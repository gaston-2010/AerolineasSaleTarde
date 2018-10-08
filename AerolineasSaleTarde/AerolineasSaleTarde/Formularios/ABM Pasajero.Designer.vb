<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Pasajero
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
        Me.txt_nroDocumento = New AerolineasSaleTarde.MTB_01()
        Me.cmb_tipoDocumento = New AerolineasSaleTarde.CMB_01()
        Me.txt_nacionalidad = New AerolineasSaleTarde.MTB_01()
        Me.txt_nombre = New AerolineasSaleTarde.MTB_01()
        Me.txt_Apellido = New AerolineasSaleTarde.MTB_01()
        Me.cmb_sexo = New AerolineasSaleTarde.CMB_01()
        Me.txt_calle = New AerolineasSaleTarde.MTB_01()
        Me.txt_nroCalle = New AerolineasSaleTarde.MTB_01()
        Me.cmb_Pais = New AerolineasSaleTarde.CMB_01()
        Me.cmb_motivo = New AerolineasSaleTarde.CMB_01()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_departamento = New AerolineasSaleTarde.MTB_01()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_localidad = New AerolineasSaleTarde.CMB_01()
        Me.cmd_Buscar = New System.Windows.Forms.Button()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.cmd_Grabar = New System.Windows.Forms.Button()
        Me.cmd_Borrar = New System.Windows.Forms.Button()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nroDocumento
        '
        Me.txt_nroDocumento.Location = New System.Drawing.Point(184, 31)
        Me.txt_nroDocumento.Mask = "9999999999999999"
        Me.txt_nroDocumento.Name = "txt_nroDocumento"
        Me.txt_nroDocumento.nombre_campo = "Numero Documento"
        Me.txt_nroDocumento.Size = New System.Drawing.Size(129, 20)
        Me.txt_nroDocumento.TabIndex = 0
        Me.txt_nroDocumento.validable = True
        '
        'cmb_tipoDocumento
        '
        Me.cmb_tipoDocumento.FormattingEnabled = True
        Me.cmb_tipoDocumento.Location = New System.Drawing.Point(95, 31)
        Me.cmb_tipoDocumento.Name = "cmb_tipoDocumento"
        Me.cmb_tipoDocumento.nombre_campo = "Tipo Documento"
        Me.cmb_tipoDocumento.Size = New System.Drawing.Size(58, 21)
        Me.cmb_tipoDocumento.TabIndex = 1
        Me.cmb_tipoDocumento.validable = True
        '
        'txt_nacionalidad
        '
        Me.txt_nacionalidad.Location = New System.Drawing.Point(95, 157)
        Me.txt_nacionalidad.Name = "txt_nacionalidad"
        Me.txt_nacionalidad.nombre_campo = "Nacionalidad"
        Me.txt_nacionalidad.Size = New System.Drawing.Size(129, 20)
        Me.txt_nacionalidad.TabIndex = 0
        Me.txt_nacionalidad.validable = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(95, 76)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.nombre_campo = "Nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(129, 20)
        Me.txt_nombre.TabIndex = 0
        Me.txt_nombre.validable = True
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Location = New System.Drawing.Point(95, 118)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.nombre_campo = "Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(129, 20)
        Me.txt_Apellido.TabIndex = 0
        Me.txt_Apellido.validable = True
        '
        'cmb_sexo
        '
        Me.cmb_sexo.FormattingEnabled = True
        Me.cmb_sexo.Items.AddRange(New Object() {"Masculino", "Femenino", "Sin Definir"})
        Me.cmb_sexo.Location = New System.Drawing.Point(95, 200)
        Me.cmb_sexo.Name = "cmb_sexo"
        Me.cmb_sexo.nombre_campo = "Sexo"
        Me.cmb_sexo.Size = New System.Drawing.Size(129, 21)
        Me.cmb_sexo.TabIndex = 1
        Me.cmb_sexo.validable = True
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(307, 97)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.nombre_campo = "Calle"
        Me.txt_calle.Size = New System.Drawing.Size(129, 20)
        Me.txt_calle.TabIndex = 0
        Me.txt_calle.validable = True
        '
        'txt_nroCalle
        '
        Me.txt_nroCalle.Location = New System.Drawing.Point(307, 139)
        Me.txt_nroCalle.Mask = "99999999999999"
        Me.txt_nroCalle.Name = "txt_nroCalle"
        Me.txt_nroCalle.nombre_campo = "Nº Calle"
        Me.txt_nroCalle.Size = New System.Drawing.Size(129, 20)
        Me.txt_nroCalle.TabIndex = 0
        Me.txt_nroCalle.validable = True
        '
        'cmb_Pais
        '
        Me.cmb_Pais.FormattingEnabled = True
        Me.cmb_Pais.Location = New System.Drawing.Point(307, 184)
        Me.cmb_Pais.Name = "cmb_Pais"
        Me.cmb_Pais.nombre_campo = "Pais"
        Me.cmb_Pais.Size = New System.Drawing.Size(129, 21)
        Me.cmb_Pais.TabIndex = 1
        Me.cmb_Pais.validable = True
        '
        'cmb_motivo
        '
        Me.cmb_motivo.FormattingEnabled = True
        Me.cmb_motivo.Items.AddRange(New Object() {"Ocio", "Trabajo", "Emergencia"})
        Me.cmb_motivo.Location = New System.Drawing.Point(95, 246)
        Me.cmb_motivo.Name = "cmb_motivo"
        Me.cmb_motivo.nombre_campo = "Motivo"
        Me.cmb_motivo.Size = New System.Drawing.Size(129, 21)
        Me.cmb_motivo.TabIndex = 1
        Me.cmb_motivo.validable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo Y Numero de Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nacionalidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Sexo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Motivo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(271, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Calle"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(256, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Nº Calle"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(274, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Pais"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(335, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Domicilio"
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(478, 76)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(273, 191)
        Me.DGV1.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(227, 222)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Departamento"
        '
        'txt_departamento
        '
        Me.txt_departamento.Location = New System.Drawing.Point(307, 222)
        Me.txt_departamento.Name = "txt_departamento"
        Me.txt_departamento.nombre_campo = "Departamento"
        Me.txt_departamento.Size = New System.Drawing.Size(129, 20)
        Me.txt_departamento.TabIndex = 0
        Me.txt_departamento.validable = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(248, 254)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Localidad"
        '
        'cmb_localidad
        '
        Me.cmb_localidad.FormattingEnabled = True
        Me.cmb_localidad.Location = New System.Drawing.Point(307, 254)
        Me.cmb_localidad.Name = "cmb_localidad"
        Me.cmb_localidad.nombre_campo = "Localidad"
        Me.cmb_localidad.Size = New System.Drawing.Size(129, 21)
        Me.cmb_localidad.TabIndex = 1
        Me.cmb_localidad.validable = True
        '
        'cmd_Buscar
        '
        Me.cmd_Buscar.Location = New System.Drawing.Point(338, 31)
        Me.cmd_Buscar.Name = "cmd_Buscar"
        Me.cmd_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Buscar.TabIndex = 12
        Me.cmd_Buscar.Text = "Buscar"
        Me.cmd_Buscar.UseVisualStyleBackColor = True
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Location = New System.Drawing.Point(95, 288)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Nuevo.TabIndex = 12
        Me.cmd_Nuevo.Text = "Blanquear"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'cmd_Grabar
        '
        Me.cmd_Grabar.Location = New System.Drawing.Point(226, 288)
        Me.cmd_Grabar.Name = "cmd_Grabar"
        Me.cmd_Grabar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Grabar.TabIndex = 12
        Me.cmd_Grabar.Text = "Grabar"
        Me.cmd_Grabar.UseVisualStyleBackColor = True
        '
        'cmd_Borrar
        '
        Me.cmd_Borrar.Location = New System.Drawing.Point(478, 301)
        Me.cmd_Borrar.Name = "cmd_Borrar"
        Me.cmd_Borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Borrar.TabIndex = 12
        Me.cmd_Borrar.Text = "Borrar"
        Me.cmd_Borrar.UseVisualStyleBackColor = True
        '
        'ABM_Pasajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmd_Borrar)
        Me.Controls.Add(Me.cmd_Grabar)
        Me.Controls.Add(Me.cmd_Nuevo)
        Me.Controls.Add(Me.cmd_Buscar)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_motivo)
        Me.Controls.Add(Me.cmb_localidad)
        Me.Controls.Add(Me.cmb_Pais)
        Me.Controls.Add(Me.cmb_sexo)
        Me.Controls.Add(Me.cmb_tipoDocumento)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_departamento)
        Me.Controls.Add(Me.txt_Apellido)
        Me.Controls.Add(Me.txt_nroCalle)
        Me.Controls.Add(Me.txt_calle)
        Me.Controls.Add(Me.txt_nacionalidad)
        Me.Controls.Add(Me.txt_nroDocumento)
        Me.Name = "ABM_Pasajero"
        Me.Text = "ABM_Pasajero"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nroDocumento As MTB_01
    Friend WithEvents cmb_tipoDocumento As CMB_01
    Friend WithEvents txt_nacionalidad As MTB_01
    Friend WithEvents txt_nombre As MTB_01
    Friend WithEvents txt_Apellido As MTB_01
    Friend WithEvents cmb_sexo As CMB_01
    Friend WithEvents txt_calle As MTB_01
    Friend WithEvents txt_nroCalle As MTB_01
    Friend WithEvents cmb_Pais As CMB_01
    Friend WithEvents cmb_motivo As CMB_01
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_departamento As MTB_01
    Friend WithEvents Label12 As Label
    Friend WithEvents cmb_localidad As CMB_01
    Friend WithEvents cmd_Buscar As Button
    Friend WithEvents cmd_Nuevo As Button
    Friend WithEvents cmd_Grabar As Button
    Friend WithEvents cmd_Borrar As Button
End Class
