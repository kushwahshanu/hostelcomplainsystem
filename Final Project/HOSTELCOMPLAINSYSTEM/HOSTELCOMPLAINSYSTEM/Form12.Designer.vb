<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALFLOORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALROOMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALWASHROOMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALWATERCOOLERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOSTELBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HOSTELCOMPLAINDataSet1 = New WindowsApplication1.HOSTELCOMPLAINDataSet1()
        Me.HOSTELTableAdapter = New WindowsApplication1.HOSTELCOMPLAINDataSet1TableAdapters.HOSTELTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HOSTELBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HOSTELCOMPLAINDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 97)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(956, 352)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HOSTEL INFORMATION"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HIDDataGridViewTextBoxColumn, Me.HNAMEDataGridViewTextBoxColumn, Me.TOTALFLOORDataGridViewTextBoxColumn, Me.TOTALROOMDataGridViewTextBoxColumn, Me.TOTALWASHROOMDataGridViewTextBoxColumn, Me.TOTALWATERCOOLERDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HOSTELBindingSource
        Me.DataGridView1.GridColor = System.Drawing.Color.Blue
        Me.DataGridView1.Location = New System.Drawing.Point(22, 26)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(926, 311)
        Me.DataGridView1.TabIndex = 0
        '
        'HIDDataGridViewTextBoxColumn
        '
        Me.HIDDataGridViewTextBoxColumn.DataPropertyName = "H_ID"
        Me.HIDDataGridViewTextBoxColumn.HeaderText = "H_ID"
        Me.HIDDataGridViewTextBoxColumn.Name = "HIDDataGridViewTextBoxColumn"
        Me.HIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.HIDDataGridViewTextBoxColumn.Width = 77
        '
        'HNAMEDataGridViewTextBoxColumn
        '
        Me.HNAMEDataGridViewTextBoxColumn.DataPropertyName = "H_NAME"
        Me.HNAMEDataGridViewTextBoxColumn.HeaderText = "H_NAME"
        Me.HNAMEDataGridViewTextBoxColumn.Name = "HNAMEDataGridViewTextBoxColumn"
        Me.HNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.HNAMEDataGridViewTextBoxColumn.Width = 105
        '
        'TOTALFLOORDataGridViewTextBoxColumn
        '
        Me.TOTALFLOORDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_FLOOR"
        Me.TOTALFLOORDataGridViewTextBoxColumn.HeaderText = "TOTAL_FLOOR"
        Me.TOTALFLOORDataGridViewTextBoxColumn.Name = "TOTALFLOORDataGridViewTextBoxColumn"
        Me.TOTALFLOORDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTALFLOORDataGridViewTextBoxColumn.Width = 149
        '
        'TOTALROOMDataGridViewTextBoxColumn
        '
        Me.TOTALROOMDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_ROOM"
        Me.TOTALROOMDataGridViewTextBoxColumn.HeaderText = "TOTAL_ROOM"
        Me.TOTALROOMDataGridViewTextBoxColumn.Name = "TOTALROOMDataGridViewTextBoxColumn"
        Me.TOTALROOMDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTALROOMDataGridViewTextBoxColumn.Width = 142
        '
        'TOTALWASHROOMDataGridViewTextBoxColumn
        '
        Me.TOTALWASHROOMDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_WASHROOM"
        Me.TOTALWASHROOMDataGridViewTextBoxColumn.HeaderText = "TOTAL_WASHROOM"
        Me.TOTALWASHROOMDataGridViewTextBoxColumn.Name = "TOTALWASHROOMDataGridViewTextBoxColumn"
        Me.TOTALWASHROOMDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTALWASHROOMDataGridViewTextBoxColumn.Width = 189
        '
        'TOTALWATERCOOLERDataGridViewTextBoxColumn
        '
        Me.TOTALWATERCOOLERDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_WATERCOOLER"
        Me.TOTALWATERCOOLERDataGridViewTextBoxColumn.HeaderText = "TOTAL_WATERCOOLER"
        Me.TOTALWATERCOOLERDataGridViewTextBoxColumn.Name = "TOTALWATERCOOLERDataGridViewTextBoxColumn"
        Me.TOTALWATERCOOLERDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTALWATERCOOLERDataGridViewTextBoxColumn.Width = 217
        '
        'HOSTELBindingSource
        '
        Me.HOSTELBindingSource.DataMember = "HOSTEL"
        Me.HOSTELBindingSource.DataSource = Me.HOSTELCOMPLAINDataSet1
        '
        'HOSTELCOMPLAINDataSet1
        '
        Me.HOSTELCOMPLAINDataSet1.DataSetName = "HOSTELCOMPLAINDataSet1"
        Me.HOSTELCOMPLAINDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HOSTELTableAdapter
        '
        Me.HOSTELTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(890, 467)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 36)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(155, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(719, 41)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "COMPLETE VIEW OF USER INFORMATION"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.members
        Me.PictureBox1.Location = New System.Drawing.Point(814, 456)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1020, 506)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form12"
        Me.Text = "HOSTEL_VIEW"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HOSTELBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HOSTELCOMPLAINDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HOSTELCOMPLAINDataSet1 As WindowsApplication1.HOSTELCOMPLAINDataSet1
    Friend WithEvents HOSTELBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HOSTELTableAdapter As WindowsApplication1.HOSTELCOMPLAINDataSet1TableAdapters.HOSTELTableAdapter
    Friend WithEvents HIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALFLOORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALROOMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALWASHROOMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALWATERCOOLERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
