<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeRolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeOpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarOpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirDepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarPermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarVacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarHorarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JornadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.OtrosToolStripMenuItem, Me.OtrosToolStripMenuItem1, Me.OtrosToolStripMenuItem2, Me.SeguridadToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirEmpleadoToolStripMenuItem, Me.AñadirDepartamentoToolStripMenuItem, Me.GestionarCargosToolStripMenuItem})
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.OtrosToolStripMenuItem.Text = "Editar"
        '
        'OtrosToolStripMenuItem1
        '
        Me.OtrosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarCargosToolStripMenuItem, Me.AdministrarPermisosToolStripMenuItem, Me.AdministrarVacacionesToolStripMenuItem})
        Me.OtrosToolStripMenuItem1.Name = "OtrosToolStripMenuItem1"
        Me.OtrosToolStripMenuItem1.Size = New System.Drawing.Size(81, 20)
        Me.OtrosToolStripMenuItem1.Text = "Administrar"
        '
        'OtrosToolStripMenuItem2
        '
        Me.OtrosToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JornadaToolStripMenuItem, Me.AsistenciaToolStripMenuItem, Me.InformeGeneralToolStripMenuItem})
        Me.OtrosToolStripMenuItem2.Name = "OtrosToolStripMenuItem2"
        Me.OtrosToolStripMenuItem2.Size = New System.Drawing.Size(35, 20)
        Me.OtrosToolStripMenuItem2.Text = "Ver"
        '
        'SeguridadToolStripMenuItem
        '
        Me.SeguridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeUsuarioToolStripMenuItem, Me.GestionDeRolesToolStripMenuItem, Me.GestionDeOpcionesToolStripMenuItem})
        Me.SeguridadToolStripMenuItem.Name = "SeguridadToolStripMenuItem"
        Me.SeguridadToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SeguridadToolStripMenuItem.Text = "Seguridad"
        '
        'GestionDeUsuarioToolStripMenuItem
        '
        Me.GestionDeUsuarioToolStripMenuItem.Name = "GestionDeUsuarioToolStripMenuItem"
        Me.GestionDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.GestionDeUsuarioToolStripMenuItem.Text = "Gestion de usuario"
        '
        'GestionDeRolesToolStripMenuItem
        '
        Me.GestionDeRolesToolStripMenuItem.Name = "GestionDeRolesToolStripMenuItem"
        Me.GestionDeRolesToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.GestionDeRolesToolStripMenuItem.Text = "Gestion de roles "
        '
        'GestionDeOpcionesToolStripMenuItem
        '
        Me.GestionDeOpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.AsignarOpcionesToolStripMenuItem})
        Me.GestionDeOpcionesToolStripMenuItem.Name = "GestionDeOpcionesToolStripMenuItem"
        Me.GestionDeOpcionesToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.GestionDeOpcionesToolStripMenuItem.Text = "Gestion de opciones "
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'AsignarOpcionesToolStripMenuItem
        '
        Me.AsignarOpcionesToolStripMenuItem.Name = "AsignarOpcionesToolStripMenuItem"
        Me.AsignarOpcionesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AsignarOpcionesToolStripMenuItem.Text = "Asignar Opciones"
        '
        'AñadirEmpleadoToolStripMenuItem
        '
        Me.AñadirEmpleadoToolStripMenuItem.Name = "AñadirEmpleadoToolStripMenuItem"
        Me.AñadirEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AñadirEmpleadoToolStripMenuItem.Text = "Gestionar empleado"
        '
        'AñadirDepartamentoToolStripMenuItem
        '
        Me.AñadirDepartamentoToolStripMenuItem.Name = "AñadirDepartamentoToolStripMenuItem"
        Me.AñadirDepartamentoToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AñadirDepartamentoToolStripMenuItem.Text = "Gestionar Departamento"
        '
        'AdministrarCargosToolStripMenuItem
        '
        Me.AdministrarCargosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarHorarioToolStripMenuItem})
        Me.AdministrarCargosToolStripMenuItem.Name = "AdministrarCargosToolStripMenuItem"
        Me.AdministrarCargosToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AdministrarCargosToolStripMenuItem.Text = "Administrar cargos"
        '
        'AdministrarPermisosToolStripMenuItem
        '
        Me.AdministrarPermisosToolStripMenuItem.Name = "AdministrarPermisosToolStripMenuItem"
        Me.AdministrarPermisosToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AdministrarPermisosToolStripMenuItem.Text = "Administrar Permisos"
        '
        'AdministrarVacacionesToolStripMenuItem
        '
        Me.AdministrarVacacionesToolStripMenuItem.Name = "AdministrarVacacionesToolStripMenuItem"
        Me.AdministrarVacacionesToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AdministrarVacacionesToolStripMenuItem.Text = "Administrar Vacaciones"
        '
        'GestionarHorarioToolStripMenuItem
        '
        Me.GestionarHorarioToolStripMenuItem.Name = "GestionarHorarioToolStripMenuItem"
        Me.GestionarHorarioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GestionarHorarioToolStripMenuItem.Text = "Gestionar Horario"
        '
        'JornadaToolStripMenuItem
        '
        Me.JornadaToolStripMenuItem.Name = "JornadaToolStripMenuItem"
        Me.JornadaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.JornadaToolStripMenuItem.Text = "Jornada"
        '
        'AsistenciaToolStripMenuItem
        '
        Me.AsistenciaToolStripMenuItem.Name = "AsistenciaToolStripMenuItem"
        Me.AsistenciaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AsistenciaToolStripMenuItem.Text = "Asistencia"
        '
        'InformeGeneralToolStripMenuItem
        '
        Me.InformeGeneralToolStripMenuItem.Name = "InformeGeneralToolStripMenuItem"
        Me.InformeGeneralToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InformeGeneralToolStripMenuItem.Text = "Informe general"
        '
        'GestionarCargosToolStripMenuItem
        '
        Me.GestionarCargosToolStripMenuItem.Name = "GestionarCargosToolStripMenuItem"
        Me.GestionarCargosToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.GestionarCargosToolStripMenuItem.Text = "Gestionar cargos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtrosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OtrosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeRolesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeOpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignarOpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirDepartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarCargosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarHorarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarPermisosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarVacacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarCargosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JornadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsistenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformeGeneralToolStripMenuItem As ToolStripMenuItem
End Class
