Public Class HomeEmployee
    Private Sub addStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addStudentToolStripMenuItem.Click
        Student.ShowDialog()
    End Sub

    Private Sub bookHostelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles bookHostelToolStripMenuItem.Click
        BookHostel.ShowDialog()
    End Sub

    Private Sub addRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addRoomToolStripMenuItem.Click
        AddRoom.ShowDialog()
    End Sub

    Private Sub viewRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles viewRoomToolStripMenuItem.Click
        ViewRoom.ShowDialog()
    End Sub

    Private Sub viewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles viewStudentToolStripMenuItem.Click
        ViewEmployee.ShowDialog()
    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        Hide()
        Form1.ShowDialog()
    End Sub
End Class