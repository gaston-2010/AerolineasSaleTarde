Public Class Vuelo
    Public Property id_vuelo As Integer
    Public Property fechaSalida As Date
    Public Property horaSalida As Date
    Public Property fechaLlegada As Date
    Public Property horaLlegada As Date
    Public Property id_avion As Integer
    Public Property idAereopuertoOrigen As Integer
    Public Property idAereopuertoDestino As Integer
    Public Property estado As String


    Dim BD As New BD_TRANSACCIONAL




    Public Sub insertar()
        Dim sql As String = ""
        sql = "SET DATEFORMAT DMY INSERT INTO Vuelos (fechaSalida
           ,horasalida
           ,fechaLlegada
           ,horaLlegada
           ,id_avion
           ,idAereopuertoOrigen
           ,idAereopuertoDestino
           ,estado)"
        sql &= "VALUES ('" & _fechaSalida & "'
           ,'" & _horaSalida & "'
           ,'" & _fechaLlegada & "'
           ,'" & _horaLlegada & "'
           ," & _id_avion & "
           ," & _idAereopuertoOrigen & "
           ," & _idAereopuertoDestino & "
           ,'" & _estado & "')"
        Me.BD.consultaABM(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = ""
        sql = "SET DATEFORMAT DMY UPDATE Vuelos"
        sql &= " SET fechaSalida = '" & _fechaSalida & "'
       ,horasalida = '" & _horaSalida & "'
      ,fechaLlegada = '" & _fechaLlegada & "'
      ,horaLlegada = '" & _horaLlegada & "'
      ,id_avion = " & _id_avion & "
      ,idAereopuertoOrigen= " & _idAereopuertoOrigen & " 
     ,idAereopuertoDestino = " & _idAereopuertoDestino & "
      ,estado = '" & _estado & "' WHERE id_vuelo=" & _id_vuelo
        Me.BD.consultaABM(sql)

    End Sub

    Public Sub borrar()

        Dim sql As String = ""
        sql = " DELETE FROM Vuelos"
        sql &= " WHERE id_vuelo=" & _id_vuelo
        Me.BD.consultaABM(sql)
    End Sub
    Public Sub transferir(ByRef sender As Object)

    End Sub
End Class
