Public Class Embarque

    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim _Embar As New Embarquec
    Dim _conex As New BD_TRANSACCIONAL
    Dim _detalle As New Detalle_Embarques
    Dim TE As New tratamientos_especiales
    Dim vuelo As Integer = 0
    Dim lista(0) As Integer
    Dim capacidad As Integer = 0
    Private Sub Embarque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_abordo.Items.Add("Abordo")
        cmb_abordo.Items.Add("Bodega")
        cmb_Tdni.cargar(_conex.consultaATabla("SELECT * FROM TipoDocumento"), "id", "nombre")
        btn_embarque.Visible = False
        Panel2.Enabled = False

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click


        If capacidad > 0 Then
            If txt_peso.Text <= capacidad Then
                Dim row As String() = New String() {txt_peso.Text, chk_Especial.Checked, cmb_abordo.Text}
                dgv1.Rows.Add(row)
                capacidad -= txt_peso.Text
            Else
                MsgBox("EL Peso Del Equipaje Debe ser menor a: " & capacidad)
            End If
        Else
            MsgBox("El avion no posee mas capacidad de equipaje")
        End If



    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If txt_dni.Text <> "" Then
            Dim sql As String = "SELECT v.id_vuelo
        FROM Vuelos v JOIN Pasaje p ON p.idVuelo = v.id_vuelo 
        WHERE YEAR(v.fechaSalida) = YEAR(getdate()) AND MONTH(v.fechaSalida) = MONTH(getdate()) 
        AND DAY(v.fechaSalida) = DAY(getdate()) AND
        p.nroDocumento =" & txt_dni.Text & " AND p.tipoDocumento = " & cmb_Tdni.SelectedValue
            Dim tabla As New DataTable
            tabla = _conex.consultaATabla(sql)
            If tabla.Rows.Count = 0 Then
                MsgBox("El Pasajero no tiene pasaje para hoy")
            Else
                MsgBox("El Pasajero tiene un Pasaje para hoy")
                vuelo = tabla.Rows(0)(0)
                txt_dni.Enabled = False
                cmb_Tdni.Enabled = False
                btn_embarque.Visible = True
                Panel2.Enabled = True
                comprobarpeso()
            End If
        Else
            MsgBox("Ingrese un Documento a buscar")
        End If

    End Sub

    Private Sub guardarlista()
        Dim c As Integer
        Dim cantidad As Integer = dgv1.Rows.Count - 1
        ReDim lista(cantidad)
        If cantidad <> 0 Then

            For c = 0 To cantidad - 1
                Dim flag As Integer
                Dim value As Boolean = CType(Me.dgv1.Rows(c).Cells(1).EditedFormattedValue, Boolean)
                If value = True Then
                    flag = 1
                Else
                    flag = 0
                End If
                Dim sql As String = " INSERT INTO Equipajes (Peso, [especial/noespecial]) VALUES ( " & dgv1.Rows(c).Cells(0).Value & ", " & flag & " )"
                _conex.consultaABM(sql)
                Dim sql1 As String = "SELECT TOP (1) nroEquipaje from Equipajes order by nroEquipaje DESC"
                Dim tabla As New DataTable
                tabla = _conex.consultaATabla(sql1)
                Dim nro As String = tabla.Rows(0)(0)
                lista(c) = nro


            Next

        End If


    End Sub

    Private Sub btn_embarque_Click(sender As Object, e As EventArgs) Handles btn_embarque.Click
        If txt_puertaEmbarque.Text = " " Then
            MsgBox("Ingrese Puerta de Embarque")
            Exit Sub
        End If
        Me._conex.iniciarTransaccion()

        guardarlista()

        Me._Embar.nroDocumento = txt_dni.Text
        Me._Embar.nroVuelo = vuelo
        Me._Embar.PuertaEmbarque = txt_puertaEmbarque.Text
        Me._Embar.tipoDocumento = cmb_Tdni.SelectedValue
        Dim tabla As New DataTable
        tabla = _conex.consultaATabla("SELECT * FROM Embarque WHERE nroVuelo = " & vuelo & " AND nroDocumento = " & txt_dni.Text &
                                      " AND PuertaEmbarque = " & txt_puertaEmbarque.Text & " AND tipoDocumento= " & cmb_Tdni.SelectedValue)
        If tabla.Rows.Count = 0 Then
            Me._Embar.insertar()
        Else
            Me._Embar.modificar()
        End If

        Me._conex.FinTransaccion()
        If comprobar("SELECT  nroEquipaje FROM Equipajes WHERE nroEquipaje =  " & lista(0)) = 1 Then
            creardetalle()
            dgv1.DataSource = New DataTable
        End If

    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.TE.blanquear_objetos(Me)
        txt_dni.Enabled = True
        cmb_Tdni.Enabled = True
        btn_embarque.Visible = False
        vuelo = 0
        dgv1.DataSource = New DataTable
    End Sub



    Private Sub creardetalle()


        For c = 0 To lista.Count - 2
            Me._detalle.nroDocumento = txt_dni.Text
            Me._detalle.nroVuelo = vuelo
            Me._detalle.tipoDocumento = cmb_Tdni.SelectedValue
            If dgv1.Rows(c).Cells(2).Value = "Abordo" Then
                Me._detalle.abordo_bodega = 1
            Else
                Me._detalle.abordo_bodega = 2
            End If
            Me._detalle.nroEquipaje = lista(c)
            Me._detalle.insertar()
        Next

    End Sub
    Private Function comprobar(sql)
        Dim tabla As New DataTable
        tabla = _conex.consultaATabla(sql)
        If tabla.Rows.Count = 0 Then
            Return 0
        Else
            Return 1
        End If
    End Function

    Private Function comprobarpeso()
        Dim cargado As Integer = 0
        Dim sql As String = "select COUNT(e.peso)  from Equipajes e 
        join DetalleEmbarques d on d.nroEquipaje=e.nroEquipaje 
        join Vuelos v on v.id_vuelo = d.nroVuelo where nroVuelo = " & vuelo
        Dim tabla As New DataTable
        tabla = _conex.consultaATabla(sql)
        If tabla.Rows(0)(0) > 0 Then
            Dim sql1 As String = "select sum(e.peso)  from Equipajes e 
        join DetalleEmbarques d on d.nroEquipaje=e.nroEquipaje 
        join Vuelos v on v.id_vuelo = d.nroVuelo where nroVuelo = " & vuelo
            tabla = _conex.consultaATabla(sql1)
            cargado = tabla.Rows(0)(0)
        End If
        Dim sql2 As String = "select t.capacidadKGEquipaje from  Embarque e  
          join Vuelos v on e.nroVuelo= v.id_vuelo join Aviones a on a.id=v.id_avion 
          join TipoAvion t on a.idTipoAvion =t.id_tipoAvion where e.nroVuelo = " & vuelo
        tabla = _conex.consultaATabla(sql2)
        Dim capacidadavion As Integer = tabla.Rows(0)(0)
        Dim disponible As Integer = capacidadavion - cargado
        capacidad = disponible
        Return disponible
    End Function
End Class