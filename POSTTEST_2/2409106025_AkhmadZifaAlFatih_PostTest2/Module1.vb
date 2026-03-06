Public Module ModuleBuku
    ' 1. Array multidimensi disimpan di Module (Sesuai contoh Halaman 8) 
    ' Indeks 0 untuk Judul Buku, Indeks 1 untuk Genre Buku
    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0

    ' 2. Function minimal 1 (Sesuai contoh Halaman 7) 
    ' Function ini mencari index array berdasarkan judul buku
    Public Function CariIndexBuku(ByVal judul As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0) = judul Then
                Return i
            End If
        Next
        Return -1
    End Function

    ' 3. Procedure dengan argumen ByVal (Sesuai contoh Halaman 6 & 8) 
    Public Sub TambahDataBuku(ByVal judul As String, ByVal genre As String)
        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre
            jumlahBuku += 1
        End If
    End Sub

    ' 4. Procedure dengan argumen ByVal dan ByRef (Sesuai contoh Halaman 6) 
    Public Sub HapusDataBuku(ByVal judul As String, ByRef statusHapus As Boolean)
        Dim index As Integer = CariIndexBuku(judul)

        If index <> -1 Then
            ' Menggunakan For...Next untuk menggeser data (Sesuai Halaman 2) 
            For i As Integer = index To jumlahBuku - 2
                daftarBuku(i, 0) = daftarBuku(i + 1, 0)
                daftarBuku(i, 1) = daftarBuku(i + 1, 1)
            Next

            jumlahBuku -= 1
            statusHapus = True ' Mengubah nilai variabel asli karena ByRef 
        Else
            statusHapus = False
        End If
    End Sub
End Module