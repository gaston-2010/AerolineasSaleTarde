Public Class Avion

    Dim BD As New BD_TRANSACCIONAL
    Public Property id As Integer
    Public Property nombre As String
    Public Property id_TipoAvion As String



    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO Aviones"
        sql &= "(nombre, idTipoAvion) VALUES ('" & _nombre & "' ," & _id_TipoAvion & ")"
        Me.BD.consultaABM(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = ""
        sql = "UPDATE Aviones"
        sql &= " SET nombre='" & _nombre & "'"
        sql &= ", idTipoAvion=" & _id_TipoAvion
        sql &= " WHERE id=" & _id
        Me.BD.consultaABM(sql)

    End Sub

    Public Sub borrar()

        Dim sql As String = ""
        sql = " DELETE FROM Aviones"
        sql &= " WHERE id=" & _id
        Me.BD.consultaABM(sql)
    End Sub



End Class
