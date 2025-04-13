Imports System.Data.SqlClient

Public Class AdminDashboard
    ' ✅ Load Form Event
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
        LoadProjects()
        LoadFinancialRecords()
        LoadMaterials()
        LoadEquipment()
        LoadProjectTracking()
        LoadFeedback()
        LoadPendingWorks() ' ✅ Load Pending Works in TabControl
    End Sub

    ' ✅ Load Users
    Private Sub LoadUsers()
        LoadData("SELECT UserID, FullName, Email, Role FROM Users", dgvUsers, "Error loading users")
    End Sub

    ' ✅ Load Projects
    Private Sub LoadProjects()
        LoadData("SELECT * FROM Projects", dgvProjects, "Error loading projects")
    End Sub

    ' ✅ Load Financial Records
    Private Sub LoadFinancialRecords()
        LoadData("SELECT * FROM FinancialRecords", dgvFinancialRecords, "Error loading financial records")
    End Sub

    ' ✅ Load Materials
    Private Sub LoadMaterials()
        LoadData("SELECT * FROM Materials", dgvMaterials, "Error loading materials")
    End Sub

    ' ✅ Load Equipment
    Private Sub LoadEquipment()
        LoadData("SELECT * FROM Equipment", dgvEquipment, "Error loading equipment")
    End Sub

    ' ✅ Load Project Tracking
    Private Sub LoadProjectTracking()
        LoadData("SELECT * FROM ProjectTracking", dgvProjectTracking, "Error loading project tracking")
    End Sub

    ' ✅ Load Feedback
    Private Sub LoadFeedback()
        LoadData("SELECT FeedbackID, ClientID, ProjectID, FeedbackText, Rating, SubmittedOn FROM Feedback", dgvFeedback, "Error loading feedback")
    End Sub

    ' ✅ Load Pending Works (Projects & Tasks)
    Private Sub LoadPendingWorks()
        ' Query to get tasks and projects with 'Pending' status
        Dim query As String = "SELECT TaskID AS ID, TaskName AS Name, StartDate, Deadline AS EndDate, Status, 'Task' AS Type FROM Tasks WHERE Status = 'Pending' " &
                              "UNION " &
                              "SELECT ProjectID AS ID, ProjectName AS Name, StartDate, EndDate, Status, 'Project' AS Type FROM Projects WHERE Status = 'Pending';"

        ' Call the LoadData function to fill the DataGridView
        LoadData(query, dgvPendingWorks, "Error loading pending works")
    End Sub

    ' ✅ Reusable Function to Load Data
    Private Sub LoadData(query As String, dgv As DataGridView, errorMessage As String)
        Try
            Using con As New SqlConnection("Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;")
                con.Open()
                Dim cmd As New SqlCommand(query, con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgv.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show(errorMessage & ": " & ex.Message)
        End Try
    End Sub

    ' ✅ Function to Delete Feedback
    Private Sub DeleteFeedback(feedbackID As Integer)
        Try
            Using con As New SqlConnection("Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;")
                con.Open()
                Dim query As String = "DELETE FROM Feedback WHERE FeedbackID = @FeedbackID"
                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@FeedbackID", feedbackID)

                Dim result As Integer = cmd.ExecuteNonQuery()
                If result > 0 Then
                    MessageBox.Show("✅ Feedback deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadFeedback()
                Else
                    MessageBox.Show("❌ Feedback not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting feedback: " & ex.Message)
        End Try
    End Sub

    ' ✅ Mark Pending Task as Completed
    Private Sub btnCompleteTask_Click(sender As Object, e As EventArgs) Handles btnCompleteTask.Click
        ' Check if any row is selected
        If dgvPendingWorks.SelectedRows.Count > 0 Then
            ' Get the selected ID and type (Task or Project)
            Dim selectedID As Integer = Convert.ToInt32(dgvPendingWorks.SelectedRows(0).Cells("ID").Value)
            Dim type As String = dgvPendingWorks.SelectedRows(0).Cells("Type").Value.ToString()

            ' Check if the selected item is a Task
            If type = "Task" Then
                Try
                    ' Create a connection to the database
                    Using con As New SqlConnection("Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;")
                        con.Open()

                        ' SQL query to update the task status to 'Completed'
                        Dim query As String = "UPDATE Tasks SET Status = 'Completed' WHERE TaskID = @TaskID"
                        Dim cmd As New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@TaskID", selectedID)

                        ' Execute the update query
                        Dim result As Integer = cmd.ExecuteNonQuery()

                        If result > 0 Then
                            ' Successfully updated the task status
                            MessageBox.Show("✅ Task marked as completed!")
                        Else
                            ' Task was not found or update failed
                            MessageBox.Show("❌ Failed to mark the task as completed!")
                        End If
                    End Using

                Catch ex As Exception
                    ' Handle any errors that occur during the database interaction
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            ElseIf type = "Project" Then
                ' If the selected item is a Project, update the project status to 'Completed'
                Try
                    ' Create a connection to the database
                    Using con As New SqlConnection("Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;")
                        con.Open()

                        ' SQL query to update the project status to 'Completed'
                        Dim query As String = "UPDATE Projects SET Status = 'Completed' WHERE ProjectID = @ProjectID"
                        Dim cmd As New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@ProjectID", selectedID)

                        ' Execute the update query
                        Dim result As Integer = cmd.ExecuteNonQuery()

                        If result > 0 Then
                            ' Successfully updated the project status
                            MessageBox.Show("✅ Project marked as completed!")
                        Else
                            ' Project was not found or update failed
                            MessageBox.Show("❌ Failed to mark the project as completed!")
                        End If
                    End Using

                Catch ex As Exception
                    ' Handle any errors that occur during the database interaction
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            Else
                ' In case the selected item is neither a Task nor a Project
                MessageBox.Show("❌ The selected item is not a Task or Project!")
            End If

            ' Refresh the Pending Works grid after the update
            LoadPendingWorks()

        Else
            ' If no row is selected in the DataGridView
            MessageBox.Show("❌ Please select a task or project to complete!")
        End If
    End Sub

    ' ✅ Refresh Pending Works
    Private Sub btnRefreshPending_Click(sender As Object, e As EventArgs) Handles btnRefreshPending.Click
        LoadPendingWorks()
    End Sub

    ' ✅ Logout
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        GlobalVariables.LoggedInUserID = -1
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Close()
    End Sub

End Class
