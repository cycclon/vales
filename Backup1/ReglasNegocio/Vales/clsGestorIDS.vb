Imports AccesoADatos.Mapeo.Vales
Namespace Vales
    Public Class clsGestorIDS
        Dim xClaves As List(Of Long)

        Private Shared xInstancia As clsGestorIDS
        Private xClavesRegistradas As List(Of String)
        Private xClavesTemporales As List(Of String)
        Private Const xTamañoClave As Byte = 9

        Public Function ObtenerUnaClave() As String
            Dim xC As String = 0
            If xClavesTemporales.Count <> 0 Then
                xC = xClavesTemporales(0)
                xClavesTemporales.RemoveAt(0)
            End If
            Return xC
        End Function

        Public Sub ActualizarClaves()
            Try
                Dim objDS As DataSet = mVales.ListarClaves
                For Each xx As DataRow In objDS.Tables(0).Rows
                    xClavesRegistradas.Add(xx.Item("val_id"))
                Next
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Private Sub New()
            Try
                Me.xClavesRegistradas = New List(Of String)
                Me.xClavesTemporales = New List(Of String)

            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function ObtenerInstancia() As clsGestorIDS
            Try
                If xInstancia Is Nothing Then xInstancia = New clsGestorIDS
                Return xInstancia
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Sub GenerarIDs(ByVal prCantidad As Integer)
            Try
                'Me.ActualizarClaves()
                For i As Integer = 1 To prCantidad
                    Dim xHecho As Boolean = False
                    Dim xNuevaClave As String = Me.GenerarClave
                    While Not xHecho
                        If Not ComprobarExistencia(xNuevaClave) Then
                            Me.xClavesTemporales.Add(xNuevaClave)
                            xHecho = True
                        Else
                            xNuevaClave = Me.GenerarClave
                        End If
                    End While
                Next
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Private Function GenerarClave() As String
            Return clsGeneradorIDs.Generate
        End Function

        Private Function ComprobarExistencia(ByVal prClave As String) As Boolean
            Dim xFlag As Boolean = False
            Dim xS As New BusquedaID(prClave)

            Dim xStr As String = Me.xClavesRegistradas.Find(AddressOf xS.Comparar)
            xFlag = Not xStr Is Nothing

            If Not xFlag Then
                xStr = Me.xClavesTemporales.Find(AddressOf xS.Comparar)
                xFlag = Not xStr Is Nothing
            End If

            Return xFlag
        End Function

        Private Class BusquedaID
            Private xID As String
            Public Sub New(ByVal prID As String)
                Me.xID = prID
            End Sub
            Public Function Comparar(ByVal prID As String) As Boolean
                Return xID = prID
            End Function
        End Class

    End Class
End Namespace

