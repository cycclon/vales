' Static Model


Namespace Acceso

    Public Class exUsuarioInexistente : Inherits Exception
        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "El usuario no existe.")
        End Sub

    End Class ' END CLASS DEFINITION exUsuarioInexistente

End Namespace ' Excepciones.Acceso

