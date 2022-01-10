Module Module2
    Public ValorError As Exception
    Public Sub ControlErrores(ex As Exception)
        Dim Message As String
        'Console.WriteLine("Error: " & ValorError.ToString)
        'Console.WriteLine("Error: " & ex.Message)

        If ex.Message.Contains("El índice estaba fuera del intervalo. Debe ser un valor no negativo e inferior al tamaño de la colección.") Then
            Message = "fuera del intervalo"
        ElseIf ex.Message.Contains("La conversión de la cadena") And ex.Message.Contains("en el tipo 'Integer' no es válida.") Then
            Message = "integer not string"
        Else
            Message = ex.Message
        End If



        Select Case Message
            Case "La operación aritmética ha provocado un desbordamiento."
                Console.WriteLine("Elemeto no encontrado.")

            Case "fuera del intervalo"
                Console.WriteLine("La posicion indicada es superior a la posición mínima o máxima")

            Case "integer not string"
                Console.WriteLine("Un integer no puede contener una cadena String")

            Case Else
                Console.WriteLine("Error desconocido: {0}", CInt(Math.Ceiling(Rnd() * Int(Date.Now.Millisecond) / 100))) 'RANDOM
                Console.WriteLine(ex.Message)

        End Select


    End Sub
End Module
