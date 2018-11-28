Public Class Form1
    Private Sub FixerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FixerToolStripMenuItem.Click
        If (My.Settings.fixer = True) Then
            Me.TopMost = False
            FixerToolStripMenuItem.Text = ("Fixer")
            My.Settings.fixer = False
            My.Settings.Save()
        ElseIf (My.Settings.fixer = False) Then
            Me.TopMost = True
            FixerToolStripMenuItem.Text = ("Détacher")
            My.Settings.fixer = True
            My.Settings.Save()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = My.Settings.text
        If (My.Settings.fixer = True) Then
            Me.TopMost = True
        End If
        If (My.Settings.fixer = False) Then
            Me.TopMost = False
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        ÉditéToolStripMenuItem.Text = ("Sauvegarde...")
        My.Settings.text = (RichTextBox1.Text)
        My.Settings.Save()
        ÉditéToolStripMenuItem.Text = ("Sauvegardé")
    End Sub
End Class
