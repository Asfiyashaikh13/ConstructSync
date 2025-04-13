Imports System.Data.SqlClient

Public Class FinancialManagement
    ' Database Connection String
    Private ReadOnly con As New SqlConnection("Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;")

    ' Form Load Event
    Private Sub FinancialManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFinancialData()
    End Sub

    ' =========================== LOAD FINANCIAL DATA =========================== '
    Private Sub LoadFinancialData()
        Try
            Using cmd As New SqlCommand("SELECT * FROM FinancialRecords", con)
                Using adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvFinancialRecords.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("❌ Error loading financial data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================== ADD FINANCIAL RECORD =========================== '
    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        ' Validate Inputs
        If txtCategory.Text = "" Or txtAmount.Text = "" Or cmbType.SelectedIndex = -1 Then
            MessageBox.Show("⚠ Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Convert Amount to Decimal
        Dim amount As Decimal
        If Not Decimal.TryParse(txtAmount.Text, amount) Then
            MessageBox.Show("⚠ Please enter a valid numeric amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Insert Financial Record
        Try
            Using cmd As New SqlCommand("INSERT INTO FinancialRecords (Category, Amount, Type, Date) VALUES (@category, @amount, @type, @date)", con)
                cmd.Parameters.AddWithValue("@category", txtCategory.Text)
                cmd.Parameters.AddWithValue("@amount", amount)
                cmd.Parameters.AddWithValue("@type", cmbType.Text) ' Expense or Budget
                cmd.Parameters.AddWithValue("@date", dtpDate.Value)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using

            MessageBox.Show("✅ Financial record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadFinancialData()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("❌ Error adding record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    ' =========================== GENERATE FINANCIAL REPORT =========================== '
    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Try
            Using cmd As New SqlCommand("SELECT Type, SUM(Amount) AS Total FROM FinancialRecords GROUP BY Type", con)
                Using adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvReport.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("❌ Error generating report: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================== NAVIGATE TO RESOURCE MANAGEMENT =========================== '
    Private Sub btnGoToResource_Click(sender As Object, e As EventArgs) Handles btnGoToResource.Click
        Try
            Dim resourceForm As New ResourceManagement()
            resourceForm.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("❌ Error opening Resource Management: " & ex.Message, "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================== CLEAR INPUT FIELDS =========================== '


    Private Sub ClearFields()
        txtCategory.Clear()
        txtAmount.Clear()
        cmbType.SelectedIndex = -1
        dtpDate.Value = DateTime.Now
    End Sub


End Class
