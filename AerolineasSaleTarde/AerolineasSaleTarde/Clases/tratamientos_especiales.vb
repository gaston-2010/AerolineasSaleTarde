Public Class tratamientos_especiales
    Public Sub blanquear_objetos(controles As Object)
        For Each obj In controles.controls
            Dim tipoObjeto As String = obj.GetType().Name
            Select Case tipoObjeto
                Case "MaskedTextBox"
                    obj.Text = ""
                Case "MTB_01"
                    obj.Text = ""
                Case "ComboBox"
                    Dim local As ComboBox = obj
                    local.SelectedIndex = -1
                Case "CMB_01"
                    Dim local As CMB_01 = obj
                    local.SelectedIndex = -1
            End Select
        Next
    End Sub
    Public Sub carga_combo(ByRef combo As ComboBox _
                           , ByVal tabla As DataTable _
                           , ByVal pk As String _
                           , ByVal descriptor As String)

        combo.DataSource = tabla
        combo.DisplayMember = descriptor
        combo.ValueMember = pk
    End Sub
    Public Sub cargar_grilla(ByRef grilla As DataGridView _
                             , ByVal tabla As DataTable)
        grilla.Rows.Clear()
        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            grilla.Rows.Add(tabla.Rows(c)(0), tabla.Rows(c)(1), tabla.Rows(c)(2), tabla.Rows(c)(3))
            'grilla.Rows.Add()
            'grilla.Rows(c).Cells(0) = tabla.Rows(c)(0)
            'grilla.Rows(c).Cells(1) = tabla.Rows(c)(1)
            'grilla.Rows(c).Cells(2) = tabla.Rows(c)(2)
        Next
    End Sub



End Class
