<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        btnHint = New Button()
        lbl_answer = New Label()
        lblLives = New Label()
        PictureBox1 = New PictureBox()
        lblDescription = New Label()
        lbl_description = New Label()
        btnNext = New Button()
        PictureBox2 = New PictureBox()
        lblHints = New Label()
        PictureBox3 = New PictureBox()
        lblScore = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(353, 398)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(0, 0)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnHint
        ' 
        btnHint.BackColor = SystemColors.ActiveCaption
        btnHint.Location = New Point(240, 456)
        btnHint.Margin = New Padding(4, 5, 4, 5)
        btnHint.Name = "btnHint"
        btnHint.Size = New Size(123, 45)
        btnHint.TabIndex = 1
        btnHint.Text = "Hint"
        btnHint.UseVisualStyleBackColor = False
        ' 
        ' lbl_answer
        ' 
        lbl_answer.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_answer.Location = New Point(0, 240)
        lbl_answer.Margin = New Padding(4, 0, 4, 0)
        lbl_answer.Name = "lbl_answer"
        lbl_answer.Size = New Size(776, 55)
        lbl_answer.TabIndex = 2
        lbl_answer.Text = "---------"
        lbl_answer.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLives
        ' 
        lblLives.AutoSize = True
        lblLives.Location = New Point(76, 38)
        lblLives.Margin = New Padding(4, 0, 4, 0)
        lblLives.Name = "lblLives"
        lblLives.Size = New Size(54, 25)
        lblLives.TabIndex = 3
        lblLives.Text = "Lives:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(17, 20)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 55)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.LiveSetting = Automation.AutomationLiveSetting.Polite
        lblDescription.Location = New Point(333, 312)
        lblDescription.Margin = New Padding(4, 0, 4, 0)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(93, 25)
        lblDescription.TabIndex = 5
        lblDescription.Text = "Definition:"
        ' 
        ' lbl_description
        ' 
        lbl_description.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_description.Location = New Point(0, 347)
        lbl_description.Margin = New Padding(4, 0, 4, 0)
        lbl_description.Name = "lbl_description"
        lbl_description.Size = New Size(776, 25)
        lbl_description.TabIndex = 6
        lbl_description.Text = "sample"
        lbl_description.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.DarkCyan
        btnNext.Enabled = False
        btnNext.ForeColor = SystemColors.ControlLightLight
        btnNext.Location = New Point(384, 456)
        btnNext.Margin = New Padding(4, 5, 4, 5)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(123, 45)
        btnNext.TabIndex = 7
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(17, 85)
        PictureBox2.Margin = New Padding(4, 5, 4, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(50, 55)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' lblHints
        ' 
        lblHints.AutoSize = True
        lblHints.Location = New Point(76, 100)
        lblHints.Margin = New Padding(4, 0, 4, 0)
        lblHints.Name = "lblHints"
        lblHints.Size = New Size(57, 25)
        lblHints.TabIndex = 9
        lblHints.Text = "Hints:"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(593, 20)
        PictureBox3.Margin = New Padding(4, 5, 4, 5)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(50, 55)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.Location = New Point(651, 38)
        lblScore.Margin = New Padding(4, 0, 4, 0)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(60, 25)
        lblScore.TabIndex = 11
        lblScore.Text = "Score:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(774, 563)
        Controls.Add(lblScore)
        Controls.Add(PictureBox3)
        Controls.Add(lblHints)
        Controls.Add(PictureBox2)
        Controls.Add(btnNext)
        Controls.Add(lbl_description)
        Controls.Add(lblDescription)
        Controls.Add(PictureBox1)
        Controls.Add(lblLives)
        Controls.Add(lbl_answer)
        Controls.Add(btnHint)
        Controls.Add(Button1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnHint As Button
    Friend WithEvents lbl_answer As Label
    Friend WithEvents lblLives As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents lbl_description As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblHints As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblScore As Label

End Class
