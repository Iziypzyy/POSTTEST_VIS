Public Class Form1

    ' 1. Fungsi untuk tombol Browse Foto
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        openFileDialog.Title = "Pilih Foto Profile"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PbFoto.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    ' 2. Validasi Inputan Nama (HANYA HURUF) - Sesuai Modul 3
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        ' Mengizinkan huruf, tombol kontrol (seperti Backspace), dan Spasi
        If Char.IsLetter(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse e.KeyChar = " "c Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ' 3. Validasi Inputan Umur (HANYA ANGKA) - Sesuai Modul 3
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ' 4. Validasi Inputan No. Telepon (HANYA ANGKA)
    Private Sub txtNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelp.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ' 5. Tombol Cetak Kartu beserta Error Handling "Inputan tidak boleh kosong"
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        ' --- ERROR HANDLING ---

        ' Cek TextBox Kosong
        If String.IsNullOrWhiteSpace(txtNama.Text) OrElse
           String.IsNullOrWhiteSpace(txtUmur.Text) OrElse
           String.IsNullOrWhiteSpace(txtNoTelp.Text) OrElse
           String.IsNullOrWhiteSpace(txtAlamat.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Cek PictureBox Kosong
        If PbFoto.Image Is Nothing Then
            MessageBox.Show("Inputan tidak boleh kosong (Silakan pilih foto profil)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Cek Radio Button (Jenis Kelamin) Kosong
        If Not rbLakiLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong (Pilih Jenis Kelamin)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Cek CheckBox (Hobby) Kosong
        Dim hobiTerpilih As Boolean = False
        Dim listHobi As String = ""

        For Each ctrl As Control In gbHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                If cb.Checked Then
                    hobiTerpilih = True
                    listHobi &= cb.Text & ", "
                End If
            End If
        Next

        If Not hobiTerpilih Then
            MessageBox.Show("Inputan tidak boleh kosong (Pilih minimal satu Hobby)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' --- PASSING DATA KE FORM 2 ---

        ' Rapikan string hobi (hapus koma terakhir)
        If listHobi.Length > 0 Then
            listHobi = listHobi.Substring(0, listHobi.Length - 2)
        End If

        ' Inisialisasi Form2
        Dim formHasil As New Form2()

        ' Pindahkan data ke Form2
        formHasil.pbFotoHasil.Image = PbFoto.Image
        formHasil.lblNama.Text = txtNama.Text
        formHasil.lblUmur.Text = txtUmur.Text & " Tahun"
        formHasil.lblNoTelp.Text = txtNoTelp.Text
        formHasil.lblTanggalLahir.Text = dtpTanggalLahir.Value.ToString("dd MMMM yyyy")
        formHasil.lblAlamat.Text = txtAlamat.Text
        formHasil.lblHobby.Text = listHobi

        If rbLakiLaki.Checked Then
            formHasil.lblJenisKelamin.Text = "Laki-laki"
        Else
            formHasil.lblJenisKelamin.Text = "Perempuan"
        End If

        ' Tampilkan Form2
        formHasil.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class