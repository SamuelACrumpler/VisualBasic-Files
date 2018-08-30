Public Class frmMain


    'Handles the process of converting the numbers
    Private Sub txtTotRev_TextChanged(sender As Object, e As EventArgs) Handles txtTotRev.TextChanged, txtTotExp.TextChanged
        'Revune subtracted by profit
        txtTotProfit.Text = Val(txtTotRev.Text) - Val(txtTotExp.Text)
        'Convert value into currency
        txtTotProfit.Text = Format(txtTotProfit.Text, "currency")
    End Sub
    'Clears by forcing values to equal empty strings'
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTotExp.Text = ""
        txtTotRev.Text = ""
        txtTotProfit.Text = ""
    End Sub
    'Uses prints using PrintToPreview
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        prtForm.Print()
    End Sub
End Class
