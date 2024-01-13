Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim teks As String
        Dim jumlah As Integer
        teks = txtteks.Text
        jumlah = txtjumlah.Text
        For i = 1 To jumlah
            List1.items.add(teks)
        Next i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtteks.Text = ""
        txtjumlah.Text = ""
        List1.Items.Clear()
    End Sub
End Class
