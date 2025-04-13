Imports System.Data.SqlClient

Public Class ProjectForm
    ' Database Connection String
    Private ReadOnly connectionString As String = "Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;"

    ' Form Load - Load Projects & Clients
    Private Sub ProjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClients() ' Load Client List
        LoadProjects() ' Load Projects into DataGridView
    End Sub

    ' Load Clients into ComboBox
    Private Sub LoadClients()
        Try
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT UserID, FullName FROM Users WHERE Role = 'Client'"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                cmbClients.DataSource = dt
                cmbClients.DisplayMember = "FullName" ' Show Client Name
                cmbClients.ValueMember = "UserID" ' Store ClientID
                cmbClients.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("❌ Error loading clients: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Load Projects into DataGridView
    Public Sub LoadProjects()
        Try
            Dim dt As DataTable = GetProjects()
            dgvProjects.DataSource = If(dt.Rows.Count > 0, dt, Nothing)
        Catch ex As Exception
            MessageBox.Show("❌ Error while loading projects: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Retrieve Projects from Database
    Public Function GetProjects() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT P.ProjectID, P.ProjectName, P.StartDate, P.EndDate, P.Status, P.Budget, U.FullName AS ClientName
                                       FROM Projects P 
                                       LEFT JOIN Users U ON P.ClientID = U.UserID"
                Using cmd As New SqlCommand(query, conn)
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("❌ Error while fetching projects: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' Add Project
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtProjectName.Text = "" Or cmbClients.SelectedIndex = -1 Then
            MessageBox.Show("❌ Please fill all required fields!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO Projects (ProjectName, StartDate, EndDate, Status, Budget, ClientID) 
                                       VALUES (@ProjectName, @StartDate, @EndDate, @Status, @Budget, @ClientID)"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProjectName", txtProjectName.Text)
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value)
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value)
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)
                    cmd.Parameters.AddWithValue("@Budget", Convert.ToDecimal(txtBudget.Text))
                    cmd.Parameters.AddWithValue("@ClientID", cmbClients.SelectedValue)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            MessageBox.Show("✅ Project added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadProjects()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("❌ Error while adding project: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Update Project
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtProjectId.Text = "" Then
            MessageBox.Show("❌ Please select a project to update!", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "UPDATE Projects 
                                       SET ProjectName=@ProjectName, StartDate=@StartDate, EndDate=@EndDate, Status=@Status, Budget=@Budget, ClientID=@ClientID 
                                       WHERE ProjectID=@ProjectID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProjectID", txtProjectId.Text)
                    cmd.Parameters.AddWithValue("@ProjectName", txtProjectName.Text)
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value)
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value)
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)
                    cmd.Parameters.AddWithValue("@Budget", Convert.ToDecimal(txtBudget.Text))
                    cmd.Parameters.AddWithValue("@ClientID", cmbClients.SelectedValue)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            MessageBox.Show("✅ Project updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadProjects()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("❌ Error while updating project: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Delete Project
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtProjectId.Text = "" Then
            MessageBox.Show("❌ Please select a project to delete!", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "DELETE FROM Projects WHERE ProjectID=@ProjectID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProjectID", txtProjectId.Text)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            MessageBox.Show("✅ Project deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadProjects()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("❌ Error while deleting project: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Selecting a Row in DataGridView
    ' Selecting a Row in DataGridView
    Private Sub dgvProjects_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjects.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProjects.Rows(e.RowIndex)

            txtProjectId.Text = row.Cells("ProjectID").Value.ToString()
            txtProjectName.Text = row.Cells("ProjectName").Value.ToString()

            ' Handle NULL values for Date fields
            If IsDBNull(row.Cells("StartDate").Value) Then
                dtpStartDate.Value = DateTime.Now ' Default to current date
            Else
                dtpStartDate.Value = Convert.ToDateTime(row.Cells("StartDate").Value)
            End If

            If IsDBNull(row.Cells("EndDate").Value) Then
                dtpEndDate.Value = DateTime.Now ' Default to current date
            Else
                dtpEndDate.Value = Convert.ToDateTime(row.Cells("EndDate").Value)
            End If

            cmbStatus.Text = row.Cells("Status").Value.ToString()
            txtBudget.Text = row.Cells("Budget").Value.ToString()
            cmbClients.Text = row.Cells("ClientName").Value.ToString()
        End If
    End Sub

    ' Clear Fields
    Private Sub ClearFields()
        txtProjectId.Clear()
        txtProjectName.Clear()
        dtpStartDate.Value = DateTime.Now
        dtpEndDate.Value = DateTime.Now
        cmbStatus.SelectedIndex = -1
        txtBudget.Clear()
        cmbClients.SelectedIndex = -1
    End Sub

    ' Clear Fields Button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub
End Class
