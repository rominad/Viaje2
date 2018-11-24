Public Class Entidad
    Private _nombre As String
    Private _domicilio As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get

        Set(value As String)
            If value.Length > 30 Then
                Throw New ArgumentException("El nombre no debe tener mas de 30 caracteres!")
            End If
            _nombre = value
        End Set
    End Property
    Public Property Domicilio As String
        Get
            Return _domicilio
        End Get
        Set(value As String)
            If value.Length > 50 Then
                Throw New ArgumentException("El domicilio no debe tener mas de 50 caracteres!")
            End If
            _domicilio = value
        End Set
    End Property
    Sub New(nombre As String, domicilio As String)
        Me.Nombre = nombre
        Me.Domicilio = domicilio
    End Sub
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
