' Static Model


Namespace Acceso

    Public Class exDuplicadoContraseña
        Inherits Exception
        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "El duplicado no coincide con la contraseña.")
        End Sub

    End Class ' END CLASS DEFINITION exDuplicadoContraseña

End Namespace ' Excepciones.Acceso

