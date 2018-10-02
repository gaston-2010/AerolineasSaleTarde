Public Class Form1
    Public Property actual As Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        actual = deletongo


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel3.Visible = False
        actual.Close()
        With ABM_Destinos

            .Show()
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .BringToFront()
        End With
        actual = ABM_Destinos
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel3.Visible = False
        actual.Close()
        With ABM_Vuelos

            .Show()
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .BringToFront()
        End With
        actual = ABM_Vuelos

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        actual.Close()
        Panel3.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel3.Visible = False
        actual.Close()
        With ABM_Avion
            .Show()
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .BringToFront()
        End With
        actual = ABM_Avion
    End Sub
End Class
