
Friend Class clsExpresionRegular

    Private xExpresion As New List(Of clsComponenteValidacion)
    Private xMinimo As Integer
    Private xMaximo As Integer

    Sub New(ByVal prMinimo As Integer, ByVal prMaximo As Integer)
        For Each xx As Integer In System.Enum.GetValues(GetType(enComponenteValidacion))
            Me.xExpresion.Add(clsComponenteValidacion.ObtenerComponente(xx))
        Next

        Me.xMinimo = prMinimo
        Me.xMaximo = prMaximo
    End Sub

    Public ReadOnly Property pdExpresion() As List(Of clsComponenteValidacion)
        Get
            Return xExpresion
        End Get
    End Property

    Public ReadOnly Property pdMinimo() As Integer
        Get
            Return xMinimo
        End Get
    End Property

    Public ReadOnly Property pdMaximo() As Integer
        Get
            Return xMaximo
        End Get
    End Property

    ''' <summary>
    ''' Devuelve la expresion regular
    ''' </summary>
    Public Function ObtenerExpresion() As String
        Dim xEx As String = "["
        For Each xx As clsComponenteValidacion In Me.xExpresion
            If xx.pdPermitido = True Then
                xEx &= "," & xx.pdValor
            End If
        Next
        Return xEx & "]{" & Me.xMinimo & "," & Me.xMaximo & "}"
    End Function

    ''' <summary>
    ''' Establece todos los componentes de validacion como permitidos
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub PermitirTodos()
        For Each xx As clsComponenteValidacion In Me.xExpresion
            xx.pdPermitido = True
        Next
    End Sub
End Class


