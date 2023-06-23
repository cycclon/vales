

''' <summary>
''' Devuelve la expresion regurar para validar codigo HTML
''' </summary>
Friend Class ValidacionGeneral

    ''' <summary>
    ''' Devuelve un mensaje de formato correcto para el texto normal
    ''' </summary>
    ''' <param name="prMin">Cantidad Maxima</param>
    ''' <param name="prMax">Cantidad Minima</param>
    ''' <param name="prCaracteres">Caracteres Permitidos</param>
    ''' <returns>Mensaje de formato de texto normal</returns>
    ''' <remarks></remarks>
    Public Shared Function msgTexto(ByVal prMin As Integer, ByVal prMax As Integer, ByVal prCaracteres As List(Of enComponenteValidacion)) As String
        'Objeto expresion regular
        Dim objEx As New clsExpresionRegular(prMin, prMax)
        'Mensaje a devolver
        Dim xMsg As String = "Caracteres permitidos: "

        'recorro los caracteres permitidos
        For Each xx As enComponenteValidacion In prCaracteres
            'Recorro los caracteres de la expresion regular
            For Each yy As clsComponenteValidacion In objEx.pdExpresion
                'Habilito el caracter
                If xx = yy.pdNombre Then
                    yy.pdPermitido = True
                End If
            Next
        Next

        'Si la cantidad de caracteres permitidos es cero entonces permito todos
        If prCaracteres.Count = 0 Then
            objEx.PermitirTodos()
        End If

        Dim xPermitidos As New List(Of clsComponenteValidacion)

        'Obtengo los caracteres permitidos
        For Each xx As clsComponenteValidacion In objEx.pdExpresion
            If xx.pdPermitido Then
                xPermitidos.Add(xx)
            End If
        Next

        For Each xx As clsComponenteValidacion In xPermitidos
            xMsg &= xx.pdNombre.ToString
            If xPermitidos.IndexOf(xx) = xPermitidos.Count - 2 Then
                xMsg &= " y "
            ElseIf Not xPermitidos.IndexOf(xx) = xPermitidos.Count - 1 Then
                xMsg &= ", "
            End If
        Next

        xMsg = xMsg & ". Mínimo: " & prMin & ". Máximo: " & prMax
        Return xMsg
    End Function

    ''' <summary>
    ''' Devuelve la expresión regular para validar un porcentaje
    ''' </summary>
    ''' <returns>Expresión regular</returns>
    ''' <remarks></remarks>
    Public Shared Function Porcentaje() As String
        Return "(?!^0*$)(?!^0*\,0*$)^\d{1,2}(\,\d{1,2})|(100|100\,0|100\,00)?$"
    End Function

    ''' <summary>
    ''' Devuelve la expresion regular para validar texto normal excepto algunos caracteres
    ''' </summary>
    ''' <param name="prMin">Cantidad minima de caracteres esperada</param>
    ''' <param name="prMax">Cantidad maxima de caracteres esperada</param>
    ''' <param name="prCaracteres">Lista de caracteres permitidos</param>
    Public Shared Function Texto(ByVal prMin As Integer, ByVal prMax As Integer, ByVal prCaracteres As List(Of enComponenteValidacion)) As String
        Dim objEx As New clsExpresionRegular(prMin, prMax)

        If prCaracteres.Count = 0 Then
            objEx.PermitirTodos()
        Else
            For Each xx As enComponenteValidacion In prCaracteres
                For Each yy As clsComponenteValidacion In objEx.pdExpresion
                    If xx = yy.pdNombre Then
                        yy.pdPermitido = True
                    End If
                Next
            Next
        End If

        Dim xEx As String = objEx.ObtenerExpresion
        Return xEx
    End Function

    ''' <summary>
    ''' Devuelve la expresion regular para validar direcciones de correo electronico.
    ''' </summary>
    Public Shared Function Email() As String
        Return "[\.,\-,_, A-Z, a-z, 0-9]{2,30}@[\.,\-,_, A-Z, a-z, 0-9]{2,30}\.[\., a-z, A-Z]{2,11}"
    End Function

    ''' <summary>
    ''' Devuelve la expresión regular para validar fechas
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Fecha()
        Return "[0-9]{2}/[0-9]{2}/[0-9]{4}"
    End Function

    ''' <summary>
    ''' Devuelve la expresion regular para validar valores de moneda
    ''' </summary>
    ''' <remarks>2 decimales</remarks>
    Public Shared Function Moneda() As String
        Return ("[0-9]{1,5}(,[0-9][0-9])?")
    End Function

    Public Shared Function msgMoneda() As String
        Return "Ej: 55,25"
    End Function
End Class


