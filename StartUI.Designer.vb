<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartUI
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PreferenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BuscarActualizacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeEpistemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SitioWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Misc_Launch = New System.Windows.Forms.Button()
        Me.MAINUI = New System.Windows.Forms.TableLayoutPanel()
        Me.Diario_Launch = New System.Windows.Forms.Button()
        Me.Algebra_Launch = New System.Windows.Forms.Button()
        Me.Geometria_Launch = New System.Windows.Forms.Button()
        Me.Numeros_Launch = New System.Windows.Forms.Button()
        Me.Juegos_Launch = New System.Windows.Forms.Button()
        Me.Electro_Launch = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Bienvenido = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ChemDoc_Launch = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.MAINUI.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.ActualizaciónToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(683, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirArchivoToolStripMenuItem, Me.ToolStripSeparator1, Me.CerrarToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'AbrirArchivoToolStripMenuItem
        '
        Me.AbrirArchivoToolStripMenuItem.Name = "AbrirArchivoToolStripMenuItem"
        Me.AbrirArchivoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AbrirArchivoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AbrirArchivoToolStripMenuItem.Text = "Abrir editor"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(173, 6)
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        Me.CerrarToolStripMenuItem.ToolTipText = "Cerrar Episteme"
        '
        'ActualizaciónToolStripMenuItem
        '
        Me.ActualizaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersiónToolStripMenuItem, Me.ToolStripSeparator2, Me.PreferenciasToolStripMenuItem, Me.ToolStripSeparator3, Me.BuscarActualizacionesToolStripMenuItem, Me.VerToolStripMenuItem})
        Me.ActualizaciónToolStripMenuItem.Name = "ActualizaciónToolStripMenuItem"
        Me.ActualizaciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ActualizaciónToolStripMenuItem.Text = "Configuración"
        '
        'VersiónToolStripMenuItem
        '
        Me.VersiónToolStripMenuItem.Name = "VersiónToolStripMenuItem"
        Me.VersiónToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.VersiónToolStripMenuItem.Text = "Versión:"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(189, 6)
        '
        'PreferenciasToolStripMenuItem
        '
        Me.PreferenciasToolStripMenuItem.Name = "PreferenciasToolStripMenuItem"
        Me.PreferenciasToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.PreferenciasToolStripMenuItem.Text = "Preferencias"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(189, 6)
        '
        'BuscarActualizacionesToolStripMenuItem
        '
        Me.BuscarActualizacionesToolStripMenuItem.Name = "BuscarActualizacionesToolStripMenuItem"
        Me.BuscarActualizacionesToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.BuscarActualizacionesToolStripMenuItem.Text = "Buscar actualizaciones"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.VerToolStripMenuItem.Text = "Ver Compilaciones"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeEpistemeToolStripMenuItem, Me.SitioWebToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeEpistemeToolStripMenuItem
        '
        Me.AcercaDeEpistemeToolStripMenuItem.Name = "AcercaDeEpistemeToolStripMenuItem"
        Me.AcercaDeEpistemeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AcercaDeEpistemeToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.AcercaDeEpistemeToolStripMenuItem.Text = "Acerca de Episteme"
        '
        'SitioWebToolStripMenuItem
        '
        Me.SitioWebToolStripMenuItem.Name = "SitioWebToolStripMenuItem"
        Me.SitioWebToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.SitioWebToolStripMenuItem.Text = "Sitio Web"
        '
        'Misc_Launch
        '
        Me.Misc_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Misc_Launch.Location = New System.Drawing.Point(513, 83)
        Me.Misc_Launch.Name = "Misc_Launch"
        Me.Misc_Launch.Size = New System.Drawing.Size(167, 74)
        Me.Misc_Launch.TabIndex = 3
        Me.Misc_Launch.Text = "Misceláneos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "De difícil agrupación"
        Me.Misc_Launch.UseVisualStyleBackColor = True
        '
        'MAINUI
        '
        Me.MAINUI.ColumnCount = 4
        Me.MAINUI.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.MAINUI.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.MAINUI.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.MAINUI.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.MAINUI.Controls.Add(Me.Diario_Launch, 2, 0)
        Me.MAINUI.Controls.Add(Me.Algebra_Launch, 0, 0)
        Me.MAINUI.Controls.Add(Me.Misc_Launch, 3, 1)
        Me.MAINUI.Controls.Add(Me.Geometria_Launch, 1, 0)
        Me.MAINUI.Controls.Add(Me.Numeros_Launch, 1, 1)
        Me.MAINUI.Controls.Add(Me.Juegos_Launch, 2, 1)
        Me.MAINUI.Controls.Add(Me.Electro_Launch, 3, 0)
        Me.MAINUI.Controls.Add(Me.Panel1, 0, 2)
        Me.MAINUI.Controls.Add(Me.ChemDoc_Launch, 0, 1)
        Me.MAINUI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MAINUI.Location = New System.Drawing.Point(0, 24)
        Me.MAINUI.Name = "MAINUI"
        Me.MAINUI.RowCount = 3
        Me.MAINUI.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MAINUI.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MAINUI.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.MAINUI.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MAINUI.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MAINUI.Size = New System.Drawing.Size(683, 182)
        Me.MAINUI.TabIndex = 4
        '
        'Diario_Launch
        '
        Me.Diario_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Diario_Launch.Location = New System.Drawing.Point(343, 3)
        Me.Diario_Launch.Name = "Diario_Launch"
        Me.Diario_Launch.Size = New System.Drawing.Size(164, 74)
        Me.Diario_Launch.TabIndex = 12
        Me.Diario_Launch.Text = "Uso Diario" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Funciones de uso frecuente"
        Me.Diario_Launch.UseVisualStyleBackColor = True
        '
        'Algebra_Launch
        '
        Me.Algebra_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Algebra_Launch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Algebra_Launch.Location = New System.Drawing.Point(3, 3)
        Me.Algebra_Launch.Name = "Algebra_Launch"
        Me.Algebra_Launch.Size = New System.Drawing.Size(164, 74)
        Me.Algebra_Launch.TabIndex = 0
        Me.Algebra_Launch.Text = "Álgebra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trabaja con literales"
        Me.Algebra_Launch.UseVisualStyleBackColor = True
        '
        'Geometria_Launch
        '
        Me.Geometria_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Geometria_Launch.Location = New System.Drawing.Point(173, 3)
        Me.Geometria_Launch.Name = "Geometria_Launch"
        Me.Geometria_Launch.Size = New System.Drawing.Size(164, 74)
        Me.Geometria_Launch.TabIndex = 2
        Me.Geometria_Launch.Text = "Geometría" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trabaja con figuras y ángulos"
        Me.Geometria_Launch.UseVisualStyleBackColor = True
        '
        'Numeros_Launch
        '
        Me.Numeros_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Numeros_Launch.Location = New System.Drawing.Point(173, 83)
        Me.Numeros_Launch.Name = "Numeros_Launch"
        Me.Numeros_Launch.Size = New System.Drawing.Size(164, 74)
        Me.Numeros_Launch.TabIndex = 5
        Me.Numeros_Launch.Text = "Números" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Todo sobre el 123"
        Me.Numeros_Launch.UseVisualStyleBackColor = True
        '
        'Juegos_Launch
        '
        Me.Juegos_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Juegos_Launch.Location = New System.Drawing.Point(343, 83)
        Me.Juegos_Launch.Name = "Juegos_Launch"
        Me.Juegos_Launch.Size = New System.Drawing.Size(164, 74)
        Me.Juegos_Launch.TabIndex = 10
        Me.Juegos_Launch.Text = "Juegos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Despéjate un rato"
        Me.Juegos_Launch.UseVisualStyleBackColor = True
        '
        'Electro_Launch
        '
        Me.Electro_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Electro_Launch.Location = New System.Drawing.Point(513, 3)
        Me.Electro_Launch.Name = "Electro_Launch"
        Me.Electro_Launch.Size = New System.Drawing.Size(167, 74)
        Me.Electro_Launch.TabIndex = 11
        Me.Electro_Launch.Text = "Electrónica" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calcula esos circuitos"
        Me.Electro_Launch.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.MAINUI.SetColumnSpan(Me.Panel1, 4)
        Me.Panel1.Controls.Add(Me.StatusStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 160)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(683, 22)
        Me.Panel1.TabIndex = 13
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bienvenido})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(683, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Bienvenido
        '
        Me.Bienvenido.Name = "Bienvenido"
        Me.Bienvenido.Size = New System.Drawing.Size(66, 17)
        Me.Bienvenido.Text = "Bienvenido"
        '
        'ChemDoc_Launch
        '
        Me.ChemDoc_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChemDoc_Launch.Location = New System.Drawing.Point(3, 83)
        Me.ChemDoc_Launch.Name = "ChemDoc_Launch"
        Me.ChemDoc_Launch.Size = New System.Drawing.Size(164, 74)
        Me.ChemDoc_Launch.TabIndex = 14
        Me.ChemDoc_Launch.Text = "Química" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mezcla los elementos"
        Me.ChemDoc_Launch.UseVisualStyleBackColor = True
        '
        'StartUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 206)
        Me.Controls.Add(Me.MAINUI)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(380, 172)
        Me.Name = "StartUI"
        Me.Text = "Episteme - Cálculos hechos Simples"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MAINUI.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Misc_Launch As System.Windows.Forms.Button
    Friend WithEvents MAINUI As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Algebra_Launch As System.Windows.Forms.Button
    Friend WithEvents Geometria_Launch As System.Windows.Forms.Button
    Friend WithEvents Numeros_Launch As System.Windows.Forms.Button
    Friend WithEvents Juegos_Launch As System.Windows.Forms.Button
    Friend WithEvents Electro_Launch As System.Windows.Forms.Button
    Friend WithEvents ActualizaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarActualizacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VersiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Diario_Launch As System.Windows.Forms.Button
    Friend WithEvents AbrirArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeEpistemeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SitioWebToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreferenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Bienvenido As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ChemDoc_Launch As System.Windows.Forms.Button

End Class
