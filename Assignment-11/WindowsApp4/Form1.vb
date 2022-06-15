Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.Buku' table. You can move, or remove it, as needed.
        Me.BukuTableAdapter.Fill(Me.Database1DataSet1.Buku)
    End Sub

    Private Sub BTN_Clear_Click(sender As Object, e As EventArgs) Handles BTN_Clear.Click
        TB_Kode.Clear()
        TB_Judul.Clear()
        TB_Pengarang.Clear()
        TB_Penerbit.Clear()
        TB_Tahun.Clear()
        TB_Pencarian.Clear()
        TB_Pencarian.Focus()
    End Sub

    Private Sub BTN_Search_Click(sender As Object, e As EventArgs) Handles BTN_Search.Click
        Dim cari, iRowIndex

        cari = TB_Pencarian.Text

        For i = 0 To Database1DataSet1.Buku.Count - 1
            If Database1DataSet1.Buku.Rows(i).Item(0) = cari Then
                iRowIndex = i
                showData(iRowIndex)
                Exit For
            End If
        Next
    End Sub

    Public Sub showData(ByVal a As Integer)
        TB_Kode.Text() = Database1DataSet1.Buku.Rows(a).Item(0)
        TB_Judul.Text() = Database1DataSet1.Buku.Rows(a).Item(1)
        TB_Pengarang.Text() = Database1DataSet1.Buku.Rows(a).Item(2)
        TB_Penerbit.Text() = Database1DataSet1.Buku.Rows(a).Item(3)
        TB_Tahun.Text() = Database1DataSet1.Buku.Rows(a).Item(4)
    End Sub

    Private Sub BTN_Save_Click(sender As Object, e As EventArgs) Handles BTN_Save.Click
        Dim newBukuRow As Database1DataSet.BukuRow
        newBukuRow = Database1DataSet1.Buku.NewBukuRow()

        newBukuRow.kode = TB_Kode.Text()
        newBukuRow.judul = TB_Judul.Text()
        newBukuRow.pengarang = TB_Pengarang.Text()
        newBukuRow.penerbit = TB_Penerbit.Text()
        newBukuRow.tahun = TB_Tahun.Text()

        Database1DataSet1.Buku.Rows.Add(newBukuRow)
    End Sub
End Class
