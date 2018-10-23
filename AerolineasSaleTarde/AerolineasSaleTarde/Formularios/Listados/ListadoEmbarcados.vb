Public Class ListadoEmbarcados
    Dim _conex As New BD_TRANSACCIONAL
    Private Sub ListadoEmbarcados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_destino.cargar(_conex.consultaATabla("SELECT * FROM Aeropuertos"), "id", "nombre")
        cmb_origen.cargar(_conex.consultaATabla("SELECT * FROM Aeropuertos"), "id", "nombre")
        cmb_destino.SelectedIndex = -1
        cmb_origen.SelectedIndex = -1
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_buscarVuelo_Click(sender As Object, e As EventArgs) Handles btn_buscarVuelo.Click
        If cmb_origen.SelectedIndex <> -1 And cmb_destino.SelectedIndex <> -1 Then
            Dim sql As String = " SELECT *
            FROM Pasajero pa JOIN pasaje p ON p.nroDocumento = pa.nroDocumento AND p.tipoDocumento = pa.tipoDocumento JOIN vuelos v
               ON v.id_vuelo = p.idVuelo
        where v.idAereopuertoDestino = " & cmb_destino.SelectedValue & " and v.idAereopuertoOrigen = " & cmb_origen.SelectedValue & "
                and CONVERT (date, GETDATE()) = v.fechaSalida "
            Dim tabla As New DataTable
            tabla = Me._conex.consultaATabla(sql)
            If tabla.Rows.Count = 0 Then
                MsgBox("No hay vuelos disponibles ya embarcados")
            Else
                PersonasEmbarcadasBindingSource.DataSource = tabla
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