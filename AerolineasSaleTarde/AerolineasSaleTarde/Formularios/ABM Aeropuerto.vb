Public Class ABM_Aeropuerto
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim _Aero As New Aeropuerto
    Dim _conex As New BD_TRANSACCIONAL
    Dim TE As New tratamientos_especiales


    Private Sub cargar_grilla()
        Dim sql As String = "SELECT id as 'Nº Aeropuerto' ,nombre as 'Nombre', [cabotaje/internacional], cantidadPuertasEmbarque as
        'Cantidad de Puertas de Embarque', salaVip as 'Cantidad de Salas Vips', salaFumadores as 'Cantidad de Salas de Fumadores' 
           , id_Localidad FROM Aeropuertos "
        Me.DGV1.DataSource = Me._conex.consultaATabla(sql)

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
        If txt_id.Text <> "" Then
            Me._Aero.id = txt_id.Text
        End If

        Me._Aero.nombre = txt_Nombre.Text
        If txt_salaFumadores.Text <> "" Then
            Me._Aero.salaFumadores = txt_salaFumadores.Text
        Else
            Me._Aero.salaFumadores = 0
        End If
        Me._Aero.cabotaje_internacional = Me.cmb_cabotaje.SelectedIndex + 1
        If txt_salaVip.Text <> "" Then
            Me._Aero.salaVip = txt_salaVip.Text
        Else
            Me._Aero.salaVip = 0
        End If
        Me._Aero.cantidadPuertasEmbarque = Me.txt_puertasembarque.Text
        Me._Aero.id_localidad = Me.cmb_localidad.SelectedValue
    End Sub



    Private Sub ABM_Aeropuerto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmd_Borrar.Enabled = False
        Me.cmb_localidad.cargar(Me._conex.consultaATabla("SELECT * FROM Localidad") _
                            , "id", "nombre")

        Me.TE.blanquear_objetos(Me)
        cmd_Borrar.BackColor = Color.Chocolate
        cmd_Nuevo.BackColor = Color.Chocolate
        cmd_Grabar.BackColor = Color.Chocolate
        cargar_grilla()
        txt_id.Visible = False

    End Sub

    Private Sub cmd_Grabar_Click_1(sender As Object, e As EventArgs) Handles cmd_Grabar.Click
        If Me.cmd_Grabar.Text = "Grabar" Then
            control_estado_grabacion = estado_grabacion.insertar
        Else
            control_estado_grabacion = estado_grabacion.modificar
        End If
        If ValidarCampo(Me) = 1 Then


            If control_estado_grabacion = estado_grabacion.insertar Then
                    transferir(Me)

                Me._Aero.insertar()

            Else

                    transferir(Me)
                Me._Aero.modificar()
            End If
                Me.cargar_grilla()
                cmd_Grabar.Visible = False

        End If

    End Sub

    Private Sub cmd_Nuevo_Click_1(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        Me.control_estado_grabacion = estado_grabacion.insertar
        Me.TE.blanquear_objetos(Me)
        Me.cmd_Grabar.Text = "Grabar"
        Me.cmd_Borrar.Enabled = False
        Me.cmb_localidad.cargar(Me._conex.consultaATabla("SELECT * FROM Localidad") _
                            , "id", "nombre")
        Dim tabla As New DataTable
        DGV1.DataSource = tabla
    End Sub

    Private Sub cmd_Borrar_Click_1(sender As Object, e As EventArgs) Handles cmd_Borrar.Click
        Me._Aero.id = txt_id.Text
        If MsgBox("DESEA ELIMINAR?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        Me._Aero.borrar()
        Me.TE.blanquear_objetos(Me)
        Me.cargar_grilla()
    End Sub

    Private Sub DGV1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellDoubleClick
        Me.control_estado_grabacion = estado_grabacion.modificar
        Me.cmd_Grabar.Text = "Modificar"
        Me.cmd_Borrar.Enabled = True
        Me.txt_id.Text = DGV1.CurrentRow.Cells(0).Value
        Me.txt_Nombre.Text = DGV1.CurrentRow.Cells(1).Value
        Me.cmb_cabotaje.SelectedIndex = DGV1.CurrentRow.Cells(2).Value - 1
        Me.txt_puertasembarque.Text = DGV1.CurrentRow.Cells(3).Value
        Me.txt_salaFumadores.Text = DGV1.CurrentRow.Cells(4).Value
        Me.txt_salaVip.Text = DGV1.CurrentRow.Cells(5).Value
        Me.cmb_localidad.SelectedValue = DGV1.CurrentRow.Cells(6).Value
        Me.cmd_Grabar.Visible = True

    End Sub
End Class