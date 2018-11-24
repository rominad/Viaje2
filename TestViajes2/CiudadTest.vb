Imports Viajes2

Module CiudadTest
    Sub Main()
        Try
            Dim ciudad1 As New Ciudad("Posadas")
            Console.WriteLine(ciudad1.ToString())
        Catch ex As Exception
            Console.WriteLine("No anda!")
        End Try
        Console.ReadKey()
    End Sub

End Module
