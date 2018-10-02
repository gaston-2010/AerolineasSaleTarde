<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Vuelos
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
        Me.txt_FechaSalida = New AerolineasSaleTarde.MTB_01()
        Me.txt_horaSalida = New AerolineasSaleTarde.MTB_01()
        Me.txt_fechaLlegada = New AerolineasSaleTarde.MTB_01()
        Me.txt_horaLlegada = New AerolineasSaleTarde.MTB_01()
        Me.cmb_avion = New AerolineasSaleTarde.CMB_01()
        Me.cmb_aeropuertoOrigen = New AerolineasSaleTarde.CMB_01()
        Me.cmb_aeropuertoDestino = New AerolineasSaleTarde.CMB_01()
        Me.cmb_estado = New AerolineasSaleTarde.CMB_01()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_grabar = New System.Windows.Forms.Button()
        Me.cmd_borrar = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.txt_Buscar = New AerolineasSaleTarde.MTB_01()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.txt_id_vuelo = New AerolineasSaleTarde.MTB_01()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_FechaSalida
        '
        Me.txt_FechaSalida.Location = New System.Drawing.Point(83, 80)
        Me.txt_FechaSalida.Mask = "00/00/0000"
        Me.txt_FechaSalida.Name = "txt_FechaSalida"
        Me.txt_FechaSalida.nombre_campo = "Fecha Salida"
        Me.txt_FechaSalida.Size = New System.Drawing.Size(100, 20)
        Me.txt_FechaSalida.TabIndex = 0
        Me.txt_FechaSalida.validable = True
        Me.txt_FechaSalida.ValidatingType = GetType(Date)
        '
        'txt_horaSalida
        '
        Me.txt_horaSalida.Location = New System.Drawing.Point(83, 106)
        Me.txt_horaSalida.Mask = "00:00"
        Me.txt_horaSalida.Name = "txt_horaSalida"
        Me.txt_horaSalida.nombre_campo = "Hora Salida"
        Me.txt_horaSalida.Size = New System.Drawing.Size(48, 20)
        Me.txt_horaSalida.TabIndex = 0
        Me.txt_horaSalida.validable = True
        Me.txt_horaSalida.ValidatingType = GetType(Date)
        '
        'txt_fechaLlegada
        '
        Me.txt_fechaLlegada.Location = New System.Drawing.Point(227, 80)
        Me.txt_fechaLlegada.Mask = "00/00/0000"
        Me.txt_fechaLlegada.Name = "txt_fechaLlegada"
        Me.txt_fechaLlegada.nombre_campo = "Fecha Llegada"
        Me.txt_fechaLlegada.Size = New System.Drawing.Size(100, 20)
        Me.txt_fechaLlegada.TabIndex = 0
        Me.txt_fechaLlegada.validable = True
        Me.txt_fechaLlegada.ValidatingType = GetType(Date)
        '
        'txt_horaLlegada
        '
        Me.txt_horaLlegada.Location = New System.Drawing.Point(227, 106)
        Me.txt_horaLlegada.Mask = "00:00"
        Me.txt_horaLlegada.Name = "txt_horaLlegada"
        Me.txt_horaLlegada.nombre_campo = "Hora Llegada"
        Me.txt_horaLlegada.Size = New System.Drawing.Size(46, 20)
        Me.txt_horaLlegada.TabIndex = 0
        Me.txt_horaLlegada.validable = True
        Me.txt_horaLlegada.ValidatingType = GetType(Date)
        '
        'cmb_avion
        '
        Me.cmb_avion.FormattingEnabled = True
        Me.cmb_avion.Location = New System.Drawing.Point(430, 80)
        Me.cmb_avion.Name = "cmb_avion"
        Me.cmb_avion.nombre_campo = "Avion"
        Me.cmb_avion.Size = New System.Drawing.Size(121, 21)
        Me.cmb_avion.TabIndex = 1
        Me.cmb_avion.validable = True
        '
        'cmb_aeropuertoOrigen
        '
        Me.cmb_aeropuertoOrigen.FormattingEnabled = True
        Me.cmb_aeropuertoOrigen.Location = New System.Drawing.Point(126, 151)
        Me.cmb_aeropuertoOrigen.Name = "cmb_aeropuertoOrigen"
        Me.cmb_aeropuertoOrigen.nombre_campo = "Aeropuerto Origen"
        Me.cmb_aeropuertoOrigen.Size = New System.Drawing.Size(244, 21)
        Me.cmb_aeropuertoOrigen.TabIndex = 1
        Me.cmb_aeropuertoOrigen.validable = True
        '
        'cmb_aeropuertoDestino
        '
        Me.cmb_aeropuertoDestino.FormattingEnabled = True
        Me.cmb_aeropuertoDestino.Location = New System.Drawing.Point(126, 189)
        Me.cmb_aeropuertoDestino.Name = "cmb_aeropuertoDestino"
        Me.cmb_aeropuertoDestino.nombre_campo = "Aeropuerto Destino"
        Me.cmb_aeropuertoDestino.Size = New System.Drawing.Size(244, 21)
        Me.cmb_aeropuertoDestino.TabIndex = 1
        Me.cmb_aeropuertoDestino.validable = True
        '
        'cmb_estado
        '
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Items.AddRange(New Object() {"En Vuelo", "Demorado", "Cancelado", "Disponible"})
        Me.cmb_estado.Location = New System.Drawing.Point(430, 107)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.nombre_campo = "Estado"
        Me.cmb_estado.Size = New System.Drawing.Size(121, 21)
        Me.cmb_estado.TabIndex = 1
        Me.cmb_estado.validable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label3.Location = New System.Drawing.Point(92, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Salida"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label4.Location = New System.Drawing.Point(234, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Llegada"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Label1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label6.Location = New System.Drawing.Point(22, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Hora"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(369, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Label1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label8.Location = New System.Drawing.Point(22, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Fecha"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label9.Location = New System.Drawing.Point(369, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Avion"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label13.Location = New System.Drawing.Point(11, 151)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Aeropuerto Origen"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(65, 189)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Label1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label15.Location = New System.Drawing.Point(11, 189)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Aeropuerto Destino"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(369, 107)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Label1"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label17.Location = New System.Drawing.Point(369, 107)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Estado"
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_nuevo.FlatAppearance.BorderSize = 2
        Me.cmd_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_nuevo.Location = New System.Drawing.Point(12, 473)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevo.TabIndex = 3
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_grabar
        '
        Me.cmd_grabar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_grabar.FlatAppearance.BorderSize = 2
        Me.cmd_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_grabar.Location = New System.Drawing.Point(108, 473)
        Me.cmd_grabar.Name = "cmd_grabar"
        Me.cmd_grabar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_grabar.TabIndex = 3
        Me.cmd_grabar.Text = "Grabar"
        Me.cmd_grabar.UseVisualStyleBackColor = True
        '
        'cmd_borrar
        '
        Me.cmd_borrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_borrar.FlatAppearance.BorderSize = 2
        Me.cmd_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_borrar.Location = New System.Drawing.Point(231, 473)
        Me.cmd_borrar.Name = "cmd_borrar"
        Me.cmd_borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_borrar.TabIndex = 3
        Me.cmd_borrar.Text = "Borrar"
        Me.cmd_borrar.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.BackgroundColor = System.Drawing.Color.Chocolate
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(26, 238)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(590, 214)
        Me.DGV1.TabIndex = 4
        '
        'txt_Buscar
        '
        Me.txt_Buscar.Location = New System.Drawing.Point(108, 12)
        Me.txt_Buscar.Mask = "CCCCCCCCCCCCCCCCCCCCC"
        Me.txt_Buscar.Name = "txt_Buscar"
        Me.txt_Buscar.nombre_campo = Nothing
        Me.txt_Buscar.Size = New System.Drawing.Size(100, 20)
        Me.txt_Buscar.TabIndex = 0
        Me.txt_Buscar.validable = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label18.Location = New System.Drawing.Point(9, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Buscar Vuelo"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(717, -242)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Label1"
        '
        'cmd_buscar
        '
        Me.cmd_buscar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_buscar.FlatAppearance.BorderSize = 2
        Me.cmd_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_buscar.Location = New System.Drawing.Point(249, 12)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_buscar.TabIndex = 3
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'txt_id_vuelo
        '
        Me.txt_id_vuelo.Location = New System.Drawing.Point(574, 108)
        Me.txt_id_vuelo.Mask = "CCCCCCCCCCCCCCCCCCCCC"
        Me.txt_id_vuelo.Name = "txt_id_vuelo"
        Me.txt_id_vuelo.nombre_campo = Nothing
        Me.txt_id_vuelo.Size = New System.Drawing.Size(24, 20)
        Me.txt_id_vuelo.TabIndex = 0
        Me.txt_id_vuelo.validable = False
        '
        'ABM_Vuelos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(644, 508)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cmd_borrar)
        Me.Controls.Add(Me.cmd_grabar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_estado)
        Me.Controls.Add(Me.cmb_aeropuertoDestino)
        Me.Controls.Add(Me.cmb_aeropuertoOrigen)
        Me.Controls.Add(Me.cmb_avion)
        Me.Controls.Add(Me.txt_id_vuelo)
        Me.Controls.Add(Me.txt_Buscar)
        Me.Controls.Add(Me.txt_horaLlegada)
        Me.Controls.Add(Me.txt_fechaLlegada)
        Me.Controls.Add(Me.txt_horaSalida)
        Me.Controls.Add(Me.txt_FechaSalida)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ABM_Vuelos"
        Me.Text = "ABM_Vuelos"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_FechaSalida As MTB_01
    Friend WithEvents txt_horaSalida As MTB_01
    Friend WithEvents txt_fechaLlegada As MTB_01
    Friend WithEvents txt_horaLlegada As MTB_01
    Friend WithEvents cmb_avion As CMB_01
    Friend WithEvents cmb_aeropuertoOrigen As CMB_01
    Friend WithEvents cmb_aeropuertoDestino As CMB_01
    Friend WithEvents cmb_estado As CMB_01
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmd_nuevo As Button
    Friend WithEvents cmd_grabar As Button
    Friend WithEvents cmd_borrar As Button
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents txt_Buscar As MTB_01
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cmd_buscar As Button
    Friend WithEvents txt_id_vuelo As MTB_01
End Class
