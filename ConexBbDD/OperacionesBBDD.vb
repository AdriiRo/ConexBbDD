Imports System.Data.OleDb

Module OperacionesBBDD

    Public ConexionNueva As OleDbConnection

    Public CadenaInsertarReg As String = "insert into peliculas (Nombre, Director) values (@Nom, @Dir)"
    Public AdaptadorDatos As OleDbDataAdapter

    Public Sub AgregarConDataAdpater()

        Dim Comando As OleDbCommand = New OleDbCommand(CadenaInsertarReg, ConexionNueva)

        Comando.Parameters.AddWithValue("@Nom", AgregarBBDD.TBNombre.Text)
        Comando.Parameters.AddWithValue("@Dir", AgregarBBDD.TBDirector.Text)

        Comando.ExecuteNonQuery()

        ConexionNueva.Close()

    End Sub


End Module
