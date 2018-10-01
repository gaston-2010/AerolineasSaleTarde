﻿Public Class CONEXION_BD

    Dim conexion As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim _cadena_conexion As String = "Provider=SQLNCLI11;Data Source=PCESCRITORIO\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Aerolineas"
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
        Dim cmd1 As New OleDb.OleDbDataAdapter(sql, conexion.ConnectionString)

        cmd1.Fill(tabla)
        'tabla.Load(cmd1.ExecuteReader())
        cerrar()
        Return tabla
    End Function
End Class