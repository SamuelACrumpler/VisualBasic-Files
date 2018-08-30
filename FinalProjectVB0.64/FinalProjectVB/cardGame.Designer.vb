<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cardGame
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
        Me.grbCharacterArt = New System.Windows.Forms.GroupBox()
        Me.lblHpLabel = New System.Windows.Forms.Label()
        Me.lblSpLabel = New System.Windows.Forms.Label()
        Me.lblSpMaxLabel = New System.Windows.Forms.Label()
        Me.lblSpSlash = New System.Windows.Forms.Label()
        Me.lblSpCurLabel = New System.Windows.Forms.Label()
        Me.lblHpCurLabel = New System.Windows.Forms.Label()
        Me.lblHpSlash = New System.Windows.Forms.Label()
        Me.lblHpMaxLabel = New System.Windows.Forms.Label()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnClassPow = New System.Windows.Forms.Button()
        Me.btnDrawCard = New System.Windows.Forms.Button()
        Me.pbarSP = New System.Windows.Forms.ProgressBar()
        Me.pbarHP = New System.Windows.Forms.ProgressBar()
        Me.lblStrLabel = New System.Windows.Forms.Label()
        Me.lblDexLabel = New System.Windows.Forms.Label()
        Me.lblConLabel = New System.Windows.Forms.Label()
        Me.lblIntLabel = New System.Windows.Forms.Label()
        Me.lblStrNum = New System.Windows.Forms.Label()
        Me.lblDexNum = New System.Windows.Forms.Label()
        Me.lblConNum = New System.Windows.Forms.Label()
        Me.lblIntNum = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picCharacter = New System.Windows.Forms.PictureBox()
        Me.grbEventWindow = New System.Windows.Forms.GroupBox()
        Me.picMonster = New System.Windows.Forms.PictureBox()
        Me.lblBattles = New System.Windows.Forms.Label()
        Me.lblBattlesNum = New System.Windows.Forms.Label()
        Me.grbCharacterArt.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbEventWindow.SuspendLayout()
        CType(Me.picMonster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbCharacterArt
        '
        Me.grbCharacterArt.Controls.Add(Me.picCharacter)
        Me.grbCharacterArt.Location = New System.Drawing.Point(536, 20)
        Me.grbCharacterArt.Name = "grbCharacterArt"
        Me.grbCharacterArt.Size = New System.Drawing.Size(98, 134)
        Me.grbCharacterArt.TabIndex = 0
        Me.grbCharacterArt.TabStop = False
        Me.grbCharacterArt.Text = "Character"
        '
        'lblHpLabel
        '
        Me.lblHpLabel.AutoSize = True
        Me.lblHpLabel.Location = New System.Drawing.Point(572, 157)
        Me.lblHpLabel.Name = "lblHpLabel"
        Me.lblHpLabel.Size = New System.Drawing.Size(21, 13)
        Me.lblHpLabel.TabIndex = 2
        Me.lblHpLabel.Text = "HP"
        '
        'lblSpLabel
        '
        Me.lblSpLabel.AutoSize = True
        Me.lblSpLabel.Location = New System.Drawing.Point(573, 220)
        Me.lblSpLabel.Name = "lblSpLabel"
        Me.lblSpLabel.Size = New System.Drawing.Size(19, 13)
        Me.lblSpLabel.TabIndex = 2
        Me.lblSpLabel.Text = "SP"
        '
        'lblSpMaxLabel
        '
        Me.lblSpMaxLabel.BackColor = System.Drawing.SystemColors.Control
        Me.lblSpMaxLabel.Location = New System.Drawing.Point(584, 233)
        Me.lblSpMaxLabel.Name = "lblSpMaxLabel"
        Me.lblSpMaxLabel.Size = New System.Drawing.Size(30, 23)
        Me.lblSpMaxLabel.TabIndex = 3
        Me.lblSpMaxLabel.Text = "000"
        Me.lblSpMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSpSlash
        '
        Me.lblSpSlash.AutoSize = True
        Me.lblSpSlash.BackColor = System.Drawing.SystemColors.Control
        Me.lblSpSlash.Location = New System.Drawing.Point(574, 238)
        Me.lblSpSlash.Name = "lblSpSlash"
        Me.lblSpSlash.Size = New System.Drawing.Size(11, 13)
        Me.lblSpSlash.TabIndex = 3
        Me.lblSpSlash.Text = "/"
        Me.lblSpSlash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSpCurLabel
        '
        Me.lblSpCurLabel.BackColor = System.Drawing.SystemColors.Control
        Me.lblSpCurLabel.Location = New System.Drawing.Point(550, 233)
        Me.lblSpCurLabel.Name = "lblSpCurLabel"
        Me.lblSpCurLabel.Size = New System.Drawing.Size(30, 23)
        Me.lblSpCurLabel.TabIndex = 3
        Me.lblSpCurLabel.Text = "000"
        Me.lblSpCurLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHpCurLabel
        '
        Me.lblHpCurLabel.BackColor = System.Drawing.SystemColors.Control
        Me.lblHpCurLabel.Location = New System.Drawing.Point(550, 170)
        Me.lblHpCurLabel.Name = "lblHpCurLabel"
        Me.lblHpCurLabel.Size = New System.Drawing.Size(30, 23)
        Me.lblHpCurLabel.TabIndex = 3
        Me.lblHpCurLabel.Text = "000"
        Me.lblHpCurLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHpSlash
        '
        Me.lblHpSlash.AutoSize = True
        Me.lblHpSlash.BackColor = System.Drawing.SystemColors.Control
        Me.lblHpSlash.Location = New System.Drawing.Point(574, 175)
        Me.lblHpSlash.Name = "lblHpSlash"
        Me.lblHpSlash.Size = New System.Drawing.Size(11, 13)
        Me.lblHpSlash.TabIndex = 3
        Me.lblHpSlash.Text = "/"
        Me.lblHpSlash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHpMaxLabel
        '
        Me.lblHpMaxLabel.BackColor = System.Drawing.SystemColors.Control
        Me.lblHpMaxLabel.Location = New System.Drawing.Point(584, 170)
        Me.lblHpMaxLabel.Name = "lblHpMaxLabel"
        Me.lblHpMaxLabel.Size = New System.Drawing.Size(30, 23)
        Me.lblHpMaxLabel.TabIndex = 3
        Me.lblHpMaxLabel.Text = "000"
        Me.lblHpMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLog
        '
        Me.txtLog.Enabled = False
        Me.txtLog.Location = New System.Drawing.Point(12, 526)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.Size = New System.Drawing.Size(624, 100)
        Me.txtLog.TabIndex = 4
        '
        'txtUserInput
        '
        Me.txtUserInput.Location = New System.Drawing.Point(12, 632)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(543, 22)
        Me.txtUserInput.TabIndex = 5
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(561, 630)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 6
        Me.btnEnter.Text = "E&nter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnClassPow
        '
        Me.btnClassPow.Location = New System.Drawing.Point(435, 259)
        Me.btnClassPow.Name = "btnClassPow"
        Me.btnClassPow.Size = New System.Drawing.Size(75, 23)
        Me.btnClassPow.TabIndex = 2
        Me.btnClassPow.Text = "Power Strike"
        Me.btnClassPow.UseVisualStyleBackColor = True
        '
        'btnDrawCard
        '
        Me.btnDrawCard.Location = New System.Drawing.Point(435, 228)
        Me.btnDrawCard.Name = "btnDrawCard"
        Me.btnDrawCard.Size = New System.Drawing.Size(75, 23)
        Me.btnDrawCard.TabIndex = 2
        Me.btnDrawCard.Text = "Defend"
        Me.btnDrawCard.UseVisualStyleBackColor = True
        '
        'pbarSP
        '
        Me.pbarSP.ForeColor = System.Drawing.Color.Navy
        Me.pbarSP.Location = New System.Drawing.Point(536, 259)
        Me.pbarSP.Name = "pbarSP"
        Me.pbarSP.Size = New System.Drawing.Size(100, 23)
        Me.pbarSP.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbarSP.TabIndex = 1
        Me.pbarSP.Value = 100
        '
        'pbarHP
        '
        Me.pbarHP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbarHP.Location = New System.Drawing.Point(536, 194)
        Me.pbarHP.Name = "pbarHP"
        Me.pbarHP.Size = New System.Drawing.Size(100, 23)
        Me.pbarHP.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbarHP.TabIndex = 1
        Me.pbarHP.Value = 100
        '
        'lblStrLabel
        '
        Me.lblStrLabel.AutoSize = True
        Me.lblStrLabel.Location = New System.Drawing.Point(432, 23)
        Me.lblStrLabel.Name = "lblStrLabel"
        Me.lblStrLabel.Size = New System.Drawing.Size(31, 13)
        Me.lblStrLabel.TabIndex = 7
        Me.lblStrLabel.Text = "STR :"
        '
        'lblDexLabel
        '
        Me.lblDexLabel.AutoSize = True
        Me.lblDexLabel.Location = New System.Drawing.Point(432, 57)
        Me.lblDexLabel.Name = "lblDexLabel"
        Me.lblDexLabel.Size = New System.Drawing.Size(33, 13)
        Me.lblDexLabel.TabIndex = 7
        Me.lblDexLabel.Text = "DEX :"
        '
        'lblConLabel
        '
        Me.lblConLabel.AutoSize = True
        Me.lblConLabel.Location = New System.Drawing.Point(432, 97)
        Me.lblConLabel.Name = "lblConLabel"
        Me.lblConLabel.Size = New System.Drawing.Size(37, 13)
        Me.lblConLabel.TabIndex = 7
        Me.lblConLabel.Text = "CON :"
        '
        'lblIntLabel
        '
        Me.lblIntLabel.AutoSize = True
        Me.lblIntLabel.Location = New System.Drawing.Point(432, 141)
        Me.lblIntLabel.Name = "lblIntLabel"
        Me.lblIntLabel.Size = New System.Drawing.Size(29, 13)
        Me.lblIntLabel.TabIndex = 7
        Me.lblIntLabel.Text = "INT :"
        '
        'lblStrNum
        '
        Me.lblStrNum.AutoSize = True
        Me.lblStrNum.Location = New System.Drawing.Point(475, 23)
        Me.lblStrNum.Name = "lblStrNum"
        Me.lblStrNum.Size = New System.Drawing.Size(25, 13)
        Me.lblStrNum.TabIndex = 7
        Me.lblStrNum.Text = "000"
        '
        'lblDexNum
        '
        Me.lblDexNum.AutoSize = True
        Me.lblDexNum.Location = New System.Drawing.Point(475, 57)
        Me.lblDexNum.Name = "lblDexNum"
        Me.lblDexNum.Size = New System.Drawing.Size(25, 13)
        Me.lblDexNum.TabIndex = 7
        Me.lblDexNum.Text = "000"
        '
        'lblConNum
        '
        Me.lblConNum.AutoSize = True
        Me.lblConNum.Location = New System.Drawing.Point(474, 97)
        Me.lblConNum.Name = "lblConNum"
        Me.lblConNum.Size = New System.Drawing.Size(25, 13)
        Me.lblConNum.TabIndex = 7
        Me.lblConNum.Text = "000"
        '
        'lblIntNum
        '
        Me.lblIntNum.AutoSize = True
        Me.lblIntNum.Location = New System.Drawing.Point(474, 141)
        Me.lblIntNum.Name = "lblIntNum"
        Me.lblIntNum.Size = New System.Drawing.Size(25, 13)
        Me.lblIntNum.TabIndex = 7
        Me.lblIntNum.Text = "000"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(644, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.NewGameToolStripMenuItem.Text = "&New Game"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'picCharacter
        '
        Me.picCharacter.BackColor = System.Drawing.Color.Transparent
        Me.picCharacter.Image = Global.FinalProjectVB.My.Resources.Resources.charSprite
        Me.picCharacter.Location = New System.Drawing.Point(17, 37)
        Me.picCharacter.Name = "picCharacter"
        Me.picCharacter.Size = New System.Drawing.Size(64, 64)
        Me.picCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCharacter.TabIndex = 0
        Me.picCharacter.TabStop = False
        '
        'grbEventWindow
        '
        Me.grbEventWindow.BackgroundImage = Global.FinalProjectVB.My.Resources.Resources.dq3bg01
        Me.grbEventWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grbEventWindow.Controls.Add(Me.picMonster)
        Me.grbEventWindow.Location = New System.Drawing.Point(12, 24)
        Me.grbEventWindow.Name = "grbEventWindow"
        Me.grbEventWindow.Size = New System.Drawing.Size(374, 262)
        Me.grbEventWindow.TabIndex = 0
        Me.grbEventWindow.TabStop = False
        Me.grbEventWindow.Text = "Event Window"
        '
        'picMonster
        '
        Me.picMonster.BackColor = System.Drawing.Color.Transparent
        Me.picMonster.Image = Global.FinalProjectVB.My.Resources.Resources.monGobS
        Me.picMonster.ImageLocation = ""
        Me.picMonster.Location = New System.Drawing.Point(148, 133)
        Me.picMonster.Name = "picMonster"
        Me.picMonster.Size = New System.Drawing.Size(64, 64)
        Me.picMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMonster.TabIndex = 1
        Me.picMonster.TabStop = False
        '
        'lblBattles
        '
        Me.lblBattles.AutoSize = True
        Me.lblBattles.Location = New System.Drawing.Point(420, 180)
        Me.lblBattles.Name = "lblBattles"
        Me.lblBattles.Size = New System.Drawing.Size(45, 13)
        Me.lblBattles.TabIndex = 7
        Me.lblBattles.Text = "Battles:"
        '
        'lblBattlesNum
        '
        Me.lblBattlesNum.AutoSize = True
        Me.lblBattlesNum.Location = New System.Drawing.Point(475, 180)
        Me.lblBattlesNum.Name = "lblBattlesNum"
        Me.lblBattlesNum.Size = New System.Drawing.Size(25, 13)
        Me.lblBattlesNum.TabIndex = 7
        Me.lblBattlesNum.Text = "000"
        '
        'cardGame
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 661)
        Me.Controls.Add(Me.lblBattles)
        Me.Controls.Add(Me.lblIntLabel)
        Me.Controls.Add(Me.lblConLabel)
        Me.Controls.Add(Me.lblDexLabel)
        Me.Controls.Add(Me.lblBattlesNum)
        Me.Controls.Add(Me.lblIntNum)
        Me.Controls.Add(Me.lblConNum)
        Me.Controls.Add(Me.lblDexNum)
        Me.Controls.Add(Me.lblStrNum)
        Me.Controls.Add(Me.lblStrLabel)
        Me.Controls.Add(Me.btnDrawCard)
        Me.Controls.Add(Me.btnClassPow)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.lblHpMaxLabel)
        Me.Controls.Add(Me.lblHpSlash)
        Me.Controls.Add(Me.lblSpMaxLabel)
        Me.Controls.Add(Me.lblHpCurLabel)
        Me.Controls.Add(Me.lblSpSlash)
        Me.Controls.Add(Me.lblSpCurLabel)
        Me.Controls.Add(Me.lblSpLabel)
        Me.Controls.Add(Me.lblHpLabel)
        Me.Controls.Add(Me.pbarSP)
        Me.Controls.Add(Me.pbarHP)
        Me.Controls.Add(Me.grbCharacterArt)
        Me.Controls.Add(Me.grbEventWindow)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(660, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(660, 700)
        Me.Name = "cardGame"
        Me.ShowIcon = False
        Me.Text = "Card Densetsu"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grbCharacterArt.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbEventWindow.ResumeLayout(False)
        CType(Me.picMonster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbEventWindow As GroupBox
    Friend WithEvents grbCharacterArt As GroupBox
    Friend WithEvents lblHpLabel As Label
    Friend WithEvents lblSpLabel As Label
    Friend WithEvents lblSpMaxLabel As Label
    Friend WithEvents lblSpSlash As Label
    Friend WithEvents lblSpCurLabel As Label
    Friend WithEvents lblHpCurLabel As Label
    Friend WithEvents lblHpSlash As Label
    Friend WithEvents lblHpMaxLabel As Label
    Friend WithEvents picMonster As PictureBox
    Friend WithEvents picCharacter As PictureBox
    Friend WithEvents txtLog As TextBox
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnClassPow As Button
    Friend WithEvents btnDrawCard As Button
    Friend WithEvents pbarSP As ProgressBar
    Friend WithEvents pbarHP As ProgressBar
    Friend WithEvents lblStrLabel As Label
    Friend WithEvents lblDexLabel As Label
    Friend WithEvents lblConLabel As Label
    Friend WithEvents lblIntLabel As Label
    Friend WithEvents lblStrNum As Label
    Friend WithEvents lblDexNum As Label
    Friend WithEvents lblConNum As Label
    Friend WithEvents lblIntNum As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblBattles As Label
    Friend WithEvents lblBattlesNum As Label
End Class
