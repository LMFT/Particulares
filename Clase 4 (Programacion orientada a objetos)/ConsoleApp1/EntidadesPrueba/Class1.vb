Imports System.Text

Public Class Alumno
    'Modificadores de visibilidad
    'Public - Publico, lo puedo ver dede cualquier parte del codigo
    'Private - Privado, solamente se puede usar en este archivo
    'Internal - Interno, usar solamente en el proyecto
    'Protected - La vemos la clase que viene

    'Atributos (o datos)
    Private nombre As String
    Private apellido As String
    Private nota1 As Integer
    Private nota2 As Integer
    Private materia As String
    Public Shared escuelaAlumnos As String

    'Constructor
    Public Sub New(nombre As String, apellido As String, nota1 As Integer, nota2 As Integer, materia As String, escuela As String)
        Me.Nombre1 = nombre
        Me.Apellido1 = apellido
        Me.Nota11 = nota1
        Me.Nota21 = nota2
        Me.Materia1 = materia
        escuelaAlumnos = escuela
    End Sub

    Public Property Nombre1 As String

        Get ' obtener
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

    Public Property Materia1 As String
        Get
            Return materia
        End Get
        Set(value As String)
            materia = value
        End Set
    End Property

    'Public Shared Property Escuela1 As String
    '    Get
    '        Return escuela
    '    End Get
    '    Set(value As String)
    '        escuela = value
    '    End Set
    'End Property


    'Metodo (o procedimiento)
    Public Function MostrarAlumno() As String
        Dim stringBuilder As StringBuilder = New StringBuilder()
        stringBuilder.AppendLine($"Nombre: {Nombre1}")
        stringBuilder.AppendLine($"Apellido: {Apellido1}")
        stringBuilder.AppendLine($"Nota 1: {Nota11}")
        stringBuilder.AppendLine($"Nota 2: {Nota21}")
        stringBuilder.AppendLine($"Materia: {Materia1}")
        stringBuilder.AppendLine($"Escuela: {escuelaAlumnos}")

        Return stringBuilder.ToString()
    End Function



End Class
