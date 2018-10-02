<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_ServicioxAeropuerto
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
        Me.cmd_Borrar = New System.Windows.Forms.Button()
        Me.cmd_Grabar = New System.Windows.Forms.Button()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.cmd_Buscar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nombreservicio = New AerolineasSaleTarde.MTB_01()
        Me.txt_nombreAeropuerto = New AerolineasSaleTarde.MTB_01()
        Me.txt_aeropuerto = New AerolineasSaleTarde.MTB_01()
        Me.cmb_tipoServicio = New AerolineasSaleTarde.CMB_01()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV1
        '
        Me.DGV1.BackgroundColor = System.Drawing.Color.Chocolate
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(14, 199)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(587, 210)
        Me.DGV1.TabIndex = 19
        '
        'cmd_Borrar
        '
        Me.cmd_Borrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_Borrar.FlatAppearance.BorderSize = 2
        Me.cmd_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_Borrar.Location = New System.Drawing.Point(426, 434)
        Me.cmd_Borrar.Name = "cmd_Borrar"
        Me.cmd_Borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Borrar.TabIndex = 7
        Me.cmd_Borrar.Text = "Borrar"
        Me.cmd_Borrar.UseVisualStyleBackColor = True
        '
        'cmd_Grabar
        '
        Me.cmd_Grabar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_Grabar.FlatAppearance.BorderSize = 2
        Me.cmd_Grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_Grabar.Location = New System.Drawing.Point(526, 157)
        Me.cmd_Grabar.Name = "cmd_Grabar"
        Me.cmd_Grabar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Grabar.TabIndex = 6
        Me.cmd_Grabar.Text = "Grabar"
        Me.cmd_Grabar.UseVisualStyleBackColor = True
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_Nuevo.FlatAppearance.BorderSize = 2
        Me.cmd_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_Nuevo.Location = New System.Drawing.Point(440, 157)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Nuevo.TabIndex = 5
        Me.cmd_Nuevo.Text = "Nuevo"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'cmd_Buscar
        '
        Me.cmd_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_Buscar.FlatAppearance.BorderSize = 2
        Me.cmd_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_Buscar.Location = New System.Drawing.Point(228, 27)
        Me.cmd_Buscar.Name = "cmd_Buscar"
        Me.cmd_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Buscar.TabIndex = 1
        Me.cmd_Buscar.Text = "Buscar"
        Me.cmd_Buscar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label5.Location = New System.Drawing.Point(21, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tipo Servicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label3.Location = New System.Drawing.Point(17, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nombre Aeropuerto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label1.Location = New System.Drawing.Point(21, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Aeropuerto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label2.Location = New System.Drawing.Point(241, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre"
        '
        'txt_nombreservicio
        '
        Me.txt_nombreservicio.Location = New System.Drawing.Point(308, 132)
        Me.txt_nombreservicio.Mask = "CCCCCCCCCCCCCCCCCCCCC"
        Me.txt_nombreservicio.Name = "txt_nombreservicio"
        Me.txt_nombreservicio.nombre_campo = "Nombre"
        Me.txt_nombreservicio.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombreservicio.TabIndex = 4
        Me.txt_nombreservicio.validable = True
        '
        'txt_nombreAeropuerto
        '
        Me.txt_nombreAeropuerto.Location = New System.Drawing.Point(122, 79)
        Me.txt_nombreAeropuerto.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC"
        Me.txt_nombreAeropuerto.Name = "txt_nombreAeropuerto"
        Me.txt_nombreAeropuerto.nombre_campo = "Nombre Aeropuerto"
        Me.txt_nombreAeropuerto.Size = New System.Drawing.Size(181, 20)
        Me.txt_nombreAeropuerto.TabIndex = 2
        Me.txt_nombreAeropuerto.validable = False
        '
        'txt_aeropuerto
        '
        Me.txt_aeropuerto.Location = New System.Drawing.Point(105, 29)
        Me.txt_aeropuerto.Mask = "99999999999999"
        Me.txt_aeropuerto.Name = "txt_aeropuerto"
        Me.txt_aeropuerto.nombre_campo = "Aeropuerto"
        Me.txt_aeropuerto.Size = New System.Drawing.Size(100, 20)
        Me.txt_aeropuerto.TabIndex = 0
        Me.txt_aeropuerto.validable = True
        '
        'cmb_tipoServicio
        '
        Me.cmb_tipoServicio.FormattingEnabled = True
        Me.cmb_tipoServicio.Location = New System.Drawing.Point(105, 131)
        Me.cmb_tipoServicio.Name = "cmb_tipoServicio"
        Me.cmb_tipoServicio.nombre_campo = "Tipo Servicio"
        Me.cmb_tipoServicio.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipoServicio.TabIndex = 3
        Me.cmb_tipoServicio.validable = True
        '
        'ABM_ServicioxAeropuerto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(628, 469)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.cmd_Borrar)
        Me.Controls.Add(Me.cmd_Grabar)
        Me.Controls.Add(Me.cmd_Nuevo)
        Me.Controls.Add(Me.cmd_Buscar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nombreservicio)
        Me.Controls.Add(Me.txt_nombreAeropuerto)
        Me.Controls.Add(Me.txt_aeropuerto)
        Me.Controls.Add(Me.cmb_tipoServicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ABM_ServicioxAeropuerto"
        Me.Text = "ABM_ServicioxAeropuerto"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents cmd_Borrar As Button
    Friend WithEvents cmd_Grabar As Button
    Friend WithEvents cmd_Nuevo As Button
    Friend WithEvents cmd_Buscar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nombreAeropuerto As MTB_01
    Friend WithEvents txt_aeropuerto As MTB_01
    Friend WithEvents cmb_tipoServicio As CMB_01
    Friend WithEvents txt_nombreservicio As MTB_01
    Friend WithEvents Label2 As Label
End Class
