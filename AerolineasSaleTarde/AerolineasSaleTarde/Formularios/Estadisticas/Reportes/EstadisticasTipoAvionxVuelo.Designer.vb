﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EstadisticasTipoAvionxVuelo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New AerolineasSaleTarde.MTB_01()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet1 = New AerolineasSaleTarde.DataSet1()
        Me.TipoAvionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoAvionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Location = New System.Drawing.Point(280, 24)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Mostrar.TabIndex = 6
        Me.btn_Mostrar.Text = "Mostrar"
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cantidad a mostrar"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(153, 26)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.nombre_campo = Nothing
        Me.txt_cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidad.TabIndex = 4
        Me.txt_cantidad.validable = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TipoAvionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AerolineasSaleTarde.EstadisticaTipoAvion.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(24, 74)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(750, 346)
        Me.ReportViewer1.TabIndex = 7
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipoAvionBindingSource
        '
        Me.TipoAvionBindingSource.DataMember = "TipoAvion"
        Me.TipoAvionBindingSource.DataSource = Me.DataSet1
        '
        'EstadisticasTipoAvionxVuelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btn_Mostrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Name = "EstadisticasTipoAvionxVuelo"
        Me.Text = "EstadisticasTipoAvionxVuelo"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoAvionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Mostrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cantidad As MTB_01
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TipoAvionBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
End Class
