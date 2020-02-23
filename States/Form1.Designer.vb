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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NewYorkButton = New System.Windows.Forms.RadioButton()
        Me.MississippiButton = New System.Windows.Forms.RadioButton()
        Me.IndianaButton = New System.Windows.Forms.RadioButton()
        Me.CaliButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MottoButton = New System.Windows.Forms.RadioButton()
        Me.NicknameButton = New System.Windows.Forms.RadioButton()
        Me.FlowerButton = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.InfoBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NewYorkButton)
        Me.GroupBox1.Controls.Add(Me.MississippiButton)
        Me.GroupBox1.Controls.Add(Me.IndianaButton)
        Me.GroupBox1.Controls.Add(Me.CaliButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 155)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "States"
        '
        'NewYorkButton
        '
        Me.NewYorkButton.AutoSize = True
        Me.NewYorkButton.Location = New System.Drawing.Point(6, 115)
        Me.NewYorkButton.Name = "NewYorkButton"
        Me.NewYorkButton.Size = New System.Drawing.Size(102, 24)
        Me.NewYorkButton.TabIndex = 3
        Me.NewYorkButton.TabStop = True
        Me.NewYorkButton.Text = "New York"
        Me.NewYorkButton.UseVisualStyleBackColor = True
        '
        'MississippiButton
        '
        Me.MississippiButton.AutoSize = True
        Me.MississippiButton.Location = New System.Drawing.Point(6, 85)
        Me.MississippiButton.Name = "MississippiButton"
        Me.MississippiButton.Size = New System.Drawing.Size(109, 24)
        Me.MississippiButton.TabIndex = 2
        Me.MississippiButton.TabStop = True
        Me.MississippiButton.Text = "Mississippi"
        Me.MississippiButton.UseVisualStyleBackColor = True
        '
        'IndianaButton
        '
        Me.IndianaButton.AutoSize = True
        Me.IndianaButton.Location = New System.Drawing.Point(6, 55)
        Me.IndianaButton.Name = "IndianaButton"
        Me.IndianaButton.Size = New System.Drawing.Size(87, 24)
        Me.IndianaButton.TabIndex = 1
        Me.IndianaButton.TabStop = True
        Me.IndianaButton.Text = "Indiana"
        Me.IndianaButton.UseVisualStyleBackColor = True
        '
        'CaliButton
        '
        Me.CaliButton.AutoSize = True
        Me.CaliButton.Location = New System.Drawing.Point(6, 25)
        Me.CaliButton.Name = "CaliButton"
        Me.CaliButton.Size = New System.Drawing.Size(100, 24)
        Me.CaliButton.TabIndex = 0
        Me.CaliButton.TabStop = True
        Me.CaliButton.Text = "California"
        Me.CaliButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MottoButton)
        Me.GroupBox2.Controls.Add(Me.NicknameButton)
        Me.GroupBox2.Controls.Add(Me.FlowerButton)
        Me.GroupBox2.Location = New System.Drawing.Point(268, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 155)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Category"
        '
        'MottoButton
        '
        Me.MottoButton.AutoSize = True
        Me.MottoButton.Location = New System.Drawing.Point(6, 115)
        Me.MottoButton.Name = "MottoButton"
        Me.MottoButton.Size = New System.Drawing.Size(75, 24)
        Me.MottoButton.TabIndex = 2
        Me.MottoButton.TabStop = True
        Me.MottoButton.Text = "Motto"
        Me.MottoButton.UseVisualStyleBackColor = True
        '
        'NicknameButton
        '
        Me.NicknameButton.AutoSize = True
        Me.NicknameButton.Location = New System.Drawing.Point(6, 70)
        Me.NicknameButton.Name = "NicknameButton"
        Me.NicknameButton.Size = New System.Drawing.Size(104, 24)
        Me.NicknameButton.TabIndex = 1
        Me.NicknameButton.TabStop = True
        Me.NicknameButton.Text = "Nickname"
        Me.NicknameButton.UseVisualStyleBackColor = True
        '
        'FlowerButton
        '
        Me.FlowerButton.AutoSize = True
        Me.FlowerButton.Location = New System.Drawing.Point(6, 25)
        Me.FlowerButton.Name = "FlowerButton"
        Me.FlowerButton.Size = New System.Drawing.Size(81, 24)
        Me.FlowerButton.TabIndex = 0
        Me.FlowerButton.TabStop = True
        Me.FlowerButton.Text = "Flower"
        Me.FlowerButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(72, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(306, 52)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Show State Information"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InfoBox
        '
        Me.InfoBox.Location = New System.Drawing.Point(72, 291)
        Me.InfoBox.Name = "InfoBox"
        Me.InfoBox.ReadOnly = True
        Me.InfoBox.Size = New System.Drawing.Size(306, 26)
        Me.InfoBox.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 369)
        Me.Controls.Add(Me.InfoBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "States"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NewYorkButton As RadioButton
    Friend WithEvents MississippiButton As RadioButton
    Friend WithEvents IndianaButton As RadioButton
    Friend WithEvents CaliButton As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MottoButton As RadioButton
    Friend WithEvents NicknameButton As RadioButton
    Friend WithEvents FlowerButton As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents InfoBox As TextBox
End Class
