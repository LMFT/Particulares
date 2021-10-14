Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Tipos de dato:
        'Integer - Numero Entero
        'Float - Numero decimal
        'Double - Numero decimal con mas precisiom
        'String - Texto
        'Char - caracter (letra, numero, simbolo, etc
        'Boolean - Booleano (Verdadero o falso)




        'Variables
        'Declaracion de una variable
        'Dim [nombre de variable] As [Tipo de dato]
        'Dim = Reservar memoria para guardar un dato
        ' As [Tipo de dato] = Definir que tipo de dato voy a guardar en la variable

        Dim miNumero As Integer
        'Inicializo la variable (le doy valor por primera vez)
        miNumero = 0

        'Se puede declarar e inicializar una variable en la misma linea
        Dim miOtroNumero As Integer = 3
        'Tambien puedo operar entre variables (sumar, restar, multiplicar, dividr, etc)
        miNumero = miOtroNumero + 7

        'Muestro la variable con un mensaje

        MsgBox($"Mi numero vale {miNumero}")





        ' 'Secuencias Condicionales

        ' 'If = Si
        ' 'Then = Entonces
        ' 'Else = Si no

        'Evalua la primer condicion
        If miNumero > 10 Then
            'Si la condicion se cumple ejecuto lo que este aca adentro
            MsgBox("Este numero es mayor a 10")
            'Si no se cumple la condicion evalua el ElseIf
        ElseIf miNumero = 10 Then
            'Ejecuto codigo si se cumple la segunda condicion
            MsgBox("Este numero es igual a 10")
            'Si no se cumple ninguna entra al else
        Else
            MsgBox("Este numero es menor a 10")

        End If


        'Estructura Select Case
        'Su funcionamiento es similar al if, analiza que se cumpla la condicion de uno de estos casos y ejecuta el codigo pertinente. Se puede usar la palabra
        '"Else" para marcar un caso por defecto (qué pasa si ninguna condicion es verdadera). 

        'Esta estructura es utilizada para casos en los que sea necesaro analizar muchas condiciones (es mas sencillo leer y seguir el código en estos casos

        Dim mes As String = "Enero"
        Dim anio As Integer = 2021
        Dim dias As Integer
        Select Case mes
            Case "Enero"
                dias = 31
            Case "Febrero"
                dias = 28
            Case "Marzo"
                dias = 31
            Case "Abril"
                dias = 30
            Case "Mayo"
                dias = 31
            Case "Junio"
                dias = 30
            Case "Julio"
                dias = 31
            Case "Agosto"
                dias = 31
            Case "Septiembre"
                dias = 30
            Case "Octubre"
                dias = 31
            Case "Noviembre"
                dias = 30
            Case "Diciembre"
                dias = 31
        End Select

        MsgBox($"El mes {mes} tiene {dias} dias")





        ' 'Secuencias de repeticion
        ' '1- While = mientras se cumpla
        ' 'Secuencia de ejecucion (como funciona)
        ' '1º- Analizar la condicion (miNumero es menor a 10?)
        ' 'Si es verdadero ENTONCES ejecuta el codigo
        ' While miNumero < 10
        '     'miNumero +=1 es lo mismo que hacer miNumero = miNumero + 1
        '     miNumero += 1
        '     MsgBox(miNumero)
        '
        ' End While
        '
        ' '2- Do While = Hacer Mientras
        ' ' 1º Ejecutar el codigo
        ' '2º Analizar la condicion
        ' Do While miNumero < 10
        '     miNumero += 1
        '     MsgBox(miNumero)
        ' Loop
        ' '3 For = Para
        ' 'Variable de iteracion, se usa para contar los bucles o repeticiones
        ' Dim i As Integer
        ' For i = 0 To 10
        '     miNumero += 5
        '     MsgBox(miNumero)
        '
        ' Next

        'Cuando se usa cada tipo de bucle
        'While = Mientras no conozca la cantidad de repeticiones
        'Do While = Mientras no conozca la cantidad de repeticiones Y necesite ejecutar el codigo al menos una vez
        'For = Cuando conozco la cantidad de repeticiones


        Label1.Text = "Primer Numero"
        Label2.Text = "Segundo Numero"
        Button1.Text = "Calcular suma"


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'ByRef = Pasar como referencia
        Dim primerNumero As Integer
        Dim segundoNumero As Integer
        'And = Y. Solo se entra al if si se cumplen las dos condiciones
        If (Integer.TryParse(txtPrimerNumero.Text, primerNumero) And Integer.TryParse(txtSegundoNumero.Text, segundoNumero)) Then
            MsgBox($"La suma de los dos numeros es {primerNumero + segundoNumero}")
        End If
    End Sub
End Class