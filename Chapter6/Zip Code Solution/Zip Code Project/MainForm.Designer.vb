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
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lstCity = New System.Windows.Forms.ListBox()
        Me.lstZip = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(17, 23)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(29, 13)
        Me.lblCity.TabIndex = 4
        Me.lblCity.Text = "&City:"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZip.Location = New System.Drawing.Point(168, 26)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(66, 13)
        Me.lblZip.TabIndex = 9
        Me.lblZip.Text = "ZIP Code(s):"
        '
        'lstCity
        '
        Me.lstCity.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCity.FormattingEnabled = True
        Me.lstCity.Location = New System.Drawing.Point(15, 42)
        Me.lstCity.Name = "lstCity"
        Me.lstCity.Size = New System.Drawing.Size(120, 147)
        Me.lstCity.TabIndex = 5
        '
        'lstZip
        '
        Me.lstZip.BackColor = System.Drawing.SystemColors.Info
        Me.lstZip.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstZip.FormattingEnabled = True
        Me.lstZip.Location = New System.Drawing.Point(166, 42)
        Me.lstZip.Name = "lstZip"
        Me.lstZip.Size = New System.Drawing.Size(120, 95)
        Me.lstZip.TabIndex = 10
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(183, 155)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 34)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 213)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lstZip)
        Me.Controls.Add(Me.lstCity)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblCity)
        Me.Name = "frmMain"
        Me.Text = "Zip Code Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents lstCity As System.Windows.Forms.ListBox
    Friend WithEvents lstZip As System.Windows.Forms.ListBox
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
