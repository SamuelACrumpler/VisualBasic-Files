Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculates area for square feet
        lblCalcSquFeet.Text = Val(txtLengthNum.Text) * Val(txtWidthNum.Text)
        lblCalcSquYards.Text = Val(txtLengthNum.Text) * Val(txtWidthNum.Text) / 9
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear all fields

        txtLengthNum.Text = ""
        txtWidthNum.Text = ""
        lblCalcSquFeet.Text = ""
        lblCalcSquYards.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'closes the program
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'prints the form
        prtMainForm.Print()
    End Sub
End Class
