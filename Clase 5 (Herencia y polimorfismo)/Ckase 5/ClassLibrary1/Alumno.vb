Public Class Alumno
    Inherits Persona
    'Inhertis  = Hereda

    Private legajo As Integer
    Private materia As String
    Private nota1 As Integer
    Private nota2 As Integer

    Public Sub New(nombre As String, apellido As String, legajo As Integer, materia As String, nota1 As Integer, nota2 As Integer)
        MyBase.New(nombre, apellido) ' hace referencia a la clase padre (persona)
        Me.Legajo1 = legajo
        Me.Materia1 = materia
        Me.Nota11 = nota1
        Me.Nota21 = nota2
    End Sub

    Public Property Legajo1 As Integer
        Get
            Return legajo
        End Get
        Set(value As Integer)
            legajo = value
        End Set
    End Property

    Public Property Materia1 As String
        Get
            Return materia
        End Get
        Set(value As String)
            materia = value
        End Set
    End Property

    Public Property Nota11 As Integer
        Get
            Return nota1
        End Get
        Set(value As Integer)
            nota1 = value
        End Set
    End Property

    Public Property Nota21 As Integer
        Get
            Return nota2
        End Get
        Set(value As Integer)
            nota2 = value
        End Set
    End Property

    Overrides Function Presentarse() As String
        Return $"Hola, soy {nombre} {apellido} y soy estudio la materia {materia}"
    End Function

End Class
