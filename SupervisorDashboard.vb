Imports System.Data.SqlClient

Public Class SupervisorDashboard

    ' Variable to store the logged-in user's role (Ensure this is set when Supervisor logs in)
    Public UserRole As String

    ' Form Load Event
    Private Sub SupervisorDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTasks()
    End Sub

    ' =========================== LOAD TASKS =========================== '
    Private Sub LoadTasks()
        Try
            Using con As New SqlConnection("Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;")
                con.Open()
                Dim query As String = "SELECT T.TaskID, T.TaskName, T.StartDate, T.EndDate, 
       COALESCE(U.FullName, 'Unassigned') AS AssignedWorker
FROM Tasks T
LEFT JOIN WorkerTasks WT ON T.TaskID = WT.TaskID
LEFT JOIN Users U ON WT.WorkerID = U.UserID;
"

                Dim adapter As New SqlDataAdapter(query, con)
                Dim table As New DataTable()
                adapter.Fill(table)

                If table.Rows.Count > 0 Then
                    dgvTasks.DataSource = table
                Else
                    dgvTasks.DataSource = Nothing
                    MessageBox.Show("No tasks found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("❌ Error loading tasks: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================== ASSIGN TASK TO WORKER =========================== '
    Private Sub btnAssignTask_Click(sender As Object, e As EventArgs) Handles btnAssigntask.Click
        ' Validate Selection
        If dgvTasks.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a task to assign.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get Task Details
        Dim selectedTaskID As Integer = Convert.ToInt32(dgvTasks.CurrentRow.Cells("TaskID").Value)

        ' Get Worker ID
        Dim workerIDInput As String = InputBox("Enter Worker ID to assign:", "Assign Task")
        Dim selectedWorkerID As Integer

        ' Validate Worker ID (Must be Integer and > 0)
        If Not Integer.TryParse(workerIDInput, selectedWorkerID) OrElse selectedWorkerID <= 0 Then
            MessageBox.Show("Invalid Worker ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using con As New SqlConnection("Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;")
                con.Open()
                Dim transaction As SqlTransaction = con.BeginTransaction()

                Try
                    ' ✅ Check if Worker Exists
                    Dim workerCheckQuery As String = "SELECT COUNT(*) FROM Users WHERE UserID = @WorkerID AND Role = 'Worker'"
                    Using workerCheckCmd As New SqlCommand(workerCheckQuery, con, transaction)
                        workerCheckCmd.Parameters.AddWithValue("@WorkerID", selectedWorkerID)
                        Dim workerExists As Integer = Convert.ToInt32(workerCheckCmd.ExecuteScalar())

                        If workerExists = 0 Then
                            MessageBox.Show("Worker ID does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            transaction.Rollback()
                            Return
                        End If
                    End Using

                    ' ✅ Check if Task is Already Assigned
                    Dim checkQuery As String = "SELECT COUNT(*) FROM WorkerTasks WHERE TaskID = @TaskID"
                    Using checkCmd As New SqlCommand(checkQuery, con, transaction)
                        checkCmd.Parameters.AddWithValue("@TaskID", selectedTaskID)
                        Dim taskExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                        If taskExists > 0 Then
                            ' 🟡 Update Existing Assignment
                            Dim updateQuery As String = "UPDATE WorkerTasks 
                                                 SET WorkerID = @WorkerID, WorkStatus = 'Not Started', 
                                                     ProgressPercentage = 0, LastUpdated = GETDATE() 
                                                 WHERE TaskID = @TaskID"
                            Using updateCmd As New SqlCommand(updateQuery, con, transaction)
                                updateCmd.Parameters.AddWithValue("@WorkerID", selectedWorkerID)
                                updateCmd.Parameters.AddWithValue("@TaskID", selectedTaskID)
                                updateCmd.ExecuteNonQuery()
                            End Using
                            MessageBox.Show("Task reassigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            ' 🔵 Insert New Assignment
                            Dim insertQuery As String = "INSERT INTO WorkerTasks (WorkerID, TaskID, WorkStatus, ProgressPercentage, LastUpdated) 
                                                 VALUES (@WorkerID, @TaskID, 'Not Started', 0, GETDATE())"
                            Using insertCmd As New SqlCommand(insertQuery, con, transaction)
                                insertCmd.Parameters.AddWithValue("@WorkerID", selectedWorkerID)
                                insertCmd.Parameters.AddWithValue("@TaskID", selectedTaskID)
                                insertCmd.ExecuteNonQuery()
                            End Using
                            MessageBox.Show("Task assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        ' ✅ Commit Transaction
                        transaction.Commit()
                    End Using
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show($"Error assigning task: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using

            LoadTasks() ' Refresh DataGridView
        Catch ex As Exception
            MessageBox.Show($"Unexpected error: {ex.Message}", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================== OPEN PROJECT FORM =========================== '
    Private Sub btnProject_Click(sender As Object, e As EventArgs) Handles btnProject.Click
        Dim projectForm As New ProjectForm()
        projectForm.Show()
    End Sub

    ' =========================== OPEN RESOURCE MANAGEMENT =========================== '
    Private Sub btnResourceManagement_Click(sender As Object, e As EventArgs) Handles btnResourceManagement.Click
        Dim resourceForm As New ResourceManagement()
        resourceForm.Show()
    End Sub

    ' =========================== OPEN FINANCIAL MANAGEMENT =========================== '
    Private Sub btnFinancialManagement_Click(sender As Object, e As EventArgs) Handles btnFinancialManagement.Click
        Dim financeForm As New FinancialManagement()
        financeForm.Show()
    End Sub

    ' =========================== OPEN PROJECT SCHEDULING =========================== '
    Private Sub btnProjectScheduling_Click(sender As Object, e As EventArgs) Handles btnProjectScheduling.Click
        Dim projectSchedulingForm As New ProjectScheduling()
        projectSchedulingForm.Show()
    End Sub

    ' =========================== OPEN WORKER DASHBOARD =========================== '
    Private Sub btnWorkerDashboard_Click(sender As Object, e As EventArgs) Handles btnWorkerDAshboard.Click
        Dim workerDashboardForm As New WorkerDashboard()
        workerDashboardForm.Show()
    End Sub

    ' =========================== LOGOUT FUNCTION =========================== '
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Close() ' Close Supervisor Dashboard
    End Sub

    Private Sub btnProjectTrackingForm_Click(sender As Object, e As EventArgs) Handles btnProjectTrackingForm.Click
        Dim ProjectTrackingForm As New ProjectTrackingForm()
        ProjectTrackingForm.Show()

    End Sub
End Class
