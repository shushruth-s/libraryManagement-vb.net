Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = 1234 Then
            userpage.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Credentials")
        End If
    End Sub
End Class
