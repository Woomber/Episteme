<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Joint
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
        Me.Esqueleto = New System.Windows.Forms.TableLayoutPanel()
        Me.EsqConjU = New System.Windows.Forms.TableLayoutPanel()
        Me.U = New System.Windows.Forms.ListBox()
        Me.BaseU = New System.Windows.Forms.GroupBox()
        Me.OpcionesU = New System.Windows.Forms.TableLayoutPanel()
        Me.EditarU = New System.Windows.Forms.Button()
        Me.EliminarU = New System.Windows.Forms.Button()
        Me.AddU = New System.Windows.Forms.TextBox()
        Me.AgregarU = New System.Windows.Forms.Button()
        Me.BaseOperaciones = New System.Windows.Forms.GroupBox()
        Me.EsqOp = New System.Windows.Forms.TableLayoutPanel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OInterseccion = New System.Windows.Forms.Button()
        Me.OUnion = New System.Windows.Forms.Button()
        Me.EsqConjB = New System.Windows.Forms.TableLayoutPanel()
        Me.B = New System.Windows.Forms.ListBox()
        Me.BaseB = New System.Windows.Forms.GroupBox()
        Me.OpcionesB = New System.Windows.Forms.TableLayoutPanel()
        Me.EditarB = New System.Windows.Forms.Button()
        Me.EliminarB = New System.Windows.Forms.Button()
        Me.AddB = New System.Windows.Forms.TextBox()
        Me.AgregarB = New System.Windows.Forms.Button()
        Me.EsqConjA = New System.Windows.Forms.TableLayoutPanel()
        Me.A = New System.Windows.Forms.ListBox()
        Me.BaseA = New System.Windows.Forms.GroupBox()
        Me.OpcionesA = New System.Windows.Forms.TableLayoutPanel()
        Me.EditarA = New System.Windows.Forms.Button()
        Me.EliminarA = New System.Windows.Forms.Button()
        Me.AddA = New System.Windows.Forms.TextBox()
        Me.AgregarA = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.R = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Esqueleto.SuspendLayout()
        Me.EsqConjU.SuspendLayout()
        Me.BaseU.SuspendLayout()
        Me.OpcionesU.SuspendLayout()
        Me.BaseOperaciones.SuspendLayout()
        Me.EsqOp.SuspendLayout()
        Me.EsqConjB.SuspendLayout()
        Me.BaseB.SuspendLayout()
        Me.OpcionesB.SuspendLayout()
        Me.EsqConjA.SuspendLayout()
        Me.BaseA.SuspendLayout()
        Me.OpcionesA.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Esqueleto
        '
        Me.Esqueleto.ColumnCount = 3
        Me.Esqueleto.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.Esqueleto.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.Esqueleto.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.Esqueleto.Controls.Add(Me.EsqConjU, 2, 0)
        Me.Esqueleto.Controls.Add(Me.BaseOperaciones, 0, 1)
        Me.Esqueleto.Controls.Add(Me.EsqConjB, 1, 0)
        Me.Esqueleto.Controls.Add(Me.EsqConjA, 0, 0)
        Me.Esqueleto.Controls.Add(Me.StatusStrip1, 0, 3)
        Me.Esqueleto.Controls.Add(Me.GroupBox1, 1, 1)
        Me.Esqueleto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Esqueleto.Location = New System.Drawing.Point(0, 24)
        Me.Esqueleto.Name = "Esqueleto"
        Me.Esqueleto.RowCount = 4
        Me.Esqueleto.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.Esqueleto.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.Esqueleto.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.Esqueleto.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Esqueleto.Size = New System.Drawing.Size(845, 427)
        Me.Esqueleto.TabIndex = 0
        '
        'EsqConjU
        '
        Me.EsqConjU.ColumnCount = 2
        Me.EsqConjU.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.EsqConjU.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.EsqConjU.Controls.Add(Me.U, 0, 0)
        Me.EsqConjU.Controls.Add(Me.BaseU, 1, 0)
        Me.EsqConjU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EsqConjU.Location = New System.Drawing.Point(565, 3)
        Me.EsqConjU.Name = "EsqConjU"
        Me.EsqConjU.RowCount = 1
        Me.EsqConjU.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.EsqConjU.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129.0!))
        Me.EsqConjU.Size = New System.Drawing.Size(277, 129)
        Me.EsqConjU.TabIndex = 4
        '
        'U
        '
        Me.U.Dock = System.Windows.Forms.DockStyle.Fill
        Me.U.FormattingEnabled = True
        Me.U.Location = New System.Drawing.Point(3, 3)
        Me.U.Name = "U"
        Me.U.Size = New System.Drawing.Size(132, 123)
        Me.U.TabIndex = 0
        '
        'BaseU
        '
        Me.BaseU.Controls.Add(Me.OpcionesU)
        Me.BaseU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BaseU.Location = New System.Drawing.Point(141, 3)
        Me.BaseU.Name = "BaseU"
        Me.BaseU.Size = New System.Drawing.Size(133, 123)
        Me.BaseU.TabIndex = 1
        Me.BaseU.TabStop = False
        Me.BaseU.Text = "Conjunto Universal"
        '
        'OpcionesU
        '
        Me.OpcionesU.ColumnCount = 1
        Me.OpcionesU.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.OpcionesU.Controls.Add(Me.EditarU, 0, 3)
        Me.OpcionesU.Controls.Add(Me.EliminarU, 0, 2)
        Me.OpcionesU.Controls.Add(Me.AddU, 0, 0)
        Me.OpcionesU.Controls.Add(Me.AgregarU, 0, 1)
        Me.OpcionesU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OpcionesU.Location = New System.Drawing.Point(3, 16)
        Me.OpcionesU.Name = "OpcionesU"
        Me.OpcionesU.RowCount = 4
        Me.OpcionesU.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.OpcionesU.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.OpcionesU.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.OpcionesU.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.OpcionesU.Size = New System.Drawing.Size(127, 104)
        Me.OpcionesU.TabIndex = 2
        '
        'EditarU
        '
        Me.EditarU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditarU.Enabled = False
        Me.EditarU.Location = New System.Drawing.Point(3, 79)
        Me.EditarU.Name = "EditarU"
        Me.EditarU.Size = New System.Drawing.Size(121, 22)
        Me.EditarU.TabIndex = 3
        Me.EditarU.Text = "Editar"
        Me.EditarU.UseVisualStyleBackColor = True
        '
        'EliminarU
        '
        Me.EliminarU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EliminarU.Location = New System.Drawing.Point(3, 53)
        Me.EliminarU.Name = "EliminarU"
        Me.EliminarU.Size = New System.Drawing.Size(121, 20)
        Me.EliminarU.TabIndex = 2
        Me.EliminarU.Text = "Eliminar"
        Me.EliminarU.UseVisualStyleBackColor = True
        '
        'AddU
        '
        Me.AddU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddU.Location = New System.Drawing.Point(3, 3)
        Me.AddU.Name = "AddU"
        Me.AddU.Size = New System.Drawing.Size(121, 20)
        Me.AddU.TabIndex = 0
        '
        'AgregarU
        '
        Me.AgregarU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AgregarU.Location = New System.Drawing.Point(3, 27)
        Me.AgregarU.Name = "AgregarU"
        Me.AgregarU.Size = New System.Drawing.Size(121, 20)
        Me.AgregarU.TabIndex = 1
        Me.AgregarU.Text = "Agregar"
        Me.AgregarU.UseVisualStyleBackColor = True
        '
        'BaseOperaciones
        '
        Me.BaseOperaciones.Controls.Add(Me.EsqOp)
        Me.BaseOperaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BaseOperaciones.Location = New System.Drawing.Point(3, 138)
        Me.BaseOperaciones.Name = "BaseOperaciones"
        Me.Esqueleto.SetRowSpan(Me.BaseOperaciones, 2)
        Me.BaseOperaciones.Size = New System.Drawing.Size(275, 264)
        Me.BaseOperaciones.TabIndex = 3
        Me.BaseOperaciones.TabStop = False
        Me.BaseOperaciones.Text = "Operaciones"
        '
        'EsqOp
        '
        Me.EsqOp.ColumnCount = 2
        Me.EsqOp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.EsqOp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.EsqOp.Controls.Add(Me.Button4, 0, 2)
        Me.EsqOp.Controls.Add(Me.Button3, 0, 2)
        Me.EsqOp.Controls.Add(Me.Button2, 0, 1)
        Me.EsqOp.Controls.Add(Me.Button1, 0, 1)
        Me.EsqOp.Controls.Add(Me.OInterseccion, 1, 0)
        Me.EsqOp.Controls.Add(Me.OUnion, 0, 0)
        Me.EsqOp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EsqOp.Location = New System.Drawing.Point(3, 16)
        Me.EsqOp.Name = "EsqOp"
        Me.EsqOp.RowCount = 5
        Me.EsqOp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.EsqOp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.EsqOp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.EsqOp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.EsqOp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.EsqOp.Size = New System.Drawing.Size(269, 245)
        Me.EsqOp.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(3, 101)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 43)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Diferencia A-B"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(137, 101)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(129, 43)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Diferencia B-A"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(137, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 43)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Complemento B"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(3, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 43)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Complemento A"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OInterseccion
        '
        Me.OInterseccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OInterseccion.Location = New System.Drawing.Point(137, 3)
        Me.OInterseccion.Name = "OInterseccion"
        Me.OInterseccion.Size = New System.Drawing.Size(129, 43)
        Me.OInterseccion.TabIndex = 1
        Me.OInterseccion.Text = "Intersección"
        Me.OInterseccion.UseVisualStyleBackColor = True
        '
        'OUnion
        '
        Me.OUnion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OUnion.Location = New System.Drawing.Point(3, 3)
        Me.OUnion.Name = "OUnion"
        Me.OUnion.Size = New System.Drawing.Size(128, 43)
        Me.OUnion.TabIndex = 0
        Me.OUnion.Text = "Unión"
        Me.OUnion.UseVisualStyleBackColor = True
        '
        'EsqConjB
        '
        Me.EsqConjB.ColumnCount = 2
        Me.EsqConjB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.EsqConjB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.EsqConjB.Controls.Add(Me.B, 0, 0)
        Me.EsqConjB.Controls.Add(Me.BaseB, 1, 0)
        Me.EsqConjB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EsqConjB.Location = New System.Drawing.Point(284, 3)
        Me.EsqConjB.Name = "EsqConjB"
        Me.EsqConjB.RowCount = 1
        Me.EsqConjB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.EsqConjB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129.0!))
        Me.EsqConjB.Size = New System.Drawing.Size(275, 129)
        Me.EsqConjB.TabIndex = 1
        '
        'B
        '
        Me.B.Dock = System.Windows.Forms.DockStyle.Fill
        Me.B.FormattingEnabled = True
        Me.B.Location = New System.Drawing.Point(3, 3)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(131, 123)
        Me.B.TabIndex = 0
        '
        'BaseB
        '
        Me.BaseB.Controls.Add(Me.OpcionesB)
        Me.BaseB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BaseB.Location = New System.Drawing.Point(140, 3)
        Me.BaseB.Name = "BaseB"
        Me.BaseB.Size = New System.Drawing.Size(132, 123)
        Me.BaseB.TabIndex = 1
        Me.BaseB.TabStop = False
        Me.BaseB.Text = "Conjunto B"
        '
        'OpcionesB
        '
        Me.OpcionesB.ColumnCount = 1
        Me.OpcionesB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.OpcionesB.Controls.Add(Me.EditarB, 0, 3)
        Me.OpcionesB.Controls.Add(Me.EliminarB, 0, 2)
        Me.OpcionesB.Controls.Add(Me.AddB, 0, 0)
        Me.OpcionesB.Controls.Add(Me.AgregarB, 0, 1)
        Me.OpcionesB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OpcionesB.Location = New System.Drawing.Point(3, 16)
        Me.OpcionesB.Name = "OpcionesB"
        Me.OpcionesB.RowCount = 4
        Me.OpcionesB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.OpcionesB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.OpcionesB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.OpcionesB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.OpcionesB.Size = New System.Drawing.Size(126, 104)
        Me.OpcionesB.TabIndex = 1
        '
        'EditarB
        '
        Me.EditarB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditarB.Enabled = False
        Me.EditarB.Location = New System.Drawing.Point(3, 79)
        Me.EditarB.Name = "EditarB"
        Me.EditarB.Size = New System.Drawing.Size(120, 22)
        Me.EditarB.TabIndex = 3
        Me.EditarB.Text = "Editar"
        Me.EditarB.UseVisualStyleBackColor = True
        '
        'EliminarB
        '
        Me.EliminarB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EliminarB.Location = New System.Drawing.Point(3, 53)
        Me.EliminarB.Name = "EliminarB"
        Me.EliminarB.Size = New System.Drawing.Size(120, 20)
        Me.EliminarB.TabIndex = 2
        Me.EliminarB.Text = "Eliminar"
        Me.EliminarB.UseVisualStyleBackColor = True
        '
        'AddB
        '
        Me.AddB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddB.Location = New System.Drawing.Point(3, 3)
        Me.AddB.Name = "AddB"
        Me.AddB.Size = New System.Drawing.Size(120, 20)
        Me.AddB.TabIndex = 0
        '
        'AgregarB
        '
        Me.AgregarB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AgregarB.Location = New System.Drawing.Point(3, 27)
        Me.AgregarB.Name = "AgregarB"
        Me.AgregarB.Size = New System.Drawing.Size(120, 20)
        Me.AgregarB.TabIndex = 1
        Me.AgregarB.Text = "Agregar"
        Me.AgregarB.UseVisualStyleBackColor = True
        '
        'EsqConjA
        '
        Me.EsqConjA.ColumnCount = 2
        Me.EsqConjA.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.EsqConjA.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.EsqConjA.Controls.Add(Me.A, 0, 0)
        Me.EsqConjA.Controls.Add(Me.BaseA, 1, 0)
        Me.EsqConjA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EsqConjA.Location = New System.Drawing.Point(3, 3)
        Me.EsqConjA.Name = "EsqConjA"
        Me.EsqConjA.RowCount = 1
        Me.EsqConjA.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.EsqConjA.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129.0!))
        Me.EsqConjA.Size = New System.Drawing.Size(275, 129)
        Me.EsqConjA.TabIndex = 0
        '
        'A
        '
        Me.A.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A.FormattingEnabled = True
        Me.A.Location = New System.Drawing.Point(3, 3)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(131, 123)
        Me.A.TabIndex = 0
        '
        'BaseA
        '
        Me.BaseA.Controls.Add(Me.OpcionesA)
        Me.BaseA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BaseA.Location = New System.Drawing.Point(140, 3)
        Me.BaseA.Name = "BaseA"
        Me.BaseA.Size = New System.Drawing.Size(132, 123)
        Me.BaseA.TabIndex = 1
        Me.BaseA.TabStop = False
        Me.BaseA.Text = "Conjunto A"
        '
        'OpcionesA
        '
        Me.OpcionesA.ColumnCount = 1
        Me.OpcionesA.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.OpcionesA.Controls.Add(Me.EditarA, 0, 3)
        Me.OpcionesA.Controls.Add(Me.EliminarA, 0, 2)
        Me.OpcionesA.Controls.Add(Me.AddA, 0, 0)
        Me.OpcionesA.Controls.Add(Me.AgregarA, 0, 1)
        Me.OpcionesA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OpcionesA.Location = New System.Drawing.Point(3, 16)
        Me.OpcionesA.Name = "OpcionesA"
        Me.OpcionesA.RowCount = 4
        Me.OpcionesA.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.OpcionesA.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.OpcionesA.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.OpcionesA.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.OpcionesA.Size = New System.Drawing.Size(126, 104)
        Me.OpcionesA.TabIndex = 0
        '
        'EditarA
        '
        Me.EditarA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditarA.Enabled = False
        Me.EditarA.Location = New System.Drawing.Point(3, 79)
        Me.EditarA.Name = "EditarA"
        Me.EditarA.Size = New System.Drawing.Size(120, 22)
        Me.EditarA.TabIndex = 3
        Me.EditarA.Text = "Editar"
        Me.EditarA.UseVisualStyleBackColor = True
        '
        'EliminarA
        '
        Me.EliminarA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EliminarA.Location = New System.Drawing.Point(3, 53)
        Me.EliminarA.Name = "EliminarA"
        Me.EliminarA.Size = New System.Drawing.Size(120, 20)
        Me.EliminarA.TabIndex = 2
        Me.EliminarA.Text = "Eliminar"
        Me.EliminarA.UseVisualStyleBackColor = True
        '
        'AddA
        '
        Me.AddA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddA.Location = New System.Drawing.Point(3, 3)
        Me.AddA.Name = "AddA"
        Me.AddA.Size = New System.Drawing.Size(120, 20)
        Me.AddA.TabIndex = 0
        '
        'AgregarA
        '
        Me.AgregarA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AgregarA.Location = New System.Drawing.Point(3, 27)
        Me.AgregarA.Name = "AgregarA"
        Me.AgregarA.Size = New System.Drawing.Size(120, 20)
        Me.AgregarA.TabIndex = 1
        Me.AgregarA.Text = "Agregar"
        Me.AgregarA.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Esqueleto.SetColumnSpan(Me.StatusStrip1, 3)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 405)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(845, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(260, 17)
        Me.ToolStripStatusLabel1.Text = "Copyright © 2014 Yael Arturo Chavoya Andalón"
        '
        'GroupBox1
        '
        Me.Esqueleto.SetColumnSpan(Me.GroupBox1, 2)
        Me.GroupBox1.Controls.Add(Me.R)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(284, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.Esqueleto.SetRowSpan(Me.GroupBox1, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(558, 264)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultado"
        '
        'R
        '
        Me.R.Dock = System.Windows.Forms.DockStyle.Fill
        Me.R.FormattingEnabled = True
        Me.R.Location = New System.Drawing.Point(3, 16)
        Me.R.Name = "R"
        Me.R.Size = New System.Drawing.Size(552, 245)
        Me.R.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(845, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ToolStripSeparator1, Me.CerrarToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir (próximamente)"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar (próximamente)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(201, 6)
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'Joint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 451)
        Me.Controls.Add(Me.Esqueleto)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Joint"
        Me.Text = "Joint"
        Me.Esqueleto.ResumeLayout(False)
        Me.Esqueleto.PerformLayout()
        Me.EsqConjU.ResumeLayout(False)
        Me.BaseU.ResumeLayout(False)
        Me.OpcionesU.ResumeLayout(False)
        Me.OpcionesU.PerformLayout()
        Me.BaseOperaciones.ResumeLayout(False)
        Me.EsqOp.ResumeLayout(False)
        Me.EsqConjB.ResumeLayout(False)
        Me.BaseB.ResumeLayout(False)
        Me.OpcionesB.ResumeLayout(False)
        Me.OpcionesB.PerformLayout()
        Me.EsqConjA.ResumeLayout(False)
        Me.BaseA.ResumeLayout(False)
        Me.OpcionesA.ResumeLayout(False)
        Me.OpcionesA.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Esqueleto As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EsqConjB As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents B As System.Windows.Forms.ListBox
    Friend WithEvents BaseB As System.Windows.Forms.GroupBox
    Friend WithEvents EsqConjA As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents A As System.Windows.Forms.ListBox
    Friend WithEvents BaseA As System.Windows.Forms.GroupBox
    Friend WithEvents BaseOperaciones As System.Windows.Forms.GroupBox
    Friend WithEvents EsqConjU As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents U As System.Windows.Forms.ListBox
    Friend WithEvents BaseU As System.Windows.Forms.GroupBox
    Friend WithEvents OpcionesA As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AddA As System.Windows.Forms.TextBox
    Friend WithEvents AgregarA As System.Windows.Forms.Button
    Friend WithEvents EditarA As System.Windows.Forms.Button
    Friend WithEvents EliminarA As System.Windows.Forms.Button
    Friend WithEvents OpcionesB As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EditarB As System.Windows.Forms.Button
    Friend WithEvents EliminarB As System.Windows.Forms.Button
    Friend WithEvents AddB As System.Windows.Forms.TextBox
    Friend WithEvents AgregarB As System.Windows.Forms.Button
    Friend WithEvents OpcionesU As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EditarU As System.Windows.Forms.Button
    Friend WithEvents EliminarU As System.Windows.Forms.Button
    Friend WithEvents AddU As System.Windows.Forms.TextBox
    Friend WithEvents AgregarU As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents R As System.Windows.Forms.ListBox
    Friend WithEvents EsqOp As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OUnion As System.Windows.Forms.Button
    Friend WithEvents OInterseccion As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
