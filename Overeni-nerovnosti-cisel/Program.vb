Option Explicit On
Imports System

Module Program
    Sub Main()
        Console.WriteLine("Urèete, zda dvì zadaná èísla x, y splòují nerovnost x+3 < 5y-1")
        Console.Write("Zadej promìnnou X: ")
        Dim x = Console.ReadLine()
        Console.Write("Zadej promìnnou Y: ")
        Dim y = Console.ReadLine()

        If (x + 3) < (5 * y - 1) Then
            Console.WriteLine("Podmínka byla splnìna.")
        Else
            Console.WriteLine("Podmínka nebyla splnìna.")
        End If

    End Sub
End Module
