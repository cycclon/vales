Namespace Acceso
    Public Class exTarjetaInvalida : Inherits Exception

        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "La tarjeta escaneada es incorrecta o est� fuera de vigencia. Comun�quese con un administrador.")
        End Sub

    End Class
End Namespace

