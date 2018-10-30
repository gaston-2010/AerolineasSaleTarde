Public Class Form1
    Public Property actual As Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actual = deletongo
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel3.Visible = True
        Dim a As Point
        a.Y = Button2.Location.Y
        a.X = 0
        Panel4.Location = a
        actual.Close()
        With ABM_Destinos

            .Show()
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .BringToFront()
        End With
        actual = ABM_Destinos
        Panel3.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel3.Visible = True
        Dim a As Point
        a.Y = Button3.Location.Y
        a.X = 0
        Panel4.Location = a
        actual.Close()
        With ABM_Vuelos

            .Show()
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .BringToFront()
        End With
        actual = ABM_Vuelos
        Panel3.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        actual.Close()
        Panel3.Visible = True
        Dim a As Point
        a.Y = 0
        a.X = 0
        Panel4.Location = a
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel3.Visible = True
        Dim a As Point
        a.Y = Button1.Location.Y
        a.X = 0
        Panel4.Location = a
        actual.Close()
        With ABM_Avion
            .Show()
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .BringToFront()
        End With
        actual = ABM_Avion
        Panel3.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel3.Visible = True
        Dim a As Point
        a.Y = Button6.Location.Y
        a.X = 0
        Panel4.Location = a
        actual.Close()
        With ABM_Personal

            .Show()
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .BringToFront()
        End With
        actual = ABM_Personal
        Panel3.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel3.Visible = True
        Dim a As Point
        a.Y = Button4.Location.Y
        a.X = 0
        Panel4.Location = a
        With ABM_PersonalxAeropuerto


            .Show()
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .BringToFront()
        End With
        actual = ABM_PersonalxAeropuerto

        Panel3.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel3.Visible = True
        Dim a As Point
        a.Y = Button5.Location.Y
        a.X = 0
        Panel4.Location = a
        With ABM_Aeropuerto
            .Show()
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .BringToFront()
        End With
        actual = ABM_Aeropuerto
        Panel3.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Panel3.Visible = True
        Dim a As Point
        a.Y = Button9.Location.Y
        a.X = 0
        Panel4.Location = a
        With ABM_TipoAvion
            .Show()
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .BringToFront()
        End With
        actual = ABM_TipoAvion
        Panel3.Visible = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim asas As New ListadoEmbarcados

        asas.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim asas As New ListadoPasajes

        asas.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim asas As New ListadoValija

        asas.Show()
    End Sub
End Class
