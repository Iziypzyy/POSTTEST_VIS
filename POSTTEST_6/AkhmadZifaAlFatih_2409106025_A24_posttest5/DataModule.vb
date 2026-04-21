Imports MySqlConnector

Module DataModule

    ' ================================================================
    '  FILE : DataModule.vb  (LENGKAP — gantikan file lama sepenuhnya)
    '  Berisi semua fungsi CRUD untuk:
    '    1. tbpakaian  (tabel utama, sudah ada sejak modul sebelumnya)
    '    2. tbsupplier (tabel induk baru — Modul 6)
    '    3. tbstok     (tabel anak baru — Modul 6)
    ' ================================================================

    ' ----------------------------------------------------------------
    '  KONEKSI  — sesuaikan server/user/password/database jika berbeda
    ' ----------------------------------------------------------------
    Public Function GetConnection() As MySqlConnection
        Dim connStr As String = "Server=localhost;Port=3306;" &
                                "Database=db_tokopakaian;" &
                                "Uid=root;Pwd=;"
        Return New MySqlConnection(connStr)
    End Function

    ' ================================================================
    '  BAGIAN 1 — TBPAKAIAN
    ' ================================================================

    ''' <summary>Ambil semua data pakaian, diurutkan by kodePakaian.</summary>
    Public Function GetAllPakaian() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kodePakaian, namaPakaian, kategori, " &
                                  "ukuran, harga, Deskripsi " &
                                  "FROM tbpakaian ORDER BY kodePakaian ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data pakaian: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ''' <summary>Cari pakaian by kode (untuk auto-fill saat tekan Enter di txtKode).</summary>
    Public Function GetPakaianByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tbpakaian WHERE kodePakaian = @kode"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kode", kode)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data pakaian: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ''' <summary>Cek apakah kodePakaian sudah ada di database.</summary>
    Public Function KodeSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbpakaian WHERE kodePakaian = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch
            Return True   ' anggap sudah ada agar tidak terjadi duplikat
        End Try
    End Function

    ''' <summary>Simpan data pakaian baru ke tbpakaian.</summary>
    Public Function SimpanPakaian(kode As String, nama As String, kategori As String,
                                   ukuran As String, harga As Integer,
                                   deskripsi As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbpakaian " &
                                  "(kodePakaian, namaPakaian, kategori, ukuran, harga, Deskripsi) " &
                                  "VALUES (@kode, @nama, @kategori, @ukuran, @harga, @deskripsi)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kategori", kategori)
                    cmd.Parameters.AddWithValue("@ukuran", ukuran)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data pakaian: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ''' <summary>Ubah data pakaian yang sudah ada.</summary>
    Public Function UbahPakaian(kode As String, nama As String, kategori As String,
                                 ukuran As String, harga As Integer,
                                 deskripsi As String) As Boolean
        Try
            Dim query As String = "UPDATE tbpakaian " &
                                  "SET namaPakaian = @nama, kategori = @kategori, " &
                                  "    ukuran = @ukuran, harga = @harga, Deskripsi = @deskripsi " &
                                  "WHERE kodePakaian = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kategori", kategori)
                    cmd.Parameters.AddWithValue("@ukuran", ukuran)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data pakaian: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ''' <summary>Hapus data pakaian. Gagal jika masih ada stok terkait (FK RESTRICT).</summary>
    Public Function HapusPakaian(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbpakaian WHERE kodePakaian = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            If ex.Message.ToLower().Contains("foreign key") Then
                MessageBox.Show("Pakaian tidak bisa dihapus karena masih memiliki " &
                                "data stok masuk yang berelasi." & vbCrLf &
                                "Hapus data stok terkait terlebih dahulu.",
                                "Peringatan Relasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Gagal menghapus data pakaian: " & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return False
        End Try
    End Function

    ''' <summary>Cari pakaian berdasarkan nama, kategori, atau ukuran.</summary>
    Public Function SearchPakaian(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kodePakaian, namaPakaian, kategori, " &
                                  "ukuran, harga, Deskripsi " &
                                  "FROM tbpakaian " &
                                  "WHERE namaPakaian LIKE @kw " &
                                  "   OR kategori    LIKE @kw " &
                                  "   OR ukuran      LIKE @kw " &
                                  "ORDER BY kodePakaian ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data pakaian: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' ================================================================
    '  BAGIAN 2 — TBSUPPLIER  (Tabel Induk — Modul 6)
    ' ================================================================

    Public Function GetAllSupplier() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kodeSupplier, namaSupplier, " &
                                  "kontakSupplier, alamatSupplier " &
                                  "FROM tbsupplier ORDER BY kodeSupplier ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data supplier: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchSupplier(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kodeSupplier, namaSupplier, " &
                                  "kontakSupplier, alamatSupplier " &
                                  "FROM tbsupplier " &
                                  "WHERE namaSupplier   LIKE @kw " &
                                  "   OR kontakSupplier LIKE @kw " &
                                  "   OR alamatSupplier LIKE @kw " &
                                  "ORDER BY kodeSupplier ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data supplier: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodeSupplierSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbsupplier WHERE kodeSupplier = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch
            Return True
        End Try
    End Function

    Public Function SimpanSupplier(kode As String, nama As String,
                                    kontak As String, alamat As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbsupplier " &
                                  "(kodeSupplier, namaSupplier, kontakSupplier, alamatSupplier) " &
                                  "VALUES (@kode, @nama, @kontak, @alamat)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kontak", kontak)
                    cmd.Parameters.AddWithValue("@alamat", alamat)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data supplier: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahSupplier(kode As String, nama As String,
                                  kontak As String, alamat As String) As Boolean
        Try
            Dim query As String = "UPDATE tbsupplier " &
                                  "SET namaSupplier = @nama, kontakSupplier = @kontak, " &
                                  "    alamatSupplier = @alamat " &
                                  "WHERE kodeSupplier = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kontak", kontak)
                    cmd.Parameters.AddWithValue("@alamat", alamat)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data supplier: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusSupplier(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbsupplier WHERE kodeSupplier = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            If ex.Message.ToLower().Contains("foreign key") Then
                MessageBox.Show("Supplier tidak bisa dihapus karena masih memiliki " &
                                "data stok yang berelasi." & vbCrLf &
                                "Hapus data stok terkait terlebih dahulu.",
                                "Peringatan Relasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Gagal menghapus data supplier: " & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return False
        End Try
    End Function

    ' ================================================================
    '  BAGIAN 3 — TBSTOK  (Tabel Anak — Modul 6)
    '  JOIN ke tbpakaian (FK: kodePakaian) dan tbsupplier (FK: kodeSupplier)
    '
    '  Indeks kolom hasil query GetAllStok / SearchStok:
    '    0 = kodeStok
    '    1 = kodePakaian  (disembunyikan di grid, dipakai untuk set cbPakaian)
    '    2 = Nama Pakaian
    '    3 = kodeSupplier (disembunyikan di grid, dipakai untuk set cbSupplier)
    '    4 = Nama Supplier
    '    5 = tanggalMasuk
    '    6 = jumlahMasuk
    '    7 = hargaBeli
    '    8 = Total Nilai
    '    9 = keterangan
    ' ================================================================

    Public Function GetAllStok() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT tbstok.kodeStok, " &
                "       tbstok.kodePakaian, " &
                "       tbpakaian.namaPakaian   AS 'Nama Pakaian', " &
                "       tbstok.kodeSupplier, " &
                "       tbsupplier.namaSupplier AS 'Nama Supplier', " &
                "       tbstok.tanggalMasuk, " &
                "       tbstok.jumlahMasuk, " &
                "       tbstok.hargaBeli, " &
                "       (tbstok.jumlahMasuk * tbstok.hargaBeli) AS 'Total Nilai', " &
                "       tbstok.keterangan " &
                "FROM tbstok " &
                "INNER JOIN tbpakaian  ON tbstok.kodePakaian  = tbpakaian.kodePakaian " &
                "INNER JOIN tbsupplier ON tbstok.kodeSupplier = tbsupplier.kodeSupplier " &
                "ORDER BY tbstok.tanggalMasuk DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data stok: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchStok(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT tbstok.kodeStok, " &
                "       tbstok.kodePakaian, " &
                "       tbpakaian.namaPakaian   AS 'Nama Pakaian', " &
                "       tbstok.kodeSupplier, " &
                "       tbsupplier.namaSupplier AS 'Nama Supplier', " &
                "       tbstok.tanggalMasuk, " &
                "       tbstok.jumlahMasuk, " &
                "       tbstok.hargaBeli, " &
                "       (tbstok.jumlahMasuk * tbstok.hargaBeli) AS 'Total Nilai', " &
                "       tbstok.keterangan " &
                "FROM tbstok " &
                "INNER JOIN tbpakaian  ON tbstok.kodePakaian  = tbpakaian.kodePakaian " &
                "INNER JOIN tbsupplier ON tbstok.kodeSupplier = tbsupplier.kodeSupplier " &
                "WHERE tbpakaian.namaPakaian   LIKE @kw " &
                "   OR tbsupplier.namaSupplier LIKE @kw " &
                "   OR tbstok.keterangan       LIKE @kw " &
                "ORDER BY tbstok.tanggalMasuk DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data stok: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodeStokSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbstok WHERE kodeStok = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch
            Return True
        End Try
    End Function

    Public Function SimpanStok(kode As String, kodePakaian As String, kodeSupplier As String,
                                tanggal As Date, jumlah As Integer,
                                hargaBeli As Integer, keterangan As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbstok " &
                "(kodeStok, kodePakaian, kodeSupplier, tanggalMasuk, jumlahMasuk, hargaBeli, keterangan) " &
                "VALUES (@kode, @kodePakaian, @kodeSupplier, @tanggal, @jumlah, @hargaBeli, @ket)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@kodePakaian", kodePakaian)
                    cmd.Parameters.AddWithValue("@kodeSupplier", kodeSupplier)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@jumlah", jumlah)
                    cmd.Parameters.AddWithValue("@hargaBeli", hargaBeli)
                    cmd.Parameters.AddWithValue("@ket", keterangan)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data stok: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahStok(kode As String, kodePakaian As String, kodeSupplier As String,
                              tanggal As Date, jumlah As Integer,
                              hargaBeli As Integer, keterangan As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tbstok " &
                "SET kodePakaian  = @kodePakaian, " &
                "    kodeSupplier = @kodeSupplier, " &
                "    tanggalMasuk = @tanggal, " &
                "    jumlahMasuk  = @jumlah, " &
                "    hargaBeli    = @hargaBeli, " &
                "    keterangan   = @ket " &
                "WHERE kodeStok = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@kodePakaian", kodePakaian)
                    cmd.Parameters.AddWithValue("@kodeSupplier", kodeSupplier)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@jumlah", jumlah)
                    cmd.Parameters.AddWithValue("@hargaBeli", hargaBeli)
                    cmd.Parameters.AddWithValue("@ket", keterangan)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data stok: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusStok(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbstok WHERE kodeStok = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data stok: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module