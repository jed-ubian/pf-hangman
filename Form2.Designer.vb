<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        btnHint = New Button()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(87, 60)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(282, 289)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' btnHint
        ' 
        btnHint.BackColor = Color.IndianRed
        btnHint.ForeColor = SystemColors.Control
        btnHint.Location = New Point(254, 407)
        btnHint.Name = "btnHint"
        btnHint.Size = New Size(115, 27)
        btnHint.TabIndex = 6
        btnHint.Text = "Exit"
        btnHint.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(87, 407)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 27)
        Button1.TabIndex = 7
        Button1.Text = "Start"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(102, 378)
        Label1.Name = "Label1"
        Label1.Size = New Size(267, 15)
        Label1.TabIndex = 8
        Label1.Text = "Pneumonoultramicroscopicsilicovolcanoconiosis"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(197, 363)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 9
        Label2.Text = "Created By:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Kristen ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(130, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(219, 36)
        Label3.TabIndex = 10
        Label3.Text = "Hangman Game"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(472, 446)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(btnHint)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnHint As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
