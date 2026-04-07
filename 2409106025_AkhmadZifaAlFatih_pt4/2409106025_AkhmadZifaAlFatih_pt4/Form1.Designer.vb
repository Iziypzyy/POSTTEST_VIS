<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuInput As ToolStripMenuItem
    Friend WithEvents menuLihat As ToolStripMenuItem
    Friend WithEvents menuSimpan As ToolStripMenuItem
    Friend WithEvents menuBuka As ToolStripMenuItem
    Friend WithEvents menuKeluar As ToolStripMenuItem

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents cmbKomunitas As ComboBox

    Friend WithEvents mskHP As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAlamat As TextBox

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbAdmin As RadioButton

    Friend WithEvents chk1 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents chk5 As CheckBox
    Friend WithEvents chk6 As CheckBox
    Friend WithEvents chk7 As CheckBox
    Friend WithEvents chk8 As CheckBox

    Friend WithEvents btnSimpan As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        menuInput = New ToolStripMenuItem()
        menuLihat = New ToolStripMenuItem()
        menuSimpan = New ToolStripMenuItem()
        menuBuka = New ToolStripMenuItem()
        menuKeluar = New ToolStripMenuItem()
        Label1 = New Label()
        PictureBoxLogo = New PictureBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        txtNama = New TextBox()
        txtID = New TextBox()
        dtpLahir = New DateTimePicker()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        cmbKomunitas = New ComboBox()
        TabPage2 = New TabPage()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        mskHP = New MaskedTextBox()
        txtEmail = New TextBox()
        txtAlamat = New TextBox()
        TabPage3 = New TabPage()
        picFoto = New PictureBox()
        btnBrowse = New Button()
        GroupBox1 = New GroupBox()
        rbKetua = New RadioButton()
        rbAnggota = New RadioButton()
        rbAdmin = New RadioButton()
        chk1 = New CheckBox()
        chk2 = New CheckBox()
        chk3 = New CheckBox()
        chk4 = New CheckBox()
        chk5 = New CheckBox()
        chk6 = New CheckBox()
        chk7 = New CheckBox()
        chk8 = New CheckBox()
        btnSimpan = New Button()
        MenuStrip1.SuspendLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {menuInput, menuLihat, menuSimpan, menuBuka, menuKeluar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 0
        ' 
        ' menuInput
        ' 
        menuInput.Name = "menuInput"
        menuInput.Size = New Size(112, 29)
        menuInput.Text = "Input Data"
        ' 
        ' menuLihat
        ' 
        menuLihat.Name = "menuLihat"
        menuLihat.Size = New Size(111, 29)
        menuLihat.Text = "Lihat Kartu"
        ' 
        ' menuSimpan
        ' 
        menuSimpan.Name = "menuSimpan"
        menuSimpan.Size = New Size(130, 29)
        menuSimpan.Text = "Simpan Data"
        ' 
        ' menuBuka
        ' 
        menuBuka.Name = "menuBuka"
        menuBuka.Size = New Size(108, 29)
        menuBuka.Text = "Buka Data"
        ' 
        ' menuKeluar
        ' 
        menuKeluar.Name = "menuKeluar"
        menuKeluar.Size = New Size(76, 29)
        menuKeluar.Text = "Keluar"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        Label1.Location = New Point(250, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(286, 37)
        Label1.TabIndex = 1
        Label1.Text = "KARTU KOMUNITAS"
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.Location = New Point(0, 0)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(100, 50)
        PictureBoxLogo.TabIndex = 0
        PictureBoxLogo.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(50, 100)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(700, 300)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(dtpLahir)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(cmbKomunitas)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Name = "TabPage1"
        TabPage1.Size = New Size(692, 262)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(20, 20)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama"
        txtNama.Size = New Size(321, 31)
        txtNama.TabIndex = 0
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(20, 60)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "ID Anggota"
        txtID.Size = New Size(321, 31)
        txtID.TabIndex = 1
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(20, 100)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(321, 31)
        dtpLahir.TabIndex = 2
        ' 
        ' rbLaki
        ' 
        rbLaki.Location = New Point(20, 140)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(104, 24)
        rbLaki.TabIndex = 3
        rbLaki.Text = "Laki-laki"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.Location = New Point(125, 139)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(133, 34)
        rbPerempuan.TabIndex = 4
        rbPerempuan.Text = "Perempuan"
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.Location = New Point(20, 180)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(321, 33)
        cmbKomunitas.TabIndex = 5
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(mskHP)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Name = "TabPage2"
        TabPage2.Size = New Size(692, 262)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(153, 25)
        Label4.TabIndex = 5
        Label4.Text = "Masukkan Alamat"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 25)
        Label3.TabIndex = 4
        Label3.Text = "Nama Gmail"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 25)
        Label2.TabIndex = 3
        Label2.Text = "No HP"
        ' 
        ' mskHP
        ' 
        mskHP.Location = New Point(193, 30)
        mskHP.Mask = "0000-0000-0000"
        mskHP.Name = "mskHP"
        mskHP.Size = New Size(160, 31)
        mskHP.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(193, 67)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(160, 31)
        txtEmail.TabIndex = 1
        txtEmail.Text = "@gmail.com"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(193, 108)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat"
        txtAlamat.Size = New Size(160, 31)
        txtAlamat.TabIndex = 2
        txtAlamat.Text = "Jl. "
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.Transparent
        TabPage3.Controls.Add(picFoto)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(GroupBox1)
        TabPage3.Controls.Add(chk1)
        TabPage3.Controls.Add(chk2)
        TabPage3.Controls.Add(chk3)
        TabPage3.Controls.Add(chk4)
        TabPage3.Controls.Add(chk5)
        TabPage3.Controls.Add(chk6)
        TabPage3.Controls.Add(chk7)
        TabPage3.Controls.Add(chk8)
        TabPage3.Controls.Add(btnSimpan)
        TabPage3.Location = New Point(4, 34)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(692, 262)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil"
        ' 
        ' picFoto
        ' 
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(27, 18)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(140, 165)
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(46, 191)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(100, 33)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbKetua)
        GroupBox1.Controls.Add(rbAnggota)
        GroupBox1.Controls.Add(rbAdmin)
        GroupBox1.Location = New Point(529, 29)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(129, 114)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Peran"
        ' 
        ' rbKetua
        ' 
        rbKetua.Location = New Point(10, 20)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(104, 24)
        rbKetua.TabIndex = 0
        rbKetua.Text = "Ketua"
        ' 
        ' rbAnggota
        ' 
        rbAnggota.Location = New Point(10, 44)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(109, 34)
        rbAnggota.TabIndex = 1
        rbAnggota.Text = "Anggota"
        ' 
        ' rbAdmin
        ' 
        rbAdmin.Location = New Point(10, 80)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(104, 24)
        rbAdmin.TabIndex = 2
        rbAdmin.Text = "Admin"
        ' 
        ' chk1
        ' 
        chk1.Location = New Point(215, 34)
        chk1.Name = "chk1"
        chk1.Size = New Size(114, 33)
        chk1.TabIndex = 3
        chk1.Text = "Ngoding"
        ' 
        ' chk2
        ' 
        chk2.Location = New Point(216, 66)
        chk2.Name = "chk2"
        chk2.Size = New Size(104, 24)
        chk2.TabIndex = 4
        chk2.Text = "Desain"
        ' 
        ' chk3
        ' 
        chk3.Location = New Point(215, 94)
        chk3.Name = "chk3"
        chk3.Size = New Size(104, 24)
        chk3.TabIndex = 5
        chk3.Text = "Game"
        ' 
        ' chk4
        ' 
        chk4.Location = New Point(215, 124)
        chk4.Name = "chk4"
        chk4.Size = New Size(104, 24)
        chk4.TabIndex = 6
        chk4.Text = "Musik"
        ' 
        ' chk5
        ' 
        chk5.Location = New Point(365, 34)
        chk5.Name = "chk5"
        chk5.Size = New Size(104, 33)
        chk5.TabIndex = 7
        chk5.Text = "Editing"
        ' 
        ' chk6
        ' 
        chk6.Location = New Point(365, 64)
        chk6.Name = "chk6"
        chk6.Size = New Size(117, 29)
        chk6.TabIndex = 8
        chk6.Text = "Fotografi"
        ' 
        ' chk7
        ' 
        chk7.Location = New Point(365, 94)
        chk7.Name = "chk7"
        chk7.Size = New Size(104, 24)
        chk7.TabIndex = 9
        chk7.Text = "Menulis"
        ' 
        ' chk8
        ' 
        chk8.Location = New Point(365, 124)
        chk8.Name = "chk8"
        chk8.Size = New Size(168, 35)
        chk8.TabIndex = 10
        chk8.Text = "Public Speaking"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(216, 191)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(84, 33)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "Simpan & Cetak"
        ' 
        ' Form1
        ' 
        BackgroundImage = My.Resources.Resources.edit_png
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        Controls.Add(Label1)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Kartu Komunitas"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label

End Class