<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.score = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ShowupTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PopTimer = New System.Windows.Forms.Timer(Me.components)
        Me.speed = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.p9 = New System.Windows.Forms.PictureBox()
        Me.p8 = New System.Windows.Forms.PictureBox()
        Me.p7 = New System.Windows.Forms.PictureBox()
        Me.p6 = New System.Windows.Forms.PictureBox()
        Me.hamer = New System.Windows.Forms.PictureBox()
        Me.p5 = New System.Windows.Forms.PictureBox()
        Me.p4 = New System.Windows.Forms.PictureBox()
        Me.p3 = New System.Windows.Forms.PictureBox()
        Me.p1 = New System.Windows.Forms.PictureBox()
        Me.p2 = New System.Windows.Forms.PictureBox()
        CType(Me.speed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hamer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"翻牌遊戲", "打地鼠"})
        Me.ComboBox1.Location = New System.Drawing.Point(107, 74)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 29)
        Me.ComboBox1.TabIndex = 21
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "hamer.png")
        Me.ImageList1.Images.SetKeyName(1, "hamerdown.png")
        Me.ImageList1.Images.SetKeyName(2, "download-removebg-preview.png")
        '
        'score
        '
        Me.score.AutoSize = True
        Me.score.BackColor = System.Drawing.SystemColors.Control
        Me.score.Font = New System.Drawing.Font("新細明體", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.score.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.score.Location = New System.Drawing.Point(1058, 58)
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(43, 48)
        Me.score.TabIndex = 23
        Me.score.Text = "0"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Font = New System.Drawing.Font("新細明體", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(117, 456)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 68)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ShowupTimer
        '
        '
        'PopTimer
        '
        '
        'speed
        '
        Me.speed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.speed.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.speed.Location = New System.Drawing.Point(217, 215)
        Me.speed.Name = "speed"
        Me.speed.Size = New System.Drawing.Size(121, 36)
        Me.speed.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 32)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "調整速度"
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.BackColor = System.Drawing.SystemColors.Info
        Me.ScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ScoreLabel.Font = New System.Drawing.Font("新細明體", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ScoreLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.ScoreLabel.Location = New System.Drawing.Point(927, 56)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(125, 50)
        Me.ScoreLabel.TabIndex = 34
        Me.ScoreLabel.Text = "Score"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.BackColor = System.Drawing.SystemColors.Info
        Me.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TimeLabel.Font = New System.Drawing.Font("新細明體", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TimeLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TimeLabel.Location = New System.Drawing.Point(927, 178)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(118, 50)
        Me.TimeLabel.TabIndex = 35
        Me.TimeLabel.Text = "Time"
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.Font = New System.Drawing.Font("新細明體", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.time.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.time.Location = New System.Drawing.Point(1058, 178)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(43, 48)
        Me.time.TabIndex = 36
        Me.time.Text = "0"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 326)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 32)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "獲得槌子"
        '
        'p9
        '
        Me.p9.Location = New System.Drawing.Point(725, 398)
        Me.p9.Name = "p9"
        Me.p9.Size = New System.Drawing.Size(95, 91)
        Me.p9.TabIndex = 31
        Me.p9.TabStop = False
        '
        'p8
        '
        Me.p8.Location = New System.Drawing.Point(561, 398)
        Me.p8.Name = "p8"
        Me.p8.Size = New System.Drawing.Size(95, 91)
        Me.p8.TabIndex = 30
        Me.p8.TabStop = False
        '
        'p7
        '
        Me.p7.Location = New System.Drawing.Point(394, 398)
        Me.p7.Name = "p7"
        Me.p7.Size = New System.Drawing.Size(95, 91)
        Me.p7.TabIndex = 29
        Me.p7.TabStop = False
        '
        'p6
        '
        Me.p6.Location = New System.Drawing.Point(725, 258)
        Me.p6.Name = "p6"
        Me.p6.Size = New System.Drawing.Size(95, 91)
        Me.p6.TabIndex = 28
        Me.p6.TabStop = False
        '
        'hamer
        '
        Me.hamer.Location = New System.Drawing.Point(238, 308)
        Me.hamer.Name = "hamer"
        Me.hamer.Size = New System.Drawing.Size(50, 50)
        Me.hamer.TabIndex = 22
        Me.hamer.TabStop = False
        '
        'p5
        '
        Me.p5.Location = New System.Drawing.Point(561, 258)
        Me.p5.Name = "p5"
        Me.p5.Size = New System.Drawing.Size(95, 91)
        Me.p5.TabIndex = 27
        Me.p5.TabStop = False
        '
        'p4
        '
        Me.p4.Location = New System.Drawing.Point(394, 258)
        Me.p4.Name = "p4"
        Me.p4.Size = New System.Drawing.Size(95, 91)
        Me.p4.TabIndex = 25
        Me.p4.TabStop = False
        '
        'p3
        '
        Me.p3.Location = New System.Drawing.Point(725, 129)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(95, 91)
        Me.p3.TabIndex = 26
        Me.p3.TabStop = False
        '
        'p1
        '
        Me.p1.Image = Global._Games.My.Resources.Resources.download_removebg_preview
        Me.p1.Location = New System.Drawing.Point(394, 129)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(95, 91)
        Me.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p1.TabIndex = 23
        Me.p1.TabStop = False
        '
        'p2
        '
        Me.p2.Location = New System.Drawing.Point(561, 129)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(95, 91)
        Me.p2.TabIndex = 24
        Me.p2.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 636)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.speed)
        Me.Controls.Add(Me.p9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.p8)
        Me.Controls.Add(Me.p7)
        Me.Controls.Add(Me.score)
        Me.Controls.Add(Me.p6)
        Me.Controls.Add(Me.hamer)
        Me.Controls.Add(Me.p5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.p4)
        Me.Controls.Add(Me.p3)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.p2)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.speed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hamer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents hamer As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents score As Label
    Friend WithEvents p1 As PictureBox
    Friend WithEvents p9 As PictureBox
    Friend WithEvents p8 As PictureBox
    Friend WithEvents p7 As PictureBox
    Friend WithEvents p6 As PictureBox
    Friend WithEvents p5 As PictureBox
    Friend WithEvents p3 As PictureBox
    Friend WithEvents p4 As PictureBox
    Friend WithEvents p2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ShowupTimer As Timer
    Friend WithEvents PopTimer As Timer
    Friend WithEvents speed As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents time As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
