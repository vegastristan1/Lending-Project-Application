Public Class Repayments
    Private Sub btnSideNavDashboard_Click(sender As Object, e As EventArgs) Handles btnSideNavDashboard.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnSideNavBorrowers_Click(sender As Object, e As EventArgs) Handles btnSideNavBorrowers.Click
        Borrowers.Show()
        Me.Hide()
    End Sub

    Private Sub btnSideNavLoans_Click(sender As Object, e As EventArgs) Handles btnSideNavLoans.Click
        Loans.Show()
        Me.Hide()
    End Sub

    Private Sub btnSideNavLogout_Click(sender As Object, e As EventArgs) Handles btnSideNavLogout.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddNewBorrower_Click(sender As Object, e As EventArgs) Handles btnAddNewBorrower.Click
        Add_Repayment.Show()
    End Sub
End Class