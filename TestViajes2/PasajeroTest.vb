Imports Viajes2
Module PasajeroTest
    Sub Main()
        Dim pasajero1 As New Pasajero(38123456, "NombrePasajero", "DomicilioPasajero", #5/31/1994#)
        Console.WriteLine(pasajero1.ToString())
        Console.WriteLine(pasajero1.isMayorEdad())
        Console.ReadKey()
    End Sub
End Module
