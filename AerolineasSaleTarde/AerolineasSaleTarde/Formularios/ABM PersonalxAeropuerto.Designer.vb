<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_PersonalxAeropuerto
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
        Me.cmb_avion = New AerolineasSaleTarde.CMB_01()
        Me.cmb_puesto = New AerolineasSaleTarde.CMB_01()
        Me.txt_Legajo = New AerolineasSaleTarde.MTB_01()
        Me.txt_apellido = New AerolineasSaleTarde.MTB_01()
        Me.txt_nombre = New AerolineasSaleTarde.MTB_01()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmd_Buscar = New System.Windows.Forms.Button()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.cmd_Grabar = New System.Windows.Forms.Button()
        Me.cmd_Borrar = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_avion
        '
        Me.cmb_avion.FormattingEnabled = True
        Me.cmb_avion.Location = New System.Drawing.Point(119, 130)
        Me.cmb_avion.Name = "cmb_avion"
        Me.cmb_avion.nombre_campo = Nothing
        Me.cmb_avion.Size = New System.Drawing.Size(121, 21)
        Me.cmb_avion.TabIndex = 0
        Me.cmb_avion.validable = True
        '
        'cmb_puesto
        '
        Me.cmb_puesto.FormattingEnabled = True
        Me.cmb_puesto.Location = New System.Drawing.Point(119, 182)
        Me.cmb_puesto.Name = "cmb_puesto"
        Me.cmb_puesto.nombre_campo = Nothing
        Me.cmb_puesto.Size = New System.Drawing.Size(121, 21)
        Me.cmb_puesto.TabIndex = 0
        Me.cmb_puesto.validable = True
        '
        'txt_Legajo
        '
        Me.txt_Legajo.Location = New System.Drawing.Point(119, 39)
        Me.txt_Legajo.Name = "txt_Legajo"
        Me.txt_Legajo.nombre_campo = "Legajo"
        Me.txt_Legajo.Size = New System.Drawing.Size(100, 20)
        Me.txt_Legajo.TabIndex = 1
        Me.txt_Legajo.validable = True
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(119, 82)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.nombre_campo = "Apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(100, 20)
        Me.txt_apellido.TabIndex = 1
        Me.txt_apellido.validable = False
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(263, 82)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.nombre_campo = "Nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 1
        Me.txt_nombre.validable = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Legajo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(289, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Vuelo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Puesto"
        '
        'cmd_Buscar
        '
        Me.cmd_Buscar.Location = New System.Drawing.Point(263, 28)
        Me.cmd_Buscar.Name = "cmd_Buscar"
        Me.cmd_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Buscar.TabIndex = 3
        Me.cmd_Buscar.Text = "Buscar"
        Me.cmd_Buscar.UseVisualStyleBackColor = True
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Location = New System.Drawing.Point(108, 239)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Nuevo.TabIndex = 3
        Me.cmd_Nuevo.Text = "Nuevo"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'cmd_Grabar
        '
        Me.cmd_Grabar.Location = New System.Drawing.Point(225, 239)
        Me.cmd_Grabar.Name = "cmd_Grabar"
        Me.cmd_Grabar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Grabar.TabIndex = 3
        Me.cmd_Grabar.Text = "Grabar"
        Me.cmd_Grabar.UseVisualStyleBackColor = True
        '
        'cmd_Borrar
        '
        Me.cmd_Borrar.Location = New System.Drawing.Point(323, 239)
        Me.cmd_Borrar.Name = "cmd_Borrar"
        Me.cmd_Borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Borrar.TabIndex = 3
        Me.cmd_Borrar.Text = "Borrar"
        Me.cmd_Borrar.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(453, 53)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(279, 179)
        Me.DGV1.TabIndex = 4
        '
        'ABM_PersonalxAeropuerto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 269)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.cmd_Borrar)
        Me.Controls.Add(Me.cmd_Grabar)
        Me.Controls.Add(Me.cmd_Nuevo)
        Me.Controls.Add(Me.cmd_Buscar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_Legajo)
        Me.Controls.Add(Me.cmb_puesto)
        Me.Controls.Add(Me.cmb_avion)
        Me.Name = "ABM_PersonalxAeropuerto"
        Me.Text = "ABM_PersonalxAeropuerto"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_avion As CMB_01
    Friend WithEvents cmb_puesto As CMB_01
    Friend WithEvents txt_Legajo As MTB_01
    Friend WithEvents txt_apellido As MTB_01
    Friend WithEvents txt_nombre As MTB_01
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmd_Buscar As Button
    Friend WithEvents cmd_Nuevo As Button
    Friend WithEvents cmd_Grabar As Button
    Friend WithEvents cmd_Borrar As Button
    Friend WithEvents DGV1 As DataGridView
End Class
