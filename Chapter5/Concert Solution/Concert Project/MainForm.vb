'Name: Concert Project
'Purpose: Allow users to input various ticket types, then calculate the price for the different tickets.
'Programmer: Samuel Crumpler 3/1/2016


Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs
                           ) Handles txtBox.KeyPress, txtGarden.KeyPress,
                       txtPav.KeyPress
        ' allows the text box to accept only numbers and
        ' the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            ' cancel the key
            e.Handled = True
        End If
    End Sub
    'Makes boxes visible upon being checked.
    'If the box is checked, the text box will appear
    'If the box is unchecked, it'll become invisible and clear the box.
    Private Sub chkBox_CheckedChanged(sender As Object, e As EventArgs) Handles chkBox.CheckedChanged
        If txtBox.Visible = False Then
            txtBox.Visible = True
        Else
            txtBox.Visible = False
            txtBox.Text = String.Empty
        End If
    End Sub

    Private Sub chkPav_CheckedChanged(sender As Object, e As EventArgs) Handles chkPav.CheckedChanged
        If txtPav.Visible = False Then
            txtPav.Visible = True
        Else
            txtPav.Visible = False
            txtPav.Text = String.Empty
        End If
    End Sub

    Private Sub chkGarden_CheckedChanged(sender As Object, e As EventArgs) Handles chkGarden.CheckedChanged
        If txtGarden.Visible = False Then
            txtGarden.Visible = True
        Else
            txtGarden.Visible = False
            txtGarden.Text = String.Empty
        End If
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Prices for the different tickets.
        Const intBOX_PRICE As Integer = 75
        Const intPAV_PRICE As Integer = 30
        Const intGARDEN_PRICE As Integer = 21
        'Declaring needed variables.
        Dim intBox As Integer
        Dim intPav As Integer
        Dim intGarden As Integer
        Dim intTotalTickets As Integer
        Dim intTotalDue As Integer
        'Push values from the text boxes into variables.
        Integer.TryParse(txtBox.Text, intBox)
        Integer.TryParse(txtPav.Text, intPav)
        Integer.TryParse(txtGarden.Text, intGarden)
        'Calculate the amount due by adding the ticket prices with the amount of tickets purchased.
        intTotalDue = (intBox * intBOX_PRICE) + (intPav * intPAV_PRICE) + (intGarden * intGARDEN_PRICE)
        'Add together all the tickets.
        intTotalTickets = intBox + intPav + intGarden
        'Push total tickets into a string
        lblTotalTickets.Text = CStr(intTotalTickets)
        'display the total amount due with the format for USD.
        lblTotalDue.Text = intTotalDue.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close Program
        Me.Close()
    End Sub
End Class
