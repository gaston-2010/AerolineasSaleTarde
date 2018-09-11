<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Avion
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
        Me.txt_nombre = New AerolineasSaleTarde.MTB_01()
        Me.cmb_tipoavion = New AerolineasSaleTarde.CMB_01()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_grabar = New System.Windows.Forms.Button()
        Me.cmd_borrar = New System.Windows.Forms.Button()
        Me.txt_id = New AerolineasSaleTarde.MTB_01()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo de Avion"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(205, 67)
        Me.txt_nombre.Mask = "LLLLLLLLLLLLLLLLL"
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.nombre_campo = "Nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 1
        Me.txt_nombre.validable = True
        '
        'cmb_tipoavion
        '
        Me.cmb_tipoavion.FormattingEnabled = True
        Me.cmb_tipoavion.Location = New System.Drawing.Point(205, 107)
        Me.cmb_tipoavion.Name = "cmb_tipoavion"
        Me.cmb_tipoavion.nombre_campo = "Tipo de Avion"
        Me.cmb_tipoavion.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipoavion.TabIndex = 2
        Me.cmb_tipoavion.validable = True
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(376, 48)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(240, 150)
        Me.DGV1.TabIndex = 3
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(109, 174)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevo.TabIndex = 4
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_grabar
        '
        Me.cmd_grabar.Location = New System.Drawing.Point(190, 174)
        Me.cmd_grabar.Name = "cmd_grabar"
        Me.cmd_grabar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_grabar.TabIndex = 4
        Me.cmd_grabar.Text = "Grabar"
        Me.cmd_grabar.UseVisualStyleBackColor = True
        '
        'cmd_borrar
        '
        Me.cmd_borrar.Location = New System.Drawing.Point(290, 202)
        Me.cmd_borrar.Name = "cmd_borrar"
        Me.cmd_borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_borrar.TabIndex = 4
        Me.cmd_borrar.Text = "Borrar"
        Me.cmd_borrar.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(205, 134)
        Me.txt_id.Mask = "99999"
        Me.txt_id.Name = "txt_id"
        Me.txt_id.nombre_campo = Nothing
        Me.txt_id.Size = New System.Drawing.Size(33, 20)
        Me.txt_id.TabIndex = 5
        Me.txt_id.validable = False
        Me.txt_id.ValidatingType = GetType(Integer)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(556, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ABM_Avion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 237)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.cmd_borrar)
        Me.Controls.Add(Me.cmd_grabar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.cmb_tipoavion)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ABM_Avion"
        Me.Text = "ABM_Avion"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nombre As MTB_01
    Friend WithEvents cmb_tipoavion As CMB_01
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents cmd_nuevo As Button
    Friend WithEvents cmd_grabar As Button
    Friend WithEvents cmd_borrar As Button
    Friend WithEvents txt_id As MTB_01
    Friend WithEvents Button1 As Button
End Class
