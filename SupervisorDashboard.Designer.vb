<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SupervisorDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupervisorDashboard))
        Me.btnProject = New System.Windows.Forms.Button()
        Me.btnResourceManagement = New System.Windows.Forms.Button()
        Me.btnFinancialManagement = New System.Windows.Forms.Button()
        Me.dgvTasks = New System.Windows.Forms.DataGridView()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblTaskList = New System.Windows.Forms.Label()
        Me.btnProjectScheduling = New System.Windows.Forms.Button()
        Me.btnWorkerDAshboard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAssigntask = New System.Windows.Forms.Button()
        Me.btnProjectTrackingForm = New System.Windows.Forms.Button()
        CType(Me.dgvTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProject
        '
        Me.btnProject.BackColor = System.Drawing.Color.White
        Me.btnProject.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProject.Location = New System.Drawing.Point(30, 428)
        Me.btnProject.Name = "btnProject"
        Me.btnProject.Size = New System.Drawing.Size(213, 39)
        Me.btnProject.TabIndex = 0
        Me.btnProject.Text = "Project "
        Me.btnProject.UseVisualStyleBackColor = False
        '
        'btnResourceManagement
        '
        Me.btnResourceManagement.BackColor = System.Drawing.Color.White
        Me.btnResourceManagement.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResourceManagement.Location = New System.Drawing.Point(537, 426)
        Me.btnResourceManagement.Name = "btnResourceManagement"
        Me.btnResourceManagement.Size = New System.Drawing.Size(214, 41)
        Me.btnResourceManagement.TabIndex = 1
        Me.btnResourceManagement.Text = "ResourceManagement"
        Me.btnResourceManagement.UseVisualStyleBackColor = False
        '
        'btnFinancialManagement
        '
        Me.btnFinancialManagement.BackColor = System.Drawing.Color.White
        Me.btnFinancialManagement.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinancialManagement.Location = New System.Drawing.Point(783, 426)
        Me.btnFinancialManagement.Name = "btnFinancialManagement"
        Me.btnFinancialManagement.Size = New System.Drawing.Size(223, 39)
        Me.btnFinancialManagement.TabIndex = 2
        Me.btnFinancialManagement.Text = "Financial Management"
        Me.btnFinancialManagement.UseVisualStyleBackColor = False
        '
        'dgvTasks
        '
        Me.dgvTasks.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTasks.Location = New System.Drawing.Point(30, 184)
        Me.dgvTasks.Name = "dgvTasks"
        Me.dgvTasks.ReadOnly = True
        Me.dgvTasks.RowHeadersWidth = 51
        Me.dgvTasks.RowTemplate.Height = 24
        Me.dgvTasks.Size = New System.Drawing.Size(924, 184)
        Me.dgvTasks.TabIndex = 3
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(1354, 486)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(118, 61)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lblTaskList
        '
        Me.lblTaskList.AutoSize = True
        Me.lblTaskList.BackColor = System.Drawing.Color.Transparent
        Me.lblTaskList.Font = New System.Drawing.Font("Yu Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaskList.Location = New System.Drawing.Point(40, 147)
        Me.lblTaskList.Name = "lblTaskList"
        Me.lblTaskList.Size = New System.Drawing.Size(88, 23)
        Me.lblTaskList.TabIndex = 5
        Me.lblTaskList.Text = "Task List"
        '
        'btnProjectScheduling
        '
        Me.btnProjectScheduling.BackColor = System.Drawing.Color.White
        Me.btnProjectScheduling.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProjectScheduling.Location = New System.Drawing.Point(283, 428)
        Me.btnProjectScheduling.Name = "btnProjectScheduling"
        Me.btnProjectScheduling.Size = New System.Drawing.Size(223, 39)
        Me.btnProjectScheduling.TabIndex = 6
        Me.btnProjectScheduling.Text = "Project Scheduling"
        Me.btnProjectScheduling.UseVisualStyleBackColor = False
        '
        'btnWorkerDAshboard
        '
        Me.btnWorkerDAshboard.BackColor = System.Drawing.Color.White
        Me.btnWorkerDAshboard.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorkerDAshboard.Location = New System.Drawing.Point(1285, 427)
        Me.btnWorkerDAshboard.Name = "btnWorkerDAshboard"
        Me.btnWorkerDAshboard.Size = New System.Drawing.Size(214, 39)
        Me.btnWorkerDAshboard.TabIndex = 7
        Me.btnWorkerDAshboard.Text = "Worker Dashboard"
        Me.btnWorkerDAshboard.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 38)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Supervisor Dashboard"
        '
        'btnAssigntask
        '
        Me.btnAssigntask.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssigntask.Location = New System.Drawing.Point(994, 224)
        Me.btnAssigntask.Name = "btnAssigntask"
        Me.btnAssigntask.Size = New System.Drawing.Size(199, 36)
        Me.btnAssigntask.TabIndex = 9
        Me.btnAssigntask.Text = "Assign Task"
        Me.btnAssigntask.UseVisualStyleBackColor = True
        '
        'btnProjectTrackingForm
        '
        Me.btnProjectTrackingForm.BackColor = System.Drawing.Color.White
        Me.btnProjectTrackingForm.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProjectTrackingForm.Location = New System.Drawing.Point(1040, 426)
        Me.btnProjectTrackingForm.Name = "btnProjectTrackingForm"
        Me.btnProjectTrackingForm.Size = New System.Drawing.Size(221, 39)
        Me.btnProjectTrackingForm.TabIndex = 10
        Me.btnProjectTrackingForm.Text = "Project Tracking"
        Me.btnProjectTrackingForm.UseVisualStyleBackColor = False
        '
        'SupervisorDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1502, 546)
        Me.Controls.Add(Me.btnProjectTrackingForm)
        Me.Controls.Add(Me.btnAssigntask)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnWorkerDAshboard)
        Me.Controls.Add(Me.btnProjectScheduling)
        Me.Controls.Add(Me.lblTaskList)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.dgvTasks)
        Me.Controls.Add(Me.btnFinancialManagement)
        Me.Controls.Add(Me.btnResourceManagement)
        Me.Controls.Add(Me.btnProject)
        Me.Name = "SupervisorDashboard"
        Me.Text = "Supervisor Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvTasks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProject As Button
    Friend WithEvents btnResourceManagement As Button
    Friend WithEvents btnFinancialManagement As Button
    Friend WithEvents dgvTasks As DataGridView
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblTaskList As Label
    Friend WithEvents btnProjectScheduling As Button
    Friend WithEvents btnWorkerDAshboard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAssigntask As Button
    Friend WithEvents btnProjectTrackingForm As Button
End Class
