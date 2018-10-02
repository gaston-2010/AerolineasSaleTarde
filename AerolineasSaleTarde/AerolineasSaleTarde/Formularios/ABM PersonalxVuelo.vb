Public Class ABM_PersonalxVuelo
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim _personaxvuelo As New PersonalxVuelo
    Dim _conex As New CONEXION_BD
    Dim TE As New tratamientos_especiales

    Private Sub ABM_Avion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmd_Borrar.Enabled = False
        Me.cargar_grilla()
        Me.cmb_avion.cargar(Me._conex.leo_tabla("SELECT * FROM Aviones") _
                             , "id", "nombre")
        Me.cmb_puesto.cargar(Me._conex.leo_tabla("SELECT * FROM Puesto") _
                             , "id", "nombre")
        Me.txt_apellido.Enabled = False
        Me.txt_nombre.Enabled = False
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        Me.control_estado_grabacion = estado_grabacion.insertar
        Me.TE.blanquear_objetos(Me)
        Me.cmd_Grabar.Text = "Grabar"
        Me.cmd_Borrar.Enabled = False
        Me.txt_apellido.Enabled = False
        Me.txt_nombre.Enabled = False
    End Sub

    Private Sub cargar_grilla()
        Me.DGV1.DataSource = Me._conex.leo_tabla("SELECT * from PersonalxVuelo")
    End Sub

    Private Sub cmd_grabar_Click(sender As Object, e As EventArgs) Handles cmd_Grabar.Click
        If txt_legajo.Text <> "" Then


            If control_estado_grabacion = estado_grabacion.insertar Then

                Me._avion.insertar()
            Else
                Me._avion.id = Me.txt_id.Text
                Me._avion.modificar()
            End If
            Me.cargar_grilla()
            Me.TE.blanquear_objetos(Me)
        Else
            MsgBox("El Legajo esta vacio")
        End If

    End Sub

    Private Sub DGV1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellDoubleClick
        Me.txt_id.Text = DGV1.CurrentRow.Cells(0).Value
        Me.txt_nombre.Text = DGV1.CurrentRow.Cells(1).Value
        Me.cmb_tipoavion.SelectedValue = DGV1.CurrentRow.Cells(2).Value
        Me.control_estado_grabacion = estado_grabacion.modificar
        Me.cmd_Grabar.Text = "Modificar"
        Me.cmd_Borrar.Enabled = True
    End Sub

    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_Borrar.Click
        Me._avion.id = Me.txt_id.Text
        If MsgBox("DESEA ELIMINAR?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        Me._avion.borrar()
        Me.TE.blanquear_objetos(Me)
        Me.cargar_grilla()
    End Sub

    Private Function comprobarexistencia()
        If control_estado_grabacion = estado_grabacion.insertar Then
            Dim tabla As New DataTable
            Dim numero As Object = cmb_Localidad.SelectedValue
            If (TypeOf numero Is DataRowView) Then
                Exit Function

            End If
            Dim nombre As String = Convert.ToString(numero)
            Dim Sql As String = "Select * from Destinos d join localidad l on d.id_localidad=l.id where l.id =" & nombre
            tabla = Me._conex.leo_tabla(Sql)
            If tabla.Rows.Count <> 0 Then
                MsgBox("El Destino ya esta creado")
                Return False
            End If
            Return True
        Else
            Return True
        End If

    End Function
End Class