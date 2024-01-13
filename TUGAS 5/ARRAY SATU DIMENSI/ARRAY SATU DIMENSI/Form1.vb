Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("NIM")
        ListView1.Columns.Add("NAMA", 115)
        ListView1.Columns.Add("PRODI", 110)
        txtnim.Text = 1
        txtnama.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arr(2) As String
        arr(0) = txtnim.Text
        arr(1) = txtnama.Text
        arr(2) = txtprodi.Text

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(arr(0))
        listitem.SubItems.Add(arr(1))
        listitem.SubItems.Add(arr(2))
        txtnim.Text = txtnim.Text + 1
        txtnama.Text = ""
        txtprodi.Focus()

    End Sub
End Class
