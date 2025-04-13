<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FinancialManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinancialManagement))
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dgvFinancialRecords = New System.Windows.Forms.DataGridView()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.btnGoToResource = New System.Windows.Forms.Button()
        Me.lblFinancialManagement = New System.Windows.Forms.Label()
        CType(Me.dgvFinancialRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(158, 85)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(86, 23)
        Me.lblCategory.TabIndex = 0
        Me.lblCategory.Text = "Category"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(158, 128)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(78, 23)
        Me.lblAmount.TabIndex = 1
        Me.lblAmount.Text = "Amount"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(723, 79)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(51, 23)
        Me.lblType.TabIndex = 2
        Me.lblType.Text = "Type"
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(257, 85)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(183, 25)
        Me.txtCategory.TabIndex = 3
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(257, 129)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(183, 25)
        Me.txtAmount.TabIndex = 4
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Expense", "Budget"})
        Me.cmbType.Location = New System.Drawing.Point(797, 77)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(200, 25)
        Me.cmbType.TabIndex = 5
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(726, 116)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(50, 23)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Date"
        '
        'dgvFinancialRecords
        '
        Me.dgvFinancialRecords.BackgroundColor = System.Drawing.Color.White
        Me.dgvFinancialRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFinancialRecords.Location = New System.Drawing.Point(40, 197)
        Me.dgvFinancialRecords.Name = "dgvFinancialRecords"
        Me.dgvFinancialRecords.RowHeadersWidth = 51
        Me.dgvFinancialRecords.RowTemplate.Height = 24
        Me.dgvFinancialRecords.Size = New System.Drawing.Size(502, 111)
        Me.dgvFinancialRecords.TabIndex = 7
        '
        'dgvReport
        '
        Me.dgvReport.BackgroundColor = System.Drawing.Color.White
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(573, 197)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.RowHeadersWidth = 51
        Me.dgvReport.RowTemplate.Height = 24
        Me.dgvReport.Size = New System.Drawing.Size(558, 111)
        Me.dgvReport.TabIndex = 8
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(797, 114)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 25)
        Me.dtpDate.TabIndex = 9
        '
        'btnAddRecord
        '
        Me.btnAddRecord.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRecord.Location = New System.Drawing.Point(179, 327)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(196, 48)
        Me.btnAddRecord.TabIndex = 10
        Me.btnAddRecord.Text = "Add Record"
        Me.btnAddRecord.UseVisualStyleBackColor = True
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateReport.Location = New System.Drawing.Point(727, 327)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(192, 48)
        Me.btnGenerateReport.TabIndex = 11
        Me.btnGenerateReport.Text = "Generate Report"
        Me.btnGenerateReport.UseVisualStyleBackColor = True
        '
        'btnGoToResource
        '
        Me.btnGoToResource.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToResource.Location = New System.Drawing.Point(906, 417)
        Me.btnGoToResource.Name = "btnGoToResource"
        Me.btnGoToResource.Size = New System.Drawing.Size(253, 49)
        Me.btnGoToResource.TabIndex = 12
        Me.btnGoToResource.Text = "Back to Resources"
        Me.btnGoToResource.UseVisualStyleBackColor = True
        '
        'lblFinancialManagement
        '
        Me.lblFinancialManagement.AutoSize = True
        Me.lblFinancialManagement.Font = New System.Drawing.Font("Elephant", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinancialManagement.Location = New System.Drawing.Point(448, 9)
        Me.lblFinancialManagement.Name = "lblFinancialManagement"
        Me.lblFinancialManagement.Size = New System.Drawing.Size(349, 35)
        Me.lblFinancialManagement.TabIndex = 13
        Me.lblFinancialManagement.Text = "Financial Management"
        '
        'FinancialManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1190, 478)
        Me.Controls.Add(Me.lblFinancialManagement)
        Me.Controls.Add(Me.btnGoToResource)
        Me.Controls.Add(Me.btnGenerateReport)
        Me.Controls.Add(Me.btnAddRecord)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.dgvFinancialRecords)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblCategory)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FinancialManagement"
        Me.Text = "Financial Management"
        CType(Me.dgvFinancialRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCategory As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblType As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents lblDate As Label
    Friend WithEvents dgvFinancialRecords As DataGridView
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnAddRecord As Button
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents btnGoToResource As Button
    Friend WithEvents lblFinancialManagement As Label
End Class
