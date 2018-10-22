Public Class ListadoPasajes
    Dim _conex As New BD_TRANSACCIONAL
    Private Sub ListadoPasajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
                If CmB_011.Text = "Primera clase" Then
                    sql = "Select * from Pasajes  where id_vuelo = " & tabla.Rows(0).Item(0) & "and claseTurista = 0"
                Else
                    sql = "Select * from Pasajes  where id_vuelo = " & tabla.Rows(0).Item(0) & "and claseTurista = 1"
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
End Class