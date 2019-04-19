<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMEscapeMenu
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
        Me.BTNPlay = New System.Windows.Forms.Button()
        Me.GBGamemode = New System.Windows.Forms.GroupBox()
        Me.RBEasy = New System.Windows.Forms.RadioButton()
        Me.RBHard = New System.Windows.Forms.RadioButton()
        Me.RBSurvival = New System.Windows.Forms.RadioButton()
        Me.BTNInstructions = New System.Windows.Forms.Button()
        Me.GBGamemode.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNPlay
        '
        Me.BTNPlay.Location = New System.Drawing.Point(12, 12)
        Me.BTNPlay.Name = "BTNPlay"
        Me.BTNPlay.Size = New System.Drawing.Size(44, 25)
        Me.BTNPlay.TabIndex = 65
        Me.BTNPlay.Text = "Play"
        Me.BTNPlay.UseVisualStyleBackColor = True
        '
        'GBGamemode
        '
        Me.GBGamemode.Controls.Add(Me.RBEasy)
        Me.GBGamemode.Controls.Add(Me.RBHard)
        Me.GBGamemode.Controls.Add(Me.RBSurvival)
        Me.GBGamemode.Location = New System.Drawing.Point(12, 43)
        Me.GBGamemode.Name = "GBGamemode"
        Me.GBGamemode.Size = New System.Drawing.Size(176, 119)
        Me.GBGamemode.TabIndex = 66
        Me.GBGamemode.TabStop = False
        Me.GBGamemode.Text = "Gamemode"
        '
        'RBEasy
        '
        Me.RBEasy.AutoSize = True
        Me.RBEasy.Enabled = False
        Me.RBEasy.Location = New System.Drawing.Point(7, 68)
        Me.RBEasy.Name = "RBEasy"
        Me.RBEasy.Size = New System.Drawing.Size(92, 17)
        Me.RBEasy.TabIndex = 2
        Me.RBEasy.TabStop = True
        Me.RBEasy.Text = "Campain Easy"
        Me.RBEasy.UseVisualStyleBackColor = True
        '
        'RBHard
        '
        Me.RBHard.AutoSize = True
        Me.RBHard.Enabled = False
        Me.RBHard.Location = New System.Drawing.Point(7, 44)
        Me.RBHard.Name = "RBHard"
        Me.RBHard.Size = New System.Drawing.Size(92, 17)
        Me.RBHard.TabIndex = 1
        Me.RBHard.TabStop = True
        Me.RBHard.Text = "Campain Hard"
        Me.RBHard.UseVisualStyleBackColor = True
        '
        'RBSurvival
        '
        Me.RBSurvival.AutoSize = True
        Me.RBSurvival.Checked = True
        Me.RBSurvival.Location = New System.Drawing.Point(7, 20)
        Me.RBSurvival.Name = "RBSurvival"
        Me.RBSurvival.Size = New System.Drawing.Size(63, 17)
        Me.RBSurvival.TabIndex = 0
        Me.RBSurvival.TabStop = True
        Me.RBSurvival.Text = "Survival"
        Me.RBSurvival.UseVisualStyleBackColor = True
        '
        'BTNInstructions
        '
        Me.BTNInstructions.Location = New System.Drawing.Point(113, 12)
        Me.BTNInstructions.Name = "BTNInstructions"
        Me.BTNInstructions.Size = New System.Drawing.Size(75, 25)
        Me.BTNInstructions.TabIndex = 67
        Me.BTNInstructions.Text = "Instructions"
        Me.BTNInstructions.UseVisualStyleBackColor = True
        '
        'FORMEscapeMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 174)
        Me.Controls.Add(Me.BTNInstructions)
        Me.Controls.Add(Me.GBGamemode)
        Me.Controls.Add(Me.BTNPlay)
        Me.Name = "FORMEscapeMenu"
        Me.Text = "Escape"
        Me.GBGamemode.ResumeLayout(False)
        Me.GBGamemode.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNPlay As System.Windows.Forms.Button
    Friend WithEvents GBGamemode As System.Windows.Forms.GroupBox
    Friend WithEvents RBEasy As System.Windows.Forms.RadioButton
    Friend WithEvents RBHard As System.Windows.Forms.RadioButton
    Friend WithEvents RBSurvival As System.Windows.Forms.RadioButton
    Friend WithEvents BTNInstructions As System.Windows.Forms.Button

End Class
