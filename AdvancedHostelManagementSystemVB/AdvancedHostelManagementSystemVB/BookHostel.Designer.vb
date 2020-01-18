<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookHostel
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
        Me.components = New System.ComponentModel.Container()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FloorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NostdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookhostelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdhostelDataSet5 = New AdvancedHostelManagementSystemVB.adhostelDataSet5()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox8 = New System.Windows.Forms.TextBox()
        Me.textBox7 = New System.Windows.Forms.TextBox()
        Me.textBox6 = New System.Windows.Forms.TextBox()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Book_hostelTableAdapter = New AdvancedHostelManagementSystemVB.adhostelDataSet5TableAdapters.book_hostelTableAdapter()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookhostelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdhostelDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridView1
        '
        Me.dataGridView1.AutoGenerateColumns = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.MobileDataGridViewTextBoxColumn, Me.AddrDataGridViewTextBoxColumn, Me.RoomnoDataGridViewTextBoxColumn, Me.FloorDataGridViewTextBoxColumn, Me.NostdDataGridViewTextBoxColumn, Me.FeeDataGridViewTextBoxColumn})
        Me.dataGridView1.DataSource = Me.BookhostelBindingSource
        Me.dataGridView1.Location = New System.Drawing.Point(31, 386)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(658, 170)
        Me.dataGridView1.TabIndex = 57
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'MobileDataGridViewTextBoxColumn
        '
        Me.MobileDataGridViewTextBoxColumn.DataPropertyName = "mobile"
        Me.MobileDataGridViewTextBoxColumn.HeaderText = "mobile"
        Me.MobileDataGridViewTextBoxColumn.Name = "MobileDataGridViewTextBoxColumn"
        '
        'AddrDataGridViewTextBoxColumn
        '
        Me.AddrDataGridViewTextBoxColumn.DataPropertyName = "addr"
        Me.AddrDataGridViewTextBoxColumn.HeaderText = "addr"
        Me.AddrDataGridViewTextBoxColumn.Name = "AddrDataGridViewTextBoxColumn"
        '
        'RoomnoDataGridViewTextBoxColumn
        '
        Me.RoomnoDataGridViewTextBoxColumn.DataPropertyName = "room_no"
        Me.RoomnoDataGridViewTextBoxColumn.HeaderText = "room_no"
        Me.RoomnoDataGridViewTextBoxColumn.Name = "RoomnoDataGridViewTextBoxColumn"
        '
        'FloorDataGridViewTextBoxColumn
        '
        Me.FloorDataGridViewTextBoxColumn.DataPropertyName = "floor"
        Me.FloorDataGridViewTextBoxColumn.HeaderText = "floor"
        Me.FloorDataGridViewTextBoxColumn.Name = "FloorDataGridViewTextBoxColumn"
        '
        'NostdDataGridViewTextBoxColumn
        '
        Me.NostdDataGridViewTextBoxColumn.DataPropertyName = "no_std"
        Me.NostdDataGridViewTextBoxColumn.HeaderText = "no_std"
        Me.NostdDataGridViewTextBoxColumn.Name = "NostdDataGridViewTextBoxColumn"
        '
        'FeeDataGridViewTextBoxColumn
        '
        Me.FeeDataGridViewTextBoxColumn.DataPropertyName = "fee"
        Me.FeeDataGridViewTextBoxColumn.HeaderText = "fee"
        Me.FeeDataGridViewTextBoxColumn.Name = "FeeDataGridViewTextBoxColumn"
        '
        'BookhostelBindingSource
        '
        Me.BookhostelBindingSource.DataMember = "book_hostel"
        Me.BookhostelBindingSource.DataSource = Me.AdhostelDataSet5
        '
        'AdhostelDataSet5
        '
        Me.AdhostelDataSet5.DataSetName = "adhostelDataSet5"
        Me.AdhostelDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'button3
        '
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(608, 325)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(81, 28)
        Me.button3.TabIndex = 56
        Me.button3.Text = "Update"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(493, 328)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(81, 28)
        Me.button2.TabIndex = 55
        Me.button2.Text = "Search"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(376, 328)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(81, 28)
        Me.button1.TabIndex = 54
        Me.button1.Text = "Add"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox8
        '
        Me.textBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox8.Location = New System.Drawing.Point(483, 259)
        Me.textBox8.Name = "textBox8"
        Me.textBox8.Size = New System.Drawing.Size(149, 22)
        Me.textBox8.TabIndex = 53
        '
        'textBox7
        '
        Me.textBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox7.Location = New System.Drawing.Point(483, 197)
        Me.textBox7.Name = "textBox7"
        Me.textBox7.Size = New System.Drawing.Size(149, 22)
        Me.textBox7.TabIndex = 52
        '
        'textBox6
        '
        Me.textBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox6.Location = New System.Drawing.Point(483, 136)
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New System.Drawing.Size(149, 22)
        Me.textBox6.TabIndex = 51
        '
        'textBox5
        '
        Me.textBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox5.Location = New System.Drawing.Point(483, 72)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(149, 22)
        Me.textBox5.TabIndex = 50
        '
        'textBox4
        '
        Me.textBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox4.Location = New System.Drawing.Point(162, 328)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(149, 22)
        Me.textBox4.TabIndex = 49
        '
        'textBox3
        '
        Me.textBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox3.Location = New System.Drawing.Point(162, 259)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(149, 22)
        Me.textBox3.TabIndex = 48
        '
        'comboBox1
        '
        Me.comboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {"Male", "Female"})
        Me.comboBox1.Location = New System.Drawing.Point(162, 197)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(121, 24)
        Me.comboBox1.TabIndex = 47
        Me.comboBox1.Text = "--Select--"
        '
        'textBox2
        '
        Me.textBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(162, 136)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(149, 22)
        Me.textBox2.TabIndex = 46
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(422, 262)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(35, 16)
        Me.label10.TabIndex = 45
        Me.label10.Text = "Fee"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(356, 200)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(101, 16)
        Me.label9.TabIndex = 44
        Me.label9.Text = "No of Student"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(413, 139)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(44, 16)
        Me.label8.TabIndex = 43
        Me.label8.Text = "Floor"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(384, 75)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(73, 16)
        Me.label7.TabIndex = 42
        Me.label7.Text = "Room No"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(67, 331)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(66, 16)
        Me.label6.TabIndex = 41
        Me.label6.Text = "Address"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(78, 262)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(55, 16)
        Me.label5.TabIndex = 40
        Me.label5.Text = "Mobile"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(74, 200)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(59, 16)
        Me.label4.TabIndex = 39
        Me.label4.Text = "Gender"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(84, 139)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(49, 16)
        Me.label3.TabIndex = 38
        Me.label3.Text = "Name"
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(162, 72)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(149, 22)
        Me.textBox1.TabIndex = 37
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.IndianRed
        Me.label2.Location = New System.Drawing.Point(300, 13)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(118, 24)
        Me.label2.TabIndex = 36
        Me.label2.Text = "Book Room"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(51, 75)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(82, 16)
        Me.label1.TabIndex = 35
        Me.label1.Text = "Booking Id"
        '
        'Book_hostelTableAdapter
        '
        Me.Book_hostelTableAdapter.ClearBeforeFill = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.AdvancedHostelManagementSystemVB.My.Resources.Resources.kashipara
        Me.pictureBox1.Location = New System.Drawing.Point(617, 12)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 58
        Me.pictureBox1.TabStop = False
        '
        'BookHostel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 572)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox8)
        Me.Controls.Add(Me.textBox7)
        Me.Controls.Add(Me.textBox6)
        Me.Controls.Add(Me.textBox5)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "BookHostel"
        Me.Text = "BookHostel"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookhostelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdhostelDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents textBox8 As TextBox
    Private WithEvents textBox7 As TextBox
    Private WithEvents textBox6 As TextBox
    Private WithEvents textBox5 As TextBox
    Private WithEvents textBox4 As TextBox
    Private WithEvents textBox3 As TextBox
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents label10 As Label
    Private WithEvents label9 As Label
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents textBox1 As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Friend WithEvents AdhostelDataSet5 As adhostelDataSet5
    Friend WithEvents BookhostelBindingSource As BindingSource
    Friend WithEvents Book_hostelTableAdapter As adhostelDataSet5TableAdapters.book_hostelTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobileDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FloorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NostdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FeeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Private WithEvents pictureBox1 As PictureBox
End Class
