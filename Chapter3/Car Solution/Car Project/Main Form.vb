'Name: Car Expense Project
'Purpose: Calculate monthly and yearly expenses
'Programmer: Samuel Crumpler 2/23/2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain



    Private Sub txtLoan_TextChanged(sender As Object, e As EventArgs) Handles txtLoan.TextChanged, txtInsur.TextChanged, txtOil.TextChanged, txtMaintenance.TextChanged, txtWash.TextChanged, txtGas.TextChanged
        'Define all decimals.
        Dim decLoan As Decimal
        Dim decInsur As Decimal
        Dim decOil As Decimal
        Dim decMaintenance As Decimal
        Dim decWash As Decimal
        Dim decGas As Decimal
        'Convert all text strings into decimal form
        Decimal.TryParse(txtLoan.Text, decLoan)
        Decimal.TryParse(txtInsur.Text, decInsur)
        Decimal.TryParse(txtOil.Text, decOil)
        Decimal.TryParse(txtMaintenance.Text, decMaintenance)
        Decimal.TryParse(txtWash.Text, decWash)
        Decimal.TryParse(txtGas.Text, decGas)
        'Add all expenses together. *12 for annual after addition has occurred to account for 12 months.
        lblMonthTotal.Text = CStr(decLoan + decInsur + decOil + decMaintenance + decWash + decGas)
        lblAnnualTotal.Text = CStr((decLoan + decInsur + decOil + decMaintenance + decWash + decGas) * 12)

    End Sub
End Class
