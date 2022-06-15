Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.Database1DataSet.Student)

        tb_jurusan.Items.Add("MI")
        tb_jurusan.Items.Add("TId3")
        tb_jurusan.Items.Add("KA")
        tb_jurusan.Items.Add("SI")
        tb_jurusan.Items.Add("TIs1")
        tb_jurusan.Items.Add("SK")

        For i As Integer = 0 To DataGridView1.Rows.Count - 2
            pick_nim.Items.Add(DataGridView1.Rows(i).Cells(0).Value)
        Next

    End Sub

    Private Sub pick_nim_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pick_nim.SelectedIndexChanged
        Dim index As Integer

        index = pick_nim.SelectedIndex

        tbs_nama.Text = DataGridView1.Rows(index).Cells(1).Value
        tbs_alamat.Text = DataGridView1.Rows(index).Cells(2).Value
        tbs_date.Text = DataGridView1.Rows(index).Cells(3).Value
        tbs_jurusan.Text = DataGridView1.Rows(index).Cells(4).Value
        tbs_konsentrasi.Text = DataGridView1.Rows(index).Cells(5).Value
    End Sub

    Private Sub BTN_Clear_Click(sender As Object, e As EventArgs) Handles BTN_Clear.Click
        tb_nim.Clear()
        tb_nama.Clear()
        tb_alamat.Clear()
        tb_date.Clear()
        tb_jurusan.ResetText()
        tb_konsentrasi.ResetText()
        tb_nim.Focus()
    End Sub

    Private Sub BTN_Delete_Click(sender As Object, e As EventArgs) Handles BTN_Delete.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            Dim result As DialogResult = MessageBox.Show("Yakin ingin menghapus data?", "Hapus Data", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                DataGridView1.Rows.Remove(row)
                MessageBox.Show("Data berhasil dihapus.")
            End If
        Next
    End Sub

    Private Sub BTN_Save_Click(sender As Object, e As EventArgs) Handles BTN_Save.Click
        Dim newStudentRow As Database1DataSet.StudentRow
        newStudentRow = Database1DataSet.Student.NewStudentRow()

        newStudentRow.nim = tb_nim.Text
        newStudentRow.nama = tb_nama.Text
        newStudentRow.alamat = tb_alamat.Text
        newStudentRow.tanggal_lahir = tb_date.Text
        newStudentRow.jurusan = tb_jurusan.Text
        newStudentRow.konsentrasi = tb_konsentrasi.Text

        Database1DataSet.Student.Rows.Add(newStudentRow)
    End Sub

    Private Sub BTN_Exit_Click(sender As Object, e As EventArgs) Handles BTN_Exit.Click
        Me.Close()
    End Sub

    Private Sub tb_jurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tb_jurusan.SelectedIndexChanged
        Dim jurusan

        jurusan = tb_jurusan.Text

        If jurusan = "MI" Then
            tb_konsentrasi.Items.Clear()
            tb_konsentrasi.Items.Add("SIM")
            tb_konsentrasi.Items.Add("WGD")
        ElseIf jurusan = "TId3" Then
            tb_konsentrasi.Items.Clear()
            tb_konsentrasi.Items.Add("AI")
            tb_konsentrasi.Items.Add("CA")
        ElseIf jurusan = "KA" Then
            tb_konsentrasi.Items.Clear()
            tb_konsentrasi.Items.Add("WBAS")
            tb_konsentrasi.Items.Add("FINANCE")
        ElseIf jurusan = "SI" Then
            tb_konsentrasi.Items.Clear()
            tb_konsentrasi.Items.Add("BI")
            tb_konsentrasi.Items.Add("SIM")
            tb_konsentrasi.Items.Add("AKUTANSI")
        ElseIf jurusan = "TIs1" Then
            tb_konsentrasi.Items.Clear()
            tb_konsentrasi.Items.Add("MAVIB")
            tb_konsentrasi.Items.Add("SE")
        Else
            tb_konsentrasi.Items.Clear()
            tb_konsentrasi.Items.Add("CCIT")
            tb_konsentrasi.Items.Add("COS")
        End If
    End Sub

End Class
