Public Class frmConsultaEscuelas
    Private Sub frmConsultaEscuelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgEscuelas.Rows.Clear()
        Try
            Conexion.Open()
            comandoGeneral.CommandText = "SELECT idEscuela, nombre FROM Escuela"
            lectorGeneral = comandoGeneral.ExecuteReader
            While lectorGeneral.Read
                dgEscuelas.Rows.Add(lectorGeneral(0), lectorGeneral(1))
            End While
            lectorGeneral.Close()

        Catch ex As Exception
            Conexion.Close()
            MessageBox.Show("ERROR AL INTENTAR ACCEDER A LA BASE DE DATOS", "ERROR DE CONEXIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Conexion.Close()
        Me.Dispose()
    End Sub
End Class