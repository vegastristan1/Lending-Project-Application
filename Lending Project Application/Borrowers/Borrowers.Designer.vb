<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Borrowers
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnSideNavLogout = New System.Windows.Forms.Button()
        Me.btnSideNavAccounts = New System.Windows.Forms.Button()
        Me.btnSideNavRepayments = New System.Windows.Forms.Button()
        Me.btnSideNavLoans = New System.Windows.Forms.Button()
        Me.btnSideNavBorrowers = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSideNavDashboard = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnAddNewBorrower = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colPicture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAction = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GrayText
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSideNavLogout)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSideNavAccounts)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSideNavRepayments)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSideNavLoans)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSideNavBorrowers)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSideNavDashboard)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnAddNewBorrower)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1664, 961)
        Me.SplitContainer1.SplitterDistance = 250
        Me.SplitContainer1.TabIndex = 1
        '
        'btnSideNavLogout
        '
        Me.btnSideNavLogout.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnSideNavLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSideNavLogout.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSideNavLogout.FlatAppearance.BorderSize = 0
        Me.btnSideNavLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSideNavLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSideNavLogout.ForeColor = System.Drawing.Color.White
        Me.btnSideNavLogout.Location = New System.Drawing.Point(12, 897)
        Me.btnSideNavLogout.Name = "btnSideNavLogout"
        Me.btnSideNavLogout.Size = New System.Drawing.Size(226, 52)
        Me.btnSideNavLogout.TabIndex = 6
        Me.btnSideNavLogout.Text = "Logout"
        Me.btnSideNavLogout.UseVisualStyleBackColor = False
        '
        'btnSideNavAccounts
        '
        Me.btnSideNavAccounts.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnSideNavAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSideNavAccounts.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSideNavAccounts.FlatAppearance.BorderSize = 0
        Me.btnSideNavAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSideNavAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSideNavAccounts.ForeColor = System.Drawing.Color.White
        Me.btnSideNavAccounts.Location = New System.Drawing.Point(12, 449)
        Me.btnSideNavAccounts.Name = "btnSideNavAccounts"
        Me.btnSideNavAccounts.Size = New System.Drawing.Size(226, 52)
        Me.btnSideNavAccounts.TabIndex = 5
        Me.btnSideNavAccounts.Text = "Accounts"
        Me.btnSideNavAccounts.UseVisualStyleBackColor = False
        '
        'btnSideNavRepayments
        '
        Me.btnSideNavRepayments.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnSideNavRepayments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSideNavRepayments.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSideNavRepayments.FlatAppearance.BorderSize = 0
        Me.btnSideNavRepayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSideNavRepayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSideNavRepayments.ForeColor = System.Drawing.Color.White
        Me.btnSideNavRepayments.Location = New System.Drawing.Point(12, 391)
        Me.btnSideNavRepayments.Name = "btnSideNavRepayments"
        Me.btnSideNavRepayments.Size = New System.Drawing.Size(226, 52)
        Me.btnSideNavRepayments.TabIndex = 4
        Me.btnSideNavRepayments.Text = "Repayments"
        Me.btnSideNavRepayments.UseVisualStyleBackColor = False
        '
        'btnSideNavLoans
        '
        Me.btnSideNavLoans.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnSideNavLoans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSideNavLoans.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSideNavLoans.FlatAppearance.BorderSize = 0
        Me.btnSideNavLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSideNavLoans.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSideNavLoans.ForeColor = System.Drawing.Color.White
        Me.btnSideNavLoans.Location = New System.Drawing.Point(12, 333)
        Me.btnSideNavLoans.Name = "btnSideNavLoans"
        Me.btnSideNavLoans.Size = New System.Drawing.Size(226, 52)
        Me.btnSideNavLoans.TabIndex = 3
        Me.btnSideNavLoans.Text = "Loans"
        Me.btnSideNavLoans.UseVisualStyleBackColor = False
        '
        'btnSideNavBorrowers
        '
        Me.btnSideNavBorrowers.BackColor = System.Drawing.Color.White
        Me.btnSideNavBorrowers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSideNavBorrowers.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSideNavBorrowers.FlatAppearance.BorderSize = 0
        Me.btnSideNavBorrowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSideNavBorrowers.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSideNavBorrowers.ForeColor = System.Drawing.SystemColors.GrayText
        Me.btnSideNavBorrowers.Location = New System.Drawing.Point(12, 275)
        Me.btnSideNavBorrowers.Name = "btnSideNavBorrowers"
        Me.btnSideNavBorrowers.Size = New System.Drawing.Size(226, 52)
        Me.btnSideNavBorrowers.TabIndex = 2
        Me.btnSideNavBorrowers.Text = "Borrowers"
        Me.btnSideNavBorrowers.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lending_Project_Application.My.Resources.Resources.logo_placeholder_image
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 199)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnSideNavDashboard
        '
        Me.btnSideNavDashboard.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnSideNavDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSideNavDashboard.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSideNavDashboard.FlatAppearance.BorderSize = 0
        Me.btnSideNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSideNavDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSideNavDashboard.ForeColor = System.Drawing.Color.White
        Me.btnSideNavDashboard.Location = New System.Drawing.Point(12, 217)
        Me.btnSideNavDashboard.Name = "btnSideNavDashboard"
        Me.btnSideNavDashboard.Size = New System.Drawing.Size(226, 52)
        Me.btnSideNavDashboard.TabIndex = 0
        Me.btnSideNavDashboard.Text = "Dashboard"
        Me.btnSideNavDashboard.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(26, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(741, 38)
        Me.TextBox1.TabIndex = 3
        '
        'btnAddNewBorrower
        '
        Me.btnAddNewBorrower.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddNewBorrower.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewBorrower.ForeColor = System.Drawing.Color.White
        Me.btnAddNewBorrower.Location = New System.Drawing.Point(1123, 86)
        Me.btnAddNewBorrower.Name = "btnAddNewBorrower"
        Me.btnAddNewBorrower.Size = New System.Drawing.Size(258, 46)
        Me.btnAddNewBorrower.TabIndex = 2
        Me.btnAddNewBorrower.Text = "Add New Borrower"
        Me.btnAddNewBorrower.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPicture, Me.colID, Me.colName, Me.colEmail, Me.colBalance, Me.colStatus, Me.colAction})
        Me.DataGridView1.Location = New System.Drawing.Point(26, 138)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1355, 799)
        Me.DataGridView1.TabIndex = 1
        '
        'colPicture
        '
        Me.colPicture.HeaderText = "Picture"
        Me.colPicture.MinimumWidth = 50
        Me.colPicture.Name = "colPicture"
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.MinimumWidth = 20
        Me.colID.Name = "colID"
        '
        'colName
        '
        Me.colName.HeaderText = "Name"
        Me.colName.MinimumWidth = 200
        Me.colName.Name = "colName"
        '
        'colEmail
        '
        Me.colEmail.HeaderText = "Email"
        Me.colEmail.MinimumWidth = 300
        Me.colEmail.Name = "colEmail"
        '
        'colBalance
        '
        Me.colBalance.HeaderText = "Balance"
        Me.colBalance.MinimumWidth = 200
        Me.colBalance.Name = "colBalance"
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.MinimumWidth = 80
        Me.colStatus.Name = "colStatus"
        '
        'colAction
        '
        Me.colAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colAction.HeaderText = "Action"
        Me.colAction.MinimumWidth = 100
        Me.colAction.Name = "colAction"
        Me.colAction.Width = 115
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Borrowers Lists"
        '
        'Borrowers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1664, 961)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Borrowers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borrowers"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnSideNavLogout As Button
    Friend WithEvents btnSideNavAccounts As Button
    Friend WithEvents btnSideNavRepayments As Button
    Friend WithEvents btnSideNavLoans As Button
    Friend WithEvents btnSideNavBorrowers As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSideNavDashboard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAddNewBorrower As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents colPicture As DataGridViewTextBoxColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colBalance As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colAction As DataGridViewButtonColumn
End Class
