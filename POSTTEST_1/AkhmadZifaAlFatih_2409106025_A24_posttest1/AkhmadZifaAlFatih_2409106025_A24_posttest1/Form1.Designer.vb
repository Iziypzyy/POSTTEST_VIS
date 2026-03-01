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
        txtIPSemester = New TextBox()
        Label1 = New Label()
        btnTambah = New Button()
        btnReset = New Button()
        Label2 = New Label()
        txtIPK = New TextBox()
        LblPredikat = New Label()
        SuspendLayout()
        ' 
        ' txtIPSemester
        ' 
        txtIPSemester.Location = New Point(164, 76)
        txtIPSemester.Margin = New Padding(3, 2, 3, 2)
        txtIPSemester.Name = "txtIPSemester"
        txtIPSemester.Size = New Size(193, 31)
        txtIPSemester.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 20)
        Label1.TabIndex = 1
        Label1.Text = "IP Semester"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = SystemColors.ActiveBorder
        btnTambah.Location = New Point(164, 116)
        btnTambah.Margin = New Padding(3, 2, 3, 2)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(102, 28)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = SystemColors.ActiveBorder
        btnReset.Location = New Point(272, 116)
        btnReset.Margin = New Padding(3, 2, 3, 2)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(85, 28)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 182)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 20)
        Label2.TabIndex = 4
        Label2.Text = "IP Kumulatif"
        ' 
        ' txtIPK
        ' 
        txtIPK.Enabled = False
        txtIPK.Location = New Point(164, 179)
        txtIPK.Margin = New Padding(3, 2, 3, 2)
        txtIPK.Name = "txtIPK"
        txtIPK.ReadOnly = True
        txtIPK.Size = New Size(193, 31)
        txtIPK.TabIndex = 5
        txtIPK.Text = "0,00"
        ' 
        ' LblPredikat
        ' 
        LblPredikat.AutoSize = True
        LblPredikat.Location = New Point(164, 215)
        LblPredikat.Name = "LblPredikat"
        LblPredikat.Size = New Size(0, 20)
        LblPredikat.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(513, 360)
        Controls.Add(LblPredikat)
        Controls.Add(txtIPK)
        Controls.Add(Label2)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(Label1)
        Controls.Add(txtIPSemester)
        Cursor = Cursors.Cross
        Font = New Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.Fixed3D
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "IPK Kalkulator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIPSemester As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents LblPredikat As Label

End Class
