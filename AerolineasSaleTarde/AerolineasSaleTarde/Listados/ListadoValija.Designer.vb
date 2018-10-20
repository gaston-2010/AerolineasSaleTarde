<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoValija
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
        Me.btn_buscarVuelo = New System.Windows.Forms.Button()
        Me.cmb_origen = New AerolineasSaleTarde.CMB_01()
        Me.cmb_destino = New AerolineasSaleTarde.CMB_01()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet1 = New AerolineasSaleTarde.DataSet1()
        Me.ValijasEmbarcadasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValijasEmbarcadasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_buscarVuelo
        '
        Me.btn_buscarVuelo.Location = New System.Drawing.Point(415, 27)
        Me.btn_buscarVuelo.Name = "btn_buscarVuelo"
        Me.btn_buscarVuelo.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscarVuelo.TabIndex = 24
        Me.btn_buscarVuelo.Text = "Buscar"
        Me.btn_buscarVuelo.UseVisualStyleBackColor = True
        '
        'cmb_origen
        '
        Me.cmb_origen.FormattingEnabled = True
        Me.cmb_origen.Location = New System.Drawing.Point(74, 27)
        Me.cmb_origen.Name = "cmb_origen"
        Me.cmb_origen.nombre_campo = Nothing
        Me.cmb_origen.Size = New System.Drawing.Size(121, 21)
        Me.cmb_origen.TabIndex = 23
        Me.cmb_origen.validable = True
        '
        'cmb_destino
        '
        Me.cmb_destino.FormattingEnabled = True
        Me.cmb_destino.Location = New System.Drawing.Point(260, 27)
        Me.cmb_destino.Name = "cmb_destino"
        Me.cmb_destino.nombre_campo = Nothing
        Me.cmb_destino.Size = New System.Drawing.Size(121, 21)
        Me.cmb_destino.TabIndex = 22
        Me.cmb_destino.validable = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(210, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Destino"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Origen"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ValijasEmbarcadasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AerolineasSaleTarde.ValijasEmbarcadas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 75)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(754, 348)
        Me.ReportViewer1.TabIndex = 25
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ValijasEmbarcadasBindingSource
        '
        Me.ValijasEmbarcadasBindingSource.DataMember = "ValijasEmbarcadas"
        Me.ValijasEmbarcadasBindingSource.DataSource = Me.DataSet1
        '
        'ListadoValija
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btn_buscarVuelo)
        Me.Controls.Add(Me.cmb_origen)
        Me.Controls.Add(Me.cmb_destino)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Name = "ListadoValija"
        Me.Text = "ListadoValija"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValijasEmbarcadasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_buscarVuelo As Button
    Friend WithEvents cmb_origen As CMB_01
    Friend WithEvents cmb_destino As CMB_01
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ValijasEmbarcadasBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
End Class
