Namespace Vales
    Public Class vVale

        Private xCVigencia As New List(Of enComponenteValidacion)

        Private xCCantidad As New List(Of enComponenteValidacion)

        Public Sub New()
            xCVigencia.Add(enComponenteValidacion.numeros)
            xCCantidad.Add(enComponenteValidacion.numeros)
        End Sub

        Public Function exDescargado() As String
            Return ValidacionGeneral.Moneda
        End Function

        Public Function exVigencia() As String
            Return ValidacionGeneral.Texto(1, 3, Me.xCVigencia)
        End Function

        Public Function exTotal() As String
            Return ValidacionGeneral.Moneda
        End Function

        Public Function exCantidad() As String
            Return ValidacionGeneral.Texto(1, 5, Me.xCCantidad)
        End Function

        Public Function exValor() As String
            Return ValidacionGeneral.Moneda
        End Function

        Public Function msgVigencia() As String
            Return "Error en el formato de la vigencia de la serie."
        End Function

        Public Function msgTotal() As String
            Return "Error en el formato del total de la serie."
        End Function

        Public Function msgCantidad() As String
            Return "Error en el formato de la cantidad de vales de la distribución."
        End Function

        Public Function msgValor() As String
            Return "Error en el formato del valor de cada vale de la distribución."
        End Function

        Public Function msgDescargado() As String
            Return "Error en el formato del total descargado."
        End Function

        Public Function msgRDescargad() As String
            Return "Debe ingresar el total descargado."
        End Function

        Public Function msgRVigencia() As String
            Return "Debe ingresar la vigencia de la serie."
        End Function

        Public Function msgRTotal() As String
            Return "Debe ingresar el total de la serie."
        End Function

        Public Function msgRCantidad() As String
            Return "Debe ingresar la cantidad de vales de la distribución."
        End Function

        Public Function msgRValor() As String
            Return "Debe ingresar el valor de cada vale de la distribución."
        End Function

        Public Function helpVigencia() As String
            Return ValidacionGeneral.msgTexto(1, 3, Me.xCVigencia)
        End Function

        Public Function helpTotal() As String
            Return ValidacionGeneral.msgMoneda
        End Function

        Public Function helpCantidad() As String
            Return ValidacionGeneral.msgTexto(1, 5, Me.xCCantidad)
        End Function

        Public Function helpValor() As String
            Return ValidacionGeneral.msgMoneda
        End Function

        Public Function helpDescargado() As String
            Return ValidacionGeneral.msgMoneda
        End Function
    End Class
End Namespace

