Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nilaiAbsen, nilaiTugas, nilaiUTS, nilaiUAS, nilaiAkhir
        nilaiAbsen = Val(TextBox1.Text) * 10 / 100
        nilaiTugas = Val(TextBox2.Text) * 20 / 100
        nilaiUTS = Val(TextBox3.Text) * 30 / 100
        nilaiUAS = Val(TextBox1.Text) * 40 / 100

        nilaiAkhir = nilaiAbsen + nilaiTugas + nilaiUTS + nilaiUAS
        TextBox5.Text = nilaiAkhir

        Select Case nilaiAkhir
            Case 0 To 39
                TextBox6.Text = "E"
            Case 40 To 49
                TextBox6.Text = "D"
            Case 50 To 69
                TextBox6.Text = "C"
            Case 70 To 89
                TextBox6.Text = "B"
            Case 90 To 100
                TextBox6.Text = "A"
        End Select
    End Sub
End Class
