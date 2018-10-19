Public Class Listados
    Dim _conex As New BD_TRANSACCIONAL
    Private Sub Listados_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.rv.RefreshReport()
    End Sub

    Private Sub btn_buscarVuelo_Click(sender As Object, e As EventArgs) Handles btn_buscarVuelo.Click
        If cmb_origen.SelectedIndex <> -1 And cmb_destino.SelectedIndex <> -1 Then
            Dim sql As String = " SET DATEFORMAT DMY SELECT * from Vuelos v Where idAereopuertoOrigen = " & cmb_origen.SelectedValue & " and idAereopuertoDestino = " & cmb_destino.SelectedValue & " and '" & Today.Day & "' = v.fechaSalida"
            Dim tabla As New DataTable
            tabla = Me._conex.consultaATabla(sql)
            If tabla.Rows.Count = 0 Then
                MsgBox("No hay vuelos disponibles ya embarcados")
            Else

            End If
        Else
            MsgBox("Falta un dato")
        End If
    End Sub
End Class