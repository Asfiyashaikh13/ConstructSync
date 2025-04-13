Imports System.Data.SqlClient

Public Class ResourceManagement
    Private ReadOnly connectionString As String = "Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;"

    Private Sub ResourceManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMaterials()
        LoadEquipment()
        PopulateMaterialLists()
    End Sub

    ' =========================== MATERIALS MANAGEMENT =========================== '

    Private Sub PopulateMaterialLists()
        ' Material Names
        clbMaterials.Items.AddRange({
            "Cement", "Bricks", "Steel", "Sand", "Gravel", "Wood", "Tiles", "Glass", "Concrete",
            "Paint", "Pipes", "Iron Rods", "POP", "Aluminum Sheets", "PVC", "Gypsum", "Nails"
        })

        ' Quantities
        clbQuantities.Items.AddRange({"10", "20", "50", "100", "200", "500"})

        ' Units
        clbUnits.Items.AddRange({"Bags", "Kg", "Ton", "Cubic Meter", "Pieces"})
    End Sub

    Private Sub LoadMaterials()
        Try
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM Materials"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvMaterials.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading materials: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAddMaterial_Click(sender As Object, e As EventArgs) Handles btnAddMaterial.Click
        If clbMaterials.CheckedItems.Count = 0 Or clbQuantities.CheckedItems.Count = 0 Or clbUnits.CheckedItems.Count = 0 Then
            MessageBox.Show("Please select at least one material, quantity, and unit!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ensure counts match
        If clbMaterials.CheckedItems.Count <> clbQuantities.CheckedItems.Count Or clbMaterials.CheckedItems.Count <> clbUnits.CheckedItems.Count Then
            MessageBox.Show("Please select the same number of materials, quantities, and units (by index).", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                For i As Integer = 0 To clbMaterials.CheckedItems.Count - 1
                    Dim material As String = clbMaterials.CheckedItems(i).ToString()
                    Dim quantity As String = clbQuantities.CheckedItems(i).ToString()
                    Dim unit As String = clbUnits.CheckedItems(i).ToString()

                    Dim query As String = "INSERT INTO Materials (MaterialName, Quantity, Unit) VALUES (@MaterialName, @Quantity, @Unit)"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@MaterialName", material)
                        cmd.Parameters.AddWithValue("@Quantity", quantity)
                        cmd.Parameters.AddWithValue("@Unit", unit)
                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using

            MessageBox.Show("Materials added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadMaterials()

            ' Clear Selections
            ClearCheckedList(clbMaterials)
            ClearCheckedList(clbQuantities)
            ClearCheckedList(clbUnits)

        Catch ex As Exception
            MessageBox.Show("Error adding materials: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearCheckedList(clb As CheckedListBox)
        For i As Integer = 0 To clb.Items.Count - 1
            clb.SetItemChecked(i, False)
        Next
    End Sub

    ' =========================== EQUIPMENT MANAGEMENT =========================== '

    Private Sub LoadEquipment()
        Try
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM Equipment"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvEquipment.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading equipment: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAddEquipment_Click(sender As Object, e As EventArgs) Handles btnAddEquipment.Click
        If TxtEquipmentName.Text = "" Or cmbStatus.Text = "" Then
            MessageBox.Show("Please fill all equipment details!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO Equipment (EquipmentName, Status) VALUES (@EquipmentName, @Status)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EquipmentName", TxtEquipmentName.Text)
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Equipment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadEquipment()
        Catch ex As Exception
            MessageBox.Show("Error adding equipment: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdateEquipment_Click(sender As Object, e As EventArgs) Handles btnUpdateEquipment.Click
        If TxtEquipmentID.Text = "" Or cmbStatus.Text = "" Then
            MessageBox.Show("Please select equipment and update status!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "UPDATE Equipment SET Status = @Status WHERE EquipmentID = @EquipmentID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EquipmentID", TxtEquipmentID.Text)
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Equipment status updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadEquipment()
        Catch ex As Exception
            MessageBox.Show("Error updating equipment: " & ex.Message)
        End Try
    End Sub

    Private Sub btnFinancialModule_Click(sender As Object, e As EventArgs) Handles btnFinancialModule.Click
        Dim financeForm As New FinancialManagement()
        financeForm.Show()
        Me.Hide()
    End Sub
End Class
