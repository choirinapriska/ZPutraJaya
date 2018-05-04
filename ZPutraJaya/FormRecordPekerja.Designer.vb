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
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboProduk = New System.Windows.Forms.ComboBox()
        Me.ComboPegawai = New System.Windows.Forms.ComboBox()
        Me.TextJumlah = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridRecordPekerja = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelIDData = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimeTgl = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridRecordPekerja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.Label6.Location = New System.Drawing.Point(474, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(388, 46)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "RECORD PEKERJA"
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(583, 492)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelete.TabIndex = 47
        Me.ButtonDelete.Text = "Hapus"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        Me.ButtonDelete.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimeTgl)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboProduk)
        Me.GroupBox1.Controls.Add(Me.ComboPegawai)
        Me.GroupBox1.Controls.Add(Me.TextJumlah)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(130, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 193)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form"
        '
        'ComboProduk
        '
        Me.ComboProduk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboProduk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboProduk.FormattingEnabled = True
        Me.ComboProduk.Location = New System.Drawing.Point(123, 95)
        Me.ComboProduk.Name = "ComboProduk"
        Me.ComboProduk.Size = New System.Drawing.Size(212, 21)
        Me.ComboProduk.TabIndex = 58
        Me.ComboProduk.Text = "Pilih Produk"
        '
        'ComboPegawai
        '
        Me.ComboPegawai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboPegawai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboPegawai.FormattingEnabled = True
        Me.ComboPegawai.Location = New System.Drawing.Point(123, 58)
        Me.ComboPegawai.Name = "ComboPegawai"
        Me.ComboPegawai.Size = New System.Drawing.Size(212, 21)
        Me.ComboPegawai.TabIndex = 57
        Me.ComboPegawai.Text = "Pilih Pegawai"
        '
        'TextJumlah
        '
        Me.TextJumlah.Location = New System.Drawing.Point(123, 131)
        Me.TextJumlah.Name = "TextJumlah"
        Me.TextJumlah.Size = New System.Drawing.Size(121, 20)
        Me.TextJumlah.TabIndex = 56
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(260, 129)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 55
        Me.ButtonSave.Text = "Simpan"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Jumlah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Produk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Pegawai"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridRecordPekerja)
        Me.GroupBox2.Controls.Add(Me.ButtonDelete)
        Me.GroupBox2.Location = New System.Drawing.Point(591, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(680, 540)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data"
        '
        'DataGridRecordPekerja
        '
        Me.DataGridRecordPekerja.AllowUserToAddRows = False
        Me.DataGridRecordPekerja.AllowUserToDeleteRows = False
        Me.DataGridRecordPekerja.AllowUserToOrderColumns = True
        Me.DataGridRecordPekerja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRecordPekerja.Location = New System.Drawing.Point(32, 27)
        Me.DataGridRecordPekerja.Name = "DataGridRecordPekerja"
        Me.DataGridRecordPekerja.ReadOnly = True
        Me.DataGridRecordPekerja.Size = New System.Drawing.Size(626, 442)
        Me.DataGridRecordPekerja.TabIndex = 46
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.LabelDate, Me.LabelStatus, Me.ToolStripStatusLabel3, Me.LabelIDData})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 704)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1370, 22)
        Me.StatusStrip1.TabIndex = 91
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel1.Text = "Status:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'LabelDate
        '
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(0, 17)
        '
        'LabelStatus
        '
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel3.Text = "    ID : "
        '
        'LabelIDData
        '
        Me.LabelIDData.Name = "LabelIDData"
        Me.LabelIDData.Size = New System.Drawing.Size(0, 17)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Tanggal "
        '
        'DateTimeTgl
        '
        Me.DateTimeTgl.Location = New System.Drawing.Point(123, 27)
        Me.DateTimeTgl.Name = "DateTimeTgl"
        Me.DateTimeTgl.Size = New System.Drawing.Size(212, 20)
        Me.DateTimeTgl.TabIndex = 60
        '
        'FormRecordPekerja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 726)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "FormRecordPekerja"
        Me.Text = "Form Record Pekerja"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridRecordPekerja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboProduk As System.Windows.Forms.ComboBox
    Friend WithEvents ComboPegawai As System.Windows.Forms.ComboBox
    Friend WithEvents TextJumlah As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridRecordPekerja As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LabelDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LabelStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LabelIDData As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DateTimeTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
