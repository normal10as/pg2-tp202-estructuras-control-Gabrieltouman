Module Ej_2_10
    Sub Main()
        Dim valor1, valor2, aux_valor1 As Integer
        Dim cantidad_multiplos As UShort

        Console.WriteLine("Ingrese un valor: ")
        valor1 = Console.ReadLine()
        Console.WriteLine("Ingrese otro valor (mayor al primero): ")
        valor2 = Console.ReadLine()

        Console.WriteLine(vbCrLf & "----- DO WHILE LOOP -----")
        Console.WriteLine("Los multiplos de 5 entre " & valor1 & " y " & valor2 & " son:" & vbCrLf)

        aux_valor1 = valor1

        Do While aux_valor1 <= valor2
            If aux_valor1 Mod 5 = 0 Then
                Console.WriteLine(aux_valor1)
                cantidad_multiplos += 1
            End If
            aux_valor1 += 1
        Loop

        If cantidad_multiplos = 0 Then
            Console.WriteLine(vbCrLf & "No existen multiplos de 5 en el rango ingresado")
        Else
            Console.WriteLine(vbCrLf & "Cantidad de multiplos: " & cantidad_multiplos)
        End If

        '------------------------------------------------------------------------------------------

        Console.WriteLine(vbCrLf & "----- DO LOOP WHILE -----")
        Console.WriteLine("Los multiplos de 5 entre " & valor1 & " y " & valor2 & " son:" & vbCrLf)

        aux_valor1 = valor1
        cantidad_multiplos = 0

        Do

            If aux_valor1 Mod 5 = 0 Then
                Console.WriteLine(aux_valor1)
                cantidad_multiplos += 1
            End If
            aux_valor1 += 1

        Loop While aux_valor1 <= valor2
        If cantidad_multiplos = 0 Then
            Console.WriteLine(vbCrLf & "No existen multiplos de 5 en el rango ingresado")
        Else
            Console.WriteLine(vbCrLf & "Cantidad de multiplos: " & cantidad_multiplos)
        End If

        '------------------------------------------------------------------------------------------

        Console.WriteLine(vbCrLf & "----- DO UNTIL LOOP -----")
        Console.WriteLine("Los multiplos de 5 entre " & valor1 & " y " & valor2 & " son:" & vbCrLf)

        aux_valor1 = valor1
        cantidad_multiplos = 0

        Do Until aux_valor1 > valor2

            If aux_valor1 Mod 5 = 0 Then
                Console.WriteLine(aux_valor1)
                cantidad_multiplos += 1
            End If
            aux_valor1 += 1

        Loop
        If cantidad_multiplos = 0 Then
            Console.WriteLine(vbCrLf & "No existen multiplos de 5 en el rango ingresado")
        Else
            Console.WriteLine(vbCrLf & "Cantidad de multiplos: " & cantidad_multiplos)
        End If

        '------------------------------------------------------------------------------------------

        Console.WriteLine(vbCrLf & "----- DO LOOP UNTIL -----")
        Console.WriteLine("Los multiplos de 5 entre " & valor1 & " y " & valor2 & " son:" & vbCrLf)

        aux_valor1 = valor1
        cantidad_multiplos = 0

        Do

            If aux_valor1 Mod 5 = 0 Then
                Console.WriteLine(aux_valor1)
                cantidad_multiplos += 1
            End If
            aux_valor1 += 1

        Loop Until aux_valor1 > valor2
        If cantidad_multiplos = 0 Then
            Console.WriteLine(vbCrLf & "No existen multiplos de 5 en el rango ingresado")
        Else
            Console.WriteLine(vbCrLf & "Cantidad de multiplos: " & cantidad_multiplos)
        End If

        '------------------------------------------------------------------------------------------

        Console.WriteLine(vbCrLf & "----- FOR NEXT -----")
        Console.WriteLine("Los multiplos de 5 entre " & valor1 & " y " & valor2 & " son:" & vbCrLf)

        cantidad_multiplos = 0

        For aux_valor1 = valor1 To valor2

            If aux_valor1 Mod 5 = 0 Then
                Console.WriteLine(aux_valor1)
                cantidad_multiplos += 1
            End If

        Next
        If cantidad_multiplos = 0 Then
            Console.WriteLine(vbCrLf & "No existen multiplos de 5 en el rango ingresado")
        Else
            Console.WriteLine(vbCrLf & "Cantidad de multiplos: " & cantidad_multiplos)
        End If

        Console.ReadKey()

    End Sub

End Module
