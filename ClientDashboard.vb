Imports System.Data.SqlClient

Public Class ClientDashboard

    ' ✅ Load Form Event
    Private Sub ClientDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure client is logged in before loading the dashboard
        If GlobalVariables.LoggedInUserID = -1 Then
            MessageBox.Show("Client not logged in!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Exit Sub
        End If

        ' ✅ Load all dashboard data
        LoadProjectDetails()
        LoadProjectProgress()
        LoadFinancialSummary()
        LoadAssignedTasks()

        ' ✅ Populate Rating Combobox
        PopulateRatingComboBox()

        ' ✅ Make the UI Read-only for Clients

    End Sub

    ' ✅ Populate Rating Combobox
    Private Sub PopulateRatingComboBox()
        cmbRating.Items.Clear()

        ' Add rating values (1 to 5)
        For i As Integer = 1 To 5
            cmbRating.Items.Add(i)
        Next

        ' Set default selection
        cmbRating.SelectedIndex = -1
    End Sub

    ' ✅ Load Project Details
    Private Sub LoadProjectDetails()
        Try
            Using con As New SqlConnection("Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;")
                con.Open()
                Dim query As String = "SELECT ProjectID, ProjectName, StartDate, EndDate, Status, Budget 
                                       FROM Projects WHERE ClientID = @clientID"
                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@clientID", GlobalVariables.LoggedInUserID)

                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' ✅ Bind data to DataGridView
                dgvProjectDetails.DataSource = table
                dgvProjectDetails.ReadOnly = True  ' Make DataGridView read-only
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading project details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ✅ Load Project Progress
    Private Sub LoadProjectProgress()
        Try
            Using con As New SqlConnection("Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;")
                con.Open()

                Dim query As String = "SELECT T.TaskName, T.Status, T.StartDate, T.EndDate
                                       FROM Tasks T
                                       INNER JOIN Projects P ON T.ProjectID = P.ProjectID
                                       WHERE P.ClientID = @clientID"

                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@clientID", GlobalVariables.LoggedInUserID)

                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' ✅ Bind data
                dgvProjectProgress.DataSource = table
                dgvProjectProgress.ReadOnly = True  ' Make DataGridView read-only
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading project progress: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ✅ Load Financial Summary
    Private Sub LoadFinancialSummary()
        Try
            Using con As New SqlConnection("Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;")
                con.Open()

                Dim query As String = "SELECT Category, SUM(Amount) AS TotalSpent 
                                       FROM FinancialRecords 
                                       WHERE Type = 'Expense'
                                       GROUP BY Category"

                Dim cmd As New SqlCommand(query, con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' ✅ Bind data
                dgvFinancialSummary.DataSource = table
                dgvFinancialSummary.ReadOnly = True  ' Make DataGridView read-only
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading financial summary: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ✅ Load Assigned Tasks
    Private Sub LoadAssignedTasks()
        Try
            Using con As New SqlConnection("Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;")
                con.Open()

                Dim query As String = "
            SELECT 
                T.TaskID, 
                T.TaskName, 
                T.Status, 
                T.StartDate, 
                T.EndDate,
                ISNULL(U.FullName, 'Unassigned') AS WorkerName,  
                ISNULL(WT.ProgressPercentage, 0) AS ProgressPercentage
            FROM Tasks AS T
            INNER JOIN ProjectTracking AS PT ON T.TaskID = PT.TaskID
            INNER JOIN Projects AS P ON T.ProjectID = P.ProjectID
            LEFT JOIN WorkerTasks AS WT ON T.TaskID = WT.TaskID  
            LEFT JOIN Users AS U ON WT.WorkerID = U.UserID  
            WHERE P.ClientID = @ClientID"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@ClientID", Convert.ToInt32(GlobalVariables.LoggedInUserID))

                    Using adapter As New SqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        ' ✅ Bind the data to DataGridView
                        dgvAssignedTasks.DataSource = table
                        dgvAssignedTasks.ReadOnly = True  ' Make DataGridView read-only
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading assigned tasks: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ✅ Make the UI read-only for the client

    ' ✅ Submit Feedback (Enable feedback submission)
    Private Sub btnSubmitFeedback_Click(sender As Object, e As EventArgs) Handles btnSubmitFeedback.Click
        ' ✅ Validate Inputs
        If String.IsNullOrWhiteSpace(txtFeedback.Text) OrElse cmbRating.SelectedIndex = -1 Then
            MessageBox.Show("Please enter feedback and select a rating.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ✅ Get Project ID if selected
        Dim projectID As Object = Nothing
        If dgvProjectDetails.CurrentRow IsNot Nothing Then
            projectID = dgvProjectDetails.CurrentRow.Cells("ProjectID").Value
        End If

        Try
            Using con As New SqlConnection("Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;")
                con.Open()

                ' ✅ Insert Feedback
                Dim query As String = "INSERT INTO Feedback (ClientID, ProjectID, FeedbackText, Rating, SubmittedOn) 
                                       VALUES (@clientID, @projectID, @feedback, @rating, GETDATE())"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@clientID", GlobalVariables.LoggedInUserID)
                    cmd.Parameters.AddWithValue("@projectID", If(projectID IsNot Nothing, projectID, DBNull.Value))
                    cmd.Parameters.AddWithValue("@feedback", txtFeedback.Text)
                    cmd.Parameters.AddWithValue("@rating", cmbRating.SelectedItem.ToString())

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("✅ Feedback submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' ✅ Clear Fields
                txtFeedback.Clear()
                cmbRating.SelectedIndex = -1

            End Using
        Catch ex As Exception
            MessageBox.Show("Error submitting feedback: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ✅ Logout
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        GlobalVariables.LoggedInUserID = -1
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Close()
    End Sub

End Class
