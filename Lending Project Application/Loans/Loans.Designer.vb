<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loans
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnSideNavLogout = New System.Windows.Forms.Button()
        Me.btnSideNavRepayments = New System.Windows.Forms.Button()
        Me.btnSideNavLoans = New System.Windows.Forms.Button()
        Me.btnSideNavBorrowers = New System.Windows.Forms.Button()
        Me.btnSideNavDashboard = New System.Windows.Forms.Button()
        Me.dgvLoanList = New System.Windows.Forms.DataGridView()
        Me.colSideLoansID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSideLoansLoanProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSideLoansBorrower = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSideLoansReleaseDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSideLoansAppliedAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSideLoansStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSideLoansAction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearchLoanList = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddLoan = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvLoanList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSideNavRepayments)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSideNavLoans)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSideNavBorrowers)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSideNavDashboard)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvLoanList)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSearchLoanList)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnAddLoan)
        Me.SplitContainer1.Size = New System.Drawing.Size(1664, 961)
        Me.SplitContainer1.SplitterDistance = 250
        Me.SplitContainer1.TabIndex = 2
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
        Me.btnSideNavLoans.BackColor = System.Drawing.Color.White
        Me.btnSideNavLoans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSideNavLoans.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSideNavLoans.FlatAppearance.BorderSize = 0
        Me.btnSideNavLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSideNavLoans.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSideNavLoans.ForeColor = System.Drawing.SystemColors.GrayText
        Me.btnSideNavLoans.Location = New System.Drawing.Point(12, 333)
        Me.btnSideNavLoans.Name = "btnSideNavLoans"
        Me.btnSideNavLoans.Size = New System.Drawing.Size(226, 52)
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
        Me.btnSideNavBorrowers.Location = New System.Drawing.Point(12, 275)
        Me.btnSideNavBorrowers.Name = "btnSideNavBorrowers"
        Me.btnSideNavBorrowers.Size = New System.Drawing.Size(226, 52)
        Me.btnSideNavBorrowers.TabIndex = 2
        Me.btnSideNavBorrowers.Text = "Borrowers"
        Me.btnSideNavBorrowers.UseVisualStyleBackColor = False
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
        'dgvLoanList
        '
        Me.dgvLoanList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLoanList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLoanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoanList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSideLoansID, Me.colSideLoansLoanProduct, Me.colSideLoansBorrower, Me.colSideLoansReleaseDate, Me.colSideLoansAppliedAmount, Me.colSideLoansStatus, Me.colSideLoansAction})
        Me.dgvLoanList.Location = New System.Drawing.Point(26, 138)
        Me.dgvLoanList.Name = "dgvLoanList"
        Me.dgvLoanList.RowHeadersVisible = False
        Me.dgvLoanList.Size = New System.Drawing.Size(1355, 811)
        Me.dgvLoanList.TabIndex = 7
        '
        'colSideLoansID
        '
        Me.colSideLoansID.HeaderText = "ID"
        Me.colSideLoansID.Name = "colSideLoansID"
        '
        'colSideLoansLoanProduct
        '
        Me.colSideLoansLoanProduct.HeaderText = "Loan Product"
        Me.colSideLoansLoanProduct.Name = "colSideLoansLoanProduct"
        '
        'colSideLoansBorrower
        '
        Me.colSideLoansBorrower.HeaderText = "Borrower"
        Me.colSideLoansBorrower.Name = "colSideLoansBorrower"
        '
        'colSideLoansReleaseDate
        '
        Me.colSideLoansReleaseDate.HeaderText = "Release Date"
        Me.colSideLoansReleaseDate.Name = "colSideLoansReleaseDate"
        '
        'colSideLoansAppliedAmount
        '
        Me.colSideLoansAppliedAmount.HeaderText = "Applied Amount"
        Me.colSideLoansAppliedAmount.Name = "colSideLoansAppliedAmount"
        '
        'colSideLoansStatus
        '
        Me.colSideLoansStatus.HeaderText = "Status"
        Me.colSideLoansStatus.Name = "colSideLoansStatus"
        '
        'colSideLoansAction
        '
        Me.colSideLoansAction.HeaderText = "Action"
        Me.colSideLoansAction.Name = "colSideLoansAction"
        '
        'txtSearchLoanList
        '
        Me.txtSearchLoanList.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchLoanList.Location = New System.Drawing.Point(26, 94)
        Me.txtSearchLoanList.Name = "txtSearchLoanList"
        Me.txtSearchLoanList.Size = New System.Drawing.Size(741, 38)
        Me.txtSearchLoanList.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 61)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Loan List"
        '
        'btnAddLoan
        '
        Me.btnAddLoan.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddLoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddLoan.ForeColor = System.Drawing.Color.White
        Me.btnAddLoan.Location = New System.Drawing.Point(1181, 86)
        Me.btnAddLoan.Name = "btnAddLoan"
        Me.btnAddLoan.Size = New System.Drawing.Size(200, 46)
        Me.btnAddLoan.TabIndex = 5
        Me.btnAddLoan.Text = "Add Loan"
        Me.btnAddLoan.UseVisualStyleBackColor = False
        '
        'Loans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1664, 961)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Loans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loans"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvLoanList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnSideNavLogout As Button
    Friend WithEvents btnSideNavRepayments As Button
    Friend WithEvents btnSideNavLoans As Button
    Friend WithEvents btnSideNavBorrowers As Button
    Friend WithEvents btnSideNavDashboard As Button
    Friend WithEvents txtSearchLoanList As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddLoan As Button
    Friend WithEvents dgvLoanList As DataGridView
    Friend WithEvents colSideLoansID As DataGridViewTextBoxColumn
    Friend WithEvents colSideLoansLoanProduct As DataGridViewTextBoxColumn
    Friend WithEvents colSideLoansBorrower As DataGridViewTextBoxColumn
    Friend WithEvents colSideLoansReleaseDate As DataGridViewTextBoxColumn
    Friend WithEvents colSideLoansAppliedAmount As DataGridViewTextBoxColumn
    Friend WithEvents colSideLoansStatus As DataGridViewTextBoxColumn
    Friend WithEvents colSideLoansAction As DataGridViewTextBoxColumn
End Class
