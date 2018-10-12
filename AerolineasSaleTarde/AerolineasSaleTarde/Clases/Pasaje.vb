Public Class Pasaje
    Public Property idVuelo As Integer
    Public Property nroDocumento As Int64
    Public Property tipoDocumento As Integer
    Public Property tipoPasaje As Integer
    Public Property atencion As Integer
    Public Property nroAsiento As Integer
    Public Property claseTurista As Integer

    Dim BD As New BD_TRANSACCIONAL

    Public Sub insertar()
        Dim sql As String = " INSERT INTO  Pasaje 
           ( idVuelo 
           , nroDocumento 
           , tipoDocumento 
           , tipoPasaje 
           , atencion 
           , nroAsiento 
           , claseTurista )
     VALUES
           (" & _idVuelo & "," & _nroDocumento & "," & _tipoDocumento & "," & _tipoPasaje & "," & _atencion & "," & _nroAsiento & "," & _claseTurista & ")"
        BD.consultaABM(sql)

    End Sub

    Public Sub modificar()
        Dim sql As String = "UPDATE Pasaje
   SET 
      ,tipoPasaje = " & _tipoPasaje & "
      ,atencion = " & _atencion & "
      ,nroAsiento = " & _nroAsiento & "
      ,claseTurista = " & _claseTurista & "
    WHERE idVuelo = " & _idVuelo & " AND nroDocumento= " & _nroDocumento & " AND tipoDocumento= " & _tipoDocumento
        BD.consultaABM(sql)
    End Sub

    Public Sub borrar()
        Dim sql As String = "DELETE FROM Pasaje 
      WHERE idVuelo = " & _idVuelo & " AND nroDocumento= " & _nroDocumento & " AND tipoDocumento= " & _tipoDocumento
        BD.consultaABM(sql)
    End Sub
End Class
