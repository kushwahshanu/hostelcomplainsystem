<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddHostelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterComplainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElectricalcomplainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WashroomsRelatedComplainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LatedComplainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComplainStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ViewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHostelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RegisterComplainToolStripMenuItem, Me.EXITToolStripMenuItem, Me.ViewStatusToolStripMenuItem, Me.ViewInformationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddHostelToolStripMenuItem, Me.AddRoomToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(43, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AddHostelToolStripMenuItem
        '
        Me.AddHostelToolStripMenuItem.Name = "AddHostelToolStripMenuItem"
        Me.AddHostelToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.AddHostelToolStripMenuItem.Text = "Add_Hostel"
        '
        'AddRoomToolStripMenuItem
        '
        Me.AddRoomToolStripMenuItem.Name = "AddRoomToolStripMenuItem"
        Me.AddRoomToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.AddRoomToolStripMenuItem.Text = "Add_Room"
        '
        'RegisterComplainToolStripMenuItem
        '
        Me.RegisterComplainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ElectricalcomplainToolStripMenuItem, Me.WashroomsRelatedComplainToolStripMenuItem, Me.LatedComplainToolStripMenuItem})
        Me.RegisterComplainToolStripMenuItem.Name = "RegisterComplainToolStripMenuItem"
        Me.RegisterComplainToolStripMenuItem.Size = New System.Drawing.Size(132, 23)
        Me.RegisterComplainToolStripMenuItem.Text = "Register Complain"
        '
        'ElectricalcomplainToolStripMenuItem
        '
        Me.ElectricalcomplainToolStripMenuItem.Name = "ElectricalcomplainToolStripMenuItem"
        Me.ElectricalcomplainToolStripMenuItem.Size = New System.Drawing.Size(266, 24)
        Me.ElectricalcomplainToolStripMenuItem.Text = "Electrical_Complain"
        '
        'WashroomsRelatedComplainToolStripMenuItem
        '
        Me.WashroomsRelatedComplainToolStripMenuItem.Name = "WashroomsRelatedComplainToolStripMenuItem"
        Me.WashroomsRelatedComplainToolStripMenuItem.Size = New System.Drawing.Size(266, 24)
        Me.WashroomsRelatedComplainToolStripMenuItem.Text = "Washrooms_Related Complain"
        '
        'LatedComplainToolStripMenuItem
        '
        Me.LatedComplainToolStripMenuItem.Name = "LatedComplainToolStripMenuItem"
        Me.LatedComplainToolStripMenuItem.Size = New System.Drawing.Size(266, 24)
        Me.LatedComplainToolStripMenuItem.Text = "Cleanliness_Related_Complain"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLToolStripMenuItem})
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(44, 23)
        Me.EXITToolStripMenuItem.Text = "Exit"
        '
        'CLToolStripMenuItem
        '
        Me.CLToolStripMenuItem.Name = "CLToolStripMenuItem"
        Me.CLToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.CLToolStripMenuItem.Text = "Close_Application"
        '
        'ViewStatusToolStripMenuItem
        '
        Me.ViewStatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComplainStatusToolStripMenuItem})
        Me.ViewStatusToolStripMenuItem.Name = "ViewStatusToolStripMenuItem"
        Me.ViewStatusToolStripMenuItem.Size = New System.Drawing.Size(97, 23)
        Me.ViewStatusToolStripMenuItem.Text = "View_Status"
        '
        'ComplainStatusToolStripMenuItem
        '
        Me.ComplainStatusToolStripMenuItem.Name = "ComplainStatusToolStripMenuItem"
        Me.ComplainStatusToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.ComplainStatusToolStripMenuItem.Text = "Complain_Status"
        '
        'ViewInformationToolStripMenuItem
        '
        Me.ViewInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewUserToolStripMenuItem, Me.ViewHostelToolStripMenuItem})
        Me.ViewInformationToolStripMenuItem.Name = "ViewInformationToolStripMenuItem"
        Me.ViewInformationToolStripMenuItem.Size = New System.Drawing.Size(129, 23)
        Me.ViewInformationToolStripMenuItem.Text = "View_Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightCoral
        Me.Label1.Location = New System.Drawing.Point(395, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(544, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "HOSTEL COMPLAIN SYSTEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.OldLace
        Me.Label2.Location = New System.Drawing.Point(437, 674)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SHANU KUSHWAH"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.index1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(146, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1298, 130)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NATIONAL INSTITUTE OF TECHNOLOGY " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                 TIRUCHIRAPPALLI"
        '
        'ViewUserToolStripMenuItem
        '
        Me.ViewUserToolStripMenuItem.Name = "ViewUserToolStripMenuItem"
        Me.ViewUserToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ViewUserToolStripMenuItem.Text = "View_User"
        '
        'ViewHostelToolStripMenuItem
        '
        Me.ViewHostelToolStripMenuItem.Name = "ViewHostelToolStripMenuItem"
        Me.ViewHostelToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.ViewHostelToolStripMenuItem.Text = "View_Hostel"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.H1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form5"
        Me.Text = "HOSTEL COMPLAIN SYTEM"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddHostelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddRoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterComplainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ElectricalcomplainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WashroomsRelatedComplainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LatedComplainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ViewStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplainStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHostelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
