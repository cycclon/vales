Imports Entidades.Acceso
Imports Entidades.Vales

Namespace Turnos

    Public Interface iTurno : Inherits iLazy

        Property pdResumen() As iResumen

        Property pdInicio() As TimeSpan

        Property pdFinal() As TimeSpan

        Property pdID() As Integer

        ReadOnly Property Turno() As String

        Sub AgregarDescarga(ByVal prDescarga As iDescarga)

    End Interface ' END INTERFACE DEFINITION iTurno

End Namespace ' Entidades.Turnos

