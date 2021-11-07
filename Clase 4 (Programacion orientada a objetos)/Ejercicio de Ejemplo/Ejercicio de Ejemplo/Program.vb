Imports System
Imports Entidades
'Consigna#
'Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.
'
'Deberá tener los atributos:
'
'titular que contendrá el nombre del titular de la cuenta.
'cantidad que será un número Double que representa al monto actual de dinero en la cuenta.

'Construir los siguientes métodos para la clase:
'
'Un constructor que permita inicializar todos los atributos.
'Un método getter para cada atributo.
'mostrar retornará una cadena de texto con todos los datos de la cuenta.
'ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
'retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
'En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.
Module Program
    Sub Main(args As String())
        'creo 3 objetos del tipo Cuenta
        Dim cuenta1 As Cuenta = New Cuenta("Lucas", 10000)
        Dim cuenta2 As Cuenta = New Cuenta("Carolina", 15000)
        Dim cuenta3 As Cuenta = New Cuenta("Martin", 4000)

        'Pruebo las funciones creadas
        Console.WriteLine(cuenta1.MostrarCuenta())
        cuenta1.Ingresar(1500)
        Console.WriteLine(cuenta1.MostrarCuenta())
        cuenta2.Retirar(5000)
        Console.WriteLine(cuenta2.MostrarCuenta())
        cuenta3.Ingresar(2000)
        cuenta3.Ingresar(1000)
        Console.WriteLine(cuenta3.MostrarCuenta())



    End Sub
End Module
