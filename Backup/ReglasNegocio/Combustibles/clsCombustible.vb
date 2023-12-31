' Static Model

Imports AccesoADatos.Mapeo.Combustibles
Imports Excepciones.Combustibles
Imports Entidades.Combustibles

Namespace Combustibles

    Public Class clsCombustible : Implements iCombustible

        Protected xNombre As String

        Protected xID As Byte

        Private xEstado As clsEstado

        Public Sub New()
            Me.xEstado = New clsActivo
        End Sub

        Public Property pdID() As Byte Implements Entidades.Combustibles.iCombustible.pdID
            Get
                Return Me.xID
            End Get
            Set(ByVal value As Byte)
                Me.xID = value
            End Set
        End Property

        Public Property pdNombre() As String Implements Entidades.Combustibles.iCombustible.pdNombre
            Get
                Return Me.xNombre
            End Get
            Set(ByVal value As String)
                Me.xNombre = value
            End Set
        End Property

        Public ReadOnly Property pdEstado() As Entidades.Combustibles.enEstadoCombustible Implements Entidades.Combustibles.iCombustible.pdEstado
            Get
                Return Me.xEstado.pdEstado
            End Get
        End Property

        Public Sub Eliminar() Implements Entidades.Combustibles.iCombustible.Eliminar
            Try
                Me.xEstado.Eliminar(Me)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub Restaurar() Implements Entidades.Combustibles.iCombustible.Restaurar
            Try
                Me.xEstado.Restaurar(Me)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub Obtener(ByVal prIDVale As String) Implements Entidades.Combustibles.iCombustible.Obtener
            Try
                Dim objDS As DataSet = mCombustibles.ObtenerPorVale(prIDVale)
                If objDS.Tables(0).Rows.Count <> 0 Then
                    Me.ArmarCombustible(objDS.Tables(0).Rows(0))
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function Listar(ByVal prEstado As Entidades.Combustibles.enEstadoCombustible) As List(Of iCombustible)
            Try
                Dim objDS As DataSet = mCombustibles.Listar(prEstado)
                Dim xCs As New List(Of iCombustible)

                For Each xx As DataRow In objDS.Tables(0).Rows
                    Dim xC As New clsCombustible
                    xC.ArmarCombustible(xx)
                    xCs.Add(xC)
                Next

                Return xCs
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Sub Registrar() Implements Entidades.Combustibles.iCombustible.Registrar
            Try
                Dim objDS As DataSet = mCombustibles.Obtener(Me.xNombre)
                If objDS.Tables(0).Rows.Count <> 0 Then Throw New exNombreEnUso
                mCombustibles.Registrar(Me)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Private Sub CambiarEstado(ByVal prNuevoEstado As clsEstado)
            Me.xEstado = prNuevoEstado
        End Sub

        Private Sub ArmarCombustible(ByVal prRegistro As DataRow)
            With prRegistro
                Me.xID = .Item("com_id")
                Me.xNombre = .Item("com_nombre")
                Me.xEstado = clsEstado.Fabricar(.Item("com_estado"))
            End With
        End Sub

#Region "Clases Anidadas"
        Friend MustInherit Class clsEstado
            Public Shared Function Fabricar(ByVal prEstado As enEstadoCombustible) As clsEstado
                Select Case prEstado
                    Case enEstadoCombustible.Activo
                        Return New clsActivo
                    Case enEstadoCombustible.Inactivo
                        Return New clsInactivo
                    Case Else
                        Return New clsInactivo
                End Select
            End Function

            Public MustOverride Sub Eliminar(ByVal prCombustible As clsCombustible)

            Public MustOverride Sub Restaurar(ByVal prCombustible As clsCombustible)

            Public MustOverride ReadOnly Property pdEstado() As enEstadoCombustible
        End Class

        Friend Class clsInactivo : Inherits clsEstado

            Public Overrides Sub Eliminar(ByVal prCombustible As clsCombustible)
                Throw New exEliminarEliminado
            End Sub

            Public Overrides Sub Restaurar(ByVal prCombustible As clsCombustible)
                Try
                    prCombustible.CambiarEstado(clsEstado.Fabricar(enEstadoCombustible.Activo))
                    mCombustibles.Modificar(prCombustible)
                Catch ex As Exception
                    Throw
                End Try
            End Sub

            Public Overrides ReadOnly Property pdEstado() As Entidades.Combustibles.enEstadoCombustible
                Get
                    Return enEstadoCombustible.Inactivo
                End Get
            End Property
        End Class

        Friend Class clsActivo : Inherits clsEstado

            Public Overrides Sub Eliminar(ByVal prCombustible As clsCombustible)
                Try
                    prCombustible.CambiarEstado(clsEstado.Fabricar(enEstadoCombustible.Inactivo))
                    mCombustibles.Modificar(prCombustible)
                Catch ex As Exception
                    Throw
                End Try
            End Sub

            Public Overrides Sub Restaurar(ByVal prCombustible As clsCombustible)
                Throw New exActivarActivado
            End Sub

            Public Overrides ReadOnly Property pdEstado() As Entidades.Combustibles.enEstadoCombustible
                Get
                    Return enEstadoCombustible.Activo
                End Get
            End Property
        End Class
#End Region

        
    End Class ' END CLASS DEFINITION clsCombustible

End Namespace ' ReglasNegocio.Combustibles

