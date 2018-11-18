Public Class Persona

    Private _Nombre As String
    Private _Apellidos As String
    Private _Cedula As String
    Private _Telefono As String
    Private _Correo As String


    Public Property Nombre As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Apellidos As String
        Get
            Return Apellidos
        End Get
        Set(value As String)
            _Apellidos = value
        End Set
    End Property

    Public Property Cedula As String
        Get
            Return Cedula
        End Get
        Set(value As String)
            _Cedula = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return Correo
        End Get
        Set(value As String)
            _Correo = value
        End Set
    End Property



End Class
