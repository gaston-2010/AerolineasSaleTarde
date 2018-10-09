<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta_Pasajes
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
        Me.cmd_Borrar = New System.Windows.Forms.Button()
        Me.cmd_Grabar = New System.Windows.Forms.Button()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_vuelo = New System.Windows.Forms.TextBox()
        Me.btn_buscarVuelo = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_comprar = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_clase = New AerolineasSaleTarde.CMB_01()
        Me.txt_nroAsiento = New AerolineasSaleTarde.MTB_01()
        Me.cmb_tipoPasaje = New AerolineasSaleTarde.CMB_01()
        Me.cmb_tipoDocumento = New AerolineasSaleTarde.CMB_01()
        Me.txt_nroDocumento = New AerolineasSaleTarde.MTB_01()
        Me.cmb_Pais = New AerolineasSaleTarde.CMB_01()
        Me.txt_nacionalidad = New AerolineasSaleTarde.MTB_01()
        Me.txt_calle = New AerolineasSaleTarde.MTB_01()
        Me.txt_nroCalle = New AerolineasSaleTarde.MTB_01()
        Me.txt_Apellido = New AerolineasSaleTarde.MTB_01()
        Me.txt_departamento = New AerolineasSaleTarde.MTB_01()
        Me.txt_nombre = New AerolineasSaleTarde.MTB_01()
        Me.cmb_sexo = New AerolineasSaleTarde.CMB_01()
        Me.cmb_localidad = New AerolineasSaleTarde.CMB_01()
        Me.cmb_motivo = New AerolineasSaleTarde.CMB_01()
        Me.cmb_origen = New AerolineasSaleTarde.CMB_01()
        Me.cmb_destino = New AerolineasSaleTarde.CMB_01()
        Me.txt_fecha = New AerolineasSaleTarde.MTB_01()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_Borrar
        '
        Me.cmd_Borrar.Location = New System.Drawing.Point(723, 99)
        Me.cmd_Borrar.Name = "cmd_Borrar"
        Me.cmd_Borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Borrar.TabIndex = 37
        Me.cmd_Borrar.Text = "Borrar"
        Me.cmd_Borrar.UseVisualStyleBackColor = True
        '
        'cmd_Grabar
        '
        Me.cmd_Grabar.Location = New System.Drawing.Point(723, 67)
        Me.cmd_Grabar.Name = "cmd_Grabar"
        Me.cmd_Grabar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Grabar.TabIndex = 36
        Me.cmd_Grabar.Text = "Cargar"
        Me.cmd_Grabar.UseVisualStyleBackColor = True
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Location = New System.Drawing.Point(723, 29)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Nuevo.TabIndex = 35
        Me.cmd_Nuevo.Text = "Blanquear"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.DGV1.Location = New System.Drawing.Point(622, 197)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(157, 89)
        Me.DGV1.TabIndex = 34
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Apellido"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "TipoDoc"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "NumDoc"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Nacionalidad"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sexo"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Calle"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "NCalle"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Pais"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Localidad"
        Me.Column9.Name = "Column9"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(209, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Pais"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(198, 156)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Localidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(198, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Departamento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(206, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Nº Calle"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(206, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Calle"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Motivo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Nacionalidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nombre"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_fecha)
        Me.Panel1.Controls.Add(Me.txt_vuelo)
        Me.Panel1.Controls.Add(Me.btn_buscarVuelo)
        Me.Panel1.Controls.Add(Me.cmb_origen)
        Me.Panel1.Controls.Add(Me.cmb_destino)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 117)
        Me.Panel1.TabIndex = 38
        '
        'txt_vuelo
        '
        Me.txt_vuelo.Location = New System.Drawing.Point(56, 79)
        Me.txt_vuelo.Name = "txt_vuelo"
        Me.txt_vuelo.Size = New System.Drawing.Size(100, 20)
        Me.txt_vuelo.TabIndex = 10
        '
        'btn_buscarVuelo
        '
        Me.btn_buscarVuelo.Location = New System.Drawing.Point(603, 37)
        Me.btn_buscarVuelo.Name = "btn_buscarVuelo"
        Me.btn_buscarVuelo.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscarVuelo.TabIndex = 9
        Me.btn_buscarVuelo.Text = "Buscar"
        Me.btn_buscarVuelo.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Location = New System.Drawing.Point(396, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 15)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Fecha"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(192, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Destino"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Origen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleecion de Vuelo"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.cmb_tipoDocumento)
        Me.Panel2.Controls.Add(Me.txt_nroDocumento)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.cmb_Pais)
        Me.Panel2.Controls.Add(Me.cmd_Nuevo)
        Me.Panel2.Controls.Add(Me.cmd_Grabar)
        Me.Panel2.Controls.Add(Me.cmd_Borrar)
        Me.Panel2.Controls.Add(Me.txt_nacionalidad)
        Me.Panel2.Controls.Add(Me.txt_calle)
        Me.Panel2.Controls.Add(Me.txt_nroCalle)
        Me.Panel2.Controls.Add(Me.DGV1)
        Me.Panel2.Controls.Add(Me.txt_Apellido)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txt_departamento)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txt_nombre)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.cmb_sexo)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.cmb_localidad)
        Me.Panel2.Controls.Add(Me.cmb_motivo)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(0, 117)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(810, 303)
        Me.Panel2.TabIndex = 39
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(408, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(151, 13)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "Tipo Y Numero de Documento"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Carga de Pasajeros"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_comprar)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.cmb_clase)
        Me.Panel3.Controls.Add(Me.txt_nroAsiento)
        Me.Panel3.Controls.Add(Me.CheckBox1)
        Me.Panel3.Controls.Add(Me.cmb_tipoPasaje)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(0, 314)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(810, 147)
        Me.Panel3.TabIndex = 40
        '
        'btn_comprar
        '
        Me.btn_comprar.Location = New System.Drawing.Point(704, 81)
        Me.btn_comprar.Name = "btn_comprar"
        Me.btn_comprar.Size = New System.Drawing.Size(75, 23)
        Me.btn_comprar.TabIndex = 20
        Me.btn_comprar.Text = "Comprar"
        Me.btn_comprar.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(198, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 13)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Clase"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(24, 81)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 13)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Nº Asiento"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(18, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 13)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Tipo Pasaje"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(230, 48)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(156, 17)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Necesita Atencion Especial"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Venta de Pasajes"
        '
        'cmb_clase
        '
        Me.cmb_clase.FormattingEnabled = True
        Me.cmb_clase.Items.AddRange(New Object() {"Turista", "Primera Clase"})
        Me.cmb_clase.Location = New System.Drawing.Point(243, 81)
        Me.cmb_clase.Name = "cmb_clase"
        Me.cmb_clase.nombre_campo = "Clase"
        Me.cmb_clase.Size = New System.Drawing.Size(121, 21)
        Me.cmb_clase.TabIndex = 16
        Me.cmb_clase.validable = True
        '
        'txt_nroAsiento
        '
        Me.txt_nroAsiento.Location = New System.Drawing.Point(87, 81)
        Me.txt_nroAsiento.Name = "txt_nroAsiento"
        Me.txt_nroAsiento.nombre_campo = "Nº Asiento"
        Me.txt_nroAsiento.Size = New System.Drawing.Size(100, 20)
        Me.txt_nroAsiento.TabIndex = 15
        Me.txt_nroAsiento.validable = True
        '
        'cmb_tipoPasaje
        '
        Me.cmb_tipoPasaje.FormattingEnabled = True
        Me.cmb_tipoPasaje.Items.AddRange(New Object() {"1 - Bebe", "2 - Niño", "3 - Adulto"})
        Me.cmb_tipoPasaje.Location = New System.Drawing.Point(87, 45)
        Me.cmb_tipoPasaje.Name = "cmb_tipoPasaje"
        Me.cmb_tipoPasaje.nombre_campo = Nothing
        Me.cmb_tipoPasaje.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipoPasaje.TabIndex = 13
        Me.cmb_tipoPasaje.validable = True
        '
        'cmb_tipoDocumento
        '
        Me.cmb_tipoDocumento.FormattingEnabled = True
        Me.cmb_tipoDocumento.Location = New System.Drawing.Point(411, 36)
        Me.cmb_tipoDocumento.Name = "cmb_tipoDocumento"
        Me.cmb_tipoDocumento.nombre_campo = "Tipo Documento"
        Me.cmb_tipoDocumento.Size = New System.Drawing.Size(58, 21)
        Me.cmb_tipoDocumento.TabIndex = 39
        Me.cmb_tipoDocumento.validable = True
        '
        'txt_nroDocumento
        '
        Me.txt_nroDocumento.Location = New System.Drawing.Point(500, 36)
        Me.txt_nroDocumento.Mask = "9999999999999999"
        Me.txt_nroDocumento.Name = "txt_nroDocumento"
        Me.txt_nroDocumento.nombre_campo = "Numero Documento"
        Me.txt_nroDocumento.Size = New System.Drawing.Size(129, 20)
        Me.txt_nroDocumento.TabIndex = 38
        Me.txt_nroDocumento.validable = True
        '
        'cmb_Pais
        '
        Me.cmb_Pais.FormattingEnabled = True
        Me.cmb_Pais.Location = New System.Drawing.Point(243, 94)
        Me.cmb_Pais.Name = "cmb_Pais"
        Me.cmb_Pais.nombre_campo = "Pais"
        Me.cmb_Pais.Size = New System.Drawing.Size(129, 21)
        Me.cmb_Pais.TabIndex = 20
        Me.cmb_Pais.validable = True
        '
        'txt_nacionalidad
        '
        Me.txt_nacionalidad.Location = New System.Drawing.Point(80, 95)
        Me.txt_nacionalidad.Name = "txt_nacionalidad"
        Me.txt_nacionalidad.nombre_campo = "Nacionalidad"
        Me.txt_nacionalidad.Size = New System.Drawing.Size(111, 20)
        Me.txt_nacionalidad.TabIndex = 13
        Me.txt_nacionalidad.validable = True
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(243, 36)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.nombre_campo = "Calle"
        Me.txt_calle.Size = New System.Drawing.Size(129, 20)
        Me.txt_calle.TabIndex = 18
        Me.txt_calle.validable = True
        '
        'txt_nroCalle
        '
        Me.txt_nroCalle.Location = New System.Drawing.Point(257, 61)
        Me.txt_nroCalle.Mask = "99999999999999"
        Me.txt_nroCalle.Name = "txt_nroCalle"
        Me.txt_nroCalle.nombre_campo = "Nº Calle"
        Me.txt_nroCalle.Size = New System.Drawing.Size(115, 20)
        Me.txt_nroCalle.TabIndex = 14
        Me.txt_nroCalle.validable = True
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Location = New System.Drawing.Point(62, 64)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.nombre_campo = "Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(129, 20)
        Me.txt_Apellido.TabIndex = 15
        Me.txt_Apellido.validable = True
        '
        'txt_departamento
        '
        Me.txt_departamento.Location = New System.Drawing.Point(276, 126)
        Me.txt_departamento.Name = "txt_departamento"
        Me.txt_departamento.nombre_campo = "Departamento"
        Me.txt_departamento.Size = New System.Drawing.Size(96, 20)
        Me.txt_departamento.TabIndex = 16
        Me.txt_departamento.validable = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(62, 36)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.nombre_campo = "Nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(129, 20)
        Me.txt_nombre.TabIndex = 17
        Me.txt_nombre.validable = True
        '
        'cmb_sexo
        '
        Me.cmb_sexo.FormattingEnabled = True
        Me.cmb_sexo.Items.AddRange(New Object() {"Masculino", "Femenino", "Sin Definir"})
        Me.cmb_sexo.Location = New System.Drawing.Point(62, 121)
        Me.cmb_sexo.Name = "cmb_sexo"
        Me.cmb_sexo.nombre_campo = "Sexo"
        Me.cmb_sexo.Size = New System.Drawing.Size(129, 21)
        Me.cmb_sexo.TabIndex = 19
        Me.cmb_sexo.validable = True
        '
        'cmb_localidad
        '
        Me.cmb_localidad.FormattingEnabled = True
        Me.cmb_localidad.Location = New System.Drawing.Point(257, 152)
        Me.cmb_localidad.Name = "cmb_localidad"
        Me.cmb_localidad.nombre_campo = "Localidad"
        Me.cmb_localidad.Size = New System.Drawing.Size(129, 21)
        Me.cmb_localidad.TabIndex = 21
        Me.cmb_localidad.validable = True
        '
        'cmb_motivo
        '
        Me.cmb_motivo.FormattingEnabled = True
        Me.cmb_motivo.Items.AddRange(New Object() {"Ocio", "Trabajo", "Emergencia"})
        Me.cmb_motivo.Location = New System.Drawing.Point(62, 148)
        Me.cmb_motivo.Name = "cmb_motivo"
        Me.cmb_motivo.nombre_campo = "Motivo"
        Me.cmb_motivo.Size = New System.Drawing.Size(129, 21)
        Me.cmb_motivo.TabIndex = 22
        Me.cmb_motivo.validable = True
        '
        'cmb_origen
        '
        Me.cmb_origen.FormattingEnabled = True
        Me.cmb_origen.Location = New System.Drawing.Point(56, 40)
        Me.cmb_origen.Name = "cmb_origen"
        Me.cmb_origen.nombre_campo = Nothing
        Me.cmb_origen.Size = New System.Drawing.Size(121, 21)
        Me.cmb_origen.TabIndex = 8
        Me.cmb_origen.validable = True
        '
        'cmb_destino
        '
        Me.cmb_destino.FormattingEnabled = True
        Me.cmb_destino.Location = New System.Drawing.Point(242, 40)
        Me.cmb_destino.Name = "cmb_destino"
        Me.cmb_destino.nombre_campo = Nothing
        Me.cmb_destino.Size = New System.Drawing.Size(121, 21)
        Me.cmb_destino.TabIndex = 7
        Me.cmb_destino.validable = True
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(476, 41)
        Me.txt_fecha.Mask = "00/00/0000"
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.nombre_campo = Nothing
        Me.txt_fecha.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha.TabIndex = 11
        Me.txt_fecha.validable = True
        Me.txt_fecha.ValidatingType = GetType(Date)
        '
        'Venta_Pasajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 461)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Venta_Pasajes"
        Me.Text = "Venta_Pasajes"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmd_Borrar As Button
    Friend WithEvents cmd_Grabar As Button
    Friend WithEvents cmd_Nuevo As Button
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_motivo As CMB_01
    Friend WithEvents cmb_localidad As CMB_01
    Friend WithEvents cmb_Pais As CMB_01
    Friend WithEvents cmb_sexo As CMB_01
    Friend WithEvents txt_nombre As MTB_01
    Friend WithEvents txt_departamento As MTB_01
    Friend WithEvents txt_Apellido As MTB_01
    Friend WithEvents txt_nroCalle As MTB_01
    Friend WithEvents txt_calle As MTB_01
    Friend WithEvents txt_nacionalidad As MTB_01
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_buscarVuelo As Button
    Friend WithEvents cmb_origen As CMB_01
    Friend WithEvents cmb_destino As CMB_01
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_comprar As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cmb_clase As CMB_01
    Friend WithEvents txt_nroAsiento As MTB_01
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cmb_tipoPasaje As CMB_01
    Friend WithEvents Label20 As Label
    Friend WithEvents cmb_tipoDocumento As CMB_01
    Friend WithEvents txt_nroDocumento As MTB_01
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents txt_vuelo As TextBox
    Friend WithEvents txt_fecha As MTB_01
End Class
