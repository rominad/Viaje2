﻿Public Class ClientePasajero
    Inherits Cliente
    Implements IPasajero
    Private _pasaporte As UInteger
    Private _dni As UInteger
    Private _fechaNac As Date
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
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
    Sub New(cuit As String, dni As UInteger, nombre As String, domicilio As String, fechaNacimiento As Date)
        MyBase.New(cuit, nombre, domicilio)
        Me.FechaNacimiento = fechaNacimiento
    End Sub
    Sub New(cuit As String, dni As UInteger, nombre As String, domicilio As String, fechaNacimiento As Date, pasaporte As UInteger)
        MyBase.New(cuit, nombre, domicilio)
        Me.FechaNacimiento = fechaNacimiento
        Me.Pasaporte = pasaporte
    End Sub
End Class
