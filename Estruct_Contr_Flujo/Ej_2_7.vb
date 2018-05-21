Module Ej_2_7
    Sub Main()
        Dim valor As Short

        Console.WriteLine("Ingrese valor del ángulo: ")
        valor = Console.ReadLine

        Select Case valor
            Case 0 To 89
                Console.WriteLine(vbCrLf & "Es un ángulo Agudo")
            Case 90
                Console.WriteLine(vbCrLf & "Es un ángulo Recto")
            Case 91 To 179
                Console.WriteLine(vbCrLf & "Es un ángulo Obtuso")
            Case 180
                Console.WriteLine(vbCrLf & "Es un ángulo Llano")
            Case 181 To 360
                Console.WriteLine(vbCrLf & "Es un ángulo Cóncavo")
            Case Else
                Console.WriteLine(vbCrLf & "ERROR!!!")
        End Select

        Console.ReadKey()

    End Sub

End Module
