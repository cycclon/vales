' Static Model

Imports Entidades.Bitacoras
Public Class clsFabricaBitacoras

    Public Shared Function Fabricar(ByVal prTipo As enTipoBitacora) As String
        Select Case prTipo
            Case enTipoBitacora.BackupEliminado
                Return "Copia de respaldo eliminada"
            Case enTipoBitacora.BackupGenerado
                Return "Copia de respaldo generada"
            Case enTipoBitacora.BaseRestaurada
                Return "Base de datos restaurada"
            Case enTipoBitacora.ClienteEliminado
                Return "Cliente eliminado"
            Case enTipoBitacora.ClienteModificado
                Return "Cliente modificado"
            Case enTipoBitacora.ClienteRestaurado
                Return "Cliente restaurado"
            Case enTipoBitacora.ClienteRegistrado
                Return "Cliente registrado"
            Case enTipoBitacora.ContraseñaCambiada
                Return "Contraseña cambiada"
            Case enTipoBitacora.ContraseñaEstablecida
                Return "Contraseña establecida"
            Case enTipoBitacora.ContraseñaIncorrecta
                Return "Contraseña mal ingresada"
            Case enTipoBitacora.DescargaEfectuada
                Return "Descarga de vale efectuada"
            Case enTipoBitacora.InicioDeSesion
                Return "Inicio de sesión exitoso"
            Case enTipoBitacora.SerieEliminada
                Return "Serie de vales eliminada"
            Case enTipoBitacora.SerieEmitida
                Return "Serie de vales emitida"
            Case enTipoBitacora.UsuarioActivado
                Return "Usuario activado"
            Case enTipoBitacora.UsuarioDesactivado
                Return "Usuario desactivado"
            Case enTipoBitacora.UsuarioInactivo
                Return "Intento de inicio de sesión con usuario inactivo"
            Case enTipoBitacora.UsuarioInexistente
                Return "Intento de inicio de sesión con usuario inexistente"
            Case enTipoBitacora.UsuarioRegistrado
                Return "Usuario registrado"
            Case enTipoBitacora.ValeEliminado
                Return "Vale eliminado"
            Case enTipoBitacora.DescargarValeDescargado
                Return "Intentó descargar un vale ya descargado."
            Case enTipoBitacora.DescargarValeReportado
                Return "Intentó descargar un vale reportado como extraviado / robado."
            Case enTipoBitacora.DescargarValeVencido
                Return "Intentó descargar un vale vencido."
            Case enTipoBitacora.ReestablecerContraseña
                Return "Contraseña reestablecida."
            Case Else
                Return "Bitácora en blanco"
        End Select
    End Function

End Class ' END CLASS DEFINITION clsFabricaBitacoras


