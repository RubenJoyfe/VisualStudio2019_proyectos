Imports ExamenParcial1DAM2_rzc.Emple
Public Class Viajes
    Inherits Emple
    Dim viaje As String
    Dim fechaInicio As Date
    Dim fechaFinalizacion As Date
    Dim diasViaje As Integer = 0

    Sub New(dniEmple As String, name As String, ape1 As String, ape2 As String)
        MyBase.New(dniEmple, name, ape1, ape2)
        introducirDatosViaje()

        Console.WriteLine("Empleado con viaje creado")
    End Sub

    Public Sub introducirDatosViaje()
        Console.WriteLine("Introuduzca destino del viaje:")
        viaje = Console.ReadLine()
        Console.WriteLine("Introuduzca fecha de inicio del viaje:")
        fechaInicio = Console.ReadLine()
        Console.WriteLine("Introuduzca duracion del viaje en dias(max 60):")
        Do While (diasViaje < 1 Or diasViaje > 60)
            Try
                diasViaje = Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine("Introduzca un valor numerico")
            End Try
        Loop
        'fechaFinalizacion = fechaInicio + diasViaje
    End Sub

    Public Property destinoViaje As String
        Get
            Return viaje
        End Get
        Set(value As String)
            viaje = value
        End Set
    End Property
    Public Property fechaInicioViaje As Date
        Get
            Return fechaInicio
        End Get
        Set(value As Date)
            fechaInicio = value
        End Set
    End Property
    Public Property fechaFinalizacionViaje As Date
        Get
            Return fechaFinalizacion
        End Get
        Set(value As Date)
            fechaFinalizacion = value
        End Set
    End Property
    Public Property diasTotalesViaje As Integer
        Get
            Return diasViaje
        End Get
        Set(value As Integer)
            diasViaje = value
        End Set
    End Property

End Class
