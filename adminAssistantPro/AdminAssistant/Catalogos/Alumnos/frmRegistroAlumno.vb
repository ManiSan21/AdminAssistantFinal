Imports System.Data.SqlClient
Public Class frmRegistroAlumno
    Dim ubicacion As String
    Dim contFallas As Integer
    Dim banModificar As Boolean = False
    Dim idEscuela As Integer
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Cerrando conexion
        Conexion.Close()
        Me.Close()
    End Sub

    Private Sub frmRegistroAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.Open()

            comandoGeneral.CommandText = "SELECT count(nombre) FROM Escuela"
            Dim cant = comandoGeneral.ExecuteScalar

            If cant > 0 Then

                comandoGeneral.CommandText = "SELECT count(nombre) FROM Alumno"
                Dim cantAlumno = comandoGeneral.ExecuteScalar

                If cantAlumno > 0 Then

                    comandoGeneral.CommandText = "SELECT nombre FROM Escuela"
                    lectorGeneral = comandoGeneral.ExecuteReader
                    While lectorGeneral.Read
                        cboEscuela.Items.Add(lectorGeneral(0))
                    End While
                    lectorGeneral.Close()

                Else
                    Conexion.Close()
                    MessageBox.Show("NO HAY ALUMNOS REGISTRADOS", "FAVOR DE VERIFICAR INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                Conexion.Close()
                MessageBox.Show("NO SE HAN REGISTRADO ESCUELAS", "FAVOR DE REGISTRAR ESCUELAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Conexion.Close()
            MessageBox.Show("PROBLEMAS DE CONEXIÒN", "NO SE PUDO ACCEDER A LA BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        'Validaciones
        If String.IsNullOrEmpty(txtNombre.Text) Then
            MessageBox.Show("No se ha ingresado nombre", "Error, falta de información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNombre.Focus()
        Else
            If String.IsNullOrEmpty(txtDomicilio.Text) Then
                MessageBox.Show("No se ha ingresado domicilio", "Error, falta de información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtDomicilio.Focus()
            Else
                If String.IsNullOrEmpty(txtTel.Text) Then
                    MessageBox.Show("No se ha ingresado teléfono", "Error, falta de información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtTel.Focus()
                Else
                    If String.IsNullOrEmpty(txtTelEmergencia.Text) Then
                        MessageBox.Show("No se ha ingresado teléfono de emergencia", "Error, falta de información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtTelEmergencia.Focus()
                    Else
                        If String.IsNullOrEmpty(txtCiudad.Text) Then
                            MessageBox.Show("No se ha ingresado ciudad", "Error, falta de información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtCiudad.Focus()
                        Else
                            If cboEscuela.SelectedIndex.Equals(-1) Then
                                MessageBox.Show("No se ha seleccionado escuela", "Error, falta de información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Else
                                If String.IsNullOrEmpty(txtCorreo.Text) Then
                                    MessageBox.Show("No se ha ingresado correo", "Error, falta de información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    txtCorreo.Focus()
                                Else
                                    If Me.ptbFoto.Image Is Nothing Then
                                        MessageBox.Show("No se ha ingresado foto del alumno", "Error, falta de información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    Else
                                        If String.IsNullOrEmpty(txtNoContrlI.Text) Then
                                            MessageBox.Show("No se ha ingresado número de control institucional", "Error, falta de información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                            txtNoContrlI.Focus()
                                        Else
                                            'Sección de lógica y sentancias sql
                                            comandoGeneral.CommandText = "INSERT INTO Alumno VALUES(" & CInt(txtNoControl.Text) & "," & CInt(idEscuela) & ",'" & CStr(txtNombre.Text) & "','" & CStr(txtDomicilio.Text) & "','" & CStr(txtCiudad.Text) & "','" & CStr(txtTel.Text) & "','" & CStr(txtTelEmergencia.Text) & "','" & CStr(txtCorreo.Text) & "','" & CStr(ubicacion) & "'," & 0 & "," & 0 & "," & 0 & "," & 0 & "," & 0 & "," & 0 & "," & 0 & "," & 0 & "," & 0 & "," & 0 & "," & 0 & "," & 0 & ", '" & txtNoContrlI.Text & "')"
                                            comandoGeneral.ExecuteNonQuery()
                                            MessageBox.Show("¡Datos guardados exitosamente!", "Registro de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                            'Limpieza de txt
                                            txtNoControl.Text = ""
                                            txtNombre.Text = ""
                                            txtDomicilio.Text = ""
                                            txtCiudad.Text = ""
                                            txtTel.Text = ""
                                            txtTelEmergencia.Text = ""
                                            txtCorreo.Text = ""
                                            ptbFoto.Image.Dispose()
                                            ptbFoto.Image = Nothing
                                            txtNoContrlI.Text = ""



                                            'Bloqueo de txt
                                            txtNombre.Enabled = False
                                            txtDomicilio.Enabled = False
                                            txtTel.Enabled = False
                                            txtTelEmergencia.Enabled = False
                                            txtCiudad.Enabled = False
                                            txtCorreo.Enabled = False
                                            cboEscuela.Enabled = False
                                            txtNoContrlI.Enabled = False

                                            'botones
                                            btnNuevo.Enabled = True
                                            btnAceptar.Enabled = False
                                            btnCancelar.Enabled = False
                                            btnSalir.Enabled = True
                                            btnBuscarF.Enabled = False
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'botones
        Dim n As Integer
        comandoGeneral.CommandText = "SELECT COUNT(idAlumno) FROM Alumno"
        n = comandoGeneral.ExecuteScalar + 1
        txtNoControl.Text = CStr(n)
        btnNuevo.Enabled = False
        btnAceptar.Enabled = True
        btnCancelar.Enabled = True
        btnSalir.Enabled = False
        btnBuscarF.Enabled = True

        'Desbloqueo de txt
        txtNombre.Enabled = True
        txtDomicilio.Enabled = True
        txtTel.Enabled = True
        txtTelEmergencia.Enabled = True
        txtCiudad.Enabled = True
        txtCorreo.Enabled = True
        cboEscuela.Enabled = True
        txtNoContrlI.Enabled = True

        txtNombre.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'botones
        btnNuevo.Enabled = True
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
        btnSalir.Enabled = True
        btnBuscarF.Enabled = False

        'Bloqueo de txt
        txtNombre.Enabled = False
        txtDomicilio.Enabled = False
        txtTel.Enabled = False
        txtTelEmergencia.Enabled = False
        txtCiudad.Enabled = False
        txtCorreo.Enabled = False
        cboEscuela.Enabled = False
        txtNoContrlI.Enabled = False

        'Limpieza de txt
        txtNoControl.Text = ""
        txtNombre.Text = ""
        txtDomicilio.Text = ""
        txtCiudad.Text = ""
        txtTel.Text = ""
        txtTelEmergencia.Text = ""
        txtCorreo.Text = ""
        ptbFoto.Image = Nothing

    End Sub

    Private Sub btnBuscarF_Click(sender As Object, e As EventArgs) Handles btnBuscarF.Click
        OpenFileDialog1.ShowDialog()
        Dim ruta As String
        ruta = OpenFileDialog1.FileName
        ptbFoto.Image = Image.FromFile(ruta)
        ubicacion = ruta
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtCiudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCiudad.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtDomicilio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDomicilio.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(cadenaDomicilio, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaNumero, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtTelEmergencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelEmergencia.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaNumero, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub cboEscuela_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEscuela.SelectedIndexChanged
        comandoGeneral.CommandText = "SELECT idEscuela FROM Escuela WHERE nombre = '" & CStr(cboEscuela.Text) & "'"
        lectorGeneral = comandoGeneral.ExecuteReader
        lectorGeneral.Read()
        idEscuela = lectorGeneral(0)
        lectorGeneral.Close()
    End Sub


End Class