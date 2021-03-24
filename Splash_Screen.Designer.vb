<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash_Screen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash_Screen))
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.loadBar = New System.Windows.Forms.Panel()
        Me.bar = New System.Windows.Forms.Panel()
        Me.time = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Background
        '
        Me.Background.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Background.Image = CType(resources.GetObject("Background.Image"), System.Drawing.Image)
        Me.Background.Location = New System.Drawing.Point(0, 0)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(700, 400)
        Me.Background.TabIndex = 0
        Me.Background.TabStop = False
        '
        'loadBar
        '
        Me.loadBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.loadBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.loadBar.Location = New System.Drawing.Point(0, 390)
        Me.loadBar.Name = "loadBar"
        Me.loadBar.Size = New System.Drawing.Size(700, 10)
        Me.loadBar.TabIndex = 1
        '
        'bar
        '
        Me.bar.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.bar.Location = New System.Drawing.Point(0, 390)
        Me.bar.Name = "bar"
        Me.bar.Size = New System.Drawing.Size(343, 10)
        Me.bar.TabIndex = 2
        '
        'time
        '
        Me.time.Enabled = True
        Me.time.Interval = 15
        '
        'Splash_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.bar)
        Me.Controls.Add(Me.loadBar)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splash_Screen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash Screen"
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Background As PictureBox
    Friend WithEvents loadBar As Panel
    Friend WithEvents bar As Panel
    Friend WithEvents time As Timer
End Class
