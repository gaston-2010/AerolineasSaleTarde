Public Class Tipo_Avion


    Enum estado_validar
        encontrado
        no_encontrado
    End Enum

    Dim BD As New CONEXION_BD

    Public Property id_tipoAvion As Integer
    Public Property nombre As String
    Public Property capacidadAlta As Integer
    Public Property capacidadTur As Integer
    Public Property longitud As Integer
    Public Property capacidadKg As Integer
    Public Property alcance As String
    Public Property cantidadsal As Integer

    Public Function validar() As estado_validar
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql = "SELECT * FROM tipoAvion "
        sql &= " WHERE id_tipoAvion = '" & _id_tipoAvion & "'"

        tabla = Me.BD.leo_tabla(sql)
        If tabla.Rows.Count() = 0 Then
            Return estado_validar.no_encontrado
        Else
            Return estado_validar.encontrado
        End If
    End Function

    Public Sub insertar()
        Dim sql As String = ""
        sql = "INSERT INTO TipoAvion "
        sql &= "("
        sql &= "nombre"
        sql &= ", capacidadPasajerosClaseAlta"
        sql &= ", capacidadPasajerosClaseTurista"
        sql &= ", longitud"
        sql &= ", capacidadKGEquipaje"
        sql &= ", alcanceVuelo"
        sql &= ", numeroSalidaEmergencia) VALUES ("
        sql &= " '" & _nombre & "'"
        sql &= ", " & _capacidadAlta
        sql &= ", " & _capacidadTur
        sql &= ", " & _longitud
        sql &= ", " & _capacidadKg
        sql &= ", '" & _alcance & "'"
        sql &= ", " & _cantidadsal & ")"
        Me.BD.INS_MOD_BOR(sql)

    End Sub

    Public Sub modificar()
        Dim sql As String = ""
        sql = "UPDATE TipoAvion "
        sql &= "SET  "
        sql &= "nombre ='" & _nombre & "'"
        sql &= ", capacidadPasajerosClaseAlta=" & _capacidadAlta
        sql &= ", capacidadPasajerosClaseTurista=" & _capacidadTur
        sql &= ", longitud=" & _longitud
        sql &= ", capacidadKGEquipaje=" & _capacidadKg
        sql &= ", alcanceVuelo='" & _alcance & "'"
        sql &= ", numeroSalidaEmergencia=" & _cantidadsal
        sql &= "WHERE id_tipoAvion=" & _id_tipoAvion
        Me.BD.INS_MOD_BOR(sql)

    End Sub

    Public Sub borrar()

        Dim sql As String = ""
        sql = " DELETE FROM TipoAvion"
        sql &= " WHERE id_tipoavion=" & _id_tipoAvion
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
                        _nombre = obj.text
                    Case "txt_capPasAlta"
                        _capacidadAlta = obj.text
                    Case "txt_capPasClasTur"
                        _capacidadTur = obj.text
                    Case "txt_cantsalidas"
                        _cantidadsal = obj.text
                    Case "txt_capacidadKg"
                        _capacidadKg = obj.text
                    Case "txt_longitud"
                        _longitud = obj.text
                End Select
            End If
            If obj.GetType().Name = "CMB_01" Then
                If obj.selectedvalue = -1 Then
                    MsgBox("El campo Alcance no esta seleccionado")
                    obj.focus
                    Exit Sub
                    Stop
                End If
                _alcance = obj.SelectedValue
            End If
        Next
    End Sub
End Class
