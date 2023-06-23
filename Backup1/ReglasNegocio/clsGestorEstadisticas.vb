Imports Entidades.Vales
Imports ReglasNegocio.Vales
Imports AccesoADatos.Mapeo.Estadisticas
Imports Entidades.Turnos
Imports ReglasNegocio.Turnos

Public Class clsGestorEstadisticas

    Private xCombustibleEmitido As Double
    Private xCombustibleRestante As Double
    Private xDineroEmitido As Double
    Private xDineroRestante As Double

#Region "Singleton"
    Private Shared xInstancia As clsGestorEstadisticas

    Private Sub New()

    End Sub

    Public Shared Function Instanciar() As clsGestorEstadisticas
        If xInstancia Is Nothing Then xInstancia = New clsGestorEstadisticas
        Return xInstancia
    End Function
#End Region

#Region "Vales"
    Public Function DineroEmitido() As Double
        Try
            Dim objDS As DataSet = mEstadisticas.DineroEmitido
            If Not objDS.Tables(0).Rows(0).Item(0) Is DBNull.Value Then
                Me.xDineroEmitido = objDS.Tables(0).Rows(0).Item(0)
            Else
                Me.xDineroEmitido = 0
            End If
            Return xDineroEmitido
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CombustibleEmitido() As Double
        Try
            Dim objDS As DataSet = mEstadisticas.CombustibleEmitido
            If Not objDS.Tables(0).Rows(0).Item(0) Is DBNull.Value Then
                Me.xCombustibleEmitido = objDS.Tables(0).Rows(0).Item(0)
            Else
                Me.xCombustibleEmitido = 0
            End If
            Return xCombustibleEmitido
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function DineroRestante() As Double
        Try
            Dim objDS As DataSet = mEstadisticas.DineroEmitido
            Dim objDS2 As DataSet = mEstadisticas.DineroDescargado
            If Not objDS.Tables(0).Rows(0).Item(0) Is DBNull.Value And Not objDS2.Tables(0).Rows(0).Item(0) Is DBNull.Value Then
                Me.xDineroRestante = objDS.Tables(0).Rows(0).Item(0) - objDS2.Tables(0).Rows(0).Item(0)
            Else
                xDineroRestante = 0
            End If

            Return xDineroRestante
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CombustibleRestante() As Double
        Try
            Dim objDS As DataSet = mEstadisticas.CombustibleEmitido
            Dim objDS2 As DataSet = mEstadisticas.CombustibleDescargado
            If Not objDS.Tables(0).Rows(0).Item(0) Is DBNull.Value And Not objDS2.Tables(0).Rows(0).Item(0) Is DBNull.Value Then
                Me.xCombustibleRestante = objDS.Tables(0).Rows(0).Item(0) - objDS2.Tables(0).Rows(0).Item(0)
            Else
                xCombustibleRestante = 0
            End If

            Return xCombustibleRestante
        Catch ex As Exception
            Throw
        End Try
    End Function
#End Region

#Region "Dias y turnos"
    Public Function DiaDeMasDescargas() As String
        Try
            Dim objDS As DataSet = mEstadisticas.DiaDeMasDescargas
            Dim xContador(8) As Long

            For i As Byte = 0 To UBound(xContador)
                xContador(i) = 0
            Next

            For Each xx As DataRow In objDS.Tables(0).Rows
                Select Case Date.Parse(xx.Item("ditr_fecha")).DayOfWeek
                    Case DayOfWeek.Sunday
                        xContador(1) += 1
                    Case DayOfWeek.Monday
                        xContador(2) += 1
                    Case DayOfWeek.Tuesday
                        xContador(3) += 1
                    Case DayOfWeek.Wednesday
                        xContador(4) += 1
                    Case DayOfWeek.Thursday
                        xContador(5) += 1
                    Case DayOfWeek.Friday
                        xContador(6) += 1
                    Case DayOfWeek.Saturday
                        xContador(7) += 1
                End Select
            Next

            Dim xMayor As Byte = 0
            For j As Byte = 1 To UBound(xContador)
                If xContador(j) > xContador(xMayor) Then
                    xMayor = j
                End If
            Next

            If xMayor = 0 Then
                Return "aún no hubo descargas."
            Else
                Return System.Enum.GetNames(GetType(enDiasSemana))(xMayor - 1)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function PromedioDescargasCombustibleDia() As Single
        Try
            Dim objDS As DataSet = mEstadisticas.CantidadDiasTrabajados
            Dim xDescargado As Double = Me.xCombustibleEmitido - Me.xCombustibleRestante

            If objDS.Tables(0).Rows(0).Item(0) = 0 Then
                Return 0
            Else
                Return Math.Round(xDescargado / objDS.Tables(0).Rows(0).Item(0), 2)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function PromedioDescargasDineroDia() As Single
        Try
            Dim objDS As DataSet = mEstadisticas.CantidadDiasTrabajados
            Dim xDescargado As Double = Me.xDineroEmitido - Me.xDineroRestante

            If objDS.Tables(0).Rows(0).Item(0) = 0 Then
                Return 0
            Else
                Return Math.Round(xDescargado / objDS.Tables(0).Rows(0).Item(0), 2)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
#End Region

#Region "Usuarios"
    Public Function CantidadAdministradores() As Short
        Try
            Dim objDS As DataSet = mEstadisticas.CantidadAdministradores

            Return objDS.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CantidadEmpleados() As Short
        Try
            Dim objDS As DataSet = mEstadisticas.CantidadEmpleados

            Return objDS.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function EmpleadoQueMasDescarga() As String
        Try
            Dim objDS As DataSet = mEstadisticas.EmpleadoQueMasDescarga
            Dim xU As Entidades.Acceso.iUsuario

            If objDS.Tables(0).Rows.Count <> 0 Then
                xU = Acceso.clsUsuario.ObtenerPorID(objDS.Tables(0).Rows(0).Item(0))
            Else
                xU = Acceso.clsUsuario.ObtenerPorID(0)
            End If

            If xU.pdID = 0 Then
                Return "aún no hubo descargas."
            Else
                Return xU.pdNombreCompleto
            End If

        Catch ex As Exception
            Throw
        End Try
    End Function
#End Region

End Class
