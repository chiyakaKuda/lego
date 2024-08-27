<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaWinCircleProgressIndicator1 = New Guna.UI.WinForms.GunaWinCircleProgressIndicator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(175, 689)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 1
        '
        'Timer1
        '
        '
        'GunaWinCircleProgressIndicator1
        '
        Me.GunaWinCircleProgressIndicator1.BackColor = System.Drawing.Color.Transparent
        Me.GunaWinCircleProgressIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaWinCircleProgressIndicator1.Location = New System.Drawing.Point(503, 237)
        Me.GunaWinCircleProgressIndicator1.Name = "GunaWinCircleProgressIndicator1"
        Me.GunaWinCircleProgressIndicator1.ProgressColor = System.Drawing.Color.SlateGray
        Me.GunaWinCircleProgressIndicator1.Size = New System.Drawing.Size(23, 26)
        Me.GunaWinCircleProgressIndicator1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Loading, Please wait..."
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(538, 268)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GunaWinCircleProgressIndicator1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GunaWinCircleProgressIndicator1 As Guna.UI.WinForms.GunaWinCircleProgressIndicator
    Friend WithEvents Label1 As Label
End Class
