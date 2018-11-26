Imports Viajes2

Module HotelTest
    Sub Main()
        Try
            Dim ciudad1 As New Ciudad("Posadas")
            Dim hotel1 As New Hotel("Nueva DescripcionNueva DescripcionNueva DescripcionNueva Descripcion", Date.Now(), ciudad1, 7, 100)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim ciudad1 As New Ciudad("Posadas")
            Dim hotel1 As New Hotel("Nueva Descripcion", Date.Now(), ciudad1, 5, 100)
            Console.WriteLine("Precio pesos: {0}", hotel1.PrecioPesos)
            Console.WriteLine("Precio pesos: {0}", hotel1.PrecioDolar)
            Console.WriteLine(hotel1.ToString())
        Catch ex As Exception
            Console.WriteLine("ERROR 404 ", ex.ToString())
        End Try
        Console.ReadKey()
    End Sub
End Module
