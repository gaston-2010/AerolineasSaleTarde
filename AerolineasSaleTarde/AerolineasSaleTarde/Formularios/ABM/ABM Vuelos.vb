﻿Public Class ABM_Vuelos
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim _Vuelo As New Vuelo
    Dim _conex As New BD_TRANSACCIONAL
    Dim TE As New tratamientos_especiales
    Dim cambio As Boolean = False

    Private Sub ABM_Avion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmd_borrar.Enabled = False
        Me.txt_id_vuelo.Visible = False
        Me.cargar_grilla()
        Me.cmb_avion.cargar(Me._conex.consultaATabla("SELECT * FROM Aviones") _
                            , "id", "nombre")
        Me.cmb_aeropuertoDestino.cargar(Me._conex.consultaATabla("SELECT * FROM Aeropuertos") _
                            , "id", "nombre")
        Me.cmb_aeropuertoOrigen.cargar(Me._conex.consultaATabla("SELECT * FROM Aeropuertos a1
            join Aeropuertos a2 on a1.id =a2.id") _
                            , "id", "nombre")

        cmb_aeropuertoDestino.SelectedIndex = -1
        cmb_aeropuertoOrigen.SelectedIndex = -1
        cmd_borrar.BackColor = Color.Chocolate
        cmd_buscar.BackColor = Color.Chocolate
        cmd_grabar.BackColor = Color.Chocolate
        cmd_nuevo.BackColor = Color.Chocolate


    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.control_estado_grabacion = estado_grabacion.insertar
        Me.TE.blanquear_objetos(Me)
        Me.cmd_grabar.Text = "Grabar"
        Me.cmd_borrar.Enabled = False
        Me.cmd_grabar.Visible = True

    End Sub

    Private Sub cargar_grilla()
        Dim sql As String = "SET DATEFORMAT DMY Select v.id_vuelo as 'Nº Vuelo',FORMAT(v.fechaSalida ,'dd/MM/yyyy ') as ' Fecha de Salida',v.horasalida  as 'Hora de salida'
        ,FORMAT(v.fechaLlegada ,'dd/MM/yyyy ') as 'Fecha de LLegada',v.horaLlegada as 'Hora de LLegada'
       ,v.id_avion as 'Avion' ,a1.nombre as 'Aeropuerto Origen',a2.nombre as 'Aeropuerto Destino',v.estado
        FROM Vuelos v join Aviones a on v.id_avion=a.id JOIN Aeropuertos a1 ON v.idAereopuertoOrigen = a1.id 
        JOIN Aeropuertos a2 ON v.idAereopuertoDestino = a2.id"
        Me.DGV1.DataSource = Me._conex.consultaATabla(sql)

    End Sub

    Private Sub cmd_grabar_Click(sender As Object, e As EventArgs) Handles cmd_grabar.Click
        If ValidarCampo(Me) = 1 Then


            If comprobarexistencia() = True Then

                If comprobarfechas() = 1 Then


                    If control_estado_grabacion = estado_grabacion.insertar Then
                        transferir(Me)
                        Me._Vuelo.insertar()
                    Else
                        Me._Vuelo.id_vuelo = Me.txt_id_vuelo.Text
                        transferir(Me)
                        Me._Vuelo.modificar()
                    End If
                End If
            End If
            Me.cargar_grilla()
            Me.TE.blanquear_objetos(Me)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub DGV1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellDoubleClick
        Me.txt_id_vuelo.Text = DGV1.CurrentRow.Cells(0).Value
        Me.txt_FechaSalida.Text = DGV1.CurrentRow.Cells(1).Value.ToString()
        Me.txt_horaSalida.Text = DGV1.CurrentRow.Cells(2).Value.ToString()
        Me.txt_fechaLlegada.Text = DGV1.CurrentRow.Cells(3).Value.ToString()
        Me.txt_horaLlegada.Text = DGV1.CurrentRow.Cells(4).Value.ToString()
        Me.cmb_avion.SelectedValue = DGV1.CurrentRow.Cells(5).Value
        Me.cmb_aeropuertoOrigen.Text = DGV1.CurrentRow.Cells(6).Value
        Me.cmb_aeropuertoDestino.Text = DGV1.CurrentRow.Cells(7).Value
        Me.cmb_estado.SelectedItem = DGV1.CurrentRow.Cells(8).Value
        Me.control_estado_grabacion = estado_grabacion.modificar
        Me.cmd_grabar.Visible = True
        Me.cmd_grabar.Text = "Modificar"
        Me.cmd_borrar.Enabled = True
    End Sub

    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_borrar.Click
        Me._Vuelo.id_vuelo = Me.txt_id_vuelo.Text
        If MsgBox("DESEA ELIMINAR?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        Me._Vuelo.borrar()
        Me.TE.blanquear_objetos(Me)
        Me.cargar_grilla()
    End Sub

    Private Function comprobarexistencia()
        If control_estado_grabacion = estado_grabacion.insertar Then
            Dim tabla As New DataTable
            Dim fechaSalida As Date = txt_fechaLlegada.Text
            Dim horaSalida As Date = txt_horaSalida.Text
            Dim fechaLlegada As Date = txt_fechaLlegada.Text
            Dim horaLlegada As Date = txt_horaLlegada.Text
            Dim id_avion As Integer = retornarvalor(cmb_avion)
            Dim idAereopuertoOrigen As Integer = retornarvalor(cmb_aeropuertoOrigen)
            Dim idAereopuertoDestino As Integer = retornarvalor(cmb_aeropuertoDestino)
            Dim estado As String = cmb_estado.SelectedItem
            Dim sql As String = "SET DATEFORMAT DMY SELECT * FROM Vuelos v join Aviones a on v.id_avion=a.id JOIN Aeropuertos a1 ON v.idAereopuertoOrigen = a1.id 
                 JOIN Aeropuertos a2 ON v.idAereopuertoDestino = a2.id 
                    WHERE fechaSalida= '" & fechaSalida & "'
                     AND fechaLlegada= '" & fechaLlegada & "'
                     AND horaLlegada= '" & horaLlegada & "'
                     AND horasalida= '" & horaSalida & "'
                     AND id_avion = " & id_avion & "
                     AND idAereopuertoOrigen= " & idAereopuertoOrigen & "
                     AND idAereopuertoDestino= " & idAereopuertoDestino & "
                     AND estado= '" & estado & "'"
            tabla = Me._conex.consultaATabla(sql)
            If tabla.Rows.Count <> 0 Then
                MsgBox("El Vuelo ya esta creado")
                Return False
            End If
            Return True
        Else
            Return True
        End If

    End Function

    Private Function ValidarCampo(ByRef controles As Control)
        For Each obj In controles.Controls
            Dim nombre As String = ""
            nombre = obj.GetType().Name()
            If nombre = "MTB_01" Then
                Dim actual As MTB_01 = obj
                If actual.validable = True Then
                    If actual.Text = "" Then
                        MsgBox("El Campo " & actual.nombre_campo & " está vacio", MsgBoxStyle.Exclamation)
                        actual.Focus()
                        Return 0
                        Exit Function
                    End If
                    If actual.Text = "  /  /" Then
                        MsgBox("El Campo " & actual.nombre_campo & " está vacio", MsgBoxStyle.Exclamation)
                        actual.Focus()
                        Return 0
                        Exit Function
                    End If
                    If actual.Text = "  :" Then
                        MsgBox("El Campo " & actual.nombre_campo & " está vacio", MsgBoxStyle.Exclamation)
                        actual.Focus()
                        Return 0
                        Exit Function
                    End If
                End If
            End If
            If nombre = "CMB_01" Then
                Dim actual As CMB_01 = obj
                If actual.validable = True Then
                    If actual.SelectedIndex = -1 Then
                        MsgBox("El Campo " & actual.nombre_campo & " está Deseleccionado")
                        actual.Focus()
                        Return 0
                        Exit Function
                    End If
                End If

            End If
        Next
        Return 1
    End Function

    Private Function retornarvalor(ByRef combo As ComboBox)
        Dim numero As Object = combo.SelectedValue
        If (TypeOf numero Is DataRowView) Then
            Return 0

        End If
        Dim nombre As String = Convert.ToString(numero)
        Return nombre
    End Function

    'Private Sub cmb_aeropuertoDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_aeropuertoDestino.SelectedIndexChanged
    '    'Me.cmb_aeropuertoOrigen.SelectedIndex = -1
    '    Dim numero As Object = cmb_aeropuertoDestino.SelectedValue
    '    If (TypeOf numero Is DataRowView) Then
    '        Exit Sub
    '    End If
    '    Dim nombre As String = Convert.ToString(numero)
    '    If nombre = "" Then
    '        Exit Sub
    '    End If
    '    Dim Sql As String = "SELECT * FROM Aeropuertos a1 join Aeropuertos a2 on a1.id=a2.id where not a2.id= " & nombre
    '    Me.cmb_aeropuertoOrigen.cargar(Me._conex.consultaATabla(Sql), "id", "nombre")

    'End Sub

    Private Sub cmb_aeropuertoOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_aeropuertoOrigen.SelectedIndexChanged
        'Me.cmb_aeropuertoDestino.SelectedIndex = -1
        Dim numero As Object = cmb_aeropuertoOrigen.SelectedValue
        If (TypeOf numero Is DataRowView) Then
            Exit Sub
        End If
        Dim nombre As String = Convert.ToString(numero)
        If nombre = "" Then
            Exit Sub
        End If
        Dim Sql As String = "SELECT * FROM Aeropuertos a1 join Aeropuertos a2 on a1.id=a2.id where not a2.id= " & nombre
        Me.cmb_aeropuertoDestino.cargar(Me._conex.consultaATabla(Sql), "id", "nombre")
    End Sub

    Private Function comprobarfechas()
        Dim fecha_menor As DateTime = txt_fechaSalida.Text
        Dim fecha_mayor As DateTime = txt_fechaLlegada.Text
        Dim hora_menor As DateTime = txt_horaSalida.Text
        Dim hora_mayor As DateTime = txt_horaLlegada.Text
        If fecha_mayor < fecha_menor Or hora_menor >= hora_mayor Then
            MsgBox("La fecha de Salida debe ser menor que la de LLegada")
            txt_fechaLlegada.Focus()
            Return 0
        End If

        Return 1
    End Function

    Private Sub transferir(ByRef sender As Object)
        Me._Vuelo.fechaSalida = Me.txt_FechaSalida.Text
        Me._Vuelo.horaSalida = Me.txt_horaSalida.Text
        Me._Vuelo.fechaLlegada = Me.txt_fechaLlegada.Text
        Me._Vuelo.horaLlegada = Me.txt_horaLlegada.Text
        Me._Vuelo.id_avion = Me.cmb_avion.SelectedValue
        Me._Vuelo.idAereopuertoOrigen = Me.cmb_aeropuertoOrigen.SelectedValue
        Me._Vuelo.idAereopuertoDestino = Me.cmb_aeropuertoDestino.SelectedValue
        Me._Vuelo.estado = Me.cmb_estado.SelectedItem
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        If txt_Buscar.Text <> "" Then
            Dim sql As String = "SET DATEFORMAT DMY Select v.id_vuelo as 'Nº Vuelo',FORMAT(v.fechaSalida ,'dd/MM/yyyy ') as ' Fecha de Salida',v.horasalida  as 'Hora de salida'
        ,FORMAT(v.fechaLlegada ,'dd/MM/yyyy ') as 'Fecha de LLegada',v.horaLlegada as 'Hora de LLegada'
       ,v.id_avion as 'Avion' ,a1.nombre as 'Aeropuerto Origen',a2.nombre as 'Aeropuerto Destino',v.estado
        FROM Vuelos v join Aviones a on v.id_avion=a.id JOIN Aeropuertos a1 ON v.idAereopuertoOrigen = a1.id 
        JOIN Aeropuertos a2 ON v.idAereopuertoDestino = a2.id where v.id_vuelo = " & txt_Buscar.Text
            Me.DGV1.DataSource = Me._conex.consultaATabla(sql)
        Else
            MsgBox("Ingrese el numero de Vuelo a buscar")
            txt_Buscar.Focus()
        End If
    End Sub

    Private Sub txt_FechaSalida_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub
End Class