' Static Model


Namespace Acceso

    Public Class exApodoEnUso
        Inherits Exception
        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "El apodo de usuario seleccionado ya está en uso.")
        End Sub

    End Class ' END CLASS DEFINITION exApodoEnUso

End Namespace ' Excepciones.Acceso

