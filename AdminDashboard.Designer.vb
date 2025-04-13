<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tabControlAdmin = New System.Windows.Forms.TabControl()
        Me.tabUsers = New System.Windows.Forms.TabPage()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.tabFeedback = New System.Windows.Forms.TabPage()
        Me.dgvFeedback = New System.Windows.Forms.DataGridView()
        Me.tabControlProjects = New System.Windows.Forms.TabControl()
        Me.tabProjects = New System.Windows.Forms.TabPage()
        Me.dgvProjects = New System.Windows.Forms.DataGridView()
        Me.tabTracking = New System.Windows.Forms.TabPage()
        Me.dgvProjectTracking = New System.Windows.Forms.DataGridView()
        Me.tabControlResources = New System.Windows.Forms.TabControl()
        Me.tabMaterials = New System.Windows.Forms.TabPage()
        Me.dgvMaterials = New System.Windows.Forms.DataGridView()
        Me.tabEquipment = New System.Windows.Forms.TabPage()
        Me.dgvEquipment = New System.Windows.Forms.DataGridView()
        Me.tabControlFinance = New System.Windows.Forms.TabControl()
        Me.tabFinancialRecords = New System.Windows.Forms.TabPage()
        Me.dgvFinancialRecords = New System.Windows.Forms.DataGridView()
        Me.tabpendingworks = New System.Windows.Forms.TabPage()
        Me.dgvPendingWorks = New System.Windows.Forms.DataGridView()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnRefreshPending = New System.Windows.Forms.Button()
        Me.btnCompleteTask = New System.Windows.Forms.Button()
        Me.tabControlAdmin.SuspendLayout()
        Me.tabUsers.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFeedback.SuspendLayout()
        CType(Me.dgvFeedback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControlProjects.SuspendLayout()
        Me.tabProjects.SuspendLayout()
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTracking.SuspendLayout()
        CType(Me.dgvProjectTracking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControlResources.SuspendLayout()
        Me.tabMaterials.SuspendLayout()
        CType(Me.dgvMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEquipment.SuspendLayout()
        CType(Me.dgvEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControlFinance.SuspendLayout()
        Me.tabFinancialRecords.SuspendLayout()
        CType(Me.dgvFinancialRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpendingworks.SuspendLayout()
        CType(Me.dgvPendingWorks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Elephant", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(561, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(285, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Admin Dashboard"
        '
        'tabControlAdmin
        '
        Me.tabControlAdmin.Controls.Add(Me.tabUsers)
        Me.tabControlAdmin.Controls.Add(Me.tabFeedback)
        Me.tabControlAdmin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControlAdmin.Location = New System.Drawing.Point(32, 66)
        Me.tabControlAdmin.Name = "tabControlAdmin"
        Me.tabControlAdmin.SelectedIndex = 0
        Me.tabControlAdmin.Size = New System.Drawing.Size(682, 185)
        Me.tabControlAdmin.TabIndex = 1
        '
        'tabUsers
        '
        Me.tabUsers.Controls.Add(Me.dgvUsers)
        Me.tabUsers.Location = New System.Drawing.Point(4, 37)
        Me.tabUsers.Name = "tabUsers"
        Me.tabUsers.Padding = New System.Windows.Forms.Padding(3)
        Me.tabUsers.Size = New System.Drawing.Size(674, 144)
        Me.tabUsers.TabIndex = 0
        Me.tabUsers.Text = "Users"
        Me.tabUsers.UseVisualStyleBackColor = True
        '
        'dgvUsers
        '
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(3, 0)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.RowHeadersWidth = 51
        Me.dgvUsers.RowTemplate.Height = 24
        Me.dgvUsers.Size = New System.Drawing.Size(665, 138)
        Me.dgvUsers.TabIndex = 0
        '
        'tabFeedback
        '
        Me.tabFeedback.Controls.Add(Me.dgvFeedback)
        Me.tabFeedback.Location = New System.Drawing.Point(4, 37)
        Me.tabFeedback.Name = "tabFeedback"
        Me.tabFeedback.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFeedback.Size = New System.Drawing.Size(674, 144)
        Me.tabFeedback.TabIndex = 1
        Me.tabFeedback.Text = "Feedback"
        Me.tabFeedback.UseVisualStyleBackColor = True
        '
        'dgvFeedback
        '
        Me.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFeedback.Location = New System.Drawing.Point(4, 3)
        Me.dgvFeedback.Name = "dgvFeedback"
        Me.dgvFeedback.RowHeadersWidth = 51
        Me.dgvFeedback.RowTemplate.Height = 24
        Me.dgvFeedback.Size = New System.Drawing.Size(487, 150)
        Me.dgvFeedback.TabIndex = 0
        '
        'tabControlProjects
        '
        Me.tabControlProjects.Controls.Add(Me.tabProjects)
        Me.tabControlProjects.Controls.Add(Me.tabTracking)
        Me.tabControlProjects.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControlProjects.Location = New System.Drawing.Point(776, 76)
        Me.tabControlProjects.Name = "tabControlProjects"
        Me.tabControlProjects.SelectedIndex = 0
        Me.tabControlProjects.Size = New System.Drawing.Size(687, 175)
        Me.tabControlProjects.TabIndex = 2
        '
        'tabProjects
        '
        Me.tabProjects.Controls.Add(Me.dgvProjects)
        Me.tabProjects.Location = New System.Drawing.Point(4, 37)
        Me.tabProjects.Name = "tabProjects"
        Me.tabProjects.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProjects.Size = New System.Drawing.Size(679, 134)
        Me.tabProjects.TabIndex = 0
        Me.tabProjects.Text = "Projects"
        Me.tabProjects.UseVisualStyleBackColor = True
        '
        'dgvProjects
        '
        Me.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjects.Location = New System.Drawing.Point(3, 0)
        Me.dgvProjects.Name = "dgvProjects"
        Me.dgvProjects.RowHeadersWidth = 51
        Me.dgvProjects.RowTemplate.Height = 24
        Me.dgvProjects.Size = New System.Drawing.Size(732, 128)
        Me.dgvProjects.TabIndex = 0
        '
        'tabTracking
        '
        Me.tabTracking.Controls.Add(Me.dgvProjectTracking)
        Me.tabTracking.Location = New System.Drawing.Point(4, 37)
        Me.tabTracking.Name = "tabTracking"
        Me.tabTracking.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTracking.Size = New System.Drawing.Size(679, 134)
        Me.tabTracking.TabIndex = 1
        Me.tabTracking.Text = "Project Tracking"
        Me.tabTracking.UseVisualStyleBackColor = True
        '
        'dgvProjectTracking
        '
        Me.dgvProjectTracking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjectTracking.Location = New System.Drawing.Point(9, 3)
        Me.dgvProjectTracking.Name = "dgvProjectTracking"
        Me.dgvProjectTracking.RowHeadersWidth = 51
        Me.dgvProjectTracking.RowTemplate.Height = 24
        Me.dgvProjectTracking.Size = New System.Drawing.Size(522, 125)
        Me.dgvProjectTracking.TabIndex = 0
        '
        'tabControlResources
        '
        Me.tabControlResources.Controls.Add(Me.tabMaterials)
        Me.tabControlResources.Controls.Add(Me.tabEquipment)
        Me.tabControlResources.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControlResources.Location = New System.Drawing.Point(36, 272)
        Me.tabControlResources.Name = "tabControlResources"
        Me.tabControlResources.SelectedIndex = 0
        Me.tabControlResources.Size = New System.Drawing.Size(678, 176)
        Me.tabControlResources.TabIndex = 3
        '
        'tabMaterials
        '
        Me.tabMaterials.Controls.Add(Me.dgvMaterials)
        Me.tabMaterials.Location = New System.Drawing.Point(4, 37)
        Me.tabMaterials.Name = "tabMaterials"
        Me.tabMaterials.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMaterials.Size = New System.Drawing.Size(670, 135)
        Me.tabMaterials.TabIndex = 0
        Me.tabMaterials.Text = "Materials"
        Me.tabMaterials.UseVisualStyleBackColor = True
        '
        'dgvMaterials
        '
        Me.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterials.Location = New System.Drawing.Point(0, 3)
        Me.dgvMaterials.Name = "dgvMaterials"
        Me.dgvMaterials.RowHeadersWidth = 51
        Me.dgvMaterials.RowTemplate.Height = 24
        Me.dgvMaterials.Size = New System.Drawing.Size(664, 133)
        Me.dgvMaterials.TabIndex = 0
        '
        'tabEquipment
        '
        Me.tabEquipment.Controls.Add(Me.dgvEquipment)
        Me.tabEquipment.Location = New System.Drawing.Point(4, 37)
        Me.tabEquipment.Name = "tabEquipment"
        Me.tabEquipment.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEquipment.Size = New System.Drawing.Size(670, 135)
        Me.tabEquipment.TabIndex = 1
        Me.tabEquipment.Text = "Equipment"
        Me.tabEquipment.UseVisualStyleBackColor = True
        '
        'dgvEquipment
        '
        Me.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEquipment.Location = New System.Drawing.Point(5, 0)
        Me.dgvEquipment.Name = "dgvEquipment"
        Me.dgvEquipment.RowHeadersWidth = 51
        Me.dgvEquipment.RowTemplate.Height = 24
        Me.dgvEquipment.Size = New System.Drawing.Size(487, 136)
        Me.dgvEquipment.TabIndex = 0
        '
        'tabControlFinance
        '
        Me.tabControlFinance.Controls.Add(Me.tabFinancialRecords)
        Me.tabControlFinance.Controls.Add(Me.tabpendingworks)
        Me.tabControlFinance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControlFinance.Location = New System.Drawing.Point(776, 280)
        Me.tabControlFinance.Name = "tabControlFinance"
        Me.tabControlFinance.SelectedIndex = 0
        Me.tabControlFinance.Size = New System.Drawing.Size(683, 172)
        Me.tabControlFinance.TabIndex = 4
        '
        'tabFinancialRecords
        '
        Me.tabFinancialRecords.Controls.Add(Me.dgvFinancialRecords)
        Me.tabFinancialRecords.Location = New System.Drawing.Point(4, 37)
        Me.tabFinancialRecords.Name = "tabFinancialRecords"
        Me.tabFinancialRecords.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFinancialRecords.Size = New System.Drawing.Size(675, 131)
        Me.tabFinancialRecords.TabIndex = 0
        Me.tabFinancialRecords.Text = "Financial Records"
        Me.tabFinancialRecords.UseVisualStyleBackColor = True
        '
        'dgvFinancialRecords
        '
        Me.dgvFinancialRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFinancialRecords.Location = New System.Drawing.Point(6, 6)
        Me.dgvFinancialRecords.Name = "dgvFinancialRecords"
        Me.dgvFinancialRecords.RowHeadersWidth = 51
        Me.dgvFinancialRecords.RowTemplate.Height = 24
        Me.dgvFinancialRecords.Size = New System.Drawing.Size(663, 122)
        Me.dgvFinancialRecords.TabIndex = 0
        '
        'tabpendingworks
        '
        Me.tabpendingworks.Controls.Add(Me.dgvPendingWorks)
        Me.tabpendingworks.Location = New System.Drawing.Point(4, 37)
        Me.tabpendingworks.Name = "tabpendingworks"
        Me.tabpendingworks.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpendingworks.Size = New System.Drawing.Size(675, 131)
        Me.tabpendingworks.TabIndex = 1
        Me.tabpendingworks.Text = "Pending Works"
        Me.tabpendingworks.UseVisualStyleBackColor = True
        '
        'dgvPendingWorks
        '
        Me.dgvPendingWorks.AllowUserToAddRows = False
        Me.dgvPendingWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPendingWorks.Location = New System.Drawing.Point(3, 3)
        Me.dgvPendingWorks.Name = "dgvPendingWorks"
        Me.dgvPendingWorks.ReadOnly = True
        Me.dgvPendingWorks.RowHeadersWidth = 51
        Me.dgvPendingWorks.RowTemplate.Height = 24
        Me.dgvPendingWorks.Size = New System.Drawing.Size(527, 140)
        Me.dgvPendingWorks.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.Window
        Me.btnLogout.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(1317, 470)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(176, 43)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnRefreshPending
        '
        Me.btnRefreshPending.BackColor = System.Drawing.SystemColors.Window
        Me.btnRefreshPending.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshPending.Location = New System.Drawing.Point(802, 470)
        Me.btnRefreshPending.Name = "btnRefreshPending"
        Me.btnRefreshPending.Size = New System.Drawing.Size(246, 43)
        Me.btnRefreshPending.TabIndex = 6
        Me.btnRefreshPending.Text = "Refresh Pending"
        Me.btnRefreshPending.UseVisualStyleBackColor = False
        '
        'btnCompleteTask
        '
        Me.btnCompleteTask.BackColor = System.Drawing.SystemColors.Window
        Me.btnCompleteTask.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompleteTask.Location = New System.Drawing.Point(1089, 466)
        Me.btnCompleteTask.Name = "btnCompleteTask"
        Me.btnCompleteTask.Size = New System.Drawing.Size(176, 47)
        Me.btnCompleteTask.TabIndex = 7
        Me.btnCompleteTask.Text = "Complete Task"
        Me.btnCompleteTask.UseVisualStyleBackColor = False
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1533, 547)
        Me.Controls.Add(Me.btnCompleteTask)
        Me.Controls.Add(Me.btnRefreshPending)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.tabControlFinance)
        Me.Controls.Add(Me.tabControlResources)
        Me.Controls.Add(Me.tabControlProjects)
        Me.Controls.Add(Me.tabControlAdmin)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tabControlAdmin.ResumeLayout(False)
        Me.tabUsers.ResumeLayout(False)
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFeedback.ResumeLayout(False)
        CType(Me.dgvFeedback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControlProjects.ResumeLayout(False)
        Me.tabProjects.ResumeLayout(False)
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTracking.ResumeLayout(False)
        CType(Me.dgvProjectTracking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControlResources.ResumeLayout(False)
        Me.tabMaterials.ResumeLayout(False)
        CType(Me.dgvMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEquipment.ResumeLayout(False)
        CType(Me.dgvEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControlFinance.ResumeLayout(False)
        Me.tabFinancialRecords.ResumeLayout(False)
        CType(Me.dgvFinancialRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpendingworks.ResumeLayout(False)
        CType(Me.dgvPendingWorks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents tabControlAdmin As TabControl
    Friend WithEvents tabUsers As TabPage
    Friend WithEvents tabFeedback As TabPage
    Friend WithEvents tabControlProjects As TabControl
    Friend WithEvents tabProjects As TabPage
    Friend WithEvents tabTracking As TabPage
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents tabControlResources As TabControl
    Friend WithEvents tabMaterials As TabPage
    Friend WithEvents tabEquipment As TabPage
    Friend WithEvents dgvFeedback As DataGridView
    Friend WithEvents dgvProjects As DataGridView
    Friend WithEvents dgvProjectTracking As DataGridView
    Friend WithEvents dgvMaterials As DataGridView
    Friend WithEvents dgvEquipment As DataGridView
    Friend WithEvents tabControlFinance As TabControl
    Friend WithEvents tabFinancialRecords As TabPage
    Friend WithEvents tabpendingworks As TabPage
    Friend WithEvents dgvPendingWorks As DataGridView
    Friend WithEvents dgvFinancialRecords As DataGridView
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnRefreshPending As Button
    Friend WithEvents btnCompleteTask As Button
End Class
