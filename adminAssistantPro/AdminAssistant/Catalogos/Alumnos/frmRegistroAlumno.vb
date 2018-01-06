Imports System.Data.SqlClient
Public Class frmRegistroAlumno
    Dim ubicacion As String
    Dim contFallas As Integer
    Dim banModificar As Boolean = False
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Cerrando conexion

    End Sub

    Private Sub frmRegistroAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Abriendo conexion
        'Nota: Incorporar un try para la conexion

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
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
        txtControlExterno.Enabled = False

        'Validaciones
        If (IsNothing(txtNombre.Text)) Then
            MessageBox.Show("Error, falta de informaciòn", "No se ha ingresado nombre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNombre.Focus()
        Else
            If (IsNothing(txtDomicilio.Text)) Then
                MessageBox.Show("Error, falta de informaciòn", "No se ha ingresado domicilio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtDomicilio.Focus()
            Else
                If (IsNothing(txtTel.Text)) Then
                    MessageBox.Show("Error, falta de informaciòn", "No se ha ingresado teléfono", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtTel.Focus()
                Else
                    If (IsNothing(txtTelEmergencia.Text)) Then
                        MessageBox.Show("Error, falta de informaciòn", "No se ha ingresado Teléfono de emergencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtTelEmergencia.Focus()
                    Else
                        If (IsNothing(txtCiudad.Text)) Then
                            MessageBox.Show("Error, falta de informaciòn", "No se ha ingresado ciudad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtCiudad.Focus()
                        Else
                            If Not cboEscuela.SelectedValue Is Nothing Then
                                MessageBox.Show("Error, falta de informaciòn", "No se ha seleccionado escuela", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Else
                                If (IsNothing(txtControlExterno.Text)) Then
                                    MessageBox.Show("Error, falta de informaciòn", "No se ha número de control institucional", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    txtControlExterno.Focus()
                                Else
                                    If (IsNothing(txtCorreo.Text)) Then
                                        MessageBox.Show("Error, falta de informaciòn", "No se ha número de correo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                        txtCorreo.Focus()
                                    Else
                                        If Me.ptbFoto.Image Is Nothing Then
                                            MessageBox.Show("Error, falta de informaciòn", "No se ha ingresado foto de alumno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                        Else

                                            'Sección de lógica y sentancias sql








                                            'Limpieza de txt
                                            txtNoControl.Text = ""
                                            txtNombre.Text = ""
                                            txtDomicilio.Text = ""
                                            txtCiudad.Text = ""
                                            txtTel.Text = ""
                                            txtTelEmergencia.Text = ""
                                            txtCorreo.Text = ""
                                            txtControlExterno.Text = ""
                                            ptbFoto.Image.Dispose()
                                            ptbFoto.Image = Nothing


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
        txtControlExterno.Enabled = True


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
        txtControlExterno.Enabled = False


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
            If InStr(CadenaValida, e.KeyChar) = 0 Then
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

End Class