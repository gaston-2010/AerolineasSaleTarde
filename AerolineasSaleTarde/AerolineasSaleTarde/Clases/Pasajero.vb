Public Class Pasajero

    Public Property nroDocumento As Int64
    Public Property tipoDocumento As Integer
    Public Property nacionalidad As String
    Public Property nombre As String
    Public Property apellido As String
    Public Property sexo As String
    Public Property calle As String
    Public Property motivo As String
    Public Property nroCalle As String
    Public Property id_localidad As String

    Dim BD As New BD_TRANSACCIONAL

    Public Sub insertar()
        Dim sql As String = "INSERT INTO Pasajero
           (nroDocumento
           ,tipoDocumento
           ,nacionalidad
           ,nombre
           ,apellido
           ,sexo
           ,calle
           ,motivo
           ,nroCalle
           ,id_localidad)
     VALUES
           ('" & _nroDocumento & "'
           ," & _tipoDocumento & "
           ,'" & _nacionalidad & "'
           ,'" & _nombre & "'
           ,'" & _apellido & "'
           ,'" & _sexo & "'
           ,'" & _calle & "'
           ,'" & _motivo & "'
           ," & _nroCalle & "
           ," & _id_localidad & ")"

        BD.consultaABM(sql)

    End Sub

    Public Sub modificar()
        Dim sql As String = "UPDATE Pasajero
   SET 
      nacionalidad = '" & _nacionalidad & "'
      ,nombre = '" & _nombre & "'
      ,apellido = '" & _apellido & "'
      ,sexo = '" & _sexo & "'
      ,calle = '" & _calle & "'
      ,motivo = '" & _motivo & "'
      ,nroCalle = " & _nroCalle & "
      ,id_localidad = " & _id_localidad & " 
 WHERE nroDocumento= " & _nroDocumento & " AND tipoDocumento = " & _tipoDocumento & ""
        BD.consultaABM(sql)
    End Sub

    Public Sub borrar()
        Dim sql As String = " DELETE FROM Pasajero WHERE nroDocumento= " & _nroDocumento & "
        AND tipoDocumento=" & _tipoDocumento & ""

        BD.consultaABM(sql)
    End Sub
End Class
