<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Embarque
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
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.txt_peso = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_Especial = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_puertaEmbarque = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Especial = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_embarque = New System.Windows.Forms.Button()
        Me.cmb_Tdni = New AerolineasSaleTarde.CMB_01()
        Me.cmb_abordo = New AerolineasSaleTarde.CMB_01()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(126, 30)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(100, 20)
        Me.txt_dni.TabIndex = 0
        '
        'txt_peso
        '
        Me.txt_peso.Location = New System.Drawing.Point(66, 18)
        Me.txt_peso.Name = "txt_peso"
        Me.txt_peso.Size = New System.Drawing.Size(100, 20)
        Me.txt_peso.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(243, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero Documento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Peso"
        '
        'chk_Especial
        '
        Me.chk_Especial.AutoSize = True
        Me.chk_Especial.Location = New System.Drawing.Point(181, 20)
        Me.chk_Especial.Name = "chk_Especial"
        Me.chk_Especial.Size = New System.Drawing.Size(66, 17)
        Me.chk_Especial.TabIndex = 2
        Me.chk_Especial.Text = "Especial"
        Me.chk_Especial.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmb_Tdni)
        Me.Panel1.Controls.Add(Me.btn_buscar)
        Me.Panel1.Controls.Add(Me.txt_dni)
        Me.Panel1.Controls.Add(Me.txt_puertaEmbarque)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 77)
        Me.Panel1.TabIndex = 3
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(461, 29)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_puertaEmbarque
        '
        Me.txt_puertaEmbarque.Location = New System.Drawing.Point(663, 31)
        Me.txt_puertaEmbarque.Name = "txt_puertaEmbarque"
        Me.txt_puertaEmbarque.Size = New System.Drawing.Size(63, 20)
        Me.txt_puertaEmbarque.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(553, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Puerta de Embarque"
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(402, 14)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 2
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Especial, Me.Column2})
        Me.dgv1.Location = New System.Drawing.Point(24, 77)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(346, 167)
        Me.dgv1.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Peso Equipaje"
        Me.Column1.Name = "Column1"
        '
        'Especial
        '
        Me.Especial.HeaderText = "Especial"
        Me.Especial.Name = "Especial"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Abordo/Bodega"
        Me.Column2.Name = "Column2"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmb_abordo)
        Me.Panel2.Controls.Add(Me.dgv1)
        Me.Panel2.Controls.Add(Me.txt_peso)
        Me.Panel2.Controls.Add(Me.btn_agregar)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.chk_Especial)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 270)
        Me.Panel2.TabIndex = 5
        '
        'btn_embarque
        '
        Me.btn_embarque.Location = New System.Drawing.Point(655, 358)
        Me.btn_embarque.Name = "btn_embarque"
        Me.btn_embarque.Size = New System.Drawing.Size(119, 23)
        Me.btn_embarque.TabIndex = 2
        Me.btn_embarque.Text = "Realizar Embarque"
        Me.btn_embarque.UseVisualStyleBackColor = True
        '
        'cmb_Tdni
        '
        Me.cmb_Tdni.FormattingEnabled = True
        Me.cmb_Tdni.Location = New System.Drawing.Point(334, 31)
        Me.cmb_Tdni.Name = "cmb_Tdni"
        Me.cmb_Tdni.nombre_campo = Nothing
        Me.cmb_Tdni.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Tdni.TabIndex = 3
        Me.cmb_Tdni.validable = True
        '
        'cmb_abordo
        '
        Me.cmb_abordo.FormattingEnabled = True
        Me.cmb_abordo.Location = New System.Drawing.Point(263, 17)
        Me.cmb_abordo.Name = "cmb_abordo"
        Me.cmb_abordo.nombre_campo = Nothing
        Me.cmb_abordo.Size = New System.Drawing.Size(121, 21)
        Me.cmb_abordo.TabIndex = 5
        Me.cmb_abordo.validable = True
        '
        'Embarque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 393)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_embarque)
        Me.Name = "Embarque"
        Me.Text = "Embarque"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents txt_peso As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chk_Especial As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_puertaEmbarque As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_agregar As Button
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Especial As DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_embarque As Button
    Friend WithEvents cmb_Tdni As CMB_01
    Friend WithEvents cmb_abordo As CMB_01
End Class
