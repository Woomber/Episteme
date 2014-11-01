<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChemDoc
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
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuTabs = New System.Windows.Forms.TabControl()
        Me.Oxidos = New System.Windows.Forms.TabPage()
        Me.MainTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Copyright = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Hidroxidos = New System.Windows.Forms.TabPage()
        Me.Hidracidos = New System.Windows.Forms.TabPage()
        Me.Hidruros = New System.Windows.Forms.TabPage()
        Me.Oxacidos = New System.Windows.Forms.TabPage()
        Me.Menu.SuspendLayout()
        Me.Status.SuspendLayout()
        Me.MenuTabs.SuspendLayout()
        Me.MainTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(420, 24)
        Me.Menu.TabIndex = 0
        Me.Menu.Text = "MenuStrip1"
        '
        'Status
        '
        Me.Status.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Copyright})
        Me.Status.Location = New System.Drawing.Point(0, 165)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(420, 22)
        Me.Status.TabIndex = 1
        Me.Status.Text = "StatusStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'MenuTabs
        '
        Me.MenuTabs.Controls.Add(Me.Oxidos)
        Me.MenuTabs.Controls.Add(Me.Hidroxidos)
        Me.MenuTabs.Controls.Add(Me.Hidracidos)
        Me.MenuTabs.Controls.Add(Me.Hidruros)
        Me.MenuTabs.Controls.Add(Me.Oxacidos)
        Me.MenuTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuTabs.Location = New System.Drawing.Point(3, 3)
        Me.MenuTabs.Name = "MenuTabs"
        Me.MenuTabs.SelectedIndex = 0
        Me.MenuTabs.Size = New System.Drawing.Size(414, 135)
        Me.MenuTabs.TabIndex = 2
        '
        'Oxidos
        '
        Me.Oxidos.Location = New System.Drawing.Point(4, 22)
        Me.Oxidos.Name = "Oxidos"
        Me.Oxidos.Padding = New System.Windows.Forms.Padding(3)
        Me.Oxidos.Size = New System.Drawing.Size(406, 109)
        Me.Oxidos.TabIndex = 1
        Me.Oxidos.Text = "Óxidos"
        Me.Oxidos.UseVisualStyleBackColor = True
        '
        'MainTable
        '
        Me.MainTable.ColumnCount = 1
        Me.MainTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainTable.Controls.Add(Me.MenuTabs, 0, 0)
        Me.MainTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTable.Location = New System.Drawing.Point(0, 24)
        Me.MainTable.Name = "MainTable"
        Me.MainTable.RowCount = 1
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainTable.Size = New System.Drawing.Size(420, 141)
        Me.MainTable.TabIndex = 3
        '
        'Copyright
        '
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(233, 17)
        Me.Copyright.Text = "Copyright © Yael Arturo Chavoya Andalón"
        '
        'Hidroxidos
        '
        Me.Hidroxidos.Location = New System.Drawing.Point(4, 22)
        Me.Hidroxidos.Name = "Hidroxidos"
        Me.Hidroxidos.Size = New System.Drawing.Size(580, 280)
        Me.Hidroxidos.TabIndex = 2
        Me.Hidroxidos.Text = "Hidróxidos"
        Me.Hidroxidos.UseVisualStyleBackColor = True
        '
        'Hidracidos
        '
        Me.Hidracidos.Location = New System.Drawing.Point(4, 22)
        Me.Hidracidos.Name = "Hidracidos"
        Me.Hidracidos.Size = New System.Drawing.Size(580, 280)
        Me.Hidracidos.TabIndex = 3
        Me.Hidracidos.Text = "Hidrácidos"
        Me.Hidracidos.UseVisualStyleBackColor = True
        '
        'Hidruros
        '
        Me.Hidruros.Location = New System.Drawing.Point(4, 22)
        Me.Hidruros.Name = "Hidruros"
        Me.Hidruros.Size = New System.Drawing.Size(580, 280)
        Me.Hidruros.TabIndex = 4
        Me.Hidruros.Text = "Hidruros"
        Me.Hidruros.UseVisualStyleBackColor = True
        '
        'Oxacidos
        '
        Me.Oxacidos.Location = New System.Drawing.Point(4, 22)
        Me.Oxacidos.Name = "Oxacidos"
        Me.Oxacidos.Size = New System.Drawing.Size(580, 280)
        Me.Oxacidos.TabIndex = 5
        Me.Oxacidos.Text = "Oxácidos"
        Me.Oxacidos.UseVisualStyleBackColor = True
        '
        'ChemDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 187)
        Me.Controls.Add(Me.MainTable)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Menu)
        Me.MainMenuStrip = Me.Menu
        Me.Name = "ChemDoc"
        Me.Text = "ChemDoc"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.MenuTabs.ResumeLayout(False)
        Me.MainTable.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents Status As System.Windows.Forms.StatusStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Copyright As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuTabs As System.Windows.Forms.TabControl
    Friend WithEvents Oxidos As System.Windows.Forms.TabPage
    Friend WithEvents Hidroxidos As System.Windows.Forms.TabPage
    Friend WithEvents Hidracidos As System.Windows.Forms.TabPage
    Friend WithEvents Hidruros As System.Windows.Forms.TabPage
    Friend WithEvents Oxacidos As System.Windows.Forms.TabPage
    Friend WithEvents MainTable As System.Windows.Forms.TableLayoutPanel
End Class
