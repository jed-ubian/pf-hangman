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
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(247, 239)
        Button1.Name = "Button1"
        Button1.Size = New Size(0, 0)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnHint
        ' 
        btnHint.BackColor = SystemColors.ActiveCaption
        btnHint.Location = New Point(161, 276)
        btnHint.Name = "btnHint"
        btnHint.Size = New Size(86, 27)
        btnHint.TabIndex = 1
        btnHint.Text = "Hint"
        btnHint.UseVisualStyleBackColor = False
        ' 
        ' lbl_answer
        ' 
        lbl_answer.AutoSize = True
        lbl_answer.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_answer.Location = New Point(208, 144)
        lbl_answer.Name = "lbl_answer"
        lbl_answer.Size = New Size(116, 37)
        lbl_answer.TabIndex = 2
        lbl_answer.Text = "---------"
        ' 
        ' lblLives
        ' 
        lblLives.AutoSize = True
        lblLives.Location = New Point(53, 23)
        lblLives.Name = "lblLives"
        lblLives.Size = New Size(36, 15)
        lblLives.TabIndex = 3
        lblLives.Text = "Lives:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 33)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.LiveSetting = Automation.AutomationLiveSetting.Polite
        lblDescription.Location = New Point(233, 187)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(62, 15)
        lblDescription.TabIndex = 5
        lblDescription.Text = "Definition:"
        ' 
        ' lbl_description
        ' 
        lbl_description.AutoSize = True
        lbl_description.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_description.Location = New Point(240, 208)
        lbl_description.Name = "lbl_description"
        lbl_description.Size = New Size(45, 15)
        lbl_description.TabIndex = 6
        lbl_description.Text = "sample"
        lbl_description.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnGiveUp
        ' 
        btnGiveUp.BackColor = Color.IndianRed
        btnGiveUp.ForeColor = SystemColors.ControlLightLight
        btnGiveUp.Location = New Point(262, 276)
        btnGiveUp.Name = "btnGiveUp"
        btnGiveUp.Size = New Size(86, 27)
        btnGiveUp.TabIndex = 7
        btnGiveUp.Text = "Give Up"
        btnGiveUp.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(12, 51)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(35, 33)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 15)
        Label1.TabIndex = 9
        Label1.Text = "Hints:"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(415, 12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(35, 33)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(456, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 11
        Label2.Text = "Score:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(90, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(13, 15)
        Label3.TabIndex = 12
        Label3.Text = "6"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(90, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(13, 15)
        Label4.TabIndex = 13
        Label4.Text = "3"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(491, 24)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 15)
        Label5.TabIndex = 14
        Label5.Text = "0"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(542, 338)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox3)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(btnGiveUp)
        Controls.Add(lbl_description)
        Controls.Add(lblDescription)
        Controls.Add(PictureBox1)
        Controls.Add(lblLives)
        Controls.Add(lbl_answer)
        Controls.Add(btnHint)
        Controls.Add(Button1)
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
    Friend WithEvents btnGiveUp As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
