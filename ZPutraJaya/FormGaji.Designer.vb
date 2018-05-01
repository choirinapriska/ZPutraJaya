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
        Me.ComboPegawai = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Text_IDGaji = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.TextKasbon = New System.Windows.Forms.TextBox()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridRecordPekerja = New System.Windows.Forms.DataGridView()
        Me.DataGridGaji = New System.Windows.Forms.DataGridView()
        Me.LabelIDData = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.LabelStatus = New System.Windows.Forms.Label()
        CType(Me.DataGridRecordPekerja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridGaji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.Label6.Location = New System.Drawing.Point(310, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 46)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "GAJI"
        '
        'ComboPegawai
        '
        Me.ComboPegawai.FormattingEnabled = True
        Me.ComboPegawai.Items.AddRange(New Object() {"Borongan ", "Harian"})
        Me.ComboPegawai.Location = New System.Drawing.Point(160, 133)
        Me.ComboPegawai.Name = "ComboPegawai"
        Me.ComboPegawai.Size = New System.Drawing.Size(137, 21)
        Me.ComboPegawai.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Kasbon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nama Pegawai"
        '
        'Text_IDGaji
        '
        Me.Text_IDGaji.Enabled = False
        Me.Text_IDGaji.Location = New System.Drawing.Point(160, 96)
        Me.Text_IDGaji.Name = "Text_IDGaji"
        Me.Text_IDGaji.Size = New System.Drawing.Size(137, 20)
        Me.Text_IDGaji.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ID"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(222, 249)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 28
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'TextKasbon
        '
        Me.TextKasbon.Location = New System.Drawing.Point(160, 169)
        Me.TextKasbon.Name = "TextKasbon"
        Me.TextKasbon.Size = New System.Drawing.Size(137, 20)
        Me.TextKasbon.TabIndex = 29
        Me.TextKasbon.Text = "0"
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Location = New System.Drawing.Point(160, 206)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxTotal.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Total"
        '
        'DataGridRecordPekerja
        '
        Me.DataGridRecordPekerja.AllowUserToAddRows = False
        Me.DataGridRecordPekerja.AllowUserToDeleteRows = False
        Me.DataGridRecordPekerja.AllowUserToOrderColumns = True
        Me.DataGridRecordPekerja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRecordPekerja.Location = New System.Drawing.Point(336, 96)
        Me.DataGridRecordPekerja.Name = "DataGridRecordPekerja"
        Me.DataGridRecordPekerja.ReadOnly = True
        Me.DataGridRecordPekerja.Size = New System.Drawing.Size(423, 176)
        Me.DataGridRecordPekerja.TabIndex = 46
        '
        'DataGridGaji
        '
        Me.DataGridGaji.AllowUserToAddRows = False
        Me.DataGridGaji.AllowUserToDeleteRows = False
        Me.DataGridGaji.AllowUserToOrderColumns = True
        Me.DataGridGaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridGaji.Location = New System.Drawing.Point(31, 304)
        Me.DataGridGaji.Name = "DataGridGaji"
        Me.DataGridGaji.ReadOnly = True
        Me.DataGridGaji.Size = New System.Drawing.Size(423, 176)
        Me.DataGridGaji.TabIndex = 47
        '
        'LabelIDData
        '
        Me.LabelIDData.AutoSize = True
        Me.LabelIDData.Location = New System.Drawing.Point(74, 496)
        Me.LabelIDData.Name = "LabelIDData"
        Me.LabelIDData.Size = New System.Drawing.Size(0, 13)
        Me.LabelIDData.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 496)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "ID : "
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(379, 496)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelete.TabIndex = 49
        Me.ButtonDelete.Text = "Hapus"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        Me.ButtonDelete.Visible = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(363, 485)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(0, 13)
        Me.LabelStatus.TabIndex = 48
        '
        'FormGaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 555)
        Me.Controls.Add(Me.LabelIDData)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.DataGridGaji)
        Me.Controls.Add(Me.DataGridRecordPekerja)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextKasbon)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboPegawai)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Text_IDGaji)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormGaji"
        Me.Text = "Form Gaji"
        CType(Me.DataGridRecordPekerja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridGaji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboPegawai As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Text_IDGaji As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents TextKasbon As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridRecordPekerja As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridGaji As System.Windows.Forms.DataGridView
    Friend WithEvents LabelIDData As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
End Class
