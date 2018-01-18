<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarAlumno
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
        Me.txtControlExterno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboEscuela = New System.Windows.Forms.ComboBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscarF = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTelEmergencia = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboAlumno = New System.Windows.Forms.ComboBox()
        Me.txtBuscarAlumno = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ptbFoto = New System.Windows.Forms.PictureBox()
        CType(Me.ptbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtControlExterno
        '
        Me.txtControlExterno.Enabled = False
        Me.txtControlExterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtControlExterno.Location = New System.Drawing.Point(667, 484)
        Me.txtControlExterno.MaxLength = 20
        Me.txtControlExterno.Multiline = True
        Me.txtControlExterno.Name = "txtControlExterno"
        Me.txtControlExterno.Size = New System.Drawing.Size(232, 34)
        Me.txtControlExterno.TabIndex = 71
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(670, 454)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 24)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "No. control institucional"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(341, 465)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 24)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Escuela"
        '
        'cboEscuela
        '
        Me.cboEscuela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEscuela.Enabled = False
        Me.cboEscuela.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEscuela.FormattingEnabled = True
        Me.cboEscuela.Location = New System.Drawing.Point(341, 489)
        Me.cboEscuela.Name = "cboEscuela"
        Me.cboEscuela.Size = New System.Drawing.Size(316, 26)
        Me.cboEscuela.TabIndex = 57
        '
        'txtTel
        '
        Me.txtTel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTel.Enabled = False
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(27, 404)
        Me.txtTel.MaxLength = 15
        Me.txtTel.Multiline = True
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(250, 34)
        Me.txtTel.TabIndex = 52
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 377)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 24)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Teléfono"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNuevo.Location = New System.Drawing.Point(27, 535)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(171, 50)
        Me.btnNuevo.TabIndex = 59
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'txtCiudad
        '
        Me.txtCiudad.Enabled = False
        Me.txtCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiudad.Location = New System.Drawing.Point(581, 404)
        Me.txtCiudad.MaxLength = 45
        Me.txtCiudad.Multiline = True
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(318, 34)
        Me.txtCiudad.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(581, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 24)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Ciudad"
        '
        'btnBuscarF
        '
        Me.btnBuscarF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarF.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBuscarF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarF.Enabled = False
        Me.btnBuscarF.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnBuscarF.FlatAppearance.BorderSize = 0
        Me.btnBuscarF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarF.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBuscarF.Location = New System.Drawing.Point(699, 320)
        Me.btnBuscarF.Name = "btnBuscarF"
        Me.btnBuscarF.Size = New System.Drawing.Size(204, 34)
        Me.btnBuscarF.TabIndex = 50
        Me.btnBuscarF.Text = "Buscar foto"
        Me.btnBuscarF.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSalir.Location = New System.Drawing.Point(728, 535)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(171, 50)
        Me.btnSalir.TabIndex = 63
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAceptar.Location = New System.Drawing.Point(261, 535)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(171, 50)
        Me.btnAceptar.TabIndex = 61
        Me.btnAceptar.Text = "Guardar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'txtCorreo
        '
        Me.txtCorreo.Enabled = False
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(27, 484)
        Me.txtCorreo.MaxLength = 45
        Me.txtCorreo.Multiline = True
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(286, 34)
        Me.txtCorreo.TabIndex = 56
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 457)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 24)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Correo"
        '
        'txtTelEmergencia
        '
        Me.txtTelEmergencia.Enabled = False
        Me.txtTelEmergencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelEmergencia.Location = New System.Drawing.Point(303, 404)
        Me.txtTelEmergencia.MaxLength = 15
        Me.txtTelEmergencia.Multiline = True
        Me.txtTelEmergencia.Name = "txtTelEmergencia"
        Me.txtTelEmergencia.Size = New System.Drawing.Size(258, 34)
        Me.txtTelEmergencia.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(303, 377)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(240, 24)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Teléfono de emergencia"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Enabled = False
        Me.txtDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.Location = New System.Drawing.Point(27, 320)
        Me.txtDomicilio.MaxLength = 45
        Me.txtDomicilio.Multiline = True
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(641, 34)
        Me.txtDomicilio.TabIndex = 49
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelar.Location = New System.Drawing.Point(501, 535)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(171, 50)
        Me.btnCancelar.TabIndex = 62
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 24)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Domicilio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 24)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Ingresar nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(27, 247)
        Me.txtNombre.MaxLength = 40
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(520, 34)
        Me.txtNombre.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(434, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 56)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Alumno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(287, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 58)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Editar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBuscar.Location = New System.Drawing.Point(565, 115)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(111, 34)
        Me.btnBuscar.TabIndex = 73
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(27, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 24)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Sel. alumno"
        '
        'cboAlumno
        '
        Me.cboAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlumno.Enabled = False
        Me.cboAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlumno.FormattingEnabled = True
        Me.cboAlumno.Location = New System.Drawing.Point(27, 180)
        Me.cboAlumno.Name = "cboAlumno"
        Me.cboAlumno.Size = New System.Drawing.Size(520, 26)
        Me.cboAlumno.TabIndex = 75
        '
        'txtBuscarAlumno
        '
        Me.txtBuscarAlumno.Enabled = False
        Me.txtBuscarAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarAlumno.Location = New System.Drawing.Point(27, 115)
        Me.txtBuscarAlumno.MaxLength = 40
        Me.txtBuscarAlumno.Multiline = True
        Me.txtBuscarAlumno.Name = "txtBuscarAlumno"
        Me.txtBuscarAlumno.Size = New System.Drawing.Size(520, 34)
        Me.txtBuscarAlumno.TabIndex = 76
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 220)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 24)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Nombre"
        '
        'ptbFoto
        '
        Me.ptbFoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbFoto.Location = New System.Drawing.Point(699, 108)
        Me.ptbFoto.Name = "ptbFoto"
        Me.ptbFoto.Size = New System.Drawing.Size(204, 197)
        Me.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbFoto.TabIndex = 58
        Me.ptbFoto.TabStop = False
        '
        'frmEditarAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtBuscarAlumno)
        Me.Controls.Add(Me.cboAlumno)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtControlExterno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboEscuela)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBuscarF)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTelEmergencia)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ptbFoto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmEditarAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar datos de alumno"
        CType(Me.ptbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtControlExterno As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboEscuela As ComboBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscarF As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTelEmergencia As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ptbFoto As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents cboAlumno As ComboBox
    Friend WithEvents txtBuscarAlumno As TextBox
    Friend WithEvents Label12 As Label
End Class
