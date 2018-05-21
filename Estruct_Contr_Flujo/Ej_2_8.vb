Module Ej_2_8
    Enum meses_anio
        enero = 1
        febrero
        marzo
        abril
        mayo
        junio
        julio
        agosto
        septiembre
        octubre
        noviembre
        diciembre
    End Enum

    Sub Main()

        Dim mes As Byte
        Dim anio As UShort
        Dim dias As Byte

        Console.WriteLine("Ingrese un mes (1 al 12): ")
        mes = Console.ReadLine()

        If mes = meses_anio.febrero Then
            Console.WriteLine(vbCrLf & "Ingrese el año: ")
            anio = Console.ReadLine()
            ' Si es Febrero, evaluo si el año es bisiesto o no y asigno la cantidad de dias
            If anio Mod 400 = 0 Or anio Mod 4 = 0 And anio Mod 100 <> 0 Then
                dias = 29
            Else
                dias = 28
            End If
            ' Si no es Febrero, evaluo si es un mes de 30 o 31 dias
        ElseIf mes < 8 And mes Mod 2 <> 0 Or mes > 7 And mes Mod 2 = 0 Then
            dias = 31
        Else
            dias = 30
        End If

        Select Case mes
            Case meses_anio.enero
                Console.WriteLine(vbCrLf & "Se ingresó Enero y tiene " & dias & " días")
            Case meses_anio.febrero
                Console.WriteLine(vbCrLf & "Se ingresó Febrero del " & anio & " y tiene " & dias & " días")
            Case meses_anio.marzo
                Console.WriteLine(vbCrLf & "Se ingresó Marzo y tiene " & dias & " días")
            Case meses_anio.abril
                Console.WriteLine(vbCrLf & "Se ingresó Abril y tiene " & dias & " días")
            Case meses_anio.mayo
                Console.WriteLine(vbCrLf & "Se ingresó Mayo y tiene " & dias & " días")
            Case meses_anio.junio
                Console.WriteLine(vbCrLf & "Se ingresó Junio y tiene " & dias & " días")
            Case meses_anio.julio
                Console.WriteLine(vbCrLf & "Se ingresó Julio y tiene " & dias & " días")
            Case meses_anio.agosto
                Console.WriteLine(vbCrLf & "Se ingresó Agosto y tiene " & dias & " días")
            Case meses_anio.septiembre
                Console.WriteLine(vbCrLf & "Se ingresó Septiembre y tiene " & dias & " días")
            Case meses_anio.octubre
                Console.WriteLine(vbCrLf & "Se ingresó Octubre y tiene " & dias & " días")
            Case meses_anio.noviembre
                Console.WriteLine(vbCrLf & "Se ingresó Noviembre y tiene " & dias & " días")
            Case meses_anio.diciembre
                Console.WriteLine(vbCrLf & "Se ingresó Diciembre y tiene " & dias & " días")
            Case Else
                Console.WriteLine(vbCrLf & "Error en el valor del mes")
        End Select

        Console.ReadKey()

    End Sub
End Module
