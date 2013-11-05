Imports System.Data.OleDb
Public Class Form8
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim da As OleDbDataAdapter
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("WASHROOM")
        ComboBox1.Items.Add("TOILET")
        ComboBox2.Items.Add("OPAL-A")
        ComboBox2.Items.Add("OPAL-B")
        ComboBox2.Items.Add("OPAL-C")
        ComboBox2.Items.Add("OPAL-D")
        ComboBox2.Items.Add("OPAL-E")
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Chachu..prog\HOSTELCOMPLAIN.accdb")
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim R As String
        R = "W1ER"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO COMPLAIN1(C_ID,USERNAME,H_NAME,C_DATE,C_TYPE,C_TEXT)VALUES('" & R & "','" & TextBox1.Text & "','" & ComboBox2.SelectedItem & "','" & DateTimePicker1.Value & "','" & ComboBox1.SelectedItem & "','" & TextBox2.Text & "')"
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record successfully saved", MsgBoxStyle.OkCancel)
        If MsgBoxResult.Ok Then
            TextBox2.Text = ""
            TextBox1.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class