Namespace Acceso
    Public Class exTarjetaInvalida : Inherits Exception

        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "La tarjeta escaneada es incorrecta o está fuera de vigencia. Comuníquese con un administrador.")
        End Sub

    End Class
End Namespace

