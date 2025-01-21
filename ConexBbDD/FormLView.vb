Public Class FormLView
    '::: Método para cargar datos en el ListView
    Public Sub LoadDataToListView(reader As IDataReader)
        '::: Limpia columnas y filas previas
        ListView1.Clear()

        '::: Agrega las columnas al ListView (basado en los nombres de las columnas del reader)
        For i As Integer = 0 To reader.FieldCount - 1
            ListView1.Columns.Add(reader.GetName(i), 150) ' Ajusta el ancho si es necesario
        Next

        '::: Carga los datos fila por fila
        While reader.Read()
            Dim items As New List(Of String)
            For i As Integer = 0 To reader.FieldCount - 1
                items.Add(reader(i).ToString())
            Next
            ListView1.Items.Add(New ListViewItem(items.ToArray()))
        End While

        '::: Ajusta el tamaño de las columnas para que se adapten al contenido
        For Each column As ColumnHeader In ListView1.Columns
            column.Width = -2
        Next
    End Sub

    Private Sub btnIrAgregar_Click(sender As Object, e As EventArgs) Handles btnIrAgregar.Click
        Me.Hide()
        AgregarBBDD.Show()

    End Sub
End Class
