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
        Me.txtPrime = New System.Windows.Forms.TextBox()
        Me.lblPrime = New System.Windows.Forms.Label()
        Me.txtComm = New System.Windows.Forms.TextBox()
        Me.lblComm = New System.Windows.Forms.Label()
        Me.lblCommBonus = New System.Windows.Forms.Label()
        Me.lblBonusCalc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPrime
        '
        Me.txtPrime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrime.Location = New System.Drawing.Point(12, 29)
        Me.txtPrime.Name = "txtPrime"
        Me.txtPrime.Size = New System.Drawing.Size(100, 22)
        Me.txtPrime.TabIndex = 0
        '
        'lblPrime
        '
        Me.lblPrime.AutoSize = True
        Me.lblPrime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrime.Location = New System.Drawing.Point(12, 13)
        Me.lblPrime.Name = "lblPrime"
        Me.lblPrime.Size = New System.Drawing.Size(90, 13)
        Me.lblPrime.TabIndex = 1
        Me.lblPrime.Text = "Prime Statement"
        '
        'txtComm
        '
        Me.txtComm.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComm.Location = New System.Drawing.Point(12, 74)
        Me.txtComm.Name = "txtComm"
        Me.txtComm.Size = New System.Drawing.Size(100, 22)
        Me.txtComm.TabIndex = 0
        '
        'lblComm
        '
        Me.lblComm.AutoSize = True
        Me.lblComm.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComm.Location = New System.Drawing.Point(12, 58)
        Me.lblComm.Name = "lblComm"
        Me.lblComm.Size = New System.Drawing.Size(69, 13)
        Me.lblComm.TabIndex = 1
        Me.lblComm.Text = "Commission"
        '
        'lblCommBonus
        '
        Me.lblCommBonus.AutoSize = True
        Me.lblCommBonus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommBonus.Location = New System.Drawing.Point(13, 110)
        Me.lblCommBonus.Name = "lblCommBonus"
        Me.lblCommBonus.Size = New System.Drawing.Size(105, 13)
        Me.lblCommBonus.TabIndex = 1
        Me.lblCommBonus.Text = "Commission Bonus"
        '
        'lblBonusCalc
        '
        Me.lblBonusCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBonusCalc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBonusCalc.Location = New System.Drawing.Point(12, 127)
        Me.lblBonusCalc.Name = "lblBonusCalc"
        Me.lblBonusCalc.Size = New System.Drawing.Size(100, 20)
        Me.lblBonusCalc.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(128, 166)
        Me.Controls.Add(Me.lblCommBonus)
        Me.Controls.Add(Me.lblBonusCalc)
        Me.Controls.Add(Me.lblComm)
        Me.Controls.Add(Me.lblPrime)
        Me.Controls.Add(Me.txtComm)
        Me.Controls.Add(Me.txtPrime)
        Me.Name = "frmMain"
        Me.Text = "Commission Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPrime As System.Windows.Forms.TextBox
    Friend WithEvents lblPrime As System.Windows.Forms.Label
    Friend WithEvents txtComm As System.Windows.Forms.TextBox
    Friend WithEvents lblComm As System.Windows.Forms.Label
    Friend WithEvents lblCommBonus As System.Windows.Forms.Label
    Friend WithEvents lblBonusCalc As System.Windows.Forms.Label

End Class
