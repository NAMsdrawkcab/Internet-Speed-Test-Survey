Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstSpeed.Items.Clear()
        lblAverage.Visible = False
        btnSpeed.Enabled = True
        btnSpeed.Focus()
        btnClear.Enabled = False
    End Sub

    Private Sub btnSpeed_Click(sender As Object, e As EventArgs) Handles btnSpeed.Click
        Dim strSpeed As String
        Dim decSpeed As Decimal
        Dim decSumOfSpeeds As Decimal
        Dim decAverage As Decimal = 0D

        Dim strIBoxMsg As String = "Enter the number of Mbps of your home Internet speed user #"
        Dim strIBoxNormalMsg As String = strIBoxMsg
        Dim strIBoxTitle As String = "Internet Speed"
        Dim strNotNumericErrMsg As String = "Error- Enter the speed of your home Internet Connection"
        Dim strNegErrMsg As String = "Error- Enter a valid speed"

        Dim intMaxEntries As Integer = 10
        Dim intEntries As Integer = 1

        strSpeed = InputBox(strIBoxMsg & intEntries, strIBoxTitle)

        Do Until intEntries > intMaxEntries Or strSpeed = ""
            If IsNumeric(strSpeed) Then
                decSpeed = Convert.ToDecimal(strSpeed)
                If decSpeed > 0 Then
                    lstSpeed.Items.Add(decSpeed)
                    decSumOfSpeeds += decSpeed
                    intEntries += 1
                    strIBoxMsg = strIBoxNormalMsg
                Else
                    strIBoxMsg = strNegErrMsg
                End If
            Else
                strIBoxMsg = strNotNumericErrMsg
            End If

            If intEntries <= intMaxEntries Then
                strSpeed = InputBox(strIBoxMsg & intEntries, strIBoxTitle)
            End If
        Loop

        lblAverage.Visible = True
        If intEntries > 1 Then
            decAverage = decSumOfSpeeds / (intEntries - 1)
            lblAverage.Text = "Average Internet Speed:  " & decAverage.ToString("F2") & " Mbps "
        Else
            lblAverage.Text = "No Speed Values Entered"
        End If
        btnSpeed.Enabled = False
        btnClear.Enabled = True
        btnClear.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstSpeed.Items.Clear()
        lblAverage.Visible = False
        btnSpeed.Enabled = True
        btnSpeed.Focus()
        btnClear.Enabled = False
    End Sub
End Class
