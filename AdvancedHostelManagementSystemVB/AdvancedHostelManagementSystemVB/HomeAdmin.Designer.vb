<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.addEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.addStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.addRoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewRoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menuStrip1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addEmployeeToolStripMenuItem, Me.addStudentToolStripMenuItem, Me.addRoomToolStripMenuItem, Me.viewStudentToolStripMenuItem, Me.viewRoomToolStripMenuItem, Me.viewEmployeeToolStripMenuItem, Me.exitToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(735, 24)
        Me.menuStrip1.TabIndex = 1
        Me.menuStrip1.Text = "menuStrip1"
        '
        'addEmployeeToolStripMenuItem
        '
        Me.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem"
        Me.addEmployeeToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.addEmployeeToolStripMenuItem.Text = "Add Employee"
        '
        'addStudentToolStripMenuItem
        '
        Me.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem"
        Me.addStudentToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.addStudentToolStripMenuItem.Text = "Add Student"
        '
        'addRoomToolStripMenuItem
        '
        Me.addRoomToolStripMenuItem.Name = "addRoomToolStripMenuItem"
        Me.addRoomToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.addRoomToolStripMenuItem.Text = "Add Room"
        '
        'viewStudentToolStripMenuItem
        '
        Me.viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem"
        Me.viewStudentToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.viewStudentToolStripMenuItem.Text = "View Student"
        '
        'viewRoomToolStripMenuItem
        '
        Me.viewRoomToolStripMenuItem.Name = "viewRoomToolStripMenuItem"
        Me.viewRoomToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.viewRoomToolStripMenuItem.Text = "View Room"
        '
        'viewEmployeeToolStripMenuItem
        '
        Me.viewEmployeeToolStripMenuItem.Name = "viewEmployeeToolStripMenuItem"
        Me.viewEmployeeToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.viewEmployeeToolStripMenuItem.Text = "View Employee"
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.exitToolStripMenuItem.Text = "Exit"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.AdvancedHostelManagementSystemVB.My.Resources.Resources.kashipara
        Me.pictureBox1.Location = New System.Drawing.Point(623, 39)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 50
        Me.pictureBox1.TabStop = False
        '
        'HomeAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 418)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Name = "HomeAdmin"
        Me.Text = "HomeAdmin"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents addEmployeeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents addStudentToolStripMenuItem As ToolStripMenuItem
    Private WithEvents addRoomToolStripMenuItem As ToolStripMenuItem
    Private WithEvents viewStudentToolStripMenuItem As ToolStripMenuItem
    Private WithEvents viewRoomToolStripMenuItem As ToolStripMenuItem
    Private WithEvents viewEmployeeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents exitToolStripMenuItem As ToolStripMenuItem
    Private WithEvents pictureBox1 As PictureBox
End Class
