<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tools = New System.Windows.Forms.ToolStrip()
        Me.Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.AbrirArchivo = New System.Windows.Forms.ToolStripButton()
        Me.GuardarArchivo = New System.Windows.Forms.ToolStripButton()
        Me.GuardarComo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Edicion = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarEditor = New System.Windows.Forms.ToolStripButton()
        Me.Abrir = New System.Windows.Forms.OpenFileDialog()
        Me.AreaTexto = New System.Windows.Forms.TextBox()
        Me.Guardar = New System.Windows.Forms.SaveFileDialog()
        Me.StatusStrip1.SuspendLayout()
        Me.Tools.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 433)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(796, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(242, 17)
        Me.ToolStripStatusLabel1.Text = "Copyright © Yael Arturo Chavoya Andalón  |"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(61, 17)
        Me.ToolStripStatusLabel2.Text = "Preparado"
        '
        'Tools
        '
        Me.Tools.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nuevo, Me.AbrirArchivo, Me.GuardarArchivo, Me.GuardarComo, Me.ToolStripSeparator2, Me.Edicion, Me.ToolStripSeparator1, Me.CerrarEditor})
        Me.Tools.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.Tools.Location = New System.Drawing.Point(0, 0)
        Me.Tools.Name = "Tools"
        Me.Tools.Size = New System.Drawing.Size(796, 23)
        Me.Tools.TabIndex = 1
        Me.Tools.Text = "ToolStrip1"
        '
        'Nuevo
        '
        Me.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Nuevo.Image = Global.Episteme.My.Resources.Resources.Document
        Me.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(23, 20)
        Me.Nuevo.Text = "Nuevo"
        '
        'AbrirArchivo
        '
        Me.AbrirArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AbrirArchivo.Image = CType(resources.GetObject("AbrirArchivo.Image"), System.Drawing.Image)
        Me.AbrirArchivo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AbrirArchivo.Name = "AbrirArchivo"
        Me.AbrirArchivo.Size = New System.Drawing.Size(23, 20)
        Me.AbrirArchivo.Text = "Abrir"
        '
        'GuardarArchivo
        '
        Me.GuardarArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarArchivo.Image = Global.Episteme.My.Resources.Resources.Save
        Me.GuardarArchivo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarArchivo.Name = "GuardarArchivo"
        Me.GuardarArchivo.Size = New System.Drawing.Size(23, 20)
        Me.GuardarArchivo.Text = "Guardar"
        '
        'GuardarComo
        '
        Me.GuardarComo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarComo.Image = Global.Episteme.My.Resources.Resources.Save_as
        Me.GuardarComo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarComo.Name = "GuardarComo"
        Me.GuardarComo.Size = New System.Drawing.Size(23, 20)
        Me.GuardarComo.Text = "Guardar como"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'Edicion
        '
        Me.Edicion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Edicion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CortarToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.PegarToolStripMenuItem})
        Me.Edicion.Image = Global.Episteme.My.Resources.Resources.Clipboard
        Me.Edicion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Edicion.Name = "Edicion"
        Me.Edicion.Size = New System.Drawing.Size(29, 20)
        Me.Edicion.Text = "Edición"
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CortarToolStripMenuItem.Text = "Cortar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'CerrarEditor
        '
        Me.CerrarEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CerrarEditor.Image = Global.Episteme.My.Resources.Resources.Delete
        Me.CerrarEditor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CerrarEditor.Name = "CerrarEditor"
        Me.CerrarEditor.Size = New System.Drawing.Size(23, 20)
        Me.CerrarEditor.Text = "Salir"
        '
        'Abrir
        '
        Me.Abrir.FilterIndex = 2
        '
        'AreaTexto
        '
        Me.AreaTexto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AreaTexto.Location = New System.Drawing.Point(0, 23)
        Me.AreaTexto.Multiline = True
        Me.AreaTexto.Name = "AreaTexto"
        Me.AreaTexto.Size = New System.Drawing.Size(796, 410)
        Me.AreaTexto.TabIndex = 2
        '
        'Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(796, 455)
        Me.Controls.Add(Me.AreaTexto)
        Me.Controls.Add(Me.Tools)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Editor"
        Me.Text = "Editor de Texto"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Tools.ResumeLayout(False)
        Me.Tools.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Tools As System.Windows.Forms.ToolStrip
    Friend WithEvents AbrirArchivo As System.Windows.Forms.ToolStripButton
    Friend WithEvents GuardarArchivo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Abrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AreaTexto As System.Windows.Forms.TextBox
    Friend WithEvents Guardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GuardarComo As System.Windows.Forms.ToolStripButton
    Friend WithEvents CerrarEditor As System.Windows.Forms.ToolStripButton
    Friend WithEvents Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Edicion As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents CortarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
