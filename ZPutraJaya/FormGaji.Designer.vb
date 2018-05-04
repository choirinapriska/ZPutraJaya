<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGaji
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelKasbon = New System.Windows.Forms.Label()
        Me.LabelBonus = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelIDPegawai = New System.Windows.Forms.Label()
        Me.LabelNamaPegawai = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeFirst = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ComboPegawai = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Text_IDGaji = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.DataGridGaji = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelIDData = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBoxRecord = New System.Windows.Forms.GroupBox()
        Me.DataGridViewRecord = New System.Windows.Forms.DataGridView()
        Me.ColumnNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNamaProduk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnKeterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridGaji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBoxRecord.SuspendLayout()
        CType(Me.DataGridViewRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.Label6.Location = New System.Drawing.Point(369, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 46)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "GAJI"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelKasbon)
        Me.GroupBox1.Controls.Add(Me.LabelBonus)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.LabelIDPegawai)
        Me.GroupBox1.Controls.Add(Me.LabelNamaPegawai)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(318, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(196, 147)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pegawai"
        '
        'LabelKasbon
        '
        Me.LabelKasbon.AutoSize = True
        Me.LabelKasbon.Location = New System.Drawing.Point(57, 89)
        Me.LabelKasbon.Name = "LabelKasbon"
        Me.LabelKasbon.Size = New System.Drawing.Size(0, 13)
        Me.LabelKasbon.TabIndex = 77
        '
        'LabelBonus
        '
        Me.LabelBonus.AutoSize = True
        Me.LabelBonus.Location = New System.Drawing.Point(56, 121)
        Me.LabelBonus.Name = "LabelBonus"
        Me.LabelBonus.Size = New System.Drawing.Size(0, 13)
        Me.LabelBonus.TabIndex = 76
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Bonus"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Kasbon"
        '
        'LabelIDPegawai
        '
        Me.LabelIDPegawai.AutoSize = True
        Me.LabelIDPegawai.Location = New System.Drawing.Point(56, 26)
        Me.LabelIDPegawai.Name = "LabelIDPegawai"
        Me.LabelIDPegawai.Size = New System.Drawing.Size(0, 13)
        Me.LabelIDPegawai.TabIndex = 73
        '
        'LabelNamaPegawai
        '
        Me.LabelNamaPegawai.AutoSize = True
        Me.LabelNamaPegawai.Location = New System.Drawing.Point(58, 58)
        Me.LabelNamaPegawai.Name = "LabelNamaPegawai"
        Me.LabelNamaPegawai.Size = New System.Drawing.Size(0, 13)
        Me.LabelNamaPegawai.TabIndex = 72
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Nama "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 13)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.DateTimeEnd)
        Me.GroupBox2.Controls.Add(Me.DateTimeFirst)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ButtonSave)
        Me.GroupBox2.Controls.Add(Me.ComboPegawai)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Text_IDGaji)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 147)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Form"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(172, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "-"
        '
        'DateTimeEnd
        '
        Me.DateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeEnd.Location = New System.Drawing.Point(192, 26)
        Me.DateTimeEnd.Name = "DateTimeEnd"
        Me.DateTimeEnd.Size = New System.Drawing.Size(87, 20)
        Me.DateTimeEnd.TabIndex = 40
        '
        'DateTimeFirst
        '
        Me.DateTimeFirst.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFirst.Location = New System.Drawing.Point(79, 26)
        Me.DateTimeFirst.Name = "DateTimeFirst"
        Me.DateTimeFirst.Size = New System.Drawing.Size(87, 20)
        Me.DateTimeFirst.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Tanggal "
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(205, 114)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 37
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ComboPegawai
        '
        Me.ComboPegawai.FormattingEnabled = True
        Me.ComboPegawai.Items.AddRange(New Object() {"Borongan ", "Harian"})
        Me.ComboPegawai.Location = New System.Drawing.Point(79, 89)
        Me.ComboPegawai.Name = "ComboPegawai"
        Me.ComboPegawai.Size = New System.Drawing.Size(201, 21)
        Me.ComboPegawai.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Pegawai"
        '
        'Text_IDGaji
        '
        Me.Text_IDGaji.Enabled = False
        Me.Text_IDGaji.Location = New System.Drawing.Point(79, 55)
        Me.Text_IDGaji.Name = "Text_IDGaji"
        Me.Text_IDGaji.Size = New System.Drawing.Size(201, 20)
        Me.Text_IDGaji.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "ID"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonDelete)
        Me.GroupBox3.Controls.Add(Me.DataGridGaji)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 225)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(500, 243)
        Me.GroupBox3.TabIndex = 87
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data"
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(402, 19)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelete.TabIndex = 51
        Me.ButtonDelete.Text = "Hapus"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        Me.ButtonDelete.Visible = False
        '
        'DataGridGaji
        '
        Me.DataGridGaji.AllowUserToAddRows = False
        Me.DataGridGaji.AllowUserToDeleteRows = False
        Me.DataGridGaji.AllowUserToOrderColumns = True
        Me.DataGridGaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridGaji.Location = New System.Drawing.Point(24, 48)
        Me.DataGridGaji.Name = "DataGridGaji"
        Me.DataGridGaji.ReadOnly = True
        Me.DataGridGaji.Size = New System.Drawing.Size(453, 176)
        Me.DataGridGaji.TabIndex = 50
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.LabelDate, Me.ToolStripStatusLabel3, Me.LabelIDData})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 500)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(909, 22)
        Me.StatusStrip1.TabIndex = 88
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
        'GroupBoxRecord
        '
        Me.GroupBoxRecord.AutoSize = True
        Me.GroupBoxRecord.Controls.Add(Me.LabelTotal)
        Me.GroupBoxRecord.Controls.Add(Me.Label5)
        Me.GroupBoxRecord.Controls.Add(Me.DataGridViewRecord)
        Me.GroupBoxRecord.Location = New System.Drawing.Point(520, 72)
        Me.GroupBoxRecord.Name = "GroupBoxRecord"
        Me.GroupBoxRecord.Size = New System.Drawing.Size(367, 417)
        Me.GroupBoxRecord.TabIndex = 89
        Me.GroupBoxRecord.TabStop = False
        Me.GroupBoxRecord.Text = "Data Record Pegawai"
        '
        'DataGridViewRecord
        '
        Me.DataGridViewRecord.AllowUserToAddRows = False
        Me.DataGridViewRecord.AllowUserToDeleteRows = False
        Me.DataGridViewRecord.AllowUserToOrderColumns = True
        Me.DataGridViewRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridViewRecord.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnNo, Me.ColumnNamaProduk, Me.ColumnKeterangan, Me.ColumnTotal})
        Me.DataGridViewRecord.Location = New System.Drawing.Point(15, 26)
        Me.DataGridViewRecord.Name = "DataGridViewRecord"
        Me.DataGridViewRecord.ReadOnly = True
        Me.DataGridViewRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewRecord.Size = New System.Drawing.Size(340, 351)
        Me.DataGridViewRecord.TabIndex = 1
        '
        'ColumnNo
        '
        Me.ColumnNo.HeaderText = "No"
        Me.ColumnNo.Name = "ColumnNo"
        Me.ColumnNo.ReadOnly = True
        Me.ColumnNo.Width = 46
        '
        'ColumnNamaProduk
        '
        Me.ColumnNamaProduk.HeaderText = "Nama_Produk"
        Me.ColumnNamaProduk.Name = "ColumnNamaProduk"
        Me.ColumnNamaProduk.ReadOnly = True
        '
        'ColumnKeterangan
        '
        Me.ColumnKeterangan.HeaderText = "Keterangan"
        Me.ColumnKeterangan.Name = "ColumnKeterangan"
        Me.ColumnKeterangan.ReadOnly = True
        Me.ColumnKeterangan.Width = 87
        '
        'ColumnTotal
        '
        Me.ColumnTotal.HeaderText = "Total"
        Me.ColumnTotal.Name = "ColumnTotal"
        Me.ColumnTotal.ReadOnly = True
        Me.ColumnTotal.Width = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(181, 383)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "TOTAL : "
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(252, 383)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(0, 18)
        Me.LabelTotal.TabIndex = 40
        '
        'FormGaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 522)
        Me.Controls.Add(Me.GroupBoxRecord)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "FormGaji"
        Me.Text = "Form Gaji"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridGaji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBoxRecord.ResumeLayout(False)
        Me.GroupBoxRecord.PerformLayout()
        CType(Me.DataGridViewRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelKasbon As System.Windows.Forms.Label
    Friend WithEvents LabelBonus As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LabelIDPegawai As System.Windows.Forms.Label
    Friend WithEvents LabelNamaPegawai As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ComboPegawai As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Text_IDGaji As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents DataGridGaji As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LabelIDData As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBoxRecord As System.Windows.Forms.GroupBox
    Friend WithEvents LabelDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimeFirst As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewRecord As System.Windows.Forms.DataGridView
    Friend WithEvents ColumnNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnNamaProduk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnKeterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
