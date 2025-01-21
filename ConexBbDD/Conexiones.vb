Imports System.Data.OleDb
Imports System.Data.SQLite

Module Conexiones
    Public Sub conexionSQLite()
        '::: Ruta y conexión a SQLite
        Dim con As New SQLiteConnection("Data Source=C:\Users\adria\Desktop\videoclub.db; Version=3")
        Dim query As String = "SELECT * FROM peliculas" ' Reemplaza con el nombre de tu tabla.

        '::: Intentamos abrir conexión y cargar datos
        Try
            con.Open()
            Dim cmd As New SQLiteCommand(query, con)
            Dim reader As SQLiteDataReader = cmd.ExecuteReader()

            '::: Mostramos los datos en el ListView
            Dim formView As New FormLView
            formView.LoadDataToListView(reader) ' Llama a la función en FormLView
            formView.Show()

            con.Close()
        Catch ex As Exception
            MsgBox("Error al conectar o cargar datos: " & ex.Message)
        End Try
    End Sub

    Public Sub conexionAccess()
        '::: Ruta y conexión a Access
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=C:\Users\adria\Desktop\basedatospruebas.mdb")
        Dim query As String = "SELECT * FROM Tabla1" ' Reemplaza con el nombre de tu tabla.

        '::: Intentamos abrir conexión y cargar datos
        Try
            con.Open()
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            '::: Mostramos los datos en el ListView
            Dim formView As New FormLView
            formView.LoadDataToListView(reader) ' Llama a la función en FormLView
            formView.Show()

            con.Close()
        Catch ex As Exception
            MsgBox("Error al conectar o cargar datos: " & ex.Message)
        End Try
    End Sub
End Module
