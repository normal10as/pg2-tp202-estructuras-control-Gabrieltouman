Module Ej_2_13
    Sub Main()

        Dim divisor As UShort
        Dim primo As Integer

        For valor = 1 To 1000
            divisor = 1
            primo = 0
            Do
                If valor Mod divisor = 0 Then
                    primo += 1
                End If
                divisor += 1
            Loop While divisor <= valor
            If primo = 2 Then
                Console.Write("|" & valor)
            End If
        Next

        Console.ReadKey()
    End Sub
End Module
