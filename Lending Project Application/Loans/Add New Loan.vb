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
                Case "Weekly"
                    totalLoan = appliedAmount + (monthlyInterest * (payableFor * 4)) ' Assuming 4 weeks in a month
                Case "Bi-Weekly"
                    totalLoan = appliedAmount + (monthlyInterest * (payableFor * 2)) ' Assuming 2 bi-weekly periods in a month
                Case "Semi-Monthly"
                    totalLoan = appliedAmount + (monthlyInterest * (payableFor * 2))
                Case "Quarterly"
                    totalLoan = appliedAmount + (monthlyInterest * (payableFor / 3)) ' Quarterly payments
                Case "Annually"
                    totalLoan = appliedAmount + (monthlyInterest * (payableFor / 12)) ' Annual payments
                Case "Lump-Sum"
                    totalLoan = appliedAmount + monthlyInterest ' One-time payment
                Case "Daily"
                    totalLoan = appliedAmount + (monthlyInterest * (payableFor * 30)) ' Assuming 30 days in a month
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
        CalculateLoanTotal()
    End Sub

End Class