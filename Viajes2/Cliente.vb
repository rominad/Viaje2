Public Class Cliente
    Inherits Entidad
    Private _cuit_cuil As String
    Private _venta As Ventas
    Public Property Cuit_Cuil As String
        Get
            Return _cuit_cuil
        End Get
        Set(value As String)
            If value.Length <> 13 Then
                Throw New ArgumentException("No debe contener mas,ni menos de 13 caracteres!")

            Else
                _cuit_cuil = value
            End If
        End Set
    End Property
    Public Property Ventas As Ventas
        Get
            Return _venta
        End Get
        Friend Set(value As Ventas)
            _venta = value
        End Set
    End Property

    Sub New(cuit_cuil As String, nombre As String, domicilio As String)
        MyBase.New(nombre, domicilio)
        Me.Cuit_Cuil = cuit_cuil
        Ventas.addCliente(Me)
    End Sub
End Class
