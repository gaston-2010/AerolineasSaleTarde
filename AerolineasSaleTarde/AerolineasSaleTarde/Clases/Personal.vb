Public Class Personal
    Public Property legajo As Integer
    Public Property apellido As String
    Public Property nombre As String
    Public Property celular As Int64
    Public Property mail As String
    Public Property fechaIngreso As Date
    Public Property id_Aeropuerto As Integer
    Public Property fechaNacimiento As Date


    Dim BD As New BD_TRANSACCIONAL

    Public Sub insertar()
        Dim sql As String = ""
        sql = "SET DATEFORMAT DMY INSERT INTO Personal
           (apellido
           ,nombre
           ,celular
           ,mail
           ,fechaIngreso
           ,id_Aeropuerto
           ,fechaNacimiento)
     VALUES
           ('" & _apellido & "'
           ,'" & _nombre & "'
           ," & _celular & "
           ,'" & _mail & "'
           ,'" & _fechaIngreso & "'
           ," & _id_Aeropuerto & "
           ,'" & _fechaNacimiento & "')"
        Me.BD.consultaABM(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = ""
        sql = "SET DATEFORMAT DMY UPDATE Personal 
        SET apellido = '" & _apellido & "'
      ,nombre = '" & _nombre & "'
        ,celular= " & _celular & "
      ,mail = '" & _mail & "'
      ,fechaIngreso= '" & _fechaIngreso & "'
      ,id_Aeropuerto = " & _id_Aeropuerto & "
      ,fechaNacimiento = '" & _fechaNacimiento & "' WHERE legajo = " & _legajo & ""
        Me.BD.consultaABM(sql)

    End Sub

    Public Sub borrar()

        Dim sql As String = ""
        sql = " DELETE FROM Personal"
        sql &= " WHERE legajo=" & _legajo
        Me.BD.consultaABM(sql)
    End Sub

End Class
