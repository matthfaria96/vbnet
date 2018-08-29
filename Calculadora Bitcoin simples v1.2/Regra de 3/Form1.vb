Public Class Form1
    Private executar As Process

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        executar = Process.Start("calc.exe")
    End Sub

    Private Sub BlocoDeNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlocoDeNotasToolStripMenuItem.Click
        executar = Process.Start("notepad.exe")
    End Sub

    Private Sub PaintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaintToolStripMenuItem.Click
        executar = Process.Start("mspaint.exe")
    End Sub

    Private Sub CapturarTelaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturarTelaToolStripMenuItem.Click
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
            txt_valorx_1.Text = (txt_valor3_1.Text * txt_valor2_1.Text)
            txt_valorx_2.Text = ((txt_valor3_1.Text * txt_valor2_1.Text) - (txt_valor3_1.Text * txt_valor1_1.Text))
            txt_valorx_3.Text = ((txt_valor2_1.Text * 100) / txt_valor1_1.Text) - (100)
            Label19.Text = (txt_valor3_1.Text * txt_valor1_1.Text)
            If txt_valor1_1.Text < txt_valor2_1.Text Then
                Label3.Text = "Total de BTC em $$"
                Label3.ForeColor = Color.DarkGreen
                Label5.Text = "Ganho total em $$"
                Label5.ForeColor = Color.DarkGreen
                Label6.Text = "Ganho total em %"
                Label6.ForeColor = Color.DarkGreen
            Else
                Label3.Text = "Total de BTC em $$"
                Label3.ForeColor = Color.DarkRed
                Label5.Text = "Perda total em $$"
                Label5.ForeColor = Color.DarkRed
                Label6.Text = "Perda total em %"
                Label6.ForeColor = Color.DarkRed
            End If

        End If
    End Sub

    Private Sub btn_apagar1_Click(sender As Object, e As EventArgs) Handles btn_apagar1.Click
        txt_valor1_1.Text = ""
        txt_valor2_1.Text = ""
        txt_valor3_1.Text = ""
        txt_valorx_1.Text = "X"
        txt_valorx_2.Text = "Y"
        txt_valorx_3.Text = "Z"
        Label19.Text = "???"

        Label3.Text = "Total de BTC em $$"
        Label3.ForeColor = Color.DarkSlateGray

        Label5.Text = "Ganho / Prejuízo total em $$"
        Label5.ForeColor = Color.DarkSlateGray

        Label6.Text = "Ganho / Prejuízo total em %"
        Label6.ForeColor = Color.DarkSlateGray
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_valortotal_mais.Text = ""
        txt_aumento_mais.Text = ""
        txt_aumento.Text = "X"
        txt_ganho.Text = "Y"
    End Sub

    Private Sub btn_calcular_mais_Click(sender As Object, e As EventArgs) Handles btn_calcular_mais.Click
        If txt_valortotal_mais.Text = "" Or txt_aumento_mais.Text = "" Then
            MessageBox.Show("Preencha todos os valores!")
        Else
            txt_ganho.Text = ((txt_valortotal_mais.Text) * (txt_aumento_mais.Text / 100))
            txt_aumento.Text = ((txt_valortotal_mais.Text) * (txt_aumento_mais.Text / 100) + txt_valortotal_mais.Text)
        End If
    End Sub

    Private Sub txt_valortotal_mais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valortotal_mais.KeyPress
        If e.KeyChar = Chr(44) And InStr(txt_valortotal_mais.Text, ",") <> 0 Then
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

    Private Sub txt_aumento_mais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_aumento_mais.KeyPress
        If e.KeyChar = Chr(44) And InStr(txt_aumento_mais.Text, ",") <> 0 Then
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

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        txt_valortotal_menos.Text = ""
        txt_perda_menos.Text = ""
        txt_restante.Text = "X"
        txt_perda.Text = "Y"
    End Sub

    Private Sub btn_calcular_perda_Click(sender As Object, e As EventArgs)
        If txt_valortotal_menos.Text = "" Or txt_perda_menos.Text = "" Then
            MessageBox.Show("Preencha todos os valores!")
        Else
            txt_perda.Text = ((txt_valortotal_menos.Text) * (txt_perda_menos.Text / 100))
            txt_restante.Text = (txt_valortotal_menos.Text - (txt_valortotal_menos.Text) * (txt_perda_menos.Text / 100))
        End If
    End Sub

    Private Sub txt_valortotal_menos_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(44) And InStr(txt_valortotal_menos.Text, ",") <> 0 Then
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

    Private Sub txt_perda_menos_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(44) And InStr(txt_perda_menos.Text, ",") <> 0 Then
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

    Private Sub btn_calcular_perda_Click_1(sender As Object, e As EventArgs) Handles btn_calcular_perda.Click
        If txt_valortotal_menos.Text = "" Or txt_perda_menos.Text = "" Then
            MessageBox.Show("Preencha todos os valores!")
        Else
            txt_perda.Text = ((txt_valortotal_menos.Text) * (txt_perda_menos.Text / 100))
            txt_restante.Text = (txt_valortotal_menos.Text - (txt_valortotal_menos.Text) * (txt_perda_menos.Text / 100))
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        txt_valortotal_menos.Text = ""
        txt_perda_menos.Text = ""
        txt_restante.Text = "X"
        txt_perda.Text = "Y"
    End Sub

    Private Sub txt_valortotal_menos_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txt_valortotal_menos.KeyPress
        If e.KeyChar = Chr(44) And InStr(txt_valortotal_menos.Text, ",") <> 0 Then
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

    Private Sub txt_perda_menos_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txt_perda_menos.KeyPress
        If e.KeyChar = Chr(44) And InStr(txt_perda_menos.Text, ",") <> 0 Then
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
