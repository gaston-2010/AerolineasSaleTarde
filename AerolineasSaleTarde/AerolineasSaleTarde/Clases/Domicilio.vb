Public Class Domicilio
    Public Property calle As String
    Public Property nroCalle As Integer
    Public Property localidad As Integer
    Public Property dpto As String
    Public Property pais As Integer


    Dim BD As New BD_TRANSACCIONAL
    Public Sub insertar()
        Dim sql As String = "INSERT INTO Domicilio
           (calle
           ,nroCalle
           ,dpto
           ,pais
           ,localidad)
     VALUES
           ( '" & _calle & "'
           , " & _nroCalle & "
           , '" & _dpto & "'
           , " & _pais & "
           , " & _localidad & " )"
        BD.consultaABM(sql)

    End Sub
    Public Sub modificar()
        Dim sql As String = "UPDATE Domicilio 
        SET dpto = '" & _dpto & "'
            ,pais = " & _pais & "
        WHERE calle= '" & _calle & "' AND nroCalle= " & _nroCalle & " 
        AND localidad = " & _localidad & ""
        BD.consultaABM(sql)
    End Sub
    Public Sub borrar()
        Dim sql As String = " DELETE FROM Domicilio WHERE calle= '" & _calle & "' AND nroCalle= " & _nroCalle & " 
        AND localidad = " & _localidad & ""
        BD.consultaABM(sql)
    End Sub

    Public Sub eliminarnoref()
        Dim sql As String = " DELETE FROM Domicilio  
        WHERE NOT EXISTS ( SELECT 1 FROM Pasajero pa WHERE 
        pa.calle=Domicilio.calle AND pa.nroCalle=Domicilio.nroCalle AND pa.id_localidad = Domicilio.localidad)  "
        BD.consultaABM(sql)
    End Sub
End Class
