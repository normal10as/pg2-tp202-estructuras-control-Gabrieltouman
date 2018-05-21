Module Ej_2_4
    Sub Main()

        Dim cantidad As UInteger
        Dim precio As Single
        Dim subtotal As Single
        Dim descuento As Single = 0
        Dim porcentaje_desc As Byte = 0  'Valor de porcentaje

        Console.WriteLine("Ingrese Cantidad")
        cantidad = Console.ReadLine
        Console.WriteLine(vbCrLf & "Ingrese Precio")
        precio = Console.ReadLine

        subtotal = cantidad * precio

        Console.WriteLine(vbCrLf & "SUBTOTAL: $" & subtotal)

        If cantidad >= 10 And cantidad <= 50 Then
            porcentaje_desc = 5
        ElseIf cantidad >= 51 And cantidad <= 250 Then
            porcentaje_desc = 10
        End If
        If cantidad > 250 Then
            porcentaje_desc = 20
        End If

        descuento = subtotal * porcentaje_desc / 100.0

        Console.WriteLine(vbCrLf & "DESCUENTO DE " & porcentaje_desc & "%: $" & descuento)
        Console.WriteLine(vbCrLf & "TOTAL: $" & subtotal - descuento)

        Console.ReadKey()

    End Sub

End Module
