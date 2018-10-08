<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta_Pasaje
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cmd_Buscar = New System.Windows.Forms.Button()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.cmd_Grabar = New System.Windows.Forms.Button()
        Me.cmd_Borrar = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_vuelo = New AerolineasSaleTarde.CMB_01()
        Me.cmb_clase = New AerolineasSaleTarde.CMB_01()
        Me.txt_nroAsiento = New AerolineasSaleTarde.MTB_01()
        Me.cmb_tipoPasaje = New AerolineasSaleTarde.CMB_01()
        Me.txt_nombre = New AerolineasSaleTarde.MTB_01()
        Me.txt_Apellido = New AerolineasSaleTarde.MTB_01()
        Me.txt_nroDocumento = New AerolineasSaleTarde.MTB_01()
        Me.cmb_tipoDocumento = New AerolineasSaleTarde.CMB_01()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(52, 220)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(156, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Necesita Atencion Especial"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cmd_Buscar
        '
        Me.cmd_Buscar.Location = New System.Drawing.Point(262, 45)
        Me.cmd_Buscar.Name = "cmd_Buscar"
        Me.cmd_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Buscar.TabIndex = 9
        Me.cmd_Buscar.Text = "Buscar"
        Me.cmd_Buscar.UseVisualStyleBackColor = True
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Location = New System.Drawing.Point(42, 386)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Nuevo.TabIndex = 10
        Me.cmd_Nuevo.Text = "Blanquear"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'cmd_Grabar
        '
        Me.cmd_Grabar.Location = New System.Drawing.Point(148, 386)
        Me.cmd_Grabar.Name = "cmd_Grabar"
        Me.cmd_Grabar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Grabar.TabIndex = 10
        Me.cmd_Grabar.Text = "Grabar"
        Me.cmd_Grabar.UseVisualStyleBackColor = True
        '
        'cmd_Borrar
        '
        Me.cmd_Borrar.Location = New System.Drawing.Point(504, 386)
        Me.cmd_Borrar.Name = "cmd_Borrar"
        Me.cmd_Borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Borrar.TabIndex = 9
        Me.cmd_Borrar.Text = "Borrar"
        Me.cmd_Borrar.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(403, 45)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(332, 282)
        Me.DGV1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tipo y Nº Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Label1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Apellido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(184, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Vuelo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Tipo Pasaje"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Nº Asiento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Clase"
        '
        'cmb_vuelo
        '
        Me.cmb_vuelo.FormattingEnabled = True
        Me.cmb_vuelo.Location = New System.Drawing.Point(55, 125)
        Me.cmb_vuelo.Name = "cmb_vuelo"
        Me.cmb_vuelo.nombre_campo = "Vuelo"
        Me.cmb_vuelo.Size = New System.Drawing.Size(121, 21)
        Me.cmb_vuelo.TabIndex = 13
        Me.cmb_vuelo.validable = True
        '
        'cmb_clase
        '
        Me.cmb_clase.FormattingEnabled = True
        Me.cmb_clase.Items.AddRange(New Object() {"Turista", "Primera Clase"})
        Me.cmb_clase.Location = New System.Drawing.Point(52, 306)
        Me.cmb_clase.Name = "cmb_clase"
        Me.cmb_clase.nombre_campo = "Clase"
        Me.cmb_clase.Size = New System.Drawing.Size(121, 21)
        Me.cmb_clase.TabIndex = 8
        Me.cmb_clase.validable = True
        '
        'txt_nroAsiento
        '
        Me.txt_nroAsiento.Location = New System.Drawing.Point(70, 261)
        Me.txt_nroAsiento.Name = "txt_nroAsiento"
        Me.txt_nroAsiento.nombre_campo = "Nº Asiento"
        Me.txt_nroAsiento.Size = New System.Drawing.Size(100, 20)
        Me.txt_nroAsiento.TabIndex = 7
        Me.txt_nroAsiento.validable = True
        '
        'cmb_tipoPasaje
        '
        Me.cmb_tipoPasaje.FormattingEnabled = True
        Me.cmb_tipoPasaje.Items.AddRange(New Object() {"1 - Bebe", "2 - Niño", "3 - Adulto"})
        Me.cmb_tipoPasaje.Location = New System.Drawing.Point(76, 178)
        Me.cmb_tipoPasaje.Name = "cmb_tipoPasaje"
        Me.cmb_tipoPasaje.nombre_campo = Nothing
        Me.cmb_tipoPasaje.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipoPasaje.TabIndex = 5
        Me.cmb_tipoPasaje.validable = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(176, 89)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.nombre_campo = "Nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 4
        Me.txt_nombre.validable = False
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Location = New System.Drawing.Point(52, 89)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.nombre_campo = "Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(100, 20)
        Me.txt_Apellido.TabIndex = 3
        Me.txt_Apellido.validable = False
        '
        'txt_nroDocumento
        '
        Me.txt_nroDocumento.Location = New System.Drawing.Point(123, 45)
        Me.txt_nroDocumento.Name = "txt_nroDocumento"
        Me.txt_nroDocumento.nombre_campo = "Numero Documento"
        Me.txt_nroDocumento.Size = New System.Drawing.Size(100, 20)
        Me.txt_nroDocumento.TabIndex = 2
        Me.txt_nroDocumento.validable = True
        '
        'cmb_tipoDocumento
        '
        Me.cmb_tipoDocumento.FormattingEnabled = True
        Me.cmb_tipoDocumento.Location = New System.Drawing.Point(52, 45)
        Me.cmb_tipoDocumento.Name = "cmb_tipoDocumento"
        Me.cmb_tipoDocumento.nombre_campo = "Tipo Documento"
        Me.cmb_tipoDocumento.Size = New System.Drawing.Size(65, 21)
        Me.cmb_tipoDocumento.TabIndex = 0
        Me.cmb_tipoDocumento.validable = True
        '
        'Venta_Pasaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmb_vuelo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.cmd_Grabar)
        Me.Controls.Add(Me.cmd_Nuevo)
        Me.Controls.Add(Me.cmd_Borrar)
        Me.Controls.Add(Me.cmd_Buscar)
        Me.Controls.Add(Me.cmb_clase)
        Me.Controls.Add(Me.txt_nroAsiento)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.cmb_tipoPasaje)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_Apellido)
        Me.Controls.Add(Me.txt_nroDocumento)
        Me.Controls.Add(Me.cmb_tipoDocumento)
        Me.Name = "Venta_Pasaje"
        Me.Text = "Venta_Pasaje"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_tipoDocumento As CMB_01
    Friend WithEvents txt_nroDocumento As MTB_01
    Friend WithEvents txt_Apellido As MTB_01
    Friend WithEvents txt_nombre As MTB_01
    Friend WithEvents cmb_tipoPasaje As CMB_01
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txt_nroAsiento As MTB_01
    Friend WithEvents cmb_clase As CMB_01
    Friend WithEvents cmd_Buscar As Button
    Friend WithEvents cmd_Nuevo As Button
    Friend WithEvents cmd_Grabar As Button
    Friend WithEvents cmd_Borrar As Button
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_vuelo As CMB_01
End Class
