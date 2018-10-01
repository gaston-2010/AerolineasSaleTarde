Public Class Destino
    Public Property id_localidad As Integer
    Public Property id As Integer

    Dim BD As New CONEXION_BD

    Enum estado_validar
        encontrado
        no_encontrado
    End Enum

    Public Function validar() As estado_validar
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = "SELECT * FROM Destinos "
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
        sql = "INSERT INTO Destinos"
        sql &= "(id_localidad) VALUES ( " & _id_localidad & " )"
        Me.BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = ""
        sql = "UPDATE Destinos"
        sql &= " SET id_localidad=" & _id_localidad & ""
        sql &= " WHERE id=" & _id
        Me.BD.INS_MOD_BOR(sql)

    End Sub

    Public Sub transferir(ByRef controles As Object)
        For Each obj In controles.Controls
            If obj.Name = "cmb_Localidad" Then
                _id_localidad = obj.selectedValue
            End If
        Next
    End Sub


    Public Sub borrar()

        Dim sql As String = ""
        sql = " DELETE FROM Destinos"
        sql &= " WHERE id=" & _id
        Me.BD.INS_MOD_BOR(sql)
    End Sub

End Class
