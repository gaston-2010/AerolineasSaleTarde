Public Class Avion


    Enum estado_validar
        encontrado
        no_encontrado
    End Enum

    Dim BD As New CONEXION_BD
    Public Property id As Integer
    Public Property nombre As String
    Public Property id_TipoAvion As String


    Public Function validar() As estado_validar
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = "SELECT * FROM Aviones "
        sql &= " WHERE id = '" & _id & "'"

        tabla = Me.BD.leo_tabla(sql)
        If tabla.Rows.Count() = 0 Then
            Return estado_validar.no_encontrado
        Else
            Return estado_validar.encontrado
        End If
    End Function


    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO Aviones"
        sql &= "(nombre, idTipoAvion) VALUES ('" & _nombre & "' ," & _id_TipoAvion & ")"
        Me.BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = ""
        sql = "UPDATE Aviones"
        sql &= " SET nombre='" & _nombre & "'"
        sql &= ", idTipoAvion=" & _id_TipoAvion
        sql &= " WHERE id=" & _id
        Me.BD.INS_MOD_BOR(sql)

    End Sub

    Public Sub borrar()

        Dim sql As String = ""
        sql = " DELETE FROM Aviones"
        sql &= " WHERE id=" & _id
        Me.BD.INS_MOD_BOR(sql)
    End Sub



End Class
