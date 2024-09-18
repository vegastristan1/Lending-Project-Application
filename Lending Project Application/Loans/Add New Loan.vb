Imports System.Data.SqlClient
Imports System.Text

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
                    ' Get the full name from the "Name" column of the query
                    Dim fullName As String = reader("Name").ToString()

                    ' Add the full name to the ComboBox items
                    cmbAddNewLoanBorrower.Items.Add(fullName)
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





End Class