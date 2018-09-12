Public Class Escritorio
    Private Sub ABMAvionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMAvionToolStripMenuItem.Click
        ABM_Avion.ShowDialog()
    End Sub

    Private Sub ABMTIpoDeAvionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMTIpoDeAvionToolStripMenuItem.Click
        ABM_TipoAvion.ShowDialog()
    End Sub

    Private Sub Escritorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class