<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Aeropuerto
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
        Me.txt_Nombre = New AerolineasSaleTarde.MTB_01()
        Me.cmb_cabotaje = New AerolineasSaleTarde.CMB_01()
        Me.txt_puertasembarque = New AerolineasSaleTarde.MTB_01()
        Me.txt_salaVip = New AerolineasSaleTarde.MTB_01()
        Me.txt_salaFumadores = New AerolineasSaleTarde.MTB_01()
        Me.cmb_localidad = New AerolineasSaleTarde.CMB_01()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.cmd_Grabar = New System.Windows.Forms.Button()
        Me.cmd_Borrar = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.txt_id = New AerolineasSaleTarde.MTB_01()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(85, 45)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.nombre_campo = "Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(198, 20)
        Me.txt_Nombre.TabIndex = 0
        Me.txt_Nombre.validable = True
        '
        'cmb_cabotaje
        '
        Me.cmb_cabotaje.FormattingEnabled = True
        Me.cmb_cabotaje.Items.AddRange(New Object() {"1 - Cabotaje", "2 - Internacional"})
        Me.cmb_cabotaje.Location = New System.Drawing.Point(150, 72)
        Me.cmb_cabotaje.Name = "cmb_cabotaje"
        Me.cmb_cabotaje.nombre_campo = "Cabotaje / Internacional"
        Me.cmb_cabotaje.Size = New System.Drawing.Size(121, 21)
        Me.cmb_cabotaje.TabIndex = 1
        Me.cmb_cabotaje.validable = True
        '
        'txt_puertasembarque
        '
        Me.txt_puertasembarque.Location = New System.Drawing.Point(171, 109)
        Me.txt_puertasembarque.Name = "txt_puertasembarque"
        Me.txt_puertasembarque.nombre_campo = "Cantidad Puertas de Embarque"
        Me.txt_puertasembarque.Size = New System.Drawing.Size(100, 20)
        Me.txt_puertasembarque.TabIndex = 2
        Me.txt_puertasembarque.validable = True
        '
        'txt_salaVip
        '
        Me.txt_salaVip.Location = New System.Drawing.Point(85, 148)
        Me.txt_salaVip.Name = "txt_salaVip"
        Me.txt_salaVip.nombre_campo = "Sala Vip"
        Me.txt_salaVip.Size = New System.Drawing.Size(100, 20)
        Me.txt_salaVip.TabIndex = 2
        Me.txt_salaVip.Text = "0"
        Me.txt_salaVip.validable = False
        '
        'txt_salaFumadores
        '
        Me.txt_salaFumadores.Location = New System.Drawing.Point(101, 180)
        Me.txt_salaFumadores.Name = "txt_salaFumadores"
        Me.txt_salaFumadores.nombre_campo = "Sala Fumadores"
        Me.txt_salaFumadores.Size = New System.Drawing.Size(100, 20)
        Me.txt_salaFumadores.TabIndex = 2
        Me.txt_salaFumadores.Text = "0"
        Me.txt_salaFumadores.validable = False
        '
        'cmb_localidad
        '
        Me.cmb_localidad.FormattingEnabled = True
        Me.cmb_localidad.Items.AddRange(New Object() {"1 - Cabotaje", "2 - Internacional"})
        Me.cmb_localidad.Location = New System.Drawing.Point(85, 223)
        Me.cmb_localidad.Name = "cmb_localidad"
        Me.cmb_localidad.nombre_campo = "Localidad"
        Me.cmb_localidad.Size = New System.Drawing.Size(121, 21)
        Me.cmb_localidad.TabIndex = 1
        Me.cmb_localidad.validable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cabotaje / Internacional"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cantidad Puertas de Embarque"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sala Vip"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Sala Fumadores"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Localidad"
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Location = New System.Drawing.Point(24, 278)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Nuevo.TabIndex = 4
        Me.cmd_Nuevo.Text = "Blanquear"
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'cmd_Grabar
        '
        Me.cmd_Grabar.Location = New System.Drawing.Point(131, 278)
        Me.cmd_Grabar.Name = "cmd_Grabar"
        Me.cmd_Grabar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Grabar.TabIndex = 4
        Me.cmd_Grabar.Text = "Grabar"
        Me.cmd_Grabar.UseVisualStyleBackColor = True
        '
        'cmd_Borrar
        '
        Me.cmd_Borrar.Location = New System.Drawing.Point(536, 278)
        Me.cmd_Borrar.Name = "cmd_Borrar"
        Me.cmd_Borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Borrar.TabIndex = 4
        Me.cmd_Borrar.Text = "Borrar"
        Me.cmd_Borrar.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(404, 50)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(301, 200)
        Me.DGV1.TabIndex = 5
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(272, 230)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.nombre_campo = Nothing
        Me.txt_id.Size = New System.Drawing.Size(38, 20)
        Me.txt_id.TabIndex = 6
        Me.txt_id.validable = False
        '
        'ABM_Aeropuerto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.cmd_Borrar)
        Me.Controls.Add(Me.cmd_Grabar)
        Me.Controls.Add(Me.cmd_Nuevo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_salaFumadores)
        Me.Controls.Add(Me.txt_salaVip)
        Me.Controls.Add(Me.cmb_localidad)
        Me.Controls.Add(Me.txt_puertasembarque)
        Me.Controls.Add(Me.cmb_cabotaje)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Name = "ABM_Aeropuerto"
        Me.Text = "ABM_Aeropuerto"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Nombre As MTB_01
    Friend WithEvents cmb_cabotaje As CMB_01
    Friend WithEvents txt_puertasembarque As MTB_01
    Friend WithEvents txt_salaVip As MTB_01
    Friend WithEvents txt_salaFumadores As MTB_01
    Friend WithEvents cmb_localidad As CMB_01
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmd_Nuevo As Button
    Friend WithEvents cmd_Grabar As Button
    Friend WithEvents cmd_Borrar As Button
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents txt_id As MTB_01
End Class
