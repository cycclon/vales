' Static Model


Namespace Acceso

    Public Class exPermisos
        Inherits Exception
        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "No tiene permisos suficientes para acceder a esta funcionalidad del sistema.")
        End Sub

    End Class ' END CLASS DEFINITION exPermisos

End Namespace ' Excepciones.Acceso

