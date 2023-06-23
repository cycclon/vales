Imports Acceso
Public Class ctrlMenu

    Public Sub MostrarMenu()
        Me.Controls.Clear()
        Dim xS As clsSesion = clsSesion.ObtenerInstancia()

        'ADMINISTRAR
        If Not xS.UsuarioLogueado Then
            Dim xADM As New ctrlCategoriaMenu
            Dim xBADM As New List(Of ctrlBotonMenu)
            If xS.ValidarPermiso(0) Then xBADM.Add(New ctrlBotonMenu("Iniciar Sesión", Navegacion.enFormulario.Login))
            xADM.Dock = DockStyle.Bottom
            xADM.pdBotones = xBADM
            xADM.pdTitulo = "Administrar"
            If xBADM.Count <> 0 Then Me.Controls.Add(xADM)
        End If

        'BACKUPS
        Dim xBackups As New ctrlCategoriaMenu
        Dim xBBackups As New List(Of ctrlBotonMenu)
        Dim xNombrePC As String = ReglasNegocio.Configuracion.clsGestorConfiguracion.ObtenerServidor
        If xS.ValidarPermiso(2) Then xBBackups.Add(New ctrlBotonMenu("Ver Backups", Navegacion.enFormulario.VerBackups))
        If Not xS.pdUsuario Is Nothing Then xBBackups.Add(New ctrlBotonMenu("Estadísticas", Navegacion.enFormulario.Estadísticas))
        If xS.ValidarPermiso(32) Then xBBackups.Add(New ctrlBotonMenu("Ver Bitácoras", Navegacion.enFormulario.VerBitacoras))
        If Not xS.pdUsuario Is Nothing Then xBBackups.Add(New ctrlBotonMenu("Buscar Vale", Navegacion.enFormulario.BuscarVale))
        xBackups.pdBotones = xBBackups
        xBackups.Dock = DockStyle.Top
        xBackups.pdTitulo = "Utilidades"
        If xBBackups.Count <> 0 Then Me.Controls.Add(xBackups)

        ''BITACORAS
        'Dim xBitacoras As New ctrlCategoriaMenu
        'Dim xBBitacoras As New List(Of ctrlBotonMenu)
        'If xS.ValidarPermiso(32) Then xBBitacoras.Add(New ctrlBotonMenu("Ver Registro", Navegacion.enFormulario.VerBitacoras))
        'xBitacoras.pdBotones = xBBitacoras
        'xBitacoras.Dock = DockStyle.Top
        'xBitacoras.pdTitulo = "Bitácoras"
        'If xBBitacoras.Count <> 0 Then Me.Controls.Add(xBitacoras)

        'USUARIOS
        Dim xUsuarios As New ctrlCategoriaMenu
        Dim xBUsuarios As New List(Of ctrlBotonMenu)
        If xS.ValidarPermiso(5) Then xBUsuarios.Add(New ctrlBotonMenu("Ver Usuarios", Navegacion.enFormulario.VerUsuarios))
        If xS.ValidarPermiso(6) Then xBUsuarios.Add(New ctrlBotonMenu("Nuevo Usuario", Navegacion.enFormulario.NuevoUsuario))
        xUsuarios.pdBotones = xBUsuarios
        xUsuarios.Dock = DockStyle.Top
        xUsuarios.pdTitulo = "Usuarios"
        If xBUsuarios.Count <> 0 Then Me.Controls.Add(xUsuarios)

        'COMBUSTIBLES
        Dim xCombustibles As New ctrlCategoriaMenu
        Dim xBCombustibles As New List(Of ctrlBotonMenu)
        If xS.ValidarPermiso(29) Then xBCombustibles.Add(New ctrlBotonMenu("Combustibles", Navegacion.enFormulario.Combustibles))
        xCombustibles.pdBotones = xBCombustibles
        xCombustibles.Dock = DockStyle.Top
        xCombustibles.pdTitulo = "Combustibles"
        If xBCombustibles.Count <> 0 Then Me.Controls.Add(xCombustibles)

        'CLIENTES
        Dim xClientes As New ctrlCategoriaMenu
        Dim xBClientes As New List(Of ctrlBotonMenu)
        If xS.ValidarPermiso(10) Then xBClientes.Add(New ctrlBotonMenu("Ver Clientes", Navegacion.enFormulario.Clientes))
        If xS.ValidarPermiso(11) Then xBClientes.Add(New ctrlBotonMenu("Nuevo Cliente", Navegacion.enFormulario.NuevoCliente))
        xClientes.pdBotones = xBClientes
        xClientes.Dock = DockStyle.Top
        xClientes.pdTitulo = "Clientes"
        If xBClientes.Count <> 0 Then Me.Controls.Add(xClientes)

        'TURNOS
        Dim xTurnos As New ctrlCategoriaMenu
        Dim xBTurnos As New List(Of ctrlBotonMenu)
        If xS.ValidarPermiso(18) Then xBTurnos.Add(New ctrlBotonMenu("Asignar", Navegacion.enFormulario.AsignarTurnos))
        If xS.ValidarPermiso(0) Then xBTurnos.Add(New ctrlBotonMenu("Ver Turnos", Navegacion.enFormulario.VerTurnos))
        xTurnos.pdBotones = xBTurnos
        xTurnos.Dock = DockStyle.Top
        xTurnos.pdTitulo = "Turnos"
        If xBTurnos.Count <> 0 Then Me.Controls.Add(xTurnos)

        'VALES
        Dim xVales As New ctrlCategoriaMenu
        Dim xBVales As New List(Of ctrlBotonMenu)
        If xS.ValidarPermiso(24) Then xBVales.Add(New ctrlBotonMenu("Emitir", Navegacion.enFormulario.Emitir))
        If xS.ValidarPermiso(0) Then xBVales.Add(New ctrlBotonMenu("Descargar", Navegacion.enFormulario.Descargar))
        If xS.ValidarPermiso(0) Then xBVales.Add(New ctrlBotonMenu("D. Parcial", Navegacion.enFormulario.DescargaParcial))
        If xS.ValidarPermiso(23) Then xBVales.Add(New ctrlBotonMenu("Ver Emisiones", Navegacion.enFormulario.VerEmisiones))
        xVales.pdBotones = xBVales
        xVales.Dock = DockStyle.Top
        xVales.pdTitulo = "Vales"
        If xBVales.Count <> 0 Then Me.Controls.Add(xVales)
    End Sub

    Private Sub ctrlMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MostrarMenu()
    End Sub

End Class
