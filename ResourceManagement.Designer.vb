<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResourceManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResourceManagement))
        Me.grpMaterials = New System.Windows.Forms.GroupBox()
        Me.btnAddMaterial = New System.Windows.Forms.Button()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblMaterialName = New System.Windows.Forms.Label()
        Me.grpEquipment = New System.Windows.Forms.GroupBox()
        Me.btnAddEquipment = New System.Windows.Forms.Button()
        Me.TxtEquipmentName = New System.Windows.Forms.TextBox()
        Me.lblEquipmentName = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.btnUpdateEquipment = New System.Windows.Forms.Button()
        Me.TxtEquipmentID = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblEquipmentID = New System.Windows.Forms.Label()
        Me.dgvMaterials = New System.Windows.Forms.DataGridView()
        Me.dgvEquipment = New System.Windows.Forms.DataGridView()
        Me.btnFinancialModule = New System.Windows.Forms.Button()
        Me.clbMaterials = New System.Windows.Forms.CheckedListBox()
        Me.clbQuantities = New System.Windows.Forms.CheckedListBox()
        Me.clbUnits = New System.Windows.Forms.CheckedListBox()
        Me.grpMaterials.SuspendLayout()
        Me.grpEquipment.SuspendLayout()
        CType(Me.dgvMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMaterials
        '
        Me.grpMaterials.BackColor = System.Drawing.Color.Transparent
        Me.grpMaterials.Controls.Add(Me.clbUnits)
        Me.grpMaterials.Controls.Add(Me.clbQuantities)
        Me.grpMaterials.Controls.Add(Me.clbMaterials)
        Me.grpMaterials.Controls.Add(Me.btnAddMaterial)
        Me.grpMaterials.Controls.Add(Me.lblUnit)
        Me.grpMaterials.Controls.Add(Me.lblQuantity)
        Me.grpMaterials.Controls.Add(Me.lblMaterialName)
        Me.grpMaterials.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMaterials.Location = New System.Drawing.Point(20, 20)
        Me.grpMaterials.Name = "grpMaterials"
        Me.grpMaterials.Size = New System.Drawing.Size(606, 229)
        Me.grpMaterials.TabIndex = 0
        Me.grpMaterials.TabStop = False
        Me.grpMaterials.Text = "Materials Management"
        '
        'btnAddMaterial
        '
        Me.btnAddMaterial.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMaterial.Location = New System.Drawing.Point(442, 177)
        Me.btnAddMaterial.Name = "btnAddMaterial"
        Me.btnAddMaterial.Size = New System.Drawing.Size(148, 37)
        Me.btnAddMaterial.TabIndex = 3
        Me.btnAddMaterial.Text = "Add Material"
        Me.btnAddMaterial.UseVisualStyleBackColor = True
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.BackColor = System.Drawing.Color.White
        Me.lblUnit.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(146, 143)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(46, 23)
        Me.lblUnit.TabIndex = 2
        Me.lblUnit.Text = "Unit"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.White
        Me.lblQuantity.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(127, 101)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(85, 23)
        Me.lblQuantity.TabIndex = 1
        Me.lblQuantity.Text = "Quantity"
        '
        'lblMaterialName
        '
        Me.lblMaterialName.AutoSize = True
        Me.lblMaterialName.BackColor = System.Drawing.Color.White
        Me.lblMaterialName.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterialName.Location = New System.Drawing.Point(92, 54)
        Me.lblMaterialName.Name = "lblMaterialName"
        Me.lblMaterialName.Size = New System.Drawing.Size(137, 23)
        Me.lblMaterialName.TabIndex = 0
        Me.lblMaterialName.Text = "Material Name"
        '
        'grpEquipment
        '
        Me.grpEquipment.BackColor = System.Drawing.Color.Transparent
        Me.grpEquipment.Controls.Add(Me.btnAddEquipment)
        Me.grpEquipment.Controls.Add(Me.TxtEquipmentName)
        Me.grpEquipment.Controls.Add(Me.lblEquipmentName)
        Me.grpEquipment.Controls.Add(Me.cmbStatus)
        Me.grpEquipment.Controls.Add(Me.btnUpdateEquipment)
        Me.grpEquipment.Controls.Add(Me.TxtEquipmentID)
        Me.grpEquipment.Controls.Add(Me.lblStatus)
        Me.grpEquipment.Controls.Add(Me.lblEquipmentID)
        Me.grpEquipment.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEquipment.Location = New System.Drawing.Point(683, 22)
        Me.grpEquipment.Name = "grpEquipment"
        Me.grpEquipment.Size = New System.Drawing.Size(606, 227)
        Me.grpEquipment.TabIndex = 2
        Me.grpEquipment.TabStop = False
        Me.grpEquipment.Text = "Equipment Management"
        '
        'btnAddEquipment
        '
        Me.btnAddEquipment.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEquipment.Location = New System.Drawing.Point(440, 175)
        Me.btnAddEquipment.Name = "btnAddEquipment"
        Me.btnAddEquipment.Size = New System.Drawing.Size(146, 35)
        Me.btnAddEquipment.TabIndex = 8
        Me.btnAddEquipment.Text = "Add Equipment"
        Me.btnAddEquipment.UseVisualStyleBackColor = True
        '
        'TxtEquipmentName
        '
        Me.TxtEquipmentName.Location = New System.Drawing.Point(247, 93)
        Me.TxtEquipmentName.Name = "TxtEquipmentName"
        Me.TxtEquipmentName.Size = New System.Drawing.Size(161, 34)
        Me.TxtEquipmentName.TabIndex = 7
        '
        'lblEquipmentName
        '
        Me.lblEquipmentName.AutoSize = True
        Me.lblEquipmentName.BackColor = System.Drawing.Color.White
        Me.lblEquipmentName.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquipmentName.Location = New System.Drawing.Point(96, 93)
        Me.lblEquipmentName.Name = "lblEquipmentName"
        Me.lblEquipmentName.Size = New System.Drawing.Size(150, 23)
        Me.lblEquipmentName.TabIndex = 6
        Me.lblEquipmentName.Text = "EquipmentName"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Available", "In Use", "Maintenance"})
        Me.cmbStatus.Location = New System.Drawing.Point(247, 130)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(161, 36)
        Me.cmbStatus.TabIndex = 5
        '
        'btnUpdateEquipment
        '
        Me.btnUpdateEquipment.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateEquipment.Location = New System.Drawing.Point(440, 134)
        Me.btnUpdateEquipment.Name = "btnUpdateEquipment"
        Me.btnUpdateEquipment.Size = New System.Drawing.Size(139, 35)
        Me.btnUpdateEquipment.TabIndex = 4
        Me.btnUpdateEquipment.Text = "Update Equipment"
        Me.btnUpdateEquipment.UseVisualStyleBackColor = True
        '
        'TxtEquipmentID
        '
        Me.TxtEquipmentID.Location = New System.Drawing.Point(247, 57)
        Me.TxtEquipmentID.Name = "TxtEquipmentID"
        Me.TxtEquipmentID.Size = New System.Drawing.Size(161, 34)
        Me.TxtEquipmentID.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(138, 133)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(64, 23)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Status"
        '
        'lblEquipmentID
        '
        Me.lblEquipmentID.AutoSize = True
        Me.lblEquipmentID.BackColor = System.Drawing.Color.White
        Me.lblEquipmentID.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquipmentID.Location = New System.Drawing.Point(108, 62)
        Me.lblEquipmentID.Name = "lblEquipmentID"
        Me.lblEquipmentID.Size = New System.Drawing.Size(124, 23)
        Me.lblEquipmentID.TabIndex = 0
        Me.lblEquipmentID.Text = "Equipment ID"
        '
        'dgvMaterials
        '
        Me.dgvMaterials.BackgroundColor = System.Drawing.Color.White
        Me.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterials.Location = New System.Drawing.Point(12, 276)
        Me.dgvMaterials.Name = "dgvMaterials"
        Me.dgvMaterials.RowHeadersWidth = 51
        Me.dgvMaterials.RowTemplate.Height = 24
        Me.dgvMaterials.Size = New System.Drawing.Size(614, 176)
        Me.dgvMaterials.TabIndex = 7
        '
        'dgvEquipment
        '
        Me.dgvEquipment.BackgroundColor = System.Drawing.Color.White
        Me.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEquipment.Location = New System.Drawing.Point(683, 276)
        Me.dgvEquipment.Name = "dgvEquipment"
        Me.dgvEquipment.RowHeadersWidth = 51
        Me.dgvEquipment.RowTemplate.Height = 24
        Me.dgvEquipment.Size = New System.Drawing.Size(606, 176)
        Me.dgvEquipment.TabIndex = 9
        '
        'btnFinancialModule
        '
        Me.btnFinancialModule.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinancialModule.Location = New System.Drawing.Point(505, 470)
        Me.btnFinancialModule.Name = "btnFinancialModule"
        Me.btnFinancialModule.Size = New System.Drawing.Size(281, 62)
        Me.btnFinancialModule.TabIndex = 10
        Me.btnFinancialModule.Text = "Finance Management"
        Me.btnFinancialModule.UseVisualStyleBackColor = True
        '
        'clbMaterials
        '
        Me.clbMaterials.FormattingEnabled = True
        Me.clbMaterials.Location = New System.Drawing.Point(253, 43)
        Me.clbMaterials.Name = "clbMaterials"
        Me.clbMaterials.Size = New System.Drawing.Size(198, 34)
        Me.clbMaterials.TabIndex = 4
        '
        'clbQuantities
        '
        Me.clbQuantities.FormattingEnabled = True
        Me.clbQuantities.Location = New System.Drawing.Point(253, 87)
        Me.clbQuantities.Name = "clbQuantities"
        Me.clbQuantities.Size = New System.Drawing.Size(198, 34)
        Me.clbQuantities.TabIndex = 5
        '
        'clbUnits
        '
        Me.clbUnits.FormattingEnabled = True
        Me.clbUnits.Location = New System.Drawing.Point(253, 134)
        Me.clbUnits.Name = "clbUnits"
        Me.clbUnits.Size = New System.Drawing.Size(198, 34)
        Me.clbUnits.TabIndex = 6
        '
        'ResourceManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1338, 553)
        Me.Controls.Add(Me.btnFinancialModule)
        Me.Controls.Add(Me.dgvEquipment)
        Me.Controls.Add(Me.dgvMaterials)
        Me.Controls.Add(Me.grpEquipment)
        Me.Controls.Add(Me.grpMaterials)
        Me.Name = "ResourceManagement"
        Me.Text = "Resource management"
        Me.grpMaterials.ResumeLayout(False)
        Me.grpMaterials.PerformLayout()
        Me.grpEquipment.ResumeLayout(False)
        Me.grpEquipment.PerformLayout()
        CType(Me.dgvMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpMaterials As GroupBox
    Friend WithEvents grpEquipment As GroupBox
    Friend WithEvents btnAddMaterial As Button
    Friend WithEvents lblUnit As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblMaterialName As Label
    Friend WithEvents dgvMaterials As DataGridView
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnUpdateEquipment As Button
    Friend WithEvents TxtEquipmentID As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblEquipmentID As Label
    Friend WithEvents dgvEquipment As DataGridView
    Friend WithEvents TxtEquipmentName As TextBox
    Friend WithEvents lblEquipmentName As Label
    Friend WithEvents btnAddEquipment As Button
    Friend WithEvents btnFinancialModule As Button
    Friend WithEvents clbUnits As CheckedListBox
    Friend WithEvents clbQuantities As CheckedListBox
    Friend WithEvents clbMaterials As CheckedListBox
End Class
