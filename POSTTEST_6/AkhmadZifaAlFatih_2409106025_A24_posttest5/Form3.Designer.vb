<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents pnlInfoRelasi As System.Windows.Forms.Panel
    Friend WithEvents lblInfoRelasi As System.Windows.Forms.Label
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents lblKodeStok As System.Windows.Forms.Label
    Friend WithEvents txtKodeStok As System.Windows.Forms.TextBox
    Friend WithEvents lblPakaian As System.Windows.Forms.Label
    Friend WithEvents cbPakaian As System.Windows.Forms.ComboBox
    Friend WithEvents lblHargaJual As System.Windows.Forms.Label
    Friend WithEvents lblHargaJualValue As System.Windows.Forms.Label
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents cbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblJumlah As System.Windows.Forms.Label
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents lblHargaBeli As System.Windows.Forms.Label
    Friend WithEvents txtHargaBeli As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalValue As System.Windows.Forms.Label
    Friend WithEvents lblKeterangan As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents dgvStok As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        pnlHeader = New Panel()
        lblJudul = New Label()
        pnlInfoRelasi = New Panel()
        lblInfoRelasi = New Label()
        pnlForm = New Panel()
        lblKodeStok = New Label()
        txtKodeStok = New TextBox()
        lblPakaian = New Label()
        cbPakaian = New ComboBox()
        lblHargaJual = New Label()
        lblHargaJualValue = New Label()
        lblSupplier = New Label()
        cbSupplier = New ComboBox()
        lblTanggal = New Label()
        dtpTanggal = New DateTimePicker()
        lblJumlah = New Label()
        txtJumlah = New TextBox()
        lblHargaBeli = New Label()
        txtHargaBeli = New TextBox()
        lblTotal = New Label()
        lblTotalValue = New Label()
        lblKeterangan = New Label()
        txtKeterangan = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        pnlGrid = New Panel()
        txtCari = New TextBox()
        dgvStok = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        pnlHeader.SuspendLayout()
        pnlInfoRelasi.SuspendLayout()
        pnlForm.SuspendLayout()
        pnlGrid.SuspendLayout()
        CType(dgvStok, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(28), CByte(40), CByte(80))
        pnlHeader.Controls.Add(lblJudul)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(4, 5, 4, 5)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1286, 87)
        pnlHeader.TabIndex = 0
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(20, 20)
        lblJudul.Margin = New Padding(4, 0, 4, 0)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(281, 38)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Stok Masuk Pakaian"
        ' 
        ' pnlInfoRelasi
        ' 
        pnlInfoRelasi.BackColor = Color.FromArgb(CByte(217), CByte(237), CByte(247))
        pnlInfoRelasi.BorderStyle = BorderStyle.FixedSingle
        pnlInfoRelasi.Controls.Add(lblInfoRelasi)
        pnlInfoRelasi.Location = New Point(17, 100)
        pnlInfoRelasi.Margin = New Padding(4, 5, 4, 5)
        pnlInfoRelasi.Name = "pnlInfoRelasi"
        pnlInfoRelasi.Size = New Size(1251, 42)
        pnlInfoRelasi.TabIndex = 1
        ' 
        ' lblInfoRelasi
        ' 
        lblInfoRelasi.AutoSize = True
        lblInfoRelasi.Font = New Font("Segoe UI", 8.5F, FontStyle.Italic)
        lblInfoRelasi.ForeColor = Color.FromArgb(CByte(31), CByte(78), CByte(121))
        lblInfoRelasi.Location = New Point(11, 7)
        lblInfoRelasi.Margin = New Padding(4, 0, 4, 0)
        lblInfoRelasi.Name = "lblInfoRelasi"
        lblInfoRelasi.Size = New Size(971, 23)
        lblInfoRelasi.TabIndex = 0
        lblInfoRelasi.Text = "Tabel ini berelasi ke tbpakaian (FK: kodePakaian) dan tbsupplier (FK: kodeSupplier) - ON DELETE RESTRICT / ON UPDATE CASCADE"
        ' 
        ' pnlForm
        ' 
        pnlForm.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(252))
        pnlForm.BorderStyle = BorderStyle.FixedSingle
        pnlForm.Controls.Add(lblKodeStok)
        pnlForm.Controls.Add(txtKodeStok)
        pnlForm.Controls.Add(lblPakaian)
        pnlForm.Controls.Add(cbPakaian)
        pnlForm.Controls.Add(lblHargaJual)
        pnlForm.Controls.Add(lblHargaJualValue)
        pnlForm.Controls.Add(lblSupplier)
        pnlForm.Controls.Add(cbSupplier)
        pnlForm.Controls.Add(lblTanggal)
        pnlForm.Controls.Add(dtpTanggal)
        pnlForm.Controls.Add(lblJumlah)
        pnlForm.Controls.Add(txtJumlah)
        pnlForm.Controls.Add(lblHargaBeli)
        pnlForm.Controls.Add(txtHargaBeli)
        pnlForm.Controls.Add(lblTotal)
        pnlForm.Controls.Add(lblTotalValue)
        pnlForm.Controls.Add(lblKeterangan)
        pnlForm.Controls.Add(txtKeterangan)
        pnlForm.Controls.Add(btnSimpan)
        pnlForm.Controls.Add(btnUbah)
        pnlForm.Controls.Add(btnHapus)
        pnlForm.Controls.Add(btnBatal)
        pnlForm.Location = New Point(17, 157)
        pnlForm.Margin = New Padding(4, 5, 4, 5)
        pnlForm.Name = "pnlForm"
        pnlForm.Size = New Size(1251, 440)
        pnlForm.TabIndex = 2
        ' 
        ' lblKodeStok
        ' 
        lblKodeStok.AutoSize = True
        lblKodeStok.Font = New Font("Segoe UI", 9F)
        lblKodeStok.Location = New Point(20, 30)
        lblKodeStok.Margin = New Padding(4, 0, 4, 0)
        lblKodeStok.Name = "lblKodeStok"
        lblKodeStok.Size = New Size(93, 25)
        lblKodeStok.TabIndex = 0
        lblKodeStok.Text = "Kode Stok"
        ' 
        ' txtKodeStok
        ' 
        txtKodeStok.Font = New Font("Segoe UI", 9F)
        txtKodeStok.Location = New Point(200, 25)
        txtKodeStok.Margin = New Padding(4, 5, 4, 5)
        txtKodeStok.MaxLength = 10
        txtKodeStok.Name = "txtKodeStok"
        txtKodeStok.Size = New Size(184, 31)
        txtKodeStok.TabIndex = 0
        ' 
        ' lblPakaian
        ' 
        lblPakaian.AutoSize = True
        lblPakaian.Font = New Font("Segoe UI", 9F)
        lblPakaian.Location = New Point(20, 88)
        lblPakaian.Margin = New Padding(4, 0, 4, 0)
        lblPakaian.Name = "lblPakaian"
        lblPakaian.Size = New Size(71, 25)
        lblPakaian.TabIndex = 1
        lblPakaian.Text = "Pakaian"
        ' 
        ' cbPakaian
        ' 
        cbPakaian.DropDownStyle = ComboBoxStyle.DropDownList
        cbPakaian.Font = New Font("Segoe UI", 9F)
        cbPakaian.Location = New Point(200, 83)
        cbPakaian.Margin = New Padding(4, 5, 4, 5)
        cbPakaian.Name = "cbPakaian"
        cbPakaian.Size = New Size(398, 33)
        cbPakaian.TabIndex = 1
        ' 
        ' lblHargaJual
        ' 
        lblHargaJual.AutoSize = True
        lblHargaJual.Font = New Font("Segoe UI", 8F, FontStyle.Italic)
        lblHargaJual.ForeColor = Color.Gray
        lblHargaJual.Location = New Point(614, 90)
        lblHargaJual.Margin = New Padding(4, 0, 4, 0)
        lblHargaJual.Name = "lblHargaJual"
        lblHargaJual.Size = New Size(87, 21)
        lblHargaJual.TabIndex = 2
        lblHargaJual.Text = "Harga jual:"
        ' 
        ' lblHargaJualValue
        ' 
        lblHargaJualValue.AutoSize = True
        lblHargaJualValue.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblHargaJualValue.ForeColor = Color.FromArgb(CByte(20), CByte(90), CByte(180))
        lblHargaJualValue.Location = New Point(709, 90)
        lblHargaJualValue.Margin = New Padding(4, 0, 4, 0)
        lblHargaJualValue.Name = "lblHargaJualValue"
        lblHargaJualValue.Size = New Size(17, 23)
        lblHargaJualValue.TabIndex = 3
        lblHargaJualValue.Text = "-"
        ' 
        ' lblSupplier
        ' 
        lblSupplier.AutoSize = True
        lblSupplier.Font = New Font("Segoe UI", 9F)
        lblSupplier.Location = New Point(20, 147)
        lblSupplier.Margin = New Padding(4, 0, 4, 0)
        lblSupplier.Name = "lblSupplier"
        lblSupplier.Size = New Size(77, 25)
        lblSupplier.TabIndex = 4
        lblSupplier.Text = "Supplier"
        ' 
        ' cbSupplier
        ' 
        cbSupplier.DropDownStyle = ComboBoxStyle.DropDownList
        cbSupplier.Font = New Font("Segoe UI", 9F)
        cbSupplier.Location = New Point(200, 142)
        cbSupplier.Margin = New Padding(4, 5, 4, 5)
        cbSupplier.Name = "cbSupplier"
        cbSupplier.Size = New Size(398, 33)
        cbSupplier.TabIndex = 2
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Segoe UI", 9F)
        lblTanggal.Location = New Point(20, 205)
        lblTanggal.Margin = New Padding(4, 0, 4, 0)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(130, 25)
        lblTanggal.TabIndex = 5
        lblTanggal.Text = "Tanggal Masuk"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Font = New Font("Segoe UI", 9F)
        dtpTanggal.Format = DateTimePickerFormat.Short
        dtpTanggal.Location = New Point(200, 200)
        dtpTanggal.Margin = New Padding(4, 5, 4, 5)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(198, 31)
        dtpTanggal.TabIndex = 3
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Font = New Font("Segoe UI", 9F)
        lblJumlah.Location = New Point(20, 263)
        lblJumlah.Margin = New Padding(4, 0, 4, 0)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(109, 25)
        lblJumlah.TabIndex = 6
        lblJumlah.Text = "Jumlah (pcs)"
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Font = New Font("Segoe UI", 9F)
        txtJumlah.Location = New Point(200, 258)
        txtJumlah.Margin = New Padding(4, 5, 4, 5)
        txtJumlah.MaxLength = 6
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(113, 31)
        txtJumlah.TabIndex = 4
        ' 
        ' lblHargaBeli
        ' 
        lblHargaBeli.AutoSize = True
        lblHargaBeli.Font = New Font("Segoe UI", 9F)
        lblHargaBeli.Location = New Point(343, 263)
        lblHargaBeli.Margin = New Padding(4, 0, 4, 0)
        lblHargaBeli.Name = "lblHargaBeli"
        lblHargaBeli.Size = New Size(129, 25)
        lblHargaBeli.TabIndex = 7
        lblHargaBeli.Text = "Harga Beli (Rp)"
        ' 
        ' txtHargaBeli
        ' 
        txtHargaBeli.Font = New Font("Segoe UI", 9F)
        txtHargaBeli.Location = New Point(529, 258)
        txtHargaBeli.Margin = New Padding(4, 5, 4, 5)
        txtHargaBeli.MaxLength = 11
        txtHargaBeli.Name = "txtHargaBeli"
        txtHargaBeli.Size = New Size(184, 31)
        txtHargaBeli.TabIndex = 5
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTotal.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        lblTotal.Location = New Point(737, 263)
        lblTotal.Margin = New Padding(4, 0, 4, 0)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(59, 25)
        lblTotal.TabIndex = 8
        lblTotal.Text = "Total:"
        ' 
        ' lblTotalValue
        ' 
        lblTotalValue.AutoSize = True
        lblTotalValue.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblTotalValue.ForeColor = Color.FromArgb(CByte(0), CByte(128), CByte(0))
        lblTotalValue.Location = New Point(797, 260)
        lblTotalValue.Margin = New Padding(4, 0, 4, 0)
        lblTotalValue.Name = "lblTotalValue"
        lblTotalValue.Size = New Size(55, 28)
        lblTotalValue.TabIndex = 9
        lblTotalValue.Text = "Rp 0"
        ' 
        ' lblKeterangan
        ' 
        lblKeterangan.AutoSize = True
        lblKeterangan.Font = New Font("Segoe UI", 9F)
        lblKeterangan.Location = New Point(20, 325)
        lblKeterangan.Margin = New Padding(4, 0, 4, 0)
        lblKeterangan.Name = "lblKeterangan"
        lblKeterangan.Size = New Size(101, 25)
        lblKeterangan.TabIndex = 10
        lblKeterangan.Text = "Keterangan"
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.Font = New Font("Segoe UI", 9F)
        txtKeterangan.Location = New Point(200, 320)
        txtKeterangan.Margin = New Padding(4, 5, 4, 5)
        txtKeterangan.MaxLength = 255
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.Size = New Size(698, 31)
        txtKeterangan.TabIndex = 6
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(200, 380)
        btnSimpan.Margin = New Padding(4, 5, 4, 5)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(129, 47)
        btnSimpan.TabIndex = 7
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(255), CByte(153), CByte(0))
        btnUbah.FlatAppearance.BorderSize = 0
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(343, 380)
        btnUbah.Margin = New Padding(4, 5, 4, 5)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(129, 47)
        btnUbah.TabIndex = 8
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(486, 380)
        btnHapus.Margin = New Padding(4, 5, 4, 5)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(129, 47)
        btnHapus.TabIndex = 9
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(629, 380)
        btnBatal.Margin = New Padding(4, 5, 4, 5)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(129, 47)
        btnBatal.TabIndex = 10
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' pnlGrid
        ' 
        pnlGrid.Controls.Add(txtCari)
        pnlGrid.Controls.Add(dgvStok)
        pnlGrid.Location = New Point(17, 617)
        pnlGrid.Margin = New Padding(4, 5, 4, 5)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Size = New Size(1251, 500)
        pnlGrid.TabIndex = 3
        ' 
        ' txtCari
        ' 
        txtCari.Font = New Font("Segoe UI", 9F)
        txtCari.Location = New Point(0, 3)
        txtCari.Margin = New Padding(4, 5, 4, 5)
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Cari nama pakaian, supplier, atau keterangan..."
        txtCari.Size = New Size(598, 31)
        txtCari.TabIndex = 0
        ' 
        ' dgvStok
        ' 
        dgvStok.AllowUserToAddRows = False
        dgvStok.AllowUserToDeleteRows = False
        dgvStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStok.BackgroundColor = Color.White
        dgvStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStok.GridColor = Color.LightGray
        dgvStok.Location = New Point(0, 55)
        dgvStok.Margin = New Padding(4, 5, 4, 5)
        dgvStok.Name = "dgvStok"
        dgvStok.ReadOnly = True
        dgvStok.RowHeadersVisible = False
        dgvStok.RowHeadersWidth = 62
        dgvStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStok.Size = New Size(1251, 433)
        dgvStok.TabIndex = 1
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1286, 1050)
        Controls.Add(pnlHeader)
        Controls.Add(pnlInfoRelasi)
        Controls.Add(pnlForm)
        Controls.Add(pnlGrid)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Stok Masuk - Toko Pakaian Pria"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlInfoRelasi.ResumeLayout(False)
        pnlInfoRelasi.PerformLayout()
        pnlForm.ResumeLayout(False)
        pnlForm.PerformLayout()
        pnlGrid.ResumeLayout(False)
        pnlGrid.PerformLayout()
        CType(dgvStok, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

End Class