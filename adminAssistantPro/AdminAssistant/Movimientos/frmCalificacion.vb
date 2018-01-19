Public Class frmCalificacion

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'Desbloqueo de botones
        btnNuevo.Enabled = False
        btnSalir.Enabled = False

        btnRegistrar.Enabled = True
        btnCancelar.Enabled = True

        'Desbloqueo de txt
        txtNivel1.Enabled = True
        txtNivel2.Enabled = True
        txtNivel3.Enabled = True
        txtNivel4.Enabled = True
        txtNivel5.Enabled = True
        txtNivel6.Enabled = True
        txtNivel7.Enabled = True
        txtNivel8.Enabled = True
        txtNivel9.Enabled = True
        txtNivel10.Enabled = True
        txtNivel11.Enabled = True
        txtNivel12.Enabled = True

        'Desbloqueo de combo, boton y nombre para buscar
        cboNombre.Enabled = True
        txtNombre.Enabled = True
        btnBuscar.Enabled = True


    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        If String.IsNullOrEmpty(txtNivel1.Text) Then
            MessageBox.Show("No se ha ingresado calificacion para este nivel", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNivel1.Focus()

        Else
            If String.IsNullOrEmpty(txtNivel2.Text) Then
                MessageBox.Show("No se ha ingresado calificacion para este nivel", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtNivel2.Focus()
            Else
                If String.IsNullOrEmpty(txtNivel3.Text) Then
                    MessageBox.Show("No se ha ingresado calificacion para este nivel", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtNivel3.Focus()
                Else
                    If String.IsNullOrEmpty(txtNivel4.Text) Then
                        MessageBox.Show("No se ha ingresado calificacion para este nivel", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtNivel4.Focus()
                    Else
                        If String.IsNullOrEmpty(txtNivel5.Text) Then
                            MessageBox.Show("No se ha ingresado calificacion para este nivel", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtNivel5.Focus()
                        Else
                            If String.IsNullOrEmpty(txtNivel6.Text) Then
                                MessageBox.Show("No se ha ingresado calificacion para este nivel", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                txtNivel6.Focus()
                            Else
                                If String.IsNullOrEmpty(txtNivel7.Text) Then
                                    MessageBox.Show("No se ha ingresado calificacion para este nivel", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    txtNivel7.Focus()
                                Else
                                    If String.IsNullOrEmpty(txtNivel8.Text) Then
                                        MessageBox.Show("No se ha ingresado calificacion para este nivel", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                        txtNivel8.Focus()
                                    Else
                                        If String.IsNullOrEmpty(txtNivel9.Text) Then
                                            MessageBox.Show("No se ha ingresado calificacion para este nivel", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                            txtNivel9.Focus()
                                        Else
                                            If String.IsNullOrEmpty(txtNivel10.Text) Then
                                                MessageBox.Show("No se ha ingresado calificacion para este nivel", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                                txtNivel10.Focus()
                                            Else
                                                If String.IsNullOrEmpty(txtNivel11.Text) Then
                                                    MessageBox.Show("No se ha ingresado calificacion para este nivel", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                                    txtNivel11.Focus()
                                                Else
                                                    If String.IsNullOrEmpty(txtNivel12.Text) Then
                                                        MessageBox.Show("No se ha ingresado calificacion para este nivel", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                                        txtNivel12.Focus()
                                                    Else
                                                        comandoGeneral.CommandText = "UPDATE Alumno SET n1 = " & txtNivel1.Text & ", n2 = " & txtNivel2.Text & ", n3 = " & txtNivel3.Text & ", n4 = " & txtNivel4.Text & ", n5 = " & txtNivel5.Text & ", n6 = " & txtNivel6.Text & ", n7 = " & txtNivel7.Text & ", n8 = " & txtNivel8.Text & ", n9 = " & txtNivel9.Text & ", n10 = " & txtNivel10.Text & ", n11 = " & txtNivel11.Text & ", n12 = " & txtNivel12.Text & " WHERE nombre = '" & cboNombre.Text & "'"
                                                        comandoGeneral.ExecuteNonQuery()

                                                        'Desbloqueo de botones
                                                        btnNuevo.Enabled = True
                                                        btnSalir.Enabled = True

                                                        btnRegistrar.Enabled = False
                                                        btnCancelar.Enabled = False

                                                        'Desbloqueo de txt
                                                        txtNivel1.Enabled = False
                                                        txtNivel2.Enabled = False
                                                        txtNivel3.Enabled = False
                                                        txtNivel4.Enabled = False
                                                        txtNivel5.Enabled = False
                                                        txtNivel6.Enabled = False
                                                        txtNivel7.Enabled = False
                                                        txtNivel8.Enabled = False
                                                        txtNivel9.Enabled = False
                                                        txtNivel10.Enabled = False
                                                        txtNivel11.Enabled = False
                                                        txtNivel12.Enabled = False

                                                        'Limpieza de txt
                                                        txtNivel1.Text = ""
                                                        txtNivel2.Text = ""
                                                        txtNivel3.Text = ""
                                                        txtNivel4.Text = ""
                                                        txtNivel5.Text = ""
                                                        txtNivel6.Text = ""
                                                        txtNivel7.Text = ""
                                                        txtNivel8.Text = ""
                                                        txtNivel9.Text = ""
                                                        txtNivel10.Text = ""
                                                        txtNivel11.Text = ""
                                                        txtNivel12.Text = ""
                                                        txtPromedio.Text = ""

                                                        'Desbloqueo de combo, boton y nombre para buscar
                                                        cboNombre.Enabled = False
                                                        txtNombre.Enabled = False
                                                        btnBuscar.Enabled = False
                                                    End If
                                                End If
                                            End If
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Desbloqueo de botones
        btnNuevo.Enabled = True
        btnSalir.Enabled = True

        btnRegistrar.Enabled = False
        btnCancelar.Enabled = False

        'Desbloqueo de txt
        txtNivel1.Enabled = False
        txtNivel2.Enabled = False
        txtNivel3.Enabled = False
        txtNivel4.Enabled = False
        txtNivel5.Enabled = False
        txtNivel6.Enabled = False
        txtNivel7.Enabled = False
        txtNivel8.Enabled = False
        txtNivel9.Enabled = False
        txtNivel10.Enabled = False
        txtNivel11.Enabled = False
        txtNivel12.Enabled = False

        'Desbloqueo de combo, boton y nombre para buscar
        cboNombre.Enabled = False
        txtNombre.Enabled = False
        btnBuscar.Enabled = False


        'Limpieza de txt
        txtNivel1.Text = ""
        txtNivel2.Text = ""
        txtNivel3.Text = ""
        txtNivel4.Text = ""
        txtNivel5.Text = ""
        txtNivel6.Text = ""
        txtNivel7.Text = ""
        txtNivel8.Text = ""
        txtNivel9.Text = ""
        txtNivel10.Text = ""
        txtNivel11.Text = ""
        txtNivel12.Text = ""
        txtPromedio.Text = ""

    End Sub

    Private Sub frmCalificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.Open()


            comandoGeneral.CommandText = "SELECT count(nombre) FROM Alumno"
            Dim cantAlumno = comandoGeneral.ExecuteScalar

            If cantAlumno > 0 Then
            Else
                Conexion.Close()
                MessageBox.Show("NO HAY ALUMNOS REGISTRADOS", "FAVOR DE VERIFICAR INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            Conexion.Close()
            MessageBox.Show("PROBLEMAS DE CONEXIÒN", "NO SE PUDO ACCEDER A LA BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNivel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNivel1.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaCalificacion, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtNivel2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNivel2.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaCalificacion, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtNivel3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNivel3.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaCalificacion, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtNivel4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNivel4.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaCalificacion, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtNivel5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNivel5.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaCalificacion, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtNivel6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNivel6.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaCalificacion, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtNivel7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNivel7.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaCalificacion, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtNivel8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNivel8.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaCalificacion, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtNivel9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNivel9.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaCalificacion, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtNivel10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNivel10.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaCalificacion, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtNivel11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNivel11.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaCalificacion, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtNivel12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNivel12.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaCalificacion, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Conexion.Close()
        Me.Dispose()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cboNombre.Items.Clear()
        comandoGeneral.CommandText = "SELECT nombre FROM Alumno WHERE nombre LIKE '%" & txtNombre.Text & "%'"
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            cboNombre.Items.Add(lectorGeneral(0))
        End While
        lectorGeneral.Close()
    End Sub

    Private Sub cboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombre.SelectedIndexChanged
        comandoGeneral.CommandText = "SELECT n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12 FROM Alumno WHERE nombre = '" & cboNombre.Text & "'"
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            txtNivel1.Text = lectorGeneral(0)
            txtNivel2.Text = lectorGeneral(1)
            txtNivel3.Text = lectorGeneral(2)
            txtNivel4.Text = lectorGeneral(3)
            txtNivel5.Text = lectorGeneral(4)
            txtNivel6.Text = lectorGeneral(5)
            txtNivel7.Text = lectorGeneral(6)
            txtNivel8.Text = lectorGeneral(7)
            txtNivel9.Text = lectorGeneral(8)
            txtNivel10.Text = lectorGeneral(9)
            txtNivel11.Text = lectorGeneral(10)
            txtNivel12.Text = lectorGeneral(11)
        End While
        lectorGeneral.Close()
        txtPromedio.Text = (CInt(txtNivel1.Text) + CInt(txtNivel2.Text) + CInt(txtNivel3.Text) + CInt(txtNivel4.Text) + CInt(txtNivel5.Text) + CInt(txtNivel6.Text) + CInt(txtNivel7.Text) + CInt(txtNivel8.Text) + CInt(txtNivel9.Text) + CInt(txtNivel10.Text) + CInt(txtNivel11.Text) + CInt(txtNivel12.Text)) / 12

    End Sub
End Class