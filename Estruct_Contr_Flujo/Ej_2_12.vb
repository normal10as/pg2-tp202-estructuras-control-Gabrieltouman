Module Ej_2_12
    Sub Main()

        Dim valor1 As Integer = 0
        Dim valor2 As Integer = 1

        Console.WriteLine("Sucesion de Fibonacci: ")
        Console.WriteLine(valor1)
        Console.WriteLine(valor2)

        For inicio = 1 To 9    ' Imprimo 2 valores por iteracion asi que el FIN del FOR debe ser la mitad del total a mostrar
            valor1 += valor2
            Console.WriteLine(valor1)
            valor2 += valor1
            Console.WriteLine(valor2)
        Next

        Console.ReadKey()

    End Sub

End Module
