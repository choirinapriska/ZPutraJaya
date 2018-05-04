<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPegawai
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
        Me.Text_IDPegawai = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextNamaPegawai = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxAlamatPegawai = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboJenisPegawai = New System.Windows.Forms.ComboBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridPegawai = New System.Windows.Forms.DataGridView()
        Me.LabelIDData = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.LabelStatus = New System.Windows.Forms.Label()
        CType(Me.DataGridPegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Text_IDPegawai
        '
        Me.Text_IDPegawai.Enabled = False
        Me.Text_IDPegawai.Location = New System.Drawing.Point(179, 72)
        Me.Text_IDPegawai.Name = "Text_IDPegawai"
        Me.Text_IDPegawai.Size = New System.Drawing.Size(137, 20)
        Me.Text_IDPegawai.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID"
        '
        'TextNamaPegawai
        '
        Me.TextNamaPegawai.Location = New System.Drawing.Point(179, 109)
        Me.TextNamaPegawai.Name = "TextNamaPegawai"
        Me.TextNamaPegawai.Size = New System.Drawing.Size(137, 20)
        Me.TextNamaPegawai.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nama Pegawai"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Alamat Pegawai"
        '
        'TextBoxAlamatPegawai
        '
        Me.TextBoxAlamatPegawai.Location = New System.Drawing.Point(179, 176)
        Me.TextBoxAlamatPegawai.Name = "TextBoxAlamatPegawai"
        Me.TextBoxAlamatPegawai.Size = New System.Drawing.Size(239, 60)
        Me.TextBoxAlamatPegawai.TabIndex = 16
        Me.TextBoxAlamatPegawai.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Jenis Pegawai"
        '
        'ComboJenisPegawai
        '
        Me.ComboJenisPegawai.FormattingEnabled = True
        Me.ComboJenisPegawai.Items.AddRange(New Object() {"Borongan ", "Harian"})
        Me.ComboJenisPegawai.Location = New System.Drawing.Point(179, 145)
        Me.ComboJenisPegawai.Name = "ComboJenisPegawai"
        Me.ComboJenisPegawai.Size = New System.Drawing.Size(137, 21)
        Me.ComboJenisPegawai.TabIndex = 18
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(441, 213)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 19
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.Label6.Location = New System.Drawing.Point(77, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 46)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "PEGAWAI"
        '
        'DataGridPegawai
        '
        Me.DataGridPegawai.AllowUserToAddRows = False
        Me.DataGridPegawai.AllowUserToDeleteRows = False
        Me.DataGridPegawai.AllowUserToOrderColumns = True
        Me.DataGridPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPegawai.Location = New System.Drawing.Point(40, 256)
        Me.DataGridPegawai.Name = "DataGridPegawai"
        Me.DataGridPegawai.ReadOnly = True
        Me.DataGridPegawai.Size = New System.Drawing.Size(553, 212)
        Me.DataGridPegawai.TabIndex = 33
        '
        'LabelIDData
        '
        Me.LabelIDData.AutoSize = True
        Me.LabelIDData.Location = New System.Drawing.Point(92, 517)
        Me.LabelIDData.Name = "LabelIDData"
        Me.LabelIDData.Size = New System.Drawing.Size(0, 13)
        Me.LabelIDData.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 517)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "ID : "
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(464, 517)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelete.TabIndex = 38
        Me.ButtonDelete.Text = "Hapus"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        Me.ButtonDelete.Visible = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(448, 506)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(0, 13)
        Me.LabelStatus.TabIndex = 37
        '
        'FormPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 557)
        Me.Controls.Add(Me.LabelIDData)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.DataGridPegawai)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ComboJenisPegawai)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxAlamatPegawai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextNamaPegawai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Text_IDPegawai)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPegawai"
        Me.Text = "FormPegawai"
        CType(Me.DataGridPegawai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Text_IDPegawai As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextNamaPegawai As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAlamatPegawai As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboJenisPegawai As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridPegawai As System.Windows.Forms.DataGridView
    Friend WithEvents LabelIDData As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
End Class
