Public Class BD_TRANSACCIONAL


    Enum tipo_conexion
            simple
            transaccion
        End Enum

        Enum estado_proceso
            _ok
            _error
        End Enum

        Dim control_conexion As tipo_conexion = tipo_conexion.simple
        Dim control_estado As estado_proceso = estado_proceso._ok

    Dim conexion As New SqlClient.SqlConnection
    Dim cmd As New SqlClient.SqlCommand
    Dim transaccion As SqlClient.SqlTransaction
    Dim _cadena_conexion As String = "Data Source=NETBOOK\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Aerolineas"
    Private Function conectar() As estado_proceso
            'Si el tipo de conexion es Transaccion, entonces devuelve ok
            'para confirmar que ya esta conectado
            If control_conexion = tipo_conexion.transaccion Then
            If conexion.State = ConnectionState.Open Then
                Return estado_proceso._ok
            End If
        End If


        conexion.ConnectionString = _cadena_conexion


        Try
                conexion.Open()
            Catch ex As Exception
                MsgBox("No conectó, verifique cadena de conexión.")
                Return estado_proceso._error
            End Try
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            If control_conexion = tipo_conexion.transaccion Then
                transaccion = conexion.BeginTransaction
                cmd.Transaction = transaccion
            End If
            Return estado_proceso._ok
        End Function

        Private Sub cerrar()
            If control_conexion = tipo_conexion.simple Then
                conexion.Close()
            ElseIf control_conexion = tipo_conexion.transaccion Then

            End If
        End Sub

        Public Function consultaABM(ByVal comando As String) As estado_proceso
            If conectar() = estado_proceso._error Then
                Return estado_proceso._error
            End If
            cmd.CommandText = comando
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Se produjo error en el comando: " & Chr(13) & cmd.ToString _
                       & Chr(13) & ex.Message)
                Return estado_proceso._error
            Finally
            cerrar()
        End Try
            'excelente profe
            'no aprende sus estructuras
            '10/10 quiero uno para mi
            cerrar()
            Return estado_proceso._ok
        End Function
        'tengo ganas de morirme

        Public Sub iniciarTransaccion()
            control_conexion = tipo_conexion.transaccion
            control_estado = estado_proceso._ok
        End Sub

        Public Sub FinTransaccion()
            If conexion.State = ConnectionState.Closed Then
                Exit Sub
            End If
            If control_conexion = tipo_conexion.transaccion Then
                If control_estado = estado_proceso._ok Then
                transaccion.Commit()
                MsgBox("Se grabó correctamente")
                Else
                    transaccion.Rollback()
                    MsgBox("Se produjo errores, no se grabó")
                End If
                conexion.Close()
            End If
            control_conexion = tipo_conexion.simple
        End Sub

        Public Function consultaATabla(ByVal sql As String) As DataTable
            Dim tabla As New DataTable

            conectar()
            cmd.CommandText = sql
        Try
            tabla.Load(cmd.ExecuteReader)
        Catch ex As Exception
            MsgBox("Error en el comando: " & Chr(13) & sql & Chr(13) & ex.Message)
            cerrar()
            Return New DataTable

        End Try
        cerrar()
        Return tabla
        End Function

End Class
