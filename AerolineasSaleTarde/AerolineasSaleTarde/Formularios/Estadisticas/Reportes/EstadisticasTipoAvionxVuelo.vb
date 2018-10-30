Public Class EstadisticasTipoAvionxVuelo

    Dim _conex As New CONEXION_BD
    Private Sub EstadisticasTipoAvionxVuelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_Mostrar_Click(sender As Object, e As EventArgs) Handles btn_Mostrar.Click
        If txt_cantidad.Text = "" Then

            Dim sql As String = "select t.nombre,COUNT(t.nombre) as 'dato' from TipoAvion t join Aviones a on a.idTipoAvion = t.id_tipoAvion 
                join Vuelos v on v.id_avion = a.id group by t.nombre"
            TipoAvionBindingSource.DataSource = _conex.leo_tabla(sql)
            ReportViewer1.RefreshReport()
        Else
            If IsNumeric(txt_cantidad.Text) Then
                Dim sql1 As String = "select top " & txt_cantidad.Text & " t.nombre,COUNT(t.nombre) as 'dato' from TipoAvion t join Aviones a on a.idTipoAvion = t.id_tipoAvion 
                join Vuelos v on v.id_avion = a.id group by t.nombre order by COUNT(t.nombre) DESC"
                TipoAvionBindingSource.DataSource = _conex.leo_tabla(sql1)
                ReportViewer1.RefreshReport()
            Else
                MsgBox("Ingrese Solo Numeros")
            End If


        End If

        ReportViewer1.Refresh()
    End Sub
End Class