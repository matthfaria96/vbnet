Public Class Form1
    Private executar As Process

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs)
        executar = Process.Start("calc.exe")
    End Sub

    Private Sub BlocoDeNotasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        executar = Process.Start("notepad.exe")
    End Sub

    Private Sub PaintToolStripMenuItem_Click(sender As Object, e As EventArgs)
        executar = Process.Start("mspaint.exe")
    End Sub

    Private Sub CapturarTelaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Not Environment.Is64BitProcess Then
            Process.Start("C:\Windows\sysnative\SnippingTool.exe")
        Else
            Process.Start("C:\Windows\system32\SnippingTool.exe")
        End If
    End Sub

    Private Sub btn_calcular1_Click(sender As Object, e As EventArgs) Handles btn_calcular1.Click
        If txt_valor1_1.Text = "" Or txt_valor2_1.Text = "" Or txt_valor3_1.Text = "" Then
            MessageBox.Show("Preencha todos os valores!")
        Else
            txt_valorx_1.Text = ((txt_valor3_1.Text * txt_valor2_1.Text) / txt_valor1_1.Text)
        End If
    End Sub

    Private Sub btn_apagar1_Click(sender As Object, e As EventArgs) Handles btn_apagar1.Click
        txt_valor1_1.Text = ""
        txt_valor2_1.Text = ""
        txt_valor3_1.Text = ""
        txt_valorx_1.Text = "X"
    End Sub

    Private Sub txt_valor1_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor1_1.KeyPress
        If e.KeyChar = Chr(44) And InStr(txt_valor1_1.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If

        If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
            Exit Sub
        End If

        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_valor2_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor2_1.KeyPress
        If e.KeyChar = Chr(44) And InStr(txt_valor2_1.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If

        If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
            Exit Sub
        End If

        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_valor3_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor3_1.KeyPress
        If e.KeyChar = Chr(44) And InStr(txt_valor3_1.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If

        If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
            Exit Sub
        End If

        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txt_valor1_2.Text = "" Or txt_valor2_2.Text = "" Or txt_valor3_2.Text = "" Then
            MessageBox.Show("Preencha todos os valores!")
        Else
            txt_valorx_2.Text = ((txt_valor3_2.Text * txt_valor2_2.Text) / txt_valor1_2.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txt_valor1_2.Text = ""
        txt_valor2_2.Text = ""
        txt_valor3_2.Text = ""
        txt_valorx_2.Text = "X"
    End Sub

    Private Sub txt_valor1_2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor1_2.KeyPress
        If e.KeyChar = Chr(44) And InStr(txt_valor1_2.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If

        If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
            Exit Sub
        End If

        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_valor2_2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor2_2.KeyPress
        If e.KeyChar = Chr(44) And InStr(txt_valor2_2.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If

        If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
            Exit Sub
        End If

        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_valor3_2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor3_2.KeyPress
        If e.KeyChar = Chr(44) And InStr(txt_valor3_2.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If

        If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
            Exit Sub
        End If

        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_calcular3_Click(sender As Object, e As EventArgs) Handles btn_calcular3.Click
        If txt_valor1_3.Text = "" Or txt_valor2_3.Text = "" Or txt_valor3_3.Text = "" Then
            MessageBox.Show("Preencha todos os valores!")
        Else
            txt_valorx_3.Text = ((txt_valor3_3.Text * txt_valor2_3.Text) / txt_valor1_3.Text)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txt_valor1_3.Text = ""
        txt_valor2_3.Text = ""
        txt_valor3_3.Text = ""
        txt_valorx_3.Text = "X"
    End Sub

    Private Sub txt_valor1_3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor1_3.KeyPress
        If e.KeyChar = Chr(44) And InStr(txt_valor1_3.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If

        If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
            Exit Sub
        End If

        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_valor2_3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor2_3.KeyPress
        If e.KeyChar = Chr(44) And InStr(txt_valor2_3.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If

        If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
            Exit Sub
        End If

        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_valor3_3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor3_3.KeyPress
        If e.KeyChar = Chr(44) And InStr(txt_valor3_3.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If

        If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
            Exit Sub
        End If

        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If txt_valor1_4.Text = "" Or txt_valor2_4.Text = "" Or txt_valor3_4.Text = "" Then
            MessageBox.Show("Preencha todos os valores!")
        Else
            txt_valorx_4.Text = ((txt_valor3_4.Text * txt_valor2_4.Text) / txt_valor1_4.Text)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txt_valor1_4.Text = ""
        txt_valor2_4.Text = ""
        txt_valor3_4.Text = ""
        txt_valorx_4.Text = "X"
    End Sub

    Private Sub txt_valor1_4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor1_4.KeyPress
        If e.KeyChar = Chr(44) And InStr(txt_valor1_4.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If

        If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
            Exit Sub
        End If

        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_valor2_4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor2_4.KeyPress
        If e.KeyChar = Chr(44) And InStr(txt_valor2_4.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If

        If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
            Exit Sub
        End If

        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_valor3_4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor3_4.KeyPress
        If e.KeyChar = Chr(44) And InStr(txt_valor3_4.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If

        If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
            Exit Sub
        End If

        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
