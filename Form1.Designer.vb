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
        btnGiveUp = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        btnHint.Location = New Point(387, 462)
        btnHint.Margin = New Padding(4, 5, 4, 5)
        btnHint.Name = "btnHint"
        btnHint.Size = New Size(123, 45)
        btnHint.TabIndex = 1
        btnHint.Text = "Hint"
        btnHint.UseVisualStyleBackColor = False
        ' 
        ' lbl_answer
        ' 
        lbl_answer.AutoSize = True
        lbl_answer.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_answer.Location = New Point(297, 240)
        lbl_answer.Margin = New Padding(4, 0, 4, 0)
        lbl_answer.Name = "lbl_answer"
        lbl_answer.Size = New Size(168, 55)
        lbl_answer.TabIndex = 2
        lbl_answer.Text = "---------"
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
        lbl_description.AutoSize = True
        lbl_description.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_description.Location = New Point(343, 347)
        lbl_description.Margin = New Padding(4, 0, 4, 0)
        lbl_description.Name = "lbl_description"
        lbl_description.Size = New Size(69, 25)
        lbl_description.TabIndex = 6
        lbl_description.Text = "sample"
        ' 
        ' btnGiveUp
        ' 
        btnGiveUp.BackColor = Color.IndianRed
        btnGiveUp.ForeColor = SystemColors.ControlLightLight
        btnGiveUp.Location = New Point(243, 462)
        btnGiveUp.Margin = New Padding(4, 5, 4, 5)
        btnGiveUp.Name = "btnGiveUp"
        btnGiveUp.Size = New Size(123, 45)
        btnGiveUp.TabIndex = 7
        btnGiveUp.Text = "Give Up"
        btnGiveUp.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(774, 563)
        Controls.Add(btnGiveUp)
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
    Friend WithEvents btnGiveUp As Button

End Class
