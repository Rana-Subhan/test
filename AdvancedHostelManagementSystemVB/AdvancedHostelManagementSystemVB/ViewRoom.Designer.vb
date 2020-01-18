<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewRoom
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
        Me.RoomnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FloorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NostdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdhostelDataSet1 = New AdvancedHostelManagementSystemVB.adhostelDataSet1()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.RoomTableAdapter = New AdvancedHostelManagementSystemVB.adhostelDataSet1TableAdapters.roomTableAdapter()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdhostelDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridView1
        '
        Me.dataGridView1.AutoGenerateColumns = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.RoomnoDataGridViewTextBoxColumn, Me.FloorDataGridViewTextBoxColumn, Me.NostdDataGridViewTextBoxColumn, Me.FeeDataGridViewTextBoxColumn})
        Me.dataGridView1.DataSource = Me.RoomBindingSource
        Me.dataGridView1.Location = New System.Drawing.Point(18, 216)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(538, 184)
        Me.dataGridView1.TabIndex = 44
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
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
        'RoomBindingSource
        '
        Me.RoomBindingSource.DataMember = "room"
        Me.RoomBindingSource.DataSource = Me.AdhostelDataSet1
        '
        'AdhostelDataSet1
        '
        Me.AdhostelDataSet1.DataSetName = "adhostelDataSet1"
        Me.AdhostelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(241, 169)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(81, 31)
        Me.button1.TabIndex = 43
        Me.button1.Text = "Search"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(260, 111)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(149, 22)
        Me.textBox1.TabIndex = 42
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.IndianRed
        Me.label2.Location = New System.Drawing.Point(217, 50)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(117, 24)
        Me.label2.TabIndex = 41
        Me.label2.Text = "View Room"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(163, 114)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(73, 16)
        Me.label1.TabIndex = 40
        Me.label1.Text = "Room No"
        '
        'RoomTableAdapter
        '
        Me.RoomTableAdapter.ClearBeforeFill = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.AdvancedHostelManagementSystemVB.My.Resources.Resources.kashipara
        Me.pictureBox1.Location = New System.Drawing.Point(463, 12)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 50
        Me.pictureBox1.TabStop = False
        '
        'ViewRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 418)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "ViewRoom"
        Me.Text = "ViewRoom"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdhostelDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents button1 As Button
    Private WithEvents textBox1 As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Friend WithEvents AdhostelDataSet1 As adhostelDataSet1
    Friend WithEvents RoomBindingSource As BindingSource
    Friend WithEvents RoomTableAdapter As adhostelDataSet1TableAdapters.roomTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FloorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NostdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FeeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Private WithEvents pictureBox1 As PictureBox
End Class
