Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Text
Imports System.IO

Public Class Add_New_Loan
    ' Connection string for your SQL Server
    Dim connectionString As String = "Data Source=LENOVO-GEN7\SQLEXPRESS;Initial Catalog=dbLending;Integrated Security=True;TrustServerCertificate=True"


    Private Sub btnBackToLoansList_Click(sender As Object, e As EventArgs) Handles btnBackToLoansList.Click
        Me.Close()
    End Sub

    Private Sub Add_New_Loan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' SQL query to retrieve borrower data
        Dim query As String = "
                SELECT 
                    b.BorrowerID, 
                    CONCAT(
                        n.LastName, ', ', 
                        n.FirstName, ' ', 
                        n.MiddleName, ' ', 
                        CASE 
                            WHEN n.SuffixName IS NULL OR n.SuffixName = 'NA' OR n.SuffixName = 'N/A' THEN '' 
                            ELSE n.SuffixName 
                        END
                    ) AS Name
                FROM 
                    Names n
                INNER JOIN 
                    Borrowers b ON n.NameID = b.NameID;"

        ' Create a new SQL connection
        Using connection As New SqlConnection(connectionString)
            ' Create a new SQL command
            Dim command As New SqlCommand(query, connection)

            Try
                ' Open the connection
                connection.Open()

                ' Execute the query and retrieve the data
                Dim reader As SqlDataReader = command.ExecuteReader()

                ' Loop through the results and add each name to the ComboBox
                While reader.Read()
                    ' Get the full name and BorrowerID from the query
                    Dim borrowerID As String = reader("BorrowerID").ToString()
                    Dim fullName As String = reader("Name").ToString()

                    ' Create a KeyValuePair for BorrowerID (key) and fullName (value)
                    Dim item As New KeyValuePair(Of String, String)(borrowerID, fullName)

                    ' Add the KeyValuePair to the ComboBox
                    cmbAddNewLoanBorrower.Items.Add(item)
                End While

                ' Close the reader
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub cmbAddNewLoanProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAddNewLoanProduct.SelectedIndexChanged
        Dim selectedLoanProduct As String = cmbAddNewLoanProduct.SelectedItem.ToString()
        Dim prefix As String = ""

        ' Set the prefix based on the selected loan product
        Select Case selectedLoanProduct
            Case "Education Loan"
                prefix = "EL"
            Case "General Loan"
                prefix = "GL"
            Case "Business Loan"
                prefix = "BL"
            Case "Personal Loan"
                prefix = "PL"
        End Select

        ' Generate the next LoanID based on the prefix
        Dim newLoanID As String = GenerateNextLoanID(prefix)

        ' Set the new LoanID in the txtAddNewLoanID textbox
        txtAddNewLoanID.Text = newLoanID
    End Sub

    Private Function GenerateNextLoanID(prefix As String) As String
        Dim nextLoanID As String = ""
        Dim maxLoanID As String = ""

        ' SQL query to get the highest LoanID that starts with the selected prefix
        Dim query As String = "SELECT MAX(LoanID) FROM Loans WHERE LoanID LIKE @Prefix + '%'"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Prefix", prefix)
                conn.Open()
                maxLoanID = Convert.ToString(cmd.ExecuteScalar())
            End Using
        End Using

        ' If no LoanID exists for this product, start from 1
        If String.IsNullOrEmpty(maxLoanID) Then
            nextLoanID = prefix & "00001"
        Else
            ' Extract the numeric part of the LoanID, increment it, and format the new ID
            Dim numericPart As Integer = Convert.ToInt32(maxLoanID.Substring(2)) + 1
            nextLoanID = prefix & numericPart.ToString("D5")
        End If

        Return nextLoanID
    End Function

    ' Function to calculate total loan with interest
    Private Sub CalculateLoanTotal()
        ' Get the applied amount and interest rate
        Dim appliedAmount As Decimal
        Dim interestRate As Decimal
        Dim payableFor As Integer
        Dim modeOfPayment As String
        Dim totalLoan As Decimal

        ' Validate and parse input
        If Decimal.TryParse(txtAddNewLoanAppliedAmount.Text, appliedAmount) AndAlso
       Decimal.TryParse(txtAddNewLoanInterestRate.Text, interestRate) AndAlso
       Integer.TryParse(txtAddNewLoanPayableFor.Text, payableFor) Then

            ' Get mode of payment from the combo box
            modeOfPayment = cmbAddNewLoanModeOfPayment.SelectedItem.ToString()

            ' Calculate interest per month
            Dim monthlyInterest As Decimal = (appliedAmount * interestRate) / 100

            ' Calculate total loan based on mode of payment
            Select Case modeOfPayment
                Case "Monthly"
                    totalLoan = appliedAmount + (monthlyInterest * payableFor)

                Case "Semi-Monthly"
                    ' For Semi-Monthly payments, interest is divided into two payments per month
                    Dim semiMonthlyInterest As Decimal = monthlyInterest / 2
                    totalLoan = appliedAmount + (semiMonthlyInterest * (payableFor * 2)) ' payableFor represents the number of months

                Case "Lump-Sum"
                    totalLoan = appliedAmount + monthlyInterest ' One-time payment
            End Select

            ' Display the total in the txtAddNewLoanTotal
            txtAddNewLoanTotal.Text = totalLoan.ToString("C2") ' Format as currency
        End If
    End Sub


    ' Add event handlers to call CalculateLoanTotal when inputs change
    Private Sub txtAddNewLoanAppliedAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAddNewLoanAppliedAmount.TextChanged
        CalculateLoanTotal()
    End Sub

    Private Sub txtAddNewLoanInterestRate_TextChanged(sender As Object, e As EventArgs) Handles txtAddNewLoanInterestRate.TextChanged
        CalculateLoanTotal()
    End Sub

    Private Sub txtAddNewLoanPayableFor_TextChanged(sender As Object, e As EventArgs) Handles txtAddNewLoanPayableFor.TextChanged
        CalculateLoanTotal()
    End Sub

    Private Sub cmbAddNewLoanModeOfPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAddNewLoanModeOfPayment.SelectedIndexChanged
        If cmbAddNewLoanModeOfPayment.SelectedItem = "Lump-Sum" Then
            txtAddNewLoanPayableFor.Enabled = False
            txtAddNewLoanPayableFor.Text = 1
        Else
            txtAddNewLoanPayableFor.Enabled = True
            CalculateLoanTotal()
        End If
    End Sub

    Private Sub btnAddNewLoanGenerateRepaymentSchedule_Click(sender As Object, e As EventArgs) Handles btnAddNewLoanGenerateRepaymentSchedule.Click
        ' Clear the DataGridView before generating a new schedule
        dgvRepaymentSchedule.Rows.Clear()

        ' Get values from the input fields
        Dim appliedAmount As Decimal
        Dim interestRate As Decimal
        Dim payableFor As Integer
        Dim modeOfPayment As String
        Dim firstPaymentDate As Date
        Dim monthlyInterest As Decimal
        Dim balance As Decimal

        ' Validate and parse input
        If Decimal.TryParse(txtAddNewLoanAppliedAmount.Text, appliedAmount) AndAlso
           Decimal.TryParse(txtAddNewLoanInterestRate.Text, interestRate) AndAlso
           Integer.TryParse(txtAddNewLoanPayableFor.Text, payableFor) AndAlso
           Date.TryParse(dtpAddNewLoanFirstPaymentDate.Value.ToString(), firstPaymentDate) Then

            modeOfPayment = cmbAddNewLoanModeOfPayment.SelectedItem.ToString()
            balance = appliedAmount
            monthlyInterest = (appliedAmount * interestRate / 100)

            Dim totalPayments As Integer = If(modeOfPayment = "Semi-Monthly", payableFor * 2, payableFor)

            ' Generate repayment schedule
            For i As Integer = 1 To totalPayments
                Dim paymentDate As Date = CalculateNextPaymentDate(firstPaymentDate, modeOfPayment, i)
                Dim interest As Decimal = monthlyInterest ' Monthly interest remains the same for simplicity
                Dim principalPayment As Decimal = appliedAmount / totalPayments ' Adjusted for total payments
                Dim amountToPay As Decimal = principalPayment + interest
                balance -= principalPayment

                ' Add the repayment row to the DataGridView
                dgvRepaymentSchedule.Rows.Add(paymentDate.ToString("MM/dd/yyyy"),
                                           amountToPay.ToString("C2"),
                                           principalPayment.ToString("C2"),
                                           interest.ToString("C2"),
                                           balance.ToString("C2"),
                                           "Pending")
            Next
        Else
            MessageBox.Show("Please ensure all loan details are correctly filled.")
        End If
    End Sub

    ' Function to calculate the next payment date with improved error handling for invalid dates
    Private Function CalculateNextPaymentDate(startDate As Date, modeOfPayment As String, paymentNumber As Integer) As Date
        Try
            Select Case modeOfPayment
                Case "Monthly"
                    ' Monthly payments - simply add months based on the payment number
                    Dim newDate As Date = startDate.AddMonths(paymentNumber - 1)
                    ' Validate day for the new date month (leap year handling)
                    Dim daysInMonth As Integer = DateTime.DaysInMonth(newDate.Year, newDate.Month)
                    If newDate.Day > daysInMonth Then
                        newDate = New Date(newDate.Year, newDate.Month, daysInMonth)
                    End If
                    Return newDate

                Case "Semi-Monthly"
                    ' For semi-monthly payments
                    Dim isOddPayment As Boolean = paymentNumber Mod 2 = 1 ' Odd or even payment
                    Dim monthOffset As Integer = (paymentNumber - 1) \ 2 ' How many months to add

                    If isOddPayment Then
                        ' Odd payments use the start date or monthly basis
                        If paymentNumber = 1 Then
                            Return startDate ' First payment on the starting date
                        Else
                            ' Add months for odd payment numbers
                            Dim newDate As Date = startDate.AddMonths(monthOffset)
                            Dim daysInMonth As Integer = DateTime.DaysInMonth(newDate.Year, newDate.Month)
                            If newDate.Day > daysInMonth Then
                                newDate = New Date(newDate.Year, newDate.Month, daysInMonth)
                            End If
                            Return newDate
                        End If
                    Else
                        ' Even payments: 15 days after the odd payment
                        Dim newDate As Date = startDate.AddMonths(monthOffset).AddDays(15)
                        Dim daysInMonth As Integer = DateTime.DaysInMonth(newDate.Year, newDate.Month)

                        ' If the new date exceeds the days in the month, adjust to the last valid day
                        If newDate.Day > daysInMonth Then
                            newDate = New Date(newDate.Year, newDate.Month, daysInMonth)
                        End If

                        ' Ensure the second payment doesn't create a past date (if before startDate)
                        If newDate < startDate Then
                            Return newDate.AddMonths(1) ' Skip to next month
                        Else
                            Return newDate
                        End If
                    End If

                Case "Lump-Sum"
                    ' Lump sum payments occur on the start date
                    Return startDate

                Case Else
                    ' Default case: no date change
                    Return startDate
            End Select

        Catch ex As Exception
            ' Display error details for easier debugging
            MessageBox.Show("An error occurred in CalculateNextPaymentDate: " & ex.Message & vbCrLf & "Stack Trace: " & ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Date.MinValue ' Return a default invalid date in case of error
        End Try
    End Function

    Private Sub btnAddNewLoanCollateralFileAttach_Click(sender As Object, e As EventArgs) Handles btnAddNewLoanCollateralFileAttach.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName

            Try
                ' Dispose of the existing image if present
                If picAddNewLoanCollateralImage.Image IsNot Nothing Then
                    picAddNewLoanCollateralImage.Image.Dispose()
                End If

                ' Load the new image
                picAddNewLoanCollateralImage.Image = Image.FromFile(filePath)
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If
    End Sub

    ' Function to convert the image to a base64 string
    Private Function ImageToBase64(picBox As PictureBox) As String
        If picBox.Image IsNot Nothing Then
            Using ms As New MemoryStream()
                ' Save the image to the memory stream in the format you want (e.g., PNG)
                picBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                ' Convert the byte array to a base64 string
                Return Convert.ToBase64String(ms.ToArray())
            End Using
        Else
            Return String.Empty ' Return an empty string if no image is loaded
        End If
    End Function

    Private Sub btnAddNewLoanSave_Click(sender As Object, e As EventArgs) Handles btnAddNewLoanSave.Click
        Dim loanid As String = txtAddNewLoanID.Text
        Dim loanproduct As String = If(cmbAddNewLoanProduct.SelectedItem IsNot Nothing, cmbAddNewLoanProduct.SelectedItem.ToString(), "")
        Dim loanborrowerid As String = If(cmbAddNewLoanBorrower.SelectedItem IsNot Nothing, cmbAddNewLoanBorrower.SelectedItem.ToString(), "")
        Dim loanmodeofpayment As String = If(cmbAddNewLoanModeOfPayment.SelectedItem IsNot Nothing, cmbAddNewLoanModeOfPayment.SelectedItem.ToString(), "")
        Dim loanappliedamount As String = txtAddNewLoanAppliedAmount.Text
        Dim loaninterestrate As String = txtAddNewLoanInterestRate.Text
        Dim loanfirstpaymentdate As Date = dtpAddNewLoanFirstPaymentDate.Value ' assuming you are using a datetimepicker
        Dim loanreleasedate As Date = dtpAddNewLoanReleaseDate.Value ' assuming you are using a datetimepicker
        Dim loanpayablefor As String = txtAddNewLoanPayableFor.Text
        Dim loanstatus As String = If(cmbAddNewLoanStatus.SelectedItem IsNot Nothing, cmbAddNewLoanStatus.SelectedItem.ToString(), "")

        Dim collateraltype As String = If(cmbAddNewLoanCollateralType.SelectedItem IsNot Nothing, cmbAddNewLoanCollateralType.SelectedItem.ToString(), "")
        Dim collateralestimatedvalue As String = txtAddNewLoanCollateralEstimatedValue.Text
        Dim collateraldescription As String = txtAddNewLoanCollateralDescription.Text
        Dim collateralownershipinfo As String = txtAddNewLoanCollateralOwnershipInfo.Text
        Dim collaterallocation As String = txtAddNewLoanCollateralLocation.Text
        Dim collateralcondition As String = If(cmbAddNewLoanCollateralCondition.SelectedItem IsNot Nothing, cmbAddNewLoanCollateralCondition.SelectedItem.ToString(), "")
        Dim collateralimage As String = ImageToBase64(picAddNewLoanCollateralImage)

        Dim guarantorname As String = txtAddNewLoanGuarantorName1.Text
        Dim guarantorrelationshiptoborrower As String = txtAddNewLoanGuarantorRelationshipToBorrower1.Text
        Dim guarantorcontactinfo As String = txtAddNewLoanGuarantorContactInfo1.Text
        Dim guarantoraddress As String = txtAddNewLoanGuarantorAddress1.Text
        Dim guarantoroccupation As String = txtAddNewLoanGuarantorOccupation1.Text
        Dim guarantoridreference As String = txtAddNewLoanGuarantorIDReference1.Text

        Dim guarantorname2 As String = txtAddNewLoanGuarantorName2.Text
        Dim guarantorrelationshiptoborrower2 As String = txtAddNewLoanGuarantorRelationshipToBorrower2.Text
        Dim guarantorcontactinfo2 As String = txtAddNewLoanGuarantorContactInfo2.Text
        Dim guarantoraddress2 As String = txtAddNewLoanGuarantorAddress2.Text
        Dim guarantoroccupation2 As String = txtAddNewLoanGuarantorOccupation2.Text
        Dim guarantoridreference2 As String = txtAddNewLoanGuarantorIDReference2.Text
    End Sub

    Public Sub InsertLoanCollateralAndGuarantor(ByVal loanid As String, ByVal loanproduct As String, ByVal loanborrowerid As String,
                                                ByVal loanmodeofpayment As String, ByVal loanappliedamount As String, ByVal loaninterestrate As String,
                                                ByVal loanfirstpaymentdate As Date, ByVal loanreleasedate As Date, ByVal loanpayablefor As String,
                                                ByVal loanstatus As String, ByVal collateraltype As String, ByVal collateralestimatedvalue As String,
                                                ByVal collateraldescription As String, ByVal collateralownershipinfo As String, ByVal collaterallocation As String,
                                                ByVal collateralcondition As String, ByVal collateralimage As String, ByVal guarantorname As String,
                                                ByVal guarantorrelationshiptoborrower As String, ByVal guarantorcontactinfo As String, ByVal guarantoraddress As String,
                                                ByVal guarantoroccupation As String, ByVal guarantoridreference As String, ByVal guarantorname2 As String,
                                                ByVal guarantorrelationshiptoborrower2 As String, ByVal guarantorcontactinfo2 As String, ByVal guarantoraddress2 As String,
                                                ByVal guarantoroccupation2 As String, ByVal guarantoridreference2 As String)

        ' Create a connection to SQL Server
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' SQL Transaction to ensure both inserts happen together
            Dim transaction As SqlTransaction = conn.BeginTransaction()

            Try
                Dim loanInsertQuery As String = "INSERT INTO Loans (loanid, loanproduct, loanborrowerid, loanmodeofpayment, loanappliedamount, loaninterestrate, loanfirstpaymentdate, loanreleasedate, loanpayablefor, loanstatus)" &
                                                "VALUES (@LoanID, @LoanProduct, @LoanBorrowerID, @LoanModeOfPayment, @LoanAppliedAmount, @LoanInterestRate, @LoanFirstPaymentDate, @LoanReleaseDate, @PayableFor, @LoanStatus); "

                Using cmd As New SqlCommand(loanInsertQuery, conn, transaction)
                    cmd.Parameters.AddWithValue("@LoanID", loanid)
                    cmd.Parameters.AddWithValue("@LoanProduct", loanproduct)
                    cmd.Parameters.AddWithValue("@LoanBorrowerID", loanborrowerid)
                    cmd.Parameters.AddWithValue("@LoanModeOfPayment", loanmodeofpayment)
                    cmd.Parameters.AddWithValue("@LoanAppliedAmount", loanappliedamount)
                    cmd.Parameters.AddWithValue("@LoanInterestRate", loaninterestrate)
                    cmd.Parameters.AddWithValue("@LoanFirstPaymentDate", loanfirstpaymentdate)
                    cmd.Parameters.AddWithValue("@LoanReleaseDate", loanreleasedate)
                    cmd.Parameters.AddWithValue("@LoanPayableFor", loanpayablefor)
                    cmd.Parameters.AddWithValue("@LoanStatus", loanstatus)

                    ' Execute the query and get the generated NameID
                    'nameID = Convert.ToInt32(cmd.ExecuteScalar())
                    cmd.ExecuteNonQuery()
                End Using

                ' Step 2: Insert into the collateral table using the LoanID
                Dim collateralInsertQuery As String = "INSERT INTO Collaterals (loanid, collateraltype, collateralestimatedvalue, collateraldescription, collateralownershipinfo, collaterallocation, collateralcondition, collateralimage) " &
                                                    "VALUES (@CollateralLoanID, @CollateralType, @CollateralEstimatedValue, @CollateralDescription, @CollateralOwnershipInformation, @CollateralAddress, @CollateralCondition, @CollateralImage);"

                Using cmd2 As New SqlCommand(collateralInsertQuery, conn, transaction)
                    'cmd2.Parameters.AddWithValue("@CollateralID", nameID)
                    cmd2.Parameters.AddWithValue("@CollateralLoanID", loanid)
                    cmd2.Parameters.AddWithValue("@CollateralType", collateraltype)
                    cmd2.Parameters.AddWithValue("@CollateralEstimatedValue", collateralestimatedvalue)
                    cmd2.Parameters.AddWithValue("@CollateralDescription", collateraldescription)
                    cmd2.Parameters.AddWithValue("@CollateralOwnershipInformation", collateralownershipinfo)
                    cmd2.Parameters.AddWithValue("@CollateralAddress", collaterallocation)
                    cmd2.Parameters.AddWithValue("@CollateralCondition", collateralcondition)
                    cmd2.Parameters.AddWithValue("@CollateralImage", collateralimage)

                    ' Execute the insert query
                    cmd2.ExecuteNonQuery()
                End Using

                ' Step 2: Insert into the Guarantor table using the LoanID
                Dim GuarantorInsertQuery As String = "INSERT INTO Guarantors (loanid, guarantorname, guarantorrelationshiptoborrower, guarantorcontactinfo, guarantoraddress, guarantoroccupation, guarantoridreference) " &
                                                    "VALUES (@GuarantorLoanID, @GuarantorName, @GuarantorRelationshipToBorrower, @GuarantorContactInformation, @GuarantorAddress, @GuarantorOccupation, @GuarantorIDReferenceNumber);"

                Using cmd3 As New SqlCommand(GuarantorInsertQuery, conn, transaction)
                    cmd3.Parameters.AddWithValue("@GuarantorLoanID", loanid)
                    cmd3.Parameters.AddWithValue("@GuarantorName", guarantorname)
                    cmd3.Parameters.AddWithValue("@GuarantorRelationshipToBorrower", guarantorrelationshiptoborrower)
                    cmd3.Parameters.AddWithValue("@GuarantorContactInformation", guarantorcontactinfo)
                    cmd3.Parameters.AddWithValue("@GuarantorAddress", guarantoraddress)
                    cmd3.Parameters.AddWithValue("@GuarantorOccupation", guarantoroccupation)
                    cmd3.Parameters.AddWithValue("@GuarantorIDReferenceNumber", guarantoridreference)

                    ' Execute the insert query
                    cmd3.ExecuteNonQuery()
                End Using

                ' If everything is successful, commit the transaction
                transaction.Commit()

                'MessageBox.Show("Borrower and Name added successfully!")

            Catch ex As Exception
                ' If any error occurs, roll back the transaction
                transaction.Rollback()
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
End Class