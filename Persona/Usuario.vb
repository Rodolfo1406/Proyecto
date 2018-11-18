
Public Class Usuario

    Inherits Persona

    Private _Usuario As String
    Private _Contrasena As String

    Public Property Usuario As String
        Get
            Return Usuario
        End Get
        Set(value As String)
            _Usuario = value
        End Set
    End Property

    Public Property Contrasena As String
        Get
            Return Contrasena
        End Get
        Set(value As String)
            _Contrasena = value
        End Set
    End Property
End Class
