<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProjectForm
    Inherits System.Windows.Forms.Form

    ' Dispose method to clean up components
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

    ' Required by Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' Declare UI Controls
    Friend WithEvents lblProjectId As Label
    Friend WithEvents txtProjectId As TextBox
    Friend WithEvents lblProjectName As Label
    Friend WithEvents txtProjectName As TextBox
    Friend WithEvents lblStartDate As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents lblEndDate As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents lblBudget As Label
    Friend WithEvents txtBudget As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button

    Friend WithEvents dgvProjects As DataGridView

    ' Initialize the Form Components
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectForm))
        Me.lblProjectId = New System.Windows.Forms.Label()
        Me.txtProjectId = New System.Windows.Forms.TextBox()
        Me.lblProjectName = New System.Windows.Forms.Label()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblBudget = New System.Windows.Forms.Label()
        Me.txtBudget = New System.Windows.Forms.TextBox()
        Me.dgvProjects = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.cmbClients = New System.Windows.Forms.ComboBox()
        Me.lblProject = New System.Windows.Forms.Label()
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProjectId
        '
        Me.lblProjectId.AutoSize = True
        Me.lblProjectId.BackColor = System.Drawing.Color.White
        Me.lblProjectId.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectId.Location = New System.Drawing.Point(321, 63)
        Me.lblProjectId.Name = "lblProjectId"
        Me.lblProjectId.Size = New System.Drawing.Size(91, 23)
        Me.lblProjectId.TabIndex = 0
        Me.lblProjectId.Text = "Project ID"
        '
        'txtProjectId
        '
        Me.txtProjectId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProjectId.Location = New System.Drawing.Point(426, 63)
        Me.txtProjectId.Name = "txtProjectId"
        Me.txtProjectId.Size = New System.Drawing.Size(200, 22)
        Me.txtProjectId.TabIndex = 1
        '
        'lblProjectName
        '
        Me.lblProjectName.AutoSize = True
        Me.lblProjectName.BackColor = System.Drawing.Color.White
        Me.lblProjectName.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectName.Location = New System.Drawing.Point(290, 103)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(122, 23)
        Me.lblProjectName.TabIndex = 2
        Me.lblProjectName.Text = "Project Name"
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(426, 103)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(200, 22)
        Me.txtProjectName.TabIndex = 3
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.BackColor = System.Drawing.Color.White
        Me.lblStartDate.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDate.Location = New System.Drawing.Point(308, 142)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(97, 23)
        Me.lblStartDate.TabIndex = 4
        Me.lblStartDate.Text = "Start Date"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(426, 143)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpStartDate.TabIndex = 5
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.BackColor = System.Drawing.Color.White
        Me.lblEndDate.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDate.Location = New System.Drawing.Point(326, 183)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(86, 23)
        Me.lblEndDate.TabIndex = 6
        Me.lblEndDate.Text = "End Date"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(426, 183)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpEndDate.TabIndex = 7
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(326, 223)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(64, 23)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Status"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Pending", "Ongoing", "Completed"})
        Me.cmbStatus.Location = New System.Drawing.Point(426, 223)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(200, 24)
        Me.cmbStatus.TabIndex = 9
        '
        'lblBudget
        '
        Me.lblBudget.AutoSize = True
        Me.lblBudget.BackColor = System.Drawing.Color.White
        Me.lblBudget.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBudget.Location = New System.Drawing.Point(326, 268)
        Me.lblBudget.Name = "lblBudget"
        Me.lblBudget.Size = New System.Drawing.Size(71, 23)
        Me.lblBudget.TabIndex = 10
        Me.lblBudget.Text = "Budget"
        '
        'txtBudget
        '
        Me.txtBudget.Location = New System.Drawing.Point(426, 268)
        Me.txtBudget.Name = "txtBudget"
        Me.txtBudget.Size = New System.Drawing.Size(200, 22)
        Me.txtBudget.TabIndex = 11
        '
        'dgvProjects
        '
        Me.dgvProjects.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjects.Location = New System.Drawing.Point(107, 382)
        Me.dgvProjects.Name = "dgvProjects"
        Me.dgvProjects.RowHeadersWidth = 51
        Me.dgvProjects.RowTemplate.Height = 24
        Me.dgvProjects.Size = New System.Drawing.Size(957, 136)
        Me.dgvProjects.TabIndex = 12
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(699, 77)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 30)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(699, 117)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 30)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(699, 157)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 30)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(699, 197)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'cmbClients
        '
        Me.cmbClients.FormattingEnabled = True
        Me.cmbClients.Location = New System.Drawing.Point(699, 268)
        Me.cmbClients.Name = "cmbClients"
        Me.cmbClients.Size = New System.Drawing.Size(121, 24)
        Me.cmbClients.TabIndex = 17
        '
        'lblProject
        '
        Me.lblProject.AutoSize = True
        Me.lblProject.BackColor = System.Drawing.Color.GhostWhite
        Me.lblProject.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProject.Location = New System.Drawing.Point(19, 18)
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(142, 38)
        Me.lblProject.TabIndex = 18
        Me.lblProject.Text = "Project "
        '
        'ProjectForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1485, 575)
        Me.Controls.Add(Me.lblProject)
        Me.Controls.Add(Me.cmbClients)
        Me.Controls.Add(Me.lblProjectId)
        Me.Controls.Add(Me.txtProjectId)
        Me.Controls.Add(Me.lblProjectName)
        Me.Controls.Add(Me.txtProjectName)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.lblBudget)
        Me.Controls.Add(Me.txtBudget)
        Me.Controls.Add(Me.dgvProjects)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "ProjectForm"
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbClients As ComboBox
    Friend WithEvents lblProject As Label
End Class