Imports System.Data.SqlClient

Public Class Student
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
    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdhostelDataSet3.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.AdhostelDataSet3.student)
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AdvancedHostelManagementSystemVB\AdvancedHostelManagementSystemVB\adhostel.mdf;Integrated Security=True")
        con.Open()
        Try
            str = "select nextID=MAX(Id)+1 from student"
            com = New SqlCommand(str, con)
            dr = com.ExecuteReader()
            If dr.Read() Then
                textBox1.Text = dr.GetValue(0).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AdvancedHostelManagementSystemVB\AdvancedHostelManagementSystemVB\adhostel.mdf;Integrated Security=True")
            str = "select * from student"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            DataGridView1.DataSource = New BindingSource(dt, addhost)
        End Using
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AdvancedHostelManagementSystemVB\AdvancedHostelManagementSystemVB\adhostel.mdf;Integrated Security=True")
        con.Open()
        str = "insert into student(name,gender,mobile,email,addr,dob,city) values('" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("student Details Inserted Successfully..")
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
        textBox6.Text = ""
        textBox7.Text = ""
        comboBox1.Text = "--Select--"

        con.Close()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AdvancedHostelManagementSystemVB\AdvancedHostelManagementSystemVB\adhostel.mdf;Integrated Security=True")
        con.Open()
        str = "update student set name='" + textBox2.Text + "',gender='" + comboBox1.Text + "',mobile='" + textBox3.Text + "',email='" + textBox4.Text + "',addr='" + textBox5.Text + "',dob='" + textBox6.Text + "',city='" + textBox7.Text + "' where id='" + textBox1.Text + "'"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Student Data Updated Successfully..")
        Using con
            str = "select * from student"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            DataGridView1.DataSource = New BindingSource(dt, addhost)
        End Using
        comboBox1.Text = "--Select--"

        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
        textBox6.Text = ""
        textBox7.Text = ""
        con.Close()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AdvancedHostelManagementSystemVB\AdvancedHostelManagementSystemVB\adhostel.mdf;Integrated Security=True")
        con.Open()
        Try
            str = "Select name,gender,mobile,email,addr,dob,city from student where id='" + textBox1.Text + "'"
            com = New SqlCommand(str, con)
            dr = com.ExecuteReader()
            If dr.Read() Then
                textBox2.Text = dr.GetValue(0).ToString()
                comboBox1.Text = dr.GetValue(1).ToString()
                textBox3.Text = dr.GetValue(2).ToString()
                textBox4.Text = dr.GetValue(3).ToString()
                textBox5.Text = dr.GetValue(4).ToString()
                textBox6.Text = dr.GetValue(5).ToString()
                textBox7.Text = dr.GetValue(6).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class