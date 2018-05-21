Module Ej_2_9
    Enum unidades_medida
        metros = 1
        yardas
        pies
        pulgadas
    End Enum

    Sub Main()

        Dim unidad_medida As Short
        Dim valor_convertir As Single

        Const centimetro As Single = 1
        Const metro As Single = 100.0 * centimetro
        Const pulgada As Single = 2.54 * centimetro
        Const pie As Single = 12.0 * pulgada
        Const yarda As Single = 3.0 * pie

        Console.WriteLine("Escoja la unidad de medida a convertir: " & vbCrLf)
        Console.WriteLine("Metros = 1" & vbCrLf & "Yardas = 2" & vbCrLf & "Pies = 3" & vbCrLf & "Pulgadas = 4" & vbCrLf)
        unidad_medida = Console.ReadLine()

        If unidad_medida < 1 Or unidad_medida > 4 Then
            Console.WriteLine(vbCrLf & "Valor no admitido!!!")
        Else
            Console.WriteLine(vbCrLf & "Ingrese el valor que desea convertir: ")
            valor_convertir = Console.ReadLine()

            Select Case unidad_medida
                Case unidades_medida.metros
                    Console.WriteLine(vbCrLf & valor_convertir & " Metro/s equivale a:" & vbCrLf)
                    Console.WriteLine(valor_convertir / pulgada * metro & " Pulgadas")
                    Console.WriteLine(valor_convertir / pie * metro & " Pies")
                    Console.WriteLine(valor_convertir / yarda * metro & " Yardas")
                    Console.WriteLine(valor_convertir / centimetro * 100 & " Centimetros")
                Case unidades_medida.pies
                    Console.WriteLine(vbCrLf & valor_convertir & " Pie/s equivale a:" & vbCrLf)
                    Console.WriteLine(valor_convertir / metro * pie & " Metros")
                    Console.WriteLine(valor_convertir / pulgada * pie & " Pulgadas")
                    Console.WriteLine(valor_convertir / yarda * pie & " Yardas")
                    Console.WriteLine(valor_convertir / centimetro * pie & " Centimetros")
                Case unidades_medida.pulgadas
                    Console.WriteLine(vbCrLf & valor_convertir & " Pulgada/s equivale a:" & vbCrLf)
                    Console.WriteLine(valor_convertir / metro * pulgada & " Metros")
                    Console.WriteLine(valor_convertir / pie * pulgada & " Pies")
                    Console.WriteLine(valor_convertir / yarda * pulgada & " Yardas")
                    Console.WriteLine(valor_convertir / centimetro * pulgada & " Centimetros")
                Case unidades_medida.yardas
                    Console.WriteLine(vbCrLf & valor_convertir & " Yarda/s equivale a:" & vbCrLf)
                    Console.WriteLine(valor_convertir / metro * yarda & " Metros")
                    Console.WriteLine(valor_convertir / pie * yarda & " Pies")
                    Console.WriteLine(valor_convertir / pulgada * yarda & " Pulgadas")
                    Console.WriteLine(valor_convertir / centimetro * yarda & " Centimetros")
            End Select
        End If

        Console.ReadLine()

    End Sub
End Module
