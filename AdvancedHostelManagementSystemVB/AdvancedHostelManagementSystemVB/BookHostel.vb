Imports System.Data.SqlClient

Public Class BookHostel
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
    Private Sub BookHostel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdhostelDataSet5.book_hostel' table. You can move, or remove it, as needed.
        Me.Book_hostelTableAdapter.Fill(Me.AdhostelDataSet5.book_hostel)

        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AdvancedHostelManagementSystemVB\AdvancedHostelManagementSystemVB\adhostel.mdf;Integrated Security=True")
        con.Open()
        Try
            str = "select nextID=MAX(Id)+1 from book_hostel"
            com = New SqlCommand(str, con)
            dr = com.ExecuteReader()
            If dr.Read() Then
                textBox1.Text = dr.GetValue(0).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AdvancedHostelManagementSystemVB\AdvancedHostelManagementSystemVB\adhostel.mdf;Integrated Security=True")
            str = "select * from book_hostel"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, addhost)
        End Using
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AdvancedHostelManagementSystemVB\AdvancedHostelManagementSystemVB\adhostel.mdf;Integrated Security=True")
        con.Open()
        str = "insert into book_hostel(name,gender,mobile,addr,room_no,floor,no_std,fee) values('" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Book Room Details Inserted Successfully..")
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
        textBox6.Text = ""
        textBox7.Text = ""
        textBox8.Text = ""
        comboBox1.Text = "--Select--"

        con.Close()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AdvancedHostelManagementSystemVB\AdvancedHostelManagementSystemVB\adhostel.mdf;Integrated Security=True")
        con.Open()
        Try
            str = "Select name,gender,mobile,addr,room_no,floor,no_std,fee from book_hostel where id='" + textBox1.Text + "'"
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
                textBox8.Text = dr.GetValue(7).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AdvancedHostelManagementSystemVB\AdvancedHostelManagementSystemVB\adhostel.mdf;Integrated Security=True")
        con.Open()
        str = "update book_hostel set name='" + textBox2.Text + "',gender='" + comboBox1.Text + "',mobile='" + textBox3.Text + "',addr='" + textBox4.Text + "',room_no='" + textBox5.Text + "',floor='" + textBox6.Text + "',no_std='" + textBox7.Text + "',fee='" + textBox8.Text + "' where id='" + textBox1.Text + "'"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Booking Room Data Updated Successfully..")
        Using con
            str = "select * from book_hostel"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, addhost)
        End Using
        comboBox1.Text = "--Select--"
        textBox7.Text = ""
        textBox8.Text = ""
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
        textBox6.Text = ""
        con.Close()
    End Sub
End Class