Public Class ListadoPasajes
    Dim _conex As New BD_TRANSACCIONAL
    Private Sub ListadoPasajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_destino.cargar(_conex.consultaATabla("SELECT * FROM Aeropuertos"), "id", "nombre")
        cmb_origen.cargar(_conex.consultaATabla("SELECT * FROM Aeropuertos"), "id", "nombre")
        cmb_destino.SelectedIndex = -1
        cmb_origen.SelectedIndex = -1
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_buscarVuelo_Click(sender As Object, e As EventArgs) Handles btn_buscarVuelo.Click
        If cmb_origen.SelectedIndex <> -1 And cmb_destino.SelectedIndex <> -1 And fecha.Text <> "" Then
            Dim sql As String = " SET DATEFORMAT DMY SELECT * from Vuelos v Where idAereopuertoOrigen = " & cmb_origen.SelectedValue & " and idAereopuertoDestino = " & cmb_destino.SelectedValue & " and '" & fecha.Text & "' = v.fechaSalida"
            Dim tabla As New DataTable
            tabla = Me._conex.consultaATabla(sql)
            If tabla.Rows.Count = 0 Then
                MsgBox("No hay vuelos disponibles para esa fecha")
            Else
                If CmB_011.Text = "Primera Clase" Then
                    sql = "Select * from Pasaje p join Pasajero pa ON p.nroDocumento = pa.nroDocumento AND p.tipoDocumento = pa.tipoDocumento   
                where idVuelo = " & tabla.Rows(0).Item(0) & " and claseTurista = 0"
                ElseIf CmB_011.Text = "Clase Turista" Then
                    sql = "Select * from Pasaje p join Pasajero pa ON p.nroDocumento = pa.nroDocumento AND p.tipoDocumento = pa.tipoDocumento   
                where idVuelo = " & tabla.Rows(0).Item(0) & " and claseTurista = 1"
                Else
                    MsgBox("Seleccione una clase de pasaje")
                    Exit Sub
                End If
    Dim tabla2 As New DataTable
                tabla2 = Me._conex.consultaATabla(sql)
                PasajePorClaseBindingSource.DataSource = tabla2
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