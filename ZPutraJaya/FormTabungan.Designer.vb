<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTabungan
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelIDData = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ComboPegawai = New System.Windows.Forms.ComboBox()
        Me.DataGridTabungan = New System.Windows.Forms.DataGridView()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxJumlah = New System.Windows.Forms.TextBox()
        CType(Me.DataGridTabungan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.Label6.Location = New System.Drawing.Point(54, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(243, 46)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "TABUNGAN"
        '
        'LabelIDData
        '
        Me.LabelIDData.AutoSize = True
        Me.LabelIDData.Location = New System.Drawing.Point(84, 437)
        Me.LabelIDData.Name = "LabelIDData"
        Me.LabelIDData.Size = New System.Drawing.Size(0, 13)
        Me.LabelIDData.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 437)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "ID : "
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(294, 437)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelete.TabIndex = 64
        Me.ButtonDelete.Text = "Hapus"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        Me.ButtonDelete.Visible = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(278, 426)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(0, 13)
        Me.LabelStatus.TabIndex = 63
        '
        'ComboPegawai
        '
        Me.ComboPegawai.FormattingEnabled = True
        Me.ComboPegawai.Items.AddRange(New Object() {"Masuk", "Ijin", "Alpa"})
        Me.ComboPegawai.Location = New System.Drawing.Point(169, 106)
        Me.ComboPegawai.Name = "ComboPegawai"
        Me.ComboPegawai.Size = New System.Drawing.Size(158, 21)
        Me.ComboPegawai.TabIndex = 62
        '
        'DataGridTabungan
        '
        Me.DataGridTabungan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTabungan.Location = New System.Drawing.Point(37, 187)
        Me.DataGridTabungan.Name = "DataGridTabungan"
        Me.DataGridTabungan.Size = New System.Drawing.Size(332, 214)
        Me.DataGridTabungan.TabIndex = 61
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(295, 148)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 59
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Jumlah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Pegawai"
        '
        'TextBoxJumlah
        '
        Me.TextBoxJumlah.Location = New System.Drawing.Point(169, 148)
        Me.TextBoxJumlah.Name = "TextBoxJumlah"
        Me.TextBoxJumlah.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxJumlah.TabIndex = 67
        '
        'FormTabungan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 498)
        Me.Controls.Add(Me.TextBoxJumlah)
        Me.Controls.Add(Me.LabelIDData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.ComboPegawai)
        Me.Controls.Add(Me.DataGridTabungan)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Name = "FormTabungan"
        Me.Text = "FormTabungan"
        CType(Me.DataGridTabungan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelIDData As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents ComboPegawai As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTabungan As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxJumlah As System.Windows.Forms.TextBox
End Class
