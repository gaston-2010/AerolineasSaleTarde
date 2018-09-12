Public Class CMB_01

    Inherits ComboBox

    Public Property nombre_campo As String
    Public Property validable As Boolean = True

    Public Sub cargar(ByVal tabla As DataTable)
        Me.DataSource = tabla
    End Sub

    Public Sub cargar(ByVal tabla As DataTable _
                      , ByVal pk As String _
                      , ByVal descripcion As String)
        Me.DataSource = tabla
        Me.DisplayMember = descripcion
        Me.ValueMember = pk
    End Sub

End Class
