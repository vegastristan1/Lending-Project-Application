<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Repayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colRepaymentsRepaymentsScheduleDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRepaymentsRepaymentsAmountToPay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRepaymentsRepaymentsPrincipal = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colRepaymentsRepaymentsInterest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRepaymentsRepaymentsBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRepaymentsRepaymentsStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAddNewBorrowerSave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblPersonalInformation = New System.Windows.Forms.Label()
        Me.btnBackToRepaymentsList = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnBackToRepaymentsList)
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
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.DateTimePicker4)
        Me.Panel2.Controls.Add(Me.DateTimePicker3)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.ComboBox2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btnAddNewBorrowerSave)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.lblPersonalInformation)
        Me.Panel2.Location = New System.Drawing.Point(12, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1382, 848)
        Me.Panel2.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(706, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(667, 395)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Receipt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(426, 39)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Total Remaining Balance"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(222, 152)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(463, 38)
        Me.TextBox2.TabIndex = 48
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker4.Location = New System.Drawing.Point(15, 152)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(201, 38)
        Me.DateTimePicker4.TabIndex = 47
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(14, 76)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(201, 38)
        Me.DateTimePicker3.TabIndex = 46
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(14, 332)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(670, 38)
        Me.TextBox4.TabIndex = 43
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRepaymentsRepaymentsScheduleDate, Me.colRepaymentsRepaymentsAmountToPay, Me.colRepaymentsRepaymentsPrincipal, Me.colRepaymentsRepaymentsInterest, Me.colRepaymentsRepaymentsBalance, Me.colRepaymentsRepaymentsStatus})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 454)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1357, 337)
        Me.DataGridView1.TabIndex = 39
        '
        'colRepaymentsRepaymentsScheduleDate
        '
        Me.colRepaymentsRepaymentsScheduleDate.FillWeight = 121.8274!
        Me.colRepaymentsRepaymentsScheduleDate.HeaderText = "Date"
        Me.colRepaymentsRepaymentsScheduleDate.Name = "colRepaymentsRepaymentsScheduleDate"
        '
        'colRepaymentsRepaymentsAmountToPay
        '
        Me.colRepaymentsRepaymentsAmountToPay.FillWeight = 78.88222!
        Me.colRepaymentsRepaymentsAmountToPay.HeaderText = "Amount to Pay"
        Me.colRepaymentsRepaymentsAmountToPay.Name = "colRepaymentsRepaymentsAmountToPay"
        '
        'colRepaymentsRepaymentsPrincipal
        '
        Me.colRepaymentsRepaymentsPrincipal.FillWeight = 78.88222!
        Me.colRepaymentsRepaymentsPrincipal.HeaderText = "Principal"
        Me.colRepaymentsRepaymentsPrincipal.Name = "colRepaymentsRepaymentsPrincipal"
        '
        'colRepaymentsRepaymentsInterest
        '
        Me.colRepaymentsRepaymentsInterest.FillWeight = 106.8027!
        Me.colRepaymentsRepaymentsInterest.HeaderText = "Interest"
        Me.colRepaymentsRepaymentsInterest.Name = "colRepaymentsRepaymentsInterest"
        '
        'colRepaymentsRepaymentsBalance
        '
        Me.colRepaymentsRepaymentsBalance.FillWeight = 106.8027!
        Me.colRepaymentsRepaymentsBalance.HeaderText = "Balance"
        Me.colRepaymentsRepaymentsBalance.Name = "colRepaymentsRepaymentsBalance"
        '
        'colRepaymentsRepaymentsStatus
        '
        Me.colRepaymentsRepaymentsStatus.FillWeight = 106.8027!
        Me.colRepaymentsRepaymentsStatus.HeaderText = "Status"
        Me.colRepaymentsRepaymentsStatus.Name = "colRepaymentsRepaymentsStatus"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(350, 243)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(334, 38)
        Me.TextBox3.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(343, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 39)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Interest"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(15, 243)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(329, 38)
        Me.TextBox1.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(296, 39)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Principal Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(218, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(425, 24)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Late Penalties (It will applu if payment date is over)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 24)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Due Repayment Date"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(221, 75)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(463, 39)
        Me.ComboBox2.TabIndex = 31
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(16, 390)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(669, 10)
        Me.Panel3.TabIndex = 30
        '
        'btnAddNewBorrowerSave
        '
        Me.btnAddNewBorrowerSave.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddNewBorrowerSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewBorrowerSave.ForeColor = System.Drawing.Color.White
        Me.btnAddNewBorrowerSave.Location = New System.Drawing.Point(1222, 797)
        Me.btnAddNewBorrowerSave.Name = "btnAddNewBorrowerSave"
        Me.btnAddNewBorrowerSave.Size = New System.Drawing.Size(151, 46)
        Me.btnAddNewBorrowerSave.TabIndex = 4
        Me.btnAddNewBorrowerSave.Text = "Save"
        Me.btnAddNewBorrowerSave.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 415)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(255, 29)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Repayments Schedule"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(216, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Loan ID"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(10, 49)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(126, 24)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Payment Date"
        '
        'lblPersonalInformation
        '
        Me.lblPersonalInformation.AutoSize = True
        Me.lblPersonalInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonalInformation.Location = New System.Drawing.Point(7, 11)
        Me.lblPersonalInformation.Name = "lblPersonalInformation"
        Me.lblPersonalInformation.Size = New System.Drawing.Size(146, 29)
        Me.lblPersonalInformation.TabIndex = 1
        Me.lblPersonalInformation.Text = "Loan Details"
        '
        'btnBackToRepaymentsList
        '
        Me.btnBackToRepaymentsList.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackToRepaymentsList.Location = New System.Drawing.Point(1244, 9)
        Me.btnBackToRepaymentsList.Name = "btnBackToRepaymentsList"
        Me.btnBackToRepaymentsList.Size = New System.Drawing.Size(151, 46)
        Me.btnBackToRepaymentsList.TabIndex = 9
        Me.btnBackToRepaymentsList.Text = "Back"
        Me.btnBackToRepaymentsList.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 54)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Loan Repayment"
        '
        'Add_Repayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1405, 926)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Add_Repayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add  Repayment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents colRepaymentsRepaymentsScheduleDate As DataGridViewTextBoxColumn
    Friend WithEvents colRepaymentsRepaymentsAmountToPay As DataGridViewTextBoxColumn
    Friend WithEvents colRepaymentsRepaymentsPrincipal As DataGridViewButtonColumn
    Friend WithEvents colRepaymentsRepaymentsInterest As DataGridViewTextBoxColumn
    Friend WithEvents colRepaymentsRepaymentsBalance As DataGridViewTextBoxColumn
    Friend WithEvents colRepaymentsRepaymentsStatus As DataGridViewTextBoxColumn
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAddNewBorrowerSave As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblPersonalInformation As Label
    Friend WithEvents btnBackToRepaymentsList As Button
    Friend WithEvents Label1 As Label
End Class
