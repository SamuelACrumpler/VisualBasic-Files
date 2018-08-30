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
        Me.lblWord = New System.Windows.Forms.Label()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Location = New System.Drawing.Point(97, 44)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(36, 13)
        Me.lblWord.TabIndex = 0
        Me.lblWord.Text = "Empty"
        '
        'btnComplete
        '
        Me.btnComplete.Location = New System.Drawing.Point(53, 86)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(132, 23)
        Me.btnComplete.TabIndex = 1
        Me.btnComplete.Text = "Complete String"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnComplete)
        Me.Controls.Add(Me.lblWord)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnComplete As System.Windows.Forms.Button
    Private WithEvents lblWord As System.Windows.Forms.Label

End Class
