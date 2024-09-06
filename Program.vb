Imports System.Console

Module Program
    Sub Main()
        Dim num As Integer
        WriteLine("enter the number")
        num = ReadLine()
        If num > 21 And num < 29 Then
            WriteLine("your number is within range")
        Else
            WriteLine("out of range")

        End If
        ReadKey()
    End Sub
End Module
