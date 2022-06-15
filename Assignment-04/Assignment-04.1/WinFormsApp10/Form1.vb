Public Class Form1

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub ButtonProcess_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim J_Kel
        Dim Tinggi
        Dim PesanLulus
        Dim PesanGagal

        J_Kel = TextBox2.Text
        Tinggi = TextBox3.Text

        PesanLulus = "Anda Lulus."
        PesanGagal = "Maaf, Tinggi badan anda belum memenuhi syarat."

        If J_Kel = 1 Then
            If Tinggi >= 165 Then
                TextBox4.Text = PesanLulus
            Else
                TextBox4.Text = PesanGagal
            End If
        ElseIf J_Kel = 2 Then
            If Tinggi >= 160 Then
                TextBox4.Text = PesanLulus
            Else
                TextBox4.Text = PesanGagal
            End If
        End If
    End Sub
End Class
