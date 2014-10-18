<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resist
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
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CalculaRes = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SelectVolt = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RemoveRes = New System.Windows.Forms.Button()
        Me.AddRes = New System.Windows.Forms.Button()
        Me.OhmMili = New System.Windows.Forms.RadioButton()
        Me.OhmMega = New System.Windows.Forms.RadioButton()
        Me.OhmKilo = New System.Windows.Forms.RadioButton()
        Me.Ohm = New System.Windows.Forms.RadioButton()
        Me.SelectRes = New System.Windows.Forms.NumericUpDown()
        Me.OhmList = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.WattList = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VoltList = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IT = New System.Windows.Forms.Label()
        Me.VE = New System.Windows.Forms.Label()
        Me.RT = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CalculaResP = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SelectVoltP = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RemoveResP = New System.Windows.Forms.Button()
        Me.AddResP = New System.Windows.Forms.Button()
        Me.OhmMiliP = New System.Windows.Forms.RadioButton()
        Me.OhmMegaP = New System.Windows.Forms.RadioButton()
        Me.OhmKiloP = New System.Windows.Forms.RadioButton()
        Me.OhmP = New System.Windows.Forms.RadioButton()
        Me.SelectResP = New System.Windows.Forms.NumericUpDown()
        Me.OhmListP = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.WattListP = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.IntListP = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ITP = New System.Windows.Forms.Label()
        Me.VTP = New System.Windows.Forms.Label()
        Me.RTP = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SelectVolt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectRes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SelectVoltP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectResP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(356, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 443)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(356, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(233, 17)
        Me.ToolStripStatusLabel1.Text = "Copyright © Yael Arturo Chavoya Andalón"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(356, 419)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(350, 413)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(342, 387)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Conexión en Serie"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.56955!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.43045!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(336, 381)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CalculaRes)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.SelectVolt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RemoveRes)
        Me.GroupBox1.Controls.Add(Me.AddRes)
        Me.GroupBox1.Controls.Add(Me.OhmMili)
        Me.GroupBox1.Controls.Add(Me.OhmMega)
        Me.GroupBox1.Controls.Add(Me.OhmKilo)
        Me.GroupBox1.Controls.Add(Me.Ohm)
        Me.GroupBox1.Controls.Add(Me.SelectRes)
        Me.GroupBox1.Controls.Add(Me.OhmList)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 159)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'CalculaRes
        '
        Me.CalculaRes.Location = New System.Drawing.Point(262, 115)
        Me.CalculaRes.Name = "CalculaRes"
        Me.CalculaRes.Size = New System.Drawing.Size(57, 40)
        Me.CalculaRes.TabIndex = 13
        Me.CalculaRes.Text = "Calcular"
        Me.CalculaRes.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "voltios"
        '
        'SelectVolt
        '
        Me.SelectVolt.DecimalPlaces = 2
        Me.SelectVolt.Location = New System.Drawing.Point(153, 132)
        Me.SelectVolt.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.SelectVolt.Name = "SelectVolt"
        Me.SelectVolt.Size = New System.Drawing.Size(55, 20)
        Me.SelectVolt.TabIndex = 11
        Me.SelectVolt.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tensión de entrada:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Resistencias:"
        '
        'RemoveRes
        '
        Me.RemoveRes.Location = New System.Drawing.Point(262, 85)
        Me.RemoveRes.Name = "RemoveRes"
        Me.RemoveRes.Size = New System.Drawing.Size(57, 23)
        Me.RemoveRes.TabIndex = 8
        Me.RemoveRes.Text = "Quitar"
        Me.RemoveRes.UseVisualStyleBackColor = True
        '
        'AddRes
        '
        Me.AddRes.Location = New System.Drawing.Point(147, 85)
        Me.AddRes.Name = "AddRes"
        Me.AddRes.Size = New System.Drawing.Size(109, 23)
        Me.AddRes.TabIndex = 7
        Me.AddRes.Text = "Agregar"
        Me.AddRes.UseVisualStyleBackColor = True
        '
        'OhmMili
        '
        Me.OhmMili.AutoSize = True
        Me.OhmMili.Location = New System.Drawing.Point(147, 62)
        Me.OhmMili.Name = "OhmMili"
        Me.OhmMili.Size = New System.Drawing.Size(42, 17)
        Me.OhmMili.TabIndex = 6
        Me.OhmMili.TabStop = True
        Me.OhmMili.Text = "mΩ"
        Me.OhmMili.UseVisualStyleBackColor = True
        '
        'OhmMega
        '
        Me.OhmMega.AutoSize = True
        Me.OhmMega.Location = New System.Drawing.Point(281, 62)
        Me.OhmMega.Name = "OhmMega"
        Me.OhmMega.Size = New System.Drawing.Size(43, 17)
        Me.OhmMega.TabIndex = 5
        Me.OhmMega.Text = "MΩ"
        Me.OhmMega.UseVisualStyleBackColor = True
        '
        'OhmKilo
        '
        Me.OhmKilo.AutoSize = True
        Me.OhmKilo.Location = New System.Drawing.Point(235, 62)
        Me.OhmKilo.Name = "OhmKilo"
        Me.OhmKilo.Size = New System.Drawing.Size(40, 17)
        Me.OhmKilo.TabIndex = 4
        Me.OhmKilo.Text = "kΩ"
        Me.OhmKilo.UseVisualStyleBackColor = True
        '
        'Ohm
        '
        Me.Ohm.AutoSize = True
        Me.Ohm.Checked = True
        Me.Ohm.Location = New System.Drawing.Point(195, 62)
        Me.Ohm.Name = "Ohm"
        Me.Ohm.Size = New System.Drawing.Size(34, 17)
        Me.Ohm.TabIndex = 3
        Me.Ohm.TabStop = True
        Me.Ohm.Text = "Ω"
        Me.Ohm.UseVisualStyleBackColor = True
        '
        'SelectRes
        '
        Me.SelectRes.DecimalPlaces = 2
        Me.SelectRes.Location = New System.Drawing.Point(153, 36)
        Me.SelectRes.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.SelectRes.Name = "SelectRes"
        Me.SelectRes.Size = New System.Drawing.Size(166, 20)
        Me.SelectRes.TabIndex = 1
        '
        'OhmList
        '
        Me.OhmList.FormattingEnabled = True
        Me.OhmList.Location = New System.Drawing.Point(6, 19)
        Me.OhmList.Name = "OhmList"
        Me.OhmList.Size = New System.Drawing.Size(135, 134)
        Me.OhmList.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.WattList)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.VoltList)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.IT)
        Me.GroupBox2.Controls.Add(Me.VE)
        Me.GroupBox2.Controls.Add(Me.RT)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 210)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'WattList
        '
        Me.WattList.FormattingEnabled = True
        Me.WattList.Location = New System.Drawing.Point(167, 80)
        Me.WattList.Name = "WattList"
        Me.WattList.Size = New System.Drawing.Size(152, 121)
        Me.WattList.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(164, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Potencias:"
        '
        'VoltList
        '
        Me.VoltList.FormattingEnabled = True
        Me.VoltList.Location = New System.Drawing.Point(9, 80)
        Me.VoltList.Name = "VoltList"
        Me.VoltList.Size = New System.Drawing.Size(143, 121)
        Me.VoltList.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tensiones:"
        '
        'IT
        '
        Me.IT.AutoSize = True
        Me.IT.Location = New System.Drawing.Point(6, 42)
        Me.IT.Name = "IT"
        Me.IT.Size = New System.Drawing.Size(75, 13)
        Me.IT.TabIndex = 2
        Me.IT.Text = "Corriente total:"
        '
        'VE
        '
        Me.VE.AutoSize = True
        Me.VE.Location = New System.Drawing.Point(6, 29)
        Me.VE.Name = "VE"
        Me.VE.Size = New System.Drawing.Size(71, 13)
        Me.VE.TabIndex = 1
        Me.VE.Text = "Tensión total:"
        '
        'RT
        '
        Me.RT.AutoSize = True
        Me.RT.Location = New System.Drawing.Point(6, 16)
        Me.RT.Name = "RT"
        Me.RT.Size = New System.Drawing.Size(88, 13)
        Me.RT.TabIndex = 0
        Me.RT.Text = "Resistencia total:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(342, 387)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Conexión en Paralelo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox4, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.56955!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.43045!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(336, 381)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CalculaResP)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.SelectVoltP)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.RemoveResP)
        Me.GroupBox3.Controls.Add(Me.AddResP)
        Me.GroupBox3.Controls.Add(Me.OhmMiliP)
        Me.GroupBox3.Controls.Add(Me.OhmMegaP)
        Me.GroupBox3.Controls.Add(Me.OhmKiloP)
        Me.GroupBox3.Controls.Add(Me.OhmP)
        Me.GroupBox3.Controls.Add(Me.SelectResP)
        Me.GroupBox3.Controls.Add(Me.OhmListP)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(330, 159)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos"
        '
        'CalculaResP
        '
        Me.CalculaResP.Location = New System.Drawing.Point(262, 115)
        Me.CalculaResP.Name = "CalculaResP"
        Me.CalculaResP.Size = New System.Drawing.Size(57, 40)
        Me.CalculaResP.TabIndex = 13
        Me.CalculaResP.Text = "Calcular"
        Me.CalculaResP.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(213, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "voltios"
        '
        'SelectVoltP
        '
        Me.SelectVoltP.DecimalPlaces = 2
        Me.SelectVoltP.Location = New System.Drawing.Point(153, 132)
        Me.SelectVoltP.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.SelectVoltP.Name = "SelectVoltP"
        Me.SelectVoltP.Size = New System.Drawing.Size(55, 20)
        Me.SelectVoltP.TabIndex = 11
        Me.SelectVoltP.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(150, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Tensión de entrada:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(147, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Resistencias:"
        '
        'RemoveResP
        '
        Me.RemoveResP.Location = New System.Drawing.Point(262, 85)
        Me.RemoveResP.Name = "RemoveResP"
        Me.RemoveResP.Size = New System.Drawing.Size(57, 23)
        Me.RemoveResP.TabIndex = 8
        Me.RemoveResP.Text = "Quitar"
        Me.RemoveResP.UseVisualStyleBackColor = True
        '
        'AddResP
        '
        Me.AddResP.Location = New System.Drawing.Point(147, 85)
        Me.AddResP.Name = "AddResP"
        Me.AddResP.Size = New System.Drawing.Size(109, 23)
        Me.AddResP.TabIndex = 7
        Me.AddResP.Text = "Agregar"
        Me.AddResP.UseVisualStyleBackColor = True
        '
        'OhmMiliP
        '
        Me.OhmMiliP.AutoSize = True
        Me.OhmMiliP.Location = New System.Drawing.Point(147, 62)
        Me.OhmMiliP.Name = "OhmMiliP"
        Me.OhmMiliP.Size = New System.Drawing.Size(42, 17)
        Me.OhmMiliP.TabIndex = 6
        Me.OhmMiliP.TabStop = True
        Me.OhmMiliP.Text = "mΩ"
        Me.OhmMiliP.UseVisualStyleBackColor = True
        '
        'OhmMegaP
        '
        Me.OhmMegaP.AutoSize = True
        Me.OhmMegaP.Location = New System.Drawing.Point(281, 62)
        Me.OhmMegaP.Name = "OhmMegaP"
        Me.OhmMegaP.Size = New System.Drawing.Size(43, 17)
        Me.OhmMegaP.TabIndex = 5
        Me.OhmMegaP.Text = "MΩ"
        Me.OhmMegaP.UseVisualStyleBackColor = True
        '
        'OhmKiloP
        '
        Me.OhmKiloP.AutoSize = True
        Me.OhmKiloP.Location = New System.Drawing.Point(235, 62)
        Me.OhmKiloP.Name = "OhmKiloP"
        Me.OhmKiloP.Size = New System.Drawing.Size(40, 17)
        Me.OhmKiloP.TabIndex = 4
        Me.OhmKiloP.Text = "kΩ"
        Me.OhmKiloP.UseVisualStyleBackColor = True
        '
        'OhmP
        '
        Me.OhmP.AutoSize = True
        Me.OhmP.Checked = True
        Me.OhmP.Location = New System.Drawing.Point(195, 62)
        Me.OhmP.Name = "OhmP"
        Me.OhmP.Size = New System.Drawing.Size(34, 17)
        Me.OhmP.TabIndex = 3
        Me.OhmP.TabStop = True
        Me.OhmP.Text = "Ω"
        Me.OhmP.UseVisualStyleBackColor = True
        '
        'SelectResP
        '
        Me.SelectResP.DecimalPlaces = 2
        Me.SelectResP.Location = New System.Drawing.Point(153, 36)
        Me.SelectResP.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.SelectResP.Name = "SelectResP"
        Me.SelectResP.Size = New System.Drawing.Size(166, 20)
        Me.SelectResP.TabIndex = 1
        '
        'OhmListP
        '
        Me.OhmListP.FormattingEnabled = True
        Me.OhmListP.Location = New System.Drawing.Point(6, 19)
        Me.OhmListP.Name = "OhmListP"
        Me.OhmListP.Size = New System.Drawing.Size(135, 134)
        Me.OhmListP.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.WattListP)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.IntListP)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.ITP)
        Me.GroupBox4.Controls.Add(Me.VTP)
        Me.GroupBox4.Controls.Add(Me.RTP)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(3, 168)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(330, 210)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resultados"
        '
        'WattListP
        '
        Me.WattListP.FormattingEnabled = True
        Me.WattListP.Location = New System.Drawing.Point(167, 80)
        Me.WattListP.Name = "WattListP"
        Me.WattListP.Size = New System.Drawing.Size(152, 121)
        Me.WattListP.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(164, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Potencias:"
        '
        'IntListP
        '
        Me.IntListP.FormattingEnabled = True
        Me.IntListP.Location = New System.Drawing.Point(9, 80)
        Me.IntListP.Name = "IntListP"
        Me.IntListP.Size = New System.Drawing.Size(143, 121)
        Me.IntListP.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Corrientes:"
        '
        'ITP
        '
        Me.ITP.AutoSize = True
        Me.ITP.Location = New System.Drawing.Point(6, 42)
        Me.ITP.Name = "ITP"
        Me.ITP.Size = New System.Drawing.Size(75, 13)
        Me.ITP.TabIndex = 2
        Me.ITP.Text = "Corriente total:"
        '
        'VTP
        '
        Me.VTP.AutoSize = True
        Me.VTP.Location = New System.Drawing.Point(6, 29)
        Me.VTP.Name = "VTP"
        Me.VTP.Size = New System.Drawing.Size(71, 13)
        Me.VTP.TabIndex = 1
        Me.VTP.Text = "Tensión total:"
        '
        'RTP
        '
        Me.RTP.AutoSize = True
        Me.RTP.Location = New System.Drawing.Point(6, 16)
        Me.RTP.Name = "RTP"
        Me.RTP.Size = New System.Drawing.Size(88, 13)
        Me.RTP.TabIndex = 0
        Me.RTP.Text = "Resistencia total:"
        '
        'Resist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 465)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Resist"
        Me.Text = "Resist"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SelectVolt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectRes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.SelectVoltP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectResP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OhmMega As System.Windows.Forms.RadioButton
    Friend WithEvents OhmKilo As System.Windows.Forms.RadioButton
    Friend WithEvents Ohm As System.Windows.Forms.RadioButton
    Friend WithEvents SelectRes As System.Windows.Forms.NumericUpDown
    Friend WithEvents OhmList As System.Windows.Forms.ListBox
    Friend WithEvents OhmMili As System.Windows.Forms.RadioButton
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveRes As System.Windows.Forms.Button
    Friend WithEvents AddRes As System.Windows.Forms.Button
    Friend WithEvents CalculaRes As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SelectVolt As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RT As System.Windows.Forms.Label
    Friend WithEvents VE As System.Windows.Forms.Label
    Friend WithEvents IT As System.Windows.Forms.Label
    Friend WithEvents VoltList As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents WattList As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CalculaResP As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SelectVoltP As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RemoveResP As System.Windows.Forms.Button
    Friend WithEvents AddResP As System.Windows.Forms.Button
    Friend WithEvents OhmMiliP As System.Windows.Forms.RadioButton
    Friend WithEvents OhmMegaP As System.Windows.Forms.RadioButton
    Friend WithEvents OhmKiloP As System.Windows.Forms.RadioButton
    Friend WithEvents OhmP As System.Windows.Forms.RadioButton
    Friend WithEvents SelectResP As System.Windows.Forms.NumericUpDown
    Friend WithEvents OhmListP As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents WattListP As System.Windows.Forms.ListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents IntListP As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ITP As System.Windows.Forms.Label
    Friend WithEvents VTP As System.Windows.Forms.Label
    Friend WithEvents RTP As System.Windows.Forms.Label
End Class
