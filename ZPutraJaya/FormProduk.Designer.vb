<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProduk
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
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextNamaProduk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextHargaProduk = New System.Windows.Forms.TextBox()
        Me.DataGridProduk = New System.Windows.Forms.DataGridView()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelIDData = New System.Windows.Forms.Label()
        Me.Text_IDProduk = New System.Windows.Forms.TextBox()
        CType(Me.DataGridProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.Label6.Location = New System.Drawing.Point(465, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 46)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "PRODUK"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(341, 251)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 29
        Me.ButtonSave.Text = "Simpan"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Harga Produk"
        '
        'TextNamaProduk
        '
        Me.TextNamaProduk.Location = New System.Drawing.Point(167, 157)
        Me.TextNamaProduk.Name = "TextNamaProduk"
        Me.TextNamaProduk.Size = New System.Drawing.Size(249, 20)
        Me.TextNamaProduk.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nama Produk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ID"
        '
        'TextHargaProduk
        '
        Me.TextHargaProduk.Location = New System.Drawing.Point(167, 193)
        Me.TextHargaProduk.Name = "TextHargaProduk"
        Me.TextHargaProduk.Size = New System.Drawing.Size(137, 20)
        Me.TextHargaProduk.TabIndex = 31
        '
        'DataGridProduk
        '
        Me.DataGridProduk.AllowUserToAddRows = False
        Me.DataGridProduk.AllowUserToDeleteRows = False
        Me.DataGridProduk.AllowUserToOrderColumns = True
        Me.DataGridProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridProduk.Location = New System.Drawing.Point(473, 113)
        Me.DataGridProduk.Name = "DataGridProduk"
        Me.DataGridProduk.ReadOnly = True
        Me.DataGridProduk.Size = New System.Drawing.Size(489, 356)
        Me.DataGridProduk.TabIndex = 32
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(871, 480)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(0, 13)
        Me.LabelStatus.TabIndex = 33
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(887, 491)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelete.TabIndex = 34
        Me.ButtonDelete.Text = "Hapus"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        Me.ButtonDelete.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(470, 491)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "ID : "
        '
        'LabelIDData
        '
        Me.LabelIDData.AutoSize = True
        Me.LabelIDData.Location = New System.Drawing.Point(515, 491)
        Me.LabelIDData.Name = "LabelIDData"
        Me.LabelIDData.Size = New System.Drawing.Size(0, 13)
        Me.LabelIDData.TabIndex = 36
        '
        'Text_IDProduk
        '
        Me.Text_IDProduk.Enabled = False
        Me.Text_IDProduk.Location = New System.Drawing.Point(167, 120)
        Me.Text_IDProduk.Name = "Text_IDProduk"
        Me.Text_IDProduk.Size = New System.Drawing.Size(137, 20)
        Me.Text_IDProduk.TabIndex = 22
        '
        'FormProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 538)
        Me.Controls.Add(Me.LabelIDData)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.DataGridProduk)
        Me.Controls.Add(Me.TextHargaProduk)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextNamaProduk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Text_IDProduk)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormProduk"
        Me.Text = "FormProduk"
        CType(Me.DataGridProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextNamaProduk As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextHargaProduk As System.Windows.Forms.TextBox
    Friend WithEvents DataGridProduk As System.Windows.Forms.DataGridView
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelIDData As System.Windows.Forms.Label
    Friend WithEvents Text_IDProduk As System.Windows.Forms.TextBox
End Class
