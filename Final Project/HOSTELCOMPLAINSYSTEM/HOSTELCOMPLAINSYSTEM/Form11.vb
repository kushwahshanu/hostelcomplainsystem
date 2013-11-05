Public Class Form11

    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HOSTELCOMPLAINDataSet.REGISTER' table. You can move, or remove it, as needed.
        Me.REGISTERTableAdapter.Fill(Me.HOSTELCOMPLAINDataSet.REGISTER)

    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.REGISTERTableAdapter.Fill(Me.HOSTELCOMPLAINDataSet.REGISTER)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class