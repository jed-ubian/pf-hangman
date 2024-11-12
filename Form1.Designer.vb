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
        Label1 = New Label()
        lblLives = New Label()
        PictureBox1 = New PictureBox()
        lblDescription = New Label()
        description = New Label()
        btnGiveUp = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        btnHint.Location = New Point(271, 277)
        btnHint.Name = "btnHint"
        btnHint.Size = New Size(86, 27)
        btnHint.TabIndex = 1
        btnHint.Text = "Hint"
        btnHint.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(208, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 37)
        Label1.TabIndex = 2
        Label1.Text = "---------"
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
        ' description
        ' 
        description.AutoSize = True
        description.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        description.Location = New Point(240, 208)
        description.Name = "description"
        description.Size = New Size(45, 15)
        description.TabIndex = 6
        description.Text = "sample"
        ' 
        ' btnGiveUp
        ' 
        btnGiveUp.BackColor = Color.IndianRed
        btnGiveUp.ForeColor = SystemColors.ControlLightLight
        btnGiveUp.Location = New Point(170, 277)
        btnGiveUp.Name = "btnGiveUp"
        btnGiveUp.Size = New Size(86, 27)
        btnGiveUp.TabIndex = 7
        btnGiveUp.Text = "Give Up"
        btnGiveUp.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(542, 338)
        Controls.Add(btnGiveUp)
        Controls.Add(description)
        Controls.Add(lblDescription)
        Controls.Add(PictureBox1)
        Controls.Add(lblLives)
        Controls.Add(Label1)
        Controls.Add(btnHint)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnHint As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLives As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents description As Label
    Friend WithEvents btnGiveUp As Button

End Class
