﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalificacion
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboNombre = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNivel1 = New System.Windows.Forms.TextBox()
        Me.txtNivel3 = New System.Windows.Forms.TextBox()
        Me.txtNivel5 = New System.Windows.Forms.TextBox()
        Me.txtNivel2 = New System.Windows.Forms.TextBox()
        Me.txtNivel4 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNivel6 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNivel7 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNivel9 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNivel11 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNivel8 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNivel10 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNivel12 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNombreID = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(186, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 16)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Sel. Alumno"
        Me.Label14.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.Location = New System.Drawing.Point(612, 95)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 22)
        Me.btnBuscar.TabIndex = 60
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(179, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(517, 55)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Actualizar  calificación"
        '
        'cboNombre
        '
        Me.cboNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNombre.Enabled = False
        Me.cboNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboNombre.FormattingEnabled = True
        Me.cboNombre.Location = New System.Drawing.Point(279, 143)
        Me.cboNombre.Name = "cboNombre"
        Me.cboNombre.Size = New System.Drawing.Size(291, 21)
        Me.cboNombre.TabIndex = 57
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNivel1)
        Me.GroupBox1.Controls.Add(Me.txtNivel3)
        Me.GroupBox1.Controls.Add(Me.txtNivel5)
        Me.GroupBox1.Controls.Add(Me.txtNivel2)
        Me.GroupBox1.Controls.Add(Me.txtNivel4)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtNivel6)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtNivel7)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtNivel9)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtNivel11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNivel8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNivel10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNivel12)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(744, 160)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calificaciones en Kardex"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nivel 1"
        '
        'txtNivel1
        '
        Me.txtNivel1.Enabled = False
        Me.txtNivel1.Location = New System.Drawing.Point(72, 19)
        Me.txtNivel1.MaxLength = 3
        Me.txtNivel1.Name = "txtNivel1"
        Me.txtNivel1.Size = New System.Drawing.Size(95, 20)
        Me.txtNivel1.TabIndex = 3
        '
        'txtNivel3
        '
        Me.txtNivel3.Enabled = False
        Me.txtNivel3.Location = New System.Drawing.Point(464, 19)
        Me.txtNivel3.MaxLength = 3
        Me.txtNivel3.Name = "txtNivel3"
        Me.txtNivel3.Size = New System.Drawing.Size(95, 20)
        Me.txtNivel3.TabIndex = 4
        '
        'txtNivel5
        '
        Me.txtNivel5.Enabled = False
        Me.txtNivel5.Location = New System.Drawing.Point(72, 58)
        Me.txtNivel5.MaxLength = 3
        Me.txtNivel5.Name = "txtNivel5"
        Me.txtNivel5.Size = New System.Drawing.Size(95, 20)
        Me.txtNivel5.TabIndex = 17
        '
        'txtNivel2
        '
        Me.txtNivel2.Enabled = False
        Me.txtNivel2.Location = New System.Drawing.Point(271, 19)
        Me.txtNivel2.MaxLength = 3
        Me.txtNivel2.Name = "txtNivel2"
        Me.txtNivel2.Size = New System.Drawing.Size(95, 20)
        Me.txtNivel2.TabIndex = 18
        '
        'txtNivel4
        '
        Me.txtNivel4.Enabled = False
        Me.txtNivel4.Location = New System.Drawing.Point(643, 19)
        Me.txtNivel4.MaxLength = 3
        Me.txtNivel4.Name = "txtNivel4"
        Me.txtNivel4.Size = New System.Drawing.Size(95, 20)
        Me.txtNivel4.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(581, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Nivel 12"
        '
        'txtNivel6
        '
        Me.txtNivel6.Enabled = False
        Me.txtNivel6.Location = New System.Drawing.Point(271, 58)
        Me.txtNivel6.MaxLength = 3
        Me.txtNivel6.Name = "txtNivel6"
        Me.txtNivel6.Size = New System.Drawing.Size(95, 20)
        Me.txtNivel6.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(396, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 16)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Nivel 11"
        '
        'txtNivel7
        '
        Me.txtNivel7.Enabled = False
        Me.txtNivel7.Location = New System.Drawing.Point(464, 58)
        Me.txtNivel7.MaxLength = 3
        Me.txtNivel7.Name = "txtNivel7"
        Me.txtNivel7.Size = New System.Drawing.Size(95, 20)
        Me.txtNivel7.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(200, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Nivel 10"
        '
        'txtNivel9
        '
        Me.txtNivel9.Enabled = False
        Me.txtNivel9.Location = New System.Drawing.Point(72, 101)
        Me.txtNivel9.MaxLength = 3
        Me.txtNivel9.Name = "txtNivel9"
        Me.txtNivel9.Size = New System.Drawing.Size(95, 20)
        Me.txtNivel9.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Nivel 9"
        '
        'txtNivel11
        '
        Me.txtNivel11.Enabled = False
        Me.txtNivel11.Location = New System.Drawing.Point(464, 101)
        Me.txtNivel11.MaxLength = 3
        Me.txtNivel11.Name = "txtNivel11"
        Me.txtNivel11.Size = New System.Drawing.Size(95, 20)
        Me.txtNivel11.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(581, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Nivel 8"
        '
        'txtNivel8
        '
        Me.txtNivel8.Enabled = False
        Me.txtNivel8.Location = New System.Drawing.Point(643, 58)
        Me.txtNivel8.MaxLength = 3
        Me.txtNivel8.Name = "txtNivel8"
        Me.txtNivel8.Size = New System.Drawing.Size(95, 20)
        Me.txtNivel8.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(396, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Nivel 7"
        '
        'txtNivel10
        '
        Me.txtNivel10.Enabled = False
        Me.txtNivel10.Location = New System.Drawing.Point(271, 101)
        Me.txtNivel10.MaxLength = 3
        Me.txtNivel10.Name = "txtNivel10"
        Me.txtNivel10.Size = New System.Drawing.Size(95, 20)
        Me.txtNivel10.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(200, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Nivel 6"
        '
        'txtNivel12
        '
        Me.txtNivel12.Enabled = False
        Me.txtNivel12.Location = New System.Drawing.Point(643, 101)
        Me.txtNivel12.MaxLength = 3
        Me.txtNivel12.Name = "txtNivel12"
        Me.txtNivel12.Size = New System.Drawing.Size(95, 20)
        Me.txtNivel12.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Nivel 5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nivel 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(581, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Nivel 4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(396, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Nivel 3"
        '
        'lblNombreID
        '
        Me.lblNombreID.AutoSize = True
        Me.lblNombreID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreID.Location = New System.Drawing.Point(186, 101)
        Me.lblNombreID.Name = "lblNombreID"
        Me.lblNombreID.Size = New System.Drawing.Size(87, 16)
        Me.lblNombreID.TabIndex = 55
        Me.lblNombreID.Text = "Ing. nombre"
        Me.lblNombreID.Visible = False
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(279, 97)
        Me.txtNombre.MaxLength = 45
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(291, 26)
        Me.txtNombre.TabIndex = 54
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AdminAssistant.My.Resources.Resources.evaluation
        Me.PictureBox1.Location = New System.Drawing.Point(12, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(12, 365)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(154, 39)
        Me.btnNuevo.TabIndex = 53
        Me.btnNuevo.Text = "Nueva act."
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(431, 365)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(154, 39)
        Me.btnCancelar.TabIndex = 62
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(602, 365)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(154, 39)
        Me.btnSalir.TabIndex = 63
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Enabled = False
        Me.btnRegistrar.Location = New System.Drawing.Point(198, 365)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(154, 39)
        Me.btnRegistrar.TabIndex = 64
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'frmCalificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 423)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cboNombre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblNombreID)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnNuevo)
        Me.Name = "frmCalificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registro/actualización de calificaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label14 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboNombre As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNivel1 As TextBox
    Friend WithEvents txtNivel3 As TextBox
    Friend WithEvents txtNivel5 As TextBox
    Friend WithEvents txtNivel2 As TextBox
    Friend WithEvents txtNivel4 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNivel6 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNivel7 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNivel9 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNivel11 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNivel8 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNivel10 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNivel12 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNombreID As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnRegistrar As Button
End Class
