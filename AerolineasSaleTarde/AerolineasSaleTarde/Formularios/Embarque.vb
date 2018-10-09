Public Class Embarque

    Enum estado_grabacion
        insertar
        modificar
    End Enum
    Dim control_estado_grabacion As estado_grabacion = estado_grabacion.insertar
    Dim _Embar As New Embarquec
    Dim _conex As New BD_TRANSACCIONAL
    Dim TE As New tratamientos_especiales

    Private Sub Embarque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_abordo.Items.Add("Abordo")
        cmb_abordo.Items.Add("Bodega")
        cmb_Tdni.cargar(_conex.consultaATabla("SELECT * FROM TipoDocumento"), "id", "nombre")

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim row As String() = New String() {txt_peso.Text, chk_Especial.Checked, cmb_abordo.Text}
        dgv1.Rows.Add(row)

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim sql As String = "SELECT *
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
        End If
    End Sub
End Class