Public Class Form1
    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Hitung_Click(sender As Object, e As EventArgs) Handles Hitung.Click
        Dim kali5
        kali5 = Val(TextBox1.Text) * 5
        TextBox2.Text = kali5
    End Sub
End Class
