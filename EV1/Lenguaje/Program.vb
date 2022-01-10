Option Explicit Off 'Deshabilita la compilación
Imports System

Module Program
    Sub Main(args As String())
        'Console.WriteLine("Hello World!")
        Dim nombre As String
        Dim numero As Integer

        nombre = "Tere"
        numero = 125
        'Console.Write("Nombre: " & nombre & " Numero: " & numero)
        'Console.Write("Nombre: {0} Numero: {1}", nombre, numero)
        'Console.ReadLine()

        'Console.WriteLine("Nombre: " & nombre & " Numero: " & numero)

        Dim lineaTexto As String

        'Console.Write("Introduzca un texto: ")
        'lineaTexto = Console.ReadLine()
        'Console.Write("Introduciste el texto {0}", lineaTexto)

        Dim codTecla As Integer
        Dim nombreTecla As Char


        Console.WriteLine("Pulsa una tecla: ")
        While True
            Console.ReadLine()
            codTecla = Console.Read()
            If codTecla = 13 Then
                Exit While
            End If
            Console.WriteLine("El codigo de la tecla es: {0} el caracter es: {1}", codTecla, Chr(codTecla))

        End While

        'Dim Nombre, Apellido, Ciudad As String
        'Dim MiValor, Total112, Total_98 As Integer

        'Boolean
        'Byte
        'Char
        'Date
        'Decimal
        'Double
        'Integer
        'Long
        'Short
        'Single
        'Object
        'String

        Dim FhActual As Date
        Dim FhNueva As Date
        Dim FhCompletaUno As Date
        Dim FhCompletaDos As Date
        Dim FhHora
        Dim Correcto As Boolean
        Dim Obj As Object

        FhActual = #10/21/2021# 'Anglosajón
        Console.WriteLine("Fecha: {0}", FhActual)
        Console.ReadLine()

        FhNueva = "21/10/2021"  'El otro
        FhCompletaUno = #10/21/2021 04:18:00 PM# '#10/21/2021 16:18:00#
        FhCompletaUno = "21/10/2021 16:18:00"
        FhHora = #4:18:00 PM#
        Dim NuevaCadena As String

        If NuevaCadena = "" Then Console.WriteLine("Cadena: {0}", NuevaCadena)

        If Obj Is Nothing Then Console.WriteLine("Object: {0}", Obj)

        Dim Valor As String
        Valor = "Un valor de prueba"
        NuevaCadena = Valor
        FhActual = Nothing







        Dim Colores(4) As String

        Colores(3) = "Azul"


        Console.WriteLine("Colores: {0}", Colores(3))





    End Sub
End Module
