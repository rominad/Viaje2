Imports Viajes2
Module EntidadTest
    Sub Main()
        Try
            Dim entidad1 As New Entidad("Nombre EntidadNombre EntidadNombre Entidad", "Domicilio EntidadDomicilio EntidadDomicilio Entidad Entidad")
            Console.WriteLine(entidad1.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim entidad1 As New Entidad("Nombre Entidad", "Domicilio Entidad")
            Console.WriteLine(entidad1.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()
    End Sub
End Module
