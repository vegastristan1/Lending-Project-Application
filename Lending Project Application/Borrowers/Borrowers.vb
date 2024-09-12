Imports System.Data.SqlClient

Public Class Borrowers
    Private Sub btnSideNavDashboard_Click(sender As Object, e As EventArgs) Handles btnSideNavDashboard.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnSideNavLoans_Click(sender As Object, e As EventArgs) Handles btnSideNavLoans.Click
        Loans.Show()
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

    Private Sub btnAddNewBorrower_Click(sender As Object, e As EventArgs) Handles btnAddNewBorrower.Click
        Add_New_Borrower.Show()
        'Me.Hide()
    End Sub

    Private Sub Borrowers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBorrowersData()
    End Sub

    Private Sub LoadBorrowersData()
        Dim connectionString As String = "Data Source=LENOVO-GEN7\SQLEXPRESS;Initial Catalog=dbLending;Integrated Security=True;TrustServerCertificate=True"

        Dim query As String = "
                            SELECT 
                                b.Picture, 
                                b.BorrowerID, 
                                CONCAT(
                                    n.LastName, ', ', 
                                    n.FirstName, ' ', 
                                    n.MiddleName, ' ', 
                                    CASE 
                                        WHEN n.SuffixName IS NULL OR n.SuffixName = 'NA' OR n.SuffixName = 'N/A' THEN '' 
                                        ELSE n.SuffixName 
                                    END
                                ) AS Name, 
                                b.EmailAddress, 
                                b.HomeAddress, 
                                b.TelNo 
                            FROM 
                                Names n
                            INNER JOIN 
                                Borrowers b ON n.NameID = b.NameID;"

        Dim dt As New DataTable()

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using

        ' Disable automatic column generation
        DataGridView1.AutoGenerateColumns = False

        ' Map data from DataTable to existing DataGridView columns
        DataGridView1.Columns("colPicture").DataPropertyName = "Picture"
        DataGridView1.Columns("colID").DataPropertyName = "BorrowerID"
        DataGridView1.Columns("colName").DataPropertyName = "Name"
        DataGridView1.Columns("colEmail").DataPropertyName = "EmailAddress"
        DataGridView1.Columns("colBalance").DataPropertyName = "HomeAddress"
        DataGridView1.Columns("colStatus").DataPropertyName = "TelNo"

        ' Bind the DataTable to the DataGridView
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Ensure the click is on a button column
        If e.ColumnIndex = DataGridView1.Columns("colAction").Index AndAlso e.RowIndex >= 0 Then
            ' Handle "View" button click
            'MessageBox.Show("View button clicked for row " & e.RowIndex.ToString())
            View_Borrower.Show()

            ' You can add your "View" logic here
        ElseIf e.ColumnIndex = DataGridView1.Columns("colDelete").Index AndAlso e.RowIndex >= 0 Then
            ' Handle "Delete" button click
            Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo)

            If confirm = DialogResult.Yes Then
                ' Perform delete logic here
                DataGridView1.Rows.RemoveAt(e.RowIndex) ' For example, removing the row from the DataGridView
                MessageBox.Show("Row deleted!")
            End If
        End If
    End Sub
End Class