
Friend Class clsComponenteValidacion

    Private xNombre As enComponenteValidacion
    Private xValor As String
    Private xPermitido As Boolean

    Sub New(ByVal prNombre As enComponenteValidacion, ByVal prValor As String)
        Me.xNombre = prNombre
        Me.xPermitido = False
        Me.xValor = prValor
    End Sub

    Public Property pdNombre() As enComponenteValidacion
        Get
            Return xNombre
        End Get
        Set(ByVal value As enComponenteValidacion)
            xNombre = value
        End Set
    End Property

    Public Property pdValor() As String
        Get
            Return xValor
        End Get
        Set(ByVal value As String)
            xValor = value
        End Set
    End Property

    Public Property pdPermitido() As Boolean
        Get
            Return xPermitido
        End Get
        Set(ByVal value As Boolean)
            xPermitido = value
        End Set
    End Property

    Public Shared Function ObtenerComponente(ByVal prIDComponente As Integer) As clsComponenteValidacion

        Select Case prIDComponente
            Case 1
                Return New clsComponenteValidacion(enComponenteValidacion.letras, "a-z,A-Z,á,é,í,ó,ú,Á,É,Í,Ó,Ú, ñ, Ñ")
            Case 2
                Return New clsComponenteValidacion(enComponenteValidacion.numeros, "0-9")
            Case 3
                Return New clsComponenteValidacion(enComponenteValidacion.punto, "\.")
            Case 4
                Return New clsComponenteValidacion(enComponenteValidacion.coma, "\,")
            Case 5
                Return New clsComponenteValidacion(enComponenteValidacion.puntoycopa, ";")
            Case 6
                Return New clsComponenteValidacion(enComponenteValidacion.dospuntos, ":")
            Case 7
                Return New clsComponenteValidacion(enComponenteValidacion.pesos, "$")
            Case 8
                Return New clsComponenteValidacion(enComponenteValidacion.igual, "=")
            Case 9
                Return New clsComponenteValidacion(enComponenteValidacion.espacio, "\s")
            Case 10
                Return New clsComponenteValidacion(enComponenteValidacion.guion, "\-")
            Case 11
                Return New clsComponenteValidacion(enComponenteValidacion.guionbajo, "_")
            Case 12
                Return New clsComponenteValidacion(enComponenteValidacion.barra_izq_der, "/")
            Case 13
                Return New clsComponenteValidacion(enComponenteValidacion.barra_der_izq, "\\")
            Case 14
                Return New clsComponenteValidacion(14, "¡")
            Case 15
                Return New clsComponenteValidacion(15, "!")
            Case 16
                Return New clsComponenteValidacion(16, "¿")
            Case 17
                Return New clsComponenteValidacion(17, "\?")
            Case 18
                Return New clsComponenteValidacion(18, "%")

            Case Else
                Return New clsComponenteValidacion(enComponenteValidacion.letras, "a-z,A-Z,á,é,í,ó,ú,Á,É,Í,Ó,Ú")
        End Select

    End Function
End Class


