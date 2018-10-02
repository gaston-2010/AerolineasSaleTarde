Public Class ABM_PersonalxAeropuerto

    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim _PersonalxAero As New PersonalxAeropuerto
    Dim _conex As New CONEXION_BD
    Dim TE As New tratamientos_especiales

    Private Sub cmd_Buscar_Click(sender As Object, e As EventArgs) Handles cmd_Buscar.Click
        If txt_Legajo.Text <> "" Then
            Dim tabla As New DataTable
            Dim sql As String = "SELECT [legajo] ,[id_vuelo] ,[id_puesto] From PersonalxVuelo where legajo=" & txt_Legajo.Text
            tabla = Me._conex.leo_tabla(sql)
            If tabla.Rows.Count = 0 Then
                MsgBox("Empleado No Encontrado")
                txt_nombre.Enabled = False
                txt_apellido.Enabled = False
                Me.TE.blanquear_objetos(Me)
            Else
                Me.DGV1.DataSource = Me._conex.leo_tabla(sql)
                txt_nombre.Enabled = True
                txt_apellido.Enabled = True
                rellenar(Me, txt_Legajo.Text)

            End If
        Else
            MsgBox("Ingrese el Legajo a buscar")
            txt_Legajo.Focus()
        End If
    End Sub

    Private Sub ABM_Avion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmd_Borrar.Enabled = False
        txt_nombre.Enabled = False
        txt_apellido.Enabled = False
        Me.cmb_avion.cargar(Me._conex.leo_tabla("SELECT * FROM Vuelos") _
                            , "id_vuelo", "nombre")
        Me.cmb_puesto.cargar(Me._conex.leo_tabla("SELECT * FROM [MicrosoftAccount\maximilianoalbert@hotmail.com].[Puesto]") _
                            , "id_puesto", "nombre")
        Me.TE.blanquear_objetos(Me)

    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        Me.control_estado_grabacion = estado_grabacion.insertar
        Me.cmd_Borrar.Enabled = False
        Me.cmd_Grabar.Text = "Grabar"
        Me.cmd_Borrar.Enabled = False
        Me.cmb_avion.cargar(Me._conex.leo_tabla("SELECT * FROM Vuelos") _
                            , "id_vuelo", "nombre")
        Me.cmb_puesto.cargar(Me._conex.leo_tabla("SELECT * FROM [MicrosoftAccount\maximilianoalbert@hotmail.com].[Puesto]") _
                            , "id_puesto", "nombre")
        Me.TE.blanquear_objetos(Me)
        Me.cmd_Grabar.Visible = True

    End Sub

    Private Sub cargar_grilla()
        Dim sql As String = "SELECT * FROM PersonalxVuelo"
        Me.DGV1.DataSource = Me._conex.leo_tabla(sql)

    End Sub

    Private Sub cmd_grabar_Click(sender As Object, e As EventArgs) Handles cmd_Grabar.Click

        If ValidarCampo(Me) = 1 Then

            If comprobarexistencia() = 0 Then
                If control_estado_grabacion = estado_grabacion.insertar Then
                    transferir(Me)
                    Me._PersonalxAero.insertar()
                Else
                    Me._PersonalxAero.legajo = Me.txt_Legajo.Text
                    transferir(Me)
                    Me._PersonalxAero.modificar()
                End If
                Me.TE.blanquear_objetos(Me)
            End If
        End If
    End Sub

    Private Sub DGV1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellDoubleClick
        Me.txt_Legajo.Text = DGV1.CurrentRow.Cells(0).Value
        Me.control_estado_grabacion = estado_grabacion.modificar
        Me.cmd_Grabar.Text = "Modificar"
        Me.cmd_Borrar.Enabled = True
        Me.cmb_puesto.SelectedValue = DGV1.CurrentRow.Cells(2).Value
        Me.cmb_avion.SelectedValue = DGV1.CurrentRow.Cells(1).Value

    End Sub

    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_Borrar.Click
        Me._PersonalxAero.legajo = Me.txt_Legajo.Text
        Me._PersonalxAero.id_puesto = Me.cmb_puesto.SelectedValue
        Me._PersonalxAero.id_vuelo = Me.cmb_avion.SelectedValue
        If MsgBox("DESEA ELIMINAR?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        Me._PersonalxAero.borrar()
        Me.TE.blanquear_objetos(Me)
        Me.cargar_grilla()
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
        Me._PersonalxAero.legajo = Me.txt_Legajo.Text
        Me._PersonalxAero.id_vuelo = Me.cmb_avion.SelectedValue
        Me._PersonalxAero.id_puesto = Me.cmb_puesto.SelectedValue
    End Sub
    Private Sub rellenar(ByRef sender As Object, ByVal legajo As Integer)
        Dim tabla As New DataTable
        Dim sql As String = "SELECT e.apellido,e.nombre From PersonalxVuelo p join Personal e on p.legajo=e.legajo where e.legajo=" & legajo
        tabla = Me._conex.leo_tabla(sql)
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            Me.txt_apellido.Text = tabla.Rows(c)(0)
            Me.txt_nombre.Text = tabla.Rows(c)(1)
        Next

    End Sub
    Public Function comprobarexistencia()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT [legajo] ,[id_vuelo] ,[id_puesto] From PersonalxVuelo where legajo=" & txt_Legajo.Text & "AND id_vuelo =" & cmb_avion.SelectedValue
        tabla = Me._conex.leo_tabla(sql)
        If tabla.Rows.Count = 0 Then
            Return 0
        Else
            MsgBox("El Empleado ya tiene un puesto en ese vuelo")
            Return 1
        End If

    End Function

End Class