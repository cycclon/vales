' Static Model


Namespace Acceso

    Public Class exContraseñaIncorrecta
        Inherits Exception
        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "La contraseña es incorrecta.")
        End Sub

    End Class ' END CLASS DEFINITION exContraseñaIncorrecta

End Namespace ' Excepciones.Acceso

