Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login_btn_login.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub btnCloseLogin_Click(sender As Object, e As EventArgs) Handles btnCloseLogin.Click
        Me.Close()
    End Sub
End Class
