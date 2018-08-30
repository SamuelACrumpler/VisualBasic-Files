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
        Me.txtMember = New System.Windows.Forms.TextBox()
        Me.lblMember = New System.Windows.Forms.Label()
        Me.txtWeekend = New System.Windows.Forms.TextBox()
        Me.lblWeekend = New System.Windows.Forms.Label()
        Me.lblFeedisplay = New System.Windows.Forms.Label()
        Me.lblFee = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMember
        '
        Me.txtMember.Location = New System.Drawing.Point(23, 47)
        Me.txtMember.Name = "txtMember"
        Me.txtMember.Size = New System.Drawing.Size(29, 20)
        Me.txtMember.TabIndex = 6
        '
        'lblMember
        '
        Me.lblMember.AutoSize = True
        Me.lblMember.Location = New System.Drawing.Point(9, 31)
        Me.lblMember.Name = "lblMember"
        Me.lblMember.Size = New System.Drawing.Size(64, 13)
        Me.lblMember.TabIndex = 5
        Me.lblMember.Text = "&Membership"
        '
        'txtWeekend
        '
        Me.txtWeekend.Location = New System.Drawing.Point(105, 47)
        Me.txtWeekend.Name = "txtWeekend"
        Me.txtWeekend.Size = New System.Drawing.Size(29, 20)
        Me.txtWeekend.TabIndex = 0
        '
        'lblWeekend
        '
        Me.lblWeekend.AutoSize = True
        Me.lblWeekend.Location = New System.Drawing.Point(90, 31)
        Me.lblWeekend.Name = "lblWeekend"
        Me.lblWeekend.Size = New System.Drawing.Size(54, 13)
        Me.lblWeekend.TabIndex = 1
        Me.lblWeekend.Text = "&Weekend"
        '
        'lblFeedisplay
        '
        Me.lblFeedisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFeedisplay.Location = New System.Drawing.Point(51, 102)
        Me.lblFeedisplay.Name = "lblFeedisplay"
        Me.lblFeedisplay.Size = New System.Drawing.Size(49, 20)
        Me.lblFeedisplay.TabIndex = 2
        '
        'lblFee
        '
        Me.lblFee.AutoSize = True
        Me.lblFee.Location = New System.Drawing.Point(48, 84)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(52, 13)
        Me.lblFee.TabIndex = 2
        Me.lblFee.Text = "Total Fee"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(40, 141)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(146, 183)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblFee)
        Me.Controls.Add(Me.lblFeedisplay)
        Me.Controls.Add(Me.lblWeekend)
        Me.Controls.Add(Me.lblMember)
        Me.Controls.Add(Me.txtWeekend)
        Me.Controls.Add(Me.txtMember)
        Me.Name = "frmMain"
        Me.Text = "Golfing Fee Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMember As System.Windows.Forms.TextBox
    Friend WithEvents lblMember As System.Windows.Forms.Label
    Friend WithEvents txtWeekend As System.Windows.Forms.TextBox
    Friend WithEvents lblWeekend As System.Windows.Forms.Label
    Friend WithEvents lblFeedisplay As System.Windows.Forms.Label
    Friend WithEvents lblFee As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button

End Class
