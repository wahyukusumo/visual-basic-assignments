Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.Database1DataSet.Table)

        ComboBox1.Items.Add("nim")
        ComboBox1.Items.Add("nama")
        ComboBox1.Items.Add("alamat")
        ComboBox1.Items.Add("jenis_kelamin")
        ComboBox1.Items.Add("agama")
        ComboBox1.Items.Add("jurusan")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dataColumn, sortMethod

        dataColumn = ComboBox1.Text

        If RadioButton1.Checked Then
            sortMethod = System.ComponentModel.ListSortDirection.Ascending
        Else
            sortMethod = System.ComponentModel.ListSortDirection.Descending
        End If

        DataGridView1.Sort(DataGridView1.Columns(dataColumn), sortMethod)
    End Sub
End Class
