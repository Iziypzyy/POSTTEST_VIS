Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Agar form muncul tepat di tengah layar
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Kunci ukuran form agar desain kartu tidak rusak (opsional)
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblHobby.Click

    End Sub

    Private Sub lblNoTelp_Click(sender As Object, e As EventArgs) Handles lblNoTelp.Click

    End Sub
End Class