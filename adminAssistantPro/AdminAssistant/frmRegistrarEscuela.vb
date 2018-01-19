Public Class frmRegistrarEscuela
    Private Sub frmRegistrarEscuela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Open()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        comandoGeneral.CommandText = "Select count(idEscuela) from Escuela"
        Dim cant As Integer = comandoGeneral.ExecuteScalar + 1

        'desbloqueo de botones
        btnNuevo.Enabled = False
        btnAceptar.Enabled = True
        btnCancelar.Enabled = True
        btnSalir.Enabled = False

        txtNombre.Focus()
        txtNombre.Enabled = True
        txtIdEscuela.Text = cant
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If String.IsNullOrEmpty(txtNombre.Text) Then
            MessageBox.Show("FAVOR DE INGRESAR NOMBRE DE ESCUELA", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNombre.Focus()

        Else
            txtNombre.Enabled = False
            comandoGeneral.CommandText = "INSERT INTO Escuela VALUES( " & CInt(txtIdEscuela.Text) & ", '" & txtNombre.Text & "')"
            comandoGeneral.ExecuteNonQuery()
            MessageBox.Show("¡Datos guardados exitosamente!", "Registro de escuela", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtNombre.Text = ""
            txtIdEscuela.Text = ""

            'desbloqueo de botones
            btnNuevo.Enabled = True
            btnAceptar.Enabled = False
            btnCancelar.Enabled = False
            btnSalir.Enabled = True
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'desbloqueo de botones
        btnNuevo.Enabled = True
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
        btnSalir.Enabled = True

        txtNombre.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Conexion.Close()
        Me.Dispose()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub txtIdEscuela_TextChanged(sender As Object, e As EventArgs) Handles txtIdEscuela.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class