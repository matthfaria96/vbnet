<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm1))
        Me.ReactorTheme1 = New Pokexgames.ReactorTheme
        Me.SuspendLayout()
        '
        'ReactorTheme1
        '
        Me.ReactorTheme1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ReactorTheme1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ReactorTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReactorTheme1.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.ReactorTheme1.Location = New System.Drawing.Point(0, 0)
        Me.ReactorTheme1.Name = "ReactorTheme1"
        Me.ReactorTheme1.Size = New System.Drawing.Size(401, 192)
        Me.ReactorTheme1.TabIndex = 0
        Me.ReactorTheme1.Text = "PxG - Login"
        '
        'LoginForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 192)
        Me.Controls.Add(Me.ReactorTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm1"
        Me.Opacity = 0.9
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReactorTheme1 As Pokexgames.ReactorTheme

End Class
