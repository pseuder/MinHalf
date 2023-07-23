Public Class Form2
    Dim clickhamer = False
    Dim ifclick = False '避免多次敲擊重複得分
    Dim mystr As String = CurDir()
    Dim picture(9) As PictureBox
    Dim random As Integer
    Dim myscore As Integer = 0
    Dim myspeed As Integer = 0
    Dim mytime As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        hamer.SizeMode = PictureBoxSizeMode.StretchImage



        ShowupTimer.Enabled = False
        PopTimer.Enabled = False

        hamer.Image = ImageList1.Images(0)
        picture(1) = p1 : picture(2) = p2 : picture(3) = p3 : picture(4) = p4 : picture(5) = p5
        picture(6) = p6 : picture(7) = p7 : picture(8) = p8 : picture(9) = p9

        For i As Integer = 1 To 9
            picture(i).Image = ImageList1.Images(2)
            picture(i).Visible = False
            picture(i).Enabled = False
        Next

        Button1.Text = "開始"
        score.Text = "0"
        time.Text = "0"

        'NumericUpDown
        speed.Maximum = 5
        speed.Minimum = 0

        mytime = 30

        ComboBox1.Text = "打地鼠"
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "翻牌遊戲" Then
            ComboBox1.Text = "翻牌遊戲"
            Me.Hide()
            Form1.Show()
        End If
    End Sub


    Private Sub hamer_Click(sender As Object, e As EventArgs) Handles hamer.Click
        Me.Cursor = New Cursor(mystr + "/hamer.cur")
        clickhamer = True
    End Sub

    Private Sub Form2_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, p1.MouseDown _
        , p2.MouseDown, p3.MouseDown, p4.MouseDown, p5.MouseDown, p6.MouseDown, p7.MouseDown, p8.MouseDown, p9.MouseDown

        If clickhamer Then
            Me.Cursor = New Cursor(mystr + "/hamerdown.cur")
        End If
    End Sub

    Private Sub Form2_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, p1.MouseUp,
        p2.MouseUp, p3.MouseUp, p4.MouseUp, p5.MouseUp, p6.MouseUp, p7.MouseUp, p8.MouseUp, p9.MouseUp
        If clickhamer Then
            Me.Cursor = New Cursor(mystr + "/hamer.cur")
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If clickhamer Then
            MsgBox("你有30秒")
            ShowupTimer.Enabled = True
            myspeed = speed.Value
            ShowupTimer.Interval = 1200 - (myspeed * 140)
            PopTimer.Interval = 1200 - (myspeed * 140)
            Timer1.Enabled = True
            Timer1.Interval = 1000
            Button1.Enabled = False
        End If
    End Sub

    Private Sub ShowupTimer_Tick(sender As Object, e As EventArgs) Handles ShowupTimer.Tick
        Dim temp As Integer = 0
        temp = random
        Randomize()
        random = Int((9 * Rnd()) + 1)
        While temp = random
            Randomize()
            random = Int((9 * Rnd()) + 1)
        End While
        picture(random).Visible = True
        picture(random).Enabled = True
        PopTimer.Enabled = True
        ifclick = True
    End Sub

    Private Sub PopTimer_Tick(sender As Object, e As EventArgs) Handles PopTimer.Tick
        picture(random).Visible = False
        picture(random).Enabled = False
        PopTimer.Enabled = False
    End Sub

    Private Sub p1_Click(sender As Object, e As EventArgs) Handles p1.Click, p2.Click,
        p3.Click, p4.Click, p5.Click, p6.Click, p7.Click, p8.Click, p9.Click
        If ifclick Then
            myscore += 1
            score.Text = Str(myscore)
        End If
        ifclick = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mytime -= 1
        time.Text = mytime
        If mytime = 0 Then

            PopTimer.Enabled = False
            Timer1.Enabled = False
            ShowupTimer.Enabled = False
            MsgBox("得分:" + Str(myscore))
        End If
    End Sub




End Class