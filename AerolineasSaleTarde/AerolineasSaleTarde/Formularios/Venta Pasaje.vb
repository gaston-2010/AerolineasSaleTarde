Public Class Venta_Pasaje
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim _Pasaje As New Pasaje
    Dim _conex As New BD_TRANSACCIONAL
    Dim TE As New tratamientos_especiales


    Private Sub cargar_grilla()
        Dim sql As String = " SELECT pa.tipoDocumento as 'Tipo Documento' , pa.nroDocumento as 'Nº Documento'
          ,pa.nombre as 'Nombre' ,pa.apellido as 'Apellido', p.idVuelo as 'Nº Vuelo', p.tipoPasaje as 'Tipo de Pasaje', 
        p.atencion as 'Atencion Especial' , p.nroAsiento as 'Nº de Asiento', p.claseTurista as 'Clase'
            FROM Pasajero pa JOIN Pasaje p on pa.nroDocumento =p.nroDocumento 
            AND pa.tipoDocumento = p.tipoDocumento JOIN Vuelos v ON p.idVuelo = v.id_vuelo
            WHERE pa.tipoDocumento = " & cmb_tipoDocumento.SelectedValue & " AND pa.nroDocumento= " & txt_nroDocumento.Text & ""
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
        Me._Pasaje.tipoDocumento = Me.cmb_tipoDocumento.Text
        Me._Pasaje.nroDocumento = Me.txt_nroDocumento.Text
        Me._Pasaje.idVuelo = Me.cmb_vuelo.SelectedItem
        Dim numero As String = Me.cmb_tipoPasaje.SelectedIndex
        numero = numero.Substring(0, 1)
        Me._Pasaje.tipoPasaje = Convert.ToInt16(numero)
        If CheckBox1.Checked = True Then
            Me._Pasaje.atencion = 1
        Else
            Me._Pasaje.atencion = 0
        End If
        Me._Pasaje.nroAsiento = Me.txt_nroAsiento.Text
        If cmb_clase.SelectedItem = "Primera Clase" Then
            Me._Pasaje.claseTurista = 0
        Else
            Me._Pasaje.claseTurista = 1
        End If

    End Sub

    Private Sub cmd_Buscar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Function comprobarasiento()
        Dim tabla As New DataTable
        Dim clase As Integer
        If cmb_clase.SelectedItem = "Primera Clase" Then
            clase = 0
        Else
            clase = 1
        End If
        Dim sql As String = " SELECT * FROM Pasaje WHERE idVuelo = " & cmb_vuelo.SelectedValue & "
        AND nroAsiento =" & txt_nroAsiento.Text & " AND claseTurista= " & clase
        tabla = _conex.consultaATabla(sql)
        If tabla.Rows.Count = 0 Then
            Return 0
        Else
            Return 1
        End If
    End Function

    Private Sub Venta_Pasaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmd_Borrar.Enabled = False
        Me.cmb_tipoDocumento.cargar(Me._conex.consultaATabla("SELECT * FROM TipoDocumento") _
                            , "id", "nombre")
        Me.cmb_vuelo.DataSource = _conex.consultaATabla("SELECT id_vuelo FROM Vuelos")
        Me.TE.blanquear_objetos(Me)
        cmd_Borrar.BackColor = Color.Chocolate
        cmd_Buscar.BackColor = Color.Chocolate
        cmd_Nuevo.BackColor = Color.Chocolate
        cmd_Grabar.BackColor = Color.Chocolate
        Me.cmd_Grabar.Visible = False
        Me.txt_nroDocumento.Enabled = True
        Me.cmb_tipoDocumento.Enabled = True
    End Sub

    Private Sub cmd_Buscar_Click_1(sender As Object, e As EventArgs) Handles cmd_Buscar.Click
        If txt_nroDocumento.Text <> "" And cmb_tipoDocumento.SelectedIndex <> -1 Then
            Dim sql As String = " SELECT * FROM Pasajero WHERE tipoDocumento = " & cmb_tipoDocumento.SelectedValue & " AND nroDocumento= " & txt_nroDocumento.Text & ""

            Dim tabla As New DataTable
            tabla = Me._conex.consultaATabla(sql)
            If tabla.Rows.Count = 0 Then
                If MsgBox("El pasajero no esta registrado, Desea Registrar? ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                Else
                    ABM_Pasajero.ShowDialog()
                End If
            Else
                cargar_grilla()

                Me.txt_Apellido.Text = tabla.Rows(0)(4)
                Me.txt_nombre.Text = tabla.Rows(0)(3)

                Me.cmd_Grabar.Visible = True
                Me.cmd_Borrar.Enabled = True

                Me.txt_nroDocumento.Enabled = False
                Me.cmb_tipoDocumento.Enabled = False
                Me.cmd_Grabar.Enabled = True
            End If
        Else
            MsgBox("Ingrese el Documento a buscar")
            txt_nroDocumento.Focus()
        End If
    End Sub

    Private Sub cmd_Grabar_Click_1(sender As Object, e As EventArgs) Handles cmd_Grabar.Click
        If Me.cmd_Grabar.Text = "Grabar" Then
            control_estado_grabacion = estado_grabacion.insertar
        Else
            control_estado_grabacion = estado_grabacion.modificar
        End If
        If ValidarCampo(Me) = 1 Then
            If comprobarasiento() = 0 Then

                If control_estado_grabacion = estado_grabacion.insertar Then
                    transferir(Me)

                    Me._Pasaje.insertar()

                Else

                    transferir(Me)
                    Me._Pasaje.modificar()
                End If
                Me.cargar_grilla()
                cmd_Grabar.Visible = False
            Else
                MsgBox("El Asiento ya esta ocupado")
            End If
        End If
    End Sub

    Private Sub cmd_Nuevo_Click_1(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        Me.control_estado_grabacion = estado_grabacion.insertar
        Me.TE.blanquear_objetos(Me)
        Me.cmd_Grabar.Text = "Grabar"
        Me.cmd_Borrar.Enabled = False
        Me.cmb_tipoDocumento.cargar(Me._conex.consultaATabla("SELECT * FROM TipoDocumento") _
                            , "id", "nombre")
        Me.cmb_vuelo.cargar(Me._conex.consultaATabla("SELECT * FROM Vuelos") _
                            , "id_vuelo", "nombre")
        Me.cmd_Grabar.Visible = False
        Me.txt_nroDocumento.Enabled = True
        Me.cmb_tipoDocumento.Enabled = True
        Dim tabla As New DataTable
        DGV1.DataSource = tabla
    End Sub

    Private Sub cmd_Borrar_Click_1(sender As Object, e As EventArgs) Handles cmd_Borrar.Click
        Me._Pasaje.tipoDocumento = cmb_tipoDocumento.SelectedValue
        Me._Pasaje.nroDocumento = txt_nroDocumento.Text
        Me._Pasaje.idVuelo = cmb_vuelo.SelectedValue
        If MsgBox("DESEA ELIMINAR?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        Me._Pasaje.borrar()
        Me.TE.blanquear_objetos(Me)
        Me.cargar_grilla()
    End Sub

    Private Sub DGV1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellDoubleClick
        Me.control_estado_grabacion = estado_grabacion.modificar
        Me.cmd_Grabar.Text = "Modificar"
        Me.cmd_Borrar.Enabled = True
        Me.cmb_tipoDocumento.Text = DGV1.CurrentRow.Cells(0).Value
        Me.txt_nroDocumento.Text = DGV1.CurrentRow.Cells(1).Value
        Me.txt_nombre.Text = DGV1.CurrentRow.Cells(2).Value
        Me.txt_Apellido.Text = DGV1.CurrentRow.Cells(3).Value
        Me.cmb_vuelo.Text = DGV1.CurrentRow.Cells(4).Value
        Me.cmb_tipoPasaje.SelectedIndex = DGV1.CurrentRow.Cells(5).Value - 1
        If DGV1.CurrentRow.Cells(6).Value = 1 Then
            Me.CheckBox1.Checked = True
        Else
            Me.CheckBox1.Checked = False
        End If
        Me.txt_nroAsiento.Text = DGV1.CurrentRow.Cells(7).Value
        Me.cmb_clase.SelectedIndex = DGV1.CurrentRow.Cells(8).Value
        Me.txt_nroDocumento.Enabled = False
        Me.cmb_tipoDocumento.Enabled = False
    End Sub
End Class