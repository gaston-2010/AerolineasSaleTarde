Public Class PersonalxVuelo
    Public Property legajo As Integer
    Public Property id_vuelo As Integer
    Public Property id_puesto As Integer

    Dim BD As New CONEXION_BD
    Public Sub insertar()
        Dim sql As String = "INSERT INTO [dbo].[PersonalxVuelo]
           ([legajo]
           ,[id_vuelo]
           ,[id_puesto])
     VALUES
           (" & _legajo & "
           ," & _id_vuelo & "
           ," & _id_puesto & ")"
        BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = "UPDATE [dbo].[PersonalxVuelo]
   SET [id_puesto] = " & _id_puesto & "WHERE legajo= " & _legajo & "AND id_vuelo= " & _id_vuelo
        BD.INS_MOD_BOR(sql)
    End Sub
    Public Sub borrar()
        Dim sql As String = "DELETE FROM PersonalxVuelo WHERE legajo= " & _legajo & " AND id_vuelo=" & _id_vuelo & " AND id_puesto=" & _id_puesto
        BD.INS_MOD_BOR(sql)
    End Sub
End Class
