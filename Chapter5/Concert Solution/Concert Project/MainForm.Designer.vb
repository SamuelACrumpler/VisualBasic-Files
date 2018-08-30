<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtGarden = New System.Windows.Forms.TextBox()
        Me.txtPav = New System.Windows.Forms.TextBox()
        Me.txtBox = New System.Windows.Forms.TextBox()
        Me.chkGarden = New System.Windows.Forms.CheckBox()
        Me.chkPav = New System.Windows.Forms.CheckBox()
        Me.chkBox = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTicket = New System.Windows.Forms.Label()
        Me.lblTotalTickets = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lblDue = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGarden)
        Me.GroupBox1.Controls.Add(Me.txtPav)
        Me.GroupBox1.Controls.Add(Me.txtBox)
        Me.GroupBox1.Controls.Add(Me.chkGarden)
        Me.GroupBox1.Controls.Add(Me.chkPav)
        Me.GroupBox1.Controls.Add(Me.chkBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets"
        '
        'txtGarden
        '
        Me.txtGarden.Location = New System.Drawing.Point(197, 56)
        Me.txtGarden.Name = "txtGarden"
        Me.txtGarden.Size = New System.Drawing.Size(33, 22)
        Me.txtGarden.TabIndex = 30
        Me.txtGarden.Visible = False
        '
        'txtPav
        '
        Me.txtPav.Location = New System.Drawing.Point(110, 56)
        Me.txtPav.Name = "txtPav"
        Me.txtPav.Size = New System.Drawing.Size(33, 22)
        Me.txtPav.TabIndex = 20
        Me.txtPav.Visible = False
        '
        'txtBox
        '
        Me.txtBox.Location = New System.Drawing.Point(23, 56)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.Size = New System.Drawing.Size(33, 22)
        Me.txtBox.TabIndex = 10
        Me.txtBox.Visible = False
        '
        'chkGarden
        '
        Me.chkGarden.AutoSize = True
        Me.chkGarden.Location = New System.Drawing.Point(180, 19)
        Me.chkGarden.Name = "chkGarden"
        Me.chkGarden.Size = New System.Drawing.Size(53, 17)
        Me.chkGarden.TabIndex = 25
        Me.chkGarden.Text = "&Lawn"
        Me.chkGarden.UseVisualStyleBackColor = True
        '
        'chkPav
        '
        Me.chkPav.AutoSize = True
        Me.chkPav.Location = New System.Drawing.Point(93, 19)
        Me.chkPav.Name = "chkPav"
        Me.chkPav.Size = New System.Drawing.Size(66, 17)
        Me.chkPav.TabIndex = 15
        Me.chkPav.Text = "&Pavilion"
        Me.chkPav.UseVisualStyleBackColor = True
        '
        'chkBox
        '
        Me.chkBox.AutoSize = True
        Me.chkBox.Location = New System.Drawing.Point(6, 19)
        Me.chkBox.Name = "chkBox"
        Me.chkBox.Size = New System.Drawing.Size(45, 17)
        Me.chkBox.TabIndex = 5
        Me.chkBox.Text = "B&ox"
        Me.chkBox.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(182, 215)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 40
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTicket
        '
        Me.lblTicket.AutoSize = True
        Me.lblTicket.Location = New System.Drawing.Point(12, 142)
        Me.lblTicket.Name = "lblTicket"
        Me.lblTicket.Size = New System.Drawing.Size(71, 13)
        Me.lblTicket.TabIndex = 3
        Me.lblTicket.Text = "Total Tickets:"
        '
        'lblTotalTickets
        '
        Me.lblTotalTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalTickets.Location = New System.Drawing.Point(12, 163)
        Me.lblTotalTickets.Name = "lblTotalTickets"
        Me.lblTotalTickets.Size = New System.Drawing.Size(56, 23)
        Me.lblTotalTickets.TabIndex = 4
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDue.Location = New System.Drawing.Point(12, 215)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(56, 23)
        Me.lblTotalDue.TabIndex = 4
        '
        'lblDue
        '
        Me.lblDue.AutoSize = True
        Me.lblDue.Location = New System.Drawing.Point(12, 194)
        Me.lblDue.Name = "lblDue"
        Me.lblDue.Size = New System.Drawing.Size(58, 13)
        Me.lblDue.TabIndex = 3
        Me.lblDue.Text = "Total Due:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(182, 184)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 35
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblDue)
        Me.Controls.Add(Me.lblTicket)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.lblTotalTickets)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.Text = "Ticket Miser"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBox As System.Windows.Forms.TextBox
    Friend WithEvents chkBox As System.Windows.Forms.CheckBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTicket As System.Windows.Forms.Label
    Friend WithEvents lblTotalTickets As System.Windows.Forms.Label
    Friend WithEvents txtGarden As System.Windows.Forms.TextBox
    Friend WithEvents txtPav As System.Windows.Forms.TextBox
    Friend WithEvents chkGarden As System.Windows.Forms.CheckBox
    Friend WithEvents chkPav As System.Windows.Forms.CheckBox
    Friend WithEvents lblTotalDue As System.Windows.Forms.Label
    Friend WithEvents lblDue As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button

End Class
