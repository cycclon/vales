' Static Model


Namespace Combustibles

    Public Class exNombreEnUso : Inherits Exception
        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "El nombre de combustible seleccionado ya está en uso. Verifique la lista de 'Combustibles eliminados' y restaure el deseado.")
        End Sub

    End Class ' END CLASS DEFINITION exNombreEnUso

End Namespace ' Excepciones.Combustibles

