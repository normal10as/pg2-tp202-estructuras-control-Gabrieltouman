Module Ej_2_3
    Sub Main()

        Dim valor_1 As Integer
        Dim valor_2 As Integer
        Dim posicion As String = "Primer"

        Console.WriteLine("Ingrese Primer Valor")
        valor_1 = Console.ReadLine
        Console.WriteLine(vbCrLf & "Ingrese Segundo Valor")
        valor_2 = Console.ReadLine

        If valor_1 = valor_2 Then
            posicion += " y Segundo"
        ElseIf valor_1 < valor_2 Then
            valor_1 = valor_2
            posicion = "Segundo"
        End If

        Console.WriteLine(vbCrLf & "Ingrese Tercer Valor")
        valor_2 = Console.ReadLine

        If valor_1 = valor_2 Then
            posicion += " y Tercer"
        ElseIf valor_1 < valor_2 Then
            valor_1 = valor_2
            posicion = "Tercer"
        End If

        Console.WriteLine(vbCrLf & "Ingrese Cuarto Valor")
        valor_2 = Console.ReadLine

        If valor_1 = valor_2 Then
            posicion += " y Cuarto"
        ElseIf valor_1 < valor_2 Then
            valor_1 = valor_2
            posicion = "Cuarto"
        End If

        Console.WriteLine(vbCrLf & "Ingrese Quinto Valor")
        valor_2 = Console.ReadLine

        If valor_1 = valor_2 Then
            posicion += " y Quinto"
        ElseIf valor_1 < valor_2 Then
            valor_1 = valor_2
            posicion = "Quinto"
        End If

        Console.WriteLine(vbCrLf & "El " & posicion & " numero 'es/son' 'el/los' de mayor valor")

        Console.ReadKey()

    End Sub

End Module
