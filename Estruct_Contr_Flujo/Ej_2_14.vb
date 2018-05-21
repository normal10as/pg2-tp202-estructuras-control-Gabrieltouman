Module Ej_2_14
    Sub Main()

        Dim cantidad As Integer
        Dim precio As Single
        Dim subtotal As Single
        Dim descuento As Single = 0
        Dim porcentaje_desc As Byte = 0  'Valor de porcentaje
        Dim total_descuento As Single
        Dim total As Single

        Do
            Console.WriteLine("Ingrese Cantidad")
            cantidad = Console.ReadLine

            Console.WriteLine(vbCrLf & "Ingrese Precio")
            precio = Console.ReadLine

            subtotal = cantidad * precio

            Console.WriteLine(vbCrLf & "SUBTOTAL: " & subtotal)

            If cantidad >= 10 Then
                If cantidad <= 50 Then
                    porcentaje_desc = 5
                ElseIf cantidad <= 250 Then
                    porcentaje_desc = 10
                Else
                    porcentaje_desc = 20
                End If
            End If

            descuento = subtotal * porcentaje_desc / 100.0
            total_descuento += descuento
            total += subtotal - descuento

            Console.WriteLine(vbCrLf & "DESCUENTO DE " & porcentaje_desc & "%: " & descuento)
            Console.WriteLine(vbCrLf & "TOTAL: " & subtotal - descuento)
            Console.WriteLine(vbCrLf & "---------------------------------" & vbCrLf)
        Loop While cantidad <> 0

        Console.WriteLine(vbCrLf & "TOTAL DE DESCUENTOS: " & total_descuento)
        Console.WriteLine(vbCrLf & "TOTAL A ABONAR: " & total)

        Console.ReadKey()

    End Sub


End Module
