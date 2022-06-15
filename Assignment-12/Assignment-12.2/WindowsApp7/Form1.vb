Public Class Form1

    Dim minval As Integer = 0
    Dim maxval As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Dosen' table. You can move, or remove it, as needed.
        Me.DosenTableAdapter.Fill(Me.Database1DataSet.Dosen)
    End Sub

    Public Sub nav(ByVal a As Integer)
        TextBox1.Text = Database1DataSet.Dosen.Rows(a).Item(0)
        TextBox2.Text = Database1DataSet.Dosen.Rows(a).Item(1)
        TextBox3.Text = Database1DataSet.Dosen.Rows(a).Item(2)
        TextBox4.Text = Database1DataSet.Dosen.Rows(a).Item(3)
        TextBox5.Text = Database1DataSet.Dosen.Rows(a).Item(4)
        TextBox6.Text = Database1DataSet.Dosen.Rows(a).Item(5)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newDosenRow As Database1DataSet.DosenRow
        newDosenRow = Database1DataSet.Dosen.NewDosenRow()

        newDosenRow.kode = TextBox1.Text
        newDosenRow.nama = TextBox2.Text
        newDosenRow.jenis_kelamin = TextBox3.Text
        newDosenRow.agama = TextBox4.Text
        newDosenRow.alamat = TextBox5.Text
        newDosenRow.pendidikan = TextBox6.Text

        Database1DataSet.Dosen.Rows.Add(newDosenRow)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If minval <> maxval - 1 Then
            'minval is incremented by 1
            minval = minval + 1
            'throw the value of minval to nav procedure
            nav(minval)
        Else
            MsgBox("Last record!")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

End Class
