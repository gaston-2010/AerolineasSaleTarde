Public Class Avion


    Enum estado_validar
        encontrado
        no_encontrado
    End Enum

    Dim BD As New CONEXION_BD
    Public Property id As Integer
    Public Property nombre As String
    Public Property id_TipoAvion As String


    Public Function validar() As estado_validar
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = "SELECT * FROM Aviones "
        sql &= " WHERE id = '" & _id & "'"

        tabla = Me.BD.leo_tabla(sql)
        If tabla.Rows.Count() = 0 Then
            Return estado_validar.no_encontrado
        Else
            Return estado_validar.encontrado
        End If
    End Function


    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO Aviones"
        sql &= "(nombre, idTipoAvion) VALUES ('" & _nombre & "' ," & _id_TipoAvion & ")"
        Me.BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub modificar()
        Dim sql As String = ""
        sql = "UPDATE Aviones"
        sql &= " SET nombre='" & _nombre & "'"
        sql &= ", idTipoAvion=" & _id_TipoAvion
        sql &= " WHERE id=" & _id
        Me.BD.INS_MOD_BOR(sql)

    End Sub

    Public Sub borrar()

        Dim sql As String = ""
        sql = " DELETE FROM Aviones"
        sql &= " WHERE id=" & _id
        Me.BD.INS_MOD_BOR(sql)
    End Sub

    Public Sub transferir(ByRef controles As Object)
        For Each obj In controles.Controls
            If obj.GetType().Name = "MTB_01" Then
                If obj.validable = True Then
                    If obj.text = "" Then
                        MsgBox("El " & obj.nombre_campo & " Está vacío")
                        obj.Focus()
                        Exit Sub
                    End If
                End If
                Select Case obj.Name
                    Case "txt_nombre"
                        _nombre = obj.text.trim()

                End Select
            End If
            If obj.GetType.Name = "CMB_01" Then
                If obj.validable = True Then
                    If obj.selectedValue = -1 Then
                        MsgBox("El Tipo de Avion està deseleccionado")
                        Exit Sub
                    End If

                End If
                _id_TipoAvion = obj.selectedvalue
            End If
        Next
    End Sub

End Class
