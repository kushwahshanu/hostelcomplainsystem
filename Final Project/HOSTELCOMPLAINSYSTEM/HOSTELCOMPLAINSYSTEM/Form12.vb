Public Class Form12

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HOSTELCOMPLAINDataSet1.HOSTEL' table. You can move, or remove it, as needed.
        Me.HOSTELTableAdapter.Fill(Me.HOSTELCOMPLAINDataSet1.HOSTEL)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class