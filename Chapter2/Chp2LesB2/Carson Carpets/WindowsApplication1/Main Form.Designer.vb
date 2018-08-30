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
        Me.lblAreaCalc = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtLengthNum = New System.Windows.Forms.TextBox()
        Me.txtWidthNum = New System.Windows.Forms.TextBox()
        Me.lblSquFeet = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCalcSquFeet = New System.Windows.Forms.Label()
        Me.lblCalcSquYards = New System.Windows.Forms.Label()
        Me.prtMainForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'lblAreaCalc
        '
        Me.lblAreaCalc.AutoSize = True
        Me.lblAreaCalc.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaCalc.Location = New System.Drawing.Point(106, 9)
        Me.lblAreaCalc.Name = "lblAreaCalc"
        Me.lblAreaCalc.Size = New System.Drawing.Size(163, 30)
        Me.lblAreaCalc.TabIndex = 0
        Me.lblAreaCalc.Text = "Area Calculator"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(12, 71)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(74, 13)
        Me.lblLength.TabIndex = 0
        Me.lblLength.Text = "&Length (Feet)"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWidth.Location = New System.Drawing.Point(12, 109)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(70, 13)
        Me.lblWidth.TabIndex = 4
        Me.lblWidth.Text = "&Width (Feet)"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(266, 103)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 15
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(266, 68)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 10
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(266, 172)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(266, 137)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtLengthNum
        '
        Me.txtLengthNum.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLengthNum.Location = New System.Drawing.Point(92, 68)
        Me.txtLengthNum.Name = "txtLengthNum"
        Me.txtLengthNum.Size = New System.Drawing.Size(106, 22)
        Me.txtLengthNum.TabIndex = 1
        '
        'txtWidthNum
        '
        Me.txtWidthNum.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWidthNum.Location = New System.Drawing.Point(92, 106)
        Me.txtWidthNum.Name = "txtWidthNum"
        Me.txtWidthNum.Size = New System.Drawing.Size(106, 22)
        Me.txtWidthNum.TabIndex = 5
        '
        'lblSquFeet
        '
        Me.lblSquFeet.AutoSize = True
        Me.lblSquFeet.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSquFeet.Location = New System.Drawing.Point(12, 143)
        Me.lblSquFeet.Name = "lblSquFeet"
        Me.lblSquFeet.Size = New System.Drawing.Size(100, 13)
        Me.lblSquFeet.TabIndex = 0
        Me.lblSquFeet.Text = "Area (Square Feet)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Area (Square Yards)"
        '
        'lblCalcSquFeet
        '
        Me.lblCalcSquFeet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcSquFeet.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalcSquFeet.Location = New System.Drawing.Point(118, 141)
        Me.lblCalcSquFeet.Name = "lblCalcSquFeet"
        Me.lblCalcSquFeet.Size = New System.Drawing.Size(80, 22)
        Me.lblCalcSquFeet.TabIndex = 0
        '
        'lblCalcSquYards
        '
        Me.lblCalcSquYards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcSquYards.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalcSquYards.Location = New System.Drawing.Point(118, 173)
        Me.lblCalcSquYards.Name = "lblCalcSquYards"
        Me.lblCalcSquYards.Size = New System.Drawing.Size(80, 22)
        Me.lblCalcSquYards.TabIndex = 0
        '
        'prtMainForm
        '
        Me.prtMainForm.DocumentName = "document"
        Me.prtMainForm.Form = Me
        Me.prtMainForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.prtMainForm.PrinterSettings = CType(resources.GetObject("prtMainForm.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.prtMainForm.PrintFileName = Nothing
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 261)
        Me.Controls.Add(Me.txtWidthNum)
        Me.Controls.Add(Me.txtLengthNum)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblSquFeet)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblCalcSquYards)
        Me.Controls.Add(Me.lblCalcSquFeet)
        Me.Controls.Add(Me.lblAreaCalc)
        Me.Name = "frmMain"
        Me.Text = "Carson Carpets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAreaCalc As System.Windows.Forms.Label
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtLengthNum As System.Windows.Forms.TextBox
    Friend WithEvents txtWidthNum As System.Windows.Forms.TextBox
    Friend WithEvents lblSquFeet As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCalcSquFeet As System.Windows.Forms.Label
    Friend WithEvents lblCalcSquYards As System.Windows.Forms.Label
    Friend WithEvents prtMainForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
