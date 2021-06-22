Public Class Form1




    Private Sub startbtn_Click(sender As Object, e As EventArgs) Handles startbtn.Click
        Timer1.Start()
        ProgramStatus.Text = "Program Status : Running..."
        ProgramStatus.ForeColor = Color.Green
    End Sub

    Private Sub stopbtn_Click(sender As Object, e As EventArgs) Handles stopbtn.Click
        Timer1.Stop()
        ProgramStatus.Text = "Program Status : Stopped..."
        ProgramStatus.ForeColor = Color.Red
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim dr As New Drawing.Bitmap(1, 1)
        Dim sys As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(dr)
        sys.CopyFromScreen(New Drawing.Point(MousePosition.X, MousePosition.Y), New Drawing.Point(0, 0), dr.Size)
        Dim p As Drawing.Color = dr.GetPixel(0, 0)
        Panel1.BackColor = p
        redtextbox.Text = p.R
        greentextbox.Text = p.G
        bluetextbox.Text = p.B
        Dim rgb = p.ToArgb()
        Dim hex = rgb.ToString("X6")
        hextextbox.Text = hex

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = 83) Then
            Timer1.Start()
            ProgramStatus.Text = "Program Status : Running..."
            ProgramStatus.ForeColor = Color.Green
        ElseIf (e.KeyCode = 69) Then
            Timer1.Stop()
            ProgramStatus.Text = "Program Status : Stopped..."
            ProgramStatus.ForeColor = Color.Red
        End If
    End Sub
End Class
