Public Class EstadisticasDestino

    Dim _conex As New CONEXION_BD

    Private Sub EstadisticasDestino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub btn_Mostrar_Click(sender As Object, e As EventArgs) Handles btn_Mostrar.Click
        If txt_cantidad.Text = "" Then

            Dim sql As String = "select l.nombre as 'destino', count(l.id) as 'dato' from Pasaje p join vuelos v on v.id_vuelo = p.idVuelo 
              join Aeropuertos a on a.id=v.idAereopuertoDestino join localidad l on l.id=a.id_Localidad group by l.nombre"
            DestinoVendidoBindingSource.DataSource = _conex.leo_tabla(sql)
            ReportViewer1.RefreshReport()
        Else
            Dim sql1 As String = "select top " & txt_cantidad.Text & " l.nombre as 'destino', count(l.id) as 'dato' from Pasaje p join vuelos v on v.id_vuelo = p.idVuelo 
              join Aeropuertos a on a.id=v.idAereopuertoDestino join localidad l on l.id=a.id_Localidad group by l.nombre order by count(l.id) DESC"
            DestinoVendidoBindingSource.DataSource = _conex.leo_tabla(sql1)
            ReportViewer1.RefreshReport()
        End If

        ReportViewer1.Refresh()
    End Sub
End Class