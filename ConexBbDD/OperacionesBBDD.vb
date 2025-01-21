Imports System.Data.OleDb

Module OperacionesBBDD

    Public ConexionNueva As OleDbConnection

    Public CadenaInsertarReg As String = "insert into peliculas values (@Nr, )"
    Public AdaptadorDatos As OleDbDataAdapter

    Public Sub AgregarConDataAdpater()

        Dim Comando As OleDbCommand
        Comando = New OleDbCommand(CadenaInsertarReg, ConexionNueva)
        Adaptadordatos.InsertCommand = Comando

        Comando.Parameters.AddWithValue("@Nom", AgregarBBDD.TBNombre.Text)
        Comando.Parameters.AddWithValue("@Dir", AgregarBBDD.TBDirector.Text)

    End Sub


End Module
