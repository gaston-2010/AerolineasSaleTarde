Public Class Tipo_Avion



    Dim BD As New BD_TRANSACCIONAL

    Public Property id_tipoAvion As Integer
    Public Property nombre As String
    Public Property capacidadAlta As Integer
    Public Property capacidadTur As Integer
    Public Property longitud As Integer
    Public Property capacidadKg As Integer
    Public Property alcance As String
    Public Property cantidadsal As Integer
    Public Property validado As Boolean = False

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
        Me.BD.consultaABM(sql)

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
        Me.BD.consultaABM(sql)

    End Sub

    Public Sub borrar()

        Dim sql As String = ""
        sql = " DELETE FROM TipoAvion"
        sql &= " WHERE id_tipoavion=" & _id_tipoAvion
        Me.BD.consultaABM(sql)
    End Sub

    Public Sub transferir(ByRef controles As Object)

        For Each obj In controles.Controls

            If validado = True Then

                Select Case obj.Name
                    Case "txt_nombre"
                        _nombre = obj.text.trim()
                    Case "txt_capPasAlta"
                        If obj.text = "" Then
                            _capacidadAlta = 0

                        Else
                            _capacidadAlta = obj.text.trim()
                        End If
                    Case "txt_capPasClasTur"
                        If obj.text = "" Then
                            _capacidadTur = 0
                        Else
                            _capacidadTur = obj.text.trim()
                        End If

                    Case "txt_cantsalidas"
                        _cantidadsal = obj.text.trim()
                    Case "txt_capacidadKg"
                        _capacidadKg = obj.text.trim()
                    Case "txt_longitud"
                        _longitud = obj.text.trim()
                End Select
                If obj.GetType().Name = "CMB_01" Then
                    _alcance = obj.SelectedItem
                End If
            End If
        Next
    End Sub

    Public Sub validarcampo(ByRef controles As Object)
        For Each obj In controles.Controls

            If obj.GetType().Name = "MTB_01" Then
                If obj.validable = True Then
                    If obj.text = "" Then
                        MsgBox("El " & obj.nombre_campo & " Está vacío")
                        obj.Focus()
                        validado = False
                        Exit Sub
                    End If

                End If
            End If
            If obj.GetType().Name = "CMB_01" Then
                If obj.SelectedItem = "" Then
                    MsgBox("El campo Alcance no esta seleccionado")
                    obj.focus
                    validado = False
                    Exit Sub

                End If
            End If

        Next
        validado = True
    End Sub
End Class
