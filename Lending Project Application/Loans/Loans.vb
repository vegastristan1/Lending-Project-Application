Imports System.Data.SqlClient

Public Class Loans

    Dim connectionString As String = "Data Source=LENOVO-GEN7\SQLEXPRESS;Initial Catalog=dbLending;Integrated Security=True;TrustServerCertificate=True"

    Private Sub btnSideNavDashboard_Click(sender As Object, e As EventArgs) Handles btnSideNavDashboard.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnSideNavBorrowers_Click(sender As Object, e As EventArgs) Handles btnSideNavBorrowers.Click
        Borrowers.Show()
        Me.Hide()
    End Sub

    Private Sub btnSideNavRepayments_Click(sender As Object, e As EventArgs) Handles btnSideNavRepayments.Click
        Repayments.Show()
        Me.Hide()
    End Sub

    Private Sub btnSideNavLogout_Click(sender As Object, e As EventArgs) Handles btnSideNavLogout.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddLoan_Click(sender As Object, e As EventArgs) Handles btnAddLoan.Click
        Add_New_Loan.Show()
    End Sub

    Private Sub Loans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadsListData()
    End Sub

    Sub LoadsListData()
        Dim connectionString As String = "Data Source=LENOVO-GEN7\SQLEXPRESS;Initial Catalog=dbLending;Integrated Security=True;TrustServerCertificate=True"

        Dim query As String = "
                            SELECT 
                                l.LoanID, 
                                l.LoanProduct, 
                                CONCAT(
                                    n.LastName, ', ', 
                                    n.FirstName, ' ', 
                                    n.MiddleName, ' ', 
                                    CASE 
                                        WHEN n.SuffixName IS NULL OR n.SuffixName = 'NA' OR n.SuffixName = 'N/A' THEN '' 
                                        ELSE n.SuffixName 
                                    END
                                ) AS Name, 
                                l.LoanReleaseDate, 
                                l.AppliedAmount, 
                                l.LoanStatus
                            FROM 
                                Names n
                            INNER JOIN 
                                Loans l ON n.NameID = l.BorrowerID;"

        Dim dt As New DataTable()

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using

        ' Disable automatic column generation
        dgvLoanList.AutoGenerateColumns = False

        ' Map data from DataTable to existing DataGridView columns
        dgvLoanList.Columns("colSideLoansID").DataPropertyName = "LoanID"
        dgvLoanList.Columns("colSideLoansLoanProduct").DataPropertyName = "LoanProduct"
        dgvLoanList.Columns("colSideLoansBorrower").DataPropertyName = "Name"
        dgvLoanList.Columns("colSideLoansReleaseDate").DataPropertyName = "LoanReleaseDate"
        dgvLoanList.Columns("colSideLoansAppliedAmount").DataPropertyName = "AppliedAmount"
        dgvLoanList.Columns("colSideLoansStatus").DataPropertyName = "LoanStatus"

        ' Bind the DataTable to the DataGridView
        dgvLoanList.DataSource = dt
    End Sub

    Private Sub dgvLoanList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoanList.CellContentClick
        ' Ensure the click is on a button column
        If e.ColumnIndex = dgvLoanList.Columns("colSideLoansView").Index AndAlso e.RowIndex >= 0 Then
            ' Handle "View" button click

            ' Get the BorrowerID from the selected row
            Dim selectedLoanID As String = CStr(dgvLoanList.Rows(e.RowIndex).Cells("colSideLoansID").Value)

            ' Create an instance of the View_Borrower form
            Dim viewLoanDetails As New View_Loan_Detials()

            ' Pass the BorrowerID to the View_Borrower form (create a property in View_Borrower to receive it)
            viewLoanDetails.HoldLoanID = selectedLoanID

            ' Show the View_Borrower form
            viewLoanDetails.Show()

            'ElseIf e.ColumnIndex = dgvLoanList.Columns("colDelete").Index AndAlso e.RowIndex >= 0 Then
            '    Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo)

            '    If confirm = DialogResult.Yes Then
            '        dgvLoanList.Rows.RemoveAt(e.RowIndex)
            '        MessageBox.Show("Row deleted!")
            '    End If
        End If
    End Sub

    Private Sub btnSideNavLoans_Click(sender As Object, e As EventArgs) Handles btnSideNavLoans.Click
        LoadsListData()
    End Sub
End Class