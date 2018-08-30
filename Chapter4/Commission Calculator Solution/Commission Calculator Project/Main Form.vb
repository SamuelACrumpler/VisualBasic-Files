' Name:         Commission Calculator Project
' Purpose:      Calculates Commission based on if the word "Prime" is written in the text box.
' Programmer:   Samuel Crumpler on 2/23/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub txtPrime_TextChanged(sender As Object, e As EventArgs) Handles txtPrime.TextChanged, txtComm.TextChanged
        'Store Values
        Dim StrPrime As String
        Dim dblBonus As Double
        'Uppercase and push string into a variable
        StrPrime = txtPrime.Text.ToUpper
        'Turn Commission Text box into a number
        Double.TryParse(txtComm.Text, dblBonus)
        'If statement that checks for uppercase Prime, then adjust commission accordingly.
        If StrPrime = "PRIME" Then
            lblBonusCalc.Text = CStr(dblBonus * 0.02)
        Else
            lblBonusCalc.Text = CStr(dblBonus * 0.025)
        End If
    End Sub
End Class
