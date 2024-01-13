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
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtnim = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbkelamin = New System.Windows.Forms.ComboBox()
        Me.cbprodi = New System.Windows.Forms.ComboBox()
        Me.bproses = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(181, 130)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(170, 20)
        Me.txtnama.TabIndex = 8
        '
        'txtnim
        '
        Me.txtnim.Location = New System.Drawing.Point(181, 82)
        Me.txtnim.Name = "txtnim"
        Me.txtnim.Size = New System.Drawing.Size(170, 20)
        Me.txtnim.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "NAMA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NIM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "PRODI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "JENIS KELAMIN"
        '
        'cbkelamin
        '
        Me.cbkelamin.FormattingEnabled = True
        Me.cbkelamin.Location = New System.Drawing.Point(181, 169)
        Me.cbkelamin.Name = "cbkelamin"
        Me.cbkelamin.Size = New System.Drawing.Size(170, 21)
        Me.cbkelamin.TabIndex = 11
        '
        'cbprodi
        '
        Me.cbprodi.FormattingEnabled = True
        Me.cbprodi.Location = New System.Drawing.Point(181, 224)
        Me.cbprodi.Name = "cbprodi"
        Me.cbprodi.Size = New System.Drawing.Size(170, 21)
        Me.cbprodi.TabIndex = 12
        '
        'bproses
        '
        Me.bproses.Location = New System.Drawing.Point(154, 275)
        Me.bproses.Name = "bproses"
        Me.bproses.Size = New System.Drawing.Size(118, 34)
        Me.bproses.TabIndex = 13
        Me.bproses.Text = "PROSES"
        Me.bproses.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(60, 332)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(484, 97)
        Me.ListView1.TabIndex = 14
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NIM"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 457)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.bproses)
        Me.Controls.Add(Me.cbprodi)
        Me.Controls.Add(Me.cbkelamin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnim)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtnim As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbkelamin As ComboBox
    Friend WithEvents cbprodi As ComboBox
    Friend WithEvents bproses As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
