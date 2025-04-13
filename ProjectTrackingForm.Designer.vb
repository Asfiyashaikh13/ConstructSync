<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectTrackingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectTrackingForm))
        Me.lblProject = New System.Windows.Forms.Label()
        Me.lblTask = New System.Windows.Forms.Label()
        Me.lblWorker = New System.Windows.Forms.Label()
        Me.lblSupervisor = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.cmbProject = New System.Windows.Forms.ComboBox()
        Me.cmbTask = New System.Windows.Forms.ComboBox()
        Me.cmbWorker = New System.Windows.Forms.ComboBox()
        Me.cmbSupervisor = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.nudProgress = New System.Windows.Forms.NumericUpDown()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtTrackingID = New System.Windows.Forms.TextBox()
        Me.lblProjectTracking = New System.Windows.Forms.Label()
        CType(Me.nudProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProject
        '
        Me.lblProject.AutoSize = True
        Me.lblProject.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProject.Location = New System.Drawing.Point(372, 105)
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(80, 23)
        Me.lblProject.TabIndex = 0
        Me.lblProject.Text = "Projects:"
        '
        'lblTask
        '
        Me.lblTask.AutoSize = True
        Me.lblTask.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTask.Location = New System.Drawing.Point(388, 156)
        Me.lblTask.Name = "lblTask"
        Me.lblTask.Size = New System.Drawing.Size(62, 23)
        Me.lblTask.TabIndex = 1
        Me.lblTask.Text = "Tasks:"
        '
        'lblWorker
        '
        Me.lblWorker.AutoSize = True
        Me.lblWorker.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorker.Location = New System.Drawing.Point(375, 205)
        Me.lblWorker.Name = "lblWorker"
        Me.lblWorker.Size = New System.Drawing.Size(76, 23)
        Me.lblWorker.TabIndex = 2
        Me.lblWorker.Text = "Worker:"
        '
        'lblSupervisor
        '
        Me.lblSupervisor.AutoSize = True
        Me.lblSupervisor.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupervisor.Location = New System.Drawing.Point(354, 264)
        Me.lblSupervisor.Name = "lblSupervisor"
        Me.lblSupervisor.Size = New System.Drawing.Size(103, 23)
        Me.lblSupervisor.TabIndex = 3
        Me.lblSupervisor.Text = "Supervisor:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(812, 102)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(69, 23)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Status:"
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgress.Location = New System.Drawing.Point(795, 156)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(86, 23)
        Me.lblProgress.TabIndex = 5
        Me.lblProgress.Text = "Progress:"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDate.Location = New System.Drawing.Point(774, 208)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(107, 23)
        Me.lblStartDate.TabIndex = 6
        Me.lblStartDate.Text = " Start Date:"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDate.Location = New System.Drawing.Point(795, 264)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(86, 23)
        Me.lblEndDate.TabIndex = 7
        Me.lblEndDate.Text = "EndDate:"
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.Location = New System.Drawing.Point(795, 318)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(88, 23)
        Me.lblRemarks.TabIndex = 8
        Me.lblRemarks.Text = "Remarks:"
        '
        'cmbProject
        '
        Me.cmbProject.FormattingEnabled = True
        Me.cmbProject.Location = New System.Drawing.Point(458, 107)
        Me.cmbProject.Name = "cmbProject"
        Me.cmbProject.Size = New System.Drawing.Size(121, 24)
        Me.cmbProject.TabIndex = 9
        '
        'cmbTask
        '
        Me.cmbTask.FormattingEnabled = True
        Me.cmbTask.Location = New System.Drawing.Point(458, 156)
        Me.cmbTask.Name = "cmbTask"
        Me.cmbTask.Size = New System.Drawing.Size(121, 24)
        Me.cmbTask.TabIndex = 10
        '
        'cmbWorker
        '
        Me.cmbWorker.FormattingEnabled = True
        Me.cmbWorker.Location = New System.Drawing.Point(458, 207)
        Me.cmbWorker.Name = "cmbWorker"
        Me.cmbWorker.Size = New System.Drawing.Size(121, 24)
        Me.cmbWorker.TabIndex = 11
        '
        'cmbSupervisor
        '
        Me.cmbSupervisor.FormattingEnabled = True
        Me.cmbSupervisor.Location = New System.Drawing.Point(458, 263)
        Me.cmbSupervisor.Name = "cmbSupervisor"
        Me.cmbSupervisor.Size = New System.Drawing.Size(121, 24)
        Me.cmbSupervisor.TabIndex = 12
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Ongoing ", "Completed", "Pending"})
        Me.cmbStatus.Location = New System.Drawing.Point(897, 104)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(121, 24)
        Me.cmbStatus.TabIndex = 13
        '
        'nudProgress
        '
        Me.nudProgress.Location = New System.Drawing.Point(897, 156)
        Me.nudProgress.Name = "nudProgress"
        Me.nudProgress.Size = New System.Drawing.Size(120, 22)
        Me.nudProgress.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(330, 411)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(803, 135)
        Me.DataGridView1.TabIndex = 15
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(897, 209)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpStartDate.TabIndex = 16
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(905, 265)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpEndDate.TabIndex = 17
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(905, 320)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(229, 32)
        Me.txtRemarks.TabIndex = 18
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(436, 368)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(143, 37)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.White
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(661, 367)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(143, 38)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(905, 368)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(136, 37)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtTrackingID
        '
        Me.txtTrackingID.Location = New System.Drawing.Point(1061, 104)
        Me.txtTrackingID.Name = "txtTrackingID"
        Me.txtTrackingID.ReadOnly = True
        Me.txtTrackingID.Size = New System.Drawing.Size(100, 22)
        Me.txtTrackingID.TabIndex = 22
        Me.txtTrackingID.Visible = False
        '
        'lblProjectTracking
        '
        Me.lblProjectTracking.AutoSize = True
        Me.lblProjectTracking.Font = New System.Drawing.Font("Elephant", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectTracking.Location = New System.Drawing.Point(552, 26)
        Me.lblProjectTracking.Name = "lblProjectTracking"
        Me.lblProjectTracking.Size = New System.Drawing.Size(271, 37)
        Me.lblProjectTracking.TabIndex = 23
        Me.lblProjectTracking.Text = "Project Tracking"
        '
        'ProjectTrackingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1464, 563)
        Me.Controls.Add(Me.lblProjectTracking)
        Me.Controls.Add(Me.txtTrackingID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.nudProgress)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbSupervisor)
        Me.Controls.Add(Me.cmbWorker)
        Me.Controls.Add(Me.cmbTask)
        Me.Controls.Add(Me.cmbProject)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblSupervisor)
        Me.Controls.Add(Me.lblWorker)
        Me.Controls.Add(Me.lblTask)
        Me.Controls.Add(Me.lblProject)
        Me.Name = "ProjectTrackingForm"
        CType(Me.nudProgress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProject As Label
    Friend WithEvents lblTask As Label
    Friend WithEvents lblWorker As Label
    Friend WithEvents lblSupervisor As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblProgress As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblRemarks As Label
    Friend WithEvents cmbProject As ComboBox
    Friend WithEvents cmbTask As ComboBox
    Friend WithEvents cmbWorker As ComboBox
    Friend WithEvents cmbSupervisor As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents nudProgress As NumericUpDown
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtTrackingID As TextBox
    Friend WithEvents lblProjectTracking As Label
End Class
