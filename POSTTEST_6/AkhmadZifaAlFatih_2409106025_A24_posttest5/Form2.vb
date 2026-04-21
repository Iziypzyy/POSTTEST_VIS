Public Class Form2

    Private Sub Kosong()
        txtKodeSupplier.Clear()
        txtNamaSupplier.Clear()
        txtKontak.Clear()
        txtAlamat.Clear()
        ErrorProvider1.Clear()
        txtKodeSupplier.Focus()
    End Sub

    Private Sub TampilData()
        dgvSupplier.DataSource = DataModule.GetAllSupplier()
        With dgvSupplier
            If .Columns.Count >= 4 Then
                .Columns(0).HeaderText = "Kode"
                .Columns(1).HeaderText = "Nama Supplier"
                .Columns(2).HeaderText = "No. Kontak"
                .Columns(3).HeaderText = "Alamat"
                .Columns(0).FillWeight = 10
                .Columns(1).FillWeight = 30
                .Columns(2).FillWeight = 20
                .Columns(3).FillWeight = 40
            End If
        End With
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Function ValidasiInput(cekKodeBaru As Boolean) As Boolean
        ErrorProvider1.Clear()
        Dim ok As Boolean = True

        If txtKodeSupplier.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtKodeSupplier, "Kode Supplier wajib diisi! (maks. 5 karakter)")
            ok = False
        ElseIf cekKodeBaru AndAlso DataModule.KodeSupplierSudahAda(txtKodeSupplier.Text.Trim().ToUpper()) Then
            ErrorProvider1.SetError(txtKodeSupplier, "Kode Supplier sudah terdaftar!")
            ok = False
        End If

        If txtNamaSupplier.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtNamaSupplier, "Nama Supplier wajib diisi!")
            ok = False
        End If

        Return ok
    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiInput(cekKodeBaru:=True) Then
            txtKodeSupplier.Focus()
            Exit Sub
        End If

        Dim kode As String = txtKodeSupplier.Text.Trim().ToUpper()
        Dim nama As String = txtNamaSupplier.Text.Trim()
        Dim kontak As String = txtKontak.Text.Trim()
        Dim alamat As String = txtAlamat.Text.Trim()

        If DataModule.SimpanSupplier(kode, nama, kontak, alamat) Then
            MessageBox.Show("Data supplier berhasil disimpan.", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If Not ValidasiInput(cekKodeBaru:=False) Then
            txtKodeSupplier.Focus()
            Exit Sub
        End If

        Dim kode As String = txtKodeSupplier.Text.Trim().ToUpper()
        Dim nama As String = txtNamaSupplier.Text.Trim()
        Dim kontak As String = txtKontak.Text.Trim()
        Dim alamat As String = txtAlamat.Text.Trim()

        If DataModule.UbahSupplier(kode, nama, kontak, alamat) Then
            MessageBox.Show("Data supplier berhasil diubah.", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Kode tidak ditemukan di database.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodeSupplier.Text.Trim() = "" Then
            MessageBox.Show("Pilih baris supplier yang ingin dihapus.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Hapus supplier """ & txtNamaSupplier.Text.Trim() & """?" & vbNewLine &
            "Aksi ini tidak bisa dibatalkan.",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If DataModule.HapusSupplier(txtKodeSupplier.Text.Trim().ToUpper()) Then
                MessageBox.Show("Data supplier berhasil dihapus.", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        TampilData()
        Kosong()
    End Sub

    Private Sub dgvSupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvSupplier.CellClick
        If e.RowIndex >= 0 Then
            With dgvSupplier.Rows(e.RowIndex)
                txtKodeSupplier.Text = .Cells(0).Value.ToString()
                txtNamaSupplier.Text = .Cells(1).Value.ToString()
                txtKontak.Text = .Cells(2).Value.ToString()
                txtAlamat.Text = .Cells(3).Value.ToString()
            End With
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvSupplier.DataSource = DataModule.SearchSupplier(txtCari.Text.Trim())
        End If
    End Sub

    Private Sub txtKontak_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKontak.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtKodeSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtKodeSupplier.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            e.Handled = True
            txtNamaSupplier.Focus()
        End If
    End Sub

    Private Sub txtNamaSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtNamaSupplier.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            e.Handled = True
            txtKontak.Focus()
        End If
    End Sub

    Private Sub txtKontak_KeyPress2(sender As Object, e As KeyPressEventArgs) _
        Handles txtKontak.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            e.Handled = True
            txtAlamat.Focus()
        End If
    End Sub

End Class
