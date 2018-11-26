Public Class Agencia
    Private Shared _ventas As List(Of Ventas)

    Public Shared Sub AddVenta(venta As Ventas)
        _ventas.Add(venta)
    End Sub
    Public Shared Sub RemoveVenta(venta As Ventas)
        _ventas.Remove(venta)
    End Sub
    Public Shared Function GetAllVentas() As List(Of Ventas)
        Return _ventas
    End Function
End Class
