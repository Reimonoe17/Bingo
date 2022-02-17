Module Bingo
    'ToDo how many malls for each letter
    'ToDO draw a random ball (letter and number)
    'ToDo track what balls have come up in an array
    'ToDo don't draw duplicates
    'Clear history on a New Game
    Sub Main()
        Dim bingoCage(4, 14) As Boolean
        Dim row As Integer
        Dim collumn As Integer
        Dim letter As String
        Dim number As Integer

        For i = 1 To 10

            row = Roll(4)

            Select Case row
                Case 0
                    collumn = Roll(14)
                    letter = "B"
                    number = collumn
                Case 1
                    collumn = Roll(14)
                    letter = "I"
                    number = collumn + 15
                Case 2
                    collumn = Roll(14)
                    letter = "N"
                    number = collumn + 30
                Case 3
                    collumn = Roll(14)
                    letter = "G"
                    number = collumn + 45
                Case 4
                    collumn = Roll(14)
                    letter = "O"
                    number = collumn + 60
            End Select

            bingoCage(row, collumn) = True


        Next

        DisplayBingoCage(bingoCage)

        'For i = 0 To 4
        '    For j = 0 To 14
        '        Console.Write($"{(bingoCage(i, j))}   ")
        '    Next
        '    Console.WriteLine("")
        'Next

        Console.ReadLine()
    End Sub
    Function Roll(value As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Dim number As Integer
        number = CInt(Int((value * Rnd())))
        Return number
    End Function

    Sub DisplayBingoCage(ByRef bingoCage(,) As Boolean)
        Dim header() As String = {"B", "I", "N", "G", "O"}
        Dim columnWidth As Integer = 3
        Dim columnData As String

        For row = 0 To bingoCage.GetLength(1)
            For column = 0 To bingoCage.GetLength(0) - 1
                Select Case row
                    Case 0 'first row is column headers
                        columnData = header(column).PadLeft(columnWidth)
                    Case Else
                        If Not bingoCage(column, row - 1) Then 'mark if ball has been drawn
                            columnData = "  "
                        Else 'show number if ball hasn't been drawn
                            columnData = CStr(((column) * bingoCage.GetLength(1)) + row)
                        End If
                End Select
                Console.Write(columnData.PadLeft(columnWidth) & " |")
            Next
            Console.WriteLine()
            Console.WriteLine(StrDup(25, "-"))
        Next

    End Sub
End Module
