Namespace Vales
    Public Class exMontoMayorAValor : Inherits Exception

        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "El monto que se intenta descargar supera al valor del vale.")
        End Sub

    End Class
End Namespace

