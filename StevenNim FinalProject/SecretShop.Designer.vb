<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecretShop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSecretShop))
        Me.pbAegislash = New System.Windows.Forms.PictureBox()
        Me.cbAegislash = New System.Windows.Forms.CheckBox()
        Me.lblAegislash = New System.Windows.Forms.Label()
        Me.nudAegislash = New System.Windows.Forms.NumericUpDown()
        Me.lblReceiptSS = New System.Windows.Forms.TextBox()
        Me.lblReceiptTitleSS = New System.Windows.Forms.Label()
        Me.btnExitSS = New System.Windows.Forms.Button()
        Me.btnPreviewSS = New System.Windows.Forms.Button()
        Me.pbMasterSword = New System.Windows.Forms.PictureBox()
        Me.pbMaxim = New System.Windows.Forms.PictureBox()
        Me.cbMasterSword = New System.Windows.Forms.CheckBox()
        Me.cbMaxim = New System.Windows.Forms.CheckBox()
        Me.lblMasterSword = New System.Windows.Forms.Label()
        Me.lblMaxim = New System.Windows.Forms.Label()
        Me.nudMasterSword = New System.Windows.Forms.NumericUpDown()
        Me.nudMaxim = New System.Windows.Forms.NumericUpDown()
        Me.btnPayCashSS = New System.Windows.Forms.Button()
        Me.pbCommChest = New System.Windows.Forms.PictureBox()
        Me.lblCommChestInfo = New System.Windows.Forms.Label()
        Me.btnPayCreditSS = New System.Windows.Forms.Button()
        Me.pbCommChestTitle = New System.Windows.Forms.PictureBox()
        CType(Me.pbAegislash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAegislash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMasterSword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMaxim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMasterSword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaxim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCommChest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCommChestTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbAegislash
        '
        Me.pbAegislash.BackColor = System.Drawing.Color.Transparent
        Me.pbAegislash.Image = CType(resources.GetObject("pbAegislash.Image"), System.Drawing.Image)
        Me.pbAegislash.Location = New System.Drawing.Point(26, 26)
        Me.pbAegislash.Name = "pbAegislash"
        Me.pbAegislash.Size = New System.Drawing.Size(100, 100)
        Me.pbAegislash.TabIndex = 1
        Me.pbAegislash.TabStop = False
        '
        'cbAegislash
        '
        Me.cbAegislash.AutoSize = True
        Me.cbAegislash.BackColor = System.Drawing.Color.Transparent
        Me.cbAegislash.Font = New System.Drawing.Font("Cambria", 15.25!)
        Me.cbAegislash.ForeColor = System.Drawing.Color.LawnGreen
        Me.cbAegislash.Location = New System.Drawing.Point(26, 149)
        Me.cbAegislash.Name = "cbAegislash"
        Me.cbAegislash.Size = New System.Drawing.Size(116, 29)
        Me.cbAegislash.TabIndex = 54
        Me.cbAegislash.Text = "Aegislash"
        Me.cbAegislash.UseVisualStyleBackColor = False
        '
        'lblAegislash
        '
        Me.lblAegislash.AutoSize = True
        Me.lblAegislash.BackColor = System.Drawing.Color.Transparent
        Me.lblAegislash.Font = New System.Drawing.Font("Cambria", 13.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAegislash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAegislash.Location = New System.Drawing.Point(40, 187)
        Me.lblAegislash.Name = "lblAegislash"
        Me.lblAegislash.Size = New System.Drawing.Size(63, 21)
        Me.lblAegislash.TabIndex = 55
        Me.lblAegislash.Text = "$54.99"
        '
        'nudAegislash
        '
        Me.nudAegislash.Enabled = False
        Me.nudAegislash.Location = New System.Drawing.Point(38, 218)
        Me.nudAegislash.Name = "nudAegislash"
        Me.nudAegislash.Size = New System.Drawing.Size(75, 20)
        Me.nudAegislash.TabIndex = 56
        '
        'lblReceiptSS
        '
        Me.lblReceiptSS.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptSS.Location = New System.Drawing.Point(632, 55)
        Me.lblReceiptSS.Multiline = True
        Me.lblReceiptSS.Name = "lblReceiptSS"
        Me.lblReceiptSS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.lblReceiptSS.Size = New System.Drawing.Size(293, 346)
        Me.lblReceiptSS.TabIndex = 57
        '
        'lblReceiptTitleSS
        '
        Me.lblReceiptTitleSS.AutoSize = True
        Me.lblReceiptTitleSS.BackColor = System.Drawing.Color.Transparent
        Me.lblReceiptTitleSS.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptTitleSS.ForeColor = System.Drawing.SystemColors.Info
        Me.lblReceiptTitleSS.Location = New System.Drawing.Point(659, 9)
        Me.lblReceiptTitleSS.Name = "lblReceiptTitleSS"
        Me.lblReceiptTitleSS.Size = New System.Drawing.Size(244, 28)
        Me.lblReceiptTitleSS.TabIndex = 58
        Me.lblReceiptTitleSS.Text = "Secret Storage Receipt"
        '
        'btnExitSS
        '
        Me.btnExitSS.BackColor = System.Drawing.Color.Moccasin
        Me.btnExitSS.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitSS.Location = New System.Drawing.Point(632, 497)
        Me.btnExitSS.Name = "btnExitSS"
        Me.btnExitSS.Size = New System.Drawing.Size(293, 33)
        Me.btnExitSS.TabIndex = 59
        Me.btnExitSS.Text = "Exit Secret Shop"
        Me.btnExitSS.UseVisualStyleBackColor = False
        '
        'btnPreviewSS
        '
        Me.btnPreviewSS.BackColor = System.Drawing.Color.Moccasin
        Me.btnPreviewSS.Font = New System.Drawing.Font("Cambria", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviewSS.Location = New System.Drawing.Point(632, 407)
        Me.btnPreviewSS.Name = "btnPreviewSS"
        Me.btnPreviewSS.Size = New System.Drawing.Size(293, 35)
        Me.btnPreviewSS.TabIndex = 60
        Me.btnPreviewSS.Text = "Preview Receipt!"
        Me.btnPreviewSS.UseVisualStyleBackColor = False
        '
        'pbMasterSword
        '
        Me.pbMasterSword.BackColor = System.Drawing.Color.Transparent
        Me.pbMasterSword.Image = CType(resources.GetObject("pbMasterSword.Image"), System.Drawing.Image)
        Me.pbMasterSword.Location = New System.Drawing.Point(411, 26)
        Me.pbMasterSword.Name = "pbMasterSword"
        Me.pbMasterSword.Size = New System.Drawing.Size(100, 100)
        Me.pbMasterSword.TabIndex = 62
        Me.pbMasterSword.TabStop = False
        '
        'pbMaxim
        '
        Me.pbMaxim.BackColor = System.Drawing.Color.Transparent
        Me.pbMaxim.Image = CType(resources.GetObject("pbMaxim.Image"), System.Drawing.Image)
        Me.pbMaxim.Location = New System.Drawing.Point(222, 26)
        Me.pbMaxim.Name = "pbMaxim"
        Me.pbMaxim.Size = New System.Drawing.Size(100, 100)
        Me.pbMaxim.TabIndex = 63
        Me.pbMaxim.TabStop = False
        '
        'cbMasterSword
        '
        Me.cbMasterSword.AutoSize = True
        Me.cbMasterSword.BackColor = System.Drawing.Color.Transparent
        Me.cbMasterSword.Font = New System.Drawing.Font("Cambria", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMasterSword.ForeColor = System.Drawing.Color.LawnGreen
        Me.cbMasterSword.Location = New System.Drawing.Point(396, 149)
        Me.cbMasterSword.Name = "cbMasterSword"
        Me.cbMasterSword.Size = New System.Drawing.Size(148, 27)
        Me.cbMasterSword.TabIndex = 64
        Me.cbMasterSword.Text = "Master Sword"
        Me.cbMasterSword.UseVisualStyleBackColor = False
        '
        'cbMaxim
        '
        Me.cbMaxim.AutoSize = True
        Me.cbMaxim.BackColor = System.Drawing.Color.Transparent
        Me.cbMaxim.Font = New System.Drawing.Font("Cambria", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMaxim.ForeColor = System.Drawing.Color.LawnGreen
        Me.cbMaxim.Location = New System.Drawing.Point(198, 149)
        Me.cbMaxim.Name = "cbMaxim"
        Me.cbMaxim.Size = New System.Drawing.Size(158, 27)
        Me.cbMaxim.TabIndex = 65
        Me.cbMaxim.Text = "Maxim Tomato"
        Me.cbMaxim.UseVisualStyleBackColor = False
        '
        'lblMasterSword
        '
        Me.lblMasterSword.AutoSize = True
        Me.lblMasterSword.BackColor = System.Drawing.Color.Transparent
        Me.lblMasterSword.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMasterSword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMasterSword.Location = New System.Drawing.Point(432, 187)
        Me.lblMasterSword.Name = "lblMasterSword"
        Me.lblMasterSword.Size = New System.Drawing.Size(68, 22)
        Me.lblMasterSword.TabIndex = 66
        Me.lblMasterSword.Text = "$39.99"
        '
        'lblMaxim
        '
        Me.lblMaxim.AutoSize = True
        Me.lblMaxim.BackColor = System.Drawing.Color.Transparent
        Me.lblMaxim.Font = New System.Drawing.Font("Cambria", 13.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxim.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMaxim.Location = New System.Drawing.Point(239, 187)
        Me.lblMaxim.Name = "lblMaxim"
        Me.lblMaxim.Size = New System.Drawing.Size(53, 21)
        Me.lblMaxim.TabIndex = 67
        Me.lblMaxim.Text = "$9.99"
        '
        'nudMasterSword
        '
        Me.nudMasterSword.Enabled = False
        Me.nudMasterSword.Location = New System.Drawing.Point(425, 218)
        Me.nudMasterSword.Name = "nudMasterSword"
        Me.nudMasterSword.Size = New System.Drawing.Size(75, 20)
        Me.nudMasterSword.TabIndex = 68
        '
        'nudMaxim
        '
        Me.nudMaxim.Enabled = False
        Me.nudMaxim.Location = New System.Drawing.Point(232, 218)
        Me.nudMaxim.Name = "nudMaxim"
        Me.nudMaxim.Size = New System.Drawing.Size(75, 20)
        Me.nudMaxim.TabIndex = 69
        '
        'btnPayCashSS
        '
        Me.btnPayCashSS.Enabled = False
        Me.btnPayCashSS.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayCashSS.Location = New System.Drawing.Point(799, 448)
        Me.btnPayCashSS.Name = "btnPayCashSS"
        Me.btnPayCashSS.Size = New System.Drawing.Size(126, 43)
        Me.btnPayCashSS.TabIndex = 71
        Me.btnPayCashSS.Text = "Pay With Cash!"
        Me.btnPayCashSS.UseVisualStyleBackColor = True
        '
        'pbCommChest
        '
        Me.pbCommChest.BackColor = System.Drawing.Color.Transparent
        Me.pbCommChest.Image = CType(resources.GetObject("pbCommChest.Image"), System.Drawing.Image)
        Me.pbCommChest.Location = New System.Drawing.Point(11, 261)
        Me.pbCommChest.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbCommChest.Name = "pbCommChest"
        Me.pbCommChest.Size = New System.Drawing.Size(323, 306)
        Me.pbCommChest.TabIndex = 72
        Me.pbCommChest.TabStop = False
        '
        'lblCommChestInfo
        '
        Me.lblCommChestInfo.AutoSize = True
        Me.lblCommChestInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblCommChestInfo.Font = New System.Drawing.Font("Cambria", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommChestInfo.ForeColor = System.Drawing.SystemColors.Info
        Me.lblCommChestInfo.Location = New System.Drawing.Point(364, 345)
        Me.lblCommChestInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCommChestInfo.Name = "lblCommChestInfo"
        Me.lblCommChestInfo.Size = New System.Drawing.Size(230, 176)
        Me.lblCommChestInfo.TabIndex = 73
        Me.lblCommChestInfo.Text = resources.GetString("lblCommChestInfo.Text")
        '
        'btnPayCreditSS
        '
        Me.btnPayCreditSS.Enabled = False
        Me.btnPayCreditSS.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayCreditSS.Location = New System.Drawing.Point(632, 448)
        Me.btnPayCreditSS.Name = "btnPayCreditSS"
        Me.btnPayCreditSS.Size = New System.Drawing.Size(161, 43)
        Me.btnPayCreditSS.TabIndex = 75
        Me.btnPayCreditSS.Text = "Pay With Credit Card!"
        Me.btnPayCreditSS.UseVisualStyleBackColor = True
        '
        'pbCommChestTitle
        '
        Me.pbCommChestTitle.BackColor = System.Drawing.Color.Transparent
        Me.pbCommChestTitle.Image = CType(resources.GetObject("pbCommChestTitle.Image"), System.Drawing.Image)
        Me.pbCommChestTitle.Location = New System.Drawing.Point(358, 283)
        Me.pbCommChestTitle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbCommChestTitle.Name = "pbCommChestTitle"
        Me.pbCommChestTitle.Size = New System.Drawing.Size(240, 60)
        Me.pbCommChestTitle.TabIndex = 76
        Me.pbCommChestTitle.TabStop = False
        '
        'frmSecretShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(937, 542)
        Me.Controls.Add(Me.pbCommChestTitle)
        Me.Controls.Add(Me.btnPayCreditSS)
        Me.Controls.Add(Me.lblCommChestInfo)
        Me.Controls.Add(Me.pbCommChest)
        Me.Controls.Add(Me.btnPayCashSS)
        Me.Controls.Add(Me.nudMaxim)
        Me.Controls.Add(Me.nudMasterSword)
        Me.Controls.Add(Me.lblMaxim)
        Me.Controls.Add(Me.lblMasterSword)
        Me.Controls.Add(Me.cbMaxim)
        Me.Controls.Add(Me.cbMasterSword)
        Me.Controls.Add(Me.pbMaxim)
        Me.Controls.Add(Me.pbMasterSword)
        Me.Controls.Add(Me.btnPreviewSS)
        Me.Controls.Add(Me.btnExitSS)
        Me.Controls.Add(Me.lblReceiptTitleSS)
        Me.Controls.Add(Me.lblReceiptSS)
        Me.Controls.Add(Me.nudAegislash)
        Me.Controls.Add(Me.lblAegislash)
        Me.Controls.Add(Me.cbAegislash)
        Me.Controls.Add(Me.pbAegislash)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSecretShop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weapons Workshop's Secret Storage"
        CType(Me.pbAegislash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAegislash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMasterSword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMaxim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMasterSword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaxim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCommChest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCommChestTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbAegislash As System.Windows.Forms.PictureBox
    Friend WithEvents cbAegislash As System.Windows.Forms.CheckBox
    Friend WithEvents lblAegislash As System.Windows.Forms.Label
    Friend WithEvents nudAegislash As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblReceiptSS As System.Windows.Forms.TextBox
    Friend WithEvents lblReceiptTitleSS As System.Windows.Forms.Label
    Friend WithEvents btnExitSS As System.Windows.Forms.Button
    Friend WithEvents btnPreviewSS As System.Windows.Forms.Button
    Friend WithEvents pbMasterSword As System.Windows.Forms.PictureBox
    Friend WithEvents pbMaxim As System.Windows.Forms.PictureBox
    Friend WithEvents cbMasterSword As System.Windows.Forms.CheckBox
    Friend WithEvents cbMaxim As System.Windows.Forms.CheckBox
    Friend WithEvents lblMasterSword As System.Windows.Forms.Label
    Friend WithEvents lblMaxim As System.Windows.Forms.Label
    Friend WithEvents nudMasterSword As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMaxim As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnPayCashSS As System.Windows.Forms.Button
    Friend WithEvents pbCommChest As System.Windows.Forms.PictureBox
    Friend WithEvents lblCommChestInfo As System.Windows.Forms.Label
    Friend WithEvents btnPayCreditSS As System.Windows.Forms.Button
    Friend WithEvents pbCommChestTitle As System.Windows.Forms.PictureBox
End Class
