Public Class CareerFair

    Dim counter As String

    Private Sub CareerFair_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'call function to get a clean form
        CleanForm()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (txtSID.ToString <> String.Empty) And IsNumeric(txtSID) And (txtSID.TextLength = 6) Then
            counter = "Auto"
            'call function to connect to database
            'function to send variables to print form
        Else
            counter = "Manual"
            My.Forms.CareerFair.Hide()
            My.Forms.ManualInformation.Text = Now.ToString()
            My.Forms.ManualInformation.Show()
            'My.Forms.CareerFair.Close()
        End If
    End Sub

    'Function to empty textbox
    Private Sub CleanForm()
        txtSID.Text = String.Empty
        btnRdUnknownSID.Checked = False
    End Sub

    'Function to call database

    'Function to send variables Print form

End Class

