Imports System.Data.OleDb
Public Class Form4
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim da As OleDbDataAdapter

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO ROOM(ROOM_NO,NO_WINDOW,NO_COD,NO_FAN,NO_TABLE,NO_CHAIR,NO_TUBELIGHT)VALUES(" & Val(TextBox1.Text) & "," & NumericUpDown1.Value & "," & NumericUpDown2.Value & "," & NumericUpDown3.Value & "," & NumericUpDown6.Value & "," & NumericUpDown4.Value & "," & NumericUpDown5.Value & ")"
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record successfully saved", MsgBoxStyle.OkCancel)
        If MsgBoxResult.Ok Then
            TextBox1.Text = ""
            NumericUpDown1.Value = 0
            NumericUpDown2.Value = 0
            NumericUpDown3.Value = 0
            NumericUpDown4.Value = 0
            NumericUpDown5.Value = 0
            NumericUpDown6.Value = 0
        End If
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chachu..prog\HOSTELCOMPLAIN.accdb")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class