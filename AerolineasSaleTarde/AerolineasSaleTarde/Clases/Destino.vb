Public Class Destino
    Public Property id_localidad As Integer
    Public Property id As Integer

    Dim BD As New BD_TRANSACCIONAL



    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO Destinos"
        sql &= "(id_localidad) VALUES ( " & _id_localidad & " )"
        Me.BD.consultaABM(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = ""
        sql = "UPDATE Destinos"
        sql &= " SET id_localidad=" & _id_localidad & ""
        sql &= " WHERE id=" & _id
        Me.BD.consultaABM(sql)

    End Sub

    Public Sub transferir(ByRef controles As Object)
        For Each obj In controles.Controls
            If obj.Name = "cmb_Localidad" Then
                _id_localidad = obj.selectedValue
            End If
        Next
    End Sub


    Public Sub borrar()

        Dim sql As String = ""
        sql = " DELETE FROM Destinos"
        sql &= " WHERE id=" & _id
        Me.BD.consultaABM(sql)
    End Sub

End Class