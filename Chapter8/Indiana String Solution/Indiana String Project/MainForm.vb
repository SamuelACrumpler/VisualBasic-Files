'Name: Indiana String Solution
'Purpose: Displays a string in a label, then adds characters to that string when the user presses the "Complete String" button.
'Programmer: Samuel Crumpler 4/22/2016


Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    'Define String
    Dim strWord As String = "In"

    'Upon loading, load the variable string into the label.
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWord.Text = strWord
    End Sub

    'When the button is pressed, insert characters.
    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        lblWord.Text = strWord.Insert(2, "diana")
    End Sub

End Class
