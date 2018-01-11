<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(principal))
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiclosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msPrincipal = New System.Windows.Forms.MenuStrip()
        Me.CatálogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KardexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaIndividualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarCalificaciònToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarCalifcacionPorAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.msPrincipal.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.AutoSize = False
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        '
        'AlumnosToolStripMenuItem1
        '
        Me.AlumnosToolStripMenuItem1.Name = "AlumnosToolStripMenuItem1"
        Me.AlumnosToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AlumnosToolStripMenuItem1.Text = "Alumnos"
        '
        'MaestrosToolStripMenuItem
        '
        Me.MaestrosToolStripMenuItem.Name = "MaestrosToolStripMenuItem"
        Me.MaestrosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MaestrosToolStripMenuItem.Text = "Maestros"
        '
        'CiclosToolStripMenuItem
        '
        Me.CiclosToolStripMenuItem.Name = "CiclosToolStripMenuItem"
        Me.CiclosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CiclosToolStripMenuItem.Text = "Ciclos"
        '
        'msPrincipal
        '
        Me.msPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.msPrincipal.Dock = System.Windows.Forms.DockStyle.Left
        Me.msPrincipal.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatálogosToolStripMenuItem, Me.MovimientosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.msPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.msPrincipal.Name = "msPrincipal"
        Me.msPrincipal.Size = New System.Drawing.Size(232, 627)
        Me.msPrincipal.TabIndex = 2
        Me.msPrincipal.Text = "MenuStrip1"
        '
        'CatálogosToolStripMenuItem
        '
        Me.CatálogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosToolStripMenuItem2})
        Me.CatálogosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CatálogosToolStripMenuItem.Name = "CatálogosToolStripMenuItem"
        Me.CatálogosToolStripMenuItem.Size = New System.Drawing.Size(219, 43)
        Me.CatálogosToolStripMenuItem.Text = "Catálogos"
        '
        'AlumnosToolStripMenuItem2
        '
        Me.AlumnosToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroToolStripMenuItem, Me.ConsultaToolStripMenuItem})
        Me.AlumnosToolStripMenuItem2.Name = "AlumnosToolStripMenuItem2"
        Me.AlumnosToolStripMenuItem2.Size = New System.Drawing.Size(225, 44)
        Me.AlumnosToolStripMenuItem2.Text = "Alumnos"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(230, 44)
        Me.RegistroToolStripMenuItem.Text = "Registro"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KardexToolStripMenuItem, Me.ConsultaIndividualToolStripMenuItem})
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(230, 44)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'KardexToolStripMenuItem
        '
        Me.KardexToolStripMenuItem.Name = "KardexToolStripMenuItem"
        Me.KardexToolStripMenuItem.Size = New System.Drawing.Size(390, 44)
        Me.KardexToolStripMenuItem.Text = "Kardex"
        '
        'ConsultaIndividualToolStripMenuItem
        '
        Me.ConsultaIndividualToolStripMenuItem.Name = "ConsultaIndividualToolStripMenuItem"
        Me.ConsultaIndividualToolStripMenuItem.Size = New System.Drawing.Size(390, 44)
        Me.ConsultaIndividualToolStripMenuItem.Text = "Consulta individual"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalificacionesToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(219, 43)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'CalificacionesToolStripMenuItem
        '
        Me.CalificacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarCalificaciònToolStripMenuItem, Me.ConsultarCalifcacionPorAlumnoToolStripMenuItem})
        Me.CalificacionesToolStripMenuItem.Name = "CalificacionesToolStripMenuItem"
        Me.CalificacionesToolStripMenuItem.Size = New System.Drawing.Size(317, 44)
        Me.CalificacionesToolStripMenuItem.Text = "Calificaciones"
        '
        'ActualizarCalificaciònToolStripMenuItem
        '
        Me.ActualizarCalificaciònToolStripMenuItem.Name = "ActualizarCalificaciònToolStripMenuItem"
        Me.ActualizarCalificaciònToolStripMenuItem.Size = New System.Drawing.Size(616, 44)
        Me.ActualizarCalificaciònToolStripMenuItem.Text = "Actualizar calificaciòn"
        '
        'ConsultarCalifcacionPorAlumnoToolStripMenuItem
        '
        Me.ConsultarCalifcacionPorAlumnoToolStripMenuItem.Name = "ConsultarCalifcacionPorAlumnoToolStripMenuItem"
        Me.ConsultarCalifcacionPorAlumnoToolStripMenuItem.Size = New System.Drawing.Size(616, 44)
        Me.ConsultarCalifcacionPorAlumnoToolStripMenuItem.Text = "Consultar califcacion por alumno"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(219, 43)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(404, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(572, 454)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1099, 627)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.msPrincipal)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.msPrincipal
        Me.Name = "principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "principal"
        Me.msPrincipal.ResumeLayout(False)
        Me.msPrincipal.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlumnosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MaestrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CiclosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents msPrincipal As MenuStrip
    Friend WithEvents CatálogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlumnosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents KardexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaIndividualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalificacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarCalificaciònToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarCalifcacionPorAlumnoToolStripMenuItem As ToolStripMenuItem
End Class
