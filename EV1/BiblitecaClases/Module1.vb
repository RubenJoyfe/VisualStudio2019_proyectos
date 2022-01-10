
Module Module1

    Sub Main()
        Dim oEmpleado As Empleado, otroEmpleado As Empleado
        oEmpleado = New Empleado
        otroEmpleado = New Empleado("20/04/2022 18:05")
        Console.WriteLine("{0} - {1}", oEmpleado.FechaCrea, otroEmpleado.FechaCrea)
        otroEmpleado.Calcularsalario()
        Console.WriteLine("Salario: {0}", otroEmpleado.Sueldo)
        Console.ReadLine()

        Dim addm As Administrativo
        addm = New Administrativo()

        addm.EnviarCorreo("Bienvenido")
        addm.Calcularsalario()
        Console.WriteLine("Salario: {0}", addm.Sueldo)
        Console.ReadLine()

    End Sub

End Module


