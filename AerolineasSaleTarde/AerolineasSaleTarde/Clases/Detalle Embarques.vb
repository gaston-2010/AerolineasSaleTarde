Public Class Detalle_Embarques

    Public Property nroVuelo As Integer
    Public Property nroDocumento As Integer
    Public Property tipoDocumento As Integer
    Public Property nroEquipaje As Integer
    Public Property abordo_bodega As Integer

    Dim _bd As New BD_TRANSACCIONAL
    Public Sub insertar()
        Dim sql As String = "INSERT INTO  DetalleEmbarques 
           ( nroVuelo 
           ,nroDocumento 
           ,tipoDocumento 
           ,nroEquipaje 
           ,[abordo/bodega] )
     VALUES
           (" & _nroVuelo & "
           ," & _nroDocumento & "
           ," & _tipoDocumento & "
           ," & _nroEquipaje & "
           ," & _abordo_bodega & " ) "
        _bd.consultaABM(sql)
    End Sub

    Public Sub Borrar()

    End Sub
End Class
