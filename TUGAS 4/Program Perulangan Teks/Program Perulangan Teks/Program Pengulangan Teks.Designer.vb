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
        Me.txtteks = New System.Windows.Forms.TextBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.List1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tuliskan Teks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jumlah Pengulangan "
        '
        'txtteks
        '
        Me.txtteks.Location = New System.Drawing.Point(241, 68)
        Me.txtteks.Name = "txtteks"
        Me.txtteks.Size = New System.Drawing.Size(162, 20)
        Me.txtteks.TabIndex = 2
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(241, 118)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(162, 20)
        Me.txtjumlah.TabIndex = 3
        '
        'List1
        '
        Me.List1.FormattingEnabled = True
        Me.List1.Location = New System.Drawing.Point(76, 217)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(327, 95)
        Me.List1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(241, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 28)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Proses"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(129, 333)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 28)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(301, 333)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 28)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Keluar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 470)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.txtteks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Program Pengulangan Teks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtteks As TextBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents List1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
