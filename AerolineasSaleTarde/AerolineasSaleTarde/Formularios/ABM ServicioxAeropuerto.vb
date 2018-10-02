Public Class ABM_ServicioxAeropuerto


    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim _ServicioxAero As New ServicioxAeropuerto
    Dim _conex As New CONEXION_BD
    Dim TE As New tratamientos_especiales

    Private Sub cmd_Buscar_Click(sender As Object, e As EventArgs) Handles cmd_Buscar.Click
        If txt_aeropuerto.Text <> "" Then
            Dim tabla As New DataTable
            Dim sql As String = "SELECT * from Aeropuertos a where a.id =" & txt_aeropuerto.Text.Trim()
            tabla = Me._conex.leo_tabla(sql)
            If tabla.Rows.Count = 0 Then
                MsgBox("Aeropuerto No Encontrado")
                txt_nombreAeropuerto.Enabled = False
                Me.TE.blanquear_objetos(Me)
            Else
                Dim sql2 As String = "SELECT * from ServicioxAeropuerto a where id_aeropuerto =" & txt_aeropuerto.Text.Trim()
                Me.DGV1.DataSource = Me._conex.leo_tabla(sql2)
                txt_nombreAeropuerto.Enabled = True
                rellenar(Me, txt_aeropuerto.Text)

            End If
        Else
            MsgBox("Ingrese el Aeropuerto a buscar")
            txt_aeropuerto.Focus()
        End If
    End Sub

    Private Sub ABM_Avion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd_Borrar.BackColor = Color.Chocolate
        cmd_Buscar.BackColor = Color.Chocolate
        cmd_Grabar.BackColor = Color.Chocolate
        cmd_Nuevo.BackColor = Color.Chocolate

        Me.cmd_Borrar.Enabled = False
        txt_nombreAeropuerto.Enabled = False
        Me.cmb_tipoServicio.cargar(Me._conex.leo_tabla("SELECT * FROM TipoServicio") _
                            , "id", "nombre")
        Me.TE.blanquear_objetos(Me)

    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        Me.control_estado_grabacion = estado_grabacion.insertar
        Me.cmd_Borrar.Enabled = False
        Me.cmd_Grabar.Text = "Grabar"
        Me.cmd_Borrar.Enabled = False
        Me.cmb_tipoServicio.cargar(Me._conex.leo_tabla("SELECT * FROM TipoServicio") _
                            , "id", "nombre")
        Me.TE.blanquear_objetos(Me)
        Me.DGV1.ClearSelection()

    End Sub
    Private Sub cargargrilla()
        Dim sql As String = "SELECT s.id_aeropuerto,s.tipo_servicio,s.nombre FROM ServicioxAeropuerto s join Aeropuertos a on s.id_aeropuerto = a.id
            where s.id_aeropuerto=" & txt_aeropuerto.Text
        DGV1.DataSource = Me._conex.leo_tabla(sql)
    End Sub
    Private Sub cmd_grabar_Click(sender As Object, e As EventArgs) Handles cmd_Grabar.Click

        If ValidarCampo(Me) = 1 Then

            If comprobarexistencia() = 0 Then
                If control_estado_grabacion = estado_grabacion.insertar Then
                    transferir(Me)
                    Me._ServicioxAero.insertar()
                Else
                    Me._ServicioxAero.id_aeropuerto = Me.txt_aeropuerto.Text
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
        Me.txt_aeropuerto.Text = DGV1.CurrentRow.Cells(0).Value
        Me.control_estado_grabacion = estado_grabacion.modificar
        Me.cmd_Grabar.Text = "Modificar"
        Me.cmd_Borrar.Enabled = True
        Me.cmb_tipoServicio.SelectedValue = DGV1.CurrentRow.Cells(1).Value
        Me.txt_nombreservicio.Text = DGV1.CurrentRow.Cells(2).Value

    End Sub

    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_Borrar.Click
        Me._ServicioxAero.id_aeropuerto = Me.txt_aeropuerto.Text
        Me._ServicioxAero.tipo_servicio = Me.cmb_tipoServicio.SelectedValue
        Me._ServicioxAero.nombre = Me.txt_nombreservicio.Text
        If MsgBox("DESEA ELIMINAR?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

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
        Me._ServicioxAero.id_aeropuerto = Me.txt_aeropuerto.Text
        Me._ServicioxAero.tipo_servicio = Me.cmb_tipoServicio.SelectedValue
        Me._ServicioxAero.nombre = Me.txt_nombreservicio.Text
    End Sub
    Private Sub rellenar(ByRef sender As Object, ByVal legajo As Integer)
        Dim tabla As New DataTable
        Dim sql As String = "SELECT a.nombre From Aeropuertos a where a.id= '" & legajo & "'"
        tabla = Me._conex.leo_tabla(sql)
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            Me.txt_nombreAeropuerto.Text = tabla.Rows(c)(0)
        Next

    End Sub
    Public Function comprobarexistencia()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT s.id_aeropuerto,s.tipo_servicio,s.nombre FROM ServicioxAeropuerto s join Aeropuertos a on s.id_aeropuerto = a.id
            where s.id_aeropuerto =" & txt_aeropuerto.Text & " AND s.tipo_servicio=" & cmb_tipoServicio.SelectedValue & " AND s.nombre= '" & txt_nombreservicio.Text & "'"
        tabla = Me._conex.leo_tabla(sql)
        If tabla.Rows.Count = 0 Then
            Return 0
        Else
            MsgBox("El servicio ya esta agregado al Aeropuerto")
            Return 1
        End If

    End Function
End Class