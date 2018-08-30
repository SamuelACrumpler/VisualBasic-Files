' Name:         State ID Project
' Purpose:      Allows the user to type in a state ID, then automatically uppercase it after hitting the proper button.
' Programmer:   Samuel Crumpler on 2/23/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' displays the ID in uppercase
        lblUppercase.Text = txtState.Text.ToUpper
        txtState.Focus()
    End Sub

    Private Sub txtState_TextChanged(sender As Object, e As EventArgs) Handles txtState.TextChanged
        lblUppercase.Text = String.Empty

    End Sub

    Private Sub txtState_Click(sender As Object, e As EventArgs) Handles txtState.Click
        txtState.SelectAll()
    End Sub

    Private Sub txtState_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtState.KeyPress
        Dim numCheck As Boolean
        numCheck = IsNumeric(e.KeyChar)
        If numCheck = True Then
            ' Cancel the key
            e.Handled = True
        End If
    End Sub
End Class
