'Name: Golfing Fee Project.
'Purpose: User will input information, and get the fee after hitting the calculate button.
'Programmer: Samuel Crumpler 3/1/2016


Option Explicit On
Option Strict On
Option Infer Off


Public Class frmMain
    'Declare the needed variable.
    Dim strDay As String
    Dim strStatus As String
    Dim intFee As Integer = 25

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Push the information from the text boxes into the Strings
        strDay = txtWeekend.Text
        strStatus = txtMember.Text
        'Check the strings for uppercase letters, then adjust price as needed.
        If strStatus = "N" Then
            If strDay = "W" Then
                intFee = 40
            ElseIf strDay = "E" Then
                intFee = 45
            End If
        End If
        'Display the fee in a currency format.
        lblFeedisplay.Text = intFee.ToString("C2")
    End Sub
End Class
