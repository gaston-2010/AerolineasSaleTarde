Public Class Venta_Pasajes
    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim _Pasajero As New Pasajero
    Dim _Dom As New Domicilio
    Dim _Pasaje As New Pasaje
    Dim _conex As New BD_TRANSACCIONAL
    Dim TE As New tratamientos_especiales



    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs)
        Me.control_estado_grabacion = estado_grabacion.insertar
        Me.TE.blanquear_objetos(Me)
        Me.cmd_Grabar.Text = "Grabar"
        Me.cmd_Borrar.Enabled = False
        Me.cmb_tipoDocumento.cargar(Me._conex.consultaATabla("SELECT * FROM TipoDocumento") _
                            , "id", "nombre")
        Me.cmb_Pais.cargar(Me._conex.consultaATabla("SELECT * FROM Pais") _
                            , "id", "nombre")
        Me.cmd_Grabar.Visible = False
        Me.txt_nroDocumento.Enabled = True
        Me.cmb_tipoDocumento.Enabled = True
        Dim tabla As New DataTable
        DGV1.DataSource = tabla
    End Sub

    Private Sub cargar_grilla()
        Dim sql As String = " SELECT pa.tipoDocumento as 'Tipo Documento' , pa.nroDocumento as 'Nº Documento'
          ,pa.nombre as 'Nombre' ,pa.apellido as 'Apellido',pa.nacionalidad as 'Nacionalidad',pa.sexo as 'Sexo' 
           ,pa.calle as 'Calle',pa.nroCalle as 'Nº Calle',p.nombre as 'Pais' ,do.dpto as 'Departamento'
           ,do.localidad as 'Localidad' ,pa.motivo as 'Motivo Viaje' FROM Pasajero pa 
            JOIN domicilio do ON pa.calle = do.calle AND pa.nroCalle = do.nroCalle AND pa.id_localidad = do.localidad 
            JOIN Pais p on p.id=do.pais
            WHERE pa.tipoDocumento = " & cmb_tipoDocumento.SelectedValue & " AND pa.nroDocumento= " & txt_nroDocumento.Text & ""
        Me.DGV1.DataSource = Me._conex.consultaATabla(sql)

    End Sub


    Private Sub DGV1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

        Me.control_estado_grabacion = estado_grabacion.modificar
        Me.cmd_Grabar.Text = "Modificar"
        Me.cmd_Borrar.Enabled = True
        Me.cmb_tipoDocumento.Text = DGV1.CurrentRow.Cells(0).Value
        Me.txt_nroDocumento.Text = DGV1.CurrentRow.Cells(1).Value
        Me.txt_nombre.Text = DGV1.CurrentRow.Cells(2).Value
        Me.txt_Apellido.Text = DGV1.CurrentRow.Cells(3).Value
        Me.txt_nacionalidad.Text = DGV1.CurrentRow.Cells(4).Value
        Me.cmb_sexo.Text = DGV1.CurrentRow.Cells(5).Value
        Me.txt_calle.Text = DGV1.CurrentRow.Cells(6).Value
        Me.txt_nroCalle.Text = DGV1.CurrentRow.Cells(7).Value
        Me.cmb_Pais.Text = DGV1.CurrentRow.Cells(8).Value
        Me.txt_departamento.Text = DGV1.CurrentRow.Cells(9).Value
        Me.cmb_localidad.SelectedValue = DGV1.CurrentRow.Cells(10).Value
        Me.cmb_motivo.Text = DGV1.CurrentRow.Cells(11).Value
        Me.txt_nroDocumento.Enabled = False
        Me.cmb_tipoDocumento.Enabled = False
    End Sub

    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs)
        Me._Pasajero.tipoDocumento = cmb_tipoDocumento.SelectedValue
        Me._Pasajero.nroDocumento = txt_nroDocumento.Text
        If MsgBox("DESEA ELIMINAR?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        Me._Pasajero.borrar()
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
        Me._Pasajero.nroDocumento = txt_nroDocumento.Text
        Me._Pasajero.tipoDocumento = cmb_tipoDocumento.SelectedValue
        Me._Pasajero.nacionalidad = txt_nacionalidad.Text
        Me._Pasajero.nombre = txt_nombre.Text.Trim()
        Me._Pasajero.apellido = txt_Apellido.Text.Trim()
        Me._Pasajero.sexo = cmb_sexo.SelectedItem
        Me._Pasajero.calle = txt_calle.Text.Trim
        Me._Pasajero.motivo = cmb_motivo.SelectedItem
        Me._Pasajero.nroCalle = txt_nroCalle.Text
        Me._Pasajero.id_localidad = cmb_localidad.SelectedValue
        Me._Dom.calle = txt_calle.Text.Trim
        Me._Dom.nroCalle = txt_nroCalle.Text
        Me._Dom.dpto = txt_departamento.Text
        Me._Dom.pais = cmb_Pais.SelectedValue
        Me._Dom.localidad = cmb_localidad.SelectedValue
        Me._Pasaje.tipoDocumento = Me.cmb_tipoDocumento.Text
        Me._Pasaje.nroDocumento = Me.txt_nroDocumento.Text
        Me._Pasaje.idVuelo = Me.txt_vuelo.Text
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
        If txt_nroDocumento.Text <> "" And cmb_tipoDocumento.SelectedIndex <> -1 Then
            Dim sql As String = " SELECT pa.tipoDocumento as 'Tipo Documento' , pa.nroDocumento as 'Nº Documento'
          ,pa.nombre as 'Nombre' ,pa.apellido as 'Apellido',pa.nacionalidad as 'Nacionalidad',pa.sexo as 'Sexo' 
           ,pa.calle as 'Calle',pa.nroCalle as 'Nº Calle',p.nombre as 'Pais' ,do.dpto as 'Departamento'
           ,do.localidad as 'Localidad' ,pa.motivo as 'Motivo Viaje' FROM Pasajero pa 
            JOIN domicilio do ON pa.calle = do.calle AND pa.nroCalle = do.nroCalle AND pa.id_localidad = do.localidad 
            JOIN Pais p on p.id=do.pais
            WHERE pa.tipoDocumento = " & cmb_tipoDocumento.SelectedValue & " AND pa.nroDocumento= " & txt_nroDocumento.Text & ""

            Dim tabla As New DataTable
            tabla = Me._conex.consultaATabla(sql)
            If tabla.Rows.Count = 0 Then
                Me.cmd_Grabar.Visible = True
                Exit Sub
            Else
                Me.DGV1.DataSource = Me._conex.consultaATabla(sql)
                Me.cmd_Grabar.Visible = True
                Me.control_estado_grabacion = estado_grabacion.modificar
                Me.cmd_Grabar.Text = "Modificar"
                Me.cmd_Borrar.Enabled = True
                Me.cmb_tipoDocumento.Text = DGV1.CurrentRow.Cells(0).Value
                Me.txt_nroDocumento.Text = DGV1.CurrentRow.Cells(1).Value
                Me.txt_nombre.Text = DGV1.CurrentRow.Cells(2).Value
                Me.txt_Apellido.Text = DGV1.CurrentRow.Cells(3).Value
                Me.txt_nacionalidad.Text = DGV1.CurrentRow.Cells(4).Value
                Me.cmb_sexo.Text = DGV1.CurrentRow.Cells(5).Value
                Me.txt_calle.Text = DGV1.CurrentRow.Cells(6).Value
                Me.txt_nroCalle.Text = DGV1.CurrentRow.Cells(7).Value
                Me.cmb_Pais.Text = DGV1.CurrentRow.Cells(8).Value
                Me.txt_departamento.Text = DGV1.CurrentRow.Cells(9).Value
                Me.cmb_localidad.SelectedValue = DGV1.CurrentRow.Cells(10).Value
                Me.cmb_motivo.Text = DGV1.CurrentRow.Cells(11).Value
                Me.txt_nroDocumento.Enabled = False
                Me.cmb_tipoDocumento.Enabled = False
                Me.cmd_Grabar.Enabled = True
            End If
        Else
            MsgBox("Ingrese el Documento a buscar")
            txt_nroDocumento.Focus()
        End If
    End Sub

    Private Sub cmb_Pais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Pais.SelectedIndexChanged

        Me.cmb_localidad.SelectedIndex = -1
        Dim numero As Object = cmb_Pais.SelectedValue
        If (TypeOf numero Is DataRowView) Then
            Exit Sub
        End If
        Dim nombre As String = Convert.ToString(numero)
        If nombre = "" Then
            Exit Sub
        End If
        Dim Sql As String = "SELECT * FROM Localidad l JOIN Provincia p ON l.id_provincia = p.id where p.id_pais = " & nombre
        Me.cmb_localidad.cargar(Me._conex.consultaATabla(Sql), "id", "nombre")

    End Sub

    Private Sub comprobardomicilio()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT nroCalle,calle,localidad FROM Domicilio where nroCalle = " & txt_nroCalle.Text & " 
        AND calle= '" & txt_calle.Text & "' AND localidad = " & cmb_localidad.SelectedValue
        tabla = Me._conex.consultaATabla(sql)
        If tabla.Rows.Count() = 0 Then
            Me._Dom.insertar()
        Else
            Me._Dom.modificar()
        End If


    End Sub

    Private Sub Venta_Pasajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_origen.cargar(Me._conex.consultaATabla("select l.nombre from vuelos v join Aeropuertos a on v.idAeropuertoOrigen = a.id join Localidad l on a.id_localidad = l.id "))
        Me.cmb_destino.cargar(Me._conex.consultaATabla("select l.nombre from vuelos v join Aeropuertos a on v.idAeropuertoDestino = a.id join Localidad l on a.id_localidad = l.id "))
        Me.cmd_Borrar.Enabled = False
        Me.cmb_tipoDocumento.cargar(Me._conex.consultaATabla("SELECT * FROM TipoDocumento") _
                            , "id", "nombre")
        Me.cmb_Pais.cargar(Me._conex.consultaATabla("SELECT * FROM Pais") _
                            , "id", "nombre")
        Me.TE.blanquear_objetos(Me)
        cmd_Borrar.BackColor = Color.Chocolate

        cmd_Nuevo.BackColor = Color.Chocolate
        cmd_Grabar.BackColor = Color.Chocolate
        Me.cmd_Grabar.Visible = False
        Me.txt_nroDocumento.Enabled = True
        Me.cmb_tipoDocumento.Enabled = True

    End Sub

    Private Sub btn_buscarVuelo_Click(sender As Object, e As EventArgs) Handles btn_buscarVuelo.Click
        If cmb_origen.SelectedIndex <> -1 And cmb_destino.SelectedIndex <> -1 And txt_fecha.Text <> "" Then
            Dim sql As String = " SELECT * from Vuelos v Where idAereopuertoOrigen = " & cmb_destino.SelectedValue & "and id AeropuertoDestino = " & cmb_destino.SelectedValue & "And " & txt_fecha.Text & " BETWEEN  v.fechaSalida AND v.fechaLlegada"
            Dim tabla As New DataTable
            tabla = Me._conex.consultaATabla(sql)
            If tabla.Rows.Count = 0 Then
                MsgBox("No hay vuelos disponibles para esa fecha")
            Else
                Panel2.Enabled = True
                txt_vuelo = tabla.Rows(0).Item(0)
            End If
        Else
            MsgBox("Falta un dato")
        End If
    End Sub

    Private Sub cmd_Grabar_Click(sender As Object, e As EventArgs) Handles cmd_Grabar.Click
        Dim row As String() = New String() {txt_nombre.Text, txt_Apellido.Text, cmb_tipoDocumento.Text, txt_nroDocumento.Text, txt_nacionalidad.Text, cmb_sexo.Text, txt_calle.Text, txt_nroCalle.Text}
        DGV1.Rows.Add(row)
    End Sub

    Private Function comprobarasiento()
        Dim tabla As New DataTable
        Dim clase As Integer
        If cmb_clase.SelectedItem = "Primera Clase" Then
            clase = 0
        Else
            clase = 1
        End If
        Dim sql As String = " SELECT * FROM Pasaje WHERE idVuelo = " & txt_vuelo.Text & "
        AND nroAsiento =" & txt_nroAsiento.Text & " AND claseTurista= " & clase
        tabla = _conex.consultaATabla(sql)
        If tabla.Rows.Count = 0 Then
            Return 0
        Else
            Return 1
        End If
    End Function

    Private Sub btn_comprar_Click(sender As Object, e As EventArgs) Handles btn_comprar.Click
        
        If ValidarCampo(Me) = 1 Then
            If comprobarasiento() = 0 Then
                transferir(Me)
                Me._Pasaje.insertar()
                Me._Dom.insertar()
                Me._Pasajero.insertar()
            End If

        Else
                MsgBox("El Asiento ya esta ocupado")
            End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class