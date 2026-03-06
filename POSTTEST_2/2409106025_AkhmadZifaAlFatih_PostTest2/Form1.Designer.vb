<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtJudulTambah = New TextBox()
        txtGenreTambah = New TextBox()
        txtJudulHapus = New TextBox()
        BtnTambah = New Button()
        BtnHapus = New Button()
        ListBox1 = New ListBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(BtnTambah)
        GroupBox1.Controls.Add(txtGenreTambah)
        GroupBox1.Controls.Add(txtJudulTambah)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(24, 31)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(325, 192)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(BtnHapus)
        GroupBox2.Controls.Add(txtJudulHapus)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(413, 31)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(342, 192)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 2
        Label1.Text = "Judul Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(0, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 25)
        Label2.TabIndex = 0
        Label2.Text = "Genre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 39)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 25)
        Label3.TabIndex = 3
        Label3.Text = "Judul Buku"
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.Location = New Point(103, 39)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(177, 31)
        txtJudulTambah.TabIndex = 3
        ' 
        ' txtGenreTambah
        ' 
        txtGenreTambah.Location = New Point(103, 85)
        txtGenreTambah.Name = "txtGenreTambah"
        txtGenreTambah.Size = New Size(177, 31)
        txtGenreTambah.TabIndex = 4
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.Location = New Point(132, 39)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(177, 31)
        txtJudulHapus.TabIndex = 5
        ' 
        ' BtnTambah
        ' 
        BtnTambah.BackColor = SystemColors.ActiveBorder
        BtnTambah.Location = New Point(197, 148)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(112, 34)
        BtnTambah.TabIndex = 6
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = False
        ' 
        ' BtnHapus
        ' 
        BtnHapus.BackColor = SystemColors.ActiveBorder
        BtnHapus.Location = New Point(214, 148)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(112, 34)
        BtnHapus.TabIndex = 7
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = False
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(196, 250)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(378, 179)
        ListBox1.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListBox1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "P05TT3ST 2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGenreTambah As TextBox
    Friend WithEvents txtJudulTambah As TextBox
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents ListBox1 As ListBox

End Class
