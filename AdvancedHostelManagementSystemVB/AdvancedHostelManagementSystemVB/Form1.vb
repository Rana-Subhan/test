Imports System.Data.SqlClient

Public Class Form1
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    Dim gen As String
    Dim str As String
    Dim getuser As String
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView
    Dim addhost As Object
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If comboBox1.SelectedIndex = "0" Then
            If textBox1.Text = "Neeta Kadam" And textBox2.Text = "kneeta" Then
                MessageBox.Show("Welcome Admin")

                comboBox1.Text = "--Select Type--"
                textBox1.Text = ""
                textBox2.Text = ""
                Hide()
                HomeAdmin.ShowDialog()

            Else
                MessageBox.Show("login fail")
            End If


        ElseIf comboBox1.SelectedIndex = "1" Then
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AdvancedHostelManagementSystemVB\AdvancedHostelManagementSystemVB\adhostel.mdf;Integrated Security=True")
            con.Open()
            Try
                getuser = "select id from employee where name='" & textBox1.Text & "' and pass='" & textBox2.Text & "'"
                com = New SqlCommand(getuser, con)
                dr = com.ExecuteReader()
                If (dr.Read()) Then
                    MsgBox("Welcome Employee.")

                    comboBox1.Text = "--Select Type--"
                    textBox1.Text = ""
                    textBox2.Text = ""
                    Hide()
                    HomeEmployee.ShowDialog()

                Else
                    MsgBox("something Wrong")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
End Class
