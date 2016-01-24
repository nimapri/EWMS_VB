Public Class frmMain
    Dim ListName As String
    Dim currentTable As New DataTable


    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        ListName = InputBox("Enter List Name", "Create New List", "List1")
        Me.Text = "Emigrated Worker Management System - " + ListName
        createTable()
        clearGridView()
        dgvDetails.DataSource = currentTable

    End Sub

    Private Sub createTable()
        Dim colName As DataColumn = currentTable.Columns.Add("Name", Type.GetType("System.String"))
        Dim colAddress As DataColumn = currentTable.Columns.Add("Address", Type.GetType("System.String"))
        Dim colNICNo As DataColumn = currentTable.Columns.Add("NIC No", Type.GetType("System.String"))
        Dim colPassportNo As DataColumn = currentTable.Columns.Add("Passport No", Type.GetType("System.String"))
        Dim colMaritalStatus As DataColumn = currentTable.Columns.Add("Marital Status", Type.GetType("System.String"))
        Dim colNameofHusband As DataColumn = currentTable.Columns.Add("Name of Husband", Type.GetType("System.String"))
        Dim colNamesofChildren As DataColumn = currentTable.Columns.Add("Names of Children", Type.GetType("System.String"))
        Dim colProtector As DataColumn = currentTable.Columns.Add("Protector of Children", Type.GetType("System.String"))
        Dim colIsProtector As DataColumn = currentTable.Columns.Add("Is Protector Still Available", Type.GetType("System.Boolean"))
        Dim colBenefits As DataColumn = currentTable.Columns.Add("Benefits From Emmigration", Type.GetType("System.Boolean"))








    End Sub

    Private Sub clearGridView()
        dgvDetails.Columns.Clear()
    End Sub

    Private Sub NameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NameToolStripMenuItem.Click

    End Sub
End Class
