Public Class Form1

    Dim harga, jumlahSewa, diskon, jumlahBayar, totalBayar
    Dim minval As Integer = 0
    Dim maxval As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Pelanggan' table. You can move, or remove it, as needed.
        Me.PelangganTableAdapter.Fill(Me.Database1DataSet.Pelanggan)

        ' Add item to combo box
        ComboBox_Status.Items.Add("Pelajar")
        ComboBox_Status.Items.Add("Umum")
        ComboBox_Status.Items.Add("Mahasiswa")

        maxval = Database1DataSet.Pelanggan.Rows.Count
    End Sub

    Private Sub ButtonClean_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        TextBox_Nama.Clear()
        ComboBox_Status.ResetText()
        TextBox_Harga.Clear()
        TextBox_JumlahSewa.Clear()
        TextBox_Diskon.Clear()
        TextBox_JumlahBayar.Clear()
        TextBox_TotalBayar.Clear()
        TextBox_Nama.Focus()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        Dim newPelangganRow As Database1DataSet.PelangganRow
        newPelangganRow = Database1DataSet.Pelanggan.NewPelangganRow()

        newPelangganRow.nama = TextBox_Nama.Text
        newPelangganRow.status = ComboBox_Status.Text
        newPelangganRow.harga = TextBox_Harga.Text
        newPelangganRow.jumlah_sewa = TextBox_JumlahSewa.Text
        newPelangganRow.diskon = TextBox_Diskon.Text
        newPelangganRow.jumlah_bayar = TextBox_JumlahBayar.Text
        newPelangganRow.total_bayar = TextBox_TotalBayar.Text

        Database1DataSet.Pelanggan.Rows.Add(newPelangganRow)

    End Sub

    Private Sub Button_Calculate_Click(sender As Object, e As EventArgs) Handles Button_Calculate.Click
        harga = TextBox_Harga.Text
        jumlahSewa = TextBox_JumlahSewa.Text

        If jumlahSewa > 3 Then
            diskon = 3000
        Else
            diskon = 0
        End If

        jumlahBayar = jumlahSewa * harga
        totalBayar = jumlahBayar - diskon

        TextBox_Diskon.Text = diskon
        TextBox_JumlahBayar.Text = jumlahBayar
        TextBox_TotalBayar.Text = totalBayar
    End Sub

    Private Sub Button_Exit_Click(sender As Object, e As EventArgs) Handles Button_Exit.Click
        Me.Close()
    End Sub

    Private Sub ComboBox_Status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Status.SelectedIndexChanged
        If ComboBox_Status.Text = "Pelajar" Then
            harga = 50000
        ElseIf ComboBox_Status.Text = "Umum" Then
            harga = 65000
        Else
            harga = 45000
        End If

        TextBox_Harga.Text = harga
    End Sub

    Public Sub nav(ByVal a As Integer)
        TextBox_Show_Nama.Text = Database1DataSet.Pelanggan.Rows(a).Item(1)
        TextBox_Show_Status.Text = Database1DataSet.Pelanggan.Rows(a).Item(2)
        TextBox_Show_Harga.Text = Database1DataSet.Pelanggan.Rows(a).Item(3)
        TextBox_Show_JumlahSewa.Text = Database1DataSet.Pelanggan.Rows(a).Item(4)
        TextBox_Show_Diskon.Text = Database1DataSet.Pelanggan.Rows(a).Item(5)
        TextBox_Show_JumlahBayar.Text = Database1DataSet.Pelanggan.Rows(a).Item(6)
        TextBox_Show_TotalBayar.Text = Database1DataSet.Pelanggan.Rows(a).Item(7)
    End Sub

    Private Sub Button_First_Click(sender As Object, e As EventArgs) Handles Button_First.Click
        If minval <> 0 Then
            minval = 0
            nav(minval)
        End If
    End Sub

    Private Sub Button_Last_Click(sender As Object, e As EventArgs) Handles Button_Last.Click
        If minval <> maxval Then
            minval = maxval - 1
            nav(minval)
        End If
    End Sub

    Private Sub Button_Prev_Click(sender As Object, e As EventArgs) Handles Button_Prev.Click
        If minval > 0 Then
            'minval will be decremented by one
            minval = minval - 1
            nav(minval)
        ElseIf minval = -1 Then
            MsgBox("No results found!")
        ElseIf minval = 0 Then
            MsgBox("First Record")
            nav(minval)
        End If
    End Sub

    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        If minval <> maxval - 1 Then
            'minval is incremented by 1
            minval = minval + 1
            'throw the value of minval to nav procedure
            nav(minval)
        Else
            MsgBox("Last record!")
        End If
    End Sub

End Class
