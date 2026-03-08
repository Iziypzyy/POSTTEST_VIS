Public Module ModuleBuku
    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0

    Public Function CariIndexBuku(ByVal judul As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0) = judul Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Sub TambahDataBuku(ByVal judul As String, ByVal genre As String)
        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre
            jumlahBuku += 1
        End If
    End Sub


    Public Sub HapusDataBuku(ByVal judul As String, ByRef statusHapus As Boolean)
        Dim index As Integer = CariIndexBuku(judul)

        If index <> -1 Then
            For i As Integer = index To jumlahBuku - 2
                daftarBuku(i, 0) = daftarBuku(i + 1, 0)
                daftarBuku(i, 1) = daftarBuku(i + 1, 1)
            Next

            jumlahBuku -= 1
            statusHapus = True
        Else
            statusHapus = False
        End If
    End Sub
End Module