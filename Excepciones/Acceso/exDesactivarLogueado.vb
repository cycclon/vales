' Static Model


Namespace Acceso

    Public Class exDesactivarLogueado
        Inherits Exception
        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "No se puede desactivar un usuario cuya sesión se encuentra activa.")
        End Sub

    End Class ' END CLASS DEFINITION exDesactivarLogueado

End Namespace ' Excepciones.Acceso

