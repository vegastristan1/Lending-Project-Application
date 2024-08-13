<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_New_Loan
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colLoansRepaymentsScheduleDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLoansRepaymentsAmountToPay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLoansRepaymentsPrincipalAmount = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colLoansRepaymentsInterest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLoansRepaymentsBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLoansRepaymentsStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAddNewBorrowerSave = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblPersonalInformation = New System.Windows.Forms.Label()
        Me.btnBackToLoansList = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnBackToLoansList)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1405, 926)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.ComboBox4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.ComboBox3)
        Me.Panel2.Controls.Add(Me.ComboBox2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btnAddNewBorrowerSave)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.lblPersonalInformation)
        Me.Panel2.Location = New System.Drawing.Point(12, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1382, 847)
        Me.Panel2.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Lending_Project_Application.My.Resources.Resources.arrows_rotate_solid
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(974, 466)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(399, 46)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Generate Repayment Schedule"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(621, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(752, 383)
        Me.TabControl1.TabIndex = 44
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.TextBox8)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.TextBox7)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.TextBox6)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.TextBox5)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(744, 350)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Collateral Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(409, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(329, 323)
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(12, 289)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(391, 38)
        Me.TextBox8.TabIndex = 52
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 262)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(162, 24)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Collateral Address"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(12, 144)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(391, 38)
        Me.TextBox7.TabIndex = 50
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 117)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 24)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Value"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(12, 219)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(391, 38)
        Me.TextBox6.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 192)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 24)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Description"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(12, 69)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(391, 38)
        Me.TextBox5.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 24)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Collateral Type"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(744, 350)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Guarantor"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(13, 386)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(291, 38)
        Me.TextBox4.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 359)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(182, 24)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Payable for (Prin/Int.)"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLoansRepaymentsScheduleDate, Me.colLoansRepaymentsAmountToPay, Me.colLoansRepaymentsPrincipalAmount, Me.colLoansRepaymentsInterest, Me.colLoansRepaymentsBalance, Me.colLoansRepaymentsStatus})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 518)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1359, 272)
        Me.DataGridView1.TabIndex = 39
        '
        'colLoansRepaymentsScheduleDate
        '
        Me.colLoansRepaymentsScheduleDate.FillWeight = 152.2843!
        Me.colLoansRepaymentsScheduleDate.HeaderText = "Date"
        Me.colLoansRepaymentsScheduleDate.Name = "colLoansRepaymentsScheduleDate"
        '
        'colLoansRepaymentsAmountToPay
        '
        Me.colLoansRepaymentsAmountToPay.FillWeight = 73.85786!
        Me.colLoansRepaymentsAmountToPay.HeaderText = "Amount to Pay"
        Me.colLoansRepaymentsAmountToPay.Name = "colLoansRepaymentsAmountToPay"
        '
        'colLoansRepaymentsPrincipalAmount
        '
        Me.colLoansRepaymentsPrincipalAmount.FillWeight = 73.85786!
        Me.colLoansRepaymentsPrincipalAmount.HeaderText = "Principal Amount"
        Me.colLoansRepaymentsPrincipalAmount.Name = "colLoansRepaymentsPrincipalAmount"
        '
        'colLoansRepaymentsInterest
        '
        Me.colLoansRepaymentsInterest.HeaderText = "Interest"
        Me.colLoansRepaymentsInterest.Name = "colLoansRepaymentsInterest"
        '
        'colLoansRepaymentsBalance
        '
        Me.colLoansRepaymentsBalance.HeaderText = "Balance"
        Me.colLoansRepaymentsBalance.Name = "colLoansRepaymentsBalance"
        '
        'colLoansRepaymentsStatus
        '
        Me.colLoansRepaymentsStatus.HeaderText = "Status"
        Me.colLoansRepaymentsStatus.Name = "colLoansRepaymentsStatus"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(310, 310)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(290, 38)
        Me.DateTimePicker2.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(306, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 24)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Release Date"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(310, 235)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(290, 38)
        Me.TextBox3.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(303, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(270, 39)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Interest Rate %"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(13, 235)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(291, 38)
        Me.TextBox1.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(275, 39)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Applied Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(306, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 24)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Mode of Payment"
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(310, 151)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(290, 39)
        Me.ComboBox4.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 24)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Loan Product"
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(14, 151)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(290, 39)
        Me.ComboBox3.TabIndex = 32
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(310, 75)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(290, 39)
        Me.ComboBox2.TabIndex = 31
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(14, 443)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1355, 10)
        Me.Panel3.TabIndex = 30
        '
        'btnAddNewBorrowerSave
        '
        Me.btnAddNewBorrowerSave.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddNewBorrowerSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewBorrowerSave.ForeColor = System.Drawing.Color.White
        Me.btnAddNewBorrowerSave.Location = New System.Drawing.Point(1222, 796)
        Me.btnAddNewBorrowerSave.Name = "btnAddNewBorrowerSave"
        Me.btnAddNewBorrowerSave.Size = New System.Drawing.Size(151, 46)
        Me.btnAddNewBorrowerSave.TabIndex = 4
        Me.btnAddNewBorrowerSave.Text = "Save"
        Me.btnAddNewBorrowerSave.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(306, 359)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 24)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Status"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(310, 385)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(290, 39)
        Me.ComboBox1.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 474)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(255, 29)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Repayments Schedule"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(306, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Borrower"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(13, 310)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(291, 38)
        Me.DateTimePicker1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(14, 75)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(290, 38)
        Me.TextBox2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "First Payment Date"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(10, 48)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 24)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Loan ID"
        '
        'lblPersonalInformation
        '
        Me.lblPersonalInformation.AutoSize = True
        Me.lblPersonalInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonalInformation.Location = New System.Drawing.Point(7, 10)
        Me.lblPersonalInformation.Name = "lblPersonalInformation"
        Me.lblPersonalInformation.Size = New System.Drawing.Size(146, 29)
        Me.lblPersonalInformation.TabIndex = 1
        Me.lblPersonalInformation.Text = "Loan Details"
        '
        'btnBackToLoansList
        '
        Me.btnBackToLoansList.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackToLoansList.Location = New System.Drawing.Point(1245, 9)
        Me.btnBackToLoansList.Name = "btnBackToLoansList"
        Me.btnBackToLoansList.Size = New System.Drawing.Size(151, 46)
        Me.btnBackToLoansList.TabIndex = 9
        Me.btnBackToLoansList.Text = "Back"
        Me.btnBackToLoansList.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 54)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Add New Loan"
        '
        'Add_New_Loan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1405, 926)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Add_New_Loan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Loan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents colLoansRepaymentsScheduleDate As DataGridViewTextBoxColumn
    Friend WithEvents colLoansRepaymentsAmountToPay As DataGridViewTextBoxColumn
    Friend WithEvents colLoansRepaymentsPrincipalAmount As DataGridViewButtonColumn
    Friend WithEvents colLoansRepaymentsInterest As DataGridViewTextBoxColumn
    Friend WithEvents colLoansRepaymentsBalance As DataGridViewTextBoxColumn
    Friend WithEvents colLoansRepaymentsStatus As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAddNewBorrowerSave As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblPersonalInformation As Label
    Friend WithEvents btnBackToLoansList As Button
    Friend WithEvents Label1 As Label
End Class
