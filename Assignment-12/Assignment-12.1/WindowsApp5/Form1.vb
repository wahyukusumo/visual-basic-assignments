Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Pelanggan' table. You can move, or remove it, as needed.
        Me.PelangganTableAdapter.Fill(Me.Database1DataSet.Pelanggan)

        CB_Kamar.Items.Add("Standard")
        CB_Kamar.Items.Add("Superior")
        CB_Kamar.Items.Add("Deluxe")
    End Sub

    Private Sub BTN_Clear_Click(sender As Object, e As EventArgs) Handles BTN_Clear.Click
        TB_ID.Clear()
        TB_Nama.Clear()
        CB_Kamar.ResetText()
        TB_Harga.Clear()
        TB_Hari.Clear()
        TB_JumlahBayar.Clear()
        TB_Diskon.Clear()
        TB_TotalBayar.Clear()
        TB_ID.Focus()
    End Sub

    Private Sub BTN_Exit_Click(sender As Object, e As EventArgs) Handles BTN_Exit.Click
        Me.Close()
    End Sub

    Private Sub TB_Hari_TextChanged(sender As Object, e As EventArgs) Handles TB_Hari.TextChanged
        TB_JumlahBayar.Text = Val(TB_Harga.Text) * Val(TB_Hari.Text)
    End Sub

    Private Sub BTN_Calculate_Click(sender As Object, e As EventArgs) Handles BTN_Calculate.Click
        Dim jumlahBayar As Integer
        jumlahBayar = TB_JumlahBayar.Text

        If jumlahBayar > 3000000 Then
            TB_Diskon.Text = 30 / 100 * jumlahBayar
        ElseIf jumlahBayar > 2000000 Then
            TB_Diskon.Text = 20 / 100 * jumlahBayar
        Else
            TB_Diskon.Text = 0
        End If

        TB_TotalBayar.Text = jumlahBayar - Val(TB_Diskon.Text)

    End Sub

    Private Sub CB_Kamar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Kamar.SelectedIndexChanged
        If CB_Kamar.Text = "Standard" Then
            TB_Harga.Text = 500000
        ElseIf CB_Kamar.Text = "Superior" Then
            TB_Harga.Text = 750000
        Else
            TB_Harga.Text = 1000000
        End If
    End Sub

    Private Sub BTN_Save_Click(sender As Object, e As EventArgs) Handles BTN_Save.Click
        Dim newPelangganRow As Database1DataSet.PelangganRow
        newPelangganRow = Database1DataSet.Pelanggan.NewPelangganRow()

        newPelangganRow.Id = TB_ID.Text
        newPelangganRow.nama = TB_Nama.Text
        newPelangganRow.kamar = CB_Kamar.Text
        newPelangganRow.harga = TB_Harga.Text
        newPelangganRow.hari = TB_Hari.Text
        newPelangganRow.jumlah_bayar = TB_JumlahBayar.Text
        newPelangganRow.diskon = TB_Diskon.Text
        newPelangganRow.total_bayar = TB_TotalBayar.Text

        Database1DataSet.Pelanggan.Rows.Add(newPelangganRow)
    End Sub

    Private Sub BTN_Delete_Click(sender As Object, e As EventArgs) Handles BTN_Delete.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next
    End Sub

End Class
