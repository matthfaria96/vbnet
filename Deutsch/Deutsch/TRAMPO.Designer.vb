<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TRAMPO
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TRAMPO))
        Me.EffectualTheme1 = New Deutsch.EffectualTheme()
        Me.EffectualGroupBox1 = New Deutsch.EffectualGroupBox()
        Me.EffectualGroupBox2 = New Deutsch.EffectualGroupBox()
        Me.EffectualTheme1.SuspendLayout()
        Me.EffectualGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EffectualTheme1
        '
        Me.EffectualTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.EffectualTheme1.Controls.Add(Me.EffectualGroupBox1)
        Me.EffectualTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EffectualTheme1.Location = New System.Drawing.Point(0, 0)
        Me.EffectualTheme1.Name = "EffectualTheme1"
        Me.EffectualTheme1.Size = New System.Drawing.Size(496, 552)
        Me.EffectualTheme1.Subtext = Nothing
        Me.EffectualTheme1.TabIndex = 1
        Me.EffectualTheme1.Text = "EffectualTheme1"
        '
        'EffectualGroupBox1
        '
        Me.EffectualGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.EffectualGroupBox1.Controls.Add(Me.EffectualGroupBox2)
        Me.EffectualGroupBox1.Location = New System.Drawing.Point(12, 83)
        Me.EffectualGroupBox1.Name = "EffectualGroupBox1"
        Me.EffectualGroupBox1.Size = New System.Drawing.Size(472, 422)
        Me.EffectualGroupBox1.TabIndex = 0
        Me.EffectualGroupBox1.Text = "Preencha o campo abaixo em Alemão de acordo com o verbo acima"
        '
        'EffectualGroupBox2
        '
        Me.EffectualGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.EffectualGroupBox2.Location = New System.Drawing.Point(19, 95)
        Me.EffectualGroupBox2.Name = "EffectualGroupBox2"
        Me.EffectualGroupBox2.Size = New System.Drawing.Size(433, 245)
        Me.EffectualGroupBox2.TabIndex = 80
        Me.EffectualGroupBox2.Text = "Conjugações (Auto-Preenchimento)"
        '
        'TRAMPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 552)
        Me.Controls.Add(Me.EffectualTheme1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TRAMPO"
        Me.ShowIcon = False
        Me.Text = "TRAMPO"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.EffectualTheme1.ResumeLayout(False)
        Me.EffectualGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EffectualTheme1 As Deutsch.EffectualTheme
    Friend WithEvents EffectualGroupBox1 As Deutsch.EffectualGroupBox
    Friend WithEvents EffectualGroupBox2 As Deutsch.EffectualGroupBox
End Class
