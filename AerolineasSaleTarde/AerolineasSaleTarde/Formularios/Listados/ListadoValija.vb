Public Class ListadoValija
    Dim _conex As New BD_TRANSACCIONAL
    Private Sub ListadoValija_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_destino.cargar(_conex.consultaATabla("SELECT * FROM Aeropuertos"), "id", "nombre")
        cmb_origen.cargar(_conex.consultaATabla("SELECT * FROM Aeropuertos"), "id", "nombre")
        cmb_destino.SelectedIndex = -1
        cmb_origen.SelectedIndex = -1
        btn_buscarVuelo.ForeColor = Color.Chocolate
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_buscarVuelo_Click(sender As Object, e As EventArgs) Handles btn_buscarVuelo.Click
        If cmb_origen.SelectedIndex <> -1 And cmb_destino.SelectedIndex <> -1 Then
            Dim sql As String = " SET DATEFORMAT DMY SELECT * from Vuelos v Where idAereopuertoOrigen = " & cmb_origen.SelectedValue & " and idAereopuertoDestino = " & cmb_destino.SelectedValue & " and CONVERT (date, GETDATE()) = v.fechaSalida"
            Dim tabla As New DataTable
            tabla = Me._conex.consultaATabla(sql)
            If tabla.Rows.Count = 0 Then
                MsgBox("No hay vuelos disponibles ya embarcados")
            Else
                Dim sql1 As String = "Select e.nroEquipaje,e.peso,[especial/noespecial] as tipo, d.[abordo/bodega] as posicion  
                from Equipajes e Join DetalleEmbarques d on e.nroEquipaje =d.nroEquipaje 
                join Embarque em on em.nroDocumento=d.nroDocumento and em.tipoDocumento = d.tipoDocumento 
               Join Vuelos v on v.id_vuelo = em.nroVuelo WHERE v.fechaSalida = CONVERT(date,getdate())"
                tabla = Me._conex.consultaATabla(sql1)
                ValijasEmbarcadasBindingSource.DataSource = tabla
                ReportViewer1.RefreshReport()
            End If
        Else
            MsgBox("Falta un dato")
        End If
    End Sub

    Private Sub cmb_origen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_origen.SelectedIndexChanged
        Dim numero As Object = cmb_origen.SelectedValue
        If (TypeOf numero Is DataRowView) Then
            Exit Sub
        End If
        Dim nombre As String = Convert.ToString(numero)
        If nombre = "" Then
            Exit Sub
        End If


        cmb_destino.SelectedIndex = -1
        cmb_destino.cargar(_conex.consultaATabla("SELECT * FROM Aeropuertos where not id  = " & numero), "id", "nombre")

    End Sub
End Class