Imports Viajes2

Public Class Ventas
    Implements Cotizacion
    Implements Servicio

    Private _fecha As Date
    Private _cotizacionDolarPesos As Decimal
    Private _pasajeros As List(Of Pasajero)
    Private _cliente As Cliente
    Private _descripcion As String
    Private _fechaInicial As Date

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Public Property CotizacionDolarPesos As Decimal
        Get
            Return _cotizacionDolarPesos
        End Get
        Set(value As Decimal)
            _cotizacionDolarPesos = value
        End Set
    End Property
    Public Property Cliente As Cliente
        Get
            Return _cliente
        End Get
        Set(value As Cliente)
            _cliente = Cliente
        End Set
    End Property
    Public Function PrecioTotal() As Decimal
        Return PrecioPesos
    End Function

    Public Sub AddPasajero(pasajero As Pasajero)
        _pasajeros.Add(pasajero)
    End Sub
    Public Sub RemovePasajero(pasajero As Pasajero)
        _pasajeros.Remove(pasajero)
    End Sub
    Public Function GetAllPasajero() As List(Of Pasajero)
        Return _pasajeros
    End Function
    Public ReadOnly Property PrecioPesos As Decimal Implements Cotizacion.PrecioPesos
        Get
            Return CotizacionDolarPesos
        End Get
    End Property

    Public ReadOnly Property PrecioDolar As Decimal Implements Cotizacion.PrecioDolar
        Get
            Return PrecioPesos * 0.36
        End Get
    End Property

    Public Property Descripcion As String Implements Servicio.Descripcion
        Get
            Return _descripcion
        End Get
        Set(value As String)
            If value.Length > 30 Then
                Throw New ArgumentException("La descripcion no debe contener mas de 30 caracteres!")
            End If
            _descripcion = value
        End Set
    End Property

    Public Property FechaInicial As Date Implements Servicio.FechaInicial
        Get
            Return _fechainicial
        End Get
        Set(value As Date)
            _fechainicial = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Descripcion
    End Function
    Sub New(fecha As Date, cliente As Cliente)
        Me.Fecha = fecha
        Me.Cliente = cliente
    End Sub
End Class
