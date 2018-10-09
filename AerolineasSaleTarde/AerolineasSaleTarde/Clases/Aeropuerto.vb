Public Class Aeropuerto
    Public Property id As Integer
    Public Property nombre As String
    Public Property cabotaje_internacional As Integer
    Public Property cantidadPuertasEmbarque As Integer
    Public Property salaVip As Integer
    Public Property salaFumadores As Integer
    Public Property id_localidad As Integer

    Dim BD As New BD_TRANSACCIONAL

    Public Sub insertar()
        Dim sql As String = "INSERT INTO Aeropuertos 
           ( nombre 
           , [cabotaje/internacional]
           , cantidadPuertasEmbarque 
           , salaVip 
           , salaFumadores 
           , id_Localidad )
     VALUES
           ( '" & _nombre & "'
           ," & _cabotaje_internacional & "
           ," & _cantidadPuertasEmbarque & " 
           ," & _salaVip & " 
           ," & _salaFumadores & "
           ," & _id_localidad & " )"
        BD.consultaABM(sql)

    End Sub

    Public Sub modificar()
        Dim sql As String = "UPDATE Aeropuertos
   SET nombre = '" & _nombre & "'
      ,[cabotaje/internacional] = " & _cabotaje_internacional & "
      ,cantidadPuertasEmbarque = " & _cantidadPuertasEmbarque & "
      ,salaVip = " & _salaVip & "
      ,salaFumadores = " & _salaFumadores & "
      ,id_Localidad = " & _id_localidad & "
    WHERE  id = " & _id
        BD.consultaABM(sql)
    End Sub

    Public Sub borrar()
        Dim sql As String = "DELETE FROM Aeropuertos WHERE id= " & _id
        BD.consultaABM(sql)
    End Sub


End Class
