﻿Public Class Vuelo
    Public Property id_vuelo As Integer
    Public Property fechaSalida As Date
    Public Property horaSalida As Date
    Public Property fechaLlegada As Date
    Public Property horaLlegada As Date
    Public Property id_avion As Integer
    Public Property idAereopuertoOrigen As Integer
    Public Property idAereopuertoDestino As Integer
    Public Property estado As String

    Enum estado_validar
        encontrado
        no_encontrado
    End Enum

    Dim BD As New CONEXION_BD


    Public Function validar() As estado_validar
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = "SELECT * FROM Vuelos "
        sql &= " WHERE id = '" & _id_vuelo & "'"

        tabla = Me.BD.leo_tabla(sql)
        If tabla.Rows.Count() = 0 Then
            Return estado_validar.no_encontrado
        Else
            Return estado_validar.encontrado
        End If
    End Function


    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO Vuelos ([fechaSalida]
           ,[horasalida]
           ,[fechaLlegada]
           ,[horaLlegada]
           ,[id_avion]
           ,[idAereopuertoOrigen]
           ,[idAereopuertoDestino]
           ,[estado])"
        sql &= "VALUES (" & _fechaSalida & "
           ," & _horaSalida & "
           ," & _fechaLlegada & "
           ," & _horaLlegada & "
           ," & _id_avion & "
           ," & _idAereopuertoOrigen & "
           ," & _idAereopuertoDestino & "
           ," & _estado & ")"
        Me.BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = ""
        sql = "UPDATE Aviones"
        sql &= " SET [fechaSalida] = " & _fechaSalida & "
       [horasalida] = " & _horaSalida & "
      ,[fechaLlegada] = " & _fechaLlegada & "
      ,[horaLlegada] = " & _horaLlegada & "
      ,[id_avion] = " & _id_avion & "
      ,[idAereopuertoOrigen] = " & _idAereopuertoOrigen & " 
     ,[idAereopuertoDestino] = " & _idAereopuertoDestino & "
      ,[estado] = '" & _estado & "' WHERE id_vuelo=" & _id_vuelo
        Me.BD.INS_MOD_BOR(sql)

    End Sub

    Public Sub borrar()

        Dim sql As String = ""
        sql = " DELETE FROM Vuelos"
        sql &= " WHERE id_vuelo=" & _id_vuelo
        Me.BD.INS_MOD_BOR(sql)
    End Sub
    Public Sub transferir(ByRef sender As Object)

    End Sub
End Class