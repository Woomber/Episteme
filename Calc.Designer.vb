<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calc))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÁngulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadianesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnEquals = New System.Windows.Forms.Button()
        Me.BtnSuma = New System.Windows.Forms.Button()
        Me.BtnRes = New System.Windows.Forms.Button()
        Me.BtnDiv = New System.Windows.Forms.Button()
        Me.BtnMult = New System.Windows.Forms.Button()
        Me.BtnC = New System.Windows.Forms.Button()
        Me.BtnCE = New System.Windows.Forms.Button()
        Me.BtnDec = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.DisplayBox = New System.Windows.Forms.TextBox()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ConfiguraciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(505, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(48, 20)
        Me.ToolStripMenuItem1.Text = "Inicio"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÁngulosToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'ÁngulosToolStripMenuItem
        '
        Me.ÁngulosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GradosToolStripMenuItem, Me.RadianesToolStripMenuItem})
        Me.ÁngulosToolStripMenuItem.Name = "ÁngulosToolStripMenuItem"
        Me.ÁngulosToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ÁngulosToolStripMenuItem.Text = "Ángulos"
        '
        'GradosToolStripMenuItem
        '
        Me.GradosToolStripMenuItem.Checked = True
        Me.GradosToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GradosToolStripMenuItem.Name = "GradosToolStripMenuItem"
        Me.GradosToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.GradosToolStripMenuItem.Text = "Grados"
        '
        'RadianesToolStripMenuItem
        '
        Me.RadianesToolStripMenuItem.Name = "RadianesToolStripMenuItem"
        Me.RadianesToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.RadianesToolStripMenuItem.Text = "Radianes"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnEquals, 5, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSuma, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnRes, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnDiv, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnMult, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnC, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnCE, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnDec, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn0, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn3, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn6, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn5, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn2, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn1, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn9, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn8, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DisplayBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn7, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox2, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox3, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox4, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox5, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox6, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox7, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox8, 3, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox9, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox10, 5, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(505, 357)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'BtnEquals
        '
        Me.BtnEquals.BackColor = System.Drawing.SystemColors.Control
        Me.BtnEquals.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnEquals.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnEquals.Font = New System.Drawing.Font("Cambria", 24.0!)
        Me.BtnEquals.Location = New System.Drawing.Point(408, 281)
        Me.BtnEquals.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnEquals.Name = "BtnEquals"
        Me.TableLayoutPanel1.SetRowSpan(Me.BtnEquals, 2)
        Me.BtnEquals.Size = New System.Drawing.Size(96, 75)
        Me.BtnEquals.TabIndex = 28
        Me.BtnEquals.Text = "="
        Me.BtnEquals.UseVisualStyleBackColor = False
        '
        'BtnSuma
        '
        Me.BtnSuma.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSuma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSuma.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnSuma.Font = New System.Drawing.Font("Cambria", 24.0!)
        Me.BtnSuma.Location = New System.Drawing.Point(310, 170)
        Me.BtnSuma.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnSuma.Name = "BtnSuma"
        Me.BtnSuma.Size = New System.Drawing.Size(96, 35)
        Me.BtnSuma.TabIndex = 27
        Me.BtnSuma.Text = "+"
        Me.BtnSuma.UseVisualStyleBackColor = False
        '
        'BtnRes
        '
        Me.BtnRes.BackColor = System.Drawing.SystemColors.Control
        Me.BtnRes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnRes.Font = New System.Drawing.Font("Cambria", 24.0!)
        Me.BtnRes.Location = New System.Drawing.Point(408, 170)
        Me.BtnRes.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnRes.Name = "BtnRes"
        Me.BtnRes.Size = New System.Drawing.Size(96, 35)
        Me.BtnRes.TabIndex = 26
        Me.BtnRes.Text = "-"
        Me.BtnRes.UseVisualStyleBackColor = False
        '
        'BtnDiv
        '
        Me.BtnDiv.BackColor = System.Drawing.SystemColors.Control
        Me.BtnDiv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnDiv.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnDiv.Font = New System.Drawing.Font("Cambria", 24.0!)
        Me.BtnDiv.Location = New System.Drawing.Point(408, 133)
        Me.BtnDiv.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnDiv.Name = "BtnDiv"
        Me.BtnDiv.Size = New System.Drawing.Size(96, 35)
        Me.BtnDiv.TabIndex = 23
        Me.BtnDiv.Text = "÷"
        Me.BtnDiv.UseVisualStyleBackColor = False
        '
        'BtnMult
        '
        Me.BtnMult.BackColor = System.Drawing.SystemColors.Control
        Me.BtnMult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnMult.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnMult.Font = New System.Drawing.Font("Cambria", 24.0!)
        Me.BtnMult.Location = New System.Drawing.Point(310, 133)
        Me.BtnMult.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnMult.Name = "BtnMult"
        Me.BtnMult.Size = New System.Drawing.Size(96, 35)
        Me.BtnMult.TabIndex = 22
        Me.BtnMult.Text = "×"
        Me.BtnMult.UseVisualStyleBackColor = False
        '
        'BtnC
        '
        Me.BtnC.BackColor = System.Drawing.SystemColors.Control
        Me.BtnC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnC.Font = New System.Drawing.Font("Cambria", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnC.Location = New System.Drawing.Point(408, 59)
        Me.BtnC.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnC.Name = "BtnC"
        Me.BtnC.Size = New System.Drawing.Size(96, 35)
        Me.BtnC.TabIndex = 13
        Me.BtnC.Text = "C"
        Me.BtnC.UseVisualStyleBackColor = False
        '
        'BtnCE
        '
        Me.BtnCE.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnCE.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnCE.Font = New System.Drawing.Font("Cambria", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCE.Location = New System.Drawing.Point(310, 59)
        Me.BtnCE.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnCE.Name = "BtnCE"
        Me.BtnCE.Size = New System.Drawing.Size(96, 35)
        Me.BtnCE.TabIndex = 12
        Me.BtnCE.Text = "CE"
        Me.BtnCE.UseVisualStyleBackColor = False
        '
        'BtnDec
        '
        Me.BtnDec.BackColor = System.Drawing.SystemColors.Control
        Me.BtnDec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnDec.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnDec.Font = New System.Drawing.Font("Cambria", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDec.Location = New System.Drawing.Point(197, 281)
        Me.BtnDec.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnDec.Name = "BtnDec"
        Me.TableLayoutPanel1.SetRowSpan(Me.BtnDec, 2)
        Me.BtnDec.Size = New System.Drawing.Size(96, 75)
        Me.BtnDec.TabIndex = 11
        Me.BtnDec.Text = "."
        Me.BtnDec.UseVisualStyleBackColor = False
        '
        'Btn0
        '
        Me.Btn0.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel1.SetColumnSpan(Me.Btn0, 2)
        Me.Btn0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn0.Font = New System.Drawing.Font("Cambria", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn0.Location = New System.Drawing.Point(1, 281)
        Me.Btn0.Margin = New System.Windows.Forms.Padding(1)
        Me.Btn0.Name = "Btn0"
        Me.TableLayoutPanel1.SetRowSpan(Me.Btn0, 2)
        Me.Btn0.Size = New System.Drawing.Size(194, 75)
        Me.Btn0.TabIndex = 10
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = False
        '
        'Btn3
        '
        Me.Btn3.BackColor = System.Drawing.SystemColors.Control
        Me.Btn3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn3.Font = New System.Drawing.Font("Cambria", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.Location = New System.Drawing.Point(197, 207)
        Me.Btn3.Margin = New System.Windows.Forms.Padding(1)
        Me.Btn3.Name = "Btn3"
        Me.TableLayoutPanel1.SetRowSpan(Me.Btn3, 2)
        Me.Btn3.Size = New System.Drawing.Size(96, 72)
        Me.Btn3.TabIndex = 9
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = False
        '
        'Btn6
        '
        Me.Btn6.BackColor = System.Drawing.SystemColors.Control
        Me.Btn6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn6.Font = New System.Drawing.Font("Cambria", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn6.Location = New System.Drawing.Point(197, 133)
        Me.Btn6.Margin = New System.Windows.Forms.Padding(1)
        Me.Btn6.Name = "Btn6"
        Me.TableLayoutPanel1.SetRowSpan(Me.Btn6, 2)
        Me.Btn6.Size = New System.Drawing.Size(96, 72)
        Me.Btn6.TabIndex = 8
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = False
        '
        'Btn5
        '
        Me.Btn5.BackColor = System.Drawing.SystemColors.Control
        Me.Btn5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn5.Font = New System.Drawing.Font("Cambria", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn5.Location = New System.Drawing.Point(99, 133)
        Me.Btn5.Margin = New System.Windows.Forms.Padding(1)
        Me.Btn5.Name = "Btn5"
        Me.TableLayoutPanel1.SetRowSpan(Me.Btn5, 2)
        Me.Btn5.Size = New System.Drawing.Size(96, 72)
        Me.Btn5.TabIndex = 7
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = False
        '
        'Btn4
        '
        Me.Btn4.BackColor = System.Drawing.SystemColors.Control
        Me.Btn4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn4.Font = New System.Drawing.Font("Cambria", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.Location = New System.Drawing.Point(1, 133)
        Me.Btn4.Margin = New System.Windows.Forms.Padding(1)
        Me.Btn4.Name = "Btn4"
        Me.TableLayoutPanel1.SetRowSpan(Me.Btn4, 2)
        Me.Btn4.Size = New System.Drawing.Size(96, 72)
        Me.Btn4.TabIndex = 6
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.SystemColors.Control
        Me.Btn2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn2.Font = New System.Drawing.Font("Cambria", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.Location = New System.Drawing.Point(99, 207)
        Me.Btn2.Margin = New System.Windows.Forms.Padding(1)
        Me.Btn2.Name = "Btn2"
        Me.TableLayoutPanel1.SetRowSpan(Me.Btn2, 2)
        Me.Btn2.Size = New System.Drawing.Size(96, 72)
        Me.Btn2.TabIndex = 5
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.SystemColors.Control
        Me.Btn1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn1.Font = New System.Drawing.Font("Cambria", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.Location = New System.Drawing.Point(1, 207)
        Me.Btn1.Margin = New System.Windows.Forms.Padding(1)
        Me.Btn1.Name = "Btn1"
        Me.TableLayoutPanel1.SetRowSpan(Me.Btn1, 2)
        Me.Btn1.Size = New System.Drawing.Size(96, 72)
        Me.Btn1.TabIndex = 4
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'Btn9
        '
        Me.Btn9.BackColor = System.Drawing.SystemColors.Control
        Me.Btn9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn9.Font = New System.Drawing.Font("Cambria", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn9.Location = New System.Drawing.Point(197, 59)
        Me.Btn9.Margin = New System.Windows.Forms.Padding(1)
        Me.Btn9.Name = "Btn9"
        Me.TableLayoutPanel1.SetRowSpan(Me.Btn9, 2)
        Me.Btn9.Size = New System.Drawing.Size(96, 72)
        Me.Btn9.TabIndex = 3
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = False
        '
        'Btn8
        '
        Me.Btn8.BackColor = System.Drawing.SystemColors.Control
        Me.Btn8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn8.Font = New System.Drawing.Font("Cambria", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn8.Location = New System.Drawing.Point(99, 59)
        Me.Btn8.Margin = New System.Windows.Forms.Padding(1)
        Me.Btn8.Name = "Btn8"
        Me.TableLayoutPanel1.SetRowSpan(Me.Btn8, 2)
        Me.Btn8.Size = New System.Drawing.Size(96, 72)
        Me.Btn8.TabIndex = 2
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = False
        '
        'DisplayBox
        '
        Me.DisplayBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.DisplayBox, 6)
        Me.DisplayBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DisplayBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DisplayBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayBox.Location = New System.Drawing.Point(3, 3)
        Me.DisplayBox.Name = "DisplayBox"
        Me.DisplayBox.ReadOnly = True
        Me.DisplayBox.Size = New System.Drawing.Size(499, 53)
        Me.DisplayBox.TabIndex = 0
        Me.DisplayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Btn7
        '
        Me.Btn7.BackColor = System.Drawing.SystemColors.Control
        Me.Btn7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn7.Font = New System.Drawing.Font("Cambria", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn7.Location = New System.Drawing.Point(1, 59)
        Me.Btn7.Margin = New System.Windows.Forms.Padding(1)
        Me.Btn7.Name = "Btn7"
        Me.TableLayoutPanel1.SetRowSpan(Me.Btn7, 2)
        Me.Btn7.Size = New System.Drawing.Size(96, 72)
        Me.Btn7.TabIndex = 1
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(297, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(9, 31)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(297, 98)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(9, 31)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(297, 135)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(9, 31)
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(297, 172)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(9, 31)
        Me.PictureBox4.TabIndex = 17
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(297, 209)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(9, 31)
        Me.PictureBox5.TabIndex = 18
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(297, 246)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(9, 31)
        Me.PictureBox6.TabIndex = 19
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Location = New System.Drawing.Point(297, 283)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(9, 31)
        Me.PictureBox7.TabIndex = 20
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Location = New System.Drawing.Point(297, 320)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(9, 34)
        Me.PictureBox8.TabIndex = 21
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Location = New System.Drawing.Point(312, 98)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(92, 31)
        Me.PictureBox9.TabIndex = 24
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Location = New System.Drawing.Point(410, 98)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(92, 31)
        Me.PictureBox10.TabIndex = 25
        Me.PictureBox10.TabStop = False
        '
        'Calc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 381)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Calc"
        Me.Text = "Calc"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÁngulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GradosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RadianesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnEquals As System.Windows.Forms.Button
    Friend WithEvents BtnSuma As System.Windows.Forms.Button
    Friend WithEvents BtnRes As System.Windows.Forms.Button
    Friend WithEvents BtnDiv As System.Windows.Forms.Button
    Friend WithEvents BtnMult As System.Windows.Forms.Button
    Friend WithEvents BtnC As System.Windows.Forms.Button
    Friend WithEvents BtnCE As System.Windows.Forms.Button
    Friend WithEvents BtnDec As System.Windows.Forms.Button
    Friend WithEvents Btn0 As System.Windows.Forms.Button
    Friend WithEvents Btn3 As System.Windows.Forms.Button
    Friend WithEvents Btn6 As System.Windows.Forms.Button
    Friend WithEvents Btn5 As System.Windows.Forms.Button
    Friend WithEvents Btn4 As System.Windows.Forms.Button
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents Btn9 As System.Windows.Forms.Button
    Friend WithEvents Btn8 As System.Windows.Forms.Button
    Friend WithEvents DisplayBox As System.Windows.Forms.TextBox
    Friend WithEvents Btn7 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
End Class
