Module Ej_2_2
    Sub Main()
        Dim valor_1 As Integer
        Dim valor_2 As Integer
        Dim valor_3 As Integer

        Console.Write("Ingrese Primer Valor: ")
        valor_1 = Console.ReadLine
        Console.Write("Ingrese Segundo Valor: ")
        valor_2 = Console.ReadLine
        Console.Write("Ingrese Tercer Valor: ")
        valor_3 = Console.ReadLine

        If valor_1 > valor_2 Then
            valor_1 = valor_2
        End If
        If valor_3 < valor_1 Then
            valor_1 = valor_3
        End If

        Console.WriteLine(vbCrLf & "El menor valor es = " & valor_1)

        Console.ReadKey()
    End Sub

End Module
