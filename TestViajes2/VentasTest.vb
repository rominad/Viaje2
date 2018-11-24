Imports Viajes2
Module VentasTest
    Sub Main()
        Dim pasajero1 As New Pasajero(38123456, "NombrePasajero1", "DomicilioPasajero", Date.Now(), DateDiff)
        Dim pasajero2 As New Pasajero(38123756, "NombrePasajero2", "DomicilioPasajero", Date.Now())
        Dim cliente1 As New Cliente("0123456789123", "NombreCliente", "DireccionCliente")
        Dim venta1 As New Ventas(Date.Now(), cliente1)
        venta1.AddPasajero(pasajero1)
        venta1.AddPasajero(pasajero2)
        venta1.RemovePasajero(pasajero1)
        For Each pasajero In venta1.GetAllPasajero()
            Console.Write("-", pasajero.Nombre)
        Next
        Console.WriteLine("Precio Pesos: {0}", venta1.PrecioPesos())
        Console.WriteLine("Precio Dolar: {0}", venta1.PrecioDolar())
        Console.WriteLine("Precio Total: {0}", venta1.PrecioTotal())
        Console.ReadKey()
    End Sub
End Module
