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
            MsgBox("Successfully logged on", MsgBoxStyle.Information, MsgBoxStyle.OkCancel)
            If MsgBoxResult.Ok Then
                Form5.Show()
                Me.Hide()
            End If
        ElseIf TextBox1.Text = "" Or TextBox2.Text = "" Then

            MsgBox("Please enter username or password", MsgBoxStyle.Information, MsgBoxStyle.OkCancel)
            If MsgBoxResult.Ok Then
                con.Close()
                TextBox1.Focus()
            End If
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

        Catch ex As Exception
            MsgBox(ex.ToString())

        End Try



    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form7.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
