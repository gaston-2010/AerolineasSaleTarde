Public Class DomicilioxPasajero
    Public Property nroDocumento As Int64
    Public Property tipoDocumento As Integer
    Public Property calle As String
    Public Property nroCalle As Integer
    Public Property localidad As Integer


    Dim BD As New BD_TRANSACCIONAL
    Public Sub insertar()
        Dim sql As String = "INSERT INTO DomicilioxPasajero
           (nroDocumento
           ,tipoDocumento
            ,calle
           ,nroCalle
           ,localidad)
     VALUES
           ( " & _nroDocumento & "
            , " & _tipoDocumento & "
            , '" & _calle & "'
           ,  " & _nroCalle & "
           , " & _localidad & " )"
        BD.consultaABM(sql)

    End Sub
    Public Sub modificar()
        Dim sql As String = "UPDATE DomicilioxPasajero
   SET 
      ,calle = '" & _calle & "'
      ,nroCalle = " & _nroCalle & "
      , localidad = " & _localidad & "
 WHERE nroDocumento =" & _nroDocumento & " AND tipoDocumento = " & _tipoDocumento
    End Sub

    Public Sub borrar()
        Dim sql As String = " DELETE FROM DomicilioxPasajero WHERE calle= '" & _calle & "' AND nroCalle= " & _nroCalle & " 
        AND localidad = " & _localidad & "AND nroDocumento= " & _nroDocumento & " AND tipoDocumento = " & _tipoDocumento
        BD.consultaABM(sql)
    End Sub

End Class
