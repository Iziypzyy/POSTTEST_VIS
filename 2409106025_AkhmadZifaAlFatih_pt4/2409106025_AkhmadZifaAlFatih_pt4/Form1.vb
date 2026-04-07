Imports System.IO

Public Class Form1

    Dim fotoPath As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' ================= VALIDASI =================

    ' Nama hanya huruf
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' ID hanya angka
    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' ================= FOTO =================
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.png"

        If ofd.ShowDialog = DialogResult.OK Then
            fotoPath = ofd.FileName
            picFoto.Image = Image.FromFile(fotoPath)
        End If
    End Sub

    ' ================= VALIDASI INPUT =================
    Function ValidasiInput() As Boolean

        If txtNama.Text = "" Or txtID.Text = "" Or cmbKomunitas.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Return False
        End If

        If Not rbLaki.Checked And Not rbPerempuan.Checked Then
            MessageBox.Show("Pilih jenis kelamin")
            Return False
        End If

        If Not mskHP.MaskFull Then
            MessageBox.Show("Nomor HP tidak sesuai format")
            Return False
        End If

        If Not (chk1.Checked Or chk2.Checked Or chk3.Checked Or chk4.Checked Or chk5.Checked Or chk6.Checked Or chk7.Checked Or chk8.Checked) Then
            MessageBox.Show("Pilih minimal 1 hobby")
            Return False
        End If

        Return True
    End Function

    ' ================= SIMPAN & CETAK =================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If Not ValidasiInput() Then Exit Sub

        Dim hobby As String = ""

        If chk1.Checked Then hobby &= "Ngoding, "
        If chk2.Checked Then hobby &= "Desain, "
        If chk3.Checked Then hobby &= "Game, "
        If chk4.Checked Then hobby &= "Musik, "
        If chk5.Checked Then hobby &= "Editing, "
        If chk6.Checked Then hobby &= "Fotografi, "
        If chk7.Checked Then hobby &= "Menulis, "
        If chk8.Checked Then hobby &= "Public Speaking"

        ' pindah ke form hasil
        Dim f As New FormHasil

        f.lblNama.Text = txtNama.Text
        f.lblID.Text = txtID.Text
        f.lblKomunitas.Text = cmbKomunitas.Text
        f.lblKontak.Text = mskHP.Text
        f.lblHobi.Text = hobby
        f.PictureBox1.Image = picFoto.Image

        f.Show()

        MessageBox.Show("Data berhasil ditampilkan!")
    End Sub

    ' ================= MENU =================

    Private Sub menuKeluar_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click
        If MessageBox.Show("Yakin keluar?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub menuInput_Click(sender As Object, e As EventArgs) Handles menuInput.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub menuLihat_Click(sender As Object, e As EventArgs) Handles menuLihat.Click
        TabControl1.SelectedIndex = 2
    End Sub

End Class