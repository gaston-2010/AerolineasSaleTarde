Public Class ABM_Avion

    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim _avion As New Avion
    Dim _conex As New CONEXION_BD
    Dim TE As New tratamientos_especiales

    Private Sub ABM_Avion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmd_borrar.Enabled = False
        Me.txt_id.Visible = False
        Me.cargar_grilla()
        Me.cmb_tipoavion.cargar(Me._conex.leo_tabla("SELECT * FROM TipoAvion") _
                             , "id_tipoAvion", "nombre")

    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.control_estado_grabacion = estado_grabacion.insertar
        Me.TE.blanquear_objetos(Me)
        Me.cmd_grabar.Text = "Grabar"
        Me.cmd_borrar.Enabled = False
    End Sub

    Private Sub cargar_grilla()
        Me.DGV1.DataSource = Me._conex.leo_tabla("SELECT * FROM Aviones")
    End Sub

    Private Sub cmd_grabar_Click(sender As Object, e As EventArgs) Handles cmd_grabar.Click
        If Me.txt_nombre.Text = "" Then
            MsgBox("El Nombre esta vacio")
            Exit Sub
        Else
            Me._avion.nombre = Me.txt_nombre.Text
        End If
        If Me.cmb_tipoavion.SelectedIndex = -1 Then
            MsgBox("El Tipo de Avion no está seleccionado ")
            Exit Sub
        Else
            Me._avion.id_TipoAvion = Me.cmb_tipoavion.SelectedValue
        End If

        If control_estado_grabacion = estado_grabacion.insertar Then

            Me._avion.insertar()
        Else
            Me._avion.id = Me.txt_id.Text
            Me._avion.modificar()
        End If
        Me.cargar_grilla()
        Me.TE.blanquear_objetos(Me)

    End Sub

    Private Sub DGV1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellDoubleClick
        Me.txt_id.Text = DGV1.CurrentRow.Cells(0).Value
        Me.txt_nombre.Text = DGV1.CurrentRow.Cells(1).Value
        Me.cmb_tipoavion.SelectedValue = DGV1.CurrentRow.Cells(2).Value
        Me.control_estado_grabacion = estado_grabacion.modificar
        Me.cmd_grabar.Text = "Modificar"
        Me.cmd_borrar.Enabled = True
    End Sub

    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_borrar.Click
        Me._avion.id = Me.txt_id.Text
        If MsgBox("DESEA ELIMINAR?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        Me._avion.borrar()

        Me.cargar_grilla()
    End Sub


End Class