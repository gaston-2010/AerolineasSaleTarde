Public Class Escritorio
    Private Sub DestinosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DestinosToolStripMenuItem.Click
        ABM_Destinos.ShowDialog()
    End Sub

    Private Sub TipoAvionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoAvionToolStripMenuItem.Click
        ABM_TipoAvion.ShowDialog()
    End Sub

    Private Sub AvionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvionToolStripMenuItem.Click
        ABM_Avion.ShowDialog()
    End Sub
End Class