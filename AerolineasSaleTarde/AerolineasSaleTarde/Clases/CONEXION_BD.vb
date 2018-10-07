Public Class CONEXION_BD

    Dim conexion As New SqlClient.SqlConnection
    Dim cmd As New SqlClient.SqlCommand

    Dim _cadena_conexion As String = "Data Source=PCESCRITORIO\SQLEXPRESS;Initial Catalog=Aerolineas;Integrated Security=True"
    'Public Property cadena_conexion As String
    Private Sub conectar()
        conexion.ConnectionString = _cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
    End Sub
    Private Sub cerrar()
        conexion.Close()
    End Sub
    Public Sub INS_MOD_BOR(ByVal comando As String)
        Me.conectar()
        cmd.CommandText = comando
        cmd.ExecuteNonQuery()
        cerrar()
    End Sub
    Public Function leo_tabla(ByVal sql As String) As DataTable
        Me.conectar()
        cmd.CommandText = sql
        Dim tabla As New DataTable
        tabla.Load(cmd.ExecuteReader())
        cerrar()
        Return tabla
    End Function
End Class
