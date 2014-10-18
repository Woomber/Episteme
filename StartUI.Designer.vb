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
        Me.Joint_Launch = New System.Windows.Forms.Button()
        Me.MAINUI = New System.Windows.Forms.TableLayoutPanel()
        Me.IMC_Launch = New System.Windows.Forms.Button()
        Me.Qadratic_Launch = New System.Windows.Forms.Button()
        Me.Vektor_Launch = New System.Windows.Forms.Button()
        Me.Pithagorean_Launch = New System.Windows.Forms.Button()
        Me.Rassop_Launch = New System.Windows.Forms.Button()
        Me.Arpevol_Launch = New System.Windows.Forms.Button()
        Me.Trigger_Launch = New System.Windows.Forms.Button()
        Me.NotWindowsCalc_Launch = New System.Windows.Forms.Button()
        Me.Eqala_Launch = New System.Windows.Forms.Button()
        Me.RND_Launch = New System.Windows.Forms.Button()
        Me.Resist_Launch = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Bienvenido = New System.Windows.Forms.ToolStripStatusLabel()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(513, 24)
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
        'Joint_Launch
        '
        Me.Joint_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Joint_Launch.Location = New System.Drawing.Point(344, 3)
        Me.Joint_Launch.Name = "Joint_Launch"
        Me.Joint_Launch.Size = New System.Drawing.Size(166, 44)
        Me.Joint_Launch.TabIndex = 3
        Me.Joint_Launch.Text = "Joint" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A U B = { x | x EA v EB }"
        Me.Joint_Launch.UseVisualStyleBackColor = True
        '
        'MAINUI
        '
        Me.MAINUI.ColumnCount = 3
        Me.MAINUI.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
        Me.MAINUI.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.MAINUI.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.MAINUI.Controls.Add(Me.IMC_Launch, 0, 3)
        Me.MAINUI.Controls.Add(Me.Qadratic_Launch, 0, 0)
        Me.MAINUI.Controls.Add(Me.Joint_Launch, 2, 0)
        Me.MAINUI.Controls.Add(Me.Vektor_Launch, 1, 0)
        Me.MAINUI.Controls.Add(Me.Pithagorean_Launch, 0, 1)
        Me.MAINUI.Controls.Add(Me.Rassop_Launch, 1, 1)
        Me.MAINUI.Controls.Add(Me.Arpevol_Launch, 2, 1)
        Me.MAINUI.Controls.Add(Me.Trigger_Launch, 0, 2)
        Me.MAINUI.Controls.Add(Me.NotWindowsCalc_Launch, 1, 2)
        Me.MAINUI.Controls.Add(Me.Eqala_Launch, 2, 2)
        Me.MAINUI.Controls.Add(Me.RND_Launch, 0, 3)
        Me.MAINUI.Controls.Add(Me.Resist_Launch, 1, 3)
        Me.MAINUI.Controls.Add(Me.Panel1, 0, 4)
        Me.MAINUI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MAINUI.Location = New System.Drawing.Point(0, 24)
        Me.MAINUI.Name = "MAINUI"
        Me.MAINUI.RowCount = 5
        Me.MAINUI.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.MAINUI.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.MAINUI.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.MAINUI.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.MAINUI.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.MAINUI.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MAINUI.Size = New System.Drawing.Size(513, 223)
        Me.MAINUI.TabIndex = 4
        '
        'IMC_Launch
        '
        Me.IMC_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IMC_Launch.Location = New System.Drawing.Point(173, 153)
        Me.IMC_Launch.Name = "IMC_Launch"
        Me.IMC_Launch.Size = New System.Drawing.Size(165, 44)
        Me.IMC_Launch.TabIndex = 12
        Me.IMC_Launch.Text = "IMC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "kg / m^2"
        Me.IMC_Launch.UseVisualStyleBackColor = True
        '
        'Qadratic_Launch
        '
        Me.Qadratic_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Qadratic_Launch.Location = New System.Drawing.Point(3, 3)
        Me.Qadratic_Launch.Name = "Qadratic_Launch"
        Me.Qadratic_Launch.Size = New System.Drawing.Size(164, 44)
        Me.Qadratic_Launch.TabIndex = 0
        Me.Qadratic_Launch.Text = "Qadratic" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ax^2 + bx + c"
        Me.Qadratic_Launch.UseVisualStyleBackColor = True
        '
        'Vektor_Launch
        '
        Me.Vektor_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vektor_Launch.Location = New System.Drawing.Point(173, 3)
        Me.Vektor_Launch.Name = "Vektor_Launch"
        Me.Vektor_Launch.Size = New System.Drawing.Size(165, 44)
        Me.Vektor_Launch.TabIndex = 2
        Me.Vektor_Launch.Text = "Vektor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vr = Va + Vb"
        Me.Vektor_Launch.UseVisualStyleBackColor = True
        '
        'Pithagorean_Launch
        '
        Me.Pithagorean_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pithagorean_Launch.Enabled = False
        Me.Pithagorean_Launch.Location = New System.Drawing.Point(3, 53)
        Me.Pithagorean_Launch.Name = "Pithagorean_Launch"
        Me.Pithagorean_Launch.Size = New System.Drawing.Size(164, 44)
        Me.Pithagorean_Launch.TabIndex = 4
        Me.Pithagorean_Launch.Text = "Pithagorean" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "c^2 = a^2 + b^2"
        Me.Pithagorean_Launch.UseVisualStyleBackColor = True
        '
        'Rassop_Launch
        '
        Me.Rassop_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Rassop_Launch.Enabled = False
        Me.Rassop_Launch.Location = New System.Drawing.Point(173, 53)
        Me.Rassop_Launch.Name = "Rassop_Launch"
        Me.Rassop_Launch.Size = New System.Drawing.Size(165, 44)
        Me.Rassop_Launch.TabIndex = 5
        Me.Rassop_Launch.Text = "Rassop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A/B = C/D"
        Me.Rassop_Launch.UseVisualStyleBackColor = True
        '
        'Arpevol_Launch
        '
        Me.Arpevol_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Arpevol_Launch.Enabled = False
        Me.Arpevol_Launch.Location = New System.Drawing.Point(344, 53)
        Me.Arpevol_Launch.Name = "Arpevol_Launch"
        Me.Arpevol_Launch.Size = New System.Drawing.Size(166, 44)
        Me.Arpevol_Launch.TabIndex = 6
        Me.Arpevol_Launch.Text = "Arpevol" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A = b x h"
        Me.Arpevol_Launch.UseVisualStyleBackColor = True
        '
        'Trigger_Launch
        '
        Me.Trigger_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Trigger_Launch.Enabled = False
        Me.Trigger_Launch.Location = New System.Drawing.Point(3, 103)
        Me.Trigger_Launch.Name = "Trigger_Launch"
        Me.Trigger_Launch.Size = New System.Drawing.Size(164, 44)
        Me.Trigger_Launch.TabIndex = 7
        Me.Trigger_Launch.Text = "Trigger" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tan(45) = 1.61977519"
        Me.Trigger_Launch.UseVisualStyleBackColor = True
        '
        'NotWindowsCalc_Launch
        '
        Me.NotWindowsCalc_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NotWindowsCalc_Launch.Enabled = False
        Me.NotWindowsCalc_Launch.Location = New System.Drawing.Point(173, 103)
        Me.NotWindowsCalc_Launch.Name = "NotWindowsCalc_Launch"
        Me.NotWindowsCalc_Launch.Size = New System.Drawing.Size(165, 44)
        Me.NotWindowsCalc_Launch.TabIndex = 8
        Me.NotWindowsCalc_Launch.Text = "NotWindowsCalc" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 + 1 = 2"
        Me.NotWindowsCalc_Launch.UseVisualStyleBackColor = True
        '
        'Eqala_Launch
        '
        Me.Eqala_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Eqala_Launch.Enabled = False
        Me.Eqala_Launch.Location = New System.Drawing.Point(344, 103)
        Me.Eqala_Launch.Name = "Eqala_Launch"
        Me.Eqala_Launch.Size = New System.Drawing.Size(166, 44)
        Me.Eqala_Launch.TabIndex = 9
        Me.Eqala_Launch.Text = "Eqala" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5x + 4 = 24"
        Me.Eqala_Launch.UseVisualStyleBackColor = True
        '
        'RND_Launch
        '
        Me.RND_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RND_Launch.Location = New System.Drawing.Point(3, 153)
        Me.RND_Launch.Name = "RND_Launch"
        Me.RND_Launch.Size = New System.Drawing.Size(164, 44)
        Me.RND_Launch.TabIndex = 10
        Me.RND_Launch.Text = "RND" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1, 4, 92, 348, 2, 50"
        Me.RND_Launch.UseVisualStyleBackColor = True
        '
        'Resist_Launch
        '
        Me.Resist_Launch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Resist_Launch.Location = New System.Drawing.Point(344, 153)
        Me.Resist_Launch.Name = "Resist_Launch"
        Me.Resist_Launch.Size = New System.Drawing.Size(166, 44)
        Me.Resist_Launch.TabIndex = 11
        Me.Resist_Launch.Text = "Resist" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rt = Ra + Rb + Rc + Rd"
        Me.Resist_Launch.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.MAINUI.SetColumnSpan(Me.Panel1, 3)
        Me.Panel1.Controls.Add(Me.StatusStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 200)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(513, 23)
        Me.Panel1.TabIndex = 13
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bienvenido})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(513, 23)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Bienvenido
        '
        Me.Bienvenido.Name = "Bienvenido"
        Me.Bienvenido.Size = New System.Drawing.Size(66, 18)
        Me.Bienvenido.Text = "Bienvenido"
        '
        'StartUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 247)
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
    Friend WithEvents Joint_Launch As System.Windows.Forms.Button
    Friend WithEvents MAINUI As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Qadratic_Launch As System.Windows.Forms.Button
    Friend WithEvents Vektor_Launch As System.Windows.Forms.Button
    Friend WithEvents Pithagorean_Launch As System.Windows.Forms.Button
    Friend WithEvents Rassop_Launch As System.Windows.Forms.Button
    Friend WithEvents Arpevol_Launch As System.Windows.Forms.Button
    Friend WithEvents Trigger_Launch As System.Windows.Forms.Button
    Friend WithEvents NotWindowsCalc_Launch As System.Windows.Forms.Button
    Friend WithEvents Eqala_Launch As System.Windows.Forms.Button
    Friend WithEvents RND_Launch As System.Windows.Forms.Button
    Friend WithEvents Resist_Launch As System.Windows.Forms.Button
    Friend WithEvents ActualizaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarActualizacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VersiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IMC_Launch As System.Windows.Forms.Button
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

End Class
