Public Class Form1
    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gajiPokok, tunjangan, hitungTotalGaji As Integer

        '.ToString("N2") digunakan agar angka lebih mudah dibaca, ex: 50000 -> 50,000.00
        tunjangan = Val(TextBox3.Text) * 50000
        TextBox4.Text = tunjangan.ToString("N2") 'Tunjangan anak

        'Tentukan gaji pokok berdasarkan lama kerja.
        If TextBox2.Text > 3 Then
            gajiPokok = 3500000
            TextBox5.Text = gajiPokok.ToString("N2")
        Else
            gajiPokok = 3000000
            TextBox5.Text = gajiPokok.ToString("N2")
        End If

        ' Hitung total gaji, tunjangan + gaji pokok.
        hitungTotalGaji = tunjangan + gajiPokok
        TextBox6.Text = hitungTotalGaji.ToString("N2")

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
