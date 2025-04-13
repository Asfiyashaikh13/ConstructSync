Imports System.Data.SqlClient

Public Class ProjectTrackingForm
    Dim connectionString As String = "Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;"

    ' Form Load
    Private Sub ProjectTrackingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProjectTrackingData()
        LoadProjects()
        LoadTasks()
        LoadWorkers()
        LoadSupervisors()
    End Sub

    ' ✅ FIX: Load DataGridView with Explicit Columns
    Private Sub LoadProjectTrackingData()
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()

                ' Use explicit columns instead of * for better stability
                Dim query As String = "SELECT TrackingID, ProjectID, TaskID, WorkerID, SupervisorID, Status, 
                                      ProgressPercentage, StartDate, EndDate, Remarks 
                                      FROM ProjectTracking"

                Dim adapter As New SqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table

                ' Automatically resize columns
                DataGridView1.AutoResizeColumns()

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Load ComboBox Data
    Private Sub LoadProjects()
        FillComboBox("SELECT ProjectID, ProjectName FROM Projects", cmbProject, "ProjectID", "ProjectName")
    End Sub

    Private Sub LoadTasks()
        FillComboBox("SELECT TaskID, TaskName FROM Tasks", cmbTask, "TaskID", "TaskName")
    End Sub

    Private Sub LoadWorkers()
        FillComboBox("SELECT UserID, FullName FROM Users WHERE Role = 'Worker'", cmbWorker, "UserID", "FullName")
    End Sub

    Private Sub LoadSupervisors()
        FillComboBox("SELECT UserID, FullName FROM Users WHERE Role = 'Supervisor'", cmbSupervisor, "UserID", "FullName")
    End Sub

    ' Helper Function to Fill ComboBoxes
    Private Sub FillComboBox(query As String, comboBox As ComboBox, valueMember As String, displayMember As String)
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand(query, conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Ensure ComboBox Binding
                comboBox.DataSource = Nothing
                comboBox.DisplayMember = displayMember
                comboBox.ValueMember = valueMember
                comboBox.DataSource = table

                ' Set default index
                If table.Rows.Count > 0 Then
                    comboBox.SelectedIndex = 0
                End If

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    ' ✅ FIX: DataGridView Row Selection Handling
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Handle NULL values safely
            txtTrackingID.Text = If(IsDBNull(row.Cells("TrackingID").Value), "", row.Cells("TrackingID").Value.ToString())

            ' Use Safe NULL Handling for ComboBox values
            If Not IsDBNull(row.Cells("ProjectID").Value) Then
                cmbProject.SelectedValue = row.Cells("ProjectID").Value
            End If

            If Not IsDBNull(row.Cells("TaskID").Value) Then
                cmbTask.SelectedValue = row.Cells("TaskID").Value
            End If

            If Not IsDBNull(row.Cells("WorkerID").Value) Then
                cmbWorker.SelectedValue = row.Cells("WorkerID").Value
            End If

            If Not IsDBNull(row.Cells("SupervisorID").Value) Then
                cmbSupervisor.SelectedValue = row.Cells("SupervisorID").Value
            End If

            ' Status handling
            cmbStatus.Text = If(IsDBNull(row.Cells("Status").Value), "", row.Cells("Status").Value.ToString())

            ' Handle NULLs for DateTime, Progress, and Remarks
            nudProgress.Value = If(IsDBNull(row.Cells("ProgressPercentage").Value), 0, Convert.ToInt32(row.Cells("ProgressPercentage").Value))
            dtpStartDate.Value = If(IsDBNull(row.Cells("StartDate").Value), DateTime.Now, Convert.ToDateTime(row.Cells("StartDate").Value))
            dtpEndDate.Value = If(IsDBNull(row.Cells("EndDate").Value), DateTime.Now, Convert.ToDateTime(row.Cells("EndDate").Value))
            txtRemarks.Text = If(IsDBNull(row.Cells("Remarks").Value), "", row.Cells("Remarks").Value.ToString())
        End If
    End Sub

    ' ✅ FIX: Clear Fields
    Private Sub ClearFields()
        txtTrackingID.Clear()
        cmbProject.SelectedIndex = -1
        cmbTask.SelectedIndex = -1
        cmbWorker.SelectedIndex = -1
        cmbSupervisor.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        nudProgress.Value = 0
        txtRemarks.Clear()
    End Sub

    ' ✅ Add Record
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Ensure fields are filled
        If cmbProject.SelectedValue Is Nothing OrElse cmbTask.SelectedValue Is Nothing OrElse
           cmbWorker.SelectedValue Is Nothing OrElse cmbSupervisor.SelectedValue Is Nothing OrElse
           String.IsNullOrWhiteSpace(cmbStatus.Text) Then
            MessageBox.Show("Please fill in all fields before adding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Add record
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO ProjectTracking 
                                       (ProjectID, TaskID, WorkerID, SupervisorID, Status, ProgressPercentage, StartDate, EndDate, Remarks) 
                                       VALUES (@ProjectID, @TaskID, @WorkerID, @SupervisorID, @Status, @ProgressPercentage, @StartDate, @EndDate, @Remarks)"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProjectID", cmbProject.SelectedValue)
                    cmd.Parameters.AddWithValue("@TaskID", cmbTask.SelectedValue)
                    cmd.Parameters.AddWithValue("@WorkerID", cmbWorker.SelectedValue)
                    cmd.Parameters.AddWithValue("@SupervisorID", cmbSupervisor.SelectedValue)
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)
                    cmd.Parameters.AddWithValue("@ProgressPercentage", nudProgress.Value)
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value)
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value)
                    cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadProjectTrackingData()
                ClearFields()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    ' Update Project Tracking Record
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Ensure TrackingID is selected
        If String.IsNullOrWhiteSpace(txtTrackingID.Text) Then
            MessageBox.Show("Please select a record to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validate Progress Percentage
        Dim progress As Integer = CInt(nudProgress.Value)
        If progress < 0 Or progress > 100 Then
            MessageBox.Show("Progress must be between 0 and 100.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validate Status
        Dim status As String = cmbStatus.Text.Trim()
        If String.IsNullOrEmpty(status) Then
            MessageBox.Show("Please select a valid status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Assign values with null checks
        Dim projectID = If(cmbProject.SelectedValue IsNot Nothing, cmbProject.SelectedValue, DBNull.Value)
        Dim taskID = If(cmbTask.SelectedValue IsNot Nothing, cmbTask.SelectedValue, DBNull.Value)
        Dim workerID = If(cmbWorker.SelectedValue IsNot Nothing, cmbWorker.SelectedValue, DBNull.Value)
        Dim supervisorID = If(cmbSupervisor.SelectedValue IsNot Nothing, cmbSupervisor.SelectedValue, DBNull.Value)

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()

                Dim query As String = "UPDATE ProjectTracking 
                                   SET ProjectID=@ProjectID, TaskID=@TaskID, WorkerID=@WorkerID, SupervisorID=@SupervisorID, 
                                       Status=@Status, ProgressPercentage=@ProgressPercentage, StartDate=@StartDate, 
                                       EndDate=@EndDate, Remarks=@Remarks
                                   WHERE TrackingID=@TrackingID"

                Using cmd As New SqlCommand(query, conn)
                    ' Add Parameters
                    cmd.Parameters.AddWithValue("@TrackingID", txtTrackingID.Text)
                    cmd.Parameters.AddWithValue("@ProjectID", projectID)
                    cmd.Parameters.AddWithValue("@TaskID", taskID)
                    cmd.Parameters.AddWithValue("@WorkerID", workerID)
                    cmd.Parameters.AddWithValue("@SupervisorID", supervisorID)
                    cmd.Parameters.AddWithValue("@Status", status)
                    cmd.Parameters.AddWithValue("@ProgressPercentage", progress)
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value)
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value)
                    cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)

                    ' Execute SQL
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadProjectTrackingData()
                        ClearFields()
                    Else
                        MessageBox.Show("No matching record found for update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using

            Catch ex As SqlException
                MessageBox.Show("SQL Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    ' Delete Project Tracking Record
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Ensure TrackingID is selected
        If String.IsNullOrWhiteSpace(txtTrackingID.Text) Then
            MessageBox.Show("Please select a record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Confirm Delete Action
        Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmDelete = DialogResult.Yes Then
            Using conn As New SqlConnection(connectionString)
                Try
                    conn.Open()

                    Dim query As String = "DELETE FROM ProjectTracking WHERE TrackingID = @TrackingID"

                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@TrackingID", txtTrackingID.Text)

                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LoadProjectTrackingData()
                            ClearFields()
                        Else
                            MessageBox.Show("No matching record found for delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using

                Catch ex As SqlException
                    MessageBox.Show("SQL Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub
End Class
