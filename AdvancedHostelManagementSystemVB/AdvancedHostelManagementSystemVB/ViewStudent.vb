Imports System.Data.SqlClient

Public Class ViewStudent
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
    Private Sub ViewStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdhostelDataSet.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.AdhostelDataSet.student)
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AdvancedHostelManagementSystemVB\AdvancedHostelManagementSystemVB\adhostel.mdf;Integrated Security=True")
            str = "select * from student"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, addhost)
        End Using
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\AdvancedHostelManagementSystemVB\AdvancedHostelManagementSystemVB\adhostel.mdf;Integrated Security=True")
            str = "select * from student where id='" + textBox1.Text + "'"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, addhost)
        End Using
    End Sub
End Class