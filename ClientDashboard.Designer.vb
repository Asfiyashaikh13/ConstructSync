<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClientDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientDashboard))
        Me.gbProjectProgress = New System.Windows.Forms.GroupBox()
        Me.dgvProjectProgress = New System.Windows.Forms.DataGridView()
        Me.grpFinancialSummary = New System.Windows.Forms.GroupBox()
        Me.dgvFinancialSummary = New System.Windows.Forms.DataGridView()
        Me.gbFeedback = New System.Windows.Forms.GroupBox()
        Me.btnSubmitFeedback = New System.Windows.Forms.Button()
        Me.cmbRating = New System.Windows.Forms.ComboBox()
        Me.txtFeedback = New System.Windows.Forms.TextBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.grpProjectDetails = New System.Windows.Forms.GroupBox()
        Me.dgvProjectDetails = New System.Windows.Forms.DataGridView()
        Me.grpAssignedTasks = New System.Windows.Forms.GroupBox()
        Me.dgvAssignedTasks = New System.Windows.Forms.DataGridView()
        Me.gbProjectProgress.SuspendLayout()
        CType(Me.dgvProjectProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFinancialSummary.SuspendLayout()
        CType(Me.dgvFinancialSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFeedback.SuspendLayout()
        Me.grpProjectDetails.SuspendLayout()
        CType(Me.dgvProjectDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAssignedTasks.SuspendLayout()
        CType(Me.dgvAssignedTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbProjectProgress
        '
        Me.gbProjectProgress.BackColor = System.Drawing.Color.White
        Me.gbProjectProgress.Controls.Add(Me.dgvProjectProgress)
        Me.gbProjectProgress.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProjectProgress.Location = New System.Drawing.Point(22, 12)
        Me.gbProjectProgress.Name = "gbProjectProgress"
        Me.gbProjectProgress.Size = New System.Drawing.Size(693, 111)
        Me.gbProjectProgress.TabIndex = 0
        Me.gbProjectProgress.TabStop = False
        Me.gbProjectProgress.Text = "ProjectProgress"
        '
        'dgvProjectProgress
        '
        Me.dgvProjectProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjectProgress.Location = New System.Drawing.Point(6, 21)
        Me.dgvProjectProgress.Name = "dgvProjectProgress"
        Me.dgvProjectProgress.RowHeadersWidth = 51
        Me.dgvProjectProgress.RowTemplate.Height = 24
        Me.dgvProjectProgress.Size = New System.Drawing.Size(681, 84)
        Me.dgvProjectProgress.TabIndex = 0
        '
        'grpFinancialSummary
        '
        Me.grpFinancialSummary.BackColor = System.Drawing.Color.White
        Me.grpFinancialSummary.Controls.Add(Me.dgvFinancialSummary)
        Me.grpFinancialSummary.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFinancialSummary.Location = New System.Drawing.Point(28, 129)
        Me.grpFinancialSummary.Name = "grpFinancialSummary"
        Me.grpFinancialSummary.Size = New System.Drawing.Size(687, 142)
        Me.grpFinancialSummary.TabIndex = 1
        Me.grpFinancialSummary.TabStop = False
        Me.grpFinancialSummary.Text = "FinancialSummary"
        '
        'dgvFinancialSummary
        '
        Me.dgvFinancialSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFinancialSummary.Location = New System.Drawing.Point(9, 24)
        Me.dgvFinancialSummary.Name = "dgvFinancialSummary"
        Me.dgvFinancialSummary.RowHeadersWidth = 51
        Me.dgvFinancialSummary.RowTemplate.Height = 24
        Me.dgvFinancialSummary.Size = New System.Drawing.Size(672, 112)
        Me.dgvFinancialSummary.TabIndex = 0
        '
        'gbFeedback
        '
        Me.gbFeedback.BackColor = System.Drawing.Color.White
        Me.gbFeedback.Controls.Add(Me.btnSubmitFeedback)
        Me.gbFeedback.Controls.Add(Me.cmbRating)
        Me.gbFeedback.Controls.Add(Me.txtFeedback)
        Me.gbFeedback.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFeedback.Location = New System.Drawing.Point(797, 33)
        Me.gbFeedback.Name = "gbFeedback"
        Me.gbFeedback.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gbFeedback.Size = New System.Drawing.Size(580, 134)
        Me.gbFeedback.TabIndex = 2
        Me.gbFeedback.TabStop = False
        Me.gbFeedback.Text = "Feedback"
        '
        'btnSubmitFeedback
        '
        Me.btnSubmitFeedback.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitFeedback.Location = New System.Drawing.Point(391, 70)
        Me.btnSubmitFeedback.Name = "btnSubmitFeedback"
        Me.btnSubmitFeedback.Size = New System.Drawing.Size(135, 38)
        Me.btnSubmitFeedback.TabIndex = 2
        Me.btnSubmitFeedback.Text = "FeedBack"
        Me.btnSubmitFeedback.UseVisualStyleBackColor = True
        '
        'cmbRating
        '
        Me.cmbRating.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRating.FormattingEnabled = True
        Me.cmbRating.Location = New System.Drawing.Point(105, 77)
        Me.cmbRating.Name = "cmbRating"
        Me.cmbRating.Size = New System.Drawing.Size(151, 31)
        Me.cmbRating.TabIndex = 1
        '
        'txtFeedback
        '
        Me.txtFeedback.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeedback.Location = New System.Drawing.Point(145, 24)
        Me.txtFeedback.Name = "txtFeedback"
        Me.txtFeedback.Size = New System.Drawing.Size(348, 30)
        Me.txtFeedback.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(1299, 521)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(142, 57)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'grpProjectDetails
        '
        Me.grpProjectDetails.BackColor = System.Drawing.Color.White
        Me.grpProjectDetails.Controls.Add(Me.dgvProjectDetails)
        Me.grpProjectDetails.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProjectDetails.Location = New System.Drawing.Point(28, 277)
        Me.grpProjectDetails.Name = "grpProjectDetails"
        Me.grpProjectDetails.Size = New System.Drawing.Size(687, 131)
        Me.grpProjectDetails.TabIndex = 4
        Me.grpProjectDetails.TabStop = False
        Me.grpProjectDetails.Text = "ProjectDetails"
        '
        'dgvProjectDetails
        '
        Me.dgvProjectDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjectDetails.Location = New System.Drawing.Point(6, 21)
        Me.dgvProjectDetails.Name = "dgvProjectDetails"
        Me.dgvProjectDetails.RowHeadersWidth = 51
        Me.dgvProjectDetails.RowTemplate.Height = 24
        Me.dgvProjectDetails.Size = New System.Drawing.Size(669, 104)
        Me.dgvProjectDetails.TabIndex = 0
        '
        'grpAssignedTasks
        '
        Me.grpAssignedTasks.BackColor = System.Drawing.Color.White
        Me.grpAssignedTasks.Controls.Add(Me.dgvAssignedTasks)
        Me.grpAssignedTasks.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAssignedTasks.Location = New System.Drawing.Point(28, 414)
        Me.grpAssignedTasks.Name = "grpAssignedTasks"
        Me.grpAssignedTasks.Size = New System.Drawing.Size(687, 135)
        Me.grpAssignedTasks.TabIndex = 5
        Me.grpAssignedTasks.TabStop = False
        Me.grpAssignedTasks.Text = "AssignedTasks"
        '
        'dgvAssignedTasks
        '
        Me.dgvAssignedTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssignedTasks.Location = New System.Drawing.Point(9, 29)
        Me.dgvAssignedTasks.Name = "dgvAssignedTasks"
        Me.dgvAssignedTasks.ReadOnly = True
        Me.dgvAssignedTasks.RowHeadersWidth = 51
        Me.dgvAssignedTasks.RowTemplate.Height = 24
        Me.dgvAssignedTasks.Size = New System.Drawing.Size(669, 95)
        Me.dgvAssignedTasks.TabIndex = 0
        '
        'ClientDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1453, 590)
        Me.Controls.Add(Me.grpAssignedTasks)
        Me.Controls.Add(Me.grpProjectDetails)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.gbFeedback)
        Me.Controls.Add(Me.grpFinancialSummary)
        Me.Controls.Add(Me.gbProjectProgress)
        Me.Name = "ClientDashboard"
        Me.Text = "ClientDashboard"
        Me.gbProjectProgress.ResumeLayout(False)
        CType(Me.dgvProjectProgress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFinancialSummary.ResumeLayout(False)
        CType(Me.dgvFinancialSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFeedback.ResumeLayout(False)
        Me.gbFeedback.PerformLayout()
        Me.grpProjectDetails.ResumeLayout(False)
        CType(Me.dgvProjectDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAssignedTasks.ResumeLayout(False)
        CType(Me.dgvAssignedTasks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbProjectProgress As GroupBox
    Friend WithEvents grpFinancialSummary As GroupBox
    Friend WithEvents dgvProjectProgress As DataGridView
    Friend WithEvents gbFeedback As GroupBox
    Friend WithEvents dgvFinancialSummary As DataGridView
    Friend WithEvents btnSubmitFeedback As Button
    Friend WithEvents cmbRating As ComboBox
    Friend WithEvents txtFeedback As TextBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents grpProjectDetails As GroupBox
    Friend WithEvents dgvProjectDetails As DataGridView
    Friend WithEvents grpAssignedTasks As GroupBox
    Friend WithEvents dgvAssignedTasks As DataGridView
End Class
