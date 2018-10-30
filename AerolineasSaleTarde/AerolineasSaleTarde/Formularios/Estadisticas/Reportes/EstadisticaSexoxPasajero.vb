Public Class EstadisticaSexoxPasajero

    Dim _conex As New CONEXION_BD
    Private Sub EstadisticaSexoxPasajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmb_sexo.Text.Trim = "Todos" Then

            Dim sql As String = "select sexo, COUNT(sexo) as 'dato' from Pasajero group by sexo"
            Sexo_PasajeroBindingSource.DataSource = _conex.leo_tabla(sql)
            ReportViewer1.RefreshReport()
        Else

            Dim sql As String = "select sexo, COUNT(sexo) as 'dato' from Pasajero where sexo='" & cmb_sexo.Text & "' group by sexo"
            Sexo_PasajeroBindingSource.DataSource = _conex.leo_tabla(sql)
            ReportViewer1.RefreshReport()
        End If
    End Sub
End Class