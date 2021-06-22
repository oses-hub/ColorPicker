<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.startbtn = New System.Windows.Forms.Button()
        Me.stopbtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bluetextbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.greentextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.redtextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.hextextbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgramStatus = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'startbtn
        '
        Me.startbtn.Location = New System.Drawing.Point(13, 13)
        Me.startbtn.Name = "startbtn"
        Me.startbtn.Size = New System.Drawing.Size(131, 23)
        Me.startbtn.TabIndex = 0
        Me.startbtn.Text = "Pick (s)"
        Me.startbtn.UseVisualStyleBackColor = True
        '
        'stopbtn
        '
        Me.stopbtn.Location = New System.Drawing.Point(13, 42)
        Me.stopbtn.Name = "stopbtn"
        Me.stopbtn.Size = New System.Drawing.Size(131, 23)
        Me.stopbtn.TabIndex = 1
        Me.stopbtn.Text = "Stop (e)"
        Me.stopbtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(150, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(88, 52)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bluetextbox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.greentextbox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.redtextbox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 109)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RGB Color"
        '
        'bluetextbox
        '
        Me.bluetextbox.Location = New System.Drawing.Point(137, 78)
        Me.bluetextbox.Name = "bluetextbox"
        Me.bluetextbox.ReadOnly = True
        Me.bluetextbox.Size = New System.Drawing.Size(82, 20)
        Me.bluetextbox.TabIndex = 5
        Me.bluetextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "B:"
        '
        'greentextbox
        '
        Me.greentextbox.Location = New System.Drawing.Point(137, 52)
        Me.greentextbox.Name = "greentextbox"
        Me.greentextbox.ReadOnly = True
        Me.greentextbox.Size = New System.Drawing.Size(82, 20)
        Me.greentextbox.TabIndex = 3
        Me.greentextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "G:"
        '
        'redtextbox
        '
        Me.redtextbox.Location = New System.Drawing.Point(137, 26)
        Me.redtextbox.Name = "redtextbox"
        Me.redtextbox.ReadOnly = True
        Me.redtextbox.Size = New System.Drawing.Size(82, 20)
        Me.redtextbox.TabIndex = 1
        Me.redtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "R:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.hextextbox)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 50)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hex"
        '
        'hextextbox
        '
        Me.hextextbox.Location = New System.Drawing.Point(94, 19)
        Me.hextextbox.Name = "hextextbox"
        Me.hextextbox.ReadOnly = True
        Me.hextextbox.Size = New System.Drawing.Size(100, 20)
        Me.hextextbox.TabIndex = 5
        Me.hextextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hex Code:"
        '
        'ProgramStatus
        '
        Me.ProgramStatus.AutoSize = True
        Me.ProgramStatus.Location = New System.Drawing.Point(20, 251)
        Me.ProgramStatus.Name = "ProgramStatus"
        Me.ProgramStatus.Size = New System.Drawing.Size(137, 13)
        Me.ProgramStatus.TabIndex = 5
        Me.ProgramStatus.Text = "Program Status : Stopped..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 274)
        Me.Controls.Add(Me.ProgramStatus)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.stopbtn)
        Me.Controls.Add(Me.startbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "ColorPicker v1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents startbtn As Button
    Friend WithEvents stopbtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bluetextbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents greentextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents redtextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents hextextbox As TextBox
    Friend WithEvents ProgramStatus As Label
End Class
