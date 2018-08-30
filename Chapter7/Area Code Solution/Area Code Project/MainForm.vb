'Name: Area Code Solution
'Purpose: Allows the user to pick an area code, then display a state based on that area code.
'Programmer: Samuel Crumpler 4/19/2016


Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add and label all area codes.
        'California
        cboArea.Items.Add(209)
        'Alabama
        cboArea.Items.Add(205)
        'Arkansas
        cboArea.Items.Add(501)
        'Arizona
        cboArea.Items.Add(602)
        'Colorado
        cboArea.Items.Add(303)
    End Sub

    Private Sub cboArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboArea.SelectedIndexChanged
        'Create integer variable, then push the values from the combo box into the integer.
        Dim intArea As Integer
        intArea = CInt(cboArea.SelectedItem)
        'Display state based on the area code that is selected
        Select Case intArea
            Case 209
                lblDisplay.Text = "California"
            Case 205
                lblDisplay.Text = "Alabama"
            Case 501
                lblDisplay.Text = "Arkansas"
            Case 602
                lblDisplay.Text = "Arizona"
            Case 303
                lblDisplay.Text = "Colorado"
            Case Else
                lblDisplay.Text = String.Empty
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close program
        Me.Close()
    End Sub
End Class
