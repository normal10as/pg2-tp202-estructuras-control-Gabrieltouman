Module Ej_2_6
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

        Select Case cantidad
            Case 10 To 50
                porcentaje_desc = 5
            Case 51 To 250
                porcentaje_desc = 10
            Case Is > 250
                porcentaje_desc = 20
        End Select

        descuento = subtotal * porcentaje_desc / 100.0

        Console.WriteLine(vbCrLf & "DESCUENTO DE " & porcentaje_desc & "%: $" & descuento)
        Console.WriteLine(vbCrLf & "TOTAL: $" & subtotal - descuento)

        Console.ReadKey()
    End Sub
End Module
