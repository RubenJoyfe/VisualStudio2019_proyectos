Module Module2
    Sub Main()
        Dim alumno As New Alumno(1, "Ruben", "Zunniga", "20/04/2021")
        'alumno.AsignaturasAlumno = "Python"
        alumno.notas.nuevaAsignatura = "Python"
        Console.WriteLine(alumno.AsignaturasAlumno() + " COMA")
        'Console.WriteLine("{0}", alumno.nombreAlumno)
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
    Public Property AsignaturasAlumno As String
        Get
            Return notas.nuevaAsignatura()
        End Get
        Set(value As String)
            notas.nuevaAsignatura = value
        End Set
    End Property

End Class
Public Class Notas
    Private asignaturas() As String
    Private evs() As Double
    Private FinalOrdinaria() As Double
    Private FinalExtraordinaria() As Double


    Sub Notas()

    End Sub

    Public Property nuevaAsignatura() As String
        Get
            Return asignaturas(0)
        End Get
        Set(value As String)
            asignaturas(0) = value
        End Set
    End Property

    Public Property introducirNota() As Double()
        Set(value() As Double)
            evs.Append(value(0))
        End Set
        Get
            Return evs
        End Get
    End Property

End Class
