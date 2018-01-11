﻿Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class principal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub



    Private Sub RegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                Dim ban As Boolean = False
                comandoMasterServidor.CommandText = "SELECT name FROM sys.databases WHERE name = 'MasterEA'"
                lectorMasterServidor = comandoMasterServidor.ExecuteReader
                lectorMasterServidor.Read()
                If lectorMasterServidor(0) = "MasterEA" Then
                    ban = True
                End If
                lectorMasterServidor.Close()
                If ban Then
                    conexionMasterServidor.Close()
                    frmRegistroAlumno.Show()
                Else
                    conexionMasterServidor.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        Try
            conexionMasterServidor.Open()
            Try
                comandoMasterServidor.CommandText = "SELECT name FROM sys.databases WHERE name = 'MasterEA'"
                lectorMasterServidor = comandoMasterServidor.ExecuteReader
                lectorMasterServidor.Read()
                If lectorMasterServidor(0) = "MasterEA" Then
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                    frmConsultaAlumnos.Show()
                Else
                    lectorMasterServidor.Close()
                    conexionMasterServidor.Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub principal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            'System.Diagnostics.Process.Start("C:\Users\Diego\Documents\GitHub\adminAssistantPro\Help.chm")
            System.Diagnostics.Process.Start("C:\Users\Mani\Documents\GitHub\AdminAssistantProEdit\adminAssistantPro\Ayuda.chm")
        End If
    End Sub

    Private Sub ConsultaIndividualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaIndividualToolStripMenuItem.Click
        frmConsultaIndividual.ShowDialog()
    End Sub
End Class