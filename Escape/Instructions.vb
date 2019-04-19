Public Class FORMEscapeInstructions

    Private Sub BTNMenu_Click(sender As System.Object, e As System.EventArgs) Handles BTNMenu.Click
        Me.Close()
        FORMEscapeMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub FORMEscapeInstructions_FormClosed(sender As System.Object, e As System.EventArgs) Handles Me.FormClosed
        FORMEscapeMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub FORMEscapeInstructions_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class