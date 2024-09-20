Imports System.Data.SqlClient

Public Class View_Loan_Details

    Public Property HoldLoanID As String

    Dim connectionString As String = "Data Source=LENOVO-GEN7\SQLEXPRESS;Initial Catalog=dbLending;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    Private Sub btnBackToLoansList_Click(sender As Object, e As EventArgs) Handles btnBackToLoansList.Click
        Me.Close()
    End Sub

    Private Sub View_Loan_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Borrower_List_comboBox_Load()
        LoadLoanDetails(HoldLoanID)
        CalculateLoanTotal()
    End Sub

    Private Sub Borrower_List_comboBox_Load()
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

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)

            Try
                connection.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim borrowerID As String = reader("BorrowerID").ToString()
                    Dim fullName As String = reader("Name").ToString()

                    Dim item As New KeyValuePair(Of String, String)(borrowerID, fullName)

                    cmbLoanDetailBorrower.Items.Add(item)
                End While

                ' Close the reader
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadLoanDetails(loanID As String)

        ' SQL Query to fetch borrower details
        ' SQL Query to fetch borrower and name details using INNER JOIN
        Dim query As String = "
            SELECT
	            l.LoanProduct,
	            l.LoanID,
                n.NameID,
                CONCAT(
                n.LastName, ', ', 
                n.FirstName, ' ', 
                n.MiddleName, ' ', 
                CASE 
                    WHEN n.SuffixName IS NULL OR n.SuffixName = 'NA' OR n.SuffixName = 'N/A' THEN '' 
                    ELSE n.SuffixName 
                END
            ) AS Name, 
                l.LoanModeOfPayment, l.LoanAppliedAmount, l.LoanInterestRate, l.LoanReleaseDate, l.LoanFirstPaymentDate, l.LoanPayableFor, l.LoanStatus,

	            -- Collateral details
                c.CollateralType,
                c.CollateralEstimatedValue,
	            c.CollateralDescription,
                c.CollateralOwnershipInformation,
                c.CollateralAddress,
	            c.CollateralCondition,

	            -- First Guarantor
	            g1.GuarantorName AS GuarantorName1,
	            g1.GuarantorRelationshipToBorrower AS GuarantorRelationshipToBorrower1,
	            g1.GuarantorContactInformation AS GuarantorContactInformation1,
	            g1.GuarantorAddress AS GuarantorAddress1,
	            g1.GuarantorOccupation AS GuarantorOccupation1,
	            g1.GuarantorIDReferenceNumber AS GuarantorIDReferenceNumber1,

	            -- Second Guarantor
	            g2.GuarantorName AS GuarantorName2,
	            g2.GuarantorRelationshipToBorrower AS GuarantorRelationshipToBorrower2,
	            g2.GuarantorContactInformation AS GuarantorContactInformation2,
	            g2.GuarantorAddress AS GuarantorAddress2,
	            g2.GuarantorOccupation AS GuarantorOccupation2,
	            g2.GuarantorIDReferenceNumber AS GuarantorIDReferenceNumber2
            FROM Loans l
            INNER JOIN Names n ON l.LoanBorrowerID = n.NameID
            LEFT JOIN Collaterals c ON l.LoanID = c.CollateralLoanID
            LEFT JOIN Guarantors g1 ON l.LoanID = g1.GuarantorLoanID AND g1.GuarantorNumber = 1 -- First Guarantor
            LEFT JOIN Guarantors g2 ON l.LoanID = g2.GuarantorLoanID AND g2.GuarantorNumber = 2 -- Second Guarantor
            WHERE l.LoanID = @LoanID;"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@LoanID", loanID)

                connection.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()


                If reader.Read() Then
                    ' Populate the TextBox and ComboBox controls with the data
                    cmbLoanDetailProduct.SelectedItem = reader("LoanProduct").ToString()
                    txtLoanDetailID.Text = reader("LoanID").ToString()

                    Dim borrowerID As String = reader("NameID").ToString()
                    'Dim fullName As String = reader("Name").ToString()
                    'Dim item As New KeyValuePair(Of String, String)(borrowerID, fullName)
                    cmbLoanDetailBorrower.SelectedIndex = reader("NameID").ToString() - 1

                    cmbLoanDetailModeOfPayment.SelectedItem = reader("LoanModeOfPayment").ToString()
                    txtLoanDetailAppliedAmount.Text = reader("LoanAppliedAmount").ToString()
                    txtLoanDetailInterestRate.Text = reader("LoanInterestRate").ToString()
                    dtpLoanDetailFirstPaymentDate.Value = Convert.ToDateTime(reader("LoanFirstPaymentDate"))
                    dtpLoanDetailReleaseDate.Value = Convert.ToDateTime(reader("LoanReleaseDate"))
                    txtLoanDetailPayableFor.Text = reader("LoanPayableFor").ToString()
                    cmbLoanDetailStatus.SelectedItem = reader("LoanStatus").ToString()

                    cmbLoanDetailCollateralType.Text = reader("CollateralType").ToString()
                    txtLoanDetailCollateralEstimatedValue.Text = reader("CollateralEstimatedValue").ToString()
                    txtLoanDetailCollateralDescription.Text = reader("CollateralDescription").ToString()
                    txtLoanDetailCollateralOwnershipInfo.Text = reader("CollateralOwnershipInformation").ToString()
                    txtLoanDetailCollateralLocation.Text = reader("CollateralAddress").ToString()
                    cmbLoanDetailCollateralCondition.Text = reader("CollateralCondition").ToString()
                    ' Load image from CollateralImage (VARBINARY(MAX))
                    Try
                        If Not IsDBNull(reader("CollateralImage")) Then
                            Dim imageData As Byte() = DirectCast(reader("CollateralImage"), Byte())

                            ' Convert Byte Array to MemoryStream
                            Using ms As New System.IO.MemoryStream(imageData)
                                ' Convert MemoryStream to Image
                                picLoanDetailCollateralImage.Image = Image.FromStream(ms)
                            End Using
                        Else
                            ' If no image in the database, load the default placeholder image
                            picLoanDetailCollateralImage.Image = Lending_Project_Application.My.Resources.Resources.collateral_placeholder
                        End If
                    Catch ex As Exception
                        ' In case of any errors, load the default placeholder image
                        picLoanDetailCollateralImage.Image = Lending_Project_Application.My.Resources.Resources.collateral_placeholder
                    End Try

                    txtLoanDetailGuarantorName1.Text = reader("GuarantorName1").ToString()
                    txtLoanDetailGuarantorRelationship1.Text = reader("GuarantorRelationshipToBorrower1").ToString()
                    txtLoanDetailGuarantorContactInfo1.Text = reader("GuarantorContactInformation1").ToString()
                    txtLoanDetailGuarantorAddress1.Text = reader("GuarantorAddress1").ToString()
                    txtLoanDetailGuarantorOccupation1.Text = reader("GuarantorOccupation1").ToString()
                    txtLoanDetailGuarantorIDReference1.Text = reader("GuarantorIDReferenceNumber1").ToString()

                    txtLoanDetailGuarantorName2.Text = reader("GuarantorName2").ToString()
                    txtLoanDetailGuarantorRelationship2.Text = reader("GuarantorRelationshipToBorrower2").ToString()
                    txtLoanDetailGuarantorContactInfo2.Text = reader("GuarantorContactInformation2").ToString()
                    txtLoanDetailGuarantorAddress2.Text = reader("GuarantorAddress2").ToString()
                    txtLoanDetailGuarantorOccupation2.Text = reader("GuarantorOccupation2").ToString()
                    txtLoanDetailGuarantorIDReference2.Text = reader("GuarantorIDReferenceNumber2").ToString()
                End If

                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub cmbLoanDetailModeOfPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoanDetailModeOfPayment.SelectedIndexChanged, txtLoanDetailAppliedAmount.TextChanged,
            txtLoanDetailInterestRate.TextChanged, txtLoanDetailPayableFor.TextChanged
        CalculateLoanTotal()
    End Sub

    Private Sub CalculateLoanTotal()
        ' Get the applied amount and interest rate
        Dim appliedAmount As Decimal
        Dim interestRate As Decimal
        Dim payableFor As Integer
        Dim modeOfPayment As String
        Dim totalLoan As Decimal

        ' Validate and parse input
        If Decimal.TryParse(txtLoanDetailAppliedAmount.Text, appliedAmount) AndAlso
           Decimal.TryParse(txtLoanDetailInterestRate.Text, interestRate) AndAlso
           Integer.TryParse(txtLoanDetailPayableFor.Text, payableFor) Then

            ' Get mode of payment from the combo box
            modeOfPayment = cmbLoanDetailModeOfPayment.SelectedItem.ToString()

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
            txtLoanDetailTotal.Text = totalLoan.ToString("C2") ' Format as currency
        End If
    End Sub
End Class