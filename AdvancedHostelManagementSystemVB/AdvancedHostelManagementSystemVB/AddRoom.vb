Imports System.Data.SqlClient

Public Class AddRoom
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
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AdvancedHostelManagementSystemVB\AdvancedHostelManagementSystemVB\adhostel.mdf;Integrated Security=True")
        con.Open()
        str = "insert into room(room_no,floor,no_std,fee) values('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("New Room Details Inserted Successfully..")
        textBox2.Text = ""
        textBox3.Text = ""
        textBox1.Text = ""

        comboBox1.Text = "--Select--"

        con.Close()
    End Sub

    Private Sub AddRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        textBox2.Text = ""
        textBox3.Text = ""
        textBox1.Text = ""

        comboBox1.Text = "--Select--"

    End Sub
End Class