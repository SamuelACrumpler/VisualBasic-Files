'Name: Corondo Project
'Purpose: Corondo program for calculating discounts for sold products.
'Programmer: Samuel Crumpler 3/1/2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    'Create needed variables for the program.
    Dim intQuan As Integer
    Dim decProd As Decimal
    Dim dlgWhole As DialogResult
    'Store values after being typed in. Clear labels when user types in the boxes.
    Private Sub txtQuanNumber_TextChanged(sender As Object, e As EventArgs) Handles txtQuanNumber.TextChanged, txtProductNumber.TextChanged
        Integer.TryParse(txtQuanNumber.Text, intQuan)
        Decimal.TryParse(txtProductNumber.Text, decProd)
        lblDiscountNum.Text = ""
        lblTotalNum.Text = ""
    End Sub
    'On button click, ask user if they are a wholesaler or not. If so add a 10% discount to the sales price.
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        dlgWhole = MessageBox.Show("Is the buyer a wholesaler?", "Wholesaler", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgWhole = Windows.Forms.DialogResult.Yes Then
            lblDiscountNum.Text = "10%"
            lblTotalNum.Text = CStr((decProd * intQuan) * 0.9)
        Else
            dlgWhole = Windows.Forms.DialogResult.No
            lblDiscountNum.Text = "0%"
            lblTotalNum.Text = CStr(decProd * intQuan)
        End If
    End Sub
    'Button closes program.
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
