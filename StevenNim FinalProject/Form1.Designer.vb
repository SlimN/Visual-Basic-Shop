<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTitle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTitle))
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMoney = New System.Windows.Forms.Button()
        Me.pbTitleLogo = New System.Windows.Forms.PictureBox()
        Me.lblNotice = New System.Windows.Forms.Label()
        Me.btnCreditRegister = New System.Windows.Forms.Button()
        CType(Me.pbTitleLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Transparent
        Me.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnter.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(99, 250)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(515, 35)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "Enter Shop"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(99, 403)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(515, 35)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMoney
        '
        Me.btnMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMoney.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoney.Location = New System.Drawing.Point(99, 300)
        Me.btnMoney.Name = "btnMoney"
        Me.btnMoney.Size = New System.Drawing.Size(515, 35)
        Me.btnMoney.TabIndex = 4
        Me.btnMoney.Text = "Play on Fwump Machine"
        Me.btnMoney.UseVisualStyleBackColor = True
        '
        'pbTitleLogo
        '
        Me.pbTitleLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbTitleLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbTitleLogo.Image = CType(resources.GetObject("pbTitleLogo.Image"), System.Drawing.Image)
        Me.pbTitleLogo.Location = New System.Drawing.Point(11, 20)
        Me.pbTitleLogo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbTitleLogo.Name = "pbTitleLogo"
        Me.pbTitleLogo.Size = New System.Drawing.Size(723, 140)
        Me.pbTitleLogo.TabIndex = 5
        Me.pbTitleLogo.TabStop = False
        '
        'lblNotice
        '
        Me.lblNotice.AutoSize = True
        Me.lblNotice.BackColor = System.Drawing.Color.Transparent
        Me.lblNotice.Font = New System.Drawing.Font("Cambria", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNotice.Location = New System.Drawing.Point(78, 172)
        Me.lblNotice.Name = "lblNotice"
        Me.lblNotice.Size = New System.Drawing.Size(574, 52)
        Me.lblNotice.TabIndex = 6
        Me.lblNotice.Text = "Owned and operated by Steven Nim" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Note: Images may appear as unintended on larger" & _
            " monitors."
        Me.lblNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCreditRegister
        '
        Me.btnCreditRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreditRegister.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreditRegister.Location = New System.Drawing.Point(99, 351)
        Me.btnCreditRegister.Name = "btnCreditRegister"
        Me.btnCreditRegister.Size = New System.Drawing.Size(515, 35)
        Me.btnCreditRegister.TabIndex = 7
        Me.btnCreditRegister.Text = "Register Credit Card"
        Me.btnCreditRegister.UseVisualStyleBackColor = True
        '
        'frmTitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(741, 450)
        Me.Controls.Add(Me.btnCreditRegister)
        Me.Controls.Add(Me.lblNotice)
        Me.Controls.Add(Me.pbTitleLogo)
        Me.Controls.Add(Me.btnMoney)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTitle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to Weapons Workshop!"
        CType(Me.pbTitleLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnMoney As System.Windows.Forms.Button
    Friend WithEvents pbTitleLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblNotice As System.Windows.Forms.Label
    Friend WithEvents btnCreditRegister As System.Windows.Forms.Button

End Class
