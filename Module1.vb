Module Module1
    Public Sub route(ByRef n As Integer)
        n = CInt(InputBox("Введите количество касаний"))
    End Sub
    Public Sub disp(ByRef k As Integer)
        MessageBox.Show("Вы каснулсь " & k & " раз. Все давай снова.")
    End Sub
End Module
