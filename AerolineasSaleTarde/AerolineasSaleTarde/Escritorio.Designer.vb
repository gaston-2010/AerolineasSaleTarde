<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Escritorio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMAvionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMTIpoDeAvionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMToolStripMenuItem})
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'ABMToolStripMenuItem
        '
        Me.ABMToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMAvionToolStripMenuItem, Me.ABMTIpoDeAvionToolStripMenuItem})
        Me.ABMToolStripMenuItem.Name = "ABMToolStripMenuItem"
        Me.ABMToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.ABMToolStripMenuItem.Text = "ABM"
        '
        'ABMAvionToolStripMenuItem
        '
        Me.ABMAvionToolStripMenuItem.Name = "ABMAvionToolStripMenuItem"
        Me.ABMAvionToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ABMAvionToolStripMenuItem.Text = "ABM Avion"
        '
        'ABMTIpoDeAvionToolStripMenuItem
        '
        Me.ABMTIpoDeAvionToolStripMenuItem.Name = "ABMTIpoDeAvionToolStripMenuItem"
        Me.ABMTIpoDeAvionToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ABMTIpoDeAvionToolStripMenuItem.Text = "ABM Tipo de Avion"
        '
        'Escritorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Escritorio"
        Me.Text = "Escritorio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMAvionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMTIpoDeAvionToolStripMenuItem As ToolStripMenuItem
End Class
