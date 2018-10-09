Public Class Embarquec
    Public Property nroVuelo As Integer
    Public Property nroDocumento As Integer
    Public Property tipoDocumento As Integer
    Public Property PuertaEmbarque As Integer
    Dim BD As New BD_TRANSACCIONAL
    Public Sub insertar()
        Dim sql As String = "INSERT INTO Embarque
           (nroVuelo,nroDocumento
           ,tipoDocumento
           ,PuertaEmbarque)
     VALUES
           (" & _nroVuelo & " ," & _nroDocumento & "
           ," & _tipoDocumento & "
           ," & _PuertaEmbarque & ")"
        BD.consultaABM(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = "UPDATE Embarque
   SET PuertaEmbarque = " & _PuertaEmbarque & "
 WHERE nroVuelo = " & _nroVuelo & " AND tipoDocumento =" & _tipoDocumento & " AND nroDocumento= " & _nroDocumento
        BD.consultaABM(sql)
    End Sub
    Public Sub borrar()
        Dim sql As String = "DELETE FROM Embarque WHERE nroVuelo = " & _nroVuelo & " 
        AND tipoDocumento =" & _tipoDocumento & " AND nroDocumento= " & _nroDocumento
        BD.consultaABM(sql)
    End Sub

End Class
