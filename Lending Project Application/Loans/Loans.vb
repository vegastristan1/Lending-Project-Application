Public Class Loans
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

    End Sub
End Class