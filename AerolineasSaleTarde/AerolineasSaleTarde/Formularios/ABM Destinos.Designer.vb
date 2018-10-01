<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Destinos
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
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.cmd_Grabar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_Borrar = New System.Windows.Forms.Button()
        Me.txt_id = New AerolineasSaleTarde.MTB_01()
        Me.cmb_Localidad = New AerolineasSaleTarde.CMB_01()
        Me.cmb_Provincia = New AerolineasSaleTarde.CMB_01()
        Me.cmb_Pais = New AerolineasSaleTarde.CMB_01()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(371, 25)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(394, 267)
        Me.DGV1.TabIndex = 0
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Location = New System.Drawing.Point(89, 231)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Nuevo.TabIndex = 4
        Me.cmd_Nuevo.Text = "Nuevo"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'cmd_Grabar
        '
        Me.cmd_Grabar.Location = New System.Drawing.Point(182, 231)
        Me.cmd_Grabar.Name = "cmd_Grabar"
        Me.cmd_Grabar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Grabar.TabIndex = 5
        Me.cmd_Grabar.Text = "Grabar"
        Me.cmd_Grabar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pais"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Provincia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Localidad"
        '
        'cmd_Borrar
        '
        Me.cmd_Borrar.Location = New System.Drawing.Point(277, 231)
        Me.cmd_Borrar.Name = "cmd_Borrar"
        Me.cmd_Borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Borrar.TabIndex = 6
        Me.cmd_Borrar.Text = "Borrar"
        Me.cmd_Borrar.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(141, 180)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.nombre_campo = Nothing
        Me.txt_id.Size = New System.Drawing.Size(23, 20)
        Me.txt_id.TabIndex = 6
        Me.txt_id.validable = True
        '
        'cmb_Localidad
        '
        Me.cmb_Localidad.FormattingEnabled = True
        Me.cmb_Localidad.Location = New System.Drawing.Point(141, 143)
        Me.cmb_Localidad.Name = "cmb_Localidad"
        Me.cmb_Localidad.nombre_campo = Nothing
        Me.cmb_Localidad.Size = New System.Drawing.Size(176, 21)
        Me.cmb_Localidad.TabIndex = 3
        Me.cmb_Localidad.validable = True
        '
        'cmb_Provincia
        '
        Me.cmb_Provincia.FormattingEnabled = True
        Me.cmb_Provincia.Location = New System.Drawing.Point(141, 99)
        Me.cmb_Provincia.Name = "cmb_Provincia"
        Me.cmb_Provincia.nombre_campo = Nothing
        Me.cmb_Provincia.Size = New System.Drawing.Size(176, 21)
        Me.cmb_Provincia.TabIndex = 2
        Me.cmb_Provincia.validable = True
        '
        'cmb_Pais
        '
        Me.cmb_Pais.FormattingEnabled = True
        Me.cmb_Pais.Location = New System.Drawing.Point(141, 59)
        Me.cmb_Pais.Name = "cmb_Pais"
        Me.cmb_Pais.nombre_campo = Nothing
        Me.cmb_Pais.Size = New System.Drawing.Size(176, 21)
        Me.cmb_Pais.TabIndex = 1
        Me.cmb_Pais.validable = True
        '
        'ABM_Destinos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 314)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_Borrar)
        Me.Controls.Add(Me.cmd_Grabar)
        Me.Controls.Add(Me.cmd_Nuevo)
        Me.Controls.Add(Me.cmb_Localidad)
        Me.Controls.Add(Me.cmb_Provincia)
        Me.Controls.Add(Me.cmb_Pais)
        Me.Controls.Add(Me.DGV1)
        Me.Name = "ABM_Destinos"
        Me.Text = "ABM_Destinos"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents cmb_Pais As CMB_01
    Friend WithEvents cmb_Provincia As CMB_01
    Friend WithEvents cmd_Nuevo As Button
    Friend WithEvents cmd_Grabar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_Localidad As CMB_01
    Friend WithEvents Label3 As Label
    Friend WithEvents cmd_Borrar As Button
    Friend WithEvents txt_id As MTB_01
End Class
