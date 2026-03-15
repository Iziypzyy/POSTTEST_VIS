<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PbFoto = New PictureBox()
        btnBrowse = New Button()
        lblNama = New Label()
        lblUmur = New Label()
        lblNoTelp = New Label()
        lblTanggalLahir = New Label()
        lblAlamat = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtNoTelp = New TextBox()
        txtAlamat = New TextBox()
        dtpTanggalLahir = New DateTimePicker()
        gbJenisKelamin = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLakiLaki = New RadioButton()
        gbHobby = New GroupBox()
        cbBadminton = New CheckBox()
        cbMenyanyi = New CheckBox()
        cbBersepeda = New CheckBox()
        cbMelukis = New CheckBox()
        cbSepakBola = New CheckBox()
        cbBasket = New CheckBox()
        cbVoli = New CheckBox()
        cbMenulis = New CheckBox()
        cbMembaca = New CheckBox()
        cbBerenang = New CheckBox()
        btnCetak = New Button()
        CType(PbFoto, ComponentModel.ISupportInitialize).BeginInit()
        gbJenisKelamin.SuspendLayout()
        gbHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' PbFoto
        ' 
        PbFoto.BorderStyle = BorderStyle.FixedSingle
        PbFoto.Location = New Point(3, 9)
        PbFoto.Name = "PbFoto"
        PbFoto.Size = New Size(216, 347)
        PbFoto.SizeMode = PictureBoxSizeMode.Zoom
        PbFoto.TabIndex = 0
        PbFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(57, 376)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(112, 31)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.ForeColor = SystemColors.Control
        lblNama.Location = New Point(225, 6)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(56, 23)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.Transparent
        lblUmur.ForeColor = SystemColors.Control
        lblUmur.Location = New Point(225, 40)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(55, 23)
        lblUmur.TabIndex = 3
        lblUmur.Text = "Umur"
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.BackColor = Color.Transparent
        lblNoTelp.ForeColor = SystemColors.Control
        lblNoTelp.Location = New Point(225, 78)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(107, 23)
        lblNoTelp.TabIndex = 4
        lblNoTelp.Text = "No. Telepon"
        ' 
        ' lblTanggalLahir
        ' 
        lblTanggalLahir.AutoSize = True
        lblTanggalLahir.BackColor = Color.Transparent
        lblTanggalLahir.ForeColor = SystemColors.Control
        lblTanggalLahir.Location = New Point(225, 114)
        lblTanggalLahir.Name = "lblTanggalLahir"
        lblTanggalLahir.Size = New Size(120, 23)
        lblTanggalLahir.TabIndex = 5
        lblTanggalLahir.Text = "Tanggal Lahir"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.Transparent
        lblAlamat.ForeColor = SystemColors.Control
        lblAlamat.Location = New Point(225, 150)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(70, 23)
        lblAlamat.TabIndex = 6
        lblAlamat.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(374, 3)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(258, 28)
        txtNama.TabIndex = 7
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(376, 40)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(256, 28)
        txtUmur.TabIndex = 8
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Location = New Point(378, 77)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(254, 28)
        txtNoTelp.TabIndex = 10
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(383, 149)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(249, 29)
        txtAlamat.TabIndex = 11
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(380, 114)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(252, 28)
        dtpTanggalLahir.TabIndex = 12
        dtpTanggalLahir.Value = New Date(2026, 3, 15, 22, 45, 54, 0)
        ' 
        ' gbJenisKelamin
        ' 
        gbJenisKelamin.BackColor = Color.Transparent
        gbJenisKelamin.Controls.Add(rbPerempuan)
        gbJenisKelamin.Controls.Add(rbLakiLaki)
        gbJenisKelamin.ForeColor = SystemColors.ControlLightLight
        gbJenisKelamin.Location = New Point(228, 177)
        gbJenisKelamin.Name = "gbJenisKelamin"
        gbJenisKelamin.Size = New Size(223, 195)
        gbJenisKelamin.TabIndex = 13
        gbJenisKelamin.TabStop = False
        gbJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(6, 60)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(128, 27)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLakiLaki
        ' 
        rbLakiLaki.AutoSize = True
        rbLakiLaki.Location = New Point(6, 28)
        rbLakiLaki.Name = "rbLakiLaki"
        rbLakiLaki.Size = New Size(110, 27)
        rbLakiLaki.TabIndex = 0
        rbLakiLaki.TabStop = True
        rbLakiLaki.Text = "Laki-Laki"
        rbLakiLaki.UseVisualStyleBackColor = True
        ' 
        ' gbHobby
        ' 
        gbHobby.BackColor = Color.Transparent
        gbHobby.Controls.Add(cbBadminton)
        gbHobby.Controls.Add(cbMenyanyi)
        gbHobby.Controls.Add(cbBersepeda)
        gbHobby.Controls.Add(cbMelukis)
        gbHobby.Controls.Add(cbSepakBola)
        gbHobby.Controls.Add(cbBasket)
        gbHobby.Controls.Add(cbVoli)
        gbHobby.Controls.Add(cbMenulis)
        gbHobby.Controls.Add(cbMembaca)
        gbHobby.Controls.Add(cbBerenang)
        gbHobby.Font = New Font("Trebuchet MS", 9F, FontStyle.Italic)
        gbHobby.ForeColor = Color.Transparent
        gbHobby.Location = New Point(457, 177)
        gbHobby.Name = "gbHobby"
        gbHobby.Size = New Size(331, 195)
        gbHobby.TabIndex = 14
        gbHobby.TabStop = False
        gbHobby.Text = "Hobby"
        ' 
        ' cbBadminton
        ' 
        cbBadminton.AutoSize = True
        cbBadminton.Location = New Point(161, 159)
        cbBadminton.Name = "cbBadminton"
        cbBadminton.Size = New Size(125, 27)
        cbBadminton.TabIndex = 9
        cbBadminton.Text = "Badminton"
        cbBadminton.UseVisualStyleBackColor = True
        ' 
        ' cbMenyanyi
        ' 
        cbMenyanyi.AutoSize = True
        cbMenyanyi.Location = New Point(161, 127)
        cbMenyanyi.Name = "cbMenyanyi"
        cbMenyanyi.Size = New Size(114, 27)
        cbMenyanyi.TabIndex = 8
        cbMenyanyi.Text = "Menyanyi"
        cbMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' cbBersepeda
        ' 
        cbBersepeda.AutoSize = True
        cbBersepeda.Location = New Point(161, 95)
        cbBersepeda.Name = "cbBersepeda"
        cbBersepeda.Size = New Size(121, 27)
        cbBersepeda.TabIndex = 7
        cbBersepeda.Text = "Bersepeda"
        cbBersepeda.UseVisualStyleBackColor = True
        ' 
        ' cbMelukis
        ' 
        cbMelukis.AutoSize = True
        cbMelukis.Location = New Point(161, 61)
        cbMelukis.Name = "cbMelukis"
        cbMelukis.Size = New Size(98, 27)
        cbMelukis.TabIndex = 6
        cbMelukis.Text = "Melukis"
        cbMelukis.UseVisualStyleBackColor = True
        ' 
        ' cbSepakBola
        ' 
        cbSepakBola.AutoSize = True
        cbSepakBola.Location = New Point(161, 29)
        cbSepakBola.Name = "cbSepakBola"
        cbSepakBola.Size = New Size(125, 27)
        cbSepakBola.TabIndex = 5
        cbSepakBola.Text = "Sepak Bola"
        cbSepakBola.UseVisualStyleBackColor = True
        ' 
        ' cbBasket
        ' 
        cbBasket.AutoSize = True
        cbBasket.Location = New Point(6, 158)
        cbBasket.Name = "cbBasket"
        cbBasket.Size = New Size(90, 27)
        cbBasket.TabIndex = 4
        cbBasket.Text = "Basket"
        cbBasket.UseVisualStyleBackColor = True
        ' 
        ' cbVoli
        ' 
        cbVoli.AutoSize = True
        cbVoli.Location = New Point(6, 124)
        cbVoli.Name = "cbVoli"
        cbVoli.Size = New Size(68, 27)
        cbVoli.TabIndex = 3
        cbVoli.Text = "Voli"
        cbVoli.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Location = New Point(6, 92)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(99, 27)
        cbMenulis.TabIndex = 2
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(6, 60)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(113, 27)
        cbMembaca.TabIndex = 1
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbBerenang
        ' 
        cbBerenang.AutoSize = True
        cbBerenang.Location = New Point(6, 29)
        cbBerenang.Name = "cbBerenang"
        cbBerenang.Size = New Size(113, 27)
        cbBerenang.TabIndex = 0
        cbBerenang.Text = "Berenang"
        cbBerenang.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(248, 377)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(495, 31)
        btnCetak.TabIndex = 10
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 414)
        Controls.Add(btnCetak)
        Controls.Add(gbHobby)
        Controls.Add(gbJenisKelamin)
        Controls.Add(dtpTanggalLahir)
        Controls.Add(txtAlamat)
        Controls.Add(txtNoTelp)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(lblAlamat)
        Controls.Add(lblTanggalLahir)
        Controls.Add(lblNoTelp)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(btnBrowse)
        Controls.Add(PbFoto)
        Font = New Font("Trebuchet MS", 9F, FontStyle.Italic)
        FormBorderStyle = FormBorderStyle.FixedSingle
        FormScreenCaptureMode = ScreenCaptureMode.HideContent
        Name = "Form1"
        Text = "Form1"
        CType(PbFoto, ComponentModel.ISupportInitialize).EndInit()
        gbJenisKelamin.ResumeLayout(False)
        gbJenisKelamin.PerformLayout()
        gbHobby.ResumeLayout(False)
        gbHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PbFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents lblTanggalLahir As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents gbJenisKelamin As GroupBox
    Friend WithEvents gbHobby As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLakiLaki As RadioButton
    Friend WithEvents cbBadminton As CheckBox
    Friend WithEvents cbMenyanyi As CheckBox
    Friend WithEvents cbBersepeda As CheckBox
    Friend WithEvents cbMelukis As CheckBox
    Friend WithEvents cbSepakBola As CheckBox
    Friend WithEvents cbBasket As CheckBox
    Friend WithEvents cbVoli As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbBerenang As CheckBox
    Friend WithEvents btnCetak As Button

End Class
