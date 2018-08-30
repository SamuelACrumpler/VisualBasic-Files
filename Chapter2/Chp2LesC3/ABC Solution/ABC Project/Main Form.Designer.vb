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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txtTotRev = New System.Windows.Forms.TextBox()
        Me.txtTotExp = New System.Windows.Forms.TextBox()
        Me.txtTotProfit = New System.Windows.Forms.TextBox()
        Me.lblTotRev = New System.Windows.Forms.Label()
        Me.lblTotExp = New System.Windows.Forms.Label()
        Me.lblTotProfit = New System.Windows.Forms.Label()
        Me.prtForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(268, 116)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(187, 116)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'txtTotRev
        '
        Me.txtTotRev.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotRev.Location = New System.Drawing.Point(187, 12)
        Me.txtTotRev.Name = "txtTotRev"
        Me.txtTotRev.Size = New System.Drawing.Size(156, 22)
        Me.txtTotRev.TabIndex = 2
        '
        'txtTotExp
        '
        Me.txtTotExp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotExp.Location = New System.Drawing.Point(187, 44)
        Me.txtTotExp.Name = "txtTotExp"
        Me.txtTotExp.Size = New System.Drawing.Size(156, 22)
        Me.txtTotExp.TabIndex = 2
        '
        'txtTotProfit
        '
        Me.txtTotProfit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotProfit.Location = New System.Drawing.Point(187, 75)
        Me.txtTotProfit.Name = "txtTotProfit"
        Me.txtTotProfit.Size = New System.Drawing.Size(156, 22)
        Me.txtTotProfit.TabIndex = 2
        '
        'lblTotRev
        '
        Me.lblTotRev.AutoSize = True
        Me.lblTotRev.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotRev.Location = New System.Drawing.Point(12, 15)
        Me.lblTotRev.Name = "lblTotRev"
        Me.lblTotRev.Size = New System.Drawing.Size(78, 13)
        Me.lblTotRev.TabIndex = 3
        Me.lblTotRev.Text = "Total Revenue"
        '
        'lblTotExp
        '
        Me.lblTotExp.AutoSize = True
        Me.lblTotExp.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotExp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotExp.Location = New System.Drawing.Point(12, 47)
        Me.lblTotExp.Name = "lblTotExp"
        Me.lblTotExp.Size = New System.Drawing.Size(81, 13)
        Me.lblTotExp.TabIndex = 3
        Me.lblTotExp.Text = "Total Expenses"
        '
        'lblTotProfit
        '
        Me.lblTotProfit.AutoSize = True
        Me.lblTotProfit.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotProfit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotProfit.Location = New System.Drawing.Point(12, 82)
        Me.lblTotProfit.Name = "lblTotProfit"
        Me.lblTotProfit.Size = New System.Drawing.Size(62, 13)
        Me.lblTotProfit.TabIndex = 3
        Me.lblTotProfit.Text = "Total Profit"
        '
        'prtForm
        '
        Me.prtForm.DocumentName = "document"
        Me.prtForm.Form = Me
        Me.prtForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.prtForm.PrinterSettings = CType(resources.GetObject("prtForm.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.prtForm.PrintFileName = Nothing
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 151)
        Me.Controls.Add(Me.lblTotProfit)
        Me.Controls.Add(Me.lblTotExp)
        Me.Controls.Add(Me.lblTotRev)
        Me.Controls.Add(Me.txtTotProfit)
        Me.Controls.Add(Me.txtTotExp)
        Me.Controls.Add(Me.txtTotRev)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClear)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABC Profit Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtTotRev As System.Windows.Forms.TextBox
    Friend WithEvents txtTotExp As System.Windows.Forms.TextBox
    Friend WithEvents txtTotProfit As System.Windows.Forms.TextBox
    Friend WithEvents lblTotRev As System.Windows.Forms.Label
    Friend WithEvents lblTotExp As System.Windows.Forms.Label
    Friend WithEvents lblTotProfit As System.Windows.Forms.Label
    Friend WithEvents prtForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
