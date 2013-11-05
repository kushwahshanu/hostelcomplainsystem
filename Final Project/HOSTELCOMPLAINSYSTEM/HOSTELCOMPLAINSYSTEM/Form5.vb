Public Class Form5
    Dim f2 As Form2 = New Form2
    Dim f3 As Form3 = New Form3
    Dim f4 As Form4 = New Form4
    Dim f6 As Form6 = New Form6
    Dim f8 As Form8 = New Form8
    Private Sub AddStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        f2.Show()
    End Sub

    Private Sub AddHostelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddHostelToolStripMenuItem.Click
        f3.Show()
    End Sub

    Private Sub AddRoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddRoomToolStripMenuItem.Click
        f4.Show()
    End Sub

    Private Sub Form5_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ElectricalcomplainToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ElectricalcomplainToolStripMenuItem.Click
        F6.SHOW()
    End Sub

    Private Sub WashroomsRelatedComplainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WashroomsRelatedComplainToolStripMenuItem.Click
        f8.show()
    End Sub

    Private Sub LatedComplainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LatedComplainToolStripMenuItem.Click
        Form9.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub ComplainStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplainStatusToolStripMenuItem.Click
        Form10.Show()
    End Sub

    Private Sub ViewUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewUserToolStripMenuItem.Click
        Form11.Show()
    End Sub

    Private Sub ViewHostelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewHostelToolStripMenuItem.Click
        Form12.Show()
    End Sub
End Class