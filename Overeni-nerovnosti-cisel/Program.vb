Option Explicit On
Imports System

Module Program
    Sub Main()
        Console.WriteLine("Ur�ete, zda dv� zadan� ��sla x, y spl�uj� nerovnost x+3 < 5y-1")
        Console.Write("Zadej prom�nnou X: ")
        Dim x = Console.ReadLine()
        Console.Write("Zadej prom�nnou Y: ")
        Dim y = Console.ReadLine()

        If (x + 3) < (5 * y - 1) Then
            Console.WriteLine("Podm�nka byla spln�na.")
        Else
            Console.WriteLine("Podm�nka nebyla spln�na.")
        End If

    End Sub
End Module
