Imports System.Data.SqlClient

Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login_btn_login.Click

        Dim con As New SqlConnection("Data Source=LENOVO-GEN7\SQLEXPRESS;Initial Catalog=dbLending;Integrated Security=True;TrustServerCertificate=True")
        con.Open()
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE Username=@username AND PasswordHash=@passwordHash"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@username", login_txt_username.Text)
        cmd.Parameters.AddWithValue("@passwordHash", login_txt_password.Text)

        Dim count As Integer = Convert.ToInt64(cmd.ExecuteScalar)
        con.Close()

        If count > 0 Then
            'MessageBox.Show("Login Successfull!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Dashboard.Show()
        Else
            MessageBox.Show("Login Error")
        End If


    End Sub

    Private Sub btnCloseLogin_Click(sender As Object, e As EventArgs) Handles btnCloseLogin.Click
        Me.Close()
    End Sub
End Class
