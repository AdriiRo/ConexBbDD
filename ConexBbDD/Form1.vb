Imports System.Data.SQLite
Imports System.Data.OleDb

Public Class Form1

    'Conexión con base de datos SQLite'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Conexiones.conexionSQLite()

    End Sub

    'Conexión con base de datos Access'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Conexiones.conexionAccess()
    End Sub
End Class
