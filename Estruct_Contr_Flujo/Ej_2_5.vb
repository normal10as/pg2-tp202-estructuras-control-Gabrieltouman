Module Ej_2_5
    Sub Main()

        Dim mes As Byte

        Console.WriteLine("Ingrese un numero del 1 al 12")
        mes = Console.ReadLine()

        Select Case mes
            Case 1
                Console.WriteLine("Enero")
            Case 2
                Console.WriteLine("Febrero")
            Case 3
                Console.WriteLine("Marzo")
            Case 4
                Console.WriteLine("Abril")
            Case 5
                Console.WriteLine("Mayo")
            Case 6
                Console.WriteLine("Junio")
            Case 7
                Console.WriteLine("Julio")
            Case 8
                Console.WriteLine("Agosto")
            Case 9
                Console.WriteLine("Septiembre")
            Case 10
                Console.WriteLine("Octubre")
            Case 11
                Console.WriteLine("Noviembre")
            Case 12
                Console.WriteLine("Diciembre")
            Case Else
                Console.WriteLine("Valor Incorrecto")
        End Select

        Console.ReadLine()

    End Sub
End Module
