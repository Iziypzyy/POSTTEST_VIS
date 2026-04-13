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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblJudul = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtKodePakaian = New TextBox()
        txtNamaPakaian = New TextBox()
        txtKategori = New TextBox()
        txtUkuran = New TextBox()
        txtHarga = New TextBox()
        txtSearch = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvPakaian = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        Label6 = New Label()
        Label7 = New Label()
        txtDeskripsi = New TextBox()
        CType(dgvPakaian, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.BackColor = Color.Transparent
        lblJudul.Font = New Font("Castellar", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(28, 25)
        lblJudul.Margin = New Padding(4, 0, 4, 0)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(409, 39)
        lblJudul.TabIndex = 0
        lblJudul.Text = "DATA PAKAIAN PRIA"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Castellar", 8.0F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(35, 109)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 19)
        Label1.TabIndex = 1
        Label1.Text = "Kode Pakaian"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Castellar", 8.0F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(35, 164)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(166, 19)
        Label2.TabIndex = 2
        Label2.Text = "Nama Pakaian"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Castellar", 8.0F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(35, 219)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 19)
        Label3.TabIndex = 3
        Label3.Text = "Kategori"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Castellar", 8.0F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(35, 274)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 19)
        Label4.TabIndex = 4
        Label4.Text = "Ukuran"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Castellar", 8.0F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(35, 329)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 19)
        Label5.TabIndex = 5
        Label5.Text = "Harga"
        ' 
        ' txtKodePakaian
        ' 
        txtKodePakaian.BackColor = Color.White
        txtKodePakaian.BorderStyle = BorderStyle.FixedSingle
        txtKodePakaian.Font = New Font("Segoe UI", 10.0F)
        txtKodePakaian.Location = New Point(214, 106)
        txtKodePakaian.Margin = New Padding(4)
        txtKodePakaian.Name = "txtKodePakaian"
        txtKodePakaian.PlaceholderText = "Misal Dp-K(Kaos)001"
        txtKodePakaian.Size = New Size(391, 34)
        txtKodePakaian.TabIndex = 6
        ' 
        ' txtNamaPakaian
        ' 
        txtNamaPakaian.BorderStyle = BorderStyle.FixedSingle
        txtNamaPakaian.Font = New Font("Segoe UI", 10.0F)
        txtNamaPakaian.Location = New Point(214, 161)
        txtNamaPakaian.Margin = New Padding(4)
        txtNamaPakaian.Name = "txtNamaPakaian"
        txtNamaPakaian.PlaceholderText = "Masukkan Nama Pakaian..."
        txtNamaPakaian.Size = New Size(391, 34)
        txtNamaPakaian.TabIndex = 7
        ' 
        ' txtKategori
        ' 
        txtKategori.BorderStyle = BorderStyle.FixedSingle
        txtKategori.Font = New Font("Segoe UI", 10.0F)
        txtKategori.Location = New Point(214, 216)
        txtKategori.Margin = New Padding(4)
        txtKategori.Name = "txtKategori"
        txtKategori.PlaceholderText = "Masukkan Kategori (misal : Kaos,Celana,Jaket, dll)"
        txtKategori.Size = New Size(391, 34)
        txtKategori.TabIndex = 8
        ' 
        ' txtUkuran
        ' 
        txtUkuran.BorderStyle = BorderStyle.FixedSingle
        txtUkuran.Font = New Font("Segoe UI", 10.0F)
        txtUkuran.Location = New Point(214, 271)
        txtUkuran.Margin = New Padding(4)
        txtUkuran.Name = "txtUkuran"
        txtUkuran.PlaceholderText = "Ketik Ukuran (S, M, L, XL, XXL)"
        txtUkuran.Size = New Size(391, 34)
        txtUkuran.TabIndex = 9
        ' 
        ' txtHarga
        ' 
        txtHarga.BorderStyle = BorderStyle.FixedSingle
        txtHarga.Font = New Font("Segoe UI", 10.0F)
        txtHarga.Location = New Point(214, 326)
        txtHarga.Margin = New Padding(4)
        txtHarga.Name = "txtHarga"
        txtHarga.PlaceholderText = "Masukkan Harga..."
        txtHarga.Size = New Size(391, 34)
        txtHarga.TabIndex = 10
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = SystemColors.ControlLightLight
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10.0F)
        txtSearch.Location = New Point(788, 106)
        txtSearch.Margin = New Padding(4)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Ketik Pencarian..."
        txtSearch.Size = New Size(304, 34)
        txtSearch.TabIndex = 15
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Century", 10.0F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(620, 436)
        btnSimpan.Margin = New Padding(4)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(114, 39)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "SIMPAN"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnUbah.FlatAppearance.BorderSize = 0
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Century", 10.0F, FontStyle.Bold)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(749, 436)
        btnUbah.Margin = New Padding(4)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(98, 39)
        btnUbah.TabIndex = 12
        btnUbah.Text = "UBAH"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Century", 10.0F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(867, 436)
        btnHapus.Margin = New Padding(4)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(98, 39)
        btnHapus.TabIndex = 13
        btnHapus.Text = "HAPUS"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(149), CByte(165), CByte(166))
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Century", 10.0F, FontStyle.Bold)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(990, 436)
        btnBatal.Margin = New Padding(4)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(98, 39)
        btnBatal.TabIndex = 14
        btnBatal.Text = "BATAL"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' dgvPakaian
        ' 
        dgvPakaian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPakaian.BackgroundColor = Color.LightSeaGreen
        dgvPakaian.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvPakaian.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvPakaian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvPakaian.DefaultCellStyle = DataGridViewCellStyle2
        dgvPakaian.EnableHeadersVisualStyles = False
        dgvPakaian.Location = New Point(35, 503)
        dgvPakaian.Margin = New Padding(4)
        dgvPakaian.Name = "dgvPakaian"
        dgvPakaian.RowHeadersVisible = False
        dgvPakaian.RowHeadersWidth = 51
        dgvPakaian.RowTemplate.Height = 29
        dgvPakaian.Size = New Size(1058, 296)
        dgvPakaian.TabIndex = 16
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Castellar", 8.0F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(651, 109)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(119, 19)
        Label6.TabIndex = 16
        Label6.Text = "Cari Data"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Castellar", 8.0F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(35, 393)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(104, 19)
        Label7.TabIndex = 17
        Label7.Text = "Deskripsi"
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDeskripsi.Location = New Point(214, 385)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.PlaceholderText = "Masukkan Deskripsi Pakaian..."
        txtDeskripsi.Size = New Size(391, 90)
        txtDeskripsi.TabIndex = 18
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        BackgroundImage = My.Resources.Resources.download__16_
        ClientSize = New Size(1130, 812)
        Controls.Add(txtDeskripsi)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(dgvPakaian)
        Controls.Add(txtSearch)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtHarga)
        Controls.Add(txtUkuran)
        Controls.Add(txtKategori)
        Controls.Add(txtNamaPakaian)
        Controls.Add(txtKodePakaian)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblJudul)
        Margin = New Padding(4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manajemen Pakaian"
        CType(dgvPakaian, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKodePakaian As TextBox
    Friend WithEvents txtNamaPakaian As TextBox
    Friend WithEvents txtKategori As TextBox
    Friend WithEvents txtUkuran As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvPakaian As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDeskripsi As TextBox
End Class