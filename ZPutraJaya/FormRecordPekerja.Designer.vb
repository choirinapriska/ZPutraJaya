<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecordPekerja
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.DataGridRecordPekerja = New System.Windows.Forms.DataGridView()
        Me.TextJumlah = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboPegawai = New System.Windows.Forms.ComboBox()
        Me.ComboProduk = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridRecordPekerja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.Label6.Location = New System.Drawing.Point(233, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(388, 46)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "RECORD PEKERJA"
        '
        'LabelIDData
        '
        Me.LabelIDData.AutoSize = True
        Me.LabelIDData.Location = New System.Drawing.Point(357, 400)
        Me.LabelIDData.Name = "LabelIDData"
        Me.LabelIDData.Size = New System.Drawing.Size(0, 13)
        Me.LabelIDData.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(312, 400)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "ID : "
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(729, 400)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelete.TabIndex = 47
        Me.ButtonDelete.Text = "Hapus"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        Me.ButtonDelete.Visible = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(713, 389)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(0, 13)
        Me.LabelStatus.TabIndex = 46
        '
        'DataGridRecordPekerja
        '
        Me.DataGridRecordPekerja.AllowUserToAddRows = False
        Me.DataGridRecordPekerja.AllowUserToDeleteRows = False
        Me.DataGridRecordPekerja.AllowUserToOrderColumns = True
        Me.DataGridRecordPekerja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRecordPekerja.Location = New System.Drawing.Point(315, 124)
        Me.DataGridRecordPekerja.Name = "DataGridRecordPekerja"
        Me.DataGridRecordPekerja.ReadOnly = True
        Me.DataGridRecordPekerja.Size = New System.Drawing.Size(489, 247)
        Me.DataGridRecordPekerja.TabIndex = 45
        '
        'TextJumlah
        '
        Me.TextJumlah.Location = New System.Drawing.Point(165, 197)
        Me.TextJumlah.Name = "TextJumlah"
        Me.TextJumlah.Size = New System.Drawing.Size(121, 20)
        Me.TextJumlah.TabIndex = 44
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(211, 242)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 42
        Me.ButtonSave.Text = "Simpan"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Jumlah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Produk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Pegawai"
        '
        'ComboPegawai
        '
        Me.ComboPegawai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboPegawai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboPegawai.FormattingEnabled = True
        Me.ComboPegawai.Location = New System.Drawing.Point(165, 124)
        Me.ComboPegawai.Name = "ComboPegawai"
        Me.ComboPegawai.Size = New System.Drawing.Size(121, 21)
        Me.ComboPegawai.TabIndex = 50
        Me.ComboPegawai.Text = "Pilih Pegawai"
        '
        'ComboProduk
        '
        Me.ComboProduk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboProduk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboProduk.FormattingEnabled = True
        Me.ComboProduk.Location = New System.Drawing.Point(165, 161)
        Me.ComboProduk.Name = "ComboProduk"
        Me.ComboProduk.Size = New System.Drawing.Size(121, 21)
        Me.ComboProduk.TabIndex = 51
        Me.ComboProduk.Text = "Pilih Produk"
        '
        'FormRecordPekerja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 479)
        Me.Controls.Add(Me.ComboProduk)
        Me.Controls.Add(Me.ComboPegawai)
        Me.Controls.Add(Me.LabelIDData)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.DataGridRecordPekerja)
        Me.Controls.Add(Me.TextJumlah)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Name = "FormRecordPekerja"
        Me.Text = "Form Record Pekerja"
        CType(Me.DataGridRecordPekerja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelIDData As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents DataGridRecordPekerja As System.Windows.Forms.DataGridView
    Friend WithEvents TextJumlah As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboPegawai As System.Windows.Forms.ComboBox
    Friend WithEvents ComboProduk As System.Windows.Forms.ComboBox
End Class
