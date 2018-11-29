Imports Viajes2

Public Class Ventas
    Implements Cotizacion
    Private _fecha As Date
    Private Shared _cotizacionDolarPesos As Decimal
    Private _pasajeros As List(Of IPasajero)
    Private _clientes As List(Of Cliente)
    Private _noches As Byte
    Private _precioDiaria As Decimal
    Private _servicio As Servicio

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Public Property Noches As Byte
        Get
            Return _noches
        End Get
        Set(value As Byte)
            _noches = value
        End Set
    End Property
    Property PrecioDiaria As Decimal
        Get
            Return _precioDiaria
        End Get
        Set(value As Decimal)
            _precioDiaria = value
        End Set
    End Property
    Public Shared Property CotizacionDolarPesos As Decimal
        Get
            Return _cotizacionDolarPesos
        End Get
        Set(value As Decimal)
            _cotizacionDolarPesos = value
        End Set
    End Property
    Public Property Servicio() As Servicio
        Get
            Return _servicio
        End Get
        Friend Set(ByVal value As Servicio)
            _servicio = value
        End Set
    End Property
    Public Function PrecioTotal() As Decimal
        Return PrecioPesos
    End Function

    Public Sub AddPasajero(pasajero As IPasajero)
        _pasajeros.Add(pasajero)
    End Sub
    Public Sub RemovePasajero(pasajero As IPasajero)
        _pasajeros.Remove(pasajero)
    End Sub
    Public Function GetAllPasajero() As List(Of IPasajero)
        Return _pasajeros
    End Function
    Public ReadOnly Property PrecioPesos As Decimal Implements Cotizacion.PrecioPesos
        Get
            Return PrecioDolar
        End Get
    End Property
    Public Sub addCliente(valor As Cliente)
        If _clientes.Count < 0 Then
            If valor.Ventas IsNot Nothing Then
                Dim OTRACLASE = valor.Ventas
                OTRACLASE.removeCliente(valor)
            End If
            valor.Ventas = Me
            _clientes.Add(valor)
        End If
    End Sub
    Public Sub removeCliente(valor As Cliente)
        valor.Ventas = Nothing
        _clientes.Remove(valor)
    End Sub
    Public Function getAllCliente() As List(Of Cliente)
        Return _clientes
    End Function
    Public ReadOnly Property PrecioDolar As Decimal Implements Cotizacion.PrecioDolar
        Get
            Return PrecioDiaria * Noches
        End Get
    End Property
    Public Overrides Function ToString() As String
        Return Fecha
    End Function
    Sub New(fecha As Date, cliente As Cliente)
        Me.Fecha = fecha
        Me.Cliente = cliente
        _pasajeros = New List(Of Pasajero)
    End Sub
End Class
