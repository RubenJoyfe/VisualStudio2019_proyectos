Imports System.Console
Imports System.Timers

' *1º Metodo Sobreescrito
' *2º Metod Que nos devuleva Una String Completa con el estado y tipo de movimineto
' *3º Variable 'Static' Shared que cuente el numero de veiculos
'  4º Crear un metodo debajo de Sub Main que reste combustible     opcional(cada x segundos) 
'    al que se le gaste antes pierde y el que mas tarde gana

Module Module1

    Sub Main()
        Console.Title = "Vehiculos"

        Dim veiculo0 As Car = New Car("Juan", 6, 80)
        Dim plane As AirPlane = New AirPlane("Ruben", 6, 69)

        veiculo0.Wheel = 4
        WriteLine(veiculo0.Wheel)

        veiculo0.Fuel = 160
        WriteLine(veiculo0.Fuel)
        WriteLine(veiculo0.FechaDeCreacion)

        WriteLine(veiculo0.run(CByte(4)))
        WriteLine(veiculo0.UltimoArranque)

        WriteLine(veiculo0.run(CByte(3)))
        WriteLine(veiculo0.UltimoArranque)
        veiculo0.verEstado()
        Console.WriteLine("Numero total de vehiculos: {0}", Veicules.nvehiculos)

        'plane.volar(600)
        'plane.volar(28)

        For i As Integer = 0 To 20
            Threading.Thread.Sleep(2000)
            plane.volar(280)
        Next



        ReadKey()

    End Sub

End Module

Class Veicules
    Public Shared nvehiculos As Integer
    Protected _name, _type, _color As String
    Protected _wheel, _fuel As Byte
    Protected _mov As Byte
    Protected _status As Boolean = False
    Protected _manufactureFech As Date = Now
    Protected _runingFech As Date

    Enum Movements As Byte
        Up = 1
        Down
        Right
        Left
    End Enum

    Public Sub New(ByVal name As String, ByVal type As String, ByVal wheel As Byte, Optional ByVal fuel As Byte = 100)
        nvehiculos += 1
        Me._name = name
        Me._type = type
        Me.Wheel = wheel
        Me.Fuel = fuel
    End Sub

    Public Sub New(ByVal name As String, ByVal type As String, ByVal wheel As Byte, ByVal color As String, Optional ByVal fuel As Byte = 100)
        nvehiculos += 1
        Me._name = name
        Me._type = type
        Me.Wheel = wheel
        Me._color = color
        Me.Fuel = fuel
    End Sub

    Protected Friend Overridable Function run(Optional ByVal status As Boolean = True) As Boolean
        Me._status = status

        If (Me._status) Then
            Me._runingFech = Now
        End If

        If (Me._fuel < 5) Then
            Return False
        End If

        Return Me._status
    End Function

    Protected Friend ReadOnly Property UltimoArranque As Date
        Get
            Return Me._runingFech
        End Get
    End Property

    Protected Friend ReadOnly Property FechaDeCreacion As Date
        Get
            Return Me._manufactureFech
        End Get
    End Property

    Protected Friend Property Wheel As Byte
        Get
            Return Me._wheel
        End Get
        Set(value As Byte)
            If (value < 9) Then
                Me._wheel = value
            Else
                Me._wheel = 8
                ' Crear una excepcion
                'Throw New Exception("Un veiculo no puede tener mas de 8 ruedas")
            End If
            ' Operador ternario lo mismos que el if else
            'Me._wheel = IIf((value < 9), value, 8)
        End Set
    End Property
    Protected Friend Property Fuel As Byte
        Get
            Return Me._fuel
        End Get
        Set(value As Byte)
            If (value < 101) Then
                Me._fuel = value
            Else
                Me._fuel = 100
                ' Crear una excepcion
                'Throw New Exception("Un veiculo no puede tener mas de 8 ruedas")
            End If
            ' Operador ternario lo mismos que el if else
            'Me._wheel = IIf((value < 9), value, 8)
        End Set
    End Property

    Public Overridable Sub volar(ByVal km As Integer)
        Console.WriteLine("Si su vehículo es capaz de volar podrá volar los {1} km indicados :)", km)
    End Sub

    Public Sub verEstado()
        Console.WriteLine("El estado del vehiculo es {0}, proximo movimiento: {1}", IIf(_status, "CORRECTO", "INCORRECTO"), [Enum].GetName(GetType(Movements), Me._mov))
    End Sub

End Class
Class Car
    Inherits Veicules

    Public Sub New(ByVal name As String, ByVal wheel As Byte, Optional ByVal fuel As Byte = 100)
        MyBase.New(name, "Coche", 4, fuel)
    End Sub

    Public Overloads Function run(ByVal mov As Byte, Optional ByVal status As Boolean = True) As String
        Me._status = status
        Me._mov = mov

        If (Me._status) Then
            Me._runingFech = Now
        End If


        Return [Enum].GetName(GetType(Movements), Me._mov)

    End Function

End Class

Class MotoBike
    Inherits Veicules

    Public Sub New(ByVal name As String, Optional ByVal fuel As Byte = 100)
        MyBase.New(name, "Moto", 2, fuel)
    End Sub

End Class

Class AirPlane
    Inherits Veicules

    Public Sub New(ByVal name As String, ByVal wheel As Byte, Optional ByVal fuel As Byte = 100)
        MyBase.New(name, "Avion", wheel, fuel)
    End Sub

    Public Overrides Sub volar(ByVal km As Integer)
        Dim actfuel = _fuel
        Dim kmRecorridos = 0
        Console.SetCursorPosition(0, 9)

        For kmact As Integer = 1 To km
            If actfuel = 0 Then
                Console.WriteLine("Te quedaste sin combustible")
                Console.Write("Has volado {0} km de los {1} km indicados y has tu combustible restante es ", kmRecorridos, km)
                Console.ForegroundColor = 12
                Console.Write("{0} litros", actfuel)
                Console.ForegroundColor = 15
                Console.Write(".")
                drawPlane(4)
                _fuel = actfuel
                Return
            End If
            If kmact Mod 9 = 0 Then
                actfuel -= 1
            End If
            kmRecorridos += 1
        Next
        Console.WriteLine("Has volado {0} km y has tu combustible restante es {1} litros ", kmRecorridos, actfuel)
        If actfuel > 70 Then
            drawPlane(3)
        ElseIf actfuel > 40 Then
            drawPlane(2)
        ElseIf actfuel > 30 Then
            drawPlane(6)
        End If

        _fuel = actfuel

    End Sub

    Public Sub drawPlane(color As Integer)
        Console.ForegroundColor = color
        Console.WriteLine("
             _____
            _\ _~-\___
    =  = ==(____AA____D
                \_____\___________________,-~~~~~~~`-.._
                /     o O o o o o O O o o o o o o O o  |\_
                `~-.__        ___..----..                  )
                      `---~~\___________/------------`````
                      =  ===(_________D
                          ")
        Console.ForegroundColor = ConsoleColor.White
    End Sub

End Class