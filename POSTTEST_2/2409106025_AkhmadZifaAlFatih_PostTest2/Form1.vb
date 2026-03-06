Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RefreshDaftar()
        ListBox1.Items.Clear()

        ' Perulangan For...Next [cite: 16]
        For i As Integer = 0 To jumlahBuku - 1
            ' Penggabungan string dengan tanda & [cite: 140]
            ListBox1.Items.Add(daftarBuku(i, 0) & " (" & daftarBuku(i, 1) & ")")
        Next
    End Sub

    ' Event untuk mengeksekusi Tombol Tambah
    ' (Pastikan Name tombol di Properties adalah btnTambah dan Textbox adalah txtJudulTambah & txtGenreTambah)
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim judul As String = txtJudulTambah.Text
        Dim genre As String = txtGenreTambah.Text

        ' Memanggil procedure TambahDataBuku dari Module
        TambahDataBuku(judul, genre)
        RefreshDaftar()

        ' Mengosongkan kolom input setelah ditambah
        txtJudulTambah.Text = ""
        txtGenreTambah.Text = ""
    End Sub

    ' Event untuk mengeksekusi Tombol Hapus
    ' (Pastikan Name tombol di Properties adalah btnHapus dan Textbox adalah txtJudulHapus)
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim judulHapus As String = txtJudulHapus.Text
        Dim sukses As Boolean = False

        ' Memanggil procedure HapusDataBuku dari Module dengan argument ByRef
        HapusDataBuku(judulHapus, sukses)

        If sukses = True Then
            RefreshDaftar()
            txtJudulHapus.Text = ""
        Else
            MsgBox("Judul buku tidak ditemukan!")
        End If
    End Sub
End Class
