Imports Viajes2

Module PasajeTest
    Sub main()
        Try
            Dim origen As New Ciudad("PSS")
            Dim destino As New Ciudad("IGR")
            Dim pasaje1 As New Pasaje("Descripcion DescripcionDescripcionDescripcionNueva", Date.Now(), 200.5, 3, origen, destino)
            Console.WriteLine(pasaje1.ToString())
            Console.WriteLine("Precio Peso: {0}", pasaje1.PrecioPesos)
            Console.WriteLine("Precio Dolar: {0}", pasaje1.PrecioDolar)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim origen As New Ciudad("PSS")
            Dim destino As New Ciudad("IGR")
            Dim pasaje1 As New Pasaje("Descripcion Nueva", Date.Now(), 100.5, 2, origen, destino)
            Console.WriteLine(pasaje1.ToString())
            Console.WriteLine("Precio Peso: {0}", pasaje1.PrecioPesos)
            Console.WriteLine("Precio Dolar: {0}", pasaje1.PrecioDolar)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()
    End Sub
End Module
