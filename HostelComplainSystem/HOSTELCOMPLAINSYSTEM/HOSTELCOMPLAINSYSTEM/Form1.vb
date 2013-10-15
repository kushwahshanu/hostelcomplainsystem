Imports System.Data.OleDb

Public Class Form1
    Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chachu..prog\HOSTELCOMPLAIN.accdb")
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        openconnection()
        cmd.CommandText = "select * from LOGIN where Username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'"
        cmd.Connection = con
        reader = cmd.ExecuteReader
        If reader.HasRows Then
            Dim f2 As Form2 = New Form2
            f2.Show()
        Else
            MsgBox("Error")
        End If
    End Sub

    Private Sub Form1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        con.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

    End Sub
    Public Sub openconnection()
        Try
            con.Open()
            MsgBox("successful")
        Catch ex As Exception
            MsgBox(ex.ToString())

        End Try



    End Sub

End Class
