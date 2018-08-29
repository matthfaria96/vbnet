Public Class Form3

    Private Sub ReactorButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub ReactorButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReactorButton1.Click
        If ((UsernameTextBox.Text = "frankreich") And (PasswordTextBox.Text = "av1290dwap012olq841y1ip89i")) Then
            Form1.Show()
            Me.Close()
        Else
            Me.ErrorProvider1.SetError(Me.UsernameTextBox, "Username or password doesn't match!")
            MsgBox("Username or password doesn't match!")
        End If
    End Sub
End Class