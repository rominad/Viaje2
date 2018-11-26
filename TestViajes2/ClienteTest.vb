Imports Viajes2
Module ClienteTest

    Sub Main()
        Try
            Dim Cliente1 As New Cliente("12345678901233423", "Nombre Cliente", "Domicilio Cliente")
            Console.WriteLine(cliente1.tostring())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim Cliente2 As New Cliente("1234567890123", "Nombre Cliente", "Domicilio Cliente")
            Console.WriteLine(Cliente2.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()

    End Sub

End Module
