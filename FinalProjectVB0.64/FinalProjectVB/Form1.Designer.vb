<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lstDeck = New System.Windows.Forms.ListBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.lblEffect = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.lblSuit = New System.Windows.Forms.Label()
        Me.btnDeckCheck = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstDeck
        '
        Me.lstDeck.FormattingEnabled = True
        Me.lstDeck.Location = New System.Drawing.Point(356, 363)
        Me.lstDeck.Name = "lstDeck"
        Me.lstDeck.Size = New System.Drawing.Size(150, 43)
        Me.lstDeck.TabIndex = 11
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(369, 262)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(97, 13)
        Me.lblDesc.TabIndex = 6
        Me.lblDesc.Text = "Current Description"
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Location = New System.Drawing.Point(369, 230)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(81, 13)
        Me.lblPercent.TabIndex = 7
        Me.lblPercent.Text = "Current Percent"
        '
        'lblEffect
        '
        Me.lblEffect.AutoSize = True
        Me.lblEffect.Location = New System.Drawing.Point(369, 198)
        Me.lblEffect.Name = "lblEffect"
        Me.lblEffect.Size = New System.Drawing.Size(72, 13)
        Me.lblEffect.TabIndex = 8
        Me.lblEffect.Text = "Current Effect"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(369, 165)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(71, 13)
        Me.lblValue.TabIndex = 9
        Me.lblValue.Text = "Current Value"
        '
        'lblSuit
        '
        Me.lblSuit.AutoSize = True
        Me.lblSuit.Location = New System.Drawing.Point(369, 130)
        Me.lblSuit.Name = "lblSuit"
        Me.lblSuit.Size = New System.Drawing.Size(62, 13)
        Me.lblSuit.TabIndex = 10
        Me.lblSuit.Text = "Current Suit"
        '
        'btnDeckCheck
        '
        Me.btnDeckCheck.Location = New System.Drawing.Point(372, 426)
        Me.btnDeckCheck.Name = "btnDeckCheck"
        Me.btnDeckCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnDeckCheck.TabIndex = 4
        Me.btnDeckCheck.Text = "Deck Check"
        Me.btnDeckCheck.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(372, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Create Card"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 579)
        Me.Controls.Add(Me.lstDeck)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.lblEffect)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.lblSuit)
        Me.Controls.Add(Me.btnDeckCheck)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDeck As ListBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblPercent As Label
    Friend WithEvents lblEffect As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents lblSuit As Label
    Friend WithEvents btnDeckCheck As Button
    Friend WithEvents Button1 As Button
End Class
