Imports Viajes2

Public Class Paquete
    'IMPLEMENTAMOS INTERFACES'
    Implements Cotizacion
    Implements Servicio
    'CAMPOS'
    Private _FechaFinal As Date
    Private _NumeroDias As UShort
    Private _NumeroPasajero As UShort
    Private _servicios As List(Of Servicio)
    Private _descripcion As String
    Private _fechainicial As Date
    Private _venta As Ventas
    'PROPIEDADES'
    Private Property FechaFinal As Date
        Get
            Return _FechaFinal
        End Get
        Set(value As Date)
            _FechaFinal = value
        End Set
    End Property
    Private ReadOnly Property NumeroDias As UShort
        Get
            Return _NumeroDias
        End Get
    End Property
    Private Property NumeroPasajero As UShort
        Get
            Return _NumeroPasajero
        End Get
        Set(value As UShort)
            _NumeroPasajero = value
        End Set
    End Property
    Public ReadOnly Property PrecioPesos As Decimal Implements Cotizacion.PrecioPesos
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property PrecioDolar As Decimal Implements Cotizacion.PrecioDolar
        Get
            Throw New NotImplementedException()
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
    Public Property Venta As Ventas Implements Servicio.Venta
        Get
            Return _venta
        End Get
        Set(value As Ventas)
            _venta = value
        End Set
    End Property
    'METODOS'
    Public Sub AddServicio(servicio As Servicio)
        _servicios.Add(servicio)
    End Sub
    Public Sub RemoveServicio(servicio As Servicio)
        _servicios.Remove(servicio)
    End Sub
    Public Function GetAllServicios() As List(Of Servicio)
        Return _servicios
    End Function
    'TO STRING
    Public Overrides Function ToString() As String
        Return Descripcion
    End Function
    'CONSTRUCTOR'
    Sub New(Descripcion As String, FechaInicial As Date, fechaFinal As Date)
        Me.Descripcion = Descripcion
        Me.FechaFinal = fechaFinal
        Me.FechaInicial = FechaInicial
    End Sub

End Class
