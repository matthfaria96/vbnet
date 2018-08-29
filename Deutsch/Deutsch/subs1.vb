Public Class subs1

    Private Sub Picturebox1_Click(sender As Object, e As EventArgs) Handles Picturebox1.Click
        If local.Text = "[01/20]" Then
            MessageBox.Show("Você está no exercício [01/20], clique na seta da direita para avançar")
            Label8.Text = "Endereço"

        ElseIf local.Text = "[02/20]" Then
            local.Text = "[01/20]"
            Label8.Text = "Endereço"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[03/20]" Then
            local.Text = "[02/20]"
            Label8.Text = "Idade"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[04/20]" Then
            local.Text = "[03/20]"
            Label8.Text = "Resposta"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[05/20]" Then
            local.Text = "[04/20]"
            Label8.Text = "Médico / Médica"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.White
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.White
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.White
            ComboBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True

        ElseIf local.Text = "[06/20]" Then
            local.Text = "[05/20]"
            Label8.Text = "Exterior"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[07/20]" Then
            local.Text = "[06/20]"
            Label8.Text = "Estrangeiro / Estrangeira"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.White
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.White
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.White
            ComboBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True

        ElseIf local.Text = "[08/20]" Then
            local.Text = "[07/20]"
            Label8.Text = "Banco"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[09/20]" Then
            local.Text = "[08/20]"
            Label8.Text = "Profissão"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[10/20]" Then
            local.Text = "[09/20]"
            Label8.Text = "Quadro; Foto; Imagem"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[11/20]" Then
            local.Text = "[10/20]"
            Label8.Text = "Livro"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[12/20]" Then
            local.Text = "[11/20]"
            Label8.Text = "Letra"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[13/20]" Then
            local.Text = "[12/20]"
            Label8.Text = "Alemão (idioma)"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[14/20]" Then
            local.Text = "[13/20]"
            Label8.Text = "Alemanha"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[15/20]" Then
            local.Text = "[14/20]"
            Label8.Text = "Diálogo"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[16/20]" Then
            local.Text = "[15/20]"
            Label8.Text = "Nº ramal (forma reduzida)"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[17/20]" Then
            local.Text = "[16/20]"
            Label8.Text = "Nº ramal (forma plena)"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[18/20]" Then
            local.Text = "[17/20]"
            Label8.Text = "Engenharia elétrica"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[19/20]" Then
            local.Text = "[18/20]"
            Label8.Text = "Engenheiro(a)/Técnico(a) elétrico"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.White
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.White
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.White
            ComboBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True

        ElseIf local.Text = "[20/20]" Then
            local.Text = "[19/20]"
            Label8.Text = "Pais (pai e mãe)"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        End If
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs)
        Picturebox1.Size = New Size(40, 40)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs)
        Picturebox1.Size = New Size(51, 52)
    End Sub

    Private Sub Picturebox2_Click(sender As Object, e As EventArgs) Handles Picturebox2.Click

        If local.Text = "[01/20]" Then
            local.Text = "[02/20]"
            Label8.Text = "Idade"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[02/20]" Then
            local.Text = "[03/20]"
            Label8.Text = "Resposta"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[03/20]" Then
            local.Text = "[04/20]"
            Label8.Text = "Médico / Médica"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.White
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.White
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.White
            ComboBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True

        ElseIf local.Text = "[04/20]" Then
            local.Text = "[05/20]"
            Label8.Text = "Exterior"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[05/20]" Then
            local.Text = "[06/20]"
            Label8.Text = "Estrangeiro /Estrangeira"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.White
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.White
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.White
            ComboBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True

        ElseIf local.Text = "[06/20]" Then
            local.Text = "[07/20]"
            Label8.Text = "Banco"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[07/20]" Then
            local.Text = "[08/20]"
            Label8.Text = "Profissão"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[08/20]" Then
            local.Text = "[09/20]"
            Label8.Text = "Quadro; Foto; Imagem"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[09/20]" Then
            local.Text = "[10/20]"
            Label8.Text = "Livro"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[10/20]" Then
            local.Text = "[11/20]"
            Label8.Text = "Letra"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[11/20]" Then
            local.Text = "[12/20]"
            Label8.Text = "Alemão (idioma)"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[12/20]" Then
            local.Text = "[13/20]"
            Label8.Text = "Alemanha"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[13/20]" Then
            local.Text = "[14/20]"
            Label8.Text = "Diálogo"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[14/20]" Then
            local.Text = "[15/20]"
            Label8.Text = "Nº ramal (forma reduzida)"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[15/20]" Then
            local.Text = "[16/20]"
            Label8.Text = "Nº ramal (forma plena)"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[16/20]" Then
            local.Text = "[17/20]"
            Label8.Text = "Engenharia elétrica"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[17/20]" Then
            local.Text = "[18/20]"
            Label8.Text = "Engenheiro(a)/Técnico(a) elétrico"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.White
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.White
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.White
            ComboBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True

        ElseIf local.Text = "[18/20]" Then
            local.Text = "[19/20]"
            Label8.Text = "Pais (pai e mãe)"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[19/20]" Then
            local.Text = "[20/20]"
            Label8.Text = "E-mail"

            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
            ComboBox1.BackColor = Color.White
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.BackColor = Color.White
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.BackColor = Color.White

            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
            ComboBox2.BackColor = Color.Gainsboro
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.Gainsboro
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.Gainsboro
            ComboBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False

        ElseIf local.Text = "[20/20]" Then
            MessageBox.Show("Parabéns! Você terminou todos os exercícios, vá para o menu para mais exercícios")
            Label8.Text = "E-mail"

        End If
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs)
        Picturebox2.Size = New Size(40, 40)
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs)
        Picturebox2.Size = New Size(51, 52)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ComboBox1.Text = ""
        ComboBox1.ForeColor = Color.Black
        ComboBox1.BackColor = Color.White

        ComboBox2.Text = ""
        ComboBox2.ForeColor = Color.Black
        ComboBox2.BackColor = Color.White

        TextBox1.Text = ""
        TextBox1.ForeColor = Color.Black
        TextBox1.BackColor = Color.White

        TextBox2.Text = ""
        TextBox2.ForeColor = Color.Black
        TextBox2.BackColor = Color.White

        If TextBox3.Enabled = False Then
            TextBox3.Text = ""
        Else
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.White
        End If

        If TextBox4.Enabled = False Then
            TextBox4.Text = ""
        Else
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.White
        End If
    End Sub

    Private Sub EffectualButtonBlue1_Click_1(sender As Object, e As EventArgs) Handles EffectualButtonBlue1.Click
        If local.Text = "[01/20]" Then
            If ComboBox1.Text = "F" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToUpper = "ADRESSE" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToUpper = "ADRESSEN" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[02/20]" Then
            If ComboBox1.Text = "N" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToUpper = "ALTER" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToUpper = "ALTER" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[03/20]" Then
            If ComboBox1.Text = "F" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToUpper = "ANTWORT" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToUpper = "ANTWORTEN" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[04/20]" Then
            If ComboBox1.Text = "M" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If ComboBox2.Text = "F" Then
                ComboBox2.ForeColor = Color.White
                ComboBox2.BackColor = Color.Green
            Else
                ComboBox2.ForeColor = Color.Black
                ComboBox2.BackColor = Color.Red
            End If

            If TextBox1.Text.ToUpper = "ARZT" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToUpper = "ÄRZTE" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If

            If TextBox3.Text.ToUpper = "ÄRZTIN" Then
                TextBox3.ForeColor = Color.White
                TextBox3.BackColor = Color.Green
            Else
                TextBox3.ForeColor = Color.Black
                TextBox3.BackColor = Color.Red
            End If

            If TextBox4.Text.ToUpper = "ÄRZTINNEN" Then
                TextBox4.ForeColor = Color.White
                TextBox4.BackColor = Color.Green
            Else
                TextBox4.ForeColor = Color.Black
                TextBox4.BackColor = Color.Red
            End If
        End If

        If local.Text = "[05/20]" Then
            If ComboBox1.Text = "N" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToUpper = "AUSLAND" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text = "" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
                MessageBox.Show("Este substantivo não possui plural")
            End If
        End If


        If local.Text = "[06/20]" Then
            If ComboBox1.Text = "M" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If ComboBox2.Text = "F" Then
                ComboBox2.ForeColor = Color.White
                ComboBox2.BackColor = Color.Green
            Else
                ComboBox2.ForeColor = Color.Black
                ComboBox2.BackColor = Color.Red
            End If

            If TextBox1.Text.ToUpper = "AUSLÄNDER" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToUpper = "AUSLÄNDER" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If

            If TextBox3.Text.ToUpper = "AUSLÄNDERIN" Then
                TextBox3.ForeColor = Color.White
                TextBox3.BackColor = Color.Green
            Else
                TextBox3.ForeColor = Color.Black
                TextBox3.BackColor = Color.Red
            End If

            If TextBox4.Text.ToUpper = "AUSLÄNDERINNEN" Then
                TextBox4.ForeColor = Color.White
                TextBox4.BackColor = Color.Green
            Else
                TextBox4.ForeColor = Color.Black
                TextBox4.BackColor = Color.Red
            End If
        End If


        If local.Text = "[07/20]" Then
            If ComboBox1.Text = "F" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToUpper = "BANK" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToUpper = "BANKEN" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[08/20]" Then
            If ComboBox1.Text = "M" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToUpper = "BERUF" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToUpper = "BERUFE" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[09/20]" Then
            If ComboBox1.Text = "N" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToUpper = "BILD" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToUpper = "BILDER" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[10/20]" Then
            If ComboBox1.Text = "N" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToUpper = "BUCH" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToUpper = "BÜCHER" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[11/20]" Then
            If ComboBox1.Text = "M" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToUpper = "BUCHSTABE" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToUpper = "BUCHSTABEN" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[12/20]" Then
            If ComboBox1.Text = "N" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToUpper = "DEUTSCH" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text = "" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
                MessageBox.Show("Este substantivo não possui plural")
            End If
        End If


        If local.Text = "[13/20]" Then
            If ComboBox1.Text = "N" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToUpper = "DEUTSCHLAND" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text = "" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
                MessageBox.Show("Este substantivo não possui plural")
            End If
        End If


        If local.Text = "[14/20]" Then
            If ComboBox1.Text = "M" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToUpper = "DIALOG" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToUpper = "DIALOGE" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[15/20]" Then
            If ComboBox1.Text = "F" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToUpper = "DURCHWAHL" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToUpper = "DURCHWAHLEN" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[16/20]" Then
            If ComboBox1.Text = "F" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToUpper = "DURCHWAHLNUMMER" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToUpper = "DURCHWAHLNUMMERN" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[17/20]" Then
            If ComboBox1.Text = "F" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "elektrotechnik" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text = "" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
                MessageBox.Show("Este substantivo não possui plural")
            End If
        End If

        If local.Text = "[18/20]" Then
            If ComboBox1.Text = "M" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If ComboBox2.Text = "F" Then
                ComboBox2.ForeColor = Color.White
                ComboBox2.BackColor = Color.Green
            Else
                ComboBox2.ForeColor = Color.Black
                ComboBox2.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "elektrotechniker" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "elektrotechniker" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If

            If TextBox3.Text.ToLower = "elektrotechnikerin" Then
                TextBox3.ForeColor = Color.White
                TextBox3.BackColor = Color.Green
            Else
                TextBox3.ForeColor = Color.Black
                TextBox3.BackColor = Color.Red
            End If

            If TextBox4.Text.ToLower = "elektrotechnikerinnen" Then
                TextBox4.ForeColor = Color.White
                TextBox4.BackColor = Color.Green
            Else
                TextBox4.ForeColor = Color.Black
                TextBox4.BackColor = Color.Red
            End If
        End If


        If local.Text = "[19/20]" Then
            If ComboBox1.Text = "-" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            ElseIf ComboBox1.Text = "" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
                MessageBox.Show("Este substantivo não possui gênero")
            End If

            If TextBox1.Text = "" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
                MessageBox.Show("Este substantivo não possui singular")
            End If

            If TextBox2.Text.ToLower = "eltern" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[20/20]" Then
            If ComboBox1.Text = "F" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "e-mail" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "e-mails" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If

    End Sub

    Private Sub substantivos_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
    End Sub

    Private Sub EffectualButtonOrange1_Click_1(sender As Object, e As EventArgs) Handles EffectualButtonOrange1.Click
        If local.Text = "[01/20]" Then
            ComboBox1.Text = "F"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            TextBox1.Text = "Adresse"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = "Adressen"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If

        If local.Text = "[02/20]" Then
            ComboBox1.Text = "N"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            TextBox1.Text = "Alter"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = "Alter"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If

        If local.Text = "[03/20]" Then
            ComboBox1.Text = "F"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            TextBox1.Text = "Antwort"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = "Antworten"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If

        If local.Text = "[04/20]" Then
            ComboBox1.Text = "M"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            ComboBox2.Text = "F"
            ComboBox2.ForeColor = Color.White
            ComboBox2.BackColor = Color.Green

            TextBox1.Text = "Arzt"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = "Ärzte"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green

            TextBox3.Text = "Ärztin"
            TextBox3.ForeColor = Color.White
            TextBox3.BackColor = Color.Green

            TextBox4.Text = "Ärztinnen"
            TextBox4.ForeColor = Color.White
            TextBox4.BackColor = Color.Green
        End If

        If local.Text = "[05/20]" Then
            ComboBox1.Text = "N"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            TextBox1.Text = "Ausland"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = ""
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If

        If local.Text = "[06/20]" Then
            ComboBox1.Text = "M"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            ComboBox2.Text = "F"
            ComboBox2.ForeColor = Color.White
            ComboBox2.BackColor = Color.Green

            TextBox1.Text = "Ausländer"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = "Ausländer"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green

            TextBox3.Text = "Ausländerin"
            TextBox3.ForeColor = Color.White
            TextBox3.BackColor = Color.Green

            TextBox4.Text = "Ausländerinnen"
            TextBox4.ForeColor = Color.White
            TextBox4.BackColor = Color.Green
        End If

        If local.Text = "[07/20]" Then
            ComboBox1.Text = "F"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            TextBox1.Text = "Bank"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = "Banken"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If

        If local.Text = "[08/20]" Then
            ComboBox1.Text = "M"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            TextBox1.Text = "Beruf"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = "Berufe"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If

        If local.Text = "[09/20]" Then
            ComboBox1.Text = "N"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            TextBox1.Text = "Bild"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = "Bilder"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If

        If local.Text = "[10/20]" Then
            ComboBox1.Text = "N"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            TextBox1.Text = "Buch"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = "Bücher"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If

        If local.Text = "[11/20]" Then
            ComboBox1.Text = "M"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            TextBox1.Text = "Buchstabe"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = "Buchstaben"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If

        If local.Text = "[12/20]" Then
            ComboBox1.Text = "N"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            TextBox1.Text = "Deutsch"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = ""
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If

        If local.Text = "[13/20]" Then
            ComboBox1.Text = "N"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            TextBox1.Text = "Deutschland"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = ""
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If

        If local.Text = "[14/20]" Then
            ComboBox1.Text = "M"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            TextBox1.Text = "Dialog"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = "Dialoge"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If

        If local.Text = "[15/20]" Then
            ComboBox1.Text = "F"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            TextBox1.Text = "Durchwahl"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = "Durchwahlen"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If

        If local.Text = "[16/20]" Then
            ComboBox1.Text = "F"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            TextBox1.Text = "Durchwahlnummer"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = "Durchwahlnummern"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If

        If local.Text = "[17/20]" Then
            ComboBox1.Text = "F"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            TextBox1.Text = "Elektrotechnik"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = ""
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If

        If local.Text = "[18/20]" Then
            ComboBox1.Text = "M"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            ComboBox2.Text = "F"
            ComboBox2.ForeColor = Color.White
            ComboBox2.BackColor = Color.Green

            TextBox1.Text = "Elektrotechniker"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = "Elektrotechniker"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green

            TextBox3.Text = "Elektrotechnikerin"
            TextBox3.ForeColor = Color.White
            TextBox3.BackColor = Color.Green

            TextBox4.Text = "Elektrotechnikerinnen"
            TextBox4.ForeColor = Color.White
            TextBox4.BackColor = Color.Green
        End If

        If local.Text = "[19/20]" Then
            ComboBox1.Text = "-"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            TextBox1.Text = ""
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = "Eltern"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If

        If local.Text = "[20/20]" Then
            ComboBox1.Text = "F"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green

            TextBox1.Text = "E-mail"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green

            TextBox2.Text = "E-mails"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox1_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox2_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        e.Handled = True
    End Sub

    Private Sub EffectualButtonGray1_Click_1(sender As Object, e As EventArgs) Handles EffectualButtonGray1.Click
        ComboBox1.Text = ""
        ComboBox1.ForeColor = Color.Black
        ComboBox1.BackColor = Color.White

        ComboBox2.Text = ""
        ComboBox2.ForeColor = Color.Black
        ComboBox2.BackColor = Color.White

        TextBox1.Text = ""
        TextBox1.ForeColor = Color.Black
        TextBox1.BackColor = Color.White

        TextBox2.Text = ""
        TextBox2.ForeColor = Color.Black
        TextBox2.BackColor = Color.White

        If TextBox3.Enabled = False Then
            TextBox3.Text = ""
        Else
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.BackColor = Color.White
        End If

        If TextBox4.Enabled = False Then
            TextBox4.Text = ""
        Else
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.BackColor = Color.White
        End If
    End Sub

End Class