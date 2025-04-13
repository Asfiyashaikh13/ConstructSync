<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectScheduling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectScheduling))
        Me.lblTaskID = New System.Windows.Forms.Label()
        Me.lblProject = New System.Windows.Forms.Label()
        Me.lblTaskName = New System.Windows.Forms.Label()
        Me.lblAssignedTo = New System.Windows.Forms.Label()
        Me.lblDeadline = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtTaskID = New System.Windows.Forms.TextBox()
        Me.txtTaskName = New System.Windows.Forms.TextBox()
        Me.cmbProjects = New System.Windows.Forms.ComboBox()
        Me.cmbUsers = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.dtpDeadline = New System.Windows.Forms.DateTimePicker()
        Me.btnAddTask = New System.Windows.Forms.Button()
        Me.btnUpdateTask = New System.Windows.Forms.Button()
        Me.btnDeleteTask = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvTasks = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTaskID
        '
        Me.lblTaskID.AutoSize = True
        Me.lblTaskID.BackColor = System.Drawing.Color.White
        Me.lblTaskID.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaskID.Location = New System.Drawing.Point(398, 148)
        Me.lblTaskID.Name = "lblTaskID"
        Me.lblTaskID.Size = New System.Drawing.Size(68, 23)
        Me.lblTaskID.TabIndex = 0
        Me.lblTaskID.Text = "TaskID"
        '
        'lblProject
        '
        Me.lblProject.AutoSize = True
        Me.lblProject.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProject.Location = New System.Drawing.Point(346, 198)
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(120, 23)
        Me.lblProject.TabIndex = 1
        Me.lblProject.Text = "Select Project"
        '
        'lblTaskName
        '
        Me.lblTaskName.AutoSize = True
        Me.lblTaskName.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaskName.Location = New System.Drawing.Point(367, 245)
        Me.lblTaskName.Name = "lblTaskName"
        Me.lblTaskName.Size = New System.Drawing.Size(104, 23)
        Me.lblTaskName.TabIndex = 2
        Me.lblTaskName.Text = "Task Name"
        '
        'lblAssignedTo
        '
        Me.lblAssignedTo.AutoSize = True
        Me.lblAssignedTo.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignedTo.Location = New System.Drawing.Point(362, 290)
        Me.lblAssignedTo.Name = "lblAssignedTo"
        Me.lblAssignedTo.Size = New System.Drawing.Size(111, 23)
        Me.lblAssignedTo.TabIndex = 3
        Me.lblAssignedTo.Text = "Assigned To"
        '
        'lblDeadline
        '
        Me.lblDeadline.AutoSize = True
        Me.lblDeadline.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeadline.Location = New System.Drawing.Point(617, 210)
        Me.lblDeadline.Name = "lblDeadline"
        Me.lblDeadline.Size = New System.Drawing.Size(88, 23)
        Me.lblDeadline.TabIndex = 4
        Me.lblDeadline.Text = "DeadLine"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(639, 248)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(64, 23)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Status"
        '
        'txtTaskID
        '
        Me.txtTaskID.Location = New System.Drawing.Point(482, 148)
        Me.txtTaskID.Name = "txtTaskID"
        Me.txtTaskID.Size = New System.Drawing.Size(121, 22)
        Me.txtTaskID.TabIndex = 6
        '
        'txtTaskName
        '
        Me.txtTaskName.Location = New System.Drawing.Point(482, 245)
        Me.txtTaskName.Name = "txtTaskName"
        Me.txtTaskName.Size = New System.Drawing.Size(121, 22)
        Me.txtTaskName.TabIndex = 7
        '
        'cmbProjects
        '
        Me.cmbProjects.FormattingEnabled = True
        Me.cmbProjects.Location = New System.Drawing.Point(482, 195)
        Me.cmbProjects.Name = "cmbProjects"
        Me.cmbProjects.Size = New System.Drawing.Size(121, 24)
        Me.cmbProjects.TabIndex = 8
        '
        'cmbUsers
        '
        Me.cmbUsers.FormattingEnabled = True
        Me.cmbUsers.Location = New System.Drawing.Point(482, 290)
        Me.cmbUsers.Name = "cmbUsers"
        Me.cmbUsers.Size = New System.Drawing.Size(121, 24)
        Me.cmbUsers.TabIndex = 9
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Pending", "In Progress", "Completed"})
        Me.cmbStatus.Location = New System.Drawing.Point(711, 247)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(145, 24)
        Me.cmbStatus.TabIndex = 10
        '
        'dtpDeadline
        '
        Me.dtpDeadline.Location = New System.Drawing.Point(711, 210)
        Me.dtpDeadline.Name = "dtpDeadline"
        Me.dtpDeadline.Size = New System.Drawing.Size(200, 22)
        Me.dtpDeadline.TabIndex = 11
        '
        'btnAddTask
        '
        Me.btnAddTask.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAddTask.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTask.Location = New System.Drawing.Point(962, 144)
        Me.btnAddTask.Name = "btnAddTask"
        Me.btnAddTask.Size = New System.Drawing.Size(140, 48)
        Me.btnAddTask.TabIndex = 12
        Me.btnAddTask.Text = "Add Task"
        Me.btnAddTask.UseVisualStyleBackColor = True
        '
        'btnUpdateTask
        '
        Me.btnUpdateTask.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateTask.Location = New System.Drawing.Point(962, 198)
        Me.btnUpdateTask.Name = "btnUpdateTask"
        Me.btnUpdateTask.Size = New System.Drawing.Size(140, 44)
        Me.btnUpdateTask.TabIndex = 13
        Me.btnUpdateTask.Text = "Update Task"
        Me.btnUpdateTask.UseVisualStyleBackColor = True
        '
        'btnDeleteTask
        '
        Me.btnDeleteTask.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteTask.Location = New System.Drawing.Point(962, 247)
        Me.btnDeleteTask.Name = "btnDeleteTask"
        Me.btnDeleteTask.Size = New System.Drawing.Size(140, 49)
        Me.btnDeleteTask.TabIndex = 14
        Me.btnDeleteTask.Text = "DeleteTask"
        Me.btnDeleteTask.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(962, 302)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(140, 42)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'dgvTasks
        '
        Me.dgvTasks.BackgroundColor = System.Drawing.Color.White
        Me.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTasks.Location = New System.Drawing.Point(258, 385)
        Me.dgvTasks.Name = "dgvTasks"
        Me.dgvTasks.RowHeadersWidth = 51
        Me.dgvTasks.RowTemplate.Height = 24
        Me.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTasks.Size = New System.Drawing.Size(959, 140)
        Me.dgvTasks.StandardTab = True
        Me.dgvTasks.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 38)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Project Scheduling"
        '
        'ProjectScheduling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1486, 582)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvTasks)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDeleteTask)
        Me.Controls.Add(Me.btnUpdateTask)
        Me.Controls.Add(Me.btnAddTask)
        Me.Controls.Add(Me.dtpDeadline)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbUsers)
        Me.Controls.Add(Me.cmbProjects)
        Me.Controls.Add(Me.txtTaskName)
        Me.Controls.Add(Me.txtTaskID)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblDeadline)
        Me.Controls.Add(Me.lblAssignedTo)
        Me.Controls.Add(Me.lblTaskName)
        Me.Controls.Add(Me.lblProject)
        Me.Controls.Add(Me.lblTaskID)
        Me.Name = "ProjectScheduling"
        Me.Text = "ProjectScheduling"
        CType(Me.dgvTasks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTaskID As Label
    Friend WithEvents lblProject As Label
    Friend WithEvents lblTaskName As Label
    Friend WithEvents lblAssignedTo As Label
    Friend WithEvents lblDeadline As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtTaskID As TextBox
    Friend WithEvents txtTaskName As TextBox
    Friend WithEvents cmbProjects As ComboBox
    Friend WithEvents cmbUsers As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents dtpDeadline As DateTimePicker
    Friend WithEvents btnAddTask As Button
    Friend WithEvents btnUpdateTask As Button
    Friend WithEvents btnDeleteTask As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvTasks As DataGridView
    Friend WithEvents Label1 As Label
End Class
