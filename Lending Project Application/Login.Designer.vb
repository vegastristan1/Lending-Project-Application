<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.login_pic_logo = New System.Windows.Forms.PictureBox()
        Me.btnCloseLogin = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.login_btn_login = New System.Windows.Forms.Button()
        Me.login_txt_username = New System.Windows.Forms.TextBox()
        Me.login_txt_password = New System.Windows.Forms.TextBox()
        Me.login_lbl_Username = New System.Windows.Forms.Label()
        Me.login_lbl_password = New System.Windows.Forms.Label()
        Me.login_link_lbl_forget_password = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.login_pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.login_pic_logo)
        Me.Panel1.Controls.Add(Me.btnCloseLogin)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 360)
        Me.Panel1.TabIndex = 0
        '
        'login_pic_logo
        '
        Me.login_pic_logo.Image = Global.Lending_Project_Application.My.Resources.Resources.placeholder_logo_6
        Me.login_pic_logo.Location = New System.Drawing.Point(30, 35)
        Me.login_pic_logo.Name = "login_pic_logo"
        Me.login_pic_logo.Size = New System.Drawing.Size(365, 144)
        Me.login_pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.login_pic_logo.TabIndex = 8
        Me.login_pic_logo.TabStop = False
        '
        'btnCloseLogin
        '
        Me.btnCloseLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseLogin.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCloseLogin.Location = New System.Drawing.Point(396, 2)
        Me.btnCloseLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCloseLogin.Name = "btnCloseLogin"
        Me.btnCloseLogin.Size = New System.Drawing.Size(30, 30)
        Me.btnCloseLogin.TabIndex = 0
        Me.btnCloseLogin.Text = "X"
        Me.btnCloseLogin.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.login_btn_login)
        Me.Panel2.Controls.Add(Me.login_txt_username)
        Me.Panel2.Controls.Add(Me.login_txt_password)
        Me.Panel2.Controls.Add(Me.login_lbl_Username)
        Me.Panel2.Controls.Add(Me.login_lbl_password)
        Me.Panel2.Controls.Add(Me.login_link_lbl_forget_password)
        Me.Panel2.Location = New System.Drawing.Point(30, 185)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(365, 160)
        Me.Panel2.TabIndex = 7
        '
        'login_btn_login
        '
        Me.login_btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_btn_login.Location = New System.Drawing.Point(263, 106)
        Me.login_btn_login.Name = "login_btn_login"
        Me.login_btn_login.Size = New System.Drawing.Size(82, 33)
        Me.login_btn_login.TabIndex = 6
        Me.login_btn_login.Text = "Login"
        Me.login_btn_login.UseVisualStyleBackColor = True
        '
        'login_txt_username
        '
        Me.login_txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.login_txt_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_txt_username.Location = New System.Drawing.Point(141, 27)
        Me.login_txt_username.Margin = New System.Windows.Forms.Padding(2)
        Me.login_txt_username.Name = "login_txt_username"
        Me.login_txt_username.Size = New System.Drawing.Size(204, 35)
        Me.login_txt_username.TabIndex = 2
        '
        'login_txt_password
        '
        Me.login_txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.login_txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_txt_password.Location = New System.Drawing.Point(141, 66)
        Me.login_txt_password.Margin = New System.Windows.Forms.Padding(2)
        Me.login_txt_password.Name = "login_txt_password"
        Me.login_txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.login_txt_password.Size = New System.Drawing.Size(204, 35)
        Me.login_txt_password.TabIndex = 4
        '
        'login_lbl_Username
        '
        Me.login_lbl_Username.AutoSize = True
        Me.login_lbl_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_lbl_Username.Location = New System.Drawing.Point(17, 29)
        Me.login_lbl_Username.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.login_lbl_Username.Name = "login_lbl_Username"
        Me.login_lbl_Username.Size = New System.Drawing.Size(64, 29)
        Me.login_lbl_Username.TabIndex = 1
        Me.login_lbl_Username.Text = "User"
        '
        'login_lbl_password
        '
        Me.login_lbl_password.AutoSize = True
        Me.login_lbl_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_lbl_password.Location = New System.Drawing.Point(16, 66)
        Me.login_lbl_password.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.login_lbl_password.Name = "login_lbl_password"
        Me.login_lbl_password.Size = New System.Drawing.Size(120, 29)
        Me.login_lbl_password.TabIndex = 3
        Me.login_lbl_password.Text = "Password"
        '
        'login_link_lbl_forget_password
        '
        Me.login_link_lbl_forget_password.AutoSize = True
        Me.login_link_lbl_forget_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_link_lbl_forget_password.Location = New System.Drawing.Point(18, 112)
        Me.login_link_lbl_forget_password.Name = "login_link_lbl_forget_password"
        Me.login_link_lbl_forget_password.Size = New System.Drawing.Size(129, 20)
        Me.login_link_lbl_forget_password.TabIndex = 5
        Me.login_link_lbl_forget_password.TabStop = True
        Me.login_link_lbl_forget_password.Text = "Forget Password"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 360)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.login_pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCloseLogin As Button
    Friend WithEvents login_lbl_Username As Label
    Friend WithEvents login_txt_username As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents login_btn_login As Button
    Friend WithEvents login_link_lbl_forget_password As LinkLabel
    Friend WithEvents login_txt_password As TextBox
    Friend WithEvents login_lbl_password As Label
    Friend WithEvents login_pic_logo As PictureBox
End Class
