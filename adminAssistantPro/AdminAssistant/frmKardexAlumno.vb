Public Class frmKardexAlumno
    Private Sub frmKardexAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub rbId_CheckedChanged(sender As Object, e As EventArgs)
        txtNombre.Visible = True
        lblNombreID.Visible = True

        cboNombre.Visible = False

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
    End Sub

    Private Sub rbNombre_CheckedChanged(sender As Object, e As EventArgs)
        txtNombre.Visible = False
        lblNombreID.Visible = False

        cboNombre.Visible = True

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
    End Sub

    Private Sub cboIdAlumno_SelectedIndexChanged(sender As Object, e As EventArgs)
        'comandoGeneral.CommandText = "Select nombre, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, situacion from alumno inner join kardex on alumno.idAlumno = kardex.idAlumno where kardex.idAlumno = " & CInt(cboIdAlumno.Text) & ""
        'lectorGeneral = comandoGeneral.ExecuteReader
        'While lectorGeneral.Read
        '    txtNombreId.Text = lectorGeneral(0)
        '    txtNivel1.Text = lectorGeneral(1)
        '    txtNivel2.Text = lectorGeneral(2)
        '    txtNivel3.Text = lectorGeneral(3)
        '    txtNivel4.Text = lectorGeneral(4)
        '    txtNivel5.Text = lectorGeneral(5)
        '    txtNivel6.Text = lectorGeneral(6)
        '    txtNivel7.Text = lectorGeneral(7)
        '    txtNivel8.Text = lectorGeneral(8)
        '    txtNivel9.Text = lectorGeneral(9)
        '    txtNivel10.Text = lectorGeneral(10)
        '    txtNivel11.Text = lectorGeneral(11)
        '    txtNivel12.Text = lectorGeneral(12)
        'End While
        'lectorGeneral.Close()
    End Sub

    Private Sub cboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombre.SelectedIndexChanged
        comandoGeneral.CommandText = "Select n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12 FROM Alumno where nombre = '" & cboNombre.Text & "'"
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
        cboNombre.Items.Clear()
        comandoGeneral.CommandText = "SELECT nombre FROM Alumno WHERE nombre LIKE '%" & txtNombre.Text & "%'"
        lectorGeneral = comandoGeneral.ExecuteReader
        While lectorGeneral.Read
            cboNombre.Items.Add(lectorGeneral(0))
        End While
        lectorGeneral.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Conexion.Close()
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
        Me.Dispose()

    End Sub
End Class