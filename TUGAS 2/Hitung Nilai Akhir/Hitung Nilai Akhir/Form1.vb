Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NilaiAbs As Byte
        Dim NilaiTugas As Byte
        Dim NilaiUTS As Byte
        Dim NilaiUAS As Byte
        Dim NilaiAkhir As Byte


        NilaiAbs = txtAbsensi.Text
        NilaiAbs = (NilaiAbs * 10) / 100
        txtHasilAbs.Text = NilaiAbs

        NilaiTugas = txtTugas.Text
        NilaiTugas = (NilaiTugas * 20) / 100
        txtHasilTugas.Text = NilaiTugas

        NilaiUTS = txtUTS.Text
        NilaiUTS = (NilaiUTS * 30) / 100
        txtHasilUts.Text = NilaiUTS

        NilaiUAS = txtUAS.Text
        NilaiUAS = (NilaiUAS * 40) / 100
        txtHasilUas.Text = NilaiUAS

        NilaiAkhir = NilaiAbs + NilaiTugas + NilaiUTS + NilaiUAS
        txtNilaiAkhir.Text = NilaiAkhir

    End Sub
End Class
