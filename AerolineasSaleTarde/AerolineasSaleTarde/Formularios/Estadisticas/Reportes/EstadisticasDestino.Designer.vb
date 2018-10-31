<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstadisticasDestino
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DestinoVendidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AerolineasSaleTarde.DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txt_cantidad = New AerolineasSaleTarde.MTB_01()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        CType(Me.DestinoVendidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DestinoVendidoBindingSource
        '
        Me.DestinoVendidoBindingSource.DataMember = "DestinoVendido"
        Me.DestinoVendidoBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.Chocolate
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DestinoVendidoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AerolineasSaleTarde.Estadisticadestinovendidos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 59)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(604, 398)
        Me.ReportViewer1.TabIndex = 0
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(122, 18)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.nombre_campo = Nothing
        Me.txt_cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidad.TabIndex = 1
        Me.txt_cantidad.validable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(21, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad a mostrar"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Mostrar.Location = New System.Drawing.Point(249, 16)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Mostrar.TabIndex = 3
        Me.btn_Mostrar.Text = "Mostrar"
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'EstadisticasDestino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(628, 469)
        Me.Controls.Add(Me.btn_Mostrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EstadisticasDestino"
        Me.Text = "EstadisticasDestino"
        CType(Me.DestinoVendidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DestinoVendidoBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents txt_cantidad As MTB_01
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Mostrar As Button
End Class
