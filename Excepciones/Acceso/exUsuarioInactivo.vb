' Static Model


Namespace Acceso

    Public Class exUsuarioInactivo
        Inherits Exception
        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "El usuario se encuentra inactivo.")
        End Sub

    End Class ' END CLASS DEFINITION exUsuarioInactivo

End Namespace ' Excepciones.Acceso

