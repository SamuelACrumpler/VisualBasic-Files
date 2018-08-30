'Name: Double Divide Solution
'Purpose: Takes a value, then divides it by two. The quotient is then displayed for the user.
'Programmer: Samuel Crumpler 4/19/2016


Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs
                       ) Handles txtNum.KeyPress

        ' allows the text box to accept only numbers and
        ' the Backspace key, as well as periods for decimal points

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            ' cancel the key
            e.Handled = True
        End If
    End Sub

    'Function that takes the number given, and divides by two.
    Private Sub DivideByTwo(dblNum As Double)
        'Create the variable needed
        Dim dblQuotient As Double
        'Perform the division, and push data into the double variable
        dblQuotient = dblNum / 2
        'Display finished quotient in the label box
        lblDisplay.Text = CStr(dblQuotient)
    End Sub


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'On click create a variable, then push the text box data into that variable.
        Dim dblNumParse As Double
        Double.TryParse(txtNum.Text, dblNumParse)
        'Call function with the variable as the parameter for the function
        Call DivideByTwo(dblNumParse)
    End Sub
End Class
