Public Class frmConsultaIndividual
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Conexion.Close()
        Me.Dispose()
    End Sub

    Private Sub frmConsultaIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            MessageBox.Show("PROBLEMAS DE CONEXIÓN", "NO SE PUDO ACCEDER A LA BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtBuscarAlumno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarAlumno.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cboAlumno.Items.Clear()
        comandoGeneral.CommandText = "SELECT nombre FROM Alumno WHERE nombre LIKE '%" & txtBuscarAlumno.Text & "%'"
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            cboAlumno.Items.Add(lectorGeneral(0))
        End While
        lectorGeneral.Close()
    End Sub

    Private Sub cboAlumno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAlumno.SelectedIndexChanged
        comandoGeneral.CommandText = "SELECT Alumno.nombre, domicilio, ciudad, telefono, telefonoEmergencia, correo, noControl, foto, Escuela.nombre FROM Alumno INNER JOIN Escuela on Escuela.idEscuela = Alumno.idEscuela WHERE Alumno.nombre = '" & cboAlumno.Text & "'"
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            txtNombre.Text = lectorGeneral(0)
            txtDomicilio.Text = lectorGeneral(1)
            txtCiudad.Text = lectorGeneral(2)
            txtTel.Text = lectorGeneral(3)
            txtTelEmergencia.Text = lectorGeneral(4)
            txtCorreo.Text = lectorGeneral(5)
            txtControlExterno.Text = lectorGeneral(6)
            txtEscuela.Text = lectorGeneral(8)
        End While
        lectorGeneral.Close()
    End Sub
End Class