Public Class Profesor
    Inherits Persona
    Private materia As String
    Private rng As Random


    Public Sub New(nombre As String, apellido As String, materia As String)
        MyBase.New(nombre, apellido)
        rng = New Random(DateAndTime.TimeOfDay.GetHashCode())
        Me.Materia1 = materia
    End Sub

    Public Property Materia1 As String
        Get
            Return materia
        End Get
        Set(value As String)
            materia = value
        End Set
    End Property

    Public Function Corregir() As Integer
        Return rng.Next(1, 11) 'Retorna un numero mayor o igual a 1 y menor a 11
    End Function

    Overrides Function Presentarse() As String
        Return $"Hola, soy {nombre} {apellido} y enseño {materia}"
    End Function
End Class
