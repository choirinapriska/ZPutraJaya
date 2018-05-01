<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbsensi
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboKeterangan = New System.Windows.Forms.ComboBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridAbsensi = New System.Windows.Forms.DataGridView()
        Me.ComboPegawai = New System.Windows.Forms.ComboBox()
        Me.LabelIDData = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.DateAbsensi = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridAbsensi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pegawai"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Keterangan"
        '
        'ComboKeterangan
        '
        Me.ComboKeterangan.FormattingEnabled = True
        Me.ComboKeterangan.Items.AddRange(New Object() {"Masuk", "Ijin", "Alpa"})
        Me.ComboKeterangan.Location = New System.Drawing.Point(189, 187)
        Me.ComboKeterangan.Name = "ComboKeterangan"
        Me.ComboKeterangan.Size = New System.Drawing.Size(158, 21)
        Me.ComboKeterangan.TabIndex = 7
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(314, 235)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 8
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.Label5.Location = New System.Drawing.Point(352, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 46)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ABSENSI"
        '
        'DataGridAbsensi
        '
        Me.DataGridAbsensi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAbsensi.Location = New System.Drawing.Point(464, 107)
        Me.DataGridAbsensi.Name = "DataGridAbsensi"
        Me.DataGridAbsensi.Size = New System.Drawing.Size(423, 317)
        Me.DataGridAbsensi.TabIndex = 11
        '
        'ComboPegawai
        '
        Me.ComboPegawai.FormattingEnabled = True
        Me.ComboPegawai.Items.AddRange(New Object() {"Masuk", "Ijin", "Alpa"})
        Me.ComboPegawai.Location = New System.Drawing.Point(189, 117)
        Me.ComboPegawai.Name = "ComboPegawai"
        Me.ComboPegawai.Size = New System.Drawing.Size(158, 21)
        Me.ComboPegawai.TabIndex = 12
        '
        'LabelIDData
        '
        Me.LabelIDData.AutoSize = True
        Me.LabelIDData.Location = New System.Drawing.Point(506, 452)
        Me.LabelIDData.Name = "LabelIDData"
        Me.LabelIDData.Size = New System.Drawing.Size(0, 13)
        Me.LabelIDData.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(461, 452)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "ID : "
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(812, 452)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelete.TabIndex = 51
        Me.ButtonDelete.Text = "Hapus"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        Me.ButtonDelete.Visible = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(796, 441)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(0, 13)
        Me.LabelStatus.TabIndex = 50
        '
        'DateAbsensi
        '
        Me.DateAbsensi.Location = New System.Drawing.Point(189, 155)
        Me.DateAbsensi.Name = "DateAbsensi"
        Me.DateAbsensi.Size = New System.Drawing.Size(200, 20)
        Me.DateAbsensi.TabIndex = 54
        '
        'FormAbsensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 487)
        Me.Controls.Add(Me.DateAbsensi)
        Me.Controls.Add(Me.LabelIDData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.ComboPegawai)
        Me.Controls.Add(Me.DataGridAbsensi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ComboKeterangan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormAbsensi"
        Me.Text = "Form1"
        CType(Me.DataGridAbsensi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboKeterangan As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridAbsensi As System.Windows.Forms.DataGridView
    Friend WithEvents ComboPegawai As System.Windows.Forms.ComboBox
    Friend WithEvents LabelIDData As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents DateAbsensi As System.Windows.Forms.DateTimePicker

End Class
