Imports System
Imports ExamenParcial1DAM2_rzc.Emple

Module Program
    Dim empleadosSinViaje As New ArrayList
    Dim empleadosConViaje As New ArrayList
    Dim seguir As Boolean = True
    Sub Main(args As String())
        empleadosSinViaje.Add(New Emple("04850567M", "Ruben", "Zuñiga", "Carrillo"))
        Dim yo As Emple = empleadosSinViaje.Item(0)
        yo.datosPersonales(Date.Parse("20/04/2002"), "liberacion", "Español")
        While (seguir)
            elegirOpcion()
        End While

        Console.ReadLine()
    End Sub

    Private Sub pintarMen()
        Console.WriteLine("
            1.-Crear Emplead@s
                1.1.-Emplead@s sin viajes
                1.2.-Emplead@s con viajes
            2.-Introducir datos personales
            3.-Introducir cursos de especialización
            4.-Introducir datos de viajes
            5.-Listar datos personales
            6.-Listar viajes
            7.-Listar cursos de especialización
            8.-Finalizar
        ")
    End Sub

    Private Function preguntarOpcion()
        Dim opt As Integer
        Console.WriteLine("SELECCIONE UNA ACCION:")
        Console.WriteLine("======================")
        pintarMen()
        Console.WriteLine("Por favor, introduzca un número del 1 al 8")
        While (opt < 1 Or opt > 8)
            Try
                opt = Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine("Introduzca un valor numerico")
            End Try
        End While
        Return opt
    End Function

    Private Sub elegirOpcion()
        Select Case (preguntarOpcion())
            Case 1
                Crearempleado(conViajessinViajes())
            Case 2
                Console.WriteLine("Empleado con viajes o sin viajes")
                Dim tipoEmpl As Integer = conViajessinViajes()
                Console.WriteLine("Introduzca numero de empleado")
                Dim num As Integer = Console.ReadLine()

                If (tipoEmpl = 1) Then
                    Dim empleado As Emple = buscarEmpleadoSinViajes(num)
                    Console.WriteLine("Datos personales de {0}", empleado.nombreEmpleado)
                ElseIf (tipoEmpl = 2) Then
                    Dim empleado As Viajes = buscarEmpleadoConViajes(num)
                    Console.WriteLine("Datos personales de {0}", empleado.nombreEmpleado)
                End If
                Console.WriteLine("Introduzca fecha nacimiento")
                Dim fechaNac As Date = Console.ReadLine()
                Console.WriteLine("Introduzca Domicilio")
                Dim domicilio As String = Console.ReadLine()
                Console.WriteLine("Introduzca Nacionalidad")
                Dim nacionalidad As String = Console.ReadLine()
                If (tipoEmpl = 1) Then
                    Dim empleado As Emple = buscarEmpleadoSinViajes(num)
                    empleado.datosPersonales(fechaNac, domicilio, nacionalidad)
                ElseIf (tipoEmpl) Then
                    Dim empleado As Viajes = buscarEmpleadoConViajes(num)
                    empleado.datosPersonales(fechaNac, domicilio, nacionalidad)
                End If

            Case 3
                Console.WriteLine("Empleado con viajes o sin viajes")
                Dim tipoEmpl As Integer = conViajessinViajes()
                Console.WriteLine("Introduzca numero de empleado")
                Dim num As Integer = Console.ReadLine()
                agregarEspecialidad(num, tipoEmpl)

            Case 4
                Console.WriteLine("Introduzca numero de empleado con viajes")
                Dim num As Integer = Console.ReadLine()
                Dim empleado As Viajes = empleadosConViaje(num)
                empleado.introducirDatosViaje()

            Case 5
                Console.WriteLine("Empleado con viajes o sin viajes")
                Dim tipoEmpl As Integer = conViajessinViajes()
                Console.WriteLine("Introduzca numero de empleado")
                Dim num As Integer = Console.ReadLine()

                datosPersonales(num, tipoEmpl)

            Case 6

            Case 7
                Console.WriteLine("Introduzca numero de empleado con viajes")
                Dim num As Integer = Console.ReadLine()
                Dim empleado As Viajes = empleadosConViaje(num)
                Console.WriteLine("
                Viaje: {0}
                Fecha comienzo: {1}
                Fecha Fin: {2}
                Dias de viaje: {3}
", empleado.destinoViaje, empleado.fechaInicioViaje, empleado.fechaFinalizacionViaje, empleado.diasTotalesViaje)
            Case 8
                seguir = False
        End Select
    End Sub

    Private Sub Crearempleado(tipo As Integer)
        Console.WriteLine("Introduzca DNI")
        Dim dni As String = Console.ReadLine()
        Console.WriteLine("Introduzca Nombre")
        Dim name As String = Console.ReadLine()
        Console.WriteLine("Introduzca Apellido1")
        Dim ape1 As String = Console.ReadLine()
        Console.WriteLine("Introduzca Apellido2")
        Dim ape2 As String = Console.ReadLine()
        Dim yo As Emple
        If (tipo = 1) Then
            empleadosSinViaje.Add(New Emple(dni, name, ape1, ape2))
            yo = empleadosSinViaje.Item(0)
        Else
            empleadosConViaje.Add(New Viajes(dni, name, ape1, ape2))
            yo = empleadosConViaje.Item(0)
        End If

        Console.WriteLine(yo.nombreEmpleado)
        yo.especializacionesEmpleado = 1
        'Console.WriteLine(yo.getEspecializacion(0))
    End Sub

    Private Function conViajessinViajes()
        Dim opt As Integer = 0
        Console.WriteLine("
        1.-Emplead@s sin viajes
        2.-Emplead@s con viajes
                ")
        While (opt < 1 Or opt > 2)
            Try
                opt = Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine("Introduzca un valor numerico")
            End Try
        End While
        Return opt
    End Function

    Private Function buscarEmpleadoConViajes(num As Integer)
        If (empleadosConViaje.Count() > num) Then
            Return empleadosConViaje.Item(num)
        End If
        Return 0
    End Function
    Private Function buscarEmpleadoSinViajes(num As Integer)
        If (empleadosSinViaje.Count() > num) Then
            Return empleadosSinViaje.Item(num)
        End If
        Return 0
    End Function

    Private Sub datosPersonales(n As Integer, tipo As Integer)
        If (tipo = 1) Then
            Dim empleado As Emple = buscarEmpleadoSinViajes(n)
            Console.WriteLine("
            DNI: {0}
            Nombre: {1}
            Apellido1: {2}
            Apellido2: {3}
            fecha nacimiento: {4}
            domicilio: {5}
            nacionalidad: {6}
", empleado.empleadoDNI, empleado.nombreEmpleado, empleado.apellido1Empleado, empleado.apellido2Empleado,
   empleado.fechaNacimientoEmpleado, empleado.domicilioEmpleado, empleado.nacionalidadEmpleado)
        ElseIf (tipo = 2) Then
            Dim empleado As Viajes = buscarEmpleadoConViajes(n)
            Console.WriteLine("
            DNI: {0}
            Nombre: {1}
            Apellido1: {2}
            Apellido2: {3}
            fecha nacimiento: {4}
            domicilio: {5}
            nacionalidad: {6}
", empleado.empleadoDNI, empleado.nombreEmpleado, empleado.apellido1Empleado, empleado.apellido2Empleado,
   empleado.fechaNacimientoEmpleado, empleado.domicilioEmpleado, empleado.nacionalidadEmpleado)
        End If
    End Sub

    Private Sub agregarEspecialidad(n As Integer, tipo As Integer)
        If (tipo = 1) Then
            Dim empleado As Emple = buscarEmpleadoSinViajes(n)
            Console.WriteLine("Introducir numero de especializacion para añadir")
            Dim num As Integer = Console.ReadLine()
            empleado.especializacionesEmpleado = num

        ElseIf (tipo = 2) Then
            Dim empleado As Viajes = buscarEmpleadoConViajes(n)
            Console.WriteLine("Introducir numero de especializacion para añadir")
            Dim num As Integer = Console.ReadLine()
            empleado.especializacionesEmpleado = num
        End If
    End Sub



End Module
