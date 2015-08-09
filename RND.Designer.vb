<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RNDGen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RNDGen))
        Me.Generar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MinV = New System.Windows.Forms.NumericUpDown()
        Me.MaxV = New System.Windows.Forms.NumericUpDown()
        Me.Times = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Estado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Resultados = New System.Windows.Forms.ListBox()
        Me.ContextR = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guardado = New System.Windows.Forms.SaveFileDialog()
        CType(Me.MinV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Times, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ContextR.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Generar
        '
        Me.Generar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Generar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Generar.Location = New System.Drawing.Point(3, 16)
        Me.Generar.Name = "Generar"
        Me.Generar.Size = New System.Drawing.Size(102, 71)
        Me.Generar.TabIndex = 1
        Me.Generar.Text = "Generar"
        Me.Generar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Valor mínimo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valor máximo:"
        '
        'MinV
        '
        Me.MinV.Location = New System.Drawing.Point(6, 29)
        Me.MinV.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.MinV.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.MinV.Name = "MinV"
        Me.MinV.Size = New System.Drawing.Size(86, 20)
        Me.MinV.TabIndex = 4
        '
        'MaxV
        '
        Me.MaxV.Location = New System.Drawing.Point(6, 65)
        Me.MaxV.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.MaxV.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.MaxV.Name = "MaxV"
        Me.MaxV.Size = New System.Drawing.Size(86, 20)
        Me.MaxV.TabIndex = 5
        '
        'Times
        '
        Me.Times.Location = New System.Drawing.Point(6, 104)
        Me.Times.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.Times.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Times.Name = "Times"
        Me.Times.Size = New System.Drawing.Size(86, 20)
        Me.Times.TabIndex = 6
        Me.Times.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Repetir:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.MinV)
        Me.GroupBox1.Controls.Add(Me.Times)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.MaxV)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(108, 137)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parámetros"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Resultados, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 386.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(485, 265)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TableLayoutPanel1.SetColumnSpan(Me.StatusStrip1, 2)
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Estado})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 245)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(485, 20)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Estado
        '
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(61, 15)
        Me.Estado.Text = "Preparado"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(114, 239)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Generar)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(108, 90)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Simulación"
        '
        'Resultados
        '
        Me.Resultados.ContextMenuStrip = Me.ContextR
        Me.Resultados.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Resultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Resultados.FormattingEnabled = True
        Me.Resultados.Items.AddRange(New Object() {"RND", "Copyright © 2014 - 2015", "Yael Arturo Chavoya Andalón"})
        Me.Resultados.Location = New System.Drawing.Point(123, 3)
        Me.Resultados.Name = "Resultados"
        Me.Resultados.Size = New System.Drawing.Size(359, 239)
        Me.Resultados.TabIndex = 9
        Me.Resultados.TabStop = False
        '
        'ContextR
        '
        Me.ContextR.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem})
        Me.ContextR.Name = "ContextR"
        Me.ContextR.Size = New System.Drawing.Size(115, 26)
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(485, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'Guardado
        '
        Me.Guardado.Filter = """Episteme Log""|*.eplog"
        Me.Guardado.InitialDirectory = "%userprofile%\documents"
        Me.Guardado.Title = "Guardar archivo - RND"
        '
        'RNDGen
        '
        Me.AcceptButton = Me.Generar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 289)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(270, 300)
        Me.Name = "RNDGen"
        Me.Text = "RND - Números aleatorios"
        CType(Me.MinV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Times, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ContextR.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Generar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MinV As System.Windows.Forms.NumericUpDown
    Friend WithEvents MaxV As System.Windows.Forms.NumericUpDown
    Friend WithEvents Times As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Resultados As System.Windows.Forms.ListBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Estado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextR As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LimpiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Guardado As System.Windows.Forms.SaveFileDialog

End Class
