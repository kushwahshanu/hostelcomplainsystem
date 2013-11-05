Imports System.Data.OleDb
Public Class Form10
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim da As OleDbDataAdapter
    Dim reader As OleDbDataReader
    Dim D As Date
    Dim ANS As Integer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub openconnection()
        Try
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chachu..prog\HOSTELCOMPLAIN.accdb")
            con.Open()

        Catch ex As Exception
            MsgBox(ex.ToString())

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        openconnection()
        cmd.CommandText = "select * from COMPLAIN1 WHERE USERNAME='" + TextBox3.Text + "'"
        cmd.Connection = con
        reader = cmd.ExecuteReader

        If reader.Read = True Then

            TextBox4.Text = reader(2).ToString
            TextBox1.Text = reader(3).ToString
            D = reader(3)

            If (ANS = Val(Date.Today.Date.Day - D.Date.Day)) > 10 Then
                TextBox2.Text = "COMPLAIN PROCESSED"
            Else
                TextBox2.Text = "COMPLAIN IS UNDERPROCESSING"
            End If
            con.Close()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class