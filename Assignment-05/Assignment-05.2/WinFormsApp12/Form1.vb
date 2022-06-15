Public Class Form1
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
    End Sub

    Private Sub ButtonSelesai_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim jumlah, diskon, total, harga, jumlahBayar As Integer
        Dim nama, bonus As String

        jumlah = TextBox1.Text

        If ComboBox1.Text = "1" Then
            nama = "Cara Sukses Belajar Visual Basic"
            harga = 50000
        ElseIf ComboBox1.Text = "2" Then
            nama = "Pemrograman Visual Basic"
            harga = 65000
        ElseIf ComboBox1.Text = "3" Then
            nama = "Belajar Visual Basic"
            harga = 70000
        End If

        total = jumlah * harga

        TextBox2.Text = nama
        TextBox3.Text = harga.ToString("N")
        TextBox4.Text = jumlah

        If jumlah > 5 Then
            diskon = total * 30 / 100
        Else
            diskon = 0
        End If

        jumlahBayar = total - diskon

        If diskon = 0 Then
            bonus = "Anda tidak mendapatkan bonus."
        Else
            bonus = "Notebook"
        End If

        TextBox5.Text = total.ToString("N")
        TextBox6.Text = diskon.ToString("N")
        TextBox7.Text = jumlahBayar.ToString("N")
        TextBox8.Text = bonus

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")
    End Sub
End Class
