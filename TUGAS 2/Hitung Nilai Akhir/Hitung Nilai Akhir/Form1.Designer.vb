<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAbsensi = New System.Windows.Forms.TextBox()
        Me.txtTugas = New System.Windows.Forms.TextBox()
        Me.txtUTS = New System.Windows.Forms.TextBox()
        Me.txtUAS = New System.Windows.Forms.TextBox()
        Me.txtNilaiAkhir = New System.Windows.Forms.TextBox()
        Me.txtHasilUas = New System.Windows.Forms.TextBox()
        Me.txtHasilUts = New System.Windows.Forms.TextBox()
        Me.txtHasilAbs = New System.Windows.Forms.TextBox()
        Me.txtHasilTugas = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nilai Absen "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai Tugas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nilai UTS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nilai UAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nilai Akhir"
        '
        'txtAbsensi
        '
        Me.txtAbsensi.Location = New System.Drawing.Point(170, 57)
        Me.txtAbsensi.Multiline = True
        Me.txtAbsensi.Name = "txtAbsensi"
        Me.txtAbsensi.Size = New System.Drawing.Size(96, 23)
        Me.txtAbsensi.TabIndex = 5
        '
        'txtTugas
        '
        Me.txtTugas.Location = New System.Drawing.Point(170, 106)
        Me.txtTugas.Name = "txtTugas"
        Me.txtTugas.Size = New System.Drawing.Size(96, 20)
        Me.txtTugas.TabIndex = 6
        '
        'txtUTS
        '
        Me.txtUTS.Location = New System.Drawing.Point(170, 155)
        Me.txtUTS.Name = "txtUTS"
        Me.txtUTS.Size = New System.Drawing.Size(96, 20)
        Me.txtUTS.TabIndex = 7
        '
        'txtUAS
        '
        Me.txtUAS.Location = New System.Drawing.Point(170, 202)
        Me.txtUAS.Name = "txtUAS"
        Me.txtUAS.Size = New System.Drawing.Size(96, 20)
        Me.txtUAS.TabIndex = 8
        '
        'txtNilaiAkhir
        '
        Me.txtNilaiAkhir.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNilaiAkhir.Location = New System.Drawing.Point(170, 250)
        Me.txtNilaiAkhir.Name = "txtNilaiAkhir"
        Me.txtNilaiAkhir.Size = New System.Drawing.Size(231, 20)
        Me.txtNilaiAkhir.TabIndex = 9
        '
        'txtHasilUas
        '
        Me.txtHasilUas.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtHasilUas.Location = New System.Drawing.Point(286, 202)
        Me.txtHasilUas.Name = "txtHasilUas"
        Me.txtHasilUas.Size = New System.Drawing.Size(115, 20)
        Me.txtHasilUas.TabIndex = 10
        '
        'txtHasilUts
        '
        Me.txtHasilUts.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtHasilUts.Location = New System.Drawing.Point(286, 155)
        Me.txtHasilUts.Name = "txtHasilUts"
        Me.txtHasilUts.Size = New System.Drawing.Size(115, 20)
        Me.txtHasilUts.TabIndex = 11
        '
        'txtHasilAbs
        '
        Me.txtHasilAbs.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtHasilAbs.Location = New System.Drawing.Point(286, 56)
        Me.txtHasilAbs.Multiline = True
        Me.txtHasilAbs.Name = "txtHasilAbs"
        Me.txtHasilAbs.Size = New System.Drawing.Size(115, 20)
        Me.txtHasilAbs.TabIndex = 12
        '
        'txtHasilTugas
        '
        Me.txtHasilTugas.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtHasilTugas.Location = New System.Drawing.Point(286, 105)
        Me.txtHasilTugas.Name = "txtHasilTugas"
        Me.txtHasilTugas.Size = New System.Drawing.Size(115, 20)
        Me.txtHasilTugas.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(137, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 37)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "HITUNG"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 392)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtHasilTugas)
        Me.Controls.Add(Me.txtHasilAbs)
        Me.Controls.Add(Me.txtHasilUts)
        Me.Controls.Add(Me.txtHasilUas)
        Me.Controls.Add(Me.txtNilaiAkhir)
        Me.Controls.Add(Me.txtUAS)
        Me.Controls.Add(Me.txtUTS)
        Me.Controls.Add(Me.txtTugas)
        Me.Controls.Add(Me.txtAbsensi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAbsensi As TextBox
    Friend WithEvents txtTugas As TextBox
    Friend WithEvents txtUTS As TextBox
    Friend WithEvents txtUAS As TextBox
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents txtHasilUas As TextBox
    Friend WithEvents txtHasilUts As TextBox
    Friend WithEvents txtHasilAbs As TextBox
    Friend WithEvents txtHasilTugas As TextBox
    Friend WithEvents Button1 As Button
End Class
