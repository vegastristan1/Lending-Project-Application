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

        Dim query As String = "SELECT n.LastName, n.FirstName, n.MiddleName, b.HomeAddress, b.TelNo " &
                          "FROM Names n " &
                          "INNER JOIN Borrowers b ON n.NameID = b.NameID"

        Dim dt As New DataTable()

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using

        ' Bind the DataTable to the DataGridView
        DataGridView1.DataSource = dt
    End Sub

End Class