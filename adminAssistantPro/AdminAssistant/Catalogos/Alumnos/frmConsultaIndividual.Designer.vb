<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaIndividual
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBuscarAlumno = New System.Windows.Forms.TextBox()
        Me.cboAlumno = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtControlExterno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTelEmergencia = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ptbFoto = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEscuela = New System.Windows.Forms.TextBox()
        CType(Me.ptbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(26, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 24)
        Me.Label12.TabIndex = 108
        Me.Label12.Text = "Nombre"
        '
        'txtBuscarAlumno
        '
        Me.txtBuscarAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarAlumno.Location = New System.Drawing.Point(224, 105)
        Me.txtBuscarAlumno.MaxLength = 40
        Me.txtBuscarAlumno.Multiline = True
        Me.txtBuscarAlumno.Name = "txtBuscarAlumno"
        Me.txtBuscarAlumno.Size = New System.Drawing.Size(520, 25)
        Me.txtBuscarAlumno.TabIndex = 107
        '
        'cboAlumno
        '
        Me.cboAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlumno.FormattingEnabled = True
        Me.cboAlumno.Location = New System.Drawing.Point(224, 160)
        Me.cboAlumno.Name = "cboAlumno"
        Me.cboAlumno.Size = New System.Drawing.Size(520, 26)
        Me.cboAlumno.TabIndex = 106
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(224, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 24)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "Sel. alumno"
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBuscar.Location = New System.Drawing.Point(760, 105)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(111, 26)
        Me.btnBuscar.TabIndex = 104
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtControlExterno
        '
        Me.txtControlExterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtControlExterno.Location = New System.Drawing.Point(639, 377)
        Me.txtControlExterno.Multiline = True
        Me.txtControlExterno.Name = "txtControlExterno"
        Me.txtControlExterno.ReadOnly = True
        Me.txtControlExterno.Size = New System.Drawing.Size(232, 34)
        Me.txtControlExterno.TabIndex = 102
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(642, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 24)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "No. control institucional"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 423)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 24)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Escuela"
        '
        'txtTel
        '
        Me.txtTel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTel.Location = New System.Drawing.Point(673, 225)
        Me.txtTel.Multiline = True
        Me.txtTel.Name = "txtTel"
        Me.txtTel.ReadOnly = True
        Me.txtTel.Size = New System.Drawing.Size(203, 34)
        Me.txtTel.TabIndex = 83
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(563, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 24)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "Teléfono"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAceptar.Location = New System.Drawing.Point(26, 514)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(865, 50)
        Me.btnAceptar.TabIndex = 90
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'txtCiudad
        '
        Me.txtCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtCiudad.Location = New System.Drawing.Point(287, 377)
        Me.txtCiudad.Multiline = True
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.ReadOnly = True
        Me.txtCiudad.Size = New System.Drawing.Size(318, 34)
        Me.txtCiudad.TabIndex = 86
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(287, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 24)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Ciudad"
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtCorreo.Location = New System.Drawing.Point(563, 298)
        Me.txtCorreo.Multiline = True
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.ReadOnly = True
        Me.txtCorreo.Size = New System.Drawing.Size(313, 34)
        Me.txtCorreo.TabIndex = 87
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(563, 271)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 24)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "Correo"
        '
        'txtTelEmergencia
        '
        Me.txtTelEmergencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtTelEmergencia.Location = New System.Drawing.Point(26, 377)
        Me.txtTelEmergencia.Multiline = True
        Me.txtTelEmergencia.Name = "txtTelEmergencia"
        Me.txtTelEmergencia.ReadOnly = True
        Me.txtTelEmergencia.Size = New System.Drawing.Size(240, 34)
        Me.txtTelEmergencia.TabIndex = 85
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 350)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(240, 24)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Teléfono de emergencia"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtDomicilio.Location = New System.Drawing.Point(26, 298)
        Me.txtDomicilio.Multiline = True
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.ReadOnly = True
        Me.txtDomicilio.Size = New System.Drawing.Size(520, 34)
        Me.txtDomicilio.TabIndex = 80
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 24)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Domicilio"
        '
        'ptbFoto
        '
        Me.ptbFoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbFoto.Location = New System.Drawing.Point(30, 12)
        Me.ptbFoto.Name = "ptbFoto"
        Me.ptbFoto.Size = New System.Drawing.Size(156, 168)
        Me.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbFoto.TabIndex = 89
        Me.ptbFoto.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(224, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 24)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Ingresar nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(26, 225)
        Me.txtNombre.MaxLength = 40
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(520, 34)
        Me.txtNombre.TabIndex = 78
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(483, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 56)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Individual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(246, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 58)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Consulta"
        '
        'txtEscuela
        '
        Me.txtEscuela.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtEscuela.Location = New System.Drawing.Point(26, 450)
        Me.txtEscuela.Multiline = True
        Me.txtEscuela.Name = "txtEscuela"
        Me.txtEscuela.ReadOnly = True
        Me.txtEscuela.Size = New System.Drawing.Size(579, 34)
        Me.txtEscuela.TabIndex = 110
        '
        'frmConsultaIndividual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 581)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtEscuela)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtBuscarAlumno)
        Me.Controls.Add(Me.cboAlumno)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtControlExterno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTelEmergencia)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ptbFoto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmConsultaIndividual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta individual"
        CType(Me.ptbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents txtBuscarAlumno As TextBox
    Friend WithEvents cboAlumno As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtControlExterno As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTelEmergencia As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ptbFoto As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEscuela As TextBox
End Class
