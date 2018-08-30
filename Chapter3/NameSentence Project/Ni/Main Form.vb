' Name:         Name Sentence Project
' Purpose:      Creates a sentence using a combination of strings.
' Programmer:   Samuel Crumpler on 2/23/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Create all strings that are needed.
        Dim StrFirst As String = "Karl"
        Dim StrLast As String = "Perrilo"
        Dim StrMiddle As String = "G"
        Dim StrNickname As String = "KG"
        'Combine all strings into one string.
        Dim StrStatement As String = "My name is " + StrFirst + " " + StrMiddle + ". " + StrLast + ", but you can call me " + StrNickname + "."
        'Push the combined string into the label.
        lblStatement.Text = StrStatement
    End Sub
End Class
