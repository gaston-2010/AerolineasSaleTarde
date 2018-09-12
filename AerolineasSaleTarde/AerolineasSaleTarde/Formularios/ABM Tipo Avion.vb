Public Class ABM_TipoAvion

    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim _tipoavion As New Tipo_Avion
    Dim _conex As New CONEXION_BD
    Dim TE As New tratamientos_especiales

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmd_borrar.Enabled = False
        Me.txt_id_tipoAvion.Visible = False
        Me.cargar_grilla()

    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.control_estado_grabacion = estado_grabacion.insertar
        Me.TE.blanquear_objetos(Me)
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_borrar.Enabled = False

    End Sub


    Private Sub cargar_grilla()
        Me.DGV1.DataSource = Me._conex.leo_tabla("SELECT * FROM TipoAvion")
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        Me._tipoavion.validarcampo(Me)
        If Me._tipoavion.validado = False Then
            Exit Sub
        End If
        Me._tipoavion.transferir(Me)

        If control_estado_grabacion = estado_grabacion.insertar Then

            Me._tipoavion.insertar()
        Else
            Me._tipoavion.id_tipoAvion = Me.txt_id_tipoAvion.Text
            Me._tipoavion.modificar()
        End If
        Me.cargar_grilla()
    End Sub

    Private Sub DGV1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellDoubleClick
        Me.txt_id_tipoAvion.Text = DGV1.CurrentRow.Cells(0).Value
        Me.txt_nombre.Text = DGV1.CurrentRow.Cells(1).Value
        Me.txt_capPasAlta.Text = DGV1.CurrentRow.Cells(2).Value
        Me.txt_capPasClasTur.Text = DGV1.CurrentRow.Cells(3).Value
        Me.txt_capacidadKg.Text = DGV1.CurrentRow.Cells(4).Value
        Me.txt_cantsalidas.Text = DGV1.CurrentRow.Cells(5).Value
        Me.txt_longitud.Text = DGV1.CurrentRow.Cells(6).Value
        Me.cmb_alcance.SelectedItem = DGV1.CurrentRow.Cells(6).Value
        Me.control_estado_grabacion = estado_grabacion.modificar
        Me.cmd_guardar.Text = "Modificar"
        Me.cmd_borrar.Enabled = True
    End Sub

    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_borrar.Click
        Me._tipoavion.id_tipoAvion = Me.txt_id_tipoAvion.Text
        If MsgBox("DESEA ELIMINAR?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.No Then
            Exit Sub

        End If
        Me._tipoavion.borrar()


        Me.cargar_grilla()
    End Sub
End Class

