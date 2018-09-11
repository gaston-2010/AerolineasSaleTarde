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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ABMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMAvionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMTipoDeAvionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 48)
        Me.ContextMenuStrip1.Text = "MENU"
        '
        'ABMToolStripMenuItem
        '
        Me.ABMToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMAvionToolStripMenuItem, Me.ABMTipoDeAvionToolStripMenuItem})
        Me.ABMToolStripMenuItem.Name = "ABMToolStripMenuItem"
        Me.ABMToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ABMToolStripMenuItem.Text = "ABM"
        '
        'ABMAvionToolStripMenuItem
        '
        Me.ABMAvionToolStripMenuItem.Name = "ABMAvionToolStripMenuItem"
        Me.ABMAvionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ABMAvionToolStripMenuItem.Text = "ABM Avion"
        '
        'ABMTipoDeAvionToolStripMenuItem
        '
        Me.ABMTipoDeAvionToolStripMenuItem.Name = "ABMTipoDeAvionToolStripMenuItem"
        Me.ABMTipoDeAvionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ABMTipoDeAvionToolStripMenuItem.Text = "ABM Tipo de Avion"
        '
        'Escritorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Name = "Escritorio"
        Me.Text = "Escritorio"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ABMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMAvionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMTipoDeAvionToolStripMenuItem As ToolStripMenuItem
End Class
