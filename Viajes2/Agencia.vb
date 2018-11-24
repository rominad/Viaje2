Public Class Agencia
    Private _ventas As List(Of Ventas)

    Public Sub AddVenta(venta As Ventas)
        _ventas.Add(venta)
    End Sub
    Public Sub RemoveVenta(venta As Ventas)
        _ventas.Remove(venta)
    End Sub
    Public Function GetAllVentas() As List(Of Ventas)
        Return _ventas
    End Function
End Class
