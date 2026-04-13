Public Class Form1
    Private Sub Kosong()
        txtKodePakaian.Clear()
        txtNamaPakaian.Clear()
        txtKategori.Clear()
        txtUkuran.Clear()
        txtHarga.Clear()
        txtDeskripsi.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtKodePakaian.Focus()
    End Sub

    Private Sub TampilData()
        dgvPakaian.DataSource = GetAllPakaian()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidasiPakaian(ErrorProvider1, txtKodePakaian, txtNamaPakaian, txtKategori, txtUkuran, txtHarga) Then
            Exit Sub
        End If

        If txtDeskripsi.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtDeskripsi, "Deskripsi tidak boleh kosong")
            Exit Sub
        End If

        Dim kode As String = txtKodePakaian.Text.Trim()
        Dim nama As String = txtNamaPakaian.Text.Trim()
        Dim kategori As String = txtKategori.Text.Trim()
        Dim ukuran As String = txtUkuran.Text.Trim()
        Dim harga As Integer = Convert.ToInt32(txtHarga.Text.Trim())
        Dim deskripsi As String = txtDeskripsi.Text.Trim()

        If KodeSudahAda(kode) Then
            MessageBox.Show("Kode Pakaian sudah terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodePakaian.Focus()
            Exit Sub
        End If

        If SimpanPakaian(kode, nama, kategori, ukuran, harga, deskripsi) Then
            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()
        If Not ValidasiPakaian(ErrorProvider1, txtKodePakaian, txtNamaPakaian, txtKategori, txtUkuran, txtHarga) Then
            Exit Sub
        End If

        If txtDeskripsi.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtDeskripsi, "Deskripsi tidak boleh kosong")
            Exit Sub
        End If

        Dim kode As String = txtKodePakaian.Text.Trim()
        Dim nama As String = txtNamaPakaian.Text.Trim()
        Dim kategori As String = txtKategori.Text.Trim()
        Dim ukuran As String = txtUkuran.Text.Trim()
        Dim harga As Integer = Convert.ToInt32(txtHarga.Text.Trim())
        Dim deskripsi As String = txtDeskripsi.Text.Trim()
        If UbahPakaian(kode, nama, kategori, ukuran, harga, deskripsi) Then
            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodePakaian.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodePakaian.Focus()
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If HapusPakaian(txtKodePakaian.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub dgvPakaian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPakaian.CellClick
        If e.RowIndex >= 0 Then
            txtKodePakaian.Text = dgvPakaian.Rows(e.RowIndex).Cells("kodePakaian").Value.ToString()
            txtNamaPakaian.Text = dgvPakaian.Rows(e.RowIndex).Cells("namaPakaian").Value.ToString()
            txtKategori.Text = dgvPakaian.Rows(e.RowIndex).Cells("kategori").Value.ToString()
            txtUkuran.Text = dgvPakaian.Rows(e.RowIndex).Cells("ukuran").Value.ToString()
            txtHarga.Text = dgvPakaian.Rows(e.RowIndex).Cells("harga").Value.ToString()
            txtDeskripsi.Text = dgvPakaian.Rows(e.RowIndex).Cells("deskripsi").Value.ToString()
        End If
    End Sub

    Private Sub txtKodePakaian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodePakaian.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True
            Dim dt As DataTable = GetPakaianByKode(txtKodePakaian.Text.Trim())
            If dt.Rows.Count > 0 Then
                txtNamaPakaian.Text = dt.Rows(0)("namaPakaian").ToString()
                txtKategori.Text = dt.Rows(0)("kategori").ToString()
                txtUkuran.Text = dt.Rows(0)("ukuran").ToString()
                txtHarga.Text = dt.Rows(0)("harga").ToString()
                txtDeskripsi.Text = dt.Rows(0)("deskripsi").ToString()
            Else
                txtNamaPakaian.Clear()
                txtKategori.Clear()
                txtUkuran.Clear()
                txtHarga.Clear()
                txtDeskripsi.Clear()
            End If
            txtNamaPakaian.Focus()
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        HanyaAngka(e)
        If IsEnterKey(e) Then
            e.Handled = True
            txtDeskripsi.Focus()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvPakaian.DataSource = SearchPakaian(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub dgvPakaian_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPakaian.CellContentClick

    End Sub
End Class