Public Class Form1
    Dim totalNilaiIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim inputRaw As String = txtIPSemester.Text.Replace(",", ".")
        Dim ipSemester As Double

        If Double.TryParse(inputRaw, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, ipSemester) Then

            If ipSemester >= 0 And ipSemester <= 4 Then
                ' Fungsi Akumulatif:
                totalNilaiIP += ipSemester
                jumlahSemester += 1

                ' Hitung Rata-rata (IPK)
                Dim ipk As Double = totalNilaiIP / jumlahSemester

                ' Buat tampilan dengan desimal
                txtIPK.Text = ipk.ToString("N2")

                Select Case ipk
                    Case 3.01 To 4.0
                        LblPredikat.Text = "Sangat Memuaskan"
                    Case 2.76 To 3.0
                        LblPredikat.Text = "Memuaskan"
                    Case 2.0 To 2.75
                        LblPredikat.Text = "Cukup"
                    Case Else
                        LblPredikat.Text = "Data Tidak Valid"
                End Select

                ' fungsi untuk hapus setelah di input
                txtIPSemester.Clear()
                txtIPSemester.Focus()
            Else
                MsgBox("IP Semester harus di antara 0.00 sampai 4.00")
            End If
        Else
            MsgBox("Mohon masukkan angka yang valid!")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'untuk reset bang mba
        totalNilaiIP = 0
        jumlahSemester = 0
        txtIPK.Text = "0,00"
        LblPredikat.Text = "-"
        txtIPSemester.Clear()
    End Sub
End Class