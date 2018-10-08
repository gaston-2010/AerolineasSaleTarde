Public Class PersonalxVuelo
    Public Property legajo As Integer
    Public Property id_vuelo As Integer
    Public Property id_puesto As Integer

    Dim BD As New BD_TRANSACCIONAL
    Public Sub insertar()
        Dim sql As String = "INSERT INTO PersonalxVuelo
           (legajo
           ,id_vuelo
           ,id_puesto)
     VALUES
           (" & _legajo & "
           ," & _id_vuelo & "
           ," & _id_puesto & ")"
        BD.consultaABM(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = "UPDATE PersonalxVuelo
   SET id_puesto = " & _id_puesto & "WHERE legajo= " & _legajo & "AND id_vuelo= " & _id_vuelo
        BD.consultaABM(sql)
    End Sub
    Public Sub borrar()
        Dim sql As String = "DELETE FROM PersonalxVuelo WHERE legajo= " & _legajo & " AND id_vuelo=" & _id_vuelo & " AND id_puesto=" & _id_puesto
        BD.consultaABM(sql)
    End Sub
End Class
