<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkerDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WorkerDashboard))
        Me.dgvWorkerTasks = New System.Windows.Forms.DataGridView()
        Me.btnUpdateProgress = New System.Windows.Forms.Button()
        Me.btnCompleteTask = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.txtProgress = New System.Windows.Forms.TextBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpTaskDetails = New System.Windows.Forms.GroupBox()
        Me.btnProjectTrackingForm = New System.Windows.Forms.Button()
        CType(Me.dgvWorkerTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.grpTaskDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvWorkerTasks
        '
        Me.dgvWorkerTasks.BackgroundColor = System.Drawing.Color.White
        Me.dgvWorkerTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorkerTasks.Location = New System.Drawing.Point(6, 3)
        Me.dgvWorkerTasks.Name = "dgvWorkerTasks"
        Me.dgvWorkerTasks.ReadOnly = True
        Me.dgvWorkerTasks.RowHeadersWidth = 51
        Me.dgvWorkerTasks.RowTemplate.Height = 24
        Me.dgvWorkerTasks.Size = New System.Drawing.Size(1045, 150)
        Me.dgvWorkerTasks.TabIndex = 0
        '
        'btnUpdateProgress
        '
        Me.btnUpdateProgress.Location = New System.Drawing.Point(290, 143)
        Me.btnUpdateProgress.Name = "btnUpdateProgress"
        Me.btnUpdateProgress.Size = New System.Drawing.Size(234, 47)
        Me.btnUpdateProgress.TabIndex = 1
        Me.btnUpdateProgress.Text = "UpdateProgress"
        Me.btnUpdateProgress.UseVisualStyleBackColor = True
        '
        'btnCompleteTask
        '
        Me.btnCompleteTask.Location = New System.Drawing.Point(555, 143)
        Me.btnCompleteTask.Name = "btnCompleteTask"
        Me.btnCompleteTask.Size = New System.Drawing.Size(222, 47)
        Me.btnCompleteTask.TabIndex = 2
        Me.btnCompleteTask.Text = "CompleteTask"
        Me.btnCompleteTask.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(807, 143)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(224, 47)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(340, 61)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(209, 28)
        Me.lblProgress.TabIndex = 8
        Me.lblProgress.Text = "Update Progress (%):"
        '
        'txtProgress
        '
        Me.txtProgress.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProgress.Location = New System.Drawing.Point(565, 61)
        Me.txtProgress.Name = "txtProgress"
        Me.txtProgress.Size = New System.Drawing.Size(192, 30)
        Me.txtProgress.TabIndex = 11
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.dgvWorkerTasks)
        Me.pnlHeader.Location = New System.Drawing.Point(29, 53)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1051, 155)
        Me.pnlHeader.TabIndex = 13
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Elephant", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(274, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(304, 37)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Worker Dashboard"
        '
        'grpTaskDetails
        '
        Me.grpTaskDetails.BackColor = System.Drawing.Color.Transparent
        Me.grpTaskDetails.Controls.Add(Me.btnProjectTrackingForm)
        Me.grpTaskDetails.Controls.Add(Me.lblProgress)
        Me.grpTaskDetails.Controls.Add(Me.txtProgress)
        Me.grpTaskDetails.Controls.Add(Me.btnUpdateProgress)
        Me.grpTaskDetails.Controls.Add(Me.btnLogout)
        Me.grpTaskDetails.Controls.Add(Me.btnCompleteTask)
        Me.grpTaskDetails.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTaskDetails.Location = New System.Drawing.Point(35, 261)
        Me.grpTaskDetails.Name = "grpTaskDetails"
        Me.grpTaskDetails.Size = New System.Drawing.Size(1051, 211)
        Me.grpTaskDetails.TabIndex = 14
        Me.grpTaskDetails.TabStop = False
        Me.grpTaskDetails.Text = "TaskDetails"
        '
        'btnProjectTrackingForm
        '
        Me.btnProjectTrackingForm.Location = New System.Drawing.Point(22, 143)
        Me.btnProjectTrackingForm.Name = "btnProjectTrackingForm"
        Me.btnProjectTrackingForm.Size = New System.Drawing.Size(234, 47)
        Me.btnProjectTrackingForm.TabIndex = 12
        Me.btnProjectTrackingForm.Text = "Open Project Tracking"
        Me.btnProjectTrackingForm.UseVisualStyleBackColor = True
        '
        'WorkerDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1135, 576)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpTaskDetails)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "WorkerDashboard"
        Me.Text = "WorkerDashboard"
        CType(Me.dgvWorkerTasks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.grpTaskDetails.ResumeLayout(False)
        Me.grpTaskDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvWorkerTasks As DataGridView
    Friend WithEvents btnUpdateProgress As Button
    Friend WithEvents btnCompleteTask As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblProgress As Label
    Friend WithEvents txtProgress As TextBox
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpTaskDetails As GroupBox
    Friend WithEvents btnProjectTrackingForm As Button
End Class
