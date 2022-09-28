Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtExe.Text = My.Settings.Exe
    End Sub
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        My.Settings.Exe = txtExe.Text
        My.Settings.Save()
        Me.Hide()
    End Sub
End Class