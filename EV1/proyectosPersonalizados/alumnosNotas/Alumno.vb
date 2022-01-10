Module Module2
    Sub Main()
        Dim alumno As New Alumno(1, "Ruben", "Zunniga", "20/04/2021")
        alumno.notas.nuevaAsignatura(0) = "Python"
        alumno.notas.nuevaAsignatura(0) = "Java"

        Console.WriteLine(alumno.AsignaturasAlumno(0))

        Dim notasarr As String(,) = alumno.notas.obtenerNotas()

        alumno.notas.setnotaAsignatura("Java", 7)

        alumno.notas.obtenerNotas()

        Console.ReadLine()
    End Sub
End Module

Public Class Alumno

    Private nmat As Integer
    Private nombre As String, apellidos As String
    Private fechaNaci As Date
    Public notas As New Notas()

    Sub New()

    End Sub
    Sub New(numMat As Integer, name As String, lastname As String, birthday As Date)
        nmat = numMat
        nombre = name
        apellidos = lastname
        fechaNaci = birthday
    End Sub

    Public Property matricula As Integer
        Get
            Return nmat
        End Get
        Set(value As Integer)
            nmat = value
        End Set
    End Property
    Public Property nombreAlumno As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Public Property apellidosAlumno As String
        Get
            Return apellidos
        End Get
        Set(value As String)
            apellidos = value
        End Set
    End Property
    Public Property fechaNacimiento As String
        Get
            Return fechaNaci
        End Get
        Set(value As String)
            fechaNaci = value
        End Set
    End Property
    Default Public Property AsignaturasAlumno(ByVal index As Integer) As String 'Crear nueva asignatura o modificarla
        Get
            Return notas.nuevaAsignatura(index)
        End Get
        Set(value As String)
            notas.nuevaAsignatura(index) = value
        End Set
    End Property

End Class
Public Class Notas
    Private asignaturas As New ArrayList
    Private ev1 As New ArrayList
    Private ev2 As New ArrayList
    Private ev3 As New ArrayList
    Private FinalOrdinaria As New ArrayList
    Private FinalExtraordinaria As New ArrayList

    Sub New()

    End Sub

    Public Function obtenerNotas()
        Dim len As Integer
        len = asignaturas.Count
        Dim x As Integer = 6
        Dim notasarr(x, len) As String

        For i As Integer = 0 To x - 1
            For j As Integer = 0 To len - 1
                If i = 0 Then
                    notasarr(i, j) = asignaturas.Item(j).ToString()
                ElseIf i = 1 Then
                    notasarr(i, j) = ev1.Item(j).ToString()
                ElseIf i = 2 Then
                    notasarr(i, j) = ev2.Item(j).ToString()
                ElseIf i = 3 Then
                    notasarr(i, j) = ev3.Item(j).ToString()
                ElseIf i = 4 Then
                    notasarr(i, j) = FinalOrdinaria.Item(j).ToString()
                ElseIf i = 5 Then
                    notasarr(i, j) = FinalExtraordinaria.Item(j).ToString()
                End If

            Next
        Next

        For i As Integer = 0 To x - 1
            If i = 0 Then
                Console.Write("|    ")
            Else
                Console.Write("|{0}", vbTab)
            End If

            For j As Integer = 0 To len - 1
                If i = 0 Then
                    Console.Write(notasarr(i, j) + "{0}|     ", vbTab)
                Else
                    Console.Write(notasarr(i, j) + "{0}|{1}", vbTab, vbTab)
                End If
            Next
            Console.WriteLine()
        Next

        Return notasarr

    End Function

    Public Function verNotas()
        Dim notasarr As String(,) = obtenerNotas()
        Dim len As Integer = notasarr.Length()

        For i As Integer = 0 To len - len - 1
            Console.Write("| ")
            For j As Integer = 0 To len - 1
                Console.Write(notasarr(i, j) + " | ")
            Next
            Console.WriteLine()
        Next

        Return notasarr
    End Function


    Default Public Property nuevaAsignatura(ByVal index As Integer) As String
        Get
            Return asignaturas.Item(index)
        End Get
        Set(value As String)
            asignaturas.Add(value)
            Dim evalu As Integer = selecEval()
            introducirNotaEvaluacion(evalu, value)
        End Set
    End Property

    Public Property introducirNota(ByVal index As Integer) As Double
        Set(value As Double)
            ev1.Add(value)
        End Set
        Get
            Return Double.Parse(ev1.Item(index))
        End Get
    End Property

    Public Sub setnotaAsignatura(nombreAsgn As String, nota As Double)
        Dim position As Integer
        position = asignaturas.IndexOf(nombreAsgn)

        If position = -1 Then
            Console.WriteLine("La asignatura que buscas no está registrada, registrela para poder añadir una nota")
            Return
        End If

        Dim evalu As Integer = selecEval()
        nota = selecNota(nombreAsgn)

        Select Case (evalu)
            Case 1
                ev1.Insert(position, nota)
            Case 2
                ev2.Insert(position, nota)
            Case 3
                ev3.Insert(position, nota)
            Case 4
                FinalOrdinaria.Insert(position, nota)
            Case 5
                FinalExtraordinaria.Insert(position, nota)
        End Select


    End Sub

    Private Sub introducirNotaEvaluacion(cual As Integer, nomAsign As String)
        Dim nota As Double

        nota = selecNota(nomAsign)

        Select Case (cual)
            Case 1
                ev1.Add(nota)
                ev2.Add(0)
                ev3.Add(0)
                FinalOrdinaria.Add(0)
                FinalExtraordinaria.Add(0)
            Case 2
                ev1.Add(0)
                ev2.Add(nota)
                ev3.Add(0)
                FinalOrdinaria.Add(0)
                FinalExtraordinaria.Add(0)
            Case 3
                ev1.Add(0)
                ev2.Add(0)
                ev3.Add(nota)
                FinalOrdinaria.Add(0)
                FinalExtraordinaria.Add(0)
            Case 4
                ev1.Add(0)
                ev2.Add(0)
                ev3.Add(0)
                FinalOrdinaria.Add(nota)
                FinalExtraordinaria.Add(0)
            Case 5
                ev1.Add(0)
                ev2.Add(0)
                ev3.Add(0)
                FinalOrdinaria.Add(0)
                FinalExtraordinaria.Add(nota)
        End Select


    End Sub

    Private Function selecNota(nombreAsign As String)
        Dim nota As Double
        Console.WriteLine("Introduzca una nota para la asignatura de " + nombreAsign)

        While (nota < 1 Or nota > 11)
            Console.WriteLine("La nota debe ser un número entre el 1 y el 11 (11 matricula de honor)")
            Try
                nota = Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine("La nota debe ser un número")
            End Try
        End While
        Return nota
    End Function

    Private Function selecEval()
        Dim evalu As Integer = 0
        While (evalu < 1 Or evalu > 5)
            Console.WriteLine("Seleccione evaluación (numero)")
            Console.WriteLine("==============================")
            Console.WriteLine("1- Primera evaluación")
            Console.WriteLine("2- Segunda evaluación")
            Console.WriteLine("3- Tercera evaluación")
            Console.WriteLine("4- Final ordinaria")
            Console.WriteLine("5- Final extraordinaria")
            Try
                evalu = Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine("INTRODUZCA UN NUMERO")
            End Try
        End While
        Return evalu
    End Function

End Class
