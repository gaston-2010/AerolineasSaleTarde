Public Class ABM_ServicioxAeropuerto


    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim _ServicioxAero As New ServicioxAeropuerto
    Dim _conex As New BD_TRANSACCIONAL
    Dim TE As New tratamientos_especiales

    Private Sub cmd_Buscar_Click(sender As Object, e As EventArgs) Handles cmd_Buscar.Click
        If cmb_Aeropuerto.SelectedIndex = -1 Then
            MsgBox("Seleccione un Aeropuerto a buscar")

        Else
            Dim sql2 As String = "SELECT s.id_aeropuerto as 'Nº Aeropuerto',t.nombre as 'Tipo de Servicio',s.nombre as 'Nombre del Servicio' FROM ServicioxAeropuerto s join Aeropuertos a on s.id_aeropuerto = a.id
          JOIN TipoServicio t ON s.tipo_servicio = t.id  where s.id_aeropuerto=" & cmb_Aeropuerto.SelectedValue
            Me.DGV1.DataSource = Me._conex.consultaATabla(sql2)


            cmd_Grabar.Enabled = True
                cmb_Aeropuerto.Enabled = False
            End If

    End Sub

    Private Sub ABM_Avion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd_Borrar.BackColor = Color.Chocolate
        cmd_Buscar.BackColor = Color.Chocolate
        cmd_Grabar.BackColor = Color.Chocolate
        cmd_Nuevo.BackColor = Color.Chocolate
        cmd_Grabar.Enabled = False
        cmb_Aeropuerto.Enabled = True

        Me.cmd_Borrar.Enabled = False
        Me.cmb_Aeropuerto.cargar(Me._conex.consultaATabla("SELECT * FROM Aeropuertos") _
                            , "id", "nombre")
        Me.cmb_tipoServicio.cargar(Me._conex.consultaATabla("SELECT * FROM TipoServicio") _
                            , "id", "nombre")
        Me.TE.blanquear_objetos(Me)

    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        Me.control_estado_grabacion = estado_grabacion.insertar
        Me.cmd_Borrar.Enabled = False
        Me.cmd_Grabar.Text = "Grabar"
        Me.cmd_Borrar.Enabled = False
        Me.cmb_Aeropuerto.cargar(Me._conex.consultaATabla("SELECT * FROM Aeropuertos") _
                            , "id", "nombre")
        Me.cmb_tipoServicio.cargar(Me._conex.consultaATabla("SELECT * FROM TipoServicio") _
                            , "id", "nombre")
        Me.TE.blanquear_objetos(Me)
        Me.DGV1.DataSource = New DataTable
        cmd_Grabar.Enabled = False
        cmb_Aeropuerto.Enabled = True


    End Sub
    Private Sub cargargrilla()
        Dim sql As String = "SELECT s.id_aeropuerto as 'Nº Aeropuerto',t.nombre as 'Tipo de Servicio',s.nombre as 'Nombre del Servicio' FROM ServicioxAeropuerto s join Aeropuertos a on s.id_aeropuerto = a.id
          JOIN TipoServicio t ON s.tipo_servicio = t.id  where s.id_aeropuerto=" & cmb_Aeropuerto.SelectedValue
        DGV1.DataSource = Me._conex.consultaATabla(sql)
    End Sub
    Private Sub cmd_grabar_Click(sender As Object, e As EventArgs) Handles cmd_Grabar.Click

        If ValidarCampo(Me) = 1 Then

            If comprobarexistencia() = 0 Then
                If control_estado_grabacion = estado_grabacion.insertar Then
                    transferir(Me)
                    Me._ServicioxAero.insertar()
                Else
                    Me._ServicioxAero.id_aeropuerto = cmb_Aeropuerto.SelectedValue
                    Me._ServicioxAero.tipo_servicio = Me.cmb_tipoServicio.SelectedValue
                    transferir(Me)
                    Me._ServicioxAero.modificar()
                End If

            End If
        End If
        cargargrilla()
        Me.TE.blanquear_objetos(Me)
    End Sub

    Private Sub DGV1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellDoubleClick
        Me.cmb_Aeropuerto.SelectedValue = DGV1.CurrentRow.Cells(0).Value
        Me.control_estado_grabacion = estado_grabacion.modificar
        Me.cmd_Grabar.Text = "Modificar"
        Me.cmd_Borrar.Enabled = True
        Me.cmb_tipoServicio.Text = DGV1.CurrentRow.Cells(1).Value
        Me.txt_nombreservicio.Text = DGV1.CurrentRow.Cells(2).Value

    End Sub

    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_Borrar.Click
        Me._ServicioxAero.id_aeropuerto = cmb_Aeropuerto.SelectedValue
        Me._ServicioxAero.tipo_servicio = Me.cmb_tipoServicio.SelectedValue
        Me._ServicioxAero.nombre = Me.txt_nombreservicio.Text.Trim
        If MsgBox("DESEA ELIMINAR?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        Me.transferir(Me)
        Me._ServicioxAero.borrar()
        Me.cargargrilla()
        Me.TE.blanquear_objetos(Me)

    End Sub

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

    Public Sub transferir(ByRef sender As Object)
        Me._ServicioxAero.id_aeropuerto = Me.cmb_Aeropuerto.SelectedValue
        Me._ServicioxAero.tipo_servicio = Me.cmb_tipoServicio.SelectedValue
        Me._ServicioxAero.nombre = Me.txt_nombreservicio.Text.Trim
    End Sub



    Public Function comprobarexistencia()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT s.id_aeropuerto,s.tipo_servicio,s.nombre FROM ServicioxAeropuerto s join Aeropuertos a on s.id_aeropuerto = a.id
            where s.id_aeropuerto =" & cmb_Aeropuerto.SelectedValue & " AND s.tipo_servicio=" & cmb_tipoServicio.SelectedValue & " AND s.nombre= '" & txt_nombreservicio.Text.Trim & "'"
        tabla = Me._conex.consultaATabla(sql)
        If tabla.Rows.Count = 0 Then
            Return 0
        Else
            MsgBox("El servicio ya esta agregado al Aeropuerto")
            Return 1
        End If

    End Function
End Class