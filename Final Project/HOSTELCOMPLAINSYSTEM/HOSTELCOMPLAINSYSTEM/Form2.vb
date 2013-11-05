Imports System.Data.OleDb
Public Class Form2

    Dim con As OleDbConnection
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim da As OleDbDataAdapter
    ' Dim reader As OleDbDataReader
    ' Dim count As Integer
    'Dim query As String
    Dim U1 As String, PAS As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox7.Text = TextBox8.Text Then
            insert()
            ' INSERT2()
        Else
            check()
            If TextBox7.Text = TextBox8.Text Then
                insert()
                ' INSERT2()
            End If
        End If
    End Sub
   
    Private Sub check()
        MsgBox("Retypr your password")
        TextBox7.SelectAll()
        TextBox7.Focus()
    End Sub
    Private Sub insert()
        con.Open()
        cmd.Connection = con

        ' cmd.CommandText = "insert into LOGIN(Username,password)values('" & TextBox1.Text & "','" & TextBox7.Text & "')"
        'cmd.ExecuteNonQuery()
        cmd.CommandText = "insert into REGISTER(RNO,sname,dept,hostel_name,room_no,floor_no,pass,question,answer)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.SelectedItem & "','" & ComboBox2.SelectedItem & "','" & ComboBox3.SelectedItem & "','" & TextBox7.Text & "','" & ComboBox4.SelectedItem & "','" & TextBox4.Text & "')"
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record successfully saved", MsgBoxStyle.OkCancel)
        If MsgBoxResult.Ok Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            ComboBox4.Text = ""
            TextBox8.Text = ""
            TextBox4.Text = ""
            TextBox1.Focus()
        End If

    End Sub
    'Private Sub INSERT2()

    '    con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chachu..prog\HOSTELCOMPLAIN.accdb")
    '    con.Open()
    '    cmd.Connection = con
    '    cmd.CommandText = "insert into LOGIN(Username,password)values('" & TextBox1.Text & "','" & TextBox7.Text & "')"
    '    cmd.ExecuteNonQuery()
    '    con.Close()
    'End Sub
    Private Sub Form2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        con.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chachu..prog\HOSTELCOMPLAIN.accdb")
        ComboBox1.Items.Add("OPAL-A")
        ComboBox1.Items.Add("OPAL-B")
        ComboBox1.Items.Add("OPAL-C")
        ComboBox1.Items.Add("OPAL-D")
        ComboBox1.Items.Add("OPAL-E")
        Dim I As Integer
        For I = 1 To 200
            ComboBox2.Items.Add(I)
        Next
        For I = 1 To 4
            ComboBox3.Items.Add(I)
        Next

        ComboBox4.Items.Add("What is your dream company")
        ComboBox4.Items.Add("Who is your role model")
        ComboBox4.Items.Add("What is your birth place")
        ComboBox4.Items.Add("Which is your favourite sports")



    End Sub
    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class