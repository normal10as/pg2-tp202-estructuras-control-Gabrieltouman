Module Ej_2_1

    Sub Main()
        Dim valor_1 As Integer
        Dim valor_2 As Integer

        Console.Write("Ingrese valor: ")
        valor_1 = Console.ReadLine
        Console.WriteLine()
        Console.Write("Ingrese siguiente valor: ")
        valor_2 = Console.ReadLine
        Console.WriteLine()

        If valor_1 < valor_2 Then
            Console.WriteLine(valor_1 & " es menor a " & valor_2)
        ElseIf valor_1 > valor_2 Then
            Console.WriteLine(valor_1 & " es mayor a " & valor_2)
        Else
            Console.WriteLine(valor_1 & " y " & valor_2 & " son iguales")
        End If

        Console.ReadKey()

    End Sub

End Module
