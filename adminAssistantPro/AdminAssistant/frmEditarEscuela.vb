Public Class frmEditarEscuela
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'desbloqueo de botones
        btnAceptar.Enabled = True
        btnCancelar.Enabled = True
        btnEditar.Enabled = False
        btnSalir.Enabled = False

        'desbloqueo de cajas y otras opciones
        txtBuscar.Enabled = True
        btnBuscar.Enabled = True
        cboEscuelas.Enabled = True


    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If String.IsNullOrEmpty(txtNombre.Text) Then
            MessageBox.Show("NO SE HA INGRESADO NOMBRE DE ESCUELA", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNombre.Focus()
        Else
            comandoGeneral.CommandText = "UPDATE Escuela SET nombre = '" & txtNombre.Text & "' WHERE idEscuela = " & CInt(txtIdEscuela.Text) & ""
            comandoGeneral.ExecuteNonQuery()

            'bloqueo de botones
            btnAceptar.Enabled = False
            btnCancelar.Enabled = False
            btnEditar.Enabled = True
            btnSalir.Enabled = True

            'desbloqueo de cajas y otras opciones
            txtBuscar.Enabled = False
            btnBuscar.Enabled = False
            cboEscuelas.Enabled = False

            'limpieza de txt
            txtBuscar.Text = ""
            txtNombre.Text = ""
            txtIdEscuela.Text = ""

            txtNombre.Enabled = False

            MessageBox.Show("!DATOS GUARDADOS EXITOSAMENTE¡", "ACTUALIZACIÓN COMPLETA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'bloqueo de botones
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
        btnEditar.Enabled = True
        btnSalir.Enabled = True

        'desbloqueo de cajas y otras opciones
        txtBuscar.Enabled = False
        btnBuscar.Enabled = False
        cboEscuelas.Enabled = False

        'limpieza de txt
        txtBuscar.Text = ""
        txtNombre.Text = ""
        txtIdEscuela.Text = ""

        txtNombre.Enabled = False
    End Sub

    Private Sub frmEditarEscuela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.Open()
        Catch ex As Exception
            Conexion.Close()
            MessageBox.Show("ERROR AL INTENTAR ACCEDER A LA BASE DE DATOS", "ERROR DE CONEXIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cboEscuelas.Items.Clear()
        comandoGeneral.CommandText = "SELECT nombre FROM Escuela WHERE nombre LIKE '%" & txtBuscar.Text & "%'"
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            cboEscuelas.Items.Add(lectorGeneral(0))
        End While
        lectorGeneral.Close()
    End Sub

    Private Sub cboEscuelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEscuelas.SelectedIndexChanged
        comandoGeneral.CommandText = "SELECT idEscuela, nombre FROM Escuela WHERE nombre = '" & cboEscuelas.Text & "'"
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            txtIdEscuela.Text = lectorGeneral(0)
            txtNombre.Text = lectorGeneral(1)
        End While
        lectorGeneral.Close()
        txtNombre.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Conexion.Close()
        Me.Dispose()
    End Sub
End Class