Namespace Navegacion
    Public Class clsFabricaFormularios
        Public Shared Function Fabricar(ByVal prFormulario As enFormulario, ByVal prMensaje As String) As clsFormulario
            Select Case prFormulario
                Case enFormulario.Descargar
                    frmDescargar.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmDescargar.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmDescargar, 0)
                Case enFormulario.Emitir
                    frmEmitir.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmEmitir.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmEmitir, 24)
                Case enFormulario.Inicio
                    frmInicio.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmInicio.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmInicio, 33)
                Case enFormulario.VerUsuarios
                    frmUsuarios.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmUsuarios.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmUsuarios, 5)
                Case enFormulario.Login
                    frmLogin.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmLogin.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmLogin, 0)
                Case enFormulario.NuevoUsuario
                    frmNuevoUsuario.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmNuevoUsuario.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmNuevoUsuario, 6)
                Case enFormulario.Usuario
                    frmUsuario.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmUsuario.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmUsuario, 34)
                Case enFormulario.CambiarContraseña
                    frmCambiarContraseña.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmCambiarContraseña.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmCambiarContraseña, 7)
                Case enFormulario.Clientes
                    frmClientes.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmClientes.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmClientes, 10)
                Case enFormulario.NuevoCliente
                    frmNuevoCliente.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmNuevoCliente.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmNuevoCliente, 11)
                Case enFormulario.Cliente
                    frmCliente.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmCliente.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmCliente, 10)
                Case enFormulario.Cuenta
                    frmCuenta.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmCuenta.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmCuenta, 14)
                Case enFormulario.Movimientos
                    frmMovimientos.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmMovimientos.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmMovimientos, 15)
                Case enFormulario.Combustibles
                    frmCombustibles.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmCombustibles.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmCombustibles, 29)
                Case enFormulario.VerEmisiones
                    frmSeries.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmSeries.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmSeries, 23)
                Case enFormulario.VerSerie
                    frmSerie.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmSerie.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmSerie, 23)
                Case enFormulario.AsignarTurnos
                    frmAsignar.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmAsignar.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmAsignar, 18)
                Case enFormulario.VerTurnos
                    frmTurnos.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmTurnos.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmTurnos, 0)
                Case enFormulario.VerBitacoras
                    frmBitacoras.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmBitacoras.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmBitacoras, 32)
                Case enFormulario.VerBackups
                    frmBackup.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmBackup.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmBackup, 1)
                Case enFormulario.DescargaParcial
                    frmDescargaParcial.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmDescargaParcial.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmDescargaParcial, 0)
                Case enFormulario.Estadísticas
                    frmEstadisticas.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmEstadisticas.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmEstadisticas, 0)
                Case enFormulario.BuscarVale
                    frmBuscarVale.CtrlMensaje.pdTipo = ctrlMensaje.enTipoMensaje.Mensaje
                    frmBuscarVale.CtrlMensaje.pdMensaje = prMensaje
                    Return New clsFormulario(frmBuscarVale, 0)
                Case Else
                    Return New clsFormulario(frmLogin, 0)
            End Select
        End Function
    End Class
End Namespace

