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
        Me.lblArea = New System.Windows.Forms.Label()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(12, 26)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(71, 13)
        Me.lblArea.TabIndex = 4
        Me.lblArea.Text = "A&rea Code(s)"
        '
        'cboArea
        '
        Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArea.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Location = New System.Drawing.Point(12, 42)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(121, 21)
        Me.cboArea.TabIndex = 5
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(179, 136)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(176, 26)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(33, 13)
        Me.lblState.TabIndex = 9
        Me.lblState.Text = "State"
        '
        'lblDisplay
        '
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplay.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(176, 43)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(100, 20)
        Me.lblDisplay.TabIndex = 10
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 172)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cboArea)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblArea)
        Me.Name = "frmMain"
        Me.Text = "Area Code Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents cboArea As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblDisplay As System.Windows.Forms.Label

End Class
