<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents lblKodeSupplier As System.Windows.Forms.Label
    Friend WithEvents txtKodeSupplier As System.Windows.Forms.TextBox
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNamaSupplier As System.Windows.Forms.TextBox
    Friend WithEvents lblKontak As System.Windows.Forms.Label
    Friend WithEvents txtKontak As System.Windows.Forms.TextBox
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents dgvSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        pnlHeader = New Panel()
        lblJudul = New Label()
        pnlForm = New Panel()
        lblKodeSupplier = New Label()
        txtKodeSupplier = New TextBox()
        lblNama = New Label()
        txtNamaSupplier = New TextBox()
        lblKontak = New Label()
        txtKontak = New TextBox()
        lblAlamat = New Label()
        txtAlamat = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        pnlGrid = New Panel()
        lblCari = New Label()
        txtCari = New TextBox()
        dgvSupplier = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        pnlHeader.SuspendLayout()
        pnlForm.SuspendLayout()
        pnlGrid.SuspendLayout()
        CType(dgvSupplier, ComponentModel.ISupportInitialize).BeginInit()
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
        pnlHeader.Size = New Size(1086, 87)
        pnlHeader.TabIndex = 0
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(20, 20)
        lblJudul.Margin = New Padding(4, 0, 4, 0)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(360, 38)
        lblJudul.TabIndex = 0
        lblJudul.Text = "  ☎  Manajemen Supplier"
        ' 
        ' pnlForm
        ' 
        pnlForm.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(252))
        pnlForm.BorderStyle = BorderStyle.FixedSingle
        pnlForm.Controls.Add(lblKodeSupplier)
        pnlForm.Controls.Add(txtKodeSupplier)
        pnlForm.Controls.Add(lblNama)
        pnlForm.Controls.Add(txtNamaSupplier)
        pnlForm.Controls.Add(lblKontak)
        pnlForm.Controls.Add(txtKontak)
        pnlForm.Controls.Add(lblAlamat)
        pnlForm.Controls.Add(txtAlamat)
        pnlForm.Controls.Add(btnSimpan)
        pnlForm.Controls.Add(btnUbah)
        pnlForm.Controls.Add(btnHapus)
        pnlForm.Controls.Add(btnBatal)
        pnlForm.Location = New Point(17, 107)
        pnlForm.Margin = New Padding(4, 5, 4, 5)
        pnlForm.Name = "pnlForm"
        pnlForm.Size = New Size(1051, 324)
        pnlForm.TabIndex = 1
        ' 
        ' lblKodeSupplier
        ' 
        lblKodeSupplier.AutoSize = True
        lblKodeSupplier.Font = New Font("Segoe UI", 9.0F)
        lblKodeSupplier.Location = New Point(20, 30)
        lblKodeSupplier.Margin = New Padding(4, 0, 4, 0)
        lblKodeSupplier.Name = "lblKodeSupplier"
        lblKodeSupplier.Size = New Size(123, 25)
        lblKodeSupplier.TabIndex = 0
        lblKodeSupplier.Text = "Kode Supplier"
        ' 
        ' txtKodeSupplier
        ' 
        txtKodeSupplier.Font = New Font("Segoe UI", 9.0F)
        txtKodeSupplier.Location = New Point(200, 25)
        txtKodeSupplier.Margin = New Padding(4, 5, 4, 5)
        txtKodeSupplier.MaxLength = 5
        txtKodeSupplier.Name = "txtKodeSupplier"
        txtKodeSupplier.Size = New Size(155, 31)
        txtKodeSupplier.TabIndex = 0
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 9.0F)
        lblNama.Location = New Point(20, 87)
        lblNama.Margin = New Padding(4, 0, 4, 0)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(129, 25)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama Supplier"
        ' 
        ' txtNamaSupplier
        ' 
        txtNamaSupplier.Font = New Font("Segoe UI", 9.0F)
        txtNamaSupplier.Location = New Point(200, 82)
        txtNamaSupplier.Margin = New Padding(4, 5, 4, 5)
        txtNamaSupplier.MaxLength = 100
        txtNamaSupplier.Name = "txtNamaSupplier"
        txtNamaSupplier.Size = New Size(427, 31)
        txtNamaSupplier.TabIndex = 1
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.Font = New Font("Segoe UI", 9.0F)
        lblKontak.Location = New Point(20, 143)
        lblKontak.Margin = New Padding(4, 0, 4, 0)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(100, 25)
        lblKontak.TabIndex = 2
        lblKontak.Text = "No. Kontak"
        ' 
        ' txtKontak
        ' 
        txtKontak.Font = New Font("Segoe UI", 9.0F)
        txtKontak.Location = New Point(200, 138)
        txtKontak.Margin = New Padding(4, 5, 4, 5)
        txtKontak.MaxLength = 15
        txtKontak.Name = "txtKontak"
        txtKontak.Size = New Size(227, 31)
        txtKontak.TabIndex = 2
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Segoe UI", 9.0F)
        lblAlamat.Location = New Point(20, 200)
        lblAlamat.Margin = New Padding(4, 0, 4, 0)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(68, 25)
        lblAlamat.TabIndex = 3
        lblAlamat.Text = "Alamat"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("Segoe UI", 9.0F)
        txtAlamat.Location = New Point(200, 195)
        txtAlamat.Margin = New Padding(4, 5, 4, 5)
        txtAlamat.MaxLength = 200
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(641, 31)
        txtAlamat.TabIndex = 3
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(200, 258)
        btnSimpan.Margin = New Padding(4, 5, 4, 5)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(129, 47)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(255), CByte(153), CByte(0))
        btnUbah.FlatAppearance.BorderSize = 0
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(343, 258)
        btnUbah.Margin = New Padding(4, 5, 4, 5)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(129, 47)
        btnUbah.TabIndex = 5
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(486, 258)
        btnHapus.Margin = New Padding(4, 5, 4, 5)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(129, 47)
        btnHapus.TabIndex = 6
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(629, 258)
        btnBatal.Margin = New Padding(4, 5, 4, 5)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(129, 47)
        btnBatal.TabIndex = 7
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' pnlGrid
        ' 
        pnlGrid.Controls.Add(lblCari)
        pnlGrid.Controls.Add(txtCari)
        pnlGrid.Controls.Add(dgvSupplier)
        pnlGrid.Location = New Point(17, 450)
        pnlGrid.Margin = New Padding(4, 5, 4, 5)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Size = New Size(1051, 467)
        pnlGrid.TabIndex = 2
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Font = New Font("Segoe UI", 9.0F)
        lblCari.Location = New Point(0, 7)
        lblCari.Margin = New Padding(4, 0, 4, 0)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(88, 25)
        lblCari.TabIndex = 0
        lblCari.Text = "Cari Data:"
        ' 
        ' txtCari
        ' 
        txtCari.Font = New Font("Segoe UI", 9.0F)
        txtCari.Location = New Point(103, 2)
        txtCari.Margin = New Padding(4, 5, 4, 5)
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Ketik nama, kontak, atau alamat supplier..."
        txtCari.Size = New Size(541, 31)
        txtCari.TabIndex = 0
        ' 
        ' dgvSupplier
        ' 
        dgvSupplier.AllowUserToAddRows = False
        dgvSupplier.AllowUserToDeleteRows = False
        dgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSupplier.BackgroundColor = Color.White
        dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSupplier.GridColor = Color.LightGray
        dgvSupplier.Location = New Point(0, 53)
        dgvSupplier.Margin = New Padding(4, 5, 4, 5)
        dgvSupplier.Name = "dgvSupplier"
        dgvSupplier.ReadOnly = True
        dgvSupplier.RowHeadersVisible = False
        dgvSupplier.RowHeadersWidth = 62
        dgvSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSupplier.Size = New Size(1051, 400)
        dgvSupplier.TabIndex = 1
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1086, 937)
        Controls.Add(pnlHeader)
        Controls.Add(pnlForm)
        Controls.Add(pnlGrid)
        Font = New Font("Segoe UI", 9.0F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manajemen Supplier — Toko Pakaian Pria"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlForm.ResumeLayout(False)
        pnlForm.PerformLayout()
        pnlGrid.ResumeLayout(False)
        pnlGrid.PerformLayout()
        CType(dgvSupplier, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
End Class