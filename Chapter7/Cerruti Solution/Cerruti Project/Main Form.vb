' Name:         Cerruti Project
' Purpose:      Displays gross pay, taxes, and net pay
' Programmer:   Samuel Crumpler on 4/22/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' GetFwt function
    Private Function GetFwt(ByVal strMarital As String, ByVal intNumAllow As Integer, ByVal dblWeekPay As Double) As Double

        Const dblONE_ALLOW As Double = 73.08
        Dim dblTaxWages As Double
        Dim dblTax As Double

        dblTaxWages = dblWeekPay - intNumAllow * dblONE_ALLOW

        If strMarital = "S" Then
            Select Case dblTaxWages
                Case Is <= 41
                    dblTax = 0
                Case Is <= 209
                    dblTax = 0.1 * (dblTaxWages - 41)
                Case Is <= 721
                    dblTax = 16.8 + 0.15 * (dblTaxWages - 209)
                Case Is <= 1688
                    dblTax = 93.6 + 0.25 * (dblTaxWages - 721)
                Case Is <= 3477
                    dblTax = 335.35 + 0.28 * (dblTaxWages - 1688)
                Case Is <= 7510
                    dblTax = 836.27 + 0.33 * (dblTaxWages - 3477)
                Case Else
                    dblTax = 2167.16 + 0.35 * (dblTaxWages - 7510)
            End Select
        Else 'Marital = M
            Select Case dblTaxWages
                Case Is <= 156
                    dblTax = 0
                Case Is <= 490
                    dblTax = 0.1 * (dblTaxWages - 156)
                Case Is <= 1515
                    dblTax = 33.4 + 0.15 * (dblTaxWages - 490)
                Case Is <= 2900
                    dblTax = 187.15 + 0.25 * (dblTaxWages - 1515)
                Case Is <= 4338
                    dblTax = 533.4 + 0.28 * (dblTaxWages - 2900)
                Case Is <= 7624
                    dblTax = 936.04 + 0.33 * (dblTaxWages - 4338)
                Case Else
                    dblTax = 2020.42 + 0.35 * (dblTaxWages - 7624)
            End Select
        End If
        Return dblTax
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        ' select the existing text

        txtName.SelectAll()
    End Sub

    Private Sub cboAllowances_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboAllowances.KeyPress
        ' allow only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles lstHours.SelectedValueChanged,
        lstRates.SelectedValueChanged, radSingle.CheckedChanged, radMarried.CheckedChanged,
        txtName.TextChanged, cboAllowances.TextChanged

        lblGross.Text = String.Empty
        lblFwt.Text = String.Empty
        lblFica.Text = String.Empty
        lblNet.Text = String.Empty
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill list boxes and combo box with values
        ' then select a default value in each

        For dblHours As Double = 0 To 55 Step 0.5
            lstHours.Items.Add(dblHours.ToString("N1"))
        Next dblHours

        For dblRates As Double = 7.5 To 15.5 Step 0.5
            lstRates.Items.Add(dblRates.ToString("N2"))
        Next dblRates

        For intAllow As Integer = 0 To 10
            cboAllowances.Items.Add(intAllow.ToString)
        Next intAllow

        lstHours.SelectedItem = "40.0"
        lstRates.SelectedItem = "9.50"
        cboAllowances.SelectedIndex = 0
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Displays gross pay, taxes, and netpay

        Const dblFICA_RATE As Double = 0.0765
        Dim strStatus As String
        Dim dblHours As Double
        Dim dblPayRate As Double
        Dim intAllowances As Integer
        Dim dblFwt As Double
        Dim dblFica As Double
        Dim dblGross As Double

        dblHours = Convert.ToDouble(lstHours.SelectedItem.ToString)
        dblPayRate = Convert.ToDouble(lstRates.SelectedItem.ToString)
        intAllowances = Convert.ToInt32(cboAllowances.Text)

        If radSingle.Checked Then
            strStatus = "S"
        Else
            strStatus = "M"
        End If

        'calculate gross pay
        If dblHours <= 40 Then
            dblGross = dblHours * dblPayRate
        Else
            dblGross = 40 * dblPayRate + (dblHours - 40) * dblPayRate * 1.5
        End If

        'get the fwt
        dblFwt = GetFwt(strStatus, intAllowances, dblGross)

        ' Calculate FICA tax
        dblFica = dblGross * dblFICA_RATE

        'Observation Made: Without proper rounding the digits are specifically just cut off, and not rounded up
        'In doing so they may appear to be the correct amount, by they are in fact not the proper number

        'dblGross = Math.Round(dblGross, 2)
        'dblFwt = Math.Round(dblFwt, 2)
        'dblFica = Math.Round(dblFica, 2)

        lblGross.Text = dblGross.ToString
        lblFwt.Text = dblFwt.ToString
        lblFica.Text = dblFica.ToString
    End Sub
End Class
