Imports System.Text
Public Class Cuenta
    'Atributos (datos) de un objeto cuenta
    Private titular As String
    Private monto As Double
    ''' <summary>
    ''' Inicializa una variable del tipo Cuenta
    ''' </summary>
    ''' <param name="titular">Titular de la cuenta</param>
    ''' <param name="monto">Monto inicial asociado a la cuenta</param>
    Public Sub New(titular As String, monto As Double)
        Me.titular = titular
        Me.monto = monto
    End Sub
    ''' <summary>
    ''' Retorna el titular de la cuenta
    ''' </summary>
    ''' <returns>Titular de la cuenta</returns>
    Public ReadOnly Property Titular1 As String
        Get
            Return titular
        End Get
    End Property
    ''' <summary>
    ''' Retorna el monto de efectivo que contiene actualmente la cuenta
    ''' </summary>
    ''' <returns>Monto de efectivo disponible</returns>
    Public ReadOnly Property Monto1 As Double
        Get
            Return monto
        End Get
    End Property
    ''' <summary>
    ''' Muestra los datos de la cuenta
    ''' </summary>
    ''' <returns>Datos de la cuenta en formato string</returns>
    Function MostrarCuenta() As String
        Dim sb As StringBuilder = New StringBuilder()
        sb.AppendLine($"Titular: {Titular1}")
        sb.AppendLine($"Monto: {monto}")
        Return sb.ToString()
    End Function
    ''' <summary>
    ''' Permite ingresar efectivo en la cuenta. No realiza accion alguna con montos negativos
    ''' </summary>
    ''' <param name="monto">Cantidad de efectivo a ingresar</param>
    Sub Ingresar(monto As Double)
        If monto > 0 Then
            Me.monto += monto
        End If
    End Sub
    ''' <summary>
    ''' Permite retirar efectivo de la cuenta
    ''' </summary>
    ''' <param name="monto">Monto a retirar</param>
    Sub Retirar(monto As Double)
        Me.monto -= monto
    End Sub
End Class
