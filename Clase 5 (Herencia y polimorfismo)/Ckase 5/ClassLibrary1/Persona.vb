Public MustInherit Class Persona
    'MustInherit = Solamente se puede heredar, no crear instancias (se llama clase abstracta)

    'Private
    'Internal
    'Public

    'Protected
    Protected nombre As String
    Protected apellido As String


    Public Sub New(nombre As String, apellido As String)
        Me.Nombre1 = nombre
        Me.Apellido1 = apellido
    End Sub

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Apellido1 As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    Public MustOverride Function Presentarse() As String
    'MustOverride - La clase hija DEBE aportar la implementacion de la funcion 

    'Public Overridable Function Presentarse() As String
    '    ' Overridable - Una clase derivada PUEDE aportar una implementacion distinta
    '    Return $"Hola, soy {nombre} {apellido}"
    'End Function


End Class
