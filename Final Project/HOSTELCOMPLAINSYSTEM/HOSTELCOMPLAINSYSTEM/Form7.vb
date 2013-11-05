Imports System.Data.OleDb
Public Class Form7
    Dim con As OleDbConnection
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim cmd1 As OleDbCommand = New OleDbCommand
    Dim STR As String
    Dim str2 As String
    Dim I As Integer = 0
    Private Sub Form7_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        con.Close()
    End Sub
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("What is your dream company")
        ComboBox1.Items.Add("Who is your role model")
        ComboBox1.Items.Add("What is your birth place")
        ComboBox1.Items.Add("Which is your favourite sports")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
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
        cmd.CommandText = "select * from REGISTER where rno='" + TextBox1.Text + "' AND question='" + ComboBox1.SelectedItem + "' and answer='" + TextBox2.Text + "'"
        MsgBox(cmd.CommandText)
        cmd.Connection = con
        reader = cmd.ExecuteReader

        If reader.Read = True Then
            STR = reader(6).ToString
            str2 = reader(0).ToString
            MsgBox("Your password is" + STR)
            Label4.Text = STR
            ListBox1.Items.Add(reader(0))
            ListBox2.Items.Add(reader(6))

            MsgBox("conclosed")
        End If
      
    End Sub
   
    Private Sub Button1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.LostFocus
        

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If I <> 1 Then


            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chachu..prog\HOSTELCOMPLAIN.accdb")
            conn.Open()
            cmd1.Connection = conn
            cmd1.CommandText = "insert into LOGIN(Username,password)values('" & str2 & "','" & STR & "')"
            MsgBox(cmd1.CommandText)
            conn.Close()
            cmd1.ExecuteNonQuery()
            MsgBox("successfull")

        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
End Class