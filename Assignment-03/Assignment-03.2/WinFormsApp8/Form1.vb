Public Class Form1
    Private Sub Button_Input_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button_Remove_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Button_Move_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox2.Items.Add(ListBox1.SelectedItem)
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("John Doe")
        ListBox1.Items.Add("Dimas Aji")
        ListBox1.Items.Add("Wahyu Kusumo")
    End Sub
End Class
