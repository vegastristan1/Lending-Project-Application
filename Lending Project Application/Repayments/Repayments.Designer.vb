<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Repayments
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnSideNavLogout = New System.Windows.Forms.Button()
        Me.btnSideNavAccounts = New System.Windows.Forms.Button()
        Me.btnSideNavRepayments = New System.Windows.Forms.Button()
        Me.btnSideNavLoans = New System.Windows.Forms.Button()
        Me.btnSideNavBorrowers = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSideNavDashboard = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddNewBorrower = New System.Windows.Forms.Button()
        Me.colSideRepaymentsID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSideRepaymentsLoanProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSideRepaymentsPaymentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSideRepaymentsPrincipalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSideRepaymentsInterest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSideRepaymentsLatePenalties = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSideRepaymentsTotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSideRepaymentsAction = New System.Windows.Forms.DataGridViewButtonColumn()
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
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnAddNewBorrower)
        Me.SplitContainer1.Size = New System.Drawing.Size(2496, 1063)
        Me.SplitContainer1.SplitterDistance = 375
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 3
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
        Me.btnSideNavLogout.Location = New System.Drawing.Point(18, 1380)
        Me.btnSideNavLogout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSideNavLogout.Name = "btnSideNavLogout"
        Me.btnSideNavLogout.Size = New System.Drawing.Size(339, 80)
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
        Me.btnSideNavAccounts.Location = New System.Drawing.Point(18, 691)
        Me.btnSideNavAccounts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSideNavAccounts.Name = "btnSideNavAccounts"
        Me.btnSideNavAccounts.Size = New System.Drawing.Size(339, 80)
        Me.btnSideNavAccounts.TabIndex = 5
        Me.btnSideNavAccounts.Text = "Accounts"
        Me.btnSideNavAccounts.UseVisualStyleBackColor = False
        '
        'btnSideNavRepayments
        '
        Me.btnSideNavRepayments.BackColor = System.Drawing.Color.White
        Me.btnSideNavRepayments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSideNavRepayments.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSideNavRepayments.FlatAppearance.BorderSize = 0
        Me.btnSideNavRepayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSideNavRepayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSideNavRepayments.ForeColor = System.Drawing.SystemColors.GrayText
        Me.btnSideNavRepayments.Location = New System.Drawing.Point(18, 602)
        Me.btnSideNavRepayments.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSideNavRepayments.Name = "btnSideNavRepayments"
        Me.btnSideNavRepayments.Size = New System.Drawing.Size(339, 80)
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
        Me.btnSideNavLoans.Location = New System.Drawing.Point(18, 512)
        Me.btnSideNavLoans.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSideNavLoans.Name = "btnSideNavLoans"
        Me.btnSideNavLoans.Size = New System.Drawing.Size(339, 80)
        Me.btnSideNavLoans.TabIndex = 3
        Me.btnSideNavLoans.Text = "Loans"
        Me.btnSideNavLoans.UseVisualStyleBackColor = False
        '
        'btnSideNavBorrowers
        '
        Me.btnSideNavBorrowers.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnSideNavBorrowers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSideNavBorrowers.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSideNavBorrowers.FlatAppearance.BorderSize = 0
        Me.btnSideNavBorrowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSideNavBorrowers.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSideNavBorrowers.ForeColor = System.Drawing.Color.White
        Me.btnSideNavBorrowers.Location = New System.Drawing.Point(18, 423)
        Me.btnSideNavBorrowers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSideNavBorrowers.Name = "btnSideNavBorrowers"
        Me.btnSideNavBorrowers.Size = New System.Drawing.Size(339, 80)
        Me.btnSideNavBorrowers.TabIndex = 2
        Me.btnSideNavBorrowers.Text = "Borrowers"
        Me.btnSideNavBorrowers.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lending_Project_Application.My.Resources.Resources.logo_placeholder_image
        Me.PictureBox1.Location = New System.Drawing.Point(18, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(339, 306)
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
        Me.btnSideNavDashboard.Location = New System.Drawing.Point(18, 334)
        Me.btnSideNavDashboard.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSideNavDashboard.Name = "btnSideNavDashboard"
        Me.btnSideNavDashboard.Size = New System.Drawing.Size(339, 80)
        Me.btnSideNavDashboard.TabIndex = 0
        Me.btnSideNavDashboard.Text = "Dashboard"
        Me.btnSideNavDashboard.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSideRepaymentsID, Me.colSideRepaymentsLoanProduct, Me.colSideRepaymentsPaymentDate, Me.colSideRepaymentsPrincipalAmount, Me.colSideRepaymentsInterest, Me.colSideRepaymentsLatePenalties, Me.colSideRepaymentsTotalAmount, Me.colSideRepaymentsAction})
        Me.DataGridView1.Location = New System.Drawing.Point(39, 212)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(2032, 1248)
        Me.DataGridView1.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(39, 145)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1110, 38)
        Me.TextBox1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(524, 61)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Loan Repayment List"
        '
        'btnAddNewBorrower
        '
        Me.btnAddNewBorrower.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddNewBorrower.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewBorrower.Location = New System.Drawing.Point(1772, 132)
        Me.btnAddNewBorrower.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddNewBorrower.Name = "btnAddNewBorrower"
        Me.btnAddNewBorrower.Size = New System.Drawing.Size(300, 71)
        Me.btnAddNewBorrower.TabIndex = 9
        Me.btnAddNewBorrower.Text = "Add Repayment"
        Me.btnAddNewBorrower.UseVisualStyleBackColor = False
        '
        'colSideRepaymentsID
        '
        Me.colSideRepaymentsID.HeaderText = "ID"
        Me.colSideRepaymentsID.Name = "colSideRepaymentsID"
        '
        'colSideRepaymentsLoanProduct
        '
        Me.colSideRepaymentsLoanProduct.HeaderText = "Loan Product"
        Me.colSideRepaymentsLoanProduct.Name = "colSideRepaymentsLoanProduct"
        '
        'colSideRepaymentsPaymentDate
        '
        Me.colSideRepaymentsPaymentDate.HeaderText = "Payment Date"
        Me.colSideRepaymentsPaymentDate.Name = "colSideRepaymentsPaymentDate"
        '
        'colSideRepaymentsPrincipalAmount
        '
        Me.colSideRepaymentsPrincipalAmount.HeaderText = "Principal Amount"
        Me.colSideRepaymentsPrincipalAmount.Name = "colSideRepaymentsPrincipalAmount"
        '
        'colSideRepaymentsInterest
        '
        Me.colSideRepaymentsInterest.HeaderText = "Interest"
        Me.colSideRepaymentsInterest.Name = "colSideRepaymentsInterest"
        '
        'colSideRepaymentsLatePenalties
        '
        Me.colSideRepaymentsLatePenalties.HeaderText = "Late Penalties"
        Me.colSideRepaymentsLatePenalties.Name = "colSideRepaymentsLatePenalties"
        '
        'colSideRepaymentsTotalAmount
        '
        Me.colSideRepaymentsTotalAmount.HeaderText = "Total Amount"
        Me.colSideRepaymentsTotalAmount.Name = "colSideRepaymentsTotalAmount"
        '
        'colSideRepaymentsAction
        '
        Me.colSideRepaymentsAction.HeaderText = "Action"
        Me.colSideRepaymentsAction.Name = "colSideRepaymentsAction"
        '
        'Repayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2496, 1063)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Repayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Repayments"
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddNewBorrower As Button
    Friend WithEvents colSideRepaymentsID As DataGridViewTextBoxColumn
    Friend WithEvents colSideRepaymentsLoanProduct As DataGridViewTextBoxColumn
    Friend WithEvents colSideRepaymentsPaymentDate As DataGridViewTextBoxColumn
    Friend WithEvents colSideRepaymentsPrincipalAmount As DataGridViewTextBoxColumn
    Friend WithEvents colSideRepaymentsInterest As DataGridViewTextBoxColumn
    Friend WithEvents colSideRepaymentsLatePenalties As DataGridViewTextBoxColumn
    Friend WithEvents colSideRepaymentsTotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents colSideRepaymentsAction As DataGridViewButtonColumn
End Class
