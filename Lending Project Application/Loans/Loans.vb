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

    Private Sub btnSideNavAccounts_Click(sender As Object, e As EventArgs) Handles btnSideNavAccounts.Click
        Accounts.Show()
        Me.Hide()
    End Sub

    Private Sub btnSideNavLogout_Click(sender As Object, e As EventArgs) Handles btnSideNavLogout.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddNewBorrower_Click(sender As Object, e As EventArgs) Handles btnAddNewBorrower.Click
        Add_New_Loan.Show()
        Me.Hide()
    End Sub
End Class