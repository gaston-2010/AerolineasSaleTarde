<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABM_TipoAvion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_borrar = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.cmb_alcance = New AerolineasSaleTarde.CMB_01()
        Me.txt_id_tipoAvion = New AerolineasSaleTarde.MTB_01()
        Me.txt_longitud = New AerolineasSaleTarde.MTB_01()
        Me.txt_capacidadKg = New AerolineasSaleTarde.MTB_01()
        Me.txt_cantsalidas = New AerolineasSaleTarde.MTB_01()
        Me.txt_capPasClasTur = New AerolineasSaleTarde.MTB_01()
        Me.txt_capPasAlta = New AerolineasSaleTarde.MTB_01()
        Me.txt_nombre = New AerolineasSaleTarde.MTB_01()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Capacidad Pasajeros Clase Alta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Capacidad Pasajeros Clase Turista"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cantidad de salidas de emergencia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Capacidad de KG  Equipajes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Longitud"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Alcance del Vuelo"
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(50, 331)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevo.TabIndex = 7
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(143, 331)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_guardar.TabIndex = 8
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_borrar
        '
        Me.cmd_borrar.Location = New System.Drawing.Point(412, 331)
        Me.cmd_borrar.Name = "cmd_borrar"
        Me.cmd_borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_borrar.TabIndex = 9
        Me.cmd_borrar.Text = "Borrar"
        Me.cmd_borrar.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(441, 40)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(384, 251)
        Me.DGV1.TabIndex = 8
        '
        'cmb_alcance
        '
        Me.cmb_alcance.FormattingEnabled = True
        Me.cmb_alcance.Items.AddRange(New Object() {"Internacional", "Nacional"})
        Me.cmb_alcance.Location = New System.Drawing.Point(231, 214)
        Me.cmb_alcance.Name = "cmb_alcance"
        Me.cmb_alcance.nombre_campo = "Alcance Vuelo"
        Me.cmb_alcance.Size = New System.Drawing.Size(121, 21)
        Me.cmb_alcance.TabIndex = 5
        Me.cmb_alcance.validable = True
        '
        'txt_id_tipoAvion
        '
        Me.txt_id_tipoAvion.Location = New System.Drawing.Point(231, 286)
        Me.txt_id_tipoAvion.Mask = "9999"
        Me.txt_id_tipoAvion.Name = "txt_id_tipoAvion"
        Me.txt_id_tipoAvion.nombre_campo = "Longitud"
        Me.txt_id_tipoAvion.Size = New System.Drawing.Size(37, 20)
        Me.txt_id_tipoAvion.TabIndex = 6
        Me.txt_id_tipoAvion.validable = False
        '
        'txt_longitud
        '
        Me.txt_longitud.Location = New System.Drawing.Point(231, 250)
        Me.txt_longitud.Mask = "9999"
        Me.txt_longitud.Name = "txt_longitud"
        Me.txt_longitud.nombre_campo = "Longitud"
        Me.txt_longitud.Size = New System.Drawing.Size(37, 20)
        Me.txt_longitud.TabIndex = 6
        Me.txt_longitud.validable = True
        '
        'txt_capacidadKg
        '
        Me.txt_capacidadKg.Location = New System.Drawing.Point(231, 186)
        Me.txt_capacidadKg.Mask = "99999"
        Me.txt_capacidadKg.Name = "txt_capacidadKg"
        Me.txt_capacidadKg.nombre_campo = "Capacidad de KG Equipajes"
        Me.txt_capacidadKg.Size = New System.Drawing.Size(37, 20)
        Me.txt_capacidadKg.TabIndex = 4
        Me.txt_capacidadKg.validable = True
        '
        'txt_cantsalidas
        '
        Me.txt_cantsalidas.Location = New System.Drawing.Point(231, 143)
        Me.txt_cantsalidas.Mask = "99"
        Me.txt_cantsalidas.Name = "txt_cantsalidas"
        Me.txt_cantsalidas.nombre_campo = "Cantidad Salidas de Emergencia"
        Me.txt_cantsalidas.Size = New System.Drawing.Size(37, 20)
        Me.txt_cantsalidas.TabIndex = 3
        Me.txt_cantsalidas.validable = True
        '
        'txt_capPasClasTur
        '
        Me.txt_capPasClasTur.Location = New System.Drawing.Point(231, 110)
        Me.txt_capPasClasTur.Mask = "999"
        Me.txt_capPasClasTur.Name = "txt_capPasClasTur"
        Me.txt_capPasClasTur.nombre_campo = "Capacidad Clase Turista"
        Me.txt_capPasClasTur.Size = New System.Drawing.Size(37, 20)
        Me.txt_capPasClasTur.TabIndex = 2
        Me.txt_capPasClasTur.validable = False
        '
        'txt_capPasAlta
        '
        Me.txt_capPasAlta.Location = New System.Drawing.Point(231, 70)
        Me.txt_capPasAlta.Mask = "999"
        Me.txt_capPasAlta.Name = "txt_capPasAlta"
        Me.txt_capPasAlta.nombre_campo = "Capacidad Clase Alta"
        Me.txt_capPasAlta.Size = New System.Drawing.Size(37, 20)
        Me.txt_capPasAlta.TabIndex = 1
        Me.txt_capPasAlta.validable = False
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(231, 40)
        Me.txt_nombre.Mask = "CCCCCCCCCCCCCCCCCC"
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.nombre_campo = "Nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(175, 20)
        Me.txt_nombre.TabIndex = 0
        Me.txt_nombre.validable = True
        Me.txt_nombre.ValidatingType = GetType(Integer)
        '
        'ABM_TipoAvion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 390)
        Me.Controls.Add(Me.cmb_alcance)
        Me.Controls.Add(Me.txt_id_tipoAvion)
        Me.Controls.Add(Me.txt_longitud)
        Me.Controls.Add(Me.txt_capacidadKg)
        Me.Controls.Add(Me.txt_cantsalidas)
        Me.Controls.Add(Me.txt_capPasClasTur)
        Me.Controls.Add(Me.txt_capPasAlta)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.cmd_borrar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ABM_TipoAvion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM TIPO AVION"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmd_nuevo As Button
    Friend WithEvents cmd_guardar As Button
    Friend WithEvents cmd_borrar As Button
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents txt_nombre As MTB_01
    Friend WithEvents txt_capPasAlta As MTB_01
    Friend WithEvents txt_capPasClasTur As MTB_01
    Friend WithEvents txt_cantsalidas As MTB_01
    Friend WithEvents txt_capacidadKg As MTB_01
    Friend WithEvents txt_longitud As MTB_01
    Friend WithEvents cmb_alcance As CMB_01
    Friend WithEvents txt_id_tipoAvion As MTB_01
End Class
