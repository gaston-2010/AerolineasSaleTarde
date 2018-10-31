Public Class Listadinho
    Public Property actual As Form



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel3.Visible = True
        Dim a As Point
        a.Y = Button1.Location.Y
        a.X = 0
        Panel4.Location = a
        actual.Close()
        With ListadoEmbarcados

            .Show()
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .BringToFront()
        End With
        actual = ABM_Avion
        Panel3.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel3.Visible = True
        Dim a As Point
        a.Y = Button1.Location.Y
        a.X = 0
        Panel4.Location = a
        actual.Close()
        With ListadoValija
            .Show()
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .BringToFront()
        End With
        actual = ABM_Avion
        Panel3.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel3.Visible = True
        Dim a As Point
        a.Y = Button1.Location.Y
        a.X = 0
        Panel4.Location = a
        actual.Close()
        With ListadoPasajes
            .Show()
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .BringToFront()
        End With
        actual = ABM_Avion
        Panel3.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Panel3.Visible = True
        Dim a As Point
        a.Y = Button1.Location.Y
        a.X = 0
        Panel4.Location = a
        actual.Close()
        With EstadisticasDestino
            .Show()
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .BringToFront()
        End With
        actual = ABM_Avion
        Panel3.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel3.Visible = True
        Dim a As Point
        a.Y = Button1.Location.Y
        a.X = 0
        Panel4.Location = a
        actual.Close()
        With EstadisticaSexoxPasajero
            .Show()
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .BringToFront()
        End With
        actual = ABM_Avion
        Panel3.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel3.Visible = True
        Dim a As Point
        a.Y = Button1.Location.Y
        a.X = 0
        Panel4.Location = a
        actual.Close()
        With EstadisticasTipoAvionxVuelo
            .Show()
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .BringToFront()
        End With
        actual = ABM_Avion
        Panel3.Visible = False
    End Sub

    Private Sub Listadinho_Load(sender As Object, e As EventArgs) Handles Me.Load
        actual = deletongo
    End Sub
End Class