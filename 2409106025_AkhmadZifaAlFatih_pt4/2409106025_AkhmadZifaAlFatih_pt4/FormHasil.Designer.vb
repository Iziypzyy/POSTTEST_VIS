<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHasil
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents LabelJudul As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        LabelJudul = New Label()
        PictureBox1 = New PictureBox()
        lblNama = New Label()
        lblID = New Label()
        lblKomunitas = New Label()
        lblKontak = New Label()
        lblHobi = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(LabelJudul)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(lblNama)
        Panel1.Controls.Add(lblID)
        Panel1.Controls.Add(lblKomunitas)
        Panel1.Controls.Add(lblKontak)
        Panel1.Controls.Add(lblHobi)
        Panel1.Location = New Point(50, 30)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(544, 250)
        Panel1.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(151, 136)
        Label4.Name = "Label4"
        Label4.Size = New Size(156, 25)
        Label4.TabIndex = 10
        Label4.Text = "Kontak                 :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(151, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(157, 25)
        Label3.TabIndex = 9
        Label3.Text = "Nama Komunitas :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(152, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 25)
        Label2.TabIndex = 8
        Label2.Text = "ID Anggota          :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(152, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 25)
        Label1.TabIndex = 7
        Label1.Text = "Nama                   :"
        ' 
        ' LabelJudul
        ' 
        LabelJudul.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LabelJudul.Location = New Point(151, 11)
        LabelJudul.Name = "LabelJudul"
        LabelJudul.Size = New Size(250, 30)
        LabelJudul.TabIndex = 0
        LabelJudul.Text = "KARTU KOMUNITAS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(11, 46)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(131, 166)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.Location = New Point(315, 46)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(200, 20)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        ' 
        ' lblID
        ' 
        lblID.Location = New Point(315, 76)
        lblID.Name = "lblID"
        lblID.Size = New Size(200, 25)
        lblID.TabIndex = 3
        lblID.Text = "ID"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.Location = New Point(315, 106)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(200, 25)
        lblKomunitas.TabIndex = 4
        lblKomunitas.Text = "Komunitas"
        ' 
        ' lblKontak
        ' 
        lblKontak.Location = New Point(315, 136)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(187, 25)
        lblKontak.TabIndex = 5
        lblKontak.Text = "Kontak"
        ' 
        ' lblHobi
        ' 
        lblHobi.Location = New Point(152, 184)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(350, 40)
        lblHobi.TabIndex = 6
        lblHobi.Text = "Hobi"
        ' 
        ' FormHasil
        ' 
        BackgroundImage = My.Resources.Resources.download
        ClientSize = New Size(671, 320)
        Controls.Add(Panel1)
        Name = "FormHasil"
        Text = "Kartu Komunitas"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class