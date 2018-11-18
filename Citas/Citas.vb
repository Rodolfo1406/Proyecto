
Public Class Class1

    Private _FechaCita As Date
    Private _LugarCita As String
    Private _NumContacto As Integer
    Private _Persona As Persona.Paciente
    Private _TipoCita As String

    Public Property FechaCita As Date
        Get
            Return FechaCita
        End Get
        Set(value As Date)
            _FechaCita = value
        End Set
    End Property

    Public Property LugarCita As String
        Get
            Return LugarCita
        End Get
        Set(value As String)
            _LugarCita = value
        End Set
    End Property

    Public Property NumContacto As Integer
        Get
            Return NumContacto
        End Get
        Set(value As Integer)
            _NumContacto = value
        End Set
    End Property

    Public Property Persona As Persona.Paciente
        Get
            Return Persona
        End Get
        Set(value As Persona.Paciente)
            _Persona = value
        End Set
    End Property

    Public Property TipoCita As String
        Get
            Return TipoCita
        End Get
        Set(value As String)
            _TipoCita = value
        End Set
    End Property

End Class
