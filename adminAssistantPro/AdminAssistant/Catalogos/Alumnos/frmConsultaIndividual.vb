Public Class frmConsultaIndividual
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub frmConsultaIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtBuscarAlumno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarAlumno.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
End Class