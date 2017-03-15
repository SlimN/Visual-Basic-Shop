<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFwump
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFwump))
        Me.lblFwumpSub = New System.Windows.Forms.Label()
        Me.btnFwump = New System.Windows.Forms.Button()
        Me.lblGetThis = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.lblYourNum = New System.Windows.Forms.Label()
        Me.btnExitFwump = New System.Windows.Forms.Button()
        Me.lblIndicator = New System.Windows.Forms.Label()
        Me.nudYourNum = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.nudYourNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFwumpSub
        '
        Me.lblFwumpSub.AutoSize = True
        Me.lblFwumpSub.BackColor = System.Drawing.Color.Transparent
        Me.lblFwumpSub.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFwumpSub.Location = New System.Drawing.Point(103, 103)
        Me.lblFwumpSub.Name = "lblFwumpSub"
        Me.lblFwumpSub.Size = New System.Drawing.Size(393, 27)
        Me.lblFwumpSub.TabIndex = 1
        Me.lblFwumpSub.Text = "Did you run out of money? Try fwumping!"
        '
        'btnFwump
        '
        Me.btnFwump.BackColor = System.Drawing.Color.Gold
        Me.btnFwump.Font = New System.Drawing.Font("Palatino Linotype", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFwump.Location = New System.Drawing.Point(44, 292)
        Me.btnFwump.Name = "btnFwump"
        Me.btnFwump.Size = New System.Drawing.Size(350, 46)
        Me.btnFwump.TabIndex = 2
        Me.btnFwump.Text = "Click to Fwump"
        Me.btnFwump.UseVisualStyleBackColor = False
        '
        'lblGetThis
        '
        Me.lblGetThis.BackColor = System.Drawing.Color.Transparent
        Me.lblGetThis.Font = New System.Drawing.Font("Palatino Linotype", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGetThis.Location = New System.Drawing.Point(470, 190)
        Me.lblGetThis.Name = "lblGetThis"
        Me.lblGetThis.Size = New System.Drawing.Size(60, 71)
        Me.lblGetThis.TabIndex = 3
        Me.lblGetThis.Text = "0"
        Me.lblGetThis.Visible = False
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.BackColor = System.Drawing.Color.Transparent
        Me.lblNum.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Location = New System.Drawing.Point(421, 164)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(166, 26)
        Me.lblNum.TabIndex = 4
        Me.lblNum.Text = "The Number Was:"
        Me.lblNum.Visible = False
        '
        'lblYourNum
        '
        Me.lblYourNum.AutoSize = True
        Me.lblYourNum.BackColor = System.Drawing.Color.Transparent
        Me.lblYourNum.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourNum.Location = New System.Drawing.Point(39, 164)
        Me.lblYourNum.Name = "lblYourNum"
        Me.lblYourNum.Size = New System.Drawing.Size(198, 26)
        Me.lblYourNum.TabIndex = 6
        Me.lblYourNum.Text = "Choose Your Number!"
        '
        'btnExitFwump
        '
        Me.btnExitFwump.BackColor = System.Drawing.Color.Gold
        Me.btnExitFwump.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitFwump.Location = New System.Drawing.Point(494, 292)
        Me.btnExitFwump.Name = "btnExitFwump"
        Me.btnExitFwump.Size = New System.Drawing.Size(92, 46)
        Me.btnExitFwump.TabIndex = 7
        Me.btnExitFwump.Text = "Exit"
        Me.btnExitFwump.UseVisualStyleBackColor = False
        '
        'lblIndicator
        '
        Me.lblIndicator.BackColor = System.Drawing.Color.Silver
        Me.lblIndicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIndicator.Font = New System.Drawing.Font("Comic Sans MS", 38.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndicator.Location = New System.Drawing.Point(262, 180)
        Me.lblIndicator.Name = "lblIndicator"
        Me.lblIndicator.Size = New System.Drawing.Size(122, 82)
        Me.lblIndicator.TabIndex = 8
        Me.lblIndicator.Text = ":|"
        Me.lblIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudYourNum
        '
        Me.nudYourNum.Font = New System.Drawing.Font("Palatino Linotype", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudYourNum.Location = New System.Drawing.Point(97, 194)
        Me.nudYourNum.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nudYourNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudYourNum.Name = "nudYourNum"
        Me.nudYourNum.Size = New System.Drawing.Size(74, 71)
        Me.nudYourNum.TabIndex = 9
        Me.nudYourNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(543, 77)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'frmFwump
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(615, 359)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.nudYourNum)
        Me.Controls.Add(Me.lblIndicator)
        Me.Controls.Add(Me.btnExitFwump)
        Me.Controls.Add(Me.lblYourNum)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.lblGetThis)
        Me.Controls.Add(Me.btnFwump)
        Me.Controls.Add(Me.lblFwumpSub)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFwump"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fwump Machine"
        CType(Me.nudYourNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFwumpSub As System.Windows.Forms.Label
    Friend WithEvents btnFwump As System.Windows.Forms.Button
    Friend WithEvents lblGetThis As System.Windows.Forms.Label
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents lblYourNum As System.Windows.Forms.Label
    Friend WithEvents btnExitFwump As System.Windows.Forms.Button
    Friend WithEvents lblIndicator As System.Windows.Forms.Label
    Friend WithEvents nudYourNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
