Public Class FORMEscapeMenu

    Private Sub BTNInstructions_Click(sender As System.Object, e As System.EventArgs) Handles BTNInstructions.Click
        FORMEscapeInstructions.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BTNPlay_Click(sender As System.Object, e As System.EventArgs) Handles BTNPlay.Click
        FORMEscapeGame.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FORMEscapeMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
