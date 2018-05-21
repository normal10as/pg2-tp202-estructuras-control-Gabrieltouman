Module Ej_2_11
    Sub Main()

        Dim valor As Integer
        Dim pares As Short
        Dim impares As Short
        Dim HayPositivos As Boolean

        Do
            Console.WriteLine("Ingrese un valor positivo o 0 para salir")
            valor = Console.ReadLine()
            If valor > 0 Then
                HayPositivos = True ' Para validar que se ingreso al menos 1 valor positivo
                If valor Mod 2 = 0 Then
                    pares += 1
                Else
                    impares += 1
                End If
            End If
        Loop While valor <> 0

        If HayPositivos Then
            If pares = 0 Then
                Console.WriteLine("Todos son impares")
            ElseIf impares = 0 Then
                Console.WriteLine("Todos son pares")
            Else
                Console.WriteLine("Pares: " & pares)
                Console.WriteLine("Impares: " & impares)
            End If
        Else
            Console.WriteLine("No se ingresó numeros positivos")
        End If

        Console.ReadKey()
    End Sub
End Module
