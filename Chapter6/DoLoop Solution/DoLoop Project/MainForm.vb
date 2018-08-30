'Name: Do Loop Project
'Purpose: Infinite Loop that increases the number of integer infinitely.
'Programmer: Samuel Crumpler 3/22/2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intNum As Integer = 1
        '<alternateloop>
        ' Do While intNum > 0
        'intNum = intNum + 1
        'lblDisplay.Text = intNum
        'Loop
        '</alternateloop>
        Do
            intNum = intNum + 1
            lblDisplay.Text = CStr(intNum)
        Loop Until intNum = 0

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs)

    End Sub
End Class
