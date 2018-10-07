Public Class ABM_Personal
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim _Personal As New Personal
    Dim _conex As New CONEXION_BD
    Dim TE As New tratamientos_especiales

    Private Sub ABM_Avion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmd_Borrar.Enabled = False
        Me.txt_legajo.Visible = False
        Me.cargar_grilla()
        Me.cmb_aeropuerto.cargar(Me._conex.leo_tabla("SELECT * FROM Aeropuertos") _
                            , "id", "nombre")
        Me.TE.blanquear_objetos(Me)
        cmd_Borrar.BackColor = Color.Chocolate
        cmd_Buscar.BackColor = Color.Chocolate
        cmd_Nuevo.BackColor = Color.Chocolate
        cmd_Grabar.BackColor = Color.Chocolate


    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        Me.control_estado_grabacion = estado_grabacion.insertar
        Me.TE.blanquear_objetos(Me)
        Me.cmd_Grabar.Text = "Grabar"
        Me.cmd_Borrar.Enabled = False
        Me.cmb_aeropuerto.cargar(Me._conex.leo_tabla("SELECT * FROM Aeropuertos") _
                            , "id", "nombre")
        Me.cmd_Grabar.Visible = True

    End Sub

    Private Sub cargar_grilla()
        Dim sql As String = "SELECT p.legajo as 'Legajo',p.apellido as 'Apellido', p.nombre as 'Nombre', p.celular, p.mail, FORMAT(p.fechaIngreso ,'dd/MM/yyyy ') as ' Fecha de Ingreso',FORMAT(p.fechaNacimiento ,'dd/MM/yyyy ') as ' Fecha de Nacimiento',
                               a.nombre as 'Aeropuerto' FROM Personal p join Aeropuertos a on p.id_aeropuerto = a.id "
        Me.DGV1.DataSource = Me._conex.leo_tabla(sql)

    End Sub

    Private Sub cmd_grabar_Click(sender As Object, e As EventArgs) Handles cmd_Grabar.Click

        If ValidarCampo(Me) = 1 Then


            If control_estado_grabacion = estado_grabacion.insertar Then
                transferir(Me)
                Me._Personal.insertar()
            Else
                Me._Personal.legajo = Me.txt_legajo.Text
                transferir(Me)
                Me._Personal.modificar()
            End If
            Me.cargar_grilla()
            Me.TE.blanquear_objetos(Me)
        End If
    End Sub

    Private Sub DGV1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellDoubleClick
        Me.txt_legajo.Text = DGV1.CurrentRow.Cells(0).Value
        Me.control_estado_grabacion = estado_grabacion.modificar
        Me.cmd_Grabar.Text = "Modificar"
        Me.cmd_Borrar.Enabled = True
        Me.txt_apellido.Text = DGV1.CurrentRow.Cells(1).Value
        Me.txt_nombre.Text = DGV1.CurrentRow.Cells(2).Value
        Me.txt_celular.Text = DGV1.CurrentRow.Cells(3).Value
        Me.txt_mail.Text = DGV1.CurrentRow.Cells(4).Value
        Me.txt_fechaingreso.Text = DGV1.CurrentRow.Cells(5).Value
        Me.txt_fechanacimiento.Text = DGV1.CurrentRow.Cells(6).Value
        Me.cmb_aeropuerto.Text = DGV1.CurrentRow.Cells(7).Value
    End Sub

    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_Borrar.Click
        Me._Personal.legajo = Me.txt_legajo.Text
        If MsgBox("DESEA ELIMINAR?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        Me._Personal.borrar()
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
        Me._Personal.apellido = Me.txt_apellido.Text.Trim()
        Me._Personal.nombre = Me.txt_nombre.Text.Trim()
        Me._Personal.celular = Me.txt_celular.Text
        Me._Personal.mail = Me.txt_mail.Text.Trim()
        Me._Personal.fechaIngreso = Me.txt_fechaingreso.Text.Trim()
        Me._Personal.id_Aeropuerto = Me.cmb_aeropuerto.SelectedValue
        Me._Personal.fechaNacimiento = Me.txt_fechanacimiento.Text.Trim()
    End Sub

    Private Sub cmd_Buscar_Click(sender As Object, e As EventArgs) Handles cmd_Buscar.Click
        If txt_legajoBuscar.Text <> "" Then
            Dim sql As String = "SELECT p.legajo,p.apellido, p.nombre, p.celular, p.mail, p.fechaIngreso, p.id_Aeropuerto,p.fechaNacimiento,
                               a.nombre as 'Aeropuerto' FROM Personal p join Aeropuertos a on p.id_aeropuerto = a.id where p.legajo =" & txt_legajoBuscar.Text
            Me.DGV1.DataSource = Me._conex.leo_tabla(sql)
        Else
            MsgBox("Ingrese el Legajo a buscar")
            txt_legajoBuscar.Focus()
        End if
    End Sub
End Class