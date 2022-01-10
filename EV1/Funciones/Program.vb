Imports System

Module Program
    Sub Main()
        Dim restultado As Integer
        Dim nuevoValor As Integer
        Dim valor As Integer
        Dim Cadena As String
        If IsNumeric(Cadena) Then


        End If
        If IsDate(Cadena) Then


        End If
        Dim colores() As String = {"Azul", "Verde", "Rojo", "Amarillo"}
        ' Verificar(colores)
        'Console.WriteLine(Int(66.88))
        'Console.WriteLine(Fix(66.88))
        'Len(Cadena)
        'Cadena = Space(5)
        'InStr([comienzo,] cadenabuscar, Cadena buscada [,tipocomparacion])
        'Left(Cadena, 3[longitud])
        'Right(Cadena, 3[longitud])
        'Mid(Cadena, 3[longitud])
        'Replace(Cadena, CadenaOrigen, cadnuev[,inicio][,sustitución][,tipoconversión])
        'LTrim(Cadena)
        'RTrim(Cadena)
        'Trim(Cadena)
        'UCase(Cadena)
        'LCase(Cadena)

        Dim fecha As Date
        Dim numero As Double
        Dim ValorFormato As String
        numero = 1899
        fecha = #10/25/2021 3:35:08 PM#

        'Date
        Console.WriteLine(Format(fecha, "Long Date"))
        Console.WriteLine(Format(fecha, "Short Date"))
        'Nums
        Console.WriteLine(Format(numero, "Standard"))
        Console.WriteLine(Format(numero, "Currency"))
        Console.WriteLine(Format(numero, "Percent"))





        Console.ReadLine()


            


    End Sub
    Private Sub Verificar(ValorPasado As Object)
        If IsArray(ValorPasado) Then
            Console.WriteLine(IsArray(ValorPasado))
        End If
    End Sub

    Private Function calcular() As Integer 'si no pones private ni public, la privada será la default
        Dim miValor As Integer
        Console.WriteLine("Introduce un vaor del 1 a 100")
        miValor = Console.ReadLine()
        Return miValor

    End Function

End Module
