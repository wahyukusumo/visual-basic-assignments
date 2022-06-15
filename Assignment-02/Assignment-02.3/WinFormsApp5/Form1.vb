Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TextBox1.Text = RadioButton1.Text
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            TextBox1.Text = RadioButton2.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cb1_price, cb2_price, cb3_price, total_price As Integer

        If CheckBox1.Checked Then
            cb1_price = 20000
        Else
            cb1_price = 0
        End If

        If CheckBox2.Checked Then
            cb2_price = 30000
        Else
            cb2_price = 0
        End If

        If CheckBox3.Checked Then
            cb3_price = 25000
        Else
            cb3_price = 0
        End If

        total_price = cb1_price + cb2_price + cb3_price
        TextBox2.Text = total_price.ToString("N2")

    End Sub
End Class
