Public Class clsFFecha : Inherits clsFiltroBitacora

    Protected xInicio As Date

    Protected xFinal As Date


    Public Sub New(ByVal prInicio As Date, ByVal prFinal As Date)
        Me.xInicio = prInicio
        Me.xFinal = prFinal
    End Sub

    Public Property pdInicio() As Date
        Get
            Return Me.xInicio
        End Get

        Set(ByVal Value As Date)
            Me.xInicio = Value
        End Set
    End Property

    Public Property pdFinal() As Date
        Get
            Return Me.xFinal
        End Get

        Set(ByVal Value As Date)
            Me.xFinal = Value
        End Set
    End Property

    Public Overrides Function Filtrar(ByVal prBitacora As Entidades.Bitacoras.iBitacora) As Boolean
        If prBitacora.pdFecha.Date >= Me.xInicio.Date And prBitacora.pdFecha.Date <= Me.xFinal.Date Then
            Return True
        Else
            Return False
        End If
    End Function
End Class

