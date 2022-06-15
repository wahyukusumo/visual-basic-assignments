Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tambah item ke combobox, Menu dan Paket.
        ComboBoxMenu.Items.Add("Sarapan Pagi")
        ComboBoxMenu.Items.Add("Makan Siang")
        ComboBoxPaket.Items.Add("Paket 1")
        ComboBoxPaket.Items.Add("Paket 2")
    End Sub

    Private Sub ButtonQuit_Click(sender As Object, e As EventArgs) Handles ButtonQuit.Click
        Dim popQuit = MsgBox("Mau Keluar?", vbQuestion + vbOKCancel, "Informasi")
        If popQuit = vbOK Then
            End
        End If
    End Sub

    Private Sub ButtonNewTransaction_Click(sender As Object, e As EventArgs) Handles ButtonNewTransaction.Click
        ' Reset semua value
        ComboBoxMenu.ResetText()
        ComboBoxPaket.ResetText()
        ListMenu.Items.Clear()
        HargaFasilitas.Clear()
        HargaMakanan.Clear()
        HargaMinuman.Clear()
        CB_IceTea.Checked = False
        CB_Water.Checked = False
        RB_Delivery.Checked = False
        RB_MakanDiTempat.Checked = False
        InputJumlahBeli.Clear()
        JumlahTotalBayar.Clear()
        InputUangBayar.Clear()
        JumlahKembalian.Clear()
    End Sub

    Private Sub ComboBoxPaket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPaket.SelectedIndexChanged
        If ComboBoxMenu.Text = "Sarapan Pagi" Then
            Select Case ComboBoxPaket.Text
                Case "Paket 1"
                    ListMenu.Items.Clear()
                    ListMenu.Items.Add("Nasi Uduk")
                    ListMenu.Items.Add("Bihun")
                    ListMenu.Items.Add("Semur Tahu")
                    HargaMakanan.Text = 5000
                Case "Paket 2"
                    ListMenu.Items.Clear()
                    ListMenu.Items.Add("Nasi Goreng")
                    ListMenu.Items.Add("Telur")
                    ListMenu.Items.Add("Tempe Goreng")
                    HargaMakanan.Text = 8000
            End Select
        Else
            Select Case ComboBoxPaket.Text
                Case "Paket 1"
                    ListMenu.Items.Clear()
                    ListMenu.Items.Add("Nasi Putih")
                    ListMenu.Items.Add("Ayam Bakar")
                    ListMenu.Items.Add("Lalapan")
                    HargaMakanan.Text = 20000
                Case "Paket 2"
                    ListMenu.Items.Clear()
                    ListMenu.Items.Add("Nasi Putih")
                    ListMenu.Items.Add("Rendang")
                    ListMenu.Items.Add("Sambal Ijo")
                    HargaMakanan.Text = 25000
            End Select
        End If
    End Sub

    Private Sub CB_IceTea_CheckedChanged(sender As Object, e As EventArgs) Handles CB_IceTea.CheckedChanged
        ' Variabel untuk cek status checkbox
        Dim IceTea_Check = CB_IceTea.Checked = True
        Dim IceTea_Uncheck = CB_IceTea.Checked = False
        Dim Water_Check = CB_Water.Checked = True
        Dim Water_Uncheck = CB_Water.Checked = False

        If IceTea_Check And Water_Check Then
            HargaMinuman.Text = 3000
        ElseIf IceTea_Check And Water_Uncheck Then
            HargaMinuman.Text = 2500
        ElseIf IceTea_Uncheck And Water_Check Then
            HargaMinuman.Text = 500
        ElseIf IceTea_Uncheck And Water_Uncheck Then
            HargaMinuman.Text = 0
        End If
    End Sub

    Private Sub CB_Water_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Water.CheckedChanged
        ' Variabel untuk cek status checkbox
        Dim IceTea_Check = CB_IceTea.Checked = True
        Dim IceTea_Uncheck = CB_IceTea.Checked = False
        Dim Water_Check = CB_Water.Checked = True
        Dim Water_Uncheck = CB_Water.Checked = False

        If IceTea_Check And Water_Check Then
            HargaMinuman.Text = 3000
        ElseIf IceTea_Check And Water_Uncheck Then
            HargaMinuman.Text = 2500
        ElseIf IceTea_Uncheck And Water_Check Then
            HargaMinuman.Text = 500
        ElseIf IceTea_Uncheck And Water_Uncheck Then
            HargaMinuman.Text = 0
        End If
    End Sub

    Private Sub RB_Delivery_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Delivery.CheckedChanged
        HargaFasilitas.Text = 5000
    End Sub

    Private Sub RB_MakanDiTempat_CheckedChanged(sender As Object, e As EventArgs) Handles RB_MakanDiTempat.CheckedChanged
        HargaFasilitas.Text = 0
    End Sub

    Private Sub JumlahTotalBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles JumlahTotalBayar.KeyPress
        ' ASCII 13 adalah tombol Enter.
        ' Jika tombol Enter ditekan maka kode akan dieksekusi.
        If Asc(e.KeyChar) = 13 Then
            Dim TotalHargaMenu
            TotalHargaMenu = Val(HargaMakanan.Text) + Val(HargaMinuman.Text) + Val(HargaFasilitas.Text)
            JumlahTotalBayar.Text = Val(InputJumlahBeli.Text) * TotalHargaMenu
        End If
    End Sub

    Private Sub JumlahKembalian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles JumlahKembalian.KeyPress
        If Asc(e.KeyChar) = 13 Then
            JumlahKembalian.Text = Val(InputUangBayar.Text) - Val(JumlahTotalBayar.Text)
        End If
    End Sub

End Class
