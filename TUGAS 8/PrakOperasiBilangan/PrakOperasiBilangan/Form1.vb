Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim angka1, angka2, hasil As Single

        angka1 = txtangka1.Text
        angka2 = txtangka2.Text

        If RadioButton1.Checked = True Then
            hasil = Math.Sqrt(angka1)
            txthasil.Text = hasil
        ElseIf RadioButton2.Checked = True Then
            hasil = angka1 ^ angka2
            txthasil.Text = hasil
        ElseIf RadioButton3.Checked = True Then
            hasil = angka1 / angka2
            txthasil.Text = hasil
        ElseIf RadioButton4.Checked = True Then
            hasil = angka1 + angka2
            txthasil.Text = hasil
        ElseIf RadioButton5.Checked = True Then
            hasil = angka1 - angka2
            txthasil.Text = hasil
        ElseIf RadioButton6.Checked = True Then
            hasil = angka1 * angka2
            txthasil.Text = hasil
        End If

    End Sub
End Class
