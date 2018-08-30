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
        Me.txtTable = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtTable
        '
        Me.txtTable.AcceptsReturn = True
        Me.txtTable.AcceptsTab = True
        Me.txtTable.Location = New System.Drawing.Point(9, 24)
        Me.txtTable.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTable.Multiline = True
        Me.txtTable.Name = "txtTable"
        Me.txtTable.ReadOnly = True
        Me.txtTable.Size = New System.Drawing.Size(288, 165)
        Me.txtTable.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 206)
        Me.Controls.Add(Me.txtTable)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmMain"
        Me.Text = "Table Project"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents txtTable As System.Windows.Forms.TextBox

End Class
