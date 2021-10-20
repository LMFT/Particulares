Imports System

Module Program
    Sub Main(args As String())
        'Arrays (arreglos)
        Dim array(5) As Integer 'El numero entre parentesis indica la cantidad de variables del arreglo, mas uno (si tengo un 5 tengo
        ' 6 variables en total

        'Para inicializar los valores del arreglo, accedo a cada indice individual para guardar un valor
        array(0) = 1 ' Primer elemento en el indice 0
        array(1) = 2 ' Segundo elemento en el indice 1
        array(2) = 3 ' Tercer elemento en el indice 2
        array(3) = 4 ' Cuarto elemento en el indice 3
        array(4) = 5 ' Quinto elemento en el indice 4
        array(5) = 6 ' Sexto elemento en el indice 5
        Dim i As Integer = 0
        'Tambien puedo usar un for para inicializar un array, recorriendolo desde 0 hasta la propiedad Length - 1
        'Length: Me indica cuantos elementos tiene un arreglo
        For i = 0 To array.Length - 1 ' Como Length me indicaria que tengo 6 variables, si no resto 1 el programa intenta entrar a
            ' array(6), lo cual no existe (solamente llega hasta el 5)
            array(i) = i + 1
            Console.WriteLine(array(i))
        Next
        'Si quiero redimensionar un array puedo usar la palabra ReDim. Para conservar los datos deberia usar la palabra reservada
        'Preserve, lo cual me permite conservar los valores del arreglo
        ReDim Preserve array(10)

        For i = 0 To array.Length - 1
            array(i) = i + 1
            Console.WriteLine(array(i))
        Next
        'De no usar la palabra preserve, los valores que contenia el array se pierden
        ReDim array(3)
        For i = 0 To array.Length - 1
            Console.WriteLine(array(i))
        Next

        'Un ejemplo de uso práctico de arrays: Pedir múltiples numeros al usuario y guardarlos en cada una de sus posiciones
        For i = 0 To array.Length - 1
            Console.WriteLine("Ingrese un numero")
            Dim numero As Integer
            If Integer.TryParse(Console.ReadLine(), numero) Then
                array(i) = numero
            End If
        Next

        'Muestro los numeros que ingresó el usuario
        For i = 0 To array.Length - 1
            Console.WriteLine(array(i))
        Next

        Dim nombres(2) As String

        nombres(0) = "Lucas"
        nombres(1) = "Dante"
        nombres(2) = "Carla"
        'Algunas funciones y procedimientos útiles:
        'Contains: Me indica si un array contiene el valor que le paso entre paréntesis. Devuelve verdadero o falso 
        If nombres.Contains("Lucas") Then
            Console.WriteLine("Este array contiene el nombre Lucas")
        End If
        'Max / Min: Devuelve el valor máximo o minimo que tiene un array

        For i = 0 To array.Length - 1
            array(i) = i + 1
        Next

        Dim maximo As Integer = array.Max()
        Dim minimo As Integer = array.Min()

        Console.WriteLine($"Maximo: {maximo} ----- Minimo: {minimo}")
        'Average: Calcula el promedio y lo devuelve
        Dim promedio As Double = array.Average()

    End Sub
End Module
