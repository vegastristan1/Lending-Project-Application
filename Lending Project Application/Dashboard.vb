﻿Public Class Dashboard
    Private Sub btnSideNavBorrowers_Click(sender As Object, e As EventArgs) Handles btnSideNavBorrowers.Click
        Borrowers.Show()
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
End Class