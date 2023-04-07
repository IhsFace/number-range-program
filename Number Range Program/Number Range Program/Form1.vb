Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim number As Integer = CInt(txtInputNbr.Text)

        Select Case number
            Case 1 To 5
                txtOutputResult.Text = ("Between 1 and 5 inclusive")
            Case 6, 7, 8
                txtOutputResult.Text = ("Between 6 and 8 inclusive")
            Case 9 To 10
                txtOutputResult.Text = ("Equal to 9 or 10")
            Case Else
                txtOutputResult.Text = ("Not between 1 and 10 inclusive")
        End Select
    End Sub
End Class
