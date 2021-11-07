Imports System
Imports EntidadesPrueba
Module Program
    Sub Main(args As String())
        Dim alumno As Alumno
        alumno = New Alumno("Jose", "Perez", 5, 8, "Matematicas", "Escuela 1")
        Dim alumno2 = New Alumno("Carlos", "martinez", 1, 1, "Lengua", "Escuela 100")

        Console.WriteLine(alumno.MostrarAlumno())
        Console.WriteLine("")
        Console.WriteLine(alumno2.MostrarAlumno())
        'Console.WriteLine(alumno2.Nombre1) ' Como no estoy guardando datos el programa interpreta que quiero obtener el nombre
        'alumno2.Nombre1 = "Milena" 'Como SI estoy guardando datos, el programa interpreta que quiero guardar el valor en la variable "nombre"
        'Console.WriteLine(alumno2.Nombre1)



    End Sub
End Module
