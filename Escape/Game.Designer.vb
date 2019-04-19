<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMEscapeGame
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
        Me.BTNW = New System.Windows.Forms.Button()
        Me.BTNE = New System.Windows.Forms.Button()
        Me.BTNS = New System.Windows.Forms.Button()
        Me.BTNN = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBLScoreCollon = New System.Windows.Forms.Label()
        Me.LBLScore = New System.Windows.Forms.Label()
        Me.TBItemList = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNMenu = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TMRScore = New System.Windows.Forms.Timer(Me.components)
        Me.TMRMove = New System.Windows.Forms.Timer(Me.components)
        Me.TMRWallSpawn = New System.Windows.Forms.Timer(Me.components)
        Me.TMRCoins = New System.Windows.Forms.Timer(Me.components)
        Me.TMRCpuSpawn = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNW
        '
        Me.BTNW.Location = New System.Drawing.Point(568, 341)
        Me.BTNW.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNW.Name = "BTNW"
        Me.BTNW.Size = New System.Drawing.Size(100, 28)
        Me.BTNW.TabIndex = 9
        Me.BTNW.Text = "< < West <<"
        Me.BTNW.UseVisualStyleBackColor = True
        '
        'BTNE
        '
        Me.BTNE.Location = New System.Drawing.Point(676, 341)
        Me.BTNE.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNE.Name = "BTNE"
        Me.BTNE.Size = New System.Drawing.Size(100, 28)
        Me.BTNE.TabIndex = 8
        Me.BTNE.Text = "> > East >>"
        Me.BTNE.UseVisualStyleBackColor = True
        '
        'BTNS
        '
        Me.BTNS.Location = New System.Drawing.Point(621, 377)
        Me.BTNS.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNS.Name = "BTNS"
        Me.BTNS.Size = New System.Drawing.Size(100, 28)
        Me.BTNS.TabIndex = 7
        Me.BTNS.Text = "\\ South //"
        Me.BTNS.UseVisualStyleBackColor = True
        '
        'BTNN
        '
        Me.BTNN.Location = New System.Drawing.Point(621, 305)
        Me.BTNN.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNN.Name = "BTNN"
        Me.BTNN.Size = New System.Drawing.Size(100, 28)
        Me.BTNN.TabIndex = 6
        Me.BTNN.Text = "//  North \\"
        Me.BTNN.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LBLScoreCollon)
        Me.Panel1.Controls.Add(Me.LBLScore)
        Me.Panel1.Location = New System.Drawing.Point(212, 295)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 74)
        Me.Panel1.TabIndex = 112
        '
        'LBLScoreCollon
        '
        Me.LBLScoreCollon.AutoSize = True
        Me.LBLScoreCollon.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLScoreCollon.Location = New System.Drawing.Point(16, 15)
        Me.LBLScoreCollon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLScoreCollon.Name = "LBLScoreCollon"
        Me.LBLScoreCollon.Size = New System.Drawing.Size(127, 45)
        Me.LBLScoreCollon.TabIndex = 62
        Me.LBLScoreCollon.Text = "Score:"
        '
        'LBLScore
        '
        Me.LBLScore.AutoSize = True
        Me.LBLScore.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLScore.Location = New System.Drawing.Point(160, 15)
        Me.LBLScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLScore.Name = "LBLScore"
        Me.LBLScore.Size = New System.Drawing.Size(40, 45)
        Me.LBLScore.TabIndex = 63
        Me.LBLScore.Text = "0"
        '
        'TBItemList
        '
        Me.TBItemList.Location = New System.Drawing.Point(16, 305)
        Me.TBItemList.Margin = New System.Windows.Forms.Padding(4)
        Me.TBItemList.Multiline = True
        Me.TBItemList.Name = "TBItemList"
        Me.TBItemList.ReadOnly = True
        Me.TBItemList.Size = New System.Drawing.Size(113, 99)
        Me.TBItemList.TabIndex = 107
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 286)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Items:"
        '
        'BTNMenu
        '
        Me.BTNMenu.Location = New System.Drawing.Point(236, 377)
        Me.BTNMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNMenu.Name = "BTNMenu"
        Me.BTNMenu.Size = New System.Drawing.Size(100, 28)
        Me.BTNMenu.TabIndex = 113
        Me.BTNMenu.Text = "Menu"
        Me.BTNMenu.UseVisualStyleBackColor = True
        Me.BTNMenu.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(380, 377)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 114
        Me.Button2.Text = "Play Again"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'TMRScore
        '
        Me.TMRScore.Interval = 1000
        '
        'TMRMove
        '
        Me.TMRMove.Interval = 500
        '
        'TMRWallSpawn
        '
        Me.TMRWallSpawn.Interval = 1000
        '
        'TMRCoins
        '
        Me.TMRCoins.Interval = 1000
        '
        'TMRCpuSpawn
        '
        Me.TMRCpuSpawn.Interval = 1000
        '
        'FORMEscapeGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 420)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BTNMenu)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBItemList)
        Me.Controls.Add(Me.BTNW)
        Me.Controls.Add(Me.BTNE)
        Me.Controls.Add(Me.BTNS)
        Me.Controls.Add(Me.BTNN)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FORMEscapeGame"
        Me.Text = "Escape"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNW As System.Windows.Forms.Button
    Friend WithEvents BTNE As System.Windows.Forms.Button
    Friend WithEvents BTNS As System.Windows.Forms.Button
    Friend WithEvents BTNN As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LBLScoreCollon As System.Windows.Forms.Label
    Friend WithEvents LBLScore As System.Windows.Forms.Label
    Friend WithEvents TBItemList As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTNMenu As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TMRScore As System.Windows.Forms.Timer
    Friend WithEvents TMRMove As System.Windows.Forms.Timer
    Friend WithEvents TMRWallSpawn As System.Windows.Forms.Timer
    Friend WithEvents TMRCoins As System.Windows.Forms.Timer
    Friend WithEvents TMRCpuSpawn As System.Windows.Forms.Timer
End Class
