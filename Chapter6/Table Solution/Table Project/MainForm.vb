Public Class frmMain
    Dim intRow As Integer
    Dim intNum2 As Integer
    Dim intNum3 As Integer
    Dim intNum4 As Integer
    Dim intNum5 As Integer

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Use intRow to run the for loop. 1 through 5.
        'Multiply intRow by 2, 3, 4, and 5
        For intRow As Integer = 1 To 5
            intNum2 = intRow * 2
            intNum3 = intRow * 3
            intNum4 = intRow * 4
            intNum5 = intRow * 5
            'Insert information for the line. intRow * the respected number. Create a newline.
            txtTable.Text = txtTable.Text & intRow & ControlChars.Tab & intNum2 & ControlChars.Tab & intNum3 & ControlChars.Tab & intNum4 & ControlChars.Tab & intNum5 & vbNewLine
        Next
    End Sub
End Class
