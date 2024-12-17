Public Class Form2
    Public Sub ShowForm(formToShow As Form)
        Panel1.Controls.Clear()
        formToShow.TopLevel = False
        formToShow.FormBorderStyle = FormBorderStyle.None
        formToShow.Dock = DockStyle.Fill
        Panel1.Controls.Add(formToShow)
        formToShow.Show()

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Liste1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Liste1ToolStripMenuItem.Click
        ShowForm(New ListLiv)
    End Sub

    Private Sub Liste2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Liste2ToolStripMenuItem.Click
        ShowForm(New List2)
    End Sub

    Private Sub AjoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjoutToolStripMenuItem.Click
        ShowForm(New AddLiv)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class