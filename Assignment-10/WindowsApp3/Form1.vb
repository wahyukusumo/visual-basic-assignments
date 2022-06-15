Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Pelanggan' table. You can move, or remove it, as needed.
        Me.PelangganTableAdapter.Fill(Me.Database1DataSet.Pelanggan)

        CB_JenisBarang.Items.Add("Revo CW")
        CB_JenisBarang.Items.Add("Revo Techno AT")
        CB_JenisBarang.Items.Add("Supra X 125 CW")
        CB_JenisBarang.Items.Add("Blade Repsol")

        CB_Pembelian.Items.Add("Cash")
        CB_Pembelian.Items.Add("Kredit")

        DataGridView1.CurrentCell = DataGridView1.Item(1, 1)
    End Sub

    Private Sub CB_JenisBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_JenisBarang.SelectedIndexChanged
        Select Case (CB_JenisBarang.SelectedIndex)
            Case 0
                TB_Harga.Text = 15000000
            Case 1
                TB_Harga.Text = 17000000
            Case 2
                TB_Harga.Text = 18000000
            Case 3
                TB_Harga.Text = 20000000
        End Select
    End Sub

    Private Sub CB_Pembelian_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Pembelian.SelectedIndexChanged
        Select Case (CB_Pembelian.SelectedIndex)
            Case 0
                TB_Diskon.Text = 30 / 100 * Val(TB_JumlahBayar.Text)
            Case 1
                TB_Diskon.Text = 0
        End Select

        TB_TotalBayar.Text = Val(TB_JumlahBayar.Text()) - Val(TB_Diskon.Text())
    End Sub

    Private Sub BTN_Transaction_Click(sender As Object, e As EventArgs) Handles BTN_Transaction.Click
        TB_Nama.Clear()
        TB_Harga.Clear()
        TB_JumlahBeli.Clear()
        TB_JumlahBayar.Clear()
        TB_Diskon.Clear()
        TB_TotalBayar.Clear()
        CB_JenisBarang.ResetText()
        CB_Pembelian.ResetText()
        TB_Nama.Focus()

    End Sub
    Private Sub TB_JumlahBeli_TextChanged(sender As Object, e As EventArgs) Handles TB_JumlahBeli.TextChanged
        TB_JumlahBayar.Text = Val(TB_JumlahBeli.Text()) * Val(TB_Harga.Text())
    End Sub

    Private Sub BTN_Delete_Click(sender As Object, e As EventArgs) Handles BTN_Delete.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next
    End Sub

    Private Sub BTN_Save_Click(sender As Object, e As EventArgs) Handles BTN_Save.Click
        Dim newPelangganRow As Database1DataSet.PelangganRow
        newPelangganRow = Database1DataSet.Pelanggan.NewPelangganRow()

        newPelangganRow.nama_customer = TB_Nama.Text
        newPelangganRow.jenis_barang = CB_JenisBarang.Text
        newPelangganRow.harga = TB_Harga.Text
        newPelangganRow.jumlah_beli = TB_JumlahBeli.Text
        newPelangganRow.jumlah_bayar = TB_JumlahBayar.Text
        newPelangganRow.pembelian = CB_Pembelian.Text
        newPelangganRow.diskon = TB_Diskon.Text
        newPelangganRow.total_bayar = TB_TotalBayar.Text

        Database1DataSet.Pelanggan.Rows.Add(newPelangganRow)
    End Sub

End Class
