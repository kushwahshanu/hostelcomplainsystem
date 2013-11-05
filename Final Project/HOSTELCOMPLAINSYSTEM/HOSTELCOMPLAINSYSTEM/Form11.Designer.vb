<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HostelnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FloornoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuestionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnswerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REGISTERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HOSTELCOMPLAINDataSet = New WindowsApplication1.HOSTELCOMPLAINDataSet()
        Me.REGISTERTableAdapter = New WindowsApplication1.HOSTELCOMPLAINDataSetTableAdapters.REGISTERTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGISTERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HOSTELCOMPLAINDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RnoDataGridViewTextBoxColumn, Me.SnameDataGridViewTextBoxColumn, Me.DeptDataGridViewTextBoxColumn, Me.HostelnameDataGridViewTextBoxColumn, Me.RoomnoDataGridViewTextBoxColumn, Me.FloornoDataGridViewTextBoxColumn, Me.PassDataGridViewTextBoxColumn, Me.QuestionDataGridViewTextBoxColumn, Me.AnswerDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.REGISTERBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.Color.Blue
        Me.DataGridView1.Location = New System.Drawing.Point(5, 25)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersWidth = 60
        Me.DataGridView1.Size = New System.Drawing.Size(881, 297)
        Me.DataGridView1.TabIndex = 0
        '
        'RnoDataGridViewTextBoxColumn
        '
        Me.RnoDataGridViewTextBoxColumn.DataPropertyName = "rno"
        Me.RnoDataGridViewTextBoxColumn.HeaderText = "rno"
        Me.RnoDataGridViewTextBoxColumn.Name = "RnoDataGridViewTextBoxColumn"
        Me.RnoDataGridViewTextBoxColumn.ReadOnly = True
        Me.RnoDataGridViewTextBoxColumn.Width = 61
        '
        'SnameDataGridViewTextBoxColumn
        '
        Me.SnameDataGridViewTextBoxColumn.DataPropertyName = "sname"
        Me.SnameDataGridViewTextBoxColumn.HeaderText = "sname"
        Me.SnameDataGridViewTextBoxColumn.Name = "SnameDataGridViewTextBoxColumn"
        Me.SnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SnameDataGridViewTextBoxColumn.Width = 83
        '
        'DeptDataGridViewTextBoxColumn
        '
        Me.DeptDataGridViewTextBoxColumn.DataPropertyName = "dept"
        Me.DeptDataGridViewTextBoxColumn.HeaderText = "dept"
        Me.DeptDataGridViewTextBoxColumn.Name = "DeptDataGridViewTextBoxColumn"
        Me.DeptDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeptDataGridViewTextBoxColumn.Width = 67
        '
        'HostelnameDataGridViewTextBoxColumn
        '
        Me.HostelnameDataGridViewTextBoxColumn.DataPropertyName = "hostel_name"
        Me.HostelnameDataGridViewTextBoxColumn.HeaderText = "hostel_name"
        Me.HostelnameDataGridViewTextBoxColumn.Name = "HostelnameDataGridViewTextBoxColumn"
        Me.HostelnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.HostelnameDataGridViewTextBoxColumn.Width = 137
        '
        'RoomnoDataGridViewTextBoxColumn
        '
        Me.RoomnoDataGridViewTextBoxColumn.DataPropertyName = "room_no"
        Me.RoomnoDataGridViewTextBoxColumn.HeaderText = "room_no"
        Me.RoomnoDataGridViewTextBoxColumn.Name = "RoomnoDataGridViewTextBoxColumn"
        Me.RoomnoDataGridViewTextBoxColumn.ReadOnly = True
        Me.RoomnoDataGridViewTextBoxColumn.Width = 107
        '
        'FloornoDataGridViewTextBoxColumn
        '
        Me.FloornoDataGridViewTextBoxColumn.DataPropertyName = "floor_no"
        Me.FloornoDataGridViewTextBoxColumn.HeaderText = "floor_no"
        Me.FloornoDataGridViewTextBoxColumn.Name = "FloornoDataGridViewTextBoxColumn"
        Me.FloornoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FloornoDataGridViewTextBoxColumn.Width = 106
        '
        'PassDataGridViewTextBoxColumn
        '
        Me.PassDataGridViewTextBoxColumn.DataPropertyName = "pass"
        Me.PassDataGridViewTextBoxColumn.HeaderText = "pass"
        Me.PassDataGridViewTextBoxColumn.Name = "PassDataGridViewTextBoxColumn"
        Me.PassDataGridViewTextBoxColumn.ReadOnly = True
        Me.PassDataGridViewTextBoxColumn.Width = 67
        '
        'QuestionDataGridViewTextBoxColumn
        '
        Me.QuestionDataGridViewTextBoxColumn.DataPropertyName = "question"
        Me.QuestionDataGridViewTextBoxColumn.HeaderText = "question"
        Me.QuestionDataGridViewTextBoxColumn.Name = "QuestionDataGridViewTextBoxColumn"
        Me.QuestionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnswerDataGridViewTextBoxColumn
        '
        Me.AnswerDataGridViewTextBoxColumn.DataPropertyName = "answer"
        Me.AnswerDataGridViewTextBoxColumn.HeaderText = "answer"
        Me.AnswerDataGridViewTextBoxColumn.Name = "AnswerDataGridViewTextBoxColumn"
        Me.AnswerDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnswerDataGridViewTextBoxColumn.Width = 88
        '
        'REGISTERBindingSource
        '
        Me.REGISTERBindingSource.DataMember = "REGISTER"
        Me.REGISTERBindingSource.DataSource = Me.HOSTELCOMPLAINDataSet
        '
        'HOSTELCOMPLAINDataSet
        '
        Me.HOSTELCOMPLAINDataSet.DataSetName = "HOSTELCOMPLAINDataSet"
        Me.HOSTELCOMPLAINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'REGISTERTableAdapter
        '
        Me.REGISTERTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 84)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(891, 326)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "VIEW INFORMATION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(174, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(658, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "COMPLETE DATA VIEW OF HOSTEL INFORMATION"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(765, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.lock
        Me.PictureBox1.Location = New System.Drawing.Point(675, 427)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(927, 495)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form11"
        Me.Text = "USER_INFORMATION"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGISTERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HOSTELCOMPLAINDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HOSTELCOMPLAINDataSet As WindowsApplication1.HOSTELCOMPLAINDataSet
    Friend WithEvents REGISTERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REGISTERTableAdapter As WindowsApplication1.HOSTELCOMPLAINDataSetTableAdapters.REGISTERTableAdapter
    Friend WithEvents RnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeptDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HostelnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FloornoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuestionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnswerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
