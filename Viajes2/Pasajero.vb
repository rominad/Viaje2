Imports System
Imports Microsoft.VisualBasic
Public Class Pasajero
    Inherits Entidad
    Implements IPasajero
    Private _pasaporte As UInteger
    Private _dni As UInteger
    Private _fechaNac As Date
    Private _tutor As Pasajero

    Public Property Pasaporte As UInteger Implements IPasajero.Pasaporte
        Get
            Return _pasaporte
        End Get
        Set(value As UInteger)
            _pasaporte = value
        End Set
    End Property

    Public Property Dni As UInteger Implements IPasajero.Dni
        Get
            Return _dni
        End Get
        Set(value As UInteger)
            _dni = value
        End Set
    End Property

    Public Property FechaNacimiento As Date Implements IPasajero.FechaNacimiento
        Get
            Return _fechaNac
        End Get
        Set(value As Date)
            _fechaNac = value
        End Set
    End Property
    Public Property Tutor() As Pasajero
        Get
            Return _tutor
        End Get
        Set(value As Pasajero)
            _tutor = value
        End Set
    End Property

    Public Function isMayorEdad() As Boolean
        Dim edad As Long
        edad = Date.Now().Year() - FechaNacimiento.Year()
        If edad > 17 Then
            Return True
        Else
            Return False
        End If
        Return True
    End Function

    Sub New(dni As UInteger, nombre As String, domicilio As String, fechaNac As Date)
        MyBase.New(nombre, domicilio)
        Me.FechaNacimiento = fechaNac
        Me.Dni = dni
    End Sub
    Sub New(dni As UInteger, nombre As String, domicilio As String, fechaNac As Date, pasaporte As UInteger)
        MyBase.New(nombre, domicilio)
        Me.FechaNacimiento = fechaNac
        Me.Dni = dni
        Me.Pasaporte = pasaporte
    End Sub

End Class
