<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Escritorio
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoAvionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DestinosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ABMToolStripMenuItem
        '
        Me.ABMToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AvionToolStripMenuItem, Me.TipoAvionToolStripMenuItem, Me.DestinosToolStripMenuItem})
        Me.ABMToolStripMenuItem.Name = "ABMToolStripMenuItem"
        Me.ABMToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ABMToolStripMenuItem.Text = "ABM"
        '
        'AvionToolStripMenuItem
        '
        Me.AvionToolStripMenuItem.Name = "AvionToolStripMenuItem"
        Me.AvionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AvionToolStripMenuItem.Text = "Avion"
        '
        'TipoAvionToolStripMenuItem
        '
        Me.TipoAvionToolStripMenuItem.Name = "TipoAvionToolStripMenuItem"
        Me.TipoAvionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TipoAvionToolStripMenuItem.Text = "Tipo Avion"
        '
        'DestinosToolStripMenuItem
        '
        Me.DestinosToolStripMenuItem.Name = "DestinosToolStripMenuItem"
        Me.DestinosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DestinosToolStripMenuItem.Text = "Destinos"
        '
        'Escritorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Escritorio"
        Me.Text = "Escritorio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoAvionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DestinosToolStripMenuItem As ToolStripMenuItem
End Class
