Public Class Form3

    ' ============================================================
    ' Prosedur bantu: kosongkan semua field input
    ' ============================================================
    Private Sub Kosong()
        txtKodeStok.Clear()
        cbPakaian.SelectedIndex = -1
        cbPakaian.Text = ""
        cbSupplier.SelectedIndex = -1
        cbSupplier.Text = ""
        dtpTanggal.Value = Date.Today
        txtJumlah.Clear()
        txtHargaBeli.Clear()
        txtKeterangan.Clear()
        lblTotalValue.Text = "Rp 0"
        lblHargaJualValue.Text = "—"
        ErrorProvider1.Clear()
        txtKodeStok.Focus()
    End Sub

    ' ============================================================
    ' Tampil data grid  +  atur kolom (2 kolom kode disembunyikan)
    ' Indeks kolom:
    '   0 = kodeStok
    '   1 = kodePakaian  (HIDDEN — dipakai untuk set cbPakaian)
    '   2 = Nama Pakaian
    '   3 = kodeSupplier (HIDDEN — dipakai untuk set cbSupplier)
    '   4 = Nama Supplier
    '   5 = tanggalMasuk
    '   6 = jumlahMasuk
    '   7 = hargaBeli
    '   8 = Total Nilai
    '   9 = keterangan
    ' ============================================================
    Private Sub TampilData()
        dgvStok.DataSource = DataModule.GetAllStok()
        If dgvStok.Columns.Count < 10 Then Exit Sub

        dgvStok.Columns(0).HeaderText = "Kode Stok"
        dgvStok.Columns(1).Visible = False   ' kodePakaian — hidden
        dgvStok.Columns(2).HeaderText = "Nama Pakaian"
        dgvStok.Columns(3).Visible = False   ' kodeSupplier — hidden
        dgvStok.Columns(4).HeaderText = "Supplier"
        dgvStok.Columns(5).HeaderText = "Tgl Masuk"
        dgvStok.Columns(6).HeaderText = "Jumlah"
        dgvStok.Columns(7).HeaderText = "Harga Beli"
        dgvStok.Columns(8).HeaderText = "Total Nilai"
        dgvStok.Columns(9).HeaderText = "Keterangan"

        ' Bobot lebar kolom
        dgvStok.Columns(0).FillWeight = 10
        dgvStok.Columns(2).FillWeight = 22
        dgvStok.Columns(4).FillWeight = 18
        dgvStok.Columns(5).FillWeight = 12
        dgvStok.Columns(6).FillWeight = 8
        dgvStok.Columns(7).FillWeight = 12
        dgvStok.Columns(8).FillWeight = 12
        dgvStok.Columns(9).FillWeight = 16
    End Sub

    ' ============================================================
    ' Hitung total nilai (jumlah × harga beli) secara otomatis
    ' ============================================================
    Private Sub HitungTotal()
        Dim jml As Integer = 0
        Dim hrg As Integer = 0
        Integer.TryParse(txtJumlah.Text.Trim(), jml)
        Integer.TryParse(txtHargaBeli.Text.Trim(), hrg)
        Dim total As Long = CLng(jml) * CLng(hrg)
        lblTotalValue.Text = "Rp " & total.ToString("N0")
    End Sub

    ' ============================================================
    ' Event Load: isi ComboBox dari database, lalu tampil data
    ' ============================================================
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --- cbPakaian: DisplayMember = namaPakaian, ValueMember = kodePakaian ---
        Dim dtPakaian As DataTable = DataModule.GetAllPakaian()
        cbPakaian.DataSource = dtPakaian
        cbPakaian.DisplayMember = "namaPakaian"
        cbPakaian.ValueMember = "kodePakaian"

        ' --- cbSupplier: DisplayMember = namaSupplier, ValueMember = kodeSupplier ---
        Dim dtSupplier As DataTable = DataModule.GetAllSupplier()
        cbSupplier.DataSource = dtSupplier
        cbSupplier.DisplayMember = "namaSupplier"
        cbSupplier.ValueMember = "kodeSupplier"

        TampilData()
        Kosong()
    End Sub

    ' ============================================================
    ' Saat pilih pakaian -> tampilkan harga jual sebagai referensi
    ' ============================================================
    Private Sub cbPakaian_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cbPakaian.SelectedIndexChanged
        If cbPakaian.SelectedIndex < 0 OrElse cbPakaian.SelectedValue Is Nothing Then
            lblHargaJualValue.Text = "—"
            Exit Sub
        End If
        Dim kode As String = cbPakaian.SelectedValue.ToString()
        Dim dt As DataTable = DataModule.GetPakaianByKode(kode)
        If dt.Rows.Count > 0 Then
            Dim hJual As Integer = Convert.ToInt32(dt.Rows(0)("harga"))
            lblHargaJualValue.Text = "Rp " & hJual.ToString("N0")
        End If
    End Sub

    ' ============================================================
    ' Hitung ulang total saat jumlah / harga beli berubah
    ' ============================================================
    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged
        HitungTotal()
    End Sub

    Private Sub txtHargaBeli_TextChanged(sender As Object, e As EventArgs) Handles txtHargaBeli.TextChanged
        HitungTotal()
    End Sub

    ' ============================================================
    ' Batasi input hanya angka
    ' ============================================================
    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHargaBeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaBeli.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    ' ============================================================
    ' Validasi semua field wajib
    ' ============================================================
    Private Function ValidasiInput(cekKodeBaru As Boolean) As Boolean
        ErrorProvider1.Clear()
        Dim ok As Boolean = True

        If txtKodeStok.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtKodeStok, "Kode Stok wajib diisi! (contoh: STK001)")
            ok = False
        ElseIf cekKodeBaru AndAlso DataModule.KodeStokSudahAda(txtKodeStok.Text.Trim().ToUpper()) Then
            ErrorProvider1.SetError(txtKodeStok, "Kode Stok sudah terdaftar!")
            ok = False
        End If

        If cbPakaian.SelectedIndex < 0 Then
            ErrorProvider1.SetError(cbPakaian, "Pilih pakaian terlebih dahulu!")
            ok = False
        End If

        If cbSupplier.SelectedIndex < 0 Then
            ErrorProvider1.SetError(cbSupplier, "Pilih supplier terlebih dahulu!")
            ok = False
        End If

        Dim jml As Integer = 0
        If txtJumlah.Text.Trim() = "" OrElse Not Integer.TryParse(txtJumlah.Text.Trim(), jml) OrElse jml <= 0 Then
            ErrorProvider1.SetError(txtJumlah, "Jumlah harus diisi dan lebih dari 0!")
            ok = False
        End If

        Dim hrg As Integer = 0
        If txtHargaBeli.Text.Trim() = "" OrElse Not Integer.TryParse(txtHargaBeli.Text.Trim(), hrg) OrElse hrg <= 0 Then
            ErrorProvider1.SetError(txtHargaBeli, "Harga Beli harus diisi dan lebih dari 0!")
            ok = False
        End If

        Return ok
    End Function

    ' ============================================================
    ' Tombol Simpan
    ' ============================================================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiInput(cekKodeBaru:=True) Then Exit Sub

        Dim kode As String = txtKodeStok.Text.Trim().ToUpper()
        Dim kodePakaian As String = cbPakaian.SelectedValue.ToString()
        Dim kodeSupplier As String = cbSupplier.SelectedValue.ToString()
        Dim tanggal As Date = dtpTanggal.Value.Date
        Dim jumlah As Integer = Convert.ToInt32(txtJumlah.Text.Trim())
        Dim hargaBeli As Integer = Convert.ToInt32(txtHargaBeli.Text.Trim())
        Dim keterangan As String = txtKeterangan.Text.Trim()

        If DataModule.SimpanStok(kode, kodePakaian, kodeSupplier, tanggal, jumlah, hargaBeli, keterangan) Then
            MessageBox.Show("Data stok masuk berhasil disimpan.", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    ' ============================================================
    ' Tombol Ubah
    ' ============================================================
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtKodeStok.Text.Trim() = "" Then
            MessageBox.Show("Pilih baris data stok yang ingin diubah.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If Not ValidasiInput(cekKodeBaru:=False) Then Exit Sub

        Dim kode As String = txtKodeStok.Text.Trim().ToUpper()
        Dim kodePakaian As String = cbPakaian.SelectedValue.ToString()
        Dim kodeSupplier As String = cbSupplier.SelectedValue.ToString()
        Dim tanggal As Date = dtpTanggal.Value.Date
        Dim jumlah As Integer = Convert.ToInt32(txtJumlah.Text.Trim())
        Dim hargaBeli As Integer = Convert.ToInt32(txtHargaBeli.Text.Trim())
        Dim keterangan As String = txtKeterangan.Text.Trim()

        If DataModule.UbahStok(kode, kodePakaian, kodeSupplier, tanggal, jumlah, hargaBeli, keterangan) Then
            MessageBox.Show("Data stok berhasil diubah.", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Kode stok tidak ditemukan.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' ============================================================
    ' Tombol Hapus
    ' ============================================================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodeStok.Text.Trim() = "" Then
            MessageBox.Show("Pilih baris data stok yang ingin dihapus.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Hapus data stok " & txtKodeStok.Text.Trim().ToUpper() & "?",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If DataModule.HapusStok(txtKodeStok.Text.Trim().ToUpper()) Then
                MessageBox.Show("Data stok berhasil dihapus.", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    ' ============================================================
    ' Tombol Batal
    ' ============================================================
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        TampilData()
        Kosong()
    End Sub

    ' ============================================================
    ' Klik baris grid -> isi form
    ' Kolom 1 (kodePakaian) dan 3 (kodeSupplier) tersembunyi
    ' tapi nilainya tetap bisa dipakai untuk set SelectedValue
    ' ============================================================
    Private Sub dgvStok_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvStok.CellClick
        If e.RowIndex < 0 Then Exit Sub

        With dgvStok.Rows(e.RowIndex)
            txtKodeStok.Text = .Cells(0).Value.ToString()

            ' Set cbPakaian berdasarkan kodePakaian (kolom tersembunyi index 1)
            Dim kodeP As String = .Cells(1).Value.ToString()
            cbPakaian.SelectedValue = kodeP

            ' Set cbSupplier berdasarkan kodeSupplier (kolom tersembunyi index 3)
            Dim kodeS As String = .Cells(3).Value.ToString()
            cbSupplier.SelectedValue = kodeS

            ' Tanggal
            Dim tglStr As String = .Cells(5).Value.ToString()
            If tglStr <> "" Then
                dtpTanggal.Value = Convert.ToDateTime(tglStr)
            End If

            txtJumlah.Text = .Cells(6).Value.ToString()
            txtHargaBeli.Text = .Cells(7).Value.ToString()
            txtKeterangan.Text = .Cells(9).Value.ToString()
        End With

        HitungTotal()
        ErrorProvider1.Clear()
    End Sub

    ' ============================================================
    ' Pencarian real-time
    ' ============================================================
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvStok.DataSource = DataModule.SearchStok(txtCari.Text.Trim())
            ' Sembunyikan kembali kolom kode setelah datasource diperbarui
            If dgvStok.Columns.Count >= 4 Then
                dgvStok.Columns(1).Visible = False
                dgvStok.Columns(3).Visible = False
            End If
        End If
    End Sub

End Class