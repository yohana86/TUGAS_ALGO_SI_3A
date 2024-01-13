Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(TextBox1.Text & vbCrLf & TextBox2.Text & vbCrLf & ComboBox1.Text & vbCrLf & ComboBox2.Text, "Hasil Pengisian",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
