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
        Console.WriteLine($"{letter} {number}")

        For i = 0 To 4
            For j = 0 To 14
                Console.Write($"{(bingoCage(i, j))}   ")
            Next
            Console.WriteLine("")
        Next

        Console.ReadLine()
    End Sub
    Function Roll(value As Integer) As Integer
        Dim number As Integer
        number = CInt(Int((value * Rnd())))
        Return number
    End Function
End Module
