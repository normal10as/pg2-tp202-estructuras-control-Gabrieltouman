Module Ej_2_15
    Sub Main()

        Dim capital As Single
        Dim meses As UShort
        Const tasa_interes As Single = 0.03        '(36/100)% / 12 meses
        Dim interes As Single
        Dim total_interes As Single
        Console.Write("Ingrese capital: ")
        capital = Console.ReadLine()
        Console.Write(vbCrLf & "Ingrese cantidad de meses: ")
        meses = Console.ReadLine()
        Console.WriteLine(vbCrLf & "{0, 4}{1, 15}{2, 15}{3, 15}", "MES", "CAPITAL", "INTERES", "SALDO")

        For inicio = 1 To meses
            interes = capital * tasa_interes
            total_interes += interes
            Console.WriteLine("{0, 4}{1, 15}{2, 15}{3, 15}", Math.Round(inicio, 2), Math.Round(capital, 2), Math.Round(interes, 2), Math.Round(capital + interes, 2))
            capital += interes
        Next

        Console.WriteLine(vbCrLf & "TOTAL INTERES GANADO: " & Math.Round(total_interes, 2))

        Console.ReadKey()

    End Sub
End Module
