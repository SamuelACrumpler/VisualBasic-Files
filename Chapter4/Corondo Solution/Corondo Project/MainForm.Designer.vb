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
        Me.lblQuan = New System.Windows.Forms.Label()
        Me.txtQuanNumber = New System.Windows.Forms.TextBox()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.txtProductNumber = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblDiscountNum = New System.Windows.Forms.Label()
        Me.lblTotalNum = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblQuan
        '
        Me.lblQuan.AutoSize = True
        Me.lblQuan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuan.Location = New System.Drawing.Point(16, 11)
        Me.lblQuan.Name = "lblQuan"
        Me.lblQuan.Size = New System.Drawing.Size(100, 13)
        Me.lblQuan.TabIndex = 4
        Me.lblQuan.Text = "&Quantity Ordered:"
        '
        'txtQuanNumber
        '
        Me.txtQuanNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuanNumber.Location = New System.Drawing.Point(17, 27)
        Me.txtQuanNumber.Name = "txtQuanNumber"
        Me.txtQuanNumber.Size = New System.Drawing.Size(104, 22)
        Me.txtQuanNumber.TabIndex = 5
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.Location = New System.Drawing.Point(174, 11)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(77, 13)
        Me.lblProduct.TabIndex = 9
        Me.lblProduct.Text = "&Product Price:"
        '
        'txtProductNumber
        '
        Me.txtProductNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductNumber.Location = New System.Drawing.Point(172, 27)
        Me.txtProductNumber.Name = "txtProductNumber"
        Me.txtProductNumber.Size = New System.Drawing.Size(104, 22)
        Me.txtProductNumber.TabIndex = 10
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(172, 127)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(58, 13)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.Text = "Total Due:"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(22, 127)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(56, 13)
        Me.lblDiscount.TabIndex = 14
        Me.lblDiscount.Text = "Discount:"
        '
        'lblDiscountNum
        '
        Me.lblDiscountNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscountNum.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountNum.Location = New System.Drawing.Point(19, 143)
        Me.lblDiscountNum.Name = "lblDiscountNum"
        Me.lblDiscountNum.Size = New System.Drawing.Size(82, 23)
        Me.lblDiscountNum.TabIndex = 15
        '
        'lblTotalNum
        '
        Me.lblTotalNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalNum.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNum.Location = New System.Drawing.Point(172, 143)
        Me.lblTotalNum.Name = "lblTotalNum"
        Me.lblTotalNum.Size = New System.Drawing.Size(104, 23)
        Me.lblTotalNum.TabIndex = 20
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(63, 226)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(79, 26)
        Me.btnCalc.TabIndex = 25
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(144, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 26)
        Me.btnExit.TabIndex = 30
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtProductNumber)
        Me.Controls.Add(Me.lblTotalNum)
        Me.Controls.Add(Me.lblDiscountNum)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.txtQuanNumber)
        Me.Controls.Add(Me.lblQuan)
        Me.Name = "frmMain"
        Me.Text = "Corondo Discount Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuan As System.Windows.Forms.Label
    Friend WithEvents txtQuanNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblProduct As System.Windows.Forms.Label
    Friend WithEvents txtProductNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblDiscountNum As System.Windows.Forms.Label
    Friend WithEvents lblTotalNum As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
