' Name:         Shiloh Project
' Purpose:      Displays a 1% bonus
' Programmer:   Samuel Crumpler on 2/23/2016

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear screen for next calculation

        txtId.Text = String.Empty
        txtSales.Text = String.Empty
        lblBonus.Text = String.Empty
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' print the interface

        prtForm.PrintAction = Printing.PrintAction.PrintToPreview
        prtForm.Print()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Create the needed variables.
        Dim intSales As Integer
        Dim decBonus As Decimal
        'Use TryParse to convert string to number.
        Integer.TryParse(txtSales.Text, intSales)
        'Multiplying by 0.01 applies the 1% to the total sales
        decBonus = intSales * 0.01
        'Use ToString to covert the number to decimal, and currency form.
        lblBonus.Text = decBonus.ToString("C2")
    End Sub
End Class
