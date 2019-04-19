Public Class FORMEscapeGame
    Public Room(96) As Room
    Dim Map(96) As TextBox
    Public PlayerRoom As Integer = 42
    Public ComputerRoom(8) As Integer
    Dim ChooseRoom As Integer = 0
    Dim Score As Integer
    Dim CoinRoom As Integer
    Dim WallRoom As Integer
    Dim WallSpawn As Integer
    Dim MoveCpu As Integer
    Dim CpuNum As Integer
    Dim CpuSpawn As Integer
    Dim ChooseSpawner As Integer
    Dim Computer As Integer = 1

    'computers spawn in box (18, 31, 66, 79)... not anymore now in (1,16,81,96)
    '------------
    'still teleporting (lagg?)
    'the cpu teleports when on the edge and has a short time interval
    'Ask michael windels how to create the CpuChooseRoom with a For Loop
    'try to make it in another vb with a msgbox
    'Maybe make almost all the code into a loop to easily transport the cpu's

    '//change time interval to 500 and the interval to 250 at 225 seconds
    '//try letting them teleport
    '------------'change the color for coin when the cpu leaves the block (finished on first cpu)
    ' enable the cpuspawn after

    'xtra = maybe use "while" instead of "if" to check if the cpu is choosing a incorrect room and to choose another one?

    Public Function Rand(ByVal Low As Long, _
                         ByVal High As Long) As Long
        Randomize()
        Rand = Int((High - Low + 1) * Rnd()) + Low
    End Function

    Private Sub FORMEscape_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            BTNN.PerformClick()
        End If
        If e.KeyCode = Keys.Right Then
            BTNE.PerformClick()
        End If
        If e.KeyCode = Keys.Down Then
            BTNS.PerformClick()
        End If
        If e.KeyCode = Keys.Left Then
            BTNW.PerformClick()
        End If

        If e.KeyCode = Keys.W Then
            BTNN.PerformClick()
        End If
        If e.KeyCode = Keys.D Then
            BTNE.PerformClick()
        End If
        If e.KeyCode = Keys.S Then
            BTNS.PerformClick()
        End If
        If e.KeyCode = Keys.A Then
            BTNW.PerformClick()
        End If
    End Sub

    Private Sub FORMEscapeGame_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FORMEscapeMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub FORMMaze_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        TBItemList.Select()
        TMRScore.Enabled = True
        TMRMove.Enabled = True
        TMRWallSpawn.Enabled = True
        TMRCoins.Enabled = True
        TMRCpuSpawn.Enabled = True


        'Dim X As Integer
        'X = Rand(1, 10)

        ComputerRoom(1) = 31

        'Gamemode Survival'
        If FORMEscapeMenu.RBSurvival.Checked Then
            Dim tempy As Integer
            Dim tempx As Integer
            For x = 0 To 95
                tempy = x \ 16
                tempx = x Mod 16
                'Create(Buttons)
                Map(x + 1) = New TextBox
                With Map(x + 1)
                    .Name = "TB" & x
                    .Multiline = True
                    .ReadOnly = True
                    .Location = New System.Drawing.Point(12 + 36 * tempx, 12 + 36 * tempy)
                    .Size = New System.Drawing.Size(30, 30)
                End With
                Me.Controls.Add(Map(x + 1))
                'AddHandler Map(x + 1, y + 1).Click, AddressOf Me.ButtonClick
            Next
            For x = 0 To 96 Step 1
                Room(x) = New Room
                If x > 16 Then
                    Room(x).N = x - 16
                Else
                    Room(x).N = 0
                End If
                If x < 96 And Not x = 16 And Not x = 32 And Not x = 48 And Not x = 64 And Not x = 80 And Not x = 96 Then
                    Room(x).E = x + 1
                Else
                    Room(x).E = 0
                End If
                If x < 81 Then
                    Room(x).S = x + 16
                Else
                    Room(x).S = 0
                End If
                If x > 1 And Not x = 1 And Not x = 17 And Not x = 33 And Not x = 49 And Not x = 65 And Not x = 81 Then
                    Room(x).W = x - 1
                Else
                    Room(x).W = 0
                End If
            Next
            'Room(34).N = 0
            'Room(19).W = 0
            'Room(2).S = 0
            'Room(17).E = 0
            '
            'Room(47).N = 0
            'Room(32).W = 0
            'Room(15).S = 0
            'Room(30).E = 0
            '
            'Room(82).N = 0
            'Room(67).W = 0
            'Room(50).S = 0
            'Room(65).E = 0
            '
            'Room(95).N = 0
            'Room(80).W = 0
            'Room(63).S = 0
            'Room(78).E = 0

            Room(17).N = 0
            Room(2).W = 0

            Room(32).N = 0
            Room(15).E = 0

            Room(65).S = 0
            Room(82).W = 0

            Room(80).S = 0
            Room(95).E = 0
        End If

        'Gamemode Campaign Easy'

        'Gamemode Campaign Hard'

        View()
        EnterRoom()

    End Sub

    Private Sub CpuEnterRoom1()
        Map(ComputerRoom(1)).BackColor = Color.Red
        If ComputerRoom(1) = PlayerRoom Then
            TMRScore.Enabled = False
            TMRMove.Enabled = False
            TMRWallSpawn.Enabled = False
            Map(ComputerRoom(1)).BackColor = Color.Red
            MsgBox("Game Over. You had a Score of " & Score & "!")
            Me.Close()
        End If
        EnterRoom()
    End Sub

    Private Sub CpuEnterRoom2()
        Map(ComputerRoom(2)).BackColor = Color.Red
        If ComputerRoom(2) = PlayerRoom Then
            TMRScore.Enabled = False
            TMRMove.Enabled = False
            TMRWallSpawn.Enabled = False
            Map(ComputerRoom(2)).BackColor = Color.Red
            MsgBox("Game Over. You had a Score of " & Score & "!")
            Me.Close()
        End If
        EnterRoom()
    End Sub

    Private Sub CpuEnterRoom3()
        Map(ComputerRoom(3)).BackColor = Color.Red
        If ComputerRoom(3) = PlayerRoom Then
            TMRScore.Enabled = False
            TMRMove.Enabled = False
            TMRWallSpawn.Enabled = False
            Map(ComputerRoom(3)).BackColor = Color.Red
            MsgBox("Game Over. You had a Score of " & Score & "!")
            Me.Close()
        End If
        EnterRoom()
    End Sub

    Private Sub CpuEnterRoom4()
        Map(ComputerRoom(4)).BackColor = Color.Red
        If ComputerRoom(4) = PlayerRoom Then
            TMRScore.Enabled = False
            TMRMove.Enabled = False
            TMRWallSpawn.Enabled = False
            Map(ComputerRoom(4)).BackColor = Color.Red
            MsgBox("Game Over. You had a Score of " & Score & "!")
            Me.Close()
        End If
        EnterRoom()
    End Sub

    Private Sub CpuEnterRoom5()
        Map(ComputerRoom(5)).BackColor = Color.Red
        If ComputerRoom(5) = PlayerRoom Then
            TMRScore.Enabled = False
            TMRMove.Enabled = False
            TMRWallSpawn.Enabled = False
            Map(ComputerRoom(5)).BackColor = Color.Red
            MsgBox("Game Over. You had a Score of " & Score & "!")
            Me.Close()
        End If
        EnterRoom()
    End Sub

    Private Sub CpuEnterRoom6()
        Map(ComputerRoom(6)).BackColor = Color.Red
        If ComputerRoom(6) = PlayerRoom Then
            TMRScore.Enabled = False
            TMRMove.Enabled = False
            TMRWallSpawn.Enabled = False
            Map(ComputerRoom(6)).BackColor = Color.Red
            MsgBox("Game Over. You had a Score of " & Score & "!")
            Me.Close()
        End If
        EnterRoom()
    End Sub

    Private Sub CpuEnterRoom7()
        Map(ComputerRoom(7)).BackColor = Color.Red
        If ComputerRoom(7) = PlayerRoom Then
            TMRScore.Enabled = False
            TMRMove.Enabled = False
            TMRWallSpawn.Enabled = False
            Map(ComputerRoom(7)).BackColor = Color.Red
            MsgBox("Game Over. You had a Score of " & Score & "!")
            Me.Close()
        End If
        EnterRoom()
    End Sub

    Private Sub CpuEnterRoom8()
        Map(ComputerRoom(8)).BackColor = Color.Red
        If ComputerRoom(8) = PlayerRoom Then
            TMRScore.Enabled = False
            TMRMove.Enabled = False
            TMRWallSpawn.Enabled = False
            Map(ComputerRoom(8)).BackColor = Color.Red
            MsgBox("Game Over. You had a Score of " & Score & "!")
            Me.Close()
        End If
        EnterRoom()
    End Sub

    Private Sub EnterRoom()
        Map(PlayerRoom).BackColor = Color.Green
        If Room(PlayerRoom).Coin = True Then
            Room(PlayerRoom).Coin = False
            Score += 10
        End If
        If PlayerRoom = ComputerRoom(1) Or PlayerRoom = ComputerRoom(2) Or PlayerRoom = ComputerRoom(3) Or PlayerRoom = ComputerRoom(4) Or PlayerRoom = ComputerRoom(5) Or PlayerRoom = ComputerRoom(6) Or PlayerRoom = ComputerRoom(7) Or PlayerRoom = ComputerRoom(8) Then
            TMRScore.Enabled = False
            TMRMove.Enabled = False
            TMRWallSpawn.Enabled = False
            Map(ComputerRoom(1)).BackColor = Color.Red
            MsgBox("Game Over. You had a Score of " & Score & "!")
            Me.Close()
        End If
    End Sub

    Private Sub View()
        If Room(PlayerRoom).N = 0 Then
            BTNN.Enabled = False
        Else
            BTNN.Enabled = True
        End If

        If Room(PlayerRoom).E = 0 Then
            BTNE.Enabled = False
        Else
            BTNE.Enabled = True
        End If

        If Room(PlayerRoom).S = 0 Then
            BTNS.Enabled = False
        Else
            BTNS.Enabled = True
        End If

        If Room(PlayerRoom).W = 0 Then
            BTNW.Enabled = False
        Else
            BTNW.Enabled = True
        End If

    End Sub

    Private Sub CpuChooseRoom1()
        'Randomize()
        ChooseRoom = Rand(1, 4)
        'North
        If ChooseRoom = 1 And Not Room(ComputerRoom(1)).N = 0 Then
            Map(ComputerRoom(1)).BackColor = SystemColors.Control
            If Room(ComputerRoom(1)).Coin = True Then
                Map(ComputerRoom(1)).BackColor = Color.Yellow
            End If
            ComputerRoom(1) = Room(ComputerRoom(1)).N
            CpuEnterRoom1()

        End If
        If ChooseRoom = 1 And Room(ComputerRoom(1)).N = 0 Then
            'CpuChooseRoom1()
            CpuEnterRoom1()
        End If

        'East
        If ChooseRoom = 2 And Not Room(ComputerRoom(1)).E = 0 Then
            Map(ComputerRoom(1)).BackColor = SystemColors.Control
            If Room(ComputerRoom(1)).Coin = True Then
                Map(ComputerRoom(1)).BackColor = Color.Yellow
            End If
            ComputerRoom(1) = Room(ComputerRoom(1)).E
            CpuEnterRoom1()

        End If
        If ChooseRoom = 2 And Room(ComputerRoom(1)).E = 0 Then
            'CpuChooseRoom1()
            CpuEnterRoom1()
        End If

        'South
        If ChooseRoom = 3 And Not Room(ComputerRoom(1)).S = 0 Then
            Map(ComputerRoom(1)).BackColor = SystemColors.Control
            If Room(ComputerRoom(1)).Coin = True Then
                Map(ComputerRoom(1)).BackColor = Color.Yellow
            End If
            ComputerRoom(1) = Room(ComputerRoom(1)).S
            CpuEnterRoom1()

        End If
        If ChooseRoom = 3 And Room(ComputerRoom(1)).S = 0 Then
            'CpuChooseRoom1()
            CpuEnterRoom1()
        End If

        'West
        If ChooseRoom = 4 And Not Room(ComputerRoom(1)).W = 0 Then
            Map(ComputerRoom(1)).BackColor = SystemColors.Control
            If Room(ComputerRoom(1)).Coin = True Then
                Map(ComputerRoom(1)).BackColor = Color.Yellow
            End If
            ComputerRoom(1) = Room(ComputerRoom(1)).W
            CpuEnterRoom1()

        End If
        If ChooseRoom = 4 And Room(ComputerRoom(1)).W = 0 Then
            'CpuChooseRoom1()
            CpuEnterRoom1()
        End If

    End Sub

    Private Sub CpuChooseRoom2()
        'Randomize()
        ChooseRoom = Rand(1, 4)
        'North
        If ChooseRoom = 1 And Not Room(ComputerRoom(2)).N = 0 Then
            Map(ComputerRoom(2)).BackColor = SystemColors.Control
            If Room(ComputerRoom(2)).Coin = True Then
                Map(ComputerRoom(2)).BackColor = Color.Yellow
            End If
            ComputerRoom(2) = Room(ComputerRoom(2)).N
            CpuEnterRoom2()
        End If
        If ChooseRoom = 1 And Room(ComputerRoom(2)).N = 0 Then
            'CpuChooseRoom2()
            CpuEnterRoom2()
        End If

        'East
        If ChooseRoom = 2 And Not Room(ComputerRoom(2)).E = 0 Then
            Map(ComputerRoom(2)).BackColor = SystemColors.Control
            If Room(ComputerRoom(2)).Coin = True Then
                Map(ComputerRoom(2)).BackColor = Color.Yellow
            End If
            ComputerRoom(2) = Room(ComputerRoom(2)).E
            CpuEnterRoom2()
        End If
        If ChooseRoom = 2 And Room(ComputerRoom(2)).E = 0 Then
            'CpuChooseRoom2()
            CpuEnterRoom2()
        End If

        'South
        If ChooseRoom = 3 And Not Room(ComputerRoom(2)).S = 0 Then
            Map(ComputerRoom(2)).BackColor = SystemColors.Control
            If Room(ComputerRoom(2)).Coin = True Then
                Map(ComputerRoom(2)).BackColor = Color.Yellow
            End If
            ComputerRoom(2) = Room(ComputerRoom(2)).S
            CpuEnterRoom2()
        End If
        If ChooseRoom = 3 And Room(ComputerRoom(2)).S = 0 Then
            'CpuChooseRoom2()
            CpuEnterRoom2()
        End If

        'West
        If ChooseRoom = 4 And Not Room(ComputerRoom(2)).W = 0 Then
            Map(ComputerRoom(2)).BackColor = SystemColors.Control
            If Room(ComputerRoom(2)).Coin = True Then
                Map(ComputerRoom(2)).BackColor = Color.Yellow
            End If
            ComputerRoom(2) = Room(ComputerRoom(2)).W
            CpuEnterRoom2()
        End If
        If ChooseRoom = 4 And Room(ComputerRoom(2)).W = 0 Then
            'CpuChooseRoom2()
            CpuEnterRoom2()
        End If

    End Sub

    Private Sub CpuChooseRoom3()
        'Randomize()
        ChooseRoom = Rand(1, 4)
        'North
        If ChooseRoom = 1 And Not Room(ComputerRoom(3)).N = 0 Then
            Map(ComputerRoom(3)).BackColor = SystemColors.Control
            If Room(ComputerRoom(3)).Coin = True Then
                Map(ComputerRoom(3)).BackColor = Color.Yellow
            End If
            ComputerRoom(3) = Room(ComputerRoom(3)).N
            CpuEnterRoom3()
        End If
        If ChooseRoom = 1 And Room(ComputerRoom(3)).N = 0 Then
            'CpuChooseRoom3()
            CpuEnterRoom3()
        End If

        'East
        If ChooseRoom = 2 And Not Room(ComputerRoom(3)).E = 0 Then
            Map(ComputerRoom(3)).BackColor = SystemColors.Control
            If Room(ComputerRoom(3)).Coin = True Then
                Map(ComputerRoom(3)).BackColor = Color.Yellow
            End If
            ComputerRoom(3) = Room(ComputerRoom(3)).E
            CpuEnterRoom3()
        End If
        If ChooseRoom = 2 And Room(ComputerRoom(3)).E = 0 Then
            'CpuChooseRoom3()
            CpuEnterRoom3()
        End If

        'South
        If ChooseRoom = 3 And Not Room(ComputerRoom(3)).S = 0 Then
            Map(ComputerRoom(3)).BackColor = SystemColors.Control
            If Room(ComputerRoom(3)).Coin = True Then
                Map(ComputerRoom(3)).BackColor = Color.Yellow
            End If
            ComputerRoom(3) = Room(ComputerRoom(3)).S
            CpuEnterRoom3()
        End If
        If ChooseRoom = 3 And Room(ComputerRoom(3)).S = 0 Then
            'CpuChooseRoom3()
            CpuEnterRoom3()
        End If

        'West
        If ChooseRoom = 4 And Not Room(ComputerRoom(3)).W = 0 Then
            Map(ComputerRoom(3)).BackColor = SystemColors.Control
            If Room(ComputerRoom(3)).Coin = True Then
                Map(ComputerRoom(3)).BackColor = Color.Yellow
            End If
            ComputerRoom(3) = Room(ComputerRoom(3)).W
            CpuEnterRoom3()
        End If
        If ChooseRoom = 4 And Room(ComputerRoom(3)).W = 0 Then
            'CpuChooseRoom3()
            CpuEnterRoom3()
        End If

    End Sub

    Private Sub CpuChooseRoom4()
        'Randomize()
        ChooseRoom = Rand(1, 4)
        'North
        If ChooseRoom = 1 And Not Room(ComputerRoom(4)).N = 0 Then
            Map(ComputerRoom(4)).BackColor = SystemColors.Control
            If Room(ComputerRoom(4)).Coin = True Then
                Map(ComputerRoom(4)).BackColor = Color.Yellow
            End If
            ComputerRoom(4) = Room(ComputerRoom(4)).N
            CpuEnterRoom4()
        End If
        If ChooseRoom = 1 And Room(ComputerRoom(4)).N = 0 Then
            'CpuChooseRoom4()
            CpuEnterRoom4()
        End If

        'East
        If ChooseRoom = 2 And Not Room(ComputerRoom(4)).E = 0 Then
            Map(ComputerRoom(4)).BackColor = SystemColors.Control
            If Room(ComputerRoom(4)).Coin = True Then
                Map(ComputerRoom(4)).BackColor = Color.Yellow
            End If
            ComputerRoom(4) = Room(ComputerRoom(4)).E
            CpuEnterRoom4()
        End If
        If ChooseRoom = 2 And Room(ComputerRoom(4)).E = 0 Then
            'CpuChooseRoom4()
            CpuEnterRoom4()
        End If

        'South
        If ChooseRoom = 3 And Not Room(ComputerRoom(4)).S = 0 Then
            Map(ComputerRoom(4)).BackColor = SystemColors.Control
            If Room(ComputerRoom(4)).Coin = True Then
                Map(ComputerRoom(4)).BackColor = Color.Yellow
            End If
            ComputerRoom(4) = Room(ComputerRoom(4)).S
            CpuEnterRoom4()
        End If
        If ChooseRoom = 3 And Room(ComputerRoom(4)).S = 0 Then
            'CpuChooseRoom4()
            CpuEnterRoom4()
        End If

        'West
        If ChooseRoom = 4 And Not Room(ComputerRoom(4)).W = 0 Then
            Map(ComputerRoom(4)).BackColor = SystemColors.Control
            If Room(ComputerRoom(4)).Coin = True Then
                Map(ComputerRoom(4)).BackColor = Color.Yellow
            End If
            ComputerRoom(4) = Room(ComputerRoom(4)).W
            CpuEnterRoom4()
        End If
        If ChooseRoom = 4 And Room(ComputerRoom(4)).W = 0 Then
            'CpuChooseRoom4()
            CpuEnterRoom4()
        End If

    End Sub

    Private Sub CpuChooseRoom5()
        'Randomize()
        ChooseRoom = Rand(1, 4)
        'North
        If ChooseRoom = 1 And Not Room(ComputerRoom(5)).N = 0 Then
            Map(ComputerRoom(5)).BackColor = SystemColors.Control
            If Room(ComputerRoom(5)).Coin = True Then
                Map(ComputerRoom(5)).BackColor = Color.Yellow
            End If
            ComputerRoom(5) = Room(ComputerRoom(5)).N
            CpuEnterRoom5()
        End If
        If ChooseRoom = 1 And Room(ComputerRoom(5)).N = 0 Then
            'CpuChooseRoom5()
            CpuEnterRoom5()
        End If

        'East
        If ChooseRoom = 2 And Not Room(ComputerRoom(5)).E = 0 Then
            Map(ComputerRoom(5)).BackColor = SystemColors.Control
            If Room(ComputerRoom(5)).Coin = True Then
                Map(ComputerRoom(5)).BackColor = Color.Yellow
            End If
            ComputerRoom(5) = Room(ComputerRoom(5)).E
            CpuEnterRoom5()
        End If
        If ChooseRoom = 2 And Room(ComputerRoom(5)).E = 0 Then
            'CpuChooseRoom5()
            CpuEnterRoom5()
        End If

        'South
        If ChooseRoom = 3 And Not Room(ComputerRoom(5)).S = 0 Then
            Map(ComputerRoom(5)).BackColor = SystemColors.Control
            If Room(ComputerRoom(5)).Coin = True Then
                Map(ComputerRoom(5)).BackColor = Color.Yellow
            End If
            ComputerRoom(5) = Room(ComputerRoom(5)).S
            CpuEnterRoom5()
        End If
        If ChooseRoom = 3 And Room(ComputerRoom(5)).S = 0 Then
            'CpuChooseRoom5()
            CpuEnterRoom5()
        End If

        'West
        If ChooseRoom = 4 And Not Room(ComputerRoom(5)).W = 0 Then
            Map(ComputerRoom(5)).BackColor = SystemColors.Control
            If Room(ComputerRoom(5)).Coin = True Then
                Map(ComputerRoom(5)).BackColor = Color.Yellow
            End If
            ComputerRoom(5) = Room(ComputerRoom(5)).W
            CpuEnterRoom5()
        End If
        If ChooseRoom = 4 And Room(ComputerRoom(5)).W = 0 Then
            'CpuChooseRoom5()
            CpuEnterRoom5()
        End If

    End Sub

    Private Sub CpuChooseRoom6()
        'Randomize()
        ChooseRoom = Rand(1, 4)
        'North
        If ChooseRoom = 1 And Not Room(ComputerRoom(6)).N = 0 Then
            Map(ComputerRoom(6)).BackColor = SystemColors.Control
            If Room(ComputerRoom(6)).Coin = True Then
                Map(ComputerRoom(6)).BackColor = Color.Yellow
            End If
            ComputerRoom(6) = Room(ComputerRoom(6)).N
            CpuEnterRoom6()
        End If
        If ChooseRoom = 1 And Room(ComputerRoom(6)).N = 0 Then
            'CpuChooseRoom6()
            CpuEnterRoom6()
        End If

        'East
        If ChooseRoom = 2 And Not Room(ComputerRoom(6)).E = 0 Then
            Map(ComputerRoom(6)).BackColor = SystemColors.Control
            If Room(ComputerRoom(6)).Coin = True Then
                Map(ComputerRoom(6)).BackColor = Color.Yellow
            End If
            ComputerRoom(6) = Room(ComputerRoom(6)).E
            CpuEnterRoom6()
        End If
        If ChooseRoom = 2 And Room(ComputerRoom(6)).E = 0 Then
            'CpuChooseRoom6()
            CpuEnterRoom6()
        End If

        'South
        If ChooseRoom = 3 And Not Room(ComputerRoom(6)).S = 0 Then
            Map(ComputerRoom(6)).BackColor = SystemColors.Control
            If Room(ComputerRoom(6)).Coin = True Then
                Map(ComputerRoom(6)).BackColor = Color.Yellow
            End If
            ComputerRoom(6) = Room(ComputerRoom(6)).S
            CpuEnterRoom6()
        End If
        If ChooseRoom = 3 And Room(ComputerRoom(6)).S = 0 Then
            'CpuChooseRoom6()
            CpuEnterRoom6()
        End If

        'West
        If ChooseRoom = 4 And Not Room(ComputerRoom(6)).W = 0 Then
            Map(ComputerRoom(6)).BackColor = SystemColors.Control
            If Room(ComputerRoom(6)).Coin = True Then
                Map(ComputerRoom(6)).BackColor = Color.Yellow
            End If
            ComputerRoom(6) = Room(ComputerRoom(6)).W
            CpuEnterRoom6()
        End If
        If ChooseRoom = 4 And Room(ComputerRoom(6)).W = 0 Then
            'CpuChooseRoom6()
            CpuEnterRoom6()
        End If

    End Sub

    Private Sub CpuChooseRoom7()
        'Randomize()
        ChooseRoom = Rand(1, 4)
        'North
        If ChooseRoom = 1 And Not Room(ComputerRoom(7)).N = 0 Then
            Map(ComputerRoom(7)).BackColor = SystemColors.Control
            If Room(ComputerRoom(7)).Coin = True Then
                Map(ComputerRoom(7)).BackColor = Color.Yellow
            End If
            ComputerRoom(7) = Room(ComputerRoom(7)).N
            CpuEnterRoom7()
        End If
        If ChooseRoom = 1 And Room(ComputerRoom(7)).N = 0 Then
            'CpuChooseRoom7()
            CpuEnterRoom7()
        End If

        'East
        If ChooseRoom = 2 And Not Room(ComputerRoom(7)).E = 0 Then
            Map(ComputerRoom(7)).BackColor = SystemColors.Control
            If Room(ComputerRoom(7)).Coin = True Then
                Map(ComputerRoom(7)).BackColor = Color.Yellow
            End If
            ComputerRoom(7) = Room(ComputerRoom(7)).E
            CpuEnterRoom7()
        End If
        If ChooseRoom = 2 And Room(ComputerRoom(7)).E = 0 Then
            'CpuChooseRoom7()
            CpuEnterRoom7()
        End If

        'South
        If ChooseRoom = 3 And Not Room(ComputerRoom(7)).S = 0 Then
            Map(ComputerRoom(7)).BackColor = SystemColors.Control
            If Room(ComputerRoom(7)).Coin = True Then
                Map(ComputerRoom(7)).BackColor = Color.Yellow
            End If
            ComputerRoom(7) = Room(ComputerRoom(7)).S
            CpuEnterRoom7()
        End If
        If ChooseRoom = 3 And Room(ComputerRoom(7)).S = 0 Then
            'CpuChooseRoom7()
            CpuEnterRoom7()
        End If

        'West
        If ChooseRoom = 4 And Not Room(ComputerRoom(7)).W = 0 Then
            Map(ComputerRoom(7)).BackColor = SystemColors.Control
            If Room(ComputerRoom(7)).Coin = True Then
                Map(ComputerRoom(7)).BackColor = Color.Yellow
            End If
            ComputerRoom(7) = Room(ComputerRoom(7)).W
            CpuEnterRoom7()
        End If
        If ChooseRoom = 4 And Room(ComputerRoom(7)).W = 0 Then
            'CpuChooseRoom7()
            CpuEnterRoom7()
        End If

    End Sub

    Private Sub CpuChooseRoom8()
        'Randomize()
        ChooseRoom = Rand(1, 4)
        'North
        If ChooseRoom = 1 And Not Room(ComputerRoom(8)).N = 0 Then
            Map(ComputerRoom(8)).BackColor = SystemColors.Control
            If Room(ComputerRoom(8)).Coin = True Then
                Map(ComputerRoom(8)).BackColor = Color.Yellow
            End If
            ComputerRoom(8) = Room(ComputerRoom(8)).N
            CpuEnterRoom8()
        End If
        If ChooseRoom = 1 And Room(ComputerRoom(8)).N = 0 Then
            'CpuChooseRoom8()
            CpuEnterRoom8()
        End If

        'East
        If ChooseRoom = 2 And Not Room(ComputerRoom(8)).E = 0 Then
            Map(ComputerRoom(8)).BackColor = SystemColors.Control
            If Room(ComputerRoom(8)).Coin = True Then
                Map(ComputerRoom(8)).BackColor = Color.Yellow
            End If
            ComputerRoom(8) = Room(ComputerRoom(8)).E
            CpuEnterRoom8()
        End If
        If ChooseRoom = 2 And Room(ComputerRoom(8)).E = 0 Then
            'CpuChooseRoom8()
            CpuEnterRoom8()
        End If

        'South
        If ChooseRoom = 3 And Not Room(ComputerRoom(8)).S = 0 Then
            Map(ComputerRoom(8)).BackColor = SystemColors.Control
            If Room(ComputerRoom(8)).Coin = True Then
                Map(ComputerRoom(8)).BackColor = Color.Yellow
            End If
            ComputerRoom(8) = Room(ComputerRoom(8)).S
            CpuEnterRoom8()
        End If
        If ChooseRoom = 3 And Room(ComputerRoom(8)).S = 0 Then
            'CpuChooseRoom8()
            CpuEnterRoom8()
        End If

        'West
        If ChooseRoom = 4 And Not Room(ComputerRoom(8)).W = 0 Then
            Map(ComputerRoom(8)).BackColor = SystemColors.Control
            If Room(ComputerRoom(8)).Coin = True Then
                Map(ComputerRoom(8)).BackColor = Color.Yellow
            End If
            ComputerRoom(8) = Room(ComputerRoom(8)).W
            CpuEnterRoom8()
        End If
        If ChooseRoom = 4 And Room(ComputerRoom(8)).W = 0 Then
            'CpuChooseRoom8()
            CpuEnterRoom8()
        End If

    End Sub

    Private Sub CoinSpawn()
        'Chance'
        If Score <= 200 Then
            CoinRoom = Rand(1, 20)
        ElseIf Score <= 400 Then
            CoinRoom = Rand(1, 15)
        ElseIf Score <= 800 Then
            CoinRoom = Rand(1, 12)
        ElseIf Score <= 1600 Then
            CoinRoom = Rand(1, 10)
        ElseIf Score <= 3200 Then
            CoinRoom = Rand(1, 7)
        Else
            CoinRoom = Rand(1, 5)
        End If
        'CoinSpawn'
        If CoinRoom = 1 Then
            CoinRoom = Rand(1, 96)
            While Map(CoinRoom).BackColor = Color.Black Or CoinRoom = PlayerRoom Or CoinRoom = ComputerRoom(1) Or CoinRoom = ComputerRoom(2) Or CoinRoom = ComputerRoom(3) Or CoinRoom = ComputerRoom(4) Or CoinRoom = ComputerRoom(5) Or CoinRoom = ComputerRoom(6) Or CoinRoom = ComputerRoom(7) Or CoinRoom = ComputerRoom(8)
                CoinRoom = Rand(1, 96)
            End While
            Map(CoinRoom).BackColor = Color.Yellow
            Room(CoinRoom).Coin = True
        End If
    End Sub

    Private Sub BTNN_Click(sender As System.Object, e As System.EventArgs) Handles BTNN.Click
        Map(PlayerRoom).BackColor = SystemColors.Control
        PlayerRoom = Room(PlayerRoom).N
        View()
        EnterRoom()
    End Sub

    Private Sub BTNE_Click(sender As System.Object, e As System.EventArgs) Handles BTNE.Click
        Map(PlayerRoom).BackColor = SystemColors.Control
        PlayerRoom = Room(PlayerRoom).E
        View()
        EnterRoom()
    End Sub

    Private Sub BTNS_Click(sender As System.Object, e As System.EventArgs) Handles BTNS.Click
        Map(PlayerRoom).BackColor = SystemColors.Control
        PlayerRoom = Room(PlayerRoom).S
        View()
        EnterRoom()
    End Sub

    Private Sub BTNW_Click(sender As System.Object, e As System.EventArgs) Handles BTNW.Click
        Map(PlayerRoom).BackColor = SystemColors.Control
        PlayerRoom = Room(PlayerRoom).W
        View()
        EnterRoom()
    End Sub

    Private Sub TMRScore_Tick(sender As System.Object, e As System.EventArgs) Handles TMRScore.Tick
        Score += 1
        LBLScore.Text = Score
    End Sub

    Private Sub TMRMove_Tick(sender As System.Object, e As System.EventArgs) Handles TMRMove.Tick
        'If Not TMRMove.Interval = 500 Then
        'MoveCpu += 10
        'End If
        'TMRMove.Interval = 1000 - MoveCpu

        CpuChooseRoom1()
        If CpuSpawn >= 25 Then
            CpuChooseRoom2()
        End If
        If CpuSpawn >= 50 Then
            CpuChooseRoom3()
        End If
        If CpuSpawn >= 75 Then
            CpuChooseRoom4()
        End If
        If CpuSpawn >= 100 Then
            CpuChooseRoom5()
        End If
        If CpuSpawn >= 125 Then
            CpuChooseRoom6()
        End If
        If CpuSpawn >= 150 Then
            CpuChooseRoom7()
        End If
        If CpuSpawn >= 175 Then
            CpuChooseRoom8()
        End If
        If CpuSpawn = 225 Then
            While TMRMove.Interval > 250
                TMRMove.Interval -= 10
            End While
        End If
    End Sub

    Private Sub TimerWall_Tick(sender As System.Object, e As System.EventArgs) Handles TMRWallSpawn.Tick
        'WallSpawn = 101 '<---- disables
        WallSpawn += 1
        If WallSpawn <= 70 Then
            If WallSpawn Mod 5 = 0 Then
                WallRoom = Rand(1, 95)
                'WallRoom = 33 for testing
                If Not WallRoom = PlayerRoom And Not WallRoom = 0 And Not WallRoom = ComputerRoom(1) And Not WallRoom = ComputerRoom(2) And Not WallRoom = ComputerRoom(3) And Not WallRoom = ComputerRoom(4) And Not WallRoom = ComputerRoom(5) And Not WallRoom = ComputerRoom(6) And Not WallRoom = ComputerRoom(7) And Not WallRoom = ComputerRoom(8) Then
                    Map(WallRoom).BackColor = Color.Black
                    If WallRoom <= 80 Then
                        If Not Room(WallRoom + 16).N = 0 Then
                            Room(WallRoom + 16).N = 0
                        End If
                    End If
                    If WallRoom > 16 Then
                        If Not Room(WallRoom - 16).S = 0 Then
                            Room(WallRoom - 16).S = 0
                        End If
                    End If
                    If Not WallRoom = 1 And Not WallRoom = 17 And Not WallRoom = 33 And Not WallRoom = 49 And Not WallRoom = 65 And Not WallRoom = 81 Then
                        If Not Room(WallRoom - 1).E = 0 Then
                            Room(WallRoom - 1).E = 0
                        End If
                    End If
                    If Not WallRoom = 16 And Not WallRoom = 32 And Not WallRoom = 48 And Not WallRoom = 64 And Not WallRoom = 80 And Not WallRoom = 96 Then
                        If Not Room(WallRoom + 1).W = 0 Then
                            Room(WallRoom + 1).W = 0
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TMRCoins_Tick(sender As System.Object, e As System.EventArgs) Handles TMRCoins.Tick
        CoinSpawn()
        CoinSpawn()
        'CoinSpawn()
    End Sub

    Private Sub TMRCpuSpawn_Tick(sender As System.Object, e As System.EventArgs) Handles TMRCpuSpawn.Tick
        CpuSpawn += 1
        'Map(18).BackColor = Color.Orange
        'Map(31).BackColor = Color.Orange
        'Map(66).BackColor = Color.Orange
        'Map(79).BackColor = Color.Orange
        Map(1).BackColor = Color.Orange
        Map(16).BackColor = Color.Orange
        Map(81).BackColor = Color.Orange
        Map(96).BackColor = Color.Orange
        If CpuSpawn Mod 25 = 0 And CpuSpawn <= 175 Then 'might be and Cpuspawn <= 200
            ChooseSpawner = Rand(1, 4)
            If ChooseSpawner = 1 Then
                Computer += 1
                ComputerRoom(Computer) = 1 '18
                Map(ComputerRoom(Computer)).BackColor = Color.Red
            ElseIf ChooseSpawner = 2 Then
                Computer += 1
                ComputerRoom(Computer) = 16 '30
                Map(ComputerRoom(Computer)).BackColor = Color.Red
            ElseIf ChooseSpawner = 3 Then
                Computer += 1
                ComputerRoom(Computer) = 81 '66
                Map(ComputerRoom(Computer)).BackColor = Color.Red
            ElseIf ChooseSpawner = 4 Then
                Computer += 1
                ComputerRoom(Computer) = 96 '78
                Map(ComputerRoom(Computer)).BackColor = Color.Red
            End If
        End If
    End Sub
End Class

Public Class Room
    'Public Player As Bitmap
    'Public Computer As Bitmap
    'Public Wall As Integer
    Public Coin As Boolean
    Public N As Integer
    Public S As Integer
    Public E As Integer
    Public W As Integer
    'Public C As Integer
End Class
