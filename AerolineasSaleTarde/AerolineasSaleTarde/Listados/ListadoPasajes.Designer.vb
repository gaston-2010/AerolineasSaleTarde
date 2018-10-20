<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoPasajes
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.btn_buscarVuelo = New System.Windows.Forms.Button()
        Me.cmb_origen = New AerolineasSaleTarde.CMB_01()
        Me.cmb_destino = New AerolineasSaleTarde.CMB_01()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet1 = New AerolineasSaleTarde.DataSet1()
        Me.PasajePorClaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmB_011 = New AerolineasSaleTarde.CMB_01()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasajePorClaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fecha
        '
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(506, 25)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(114, 20)
        Me.fecha.TabIndex = 10
        '
        'btn_buscarVuelo
        '
        Me.btn_buscarVuelo.Location = New System.Drawing.Point(636, 22)
        Me.btn_buscarVuelo.Name = "btn_buscarVuelo"
        Me.btn_buscarVuelo.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscarVuelo.TabIndex = 11
        Me.btn_buscarVuelo.Text = "Buscar"
        Me.btn_buscarVuelo.UseVisualStyleBackColor = True
        '
        'cmb_origen
        '
        Me.cmb_origen.FormattingEnabled = True
        Me.cmb_origen.Location = New System.Drawing.Point(89, 25)
        Me.cmb_origen.Name = "cmb_origen"
        Me.cmb_origen.nombre_campo = Nothing
        Me.cmb_origen.Size = New System.Drawing.Size(121, 21)
        Me.cmb_origen.TabIndex = 6
        Me.cmb_origen.validable = True
        '
        'cmb_destino
        '
        Me.cmb_destino.FormattingEnabled = True
        Me.cmb_destino.Location = New System.Drawing.Point(275, 25)
        Me.cmb_destino.Name = "cmb_destino"
        Me.cmb_destino.nombre_campo = Nothing
        Me.cmb_destino.Size = New System.Drawing.Size(121, 21)
        Me.cmb_destino.TabIndex = 8
        Me.cmb_destino.validable = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Location = New System.Drawing.Point(429, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 15)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Fecha"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(225, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Destino"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(44, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Origen"
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.PasajePorClaseBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AerolineasSaleTarde.Pasajes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(22, 105)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(717, 310)
        Me.ReportViewer1.TabIndex = 13
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PasajePorClaseBindingSource
        '
        Me.PasajePorClaseBindingSource.DataMember = "PasajePorClase"
        Me.PasajePorClaseBindingSource.DataSource = Me.DataSet1
        '
        'CmB_011
        '
        Me.CmB_011.FormattingEnabled = True
        Me.CmB_011.Items.AddRange(New Object() {"Primera Clase", "ClaseTurista"})
        Me.CmB_011.Location = New System.Drawing.Point(89, 64)
        Me.CmB_011.Name = "CmB_011"
        Me.CmB_011.nombre_campo = Nothing
        Me.CmB_011.Size = New System.Drawing.Size(121, 21)
        Me.CmB_011.TabIndex = 14
        Me.CmB_011.validable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Clase"
        '
        'ListadoPasajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmB_011)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.btn_buscarVuelo)
        Me.Controls.Add(Me.cmb_origen)
        Me.Controls.Add(Me.cmb_destino)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Name = "ListadoPasajes"
        Me.Text = "ListadoPasajes"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasajePorClaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents btn_buscarVuelo As Button
    Friend WithEvents cmb_origen As CMB_01
    Friend WithEvents cmb_destino As CMB_01
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PasajePorClaseBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents CmB_011 As CMB_01
    Friend WithEvents Label1 As Label
End Class
