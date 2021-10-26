Imports System

Module Program
    Sub Main(args As String())

        'Procedimientos
        'Nos enfocamos en 2

        'Funciones = Ejecutan el bloque de codigo y retornan un valor
        'Sub = Ejecutan el bloque de codigo y NO retornan un valor

        'Bloque de codigo


        Dim nombre As String
        Dim apellido As String
        Dim dni As Integer
        Dim edad As Integer

        'Console.WriteLine("Ingrese su nombre") ' Sub
        'nombre = Console.ReadLine() 'Funcion
        Dim mensaje As String = "Ingrese un nombre"
        nombre = PedirTexto(mensaje) 'Si yo en PedirTexto puse "Lucas", el valor de la funcion al terminar es "Lucas"

        apellido = PedirTexto("Ingrese un apellido")


        Console.WriteLine("Ingrese su DNI")
        Dim aux As Integer
        If Integer.TryParse(Console.ReadLine(), aux) Then

            dni = aux
        End If

        Console.WriteLine("Ingrese su edad")
        If Integer.TryParse(Console.ReadLine(), aux) Then
            edad = aux
        End If
        MostrarPersona(nombre, apellido, dni, edad)
    End Sub
    'ByVal = Hacer una copia del valor
    'ByRef = Pasar la  direccion de memoria de la variable
    Function PedirTexto(ByRef texto As String) As String
        ' Dim texto As String = mensaje
        'texto = "Hola"
        Console.WriteLine(texto) ' Sub
        Return Console.ReadLine() 'La palabra return se usa para devolver valroes

    End Function

    Sub MostrarPersona(ByVal nombre As String, ByVal apellido As String, ByVal dni As Integer, ByVal edad As Integer)
        Console.WriteLine($"Nombre: {nombre}" +
                          $"Apellido: {apellido}" +
                          $"DNI: {dni}" +
                          $"Edad: {edad}")

    End Sub

End Module
