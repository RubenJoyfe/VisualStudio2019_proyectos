Public Class Emple
    Private DNI As String
    Private nombre As String
    Private apellido1 As String
    Private apellido2 As String
    Private fechaNacimiento As Date
    Private domicilio As String
    Private nacionalidad As String
    Private especialicaciones As New ArrayList

    Public Enum Modulos As Byte
        Porgramacion
        Sistemas
        Ofimática
        Base_de_Datos
        Contabilidad
        Idiomas
        Direccion
        RRHH
        Poteccion_de_Datos
    End Enum


    Sub New(dniEmple As String, name As String, ape1 As String, ape2 As String)
        DNI = dniEmple
        nombre = name
        apellido1 = ape1
        apellido2 = ape2
        Console.WriteLine("Empleado creado")
    End Sub

    Sub listarModulos()

    End Sub

    Sub datosPersonales(fecha_nacimiento As Date, domic As String, nacionalidadEmpleado As String)
        fechaNacimiento = fecha_nacimiento
        domicilio = domic
        nacionalidad = nacionalidadEmpleado
    End Sub


    'PROPIEDADES

    Public ReadOnly Property empleadoDNI As String
        Get
            Return DNI
        End Get
    End Property

    Public WriteOnly Property empleDNI As String
        Set(value As String)
            DNI = value
        End Set
    End Property

    Public Property nombreEmpleado As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Public Property apellido1Empleado As String
        Get
            Return apellido1
        End Get
        Set(value As String)
            apellido1 = value
        End Set
    End Property
    Public Property apellido2Empleado As String
        Get
            Return apellido2
        End Get
        Set(value As String)
            apellido2 = value
        End Set
    End Property

    Public Property fechaNacimientoEmpleado As Date
        Get
            Return fechaNacimiento
        End Get
        Set(value As Date)
            fechaNacimiento = value
        End Set
    End Property
    Public Property domicilioEmpleado As String
        Get
            Return domicilio
        End Get
        Set(value As String)
            domicilio = value
        End Set
    End Property
    Public Property nacionalidadEmpleado As String
        Get
            Return nacionalidad
        End Get
        Set(value As String)
            nacionalidad = nacionalidadEmpleado
        End Set
    End Property

    Public WriteOnly Property especializacionesEmpleado As Integer
        Set(value As Integer)
            especialicaciones.Add(value)
        End Set
    End Property

    Public ReadOnly Property getEspecializacion(index As Integer) As String
        Get
            Return [Enum].GetName(GetType(Modulos), getEspecializacion(index))
        End Get
    End Property

End Class
