Public Class Form1
    Private startSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\chord.wav")
    Public k As Integer = 0
    Public n As Integer = 0
    Private Sub MoveToStart()
        Dim startingPoint = Button1.Location
        startingPoint.Offset(0, 0)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub
    Private Sub wall_MouseEnter() Handles Label2.MouseEnter, Label3.MouseEnter,
Label4.MouseEnter, Label5.MouseEnter, Label6.MouseEnter, Label7.MouseEnter,
Label8.MouseEnter, Label9.MouseEnter, Label10.MouseEnter, Label11.MouseEnter,
Label12.MouseEnter, Label13.MouseEnter, Label14.MouseEnter, Label15.MouseEnter,
Label16.MouseEnter, Label17.MouseEnter, Label18.MouseEnter
        If n <> 0 Then
            If k < n Then
                startSoundPlayer.Play()
                k += 1
                MoveToStart()
            Else
                disp(k)
                Close()
            End If
        End If
    End Sub
    Private Sub wallFinish() Handles Label19.MouseEnter
        If n <> 0 Then
            Me.BackColor = Color.Green
            MessageBox.Show("Вы успешно прошли лабиринт")
            Close()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        route(n)
        MoveToStart()
    End Sub
End Class


