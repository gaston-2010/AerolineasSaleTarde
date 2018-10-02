Public Class ServicioxAeropuerto
    Public Property id_aeropuerto As Integer
    Public Property tipo_servicio As Integer
    Public Property nombre As String

    Dim BD As New CONEXION_BD
    Public Sub insertar()
        Dim sql As String = "INSERT INTO [dbo].[ServicioxAeropuerto]
           ([id_aeropuerto]
           ,[tipo_servicio]
           ,[nombre])
     VALUES
           (" & _id_aeropuerto & "
           ," & _tipo_servicio & "
           ,'" & _nombre & "')"
        BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = "UPDATE [dbo].[ServicioxAeropuerto]
   SET nombre= '" & _nombre & "' where id_aeropuerto = " & _id_aeropuerto & " AND tipo_servicio= " & _tipo_servicio & ""
        BD.INS_MOD_BOR(sql)
    End Sub
    Public Sub borrar()
        Dim sql As String = "DELETE FROM PersonalxVuelo WHERE id_aeropuerto= " & _id_aeropuerto & " AND tipo_servicio=" & _tipo_servicio & " AND nombre='" & _nombre & "'"
        BD.INS_MOD_BOR(sql)
    End Sub




End Class
