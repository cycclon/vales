' Static Model


Imports Bitacoras
Imports CopiasDeRespaldo

Public Class clsBBackup : Inherits clsBitacora
    Protected xBackup As CopiasDeRespaldo.clsBackup

    Public Sub New(ByVal prTipo As Entidades.Bitacoras.enTipoBitacora)
        Me.xTipo = prTipo
        Me.Inicializar()
    End Sub

    Public Property pdBackup() As clsBackup
        Get
            Return Me.xBackup
        End Get

        Set(ByVal Value As clsBackup)
            Me.xBackup = Value
        End Set
    End Property

    Public Overrides Function Mensaje() As String
        Return " Base: " & Me.xBackup.pdBase.pdNombre & " Fecha: " & Me.xBackup.pdFecha & " Archivo: " & Me.xBackup.pdArchivo
    End Function

End Class ' END CLASS DEFINITION clsBBackup



