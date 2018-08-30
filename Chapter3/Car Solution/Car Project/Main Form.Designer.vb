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
        Me.lblLoan = New System.Windows.Forms.Label()
        Me.txtLoan = New System.Windows.Forms.TextBox()
        Me.lblInsurance = New System.Windows.Forms.Label()
        Me.txtInsur = New System.Windows.Forms.TextBox()
        Me.lblOil = New System.Windows.Forms.Label()
        Me.txtOil = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGas = New System.Windows.Forms.TextBox()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.txtMaintenance = New System.Windows.Forms.TextBox()
        Me.lblWash = New System.Windows.Forms.Label()
        Me.txtWash = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lneTotal = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lneExpense = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblCarExpen = New System.Windows.Forms.Label()
        Me.lblTotals = New System.Windows.Forms.Label()
        Me.lblMonthy = New System.Windows.Forms.Label()
        Me.lblAnnual = New System.Windows.Forms.Label()
        Me.lblMonthTotal = New System.Windows.Forms.Label()
        Me.lblAnnualTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLoan
        '
        Me.lblLoan.AutoSize = True
        Me.lblLoan.Location = New System.Drawing.Point(22, 72)
        Me.lblLoan.Name = "lblLoan"
        Me.lblLoan.Size = New System.Drawing.Size(78, 13)
        Me.lblLoan.TabIndex = 0
        Me.lblLoan.Text = "Loan Payment"
        '
        'txtLoan
        '
        Me.txtLoan.Location = New System.Drawing.Point(12, 92)
        Me.txtLoan.Name = "txtLoan"
        Me.txtLoan.Size = New System.Drawing.Size(100, 22)
        Me.txtLoan.TabIndex = 1
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Location = New System.Drawing.Point(11, 129)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(103, 13)
        Me.lblInsurance.TabIndex = 0
        Me.lblInsurance.Text = "Insurance Payment"
        '
        'txtInsur
        '
        Me.txtInsur.Location = New System.Drawing.Point(12, 149)
        Me.txtInsur.Name = "txtInsur"
        Me.txtInsur.Size = New System.Drawing.Size(100, 22)
        Me.txtInsur.TabIndex = 1
        '
        'lblOil
        '
        Me.lblOil.AutoSize = True
        Me.lblOil.Location = New System.Drawing.Point(30, 185)
        Me.lblOil.Name = "lblOil"
        Me.lblOil.Size = New System.Drawing.Size(65, 13)
        Me.lblOil.TabIndex = 0
        Me.lblOil.Text = "Oil Change"
        '
        'txtOil
        '
        Me.txtOil.Location = New System.Drawing.Point(12, 205)
        Me.txtOil.Name = "txtOil"
        Me.txtOil.Size = New System.Drawing.Size(100, 22)
        Me.txtOil.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(175, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Gas"
        '
        'txtGas
        '
        Me.txtGas.Location = New System.Drawing.Point(142, 205)
        Me.txtGas.Name = "txtGas"
        Me.txtGas.Size = New System.Drawing.Size(100, 22)
        Me.txtGas.TabIndex = 1
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Location = New System.Drawing.Point(156, 72)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(74, 13)
        Me.lblMain.TabIndex = 0
        Me.lblMain.Text = "Maintenance"
        '
        'txtMaintenance
        '
        Me.txtMaintenance.Location = New System.Drawing.Point(142, 92)
        Me.txtMaintenance.Name = "txtMaintenance"
        Me.txtMaintenance.Size = New System.Drawing.Size(100, 22)
        Me.txtMaintenance.TabIndex = 1
        '
        'lblWash
        '
        Me.lblWash.AutoSize = True
        Me.lblWash.Location = New System.Drawing.Point(157, 129)
        Me.lblWash.Name = "lblWash"
        Me.lblWash.Size = New System.Drawing.Size(67, 13)
        Me.lblWash.TabIndex = 0
        Me.lblWash.Text = "Car Washes"
        '
        'txtWash
        '
        Me.txtWash.Location = New System.Drawing.Point(142, 149)
        Me.txtWash.Name = "txtWash"
        Me.txtWash.Size = New System.Drawing.Size(100, 22)
        Me.txtWash.TabIndex = 1
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.lneTotal, Me.lneExpense})
        Me.ShapeContainer1.Size = New System.Drawing.Size(268, 418)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'lneTotal
        '
        Me.lneTotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lneTotal.Name = "lneTotal"
        Me.lneTotal.X1 = 52
        Me.lneTotal.X2 = 202
        Me.lneTotal.Y1 = 286
        Me.lneTotal.Y2 = 286
        '
        'lneExpense
        '
        Me.lneExpense.Name = "lneExpense"
        Me.lneExpense.X1 = 50
        Me.lneExpense.X2 = 200
        Me.lneExpense.Y1 = 55
        Me.lneExpense.Y2 = 55
        '
        'lblCarExpen
        '
        Me.lblCarExpen.AutoSize = True
        Me.lblCarExpen.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarExpen.Location = New System.Drawing.Point(44, 9)
        Me.lblCarExpen.Name = "lblCarExpen"
        Me.lblCarExpen.Size = New System.Drawing.Size(164, 32)
        Me.lblCarExpen.TabIndex = 3
        Me.lblCarExpen.Text = "Car Expenses"
        '
        'lblTotals
        '
        Me.lblTotals.AutoSize = True
        Me.lblTotals.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotals.Location = New System.Drawing.Point(44, 241)
        Me.lblTotals.Name = "lblTotals"
        Me.lblTotals.Size = New System.Drawing.Size(182, 32)
        Me.lblTotals.TabIndex = 3
        Me.lblTotals.Text = "Total Expenses"
        '
        'lblMonthy
        '
        Me.lblMonthy.AutoSize = True
        Me.lblMonthy.Location = New System.Drawing.Point(14, 304)
        Me.lblMonthy.Name = "lblMonthy"
        Me.lblMonthy.Size = New System.Drawing.Size(100, 13)
        Me.lblMonthy.TabIndex = 0
        Me.lblMonthy.Text = "Monthly Expenses"
        '
        'lblAnnual
        '
        Me.lblAnnual.AutoSize = True
        Me.lblAnnual.Location = New System.Drawing.Point(146, 304)
        Me.lblAnnual.Name = "lblAnnual"
        Me.lblAnnual.Size = New System.Drawing.Size(94, 13)
        Me.lblAnnual.TabIndex = 0
        Me.lblAnnual.Text = "Annual Expenses"
        '
        'lblMonthTotal
        '
        Me.lblMonthTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthTotal.Location = New System.Drawing.Point(12, 326)
        Me.lblMonthTotal.Name = "lblMonthTotal"
        Me.lblMonthTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblMonthTotal.TabIndex = 4
        '
        'lblAnnualTotal
        '
        Me.lblAnnualTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnnualTotal.Location = New System.Drawing.Point(142, 326)
        Me.lblAnnualTotal.Name = "lblAnnualTotal"
        Me.lblAnnualTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblAnnualTotal.TabIndex = 4
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 418)
        Me.Controls.Add(Me.lblAnnualTotal)
        Me.Controls.Add(Me.lblMonthTotal)
        Me.Controls.Add(Me.lblMonthy)
        Me.Controls.Add(Me.lblAnnual)
        Me.Controls.Add(Me.lblTotals)
        Me.Controls.Add(Me.lblCarExpen)
        Me.Controls.Add(Me.txtWash)
        Me.Controls.Add(Me.lblWash)
        Me.Controls.Add(Me.txtGas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMaintenance)
        Me.Controls.Add(Me.txtInsur)
        Me.Controls.Add(Me.txtOil)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.lblInsurance)
        Me.Controls.Add(Me.lblOil)
        Me.Controls.Add(Me.txtLoan)
        Me.Controls.Add(Me.lblLoan)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.Text = "Car Loan Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLoan As System.Windows.Forms.Label
    Friend WithEvents txtLoan As System.Windows.Forms.TextBox
    Friend WithEvents lblInsurance As System.Windows.Forms.Label
    Friend WithEvents txtInsur As System.Windows.Forms.TextBox
    Friend WithEvents lblOil As System.Windows.Forms.Label
    Friend WithEvents txtOil As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGas As System.Windows.Forms.TextBox
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents txtMaintenance As System.Windows.Forms.TextBox
    Friend WithEvents lblWash As System.Windows.Forms.Label
    Friend WithEvents txtWash As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lneTotal As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lneExpense As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblCarExpen As System.Windows.Forms.Label
    Friend WithEvents lblTotals As System.Windows.Forms.Label
    Friend WithEvents lblMonthy As System.Windows.Forms.Label
    Friend WithEvents lblAnnual As System.Windows.Forms.Label
    Friend WithEvents lblMonthTotal As System.Windows.Forms.Label
    Friend WithEvents lblAnnualTotal As System.Windows.Forms.Label

End Class
