Imports System
Imports Entidades
Module Program
    Sub Main(args As String())
        Dim profe(15) As Profesor
        Dim alumnos(150) As Alumno
        Console.WriteLine()
        Dim persona As Persona = New Alumno("Joaquin", "Perez", 1, "Matematicas", 7, 4)
        'Dim persona2 As Persona = New Persona("Carla", "Fernandez")
        Dim persona3 As Persona = New Profesor("Carlos", "Rodriguez", "lengua")
        Console.WriteLine(persona.Presentarse())
        'Console.WriteLine(persona2.Presentarse())
        Console.WriteLine(persona3.Presentarse())
        Console.WriteLine(persona)
    End Sub
End Module
