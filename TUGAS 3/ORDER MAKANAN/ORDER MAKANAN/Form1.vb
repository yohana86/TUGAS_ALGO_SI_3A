Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Public hrgmakanan, hrgminuman As Integer

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Es Jeruk"
                Label5.Text = "Rp. 5000"
                hrgminuman = 5000
            Case "Jus Alpukat"
                Label5.Text = "Rp. 10000"
                hrgminuman = 10000
            Case "Teh Manis"
                Label5.Text = "Rp. 7000"
                hrgminuman = 7000
        End Select
    End Sub
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ComboBox2.Visible = True
        Label4.Visible = True
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim porsimkn, porsimnm, jumlah As Integer
        porsimkn = TextBox1.Text
        porsimnm = TextBox2.Text
        jumlah = (hrgmakanan * porsimkn) + (hrgminuman * porsimnm)
        Label8.Text = "Rp. " & jumlah.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Mie Ayam Bakso"
                Label3.Text = "Rp. 15000"
                hrgmakanan = 15000
            Case "Bakso"
                Label3.Text = "Rp. 12000"
                hrgmakanan = 12000
            Case "Mie Ayam"
                Label3.Text = "Rp. 10000"
                hrgmakanan = 10000
        End Select
    End Sub
End Class

