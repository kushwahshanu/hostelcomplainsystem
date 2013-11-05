Imports System.Data.OleDb
Public Class Form3
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim da As OleDbDataAdapter

    Private Sub Form3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        con.Close()
    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chachu..prog\HOSTELCOMPLAIN.accdb")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "insert into HOSTEL(H_ID,H_NAME,TOTAL_FLOOR,TOTAL_ROOM,TOTAL_WASHROOM,TOTAL_WATERCOOLER)values(" & Val(TextBox1.Text) & ",'" & TextBox2.Text & "'," & Val(TextBox3.Text) & "," & Val(TextBox4.Text) & "," & Val(TextBox5.Text) & "," & Val(TextBox6.Text) & ")"
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record successfully saved", MsgBoxStyle.Information, MsgBoxStyle.OkCancel)
        If MsgBoxResult.Ok Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class