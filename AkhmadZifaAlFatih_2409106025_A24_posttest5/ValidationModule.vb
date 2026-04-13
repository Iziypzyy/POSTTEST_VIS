Module ValidationModule
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiPakaian(ep As ErrorProvider, txtKode As TextBox, txtNama As TextBox, txtKategori As TextBox, txtUkuran As TextBox, txtHarga As TextBox) As Boolean
        Dim kodeValid As Boolean = ValidasiTextBox(ep, txtKode, "Kode Pakaian tidak boleh kosong")
        Dim namaValid As Boolean = ValidasiTextBox(ep, txtNama, "Nama Pakaian tidak boleh kosong")
        Dim katValid As Boolean = ValidasiTextBox(ep, txtKategori, "Kategori tidak boleh kosong")
        Dim ukurValid As Boolean = ValidasiTextBox(ep, txtUkuran, "Ukuran tidak boleh kosong")
        Dim hargaValid As Boolean = ValidasiTextBox(ep, txtHarga, "Harga tidak boleh kosong")

        ' Catatan: Deskripsi tidak wajib diisi dalam validasi ini (opsional), 
        ' Jika deskripsi wajib diisi, validasinya diletakkan di Form1.vb seperti kode sebelumnya.

        Return kodeValid And namaValid And katValid And ukurValid And hargaValid
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function
End Module