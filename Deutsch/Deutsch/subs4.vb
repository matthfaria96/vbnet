Public Class subs4

    Private Sub EffectualButtonBlue1_Click(sender As Object, e As EventArgs) Handles EffectualButtonBlue1.Click
        If local.Text = "[61/80]" Then
            If ComboBox1.Text = "-" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            ElseIf ComboBox1.Text = "" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
                MessageBox.Show("Este substantivo não possui genero")
            End If

            If TextBox1.Text = "" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
                MessageBox.Show("Este substantivo não possui singular")
            End If

            If TextBox2.Text.ToLower = "leute" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[62/80]" Then
            If ComboBox1.Text = "F" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "lösung" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "lösungen" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[63/80]" Then
            If ComboBox1.Text = "N" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "mädchen" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "mädchen" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[64/80]" Then
            If ComboBox1.Text = "F" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "mail" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "mails" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[65/80]" Then
            If ComboBox1.Text = "M" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "mann" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "männer" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[66/80]" Then
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

            If TextBox1.Text.ToLower = "mechaniker" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "mechaniker" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If

            If TextBox3.Text.ToLower = "mechanikerin" Then
                TextBox3.ForeColor = Color.White
                TextBox3.BackColor = Color.Green
            Else
                TextBox3.ForeColor = Color.Black
                TextBox3.BackColor = Color.Red
            End If

            If TextBox4.Text.ToLower = "mechanikerinnen" Then
                TextBox4.ForeColor = Color.White
                TextBox4.BackColor = Color.Green
            Else
                TextBox4.ForeColor = Color.Black
                TextBox4.BackColor = Color.Red
            End If
        End If


        If local.Text = "[67/80]" Then
            If ComboBox1.Text = "F" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "medizin" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
                MessageBox.Show("Este substantivo não possui plural")
            End If
        End If


        If local.Text = "[68/80]" Then
            If ComboBox1.Text = "N" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "mobiltelefon" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "mobiltelefone" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[69/80]" Then
            If ComboBox1.Text = "M" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "monat" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "monate" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[70/80]" Then
            If ComboBox1.Text = "F" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "musik" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "musiken" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[71/80]" Then
            If ComboBox1.Text = "F" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "mutter" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "mütter" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[72/80]" Then
            If ComboBox1.Text = "M" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "nachname" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "nachnamen" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[73/80]" Then
            If ComboBox1.Text = "M" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "name" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "namen" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[74/80]" Then
            If ComboBox1.Text = "F" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "nummer" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "nummern" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[75/80]" Then
            If ComboBox1.Text = "M" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "ort" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "orte" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[76/80]" Then
            If ComboBox1.Text = "F" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "ortsvorwahl" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "ortsvorwahlen" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[77/80]" Then
            If ComboBox1.Text = "N" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "österreich" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
                MessageBox.Show("Este substantivo não possui plural")
            End If
        End If

        If local.Text = "[78/80]" Then
            If ComboBox1.Text = "F" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "post" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "posten" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[79/80]" Then
            If ComboBox1.Text = "F" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "postkarte" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "postkarten" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If


        If local.Text = "[80/80]" Then
            If ComboBox1.Text = "F" Then
                ComboBox1.ForeColor = Color.White
                ComboBox1.BackColor = Color.Green
            Else
                ComboBox1.ForeColor = Color.Black
                ComboBox1.BackColor = Color.Red
            End If

            If TextBox1.Text.ToLower = "postleitzahl" Then
                TextBox1.ForeColor = Color.White
                TextBox1.BackColor = Color.Green
            Else
                TextBox1.ForeColor = Color.Black
                TextBox1.BackColor = Color.Red
            End If

            If TextBox2.Text.ToLower = "postleitzahl" Then
                TextBox2.ForeColor = Color.White
                TextBox2.BackColor = Color.Green
            Else
                TextBox2.ForeColor = Color.Black
                TextBox2.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub EffectualButtonOrange1_Click_1(sender As Object, e As EventArgs) Handles EffectualButtonOrange1.Click
        If local.Text = "[61/80]" Then
            ComboBox1.Text = "-"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = "Leute"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If


        If local.Text = "[62/80]" Then
            ComboBox1.Text = "F"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = "Lösung"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = "Lösungen"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If


        If local.Text = "[63/80]" Then
            ComboBox1.Text = "N"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = "Mädchen"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = "Mädchen"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If


        If local.Text = "[64/80]" Then
            ComboBox1.Text = "F"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = "Mail"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = "Mails"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If


        If local.Text = "[65/80]" Then
            ComboBox1.Text = "M"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = "Mann"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = "Männer"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If


        If local.Text = "[66/80]" Then
            ComboBox1.Text = "M"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            ComboBox2.Text = "F"
            ComboBox2.ForeColor = Color.White
            ComboBox2.BackColor = Color.Green
            TextBox1.Text = "Mechaniker"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = "Mechaniker"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
            TextBox3.Text = "Mechanikerin"
            TextBox3.ForeColor = Color.White
            TextBox3.BackColor = Color.Green
            TextBox4.Text = "Mechanikerinnen"
            TextBox4.ForeColor = Color.White
            TextBox4.BackColor = Color.Green
        End If


        If local.Text = "[67/80]" Then
            ComboBox1.Text = "F"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = "Medizin"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If


        If local.Text = "[68/80]" Then
            ComboBox1.Text = "N"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = "Mobiltelefon"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = "Mobiltelefone"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If


        If local.Text = "[69/80]" Then
            ComboBox1.Text = "M"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = "Monat"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = "Monate"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If


        If local.Text = "[70/80]" Then
            ComboBox1.Text = "F"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = "Musik"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = "Musiken"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If


        If local.Text = "[71/80]" Then
            ComboBox1.Text = "F"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = "Mutter"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = "Mütter"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If


        If local.Text = "[72/80]" Then
            ComboBox1.Text = "M"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = "Nachname"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = "Nachnamen"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If


        If local.Text = "[73/80]" Then
            ComboBox1.Text = "M"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = "Name"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = "Namen"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If


        If local.Text = "[74/80]" Then
            ComboBox1.Text = "F"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = "Nummer"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = "Nummern"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green

        End If


        If local.Text = "[75/80]" Then
            ComboBox1.Text = "M"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = "Ort"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = "Orte"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If


        If local.Text = "[76/80]" Then
            ComboBox1.Text = "F"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = "Ortsvorwahl"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = "Ortsvorwahlen"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If


        If local.Text = "[77/80]" Then
            ComboBox1.Text = "N"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = "Österreich"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If

        If local.Text = "[78/80]" Then
            ComboBox1.Text = "F"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = "Post"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = "Posten"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If


        If local.Text = "[79/80]" Then
            ComboBox1.Text = "F"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = "Postkarte"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = "Postkarten"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If


        If local.Text = "[80/80]" Then
            ComboBox1.Text = "F"
            ComboBox1.ForeColor = Color.White
            ComboBox1.BackColor = Color.Green
            TextBox1.Text = "Postleitzahl"
            TextBox1.ForeColor = Color.White
            TextBox1.BackColor = Color.Green
            TextBox2.Text = "Postleitzahlen"
            TextBox2.ForeColor = Color.White
            TextBox2.BackColor = Color.Green
        End If
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

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Picturebox1_Click_1(sender As Object, e As EventArgs) Handles Picturebox1.Click
        If local.Text = "[61/80]" Then
            MessageBox.Show("Você está no exercício [61/80], clique na seta da direita para avançar")
            Label8.Text = "Pessoas"

        ElseIf local.Text = "[62/80]" Then
            local.Text = "[61/80]"
            Label8.Text = "Pessoas"

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

        ElseIf local.Text = "[63/80]" Then
            local.Text = "[62/80]"
            Label8.Text = "Solução"

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

        ElseIf local.Text = "[64/80]" Then
            local.Text = "[63/80]"
            Label8.Text = "Menina"

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

        ElseIf local.Text = "[65/80]" Then
            local.Text = "[64/80]"
            Label8.Text = "E-mail (forma reduzida)"

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

        ElseIf local.Text = "[66/80]" Then
            local.Text = "[65/80]"
            Label8.Text = "Homem"

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

        ElseIf local.Text = "[67/80]" Then
            local.Text = "[66/80]"
            Label8.Text = "Mecânico / Mecânica"

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

        ElseIf local.Text = "[68/80]" Then
            local.Text = "[67/80]"
            Label8.Text = "Medicina"

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

        ElseIf local.Text = "[69/80]" Then
            local.Text = "[68/80]"
            Label8.Text = "Celular (designação técnica)"

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

        ElseIf local.Text = "[70/80]" Then
            local.Text = "[69/80]"
            Label8.Text = "Mês"

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

        ElseIf local.Text = "[71/80]" Then
            local.Text = "[70/80]"
            Label8.Text = "Música"

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

        ElseIf local.Text = "[72/80]" Then
            local.Text = "[71/80]"
            Label8.Text = "Mãe"

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

        ElseIf local.Text = "[73/80]" Then
            local.Text = "[72/80]"
            Label8.Text = "Sobrenome"

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

        ElseIf local.Text = "[74/80]" Then
            local.Text = "[73/80]"
            Label8.Text = "Nome"

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

        ElseIf local.Text = "[75/80]" Then
            local.Text = "[74/80]"
            Label8.Text = "Número (caráter identificador)"

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

        ElseIf local.Text = "[76/80]" Then
            local.Text = "[75/80]"
            Label8.Text = "Local; Lugar"

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

        ElseIf local.Text = "[77/80]" Then
            local.Text = "[76/80]"
            Label8.Text = "Código de área (telefonia)"

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

        ElseIf local.Text = "[78/80]" Then
            local.Text = "[77/80]"
            Label8.Text = "Áustria"

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

        ElseIf local.Text = "[79/80]" Then
            local.Text = "[78/80]"
            Label8.Text = "Correio"

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

        ElseIf local.Text = "[80/80]" Then
            local.Text = "[79/80]"
            Label8.Text = "Cartão-postal padronizado"

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

    Private Sub Picturebox2_Click_1(sender As Object, e As EventArgs) Handles Picturebox2.Click
        If local.Text = "[61/80]" Then
            local.Text = "[62/80]"
            Label8.Text = "Solução"

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

        ElseIf local.Text = "[62/80]" Then
            local.Text = "[63/80]"
            Label8.Text = "Menina"

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

        ElseIf local.Text = "[63/80]" Then
            local.Text = "[64/80]"
            Label8.Text = "E-mail (forma reduzida)"

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

        ElseIf local.Text = "[64/80]" Then
            local.Text = "[65/80]"
            Label8.Text = "Homem"

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

        ElseIf local.Text = "[65/80]" Then
            local.Text = "[66/80]"
            Label8.Text = "Mecânico / Mecânica"

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

        ElseIf local.Text = "[66/80]" Then
            local.Text = "[67/80]"
            Label8.Text = "Medicina"

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

        ElseIf local.Text = "[67/80]" Then
            local.Text = "[68/80]"
            Label8.Text = "Celular (designação técnica)"

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

        ElseIf local.Text = "[68/80]" Then
            local.Text = "[69/80]"
            Label8.Text = "Mês"

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

        ElseIf local.Text = "[69/80]" Then
            local.Text = "[70/80]"
            Label8.Text = "Música"

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

        ElseIf local.Text = "[70/80]" Then
            local.Text = "[71/80]"
            Label8.Text = "Mãe"

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

        ElseIf local.Text = "[71/80]" Then
            local.Text = "[72/80]"
            Label8.Text = "Sobrenome"

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

        ElseIf local.Text = "[72/80]" Then
            local.Text = "[73/80]"
            Label8.Text = "Nome"

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

        ElseIf local.Text = "[73/80]" Then
            local.Text = "[74/80]"
            Label8.Text = "Número (caráter identificador)"

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

        ElseIf local.Text = "[74/80]" Then
            local.Text = "[75/80]"
            Label8.Text = "Local; Lugar"

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

        ElseIf local.Text = "[75/80]" Then
            local.Text = "[76/80]"
            Label8.Text = "Código de área (telefonia)"

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

        ElseIf local.Text = "[76/80]" Then
            local.Text = "[77/80]"
            Label8.Text = "Áustria"

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

        ElseIf local.Text = "[77/80]" Then
            local.Text = "[78/80]"
            Label8.Text = "Correio"

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

        ElseIf local.Text = "[78/80]" Then
            local.Text = "[79/80]"
            Label8.Text = "Cartão-postal padronizado"

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

        ElseIf local.Text = "[79/80]" Then
            local.Text = "[80/80]"
            Label8.Text = "CEP"

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

        ElseIf local.Text = "[80/80]" Then
            MessageBox.Show("Parabéns! Você terminou todos os exercícios, vá para o menu para mais exercícios")
            Label8.Text = "CEP"

        End If
    End Sub

    Private Sub ComboBox1_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox2_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        e.Handled = True
    End Sub

End Class