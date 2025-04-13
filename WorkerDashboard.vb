Imports System.Data.SqlClient

Public Class WorkerDashboard
    ' Database Connection String
    Private ReadOnly connString As String = "Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;"

    ' Binding Source for DataGridView
    Private bs As New BindingSource()

    ' 🟢 Form Load Event
    Private Sub WorkerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.LoggedInWorkerID = -1 Then
            MessageBox.Show("Worker not logged in!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim loginForm As New LoginForm()
            loginForm.Show()
            Me.Close()
            Return
        End If

        SetupDataGridView()
        LoadAssignedTasks()
    End Sub

    ' 🟢 Setup DataGridView
    Private Sub SetupDataGridView()
        With dgvWorkerTasks
            .AllowUserToAddRows = False
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoGenerateColumns = False
            .Columns.Clear()
        End With

        ' Define columns based on WorkerTasks and Tasks table
        Dim columns As (String, String, Boolean)() = {
            ("WorkerTaskID", "Worker Task ID", False),
            ("TaskID", "Task ID", True),
            ("TaskName", "Task Name", True),
            ("ProjectName", "Project Name", True),
            ("StartDate", "Start Date", True),
            ("EndDate", "End Date", True),
            ("WorkStatus", "Work Status", True),
            ("ProgressPercentage", "Progress (%)", True),
            ("LastUpdated", "Last Updated", True)
        }

        For Each col In columns
            Dim column As New DataGridViewTextBoxColumn()
            column.Name = col.Item1
            column.HeaderText = col.Item2
            column.DataPropertyName = col.Item1
            column.Visible = col.Item3
            dgvWorkerTasks.Columns.Add(column)
        Next
    End Sub

    ' 🟢 Load Assigned Tasks
    Private Sub LoadAssignedTasks()
        Try
            Using con As New SqlConnection(connString)
                con.Open()
                Dim query As String = "SELECT WT.WorkerTaskID, WT.TaskID, T.TaskName, P.ProjectName, " &
                                      "T.StartDate, T.EndDate, WT.WorkStatus, WT.ProgressPercentage, WT.LastUpdated " &
                                      "FROM WorkerTasks WT " &
                                      "INNER JOIN Tasks T ON WT.TaskID = T.TaskID " &
                                      "INNER JOIN Projects P ON T.ProjectID = P.ProjectID " &
                                      "WHERE WT.WorkerID = @WorkerID"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@WorkerID", GlobalVariables.LoggedInWorkerID)

                    Using adapter As New SqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        If table.Rows.Count = 0 Then
                            MessageBox.Show("No tasks found for the worker.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        ' Bind data to DataGridView
                        bs.DataSource = table
                        dgvWorkerTasks.DataSource = bs
                        dgvWorkerTasks.Refresh()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading tasks: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 🟢 Handle Cell Click Event
    Private Sub dgvWorkerTasks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWorkerTasks.CellClick
        If e.RowIndex >= 0 Then dgvWorkerTasks.Rows(e.RowIndex).Selected = True
    End Sub
    Private Sub btnUpdateProgress_Click(sender As Object, e As EventArgs) Handles btnUpdateProgress.Click
        If dgvWorkerTasks.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a task to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim workerTaskID As Integer = Convert.ToInt32(dgvWorkerTasks.SelectedRows(0).Cells("WorkerTaskID").Value)
        Dim newProgress As Integer

        If Not Integer.TryParse(txtProgress.Text, newProgress) OrElse newProgress < 0 OrElse newProgress > 100 Then
            MessageBox.Show("Please enter a valid progress value between 0 and 100.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con As New SqlConnection(connString)
                con.Open()
                Dim query As String = "UPDATE WorkerTasks SET ProgressPercentage = @Progress, LastUpdated = GETDATE() WHERE WorkerTaskID = @WorkerTaskID"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Progress", newProgress)
                    cmd.Parameters.AddWithValue("@WorkerTaskID", workerTaskID)

                    If cmd.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("Progress updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadAssignedTasks()
                    Else
                        MessageBox.Show("Failed to update progress.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating progress: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnCompleteTask_Click(sender As Object, e As EventArgs) Handles btnCompleteTask.Click
        If dgvWorkerTasks.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a task to complete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim workerTaskID As Integer = Convert.ToInt32(dgvWorkerTasks.SelectedRows(0).Cells("WorkerTaskID").Value)

        Try
            Using con As New SqlConnection(connString)
                con.Open()
                Dim query As String = "UPDATE WorkerTasks SET WorkStatus = 'Completed', ProgressPercentage = 100, LastUpdated = GETDATE() WHERE WorkerTaskID = @WorkerTaskID"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@WorkerTaskID", workerTaskID)

                    If cmd.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("Task marked as completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadAssignedTasks()
                    Else
                        MessageBox.Show("Failed to update task status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error completing task: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' 🟢 Logout Function
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        GlobalVariables.LoggedInWorkerID = -1
        MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Close()
    End Sub
    Private Sub btnProjectTrackingForm_Click(sender As Object, e As EventArgs) Handles btnProjectTrackingForm.Click
        Dim ProjectTrackingForm As New ProjectTrackingForm()
        ProjectTrackingForm.Show()

    End Sub
End Class