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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNrp = New System.Windows.Forms.TextBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDokter = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTanggal_Lahir = New System.Windows.Forms.TextBox()
        Me.txtTanggalMasuk = New System.Windows.Forms.TextBox()
        Me.txtRuangPerawatan = New System.Windows.Forms.TextBox()
        Me.txtKlsPerawatan = New System.Windows.Forms.TextBox()
        Me.txtPembayaran = New System.Windows.Forms.TextBox()
        Me.txtJk = New System.Windows.Forms.TextBox()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(94, 427)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 118
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Kota"
        '
        'txtKota
        '
        Me.txtKota.Location = New System.Drawing.Point(121, 216)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(129, 20)
        Me.txtKota.TabIndex = 116
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Alamat"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(121, 190)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(293, 20)
        Me.txtAlamat.TabIndex = 114
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(892, 146)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 113
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Blue
        Me.btnClear.Location = New System.Drawing.Point(892, 116)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 112
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Lime
        Me.btnSubmit.Location = New System.Drawing.Point(892, 88)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 111
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Nama"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "NRP"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(121, 112)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(148, 20)
        Me.txtNama.TabIndex = 105
        '
        'txtNrp
        '
        Me.txtNrp.Location = New System.Drawing.Point(121, 86)
        Me.txtNrp.Name = "txtNrp"
        Me.txtNrp.Size = New System.Drawing.Size(58, 20)
        Me.txtNrp.TabIndex = 104
        '
        'dgvData
        '
        Me.dgvData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(38, 263)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(941, 218)
        Me.dgvData.TabIndex = 102
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(410, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 30)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Data Pasien"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(501, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "Dokter"
        '
        'txtDokter
        '
        Me.txtDokter.Location = New System.Drawing.Point(604, 191)
        Me.txtDokter.Name = "txtDokter"
        Me.txtDokter.Size = New System.Drawing.Size(129, 20)
        Me.txtDokter.TabIndex = 127
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(501, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 126
        Me.Label11.Text = "Pembayaran"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(501, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 125
        Me.Label12.Text = "Kelas Perawatan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(501, 116)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 13)
        Me.Label13.TabIndex = 124
        Me.Label13.Text = "Ruang Perawatan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(501, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 13)
        Me.Label14.TabIndex = 123
        Me.Label14.Text = "Tanggal Masuk"
        '
        'txtTanggal_Lahir
        '
        Me.txtTanggal_Lahir.Location = New System.Drawing.Point(121, 165)
        Me.txtTanggal_Lahir.Name = "txtTanggal_Lahir"
        Me.txtTanggal_Lahir.Size = New System.Drawing.Size(148, 20)
        Me.txtTanggal_Lahir.TabIndex = 129
        '
        'txtTanggalMasuk
        '
        Me.txtTanggalMasuk.Location = New System.Drawing.Point(604, 81)
        Me.txtTanggalMasuk.Name = "txtTanggalMasuk"
        Me.txtTanggalMasuk.Size = New System.Drawing.Size(148, 20)
        Me.txtTanggalMasuk.TabIndex = 130
        '
        'txtRuangPerawatan
        '
        Me.txtRuangPerawatan.Location = New System.Drawing.Point(604, 109)
        Me.txtRuangPerawatan.Name = "txtRuangPerawatan"
        Me.txtRuangPerawatan.Size = New System.Drawing.Size(148, 20)
        Me.txtRuangPerawatan.TabIndex = 131
        '
        'txtKlsPerawatan
        '
        Me.txtKlsPerawatan.Location = New System.Drawing.Point(604, 139)
        Me.txtKlsPerawatan.Name = "txtKlsPerawatan"
        Me.txtKlsPerawatan.Size = New System.Drawing.Size(148, 20)
        Me.txtKlsPerawatan.TabIndex = 132
        '
        'txtPembayaran
        '
        Me.txtPembayaran.Location = New System.Drawing.Point(604, 165)
        Me.txtPembayaran.Name = "txtPembayaran"
        Me.txtPembayaran.Size = New System.Drawing.Size(148, 20)
        Me.txtPembayaran.TabIndex = 133
        '
        'txtJk
        '
        Me.txtJk.Location = New System.Drawing.Point(121, 139)
        Me.txtJk.Name = "txtJk"
        Me.txtJk.Size = New System.Drawing.Size(148, 20)
        Me.txtJk.TabIndex = 134
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1013, 505)
        Me.Controls.Add(Me.txtJk)
        Me.Controls.Add(Me.txtPembayaran)
        Me.Controls.Add(Me.txtKlsPerawatan)
        Me.Controls.Add(Me.txtRuangPerawatan)
        Me.Controls.Add(Me.txtTanggalMasuk)
        Me.Controls.Add(Me.txtTanggal_Lahir)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDokter)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtKota)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNrp)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtKota As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNrp As TextBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDokter As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTanggal_Lahir As TextBox
    Friend WithEvents txtTanggalMasuk As TextBox
    Friend WithEvents txtRuangPerawatan As TextBox
    Friend WithEvents txtKlsPerawatan As TextBox
    Friend WithEvents txtPembayaran As TextBox
    Friend WithEvents txtJk As TextBox
End Class
