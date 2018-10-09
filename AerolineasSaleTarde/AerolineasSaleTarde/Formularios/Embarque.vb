Public Class Embarque
    Private Sub Embarque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_abordo.Items.Add("Abordo")
        cmb_abordo.Items.Add("Bodega")

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim row As String() = New String() {txt_peso.Text, chk_Especial.Checked, cmb_abordo.Text}
        dgv1.Rows.Add(row)

    End Sub
End Class