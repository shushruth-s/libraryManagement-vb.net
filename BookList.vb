Imports System.Data.DataTable

Public Class BookList
    Dim table As New DataTable("Table")
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        table.Rows.Add(TextBox1.Text, TextBox2.Text)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        Else
            MessageBox.Show("Select 1 row before you hit Delete")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        userpage.Show()
        Me.Hide()
    End Sub

    Private Sub BookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table.Columns.Add("BookName", Type.GetType("System.String"))
        table.Columns.Add("Author", Type.GetType("System.String"))
        DataGridView1.DataSource = table
    End Sub
End Class