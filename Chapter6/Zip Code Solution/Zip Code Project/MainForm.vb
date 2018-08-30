' Name:         Zip Code Project
' Purpose:      Displays zip codes for the locations when they are selected.
' Programmer:   Samuel Crumpler on 2/23/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the program
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load all values into the list box
        lstCity.Items.Add("Park Ridge")
        lstCity.Items.Add("Barrington")
        lstCity.Items.Add("Glen Ellyn")
        lstCity.Items.Add("Algoquin")
        lstCity.Items.Add("Crystal Lake")
    End Sub

    Private Sub lstCity_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstCity.SelectedValueChanged
        'Create a string variable.
        Dim strCity As String
        'Push data into the string from the selected item.
        strCity = Convert.ToString(lstCity.SelectedItem)
        'Check the string variable for a matching case. Clear previous data, then add the new data as needed.
        'Cleared if user is able to select a value that does not exist within the list box.
        Select Case strCity
            Case "Park Ridge"
                lstZip.Items.Clear()
                lstZip.Items.Add("60068")
            Case "Barrington"
                lstZip.Items.Clear()
                lstZip.Items.Add("60010")
                lstZip.Items.Add("60011")
            Case "Glen Ellyn"
                lstZip.Items.Clear()
                lstZip.Items.Add("60137")
                lstZip.Items.Add("60138")
            Case "Algoquin"
                lstZip.Items.Clear()
                lstZip.Items.Add("60102")
            Case "Crystal Lake"
                lstZip.Items.Clear()
                lstZip.Items.Add("60012")
            Case Else
                lstZip.Items.Clear()
        End Select
    End Sub
End Class
