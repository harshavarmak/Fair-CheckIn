Public Class ManualInformation
    Private Sub ManualInformation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call function to get clean form
        CleanForm()
    End Sub

    'Function to get a clean form
    Private Sub CleanForm()
        txtFirstName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtMajor.Text = String.Empty
        txtMinor.Text = String.Empty
        btnRdYes.Checked = False
        btnRdNo.Checked = False
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Send variable data to print form

    End Sub
End Class