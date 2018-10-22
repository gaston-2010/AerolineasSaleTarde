<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Personal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.cmd_Grabar = New System.Windows.Forms.Button()
        Me.cmd_Borrar = New System.Windows.Forms.Button()
        Me.cmd_Buscar = New System.Windows.Forms.Button()
        Me.txt_legajoBuscar = New AerolineasSaleTarde.MTB_01()
        Me.cmb_aeropuerto = New AerolineasSaleTarde.CMB_01()
        Me.txt_legajo = New AerolineasSaleTarde.MTB_01()
        Me.txt_fechanacimiento = New AerolineasSaleTarde.MTB_01()
        Me.txt_fechaingreso = New AerolineasSaleTarde.MTB_01()
        Me.txt_celular = New AerolineasSaleTarde.MTB_01()
        Me.txt_nombre = New AerolineasSaleTarde.MTB_01()
        Me.txt_apellido = New AerolineasSaleTarde.MTB_01()
        Me.txt_mail = New AerolineasSaleTarde.MTB_01()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Celular"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label4.Location = New System.Drawing.Point(12, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label5.Location = New System.Drawing.Point(340, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fecha Ingreso"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label6.Location = New System.Drawing.Point(340, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Aeropuerto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label7.Location = New System.Drawing.Point(340, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Fecha Nacimiento"
        '
        'DGV1
        '
        Me.DGV1.BackgroundColor = System.Drawing.Color.Chocolate
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(15, 238)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(583, 161)
        Me.DGV1.TabIndex = 11
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_Nuevo.FlatAppearance.BorderSize = 2
        Me.cmd_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_Nuevo.Location = New System.Drawing.Point(15, 426)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(75, 31)
        Me.cmd_Nuevo.TabIndex = 8
        Me.cmd_Nuevo.Text = "Nuevo"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'cmd_Grabar
        '
        Me.cmd_Grabar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_Grabar.FlatAppearance.BorderSize = 2
        Me.cmd_Grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_Grabar.Location = New System.Drawing.Point(107, 426)
        Me.cmd_Grabar.Name = "cmd_Grabar"
        Me.cmd_Grabar.Size = New System.Drawing.Size(75, 31)
        Me.cmd_Grabar.TabIndex = 9
        Me.cmd_Grabar.Text = "Grabar"
        Me.cmd_Grabar.UseVisualStyleBackColor = True
        '
        'cmd_Borrar
        '
        Me.cmd_Borrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_Borrar.FlatAppearance.BorderSize = 2
        Me.cmd_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_Borrar.Location = New System.Drawing.Point(214, 426)
        Me.cmd_Borrar.Name = "cmd_Borrar"
        Me.cmd_Borrar.Size = New System.Drawing.Size(75, 31)
        Me.cmd_Borrar.TabIndex = 10
        Me.cmd_Borrar.Text = "Borrar"
        Me.cmd_Borrar.UseVisualStyleBackColor = True
        '
        'cmd_Buscar
        '
        Me.cmd_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_Buscar.FlatAppearance.BorderSize = 2
        Me.cmd_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_Buscar.Location = New System.Drawing.Point(180, 14)
        Me.cmd_Buscar.Name = "cmd_Buscar"
        Me.cmd_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Buscar.TabIndex = 5
        Me.cmd_Buscar.Text = "Buscar"
        Me.cmd_Buscar.UseVisualStyleBackColor = True
        '
        'txt_legajoBuscar
        '
        Me.txt_legajoBuscar.Location = New System.Drawing.Point(12, 14)
        Me.txt_legajoBuscar.Name = "txt_legajoBuscar"
        Me.txt_legajoBuscar.nombre_campo = Nothing
        Me.txt_legajoBuscar.Size = New System.Drawing.Size(145, 20)
        Me.txt_legajoBuscar.TabIndex = 0
        Me.txt_legajoBuscar.validable = False
        '
        'cmb_aeropuerto
        '
        Me.cmb_aeropuerto.FormattingEnabled = True
        Me.cmb_aeropuerto.Location = New System.Drawing.Point(458, 109)
        Me.cmb_aeropuerto.Name = "cmb_aeropuerto"
        Me.cmb_aeropuerto.nombre_campo = Nothing
        Me.cmb_aeropuerto.Size = New System.Drawing.Size(121, 21)
        Me.cmb_aeropuerto.TabIndex = 6
        Me.cmb_aeropuerto.validable = True
        '
        'txt_legajo
        '
        Me.txt_legajo.Location = New System.Drawing.Point(15, 200)
        Me.txt_legajo.Name = "txt_legajo"
        Me.txt_legajo.nombre_campo = Nothing
        Me.txt_legajo.Size = New System.Drawing.Size(29, 20)
        Me.txt_legajo.TabIndex = 0
        Me.txt_legajo.validable = False
        '
        'txt_fechanacimiento
        '
        Me.txt_fechanacimiento.Location = New System.Drawing.Point(458, 161)
        Me.txt_fechanacimiento.Mask = "00/00/0000"
        Me.txt_fechanacimiento.Name = "txt_fechanacimiento"
        Me.txt_fechanacimiento.nombre_campo = "Fecha Nacimiento"
        Me.txt_fechanacimiento.Size = New System.Drawing.Size(100, 20)
        Me.txt_fechanacimiento.TabIndex = 7
        Me.txt_fechanacimiento.validable = True
        Me.txt_fechanacimiento.ValidatingType = GetType(Date)
        '
        'txt_fechaingreso
        '
        Me.txt_fechaingreso.Location = New System.Drawing.Point(458, 58)
        Me.txt_fechaingreso.Mask = "00/00/0000"
        Me.txt_fechaingreso.Name = "txt_fechaingreso"
        Me.txt_fechaingreso.nombre_campo = "Fecha Ingreso"
        Me.txt_fechaingreso.Size = New System.Drawing.Size(100, 20)
        Me.txt_fechaingreso.TabIndex = 5
        Me.txt_fechaingreso.validable = True
        Me.txt_fechaingreso.ValidatingType = GetType(Date)
        '
        'txt_celular
        '
        Me.txt_celular.Location = New System.Drawing.Point(107, 126)
        Me.txt_celular.Mask = "9999999999999"
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.nombre_campo = "Celular"
        Me.txt_celular.Size = New System.Drawing.Size(100, 20)
        Me.txt_celular.TabIndex = 3
        Me.txt_celular.validable = True
        Me.txt_celular.ValidatingType = GetType(Integer)
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(107, 91)
        Me.txt_nombre.Mask = "LLLLLLLLLLLLLL"
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.nombre_campo = "Nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 2
        Me.txt_nombre.validable = True
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(107, 56)
        Me.txt_apellido.Mask = "LLLLLLLLLLLLLLLLLLLLLL"
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.nombre_campo = "Apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(100, 20)
        Me.txt_apellido.TabIndex = 1
        Me.txt_apellido.validable = True
        '
        'txt_mail
        '
        Me.txt_mail.Location = New System.Drawing.Point(107, 161)
        Me.txt_mail.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC"
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.nombre_campo = "Email"
        Me.txt_mail.Size = New System.Drawing.Size(182, 20)
        Me.txt_mail.TabIndex = 4
        Me.txt_mail.validable = True
        '
        'ABM_Personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(628, 469)
        Me.Controls.Add(Me.cmd_Buscar)
        Me.Controls.Add(Me.cmd_Borrar)
        Me.Controls.Add(Me.cmd_Grabar)
        Me.Controls.Add(Me.cmd_Nuevo)
        Me.Controls.Add(Me.txt_legajoBuscar)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_aeropuerto)
        Me.Controls.Add(Me.txt_legajo)
        Me.Controls.Add(Me.txt_fechanacimiento)
        Me.Controls.Add(Me.txt_fechaingreso)
        Me.Controls.Add(Me.txt_mail)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_apellido)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ABM_Personal"
        Me.Text = "ABM_Personal"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_apellido As MTB_01
    Friend WithEvents txt_nombre As MTB_01
    Friend WithEvents txt_celular As MTB_01
    Friend WithEvents txt_fechaingreso As MTB_01
    Friend WithEvents txt_fechanacimiento As MTB_01
    Friend WithEvents cmb_aeropuerto As CMB_01
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_legajo As MTB_01
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents txt_legajoBuscar As MTB_01
    Friend WithEvents cmd_Nuevo As Button
    Friend WithEvents cmd_Grabar As Button
    Friend WithEvents cmd_Borrar As Button
    Friend WithEvents cmd_Buscar As Button
    Friend WithEvents txt_mail As MTB_01
End Class
