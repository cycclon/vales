' Static Model


Namespace Acceso

    Public Class exPermisos
        Inherits Exception
        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "No tiene permisos suficientes para acceder a esta funcionalidad del sistema.")
        End Sub

    End Class ' END CLASS DEFINITION exPermisos

End Namespace ' Excepciones.Acceso

