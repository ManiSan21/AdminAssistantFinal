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

    End Sub

    Private Sub frmCalificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Me.Dispose()
    End Sub
End Class