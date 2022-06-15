Public Class Form1
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim gaji, total As Integer
        Dim lamaKerja, bonus As Integer

        gaji = TextBox2.Text
        lamaKerja = TextBox3.Text

        If lamaKerja > 2 And gaji > 2000000 Then
            bonus = 10 / 100 * gaji
        Else
            bonus = 0
        End If

        total = bonus + Val(TextBox2.Text)
        TextBox4.Text = TextBox1.Text
        TextBox5.Text = gaji.ToString("N")
        TextBox6.Text = bonus.ToString("N")
        TextBox7.Text = total.ToString("N")

    End Sub

    Private Sub ButtonSelesai_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
