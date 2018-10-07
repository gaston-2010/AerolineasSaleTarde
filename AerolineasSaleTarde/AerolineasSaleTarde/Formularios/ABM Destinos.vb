Public Class ABM_Destinos
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim _Destino As New Destino
    Dim _conex As New CONEXION_BD
    Dim TE As New tratamientos_especiales
    Dim cambio As Boolean = False

    Private Sub ABM_Avion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmd_Borrar.Enabled = False
        Me.txt_id.Visible = False
        Me.cargar_grilla()
        Me.cmb_Pais.cargar(Me._conex.leo_tabla("SELECT * FROM Pais") _
                            , "id", "nombre")
        Me.TE.blanquear_objetos(Me)
        Me.cmb_Localidad.Enabled = False
        Me.cmb_Provincia.Enabled = False
        cmd_Borrar.BackColor = Color.Chocolate
        cmd_Grabar.BackColor = Color.Chocolate
        cmd_Nuevo.BackColor = Color.Chocolate

    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        Me.control_estado_grabacion = estado_grabacion.insertar
        Me.TE.blanquear_objetos(Me)
        Me.cmd_Grabar.Text = "Grabar"
        Me.cmd_Borrar.Enabled = False
        Me.cmb_Localidad.Enabled = False
        Me.cmb_Provincia.Enabled = False
        Me.cmb_Pais.cargar(Me._conex.leo_tabla("SELECT * FROM Pais") _
                            , "id", "nombre")
        Me.cmd_Grabar.Visible = True

    End Sub

    Private Sub cargar_grilla()
        Me.DGV1.DataSource = Me._conex.leo_tabla("SELECT d.id as 'Nº Destino', d.id_localidad as 'Localidad', l.nombre as 'Nombre Localidad' FROM Destinos d join Localidad l on d.id_localidad = l.id")

    End Sub

    Private Sub cmd_grabar_Click(sender As Object, e As EventArgs) Handles cmd_Grabar.Click
        If Me.cmb_Pais.SelectedIndex = -1 Then
            MsgBox("El Pais Esta deseleccionado")
            Exit Sub

        End If
        If Me.cmb_Provincia.SelectedIndex = -1 Then
            MsgBox("La Provincia esta deseleccionada ")
            Exit Sub
        End If
        If Me.cmb_Localidad.SelectedIndex = -1 Then
            MsgBox("La Localidad esta deseleccionada ")

            Me._Destino.id_localidad = cmb_Localidad.SelectedValue
            Exit Sub
        End If
        If comprobarexistencia() = True Then


            If control_estado_grabacion = estado_grabacion.insertar Then
                Me._Destino.transferir(Me)
                Me._Destino.insertar()
            Else
                Me._Destino.id = Me.txt_id.Text
                Me._Destino.modificar()
            End If
        End If
        Me.cargar_grilla()
            Me.TE.blanquear_objetos(Me)

    End Sub

    Private Sub DGV1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellDoubleClick
        Me.txt_id.Text = DGV1.CurrentRow.Cells(0).Value
        Me.control_estado_grabacion = estado_grabacion.modificar
        Me.cmd_Grabar.Visible = False
        Me.cmd_Borrar.Enabled = True
        Me.cmb_Provincia.Enabled = True
        Me.cmb_Localidad.Enabled = True
        Me.cmb_Localidad.Text = DGV1.CurrentRow.Cells(2).Value
        Dim sql As String = "SELECT * FROM Provincia p JOIN localidad l ON l.id_provincia = p.id where l.nombre= '" & cmb_Localidad.Text & "'"
        Me.cmb_Provincia.cargar(Me._conex.leo_tabla(sql), "id", "nombre")
        Dim sql2 As String = "SELECT * FROM Pais p JOIN provincia pr ON pr.id_pais = p.id where pr.nombre= '" & cmb_Provincia.Text & "'"
        Me.cmb_Pais.cargar(Me._conex.leo_tabla(sql2), "id", "nombre")

    End Sub

    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_Borrar.Click
        Me._Destino.id = Me.txt_id.Text
        If MsgBox("DESEA ELIMINAR?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        Me._Destino.borrar()
        Me.TE.blanquear_objetos(Me)
        Me.cargar_grilla()
    End Sub

    Private Sub cmb_Provincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Provincia.SelectedIndexChanged

        Me.cmb_Localidad.Enabled = True
            Me.cmb_Localidad.SelectedIndex = -1
            Dim numero As Object = cmb_Provincia.SelectedValue
            If (TypeOf numero Is DataRowView) Then
                Exit Sub
            End If
            Dim nombre As String = Convert.ToString(numero)
            If nombre = "" Then
                Exit Sub
            End If
            Dim sql As String = "SELECT * FROM Localidad l JOIN Provincia p ON l.id_provincia = p.id where p.id=" & nombre & ""
            Me.cmb_Localidad.cargar(Me._conex.leo_tabla(sql), "id", "nombre")

    End Sub

    Private Sub cmb_Pais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Pais.SelectedIndexChanged

        Me.cmb_Provincia.SelectedIndex = -1
            cmb_Provincia.Enabled = True
            Dim numero As Object = cmb_Pais.SelectedValue
            If (TypeOf numero Is DataRowView) Then
                Exit Sub
            End If
            Dim nombre As String = Convert.ToString(numero)
            If nombre = "" Then
                Exit Sub
            End If
            Dim Sql As String = "Select * FROM Provincia p JOIN Pais pa On p.id_pais = pa.id where pa.id = " & nombre
            Me.cmb_Provincia.cargar(Me._conex.leo_tabla(Sql), "id", "nombre")

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
