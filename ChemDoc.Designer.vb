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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChemDoc))
        Dim SimboloLabel As System.Windows.Forms.Label
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.Copyright = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuTabs = New System.Windows.Forms.TabControl()
        Me.Oxidos = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Seleccionar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Hidroxidos = New System.Windows.Forms.TabPage()
        Me.Hidracidos = New System.Windows.Forms.TabPage()
        Me.Hidruros = New System.Windows.Forms.TabPage()
        Me.Oxacidos = New System.Windows.Forms.TabPage()
        Me.MainTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Elements = New Episteme.ElementsDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SimboloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SimboloTableAdapter = New Episteme.ElementsDataSetTableAdapters.SimboloTableAdapter()
        Me.TableAdapterManager = New Episteme.ElementsDataSetTableAdapters.TableAdapterManager()
        Me.SimboloBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.SimboloBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SimboloTextBox = New System.Windows.Forms.TextBox()
        SimboloLabel = New System.Windows.Forms.Label()
        Me.MenuBar.SuspendLayout()
        Me.Status.SuspendLayout()
        Me.MenuTabs.SuspendLayout()
        Me.Oxidos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.MainTable.SuspendLayout()
        CType(Me.Elements, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimboloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimboloBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SimboloBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuBar
        '
        Me.MenuBar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(565, 24)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.Text = "MenuStrip1"
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
        'Status
        '
        Me.Status.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Copyright})
        Me.Status.Location = New System.Drawing.Point(0, 304)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(565, 22)
        Me.Status.TabIndex = 1
        Me.Status.Text = "StatusStrip1"
        '
        'Copyright
        '
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(233, 17)
        Me.Copyright.Text = "Copyright © Yael Arturo Chavoya Andalón"
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
        Me.MenuTabs.Size = New System.Drawing.Size(559, 274)
        Me.MenuTabs.TabIndex = 2
        '
        'Oxidos
        '
        Me.Oxidos.AutoScroll = True
        Me.Oxidos.Controls.Add(Me.GroupBox3)
        Me.Oxidos.Controls.Add(Me.GroupBox2)
        Me.Oxidos.Controls.Add(Me.GroupBox1)
        Me.Oxidos.Location = New System.Drawing.Point(4, 22)
        Me.Oxidos.Name = "Oxidos"
        Me.Oxidos.Padding = New System.Windows.Forms.Padding(3)
        Me.Oxidos.Size = New System.Drawing.Size(551, 248)
        Me.Oxidos.TabIndex = 1
        Me.Oxidos.Text = "Óxidos"
        Me.Oxidos.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(SimboloLabel)
        Me.GroupBox3.Controls.Add(Me.SimboloTextBox)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(226, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(355, 236)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resultado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 51)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButton2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioButton1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(208, 32)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton2.Location = New System.Drawing.Point(107, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(98, 26)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No Metálico"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton1.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(98, 26)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Metálico"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 179)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Seleccionar, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Calcular, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.875!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.625!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(208, 160)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Seleccionar
        '
        Me.Seleccionar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Seleccionar.Location = New System.Drawing.Point(3, 130)
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Size = New System.Drawing.Size(98, 27)
        Me.Seleccionar.TabIndex = 0
        Me.Seleccionar.Text = "Seleccionar..."
        Me.Seleccionar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 73)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "H"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label2, 2)
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "+1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Calcular
        '
        Me.Calcular.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Calcular.Location = New System.Drawing.Point(107, 130)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(98, 27)
        Me.Calcular.TabIndex = 3
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Hidroxidos
        '
        Me.Hidroxidos.Location = New System.Drawing.Point(4, 22)
        Me.Hidroxidos.Name = "Hidroxidos"
        Me.Hidroxidos.Size = New System.Drawing.Size(551, 248)
        Me.Hidroxidos.TabIndex = 2
        Me.Hidroxidos.Text = "Hidróxidos"
        Me.Hidroxidos.UseVisualStyleBackColor = True
        '
        'Hidracidos
        '
        Me.Hidracidos.Location = New System.Drawing.Point(4, 22)
        Me.Hidracidos.Name = "Hidracidos"
        Me.Hidracidos.Size = New System.Drawing.Size(551, 248)
        Me.Hidracidos.TabIndex = 3
        Me.Hidracidos.Text = "Hidrácidos"
        Me.Hidracidos.UseVisualStyleBackColor = True
        '
        'Hidruros
        '
        Me.Hidruros.Location = New System.Drawing.Point(4, 22)
        Me.Hidruros.Name = "Hidruros"
        Me.Hidruros.Size = New System.Drawing.Size(551, 248)
        Me.Hidruros.TabIndex = 4
        Me.Hidruros.Text = "Hidruros"
        Me.Hidruros.UseVisualStyleBackColor = True
        '
        'Oxacidos
        '
        Me.Oxacidos.Location = New System.Drawing.Point(4, 22)
        Me.Oxacidos.Name = "Oxacidos"
        Me.Oxacidos.Size = New System.Drawing.Size(551, 248)
        Me.Oxacidos.TabIndex = 5
        Me.Oxacidos.Text = "Oxácidos"
        Me.Oxacidos.UseVisualStyleBackColor = True
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
        Me.MainTable.Size = New System.Drawing.Size(565, 280)
        Me.MainTable.TabIndex = 3
        '
        'Elements
        '
        Me.Elements.DataSetName = "ElementsDataSet"
        Me.Elements.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Label3"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(41, 137)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'SimboloBindingSource
        '
        Me.SimboloBindingSource.DataMember = "Simbolo"
        Me.SimboloBindingSource.DataSource = Me.Elements
        '
        'SimboloTableAdapter
        '
        Me.SimboloTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SimboloTableAdapter = Me.SimboloTableAdapter
        Me.TableAdapterManager.UpdateOrder = Episteme.ElementsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SimboloBindingNavigator
        '
        Me.SimboloBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SimboloBindingNavigator.BindingSource = Me.SimboloBindingSource
        Me.SimboloBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SimboloBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SimboloBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SimboloBindingNavigatorSaveItem})
        Me.SimboloBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.SimboloBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SimboloBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SimboloBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SimboloBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SimboloBindingNavigator.Name = "SimboloBindingNavigator"
        Me.SimboloBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SimboloBindingNavigator.Size = New System.Drawing.Size(565, 25)
        Me.SimboloBindingNavigator.TabIndex = 4
        Me.SimboloBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'SimboloBindingNavigatorSaveItem
        '
        Me.SimboloBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SimboloBindingNavigatorSaveItem.Image = CType(resources.GetObject("SimboloBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SimboloBindingNavigatorSaveItem.Name = "SimboloBindingNavigatorSaveItem"
        Me.SimboloBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.SimboloBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'SimboloLabel
        '
        SimboloLabel.AutoSize = True
        SimboloLabel.Location = New System.Drawing.Point(95, 76)
        SimboloLabel.Name = "SimboloLabel"
        SimboloLabel.Size = New System.Drawing.Size(47, 13)
        SimboloLabel.TabIndex = 2
        SimboloLabel.Text = "Simbolo:"
        'AddHandler SimboloLabel.Click, AddressOf Me.SimboloLabel_Click
        '
        'SimboloTextBox
        '
        Me.SimboloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SimboloBindingSource, "Simbolo", True))
        Me.SimboloTextBox.Location = New System.Drawing.Point(148, 73)
        Me.SimboloTextBox.Name = "SimboloTextBox"
        Me.SimboloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SimboloTextBox.TabIndex = 3
        '
        'ChemDoc
        '
        Me.AcceptButton = Me.Calcular
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 326)
        Me.Controls.Add(Me.SimboloBindingNavigator)
        Me.Controls.Add(Me.MainTable)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.MenuBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuBar
        Me.MaximizeBox = False
        Me.Name = "ChemDoc"
        Me.Text = "ChemDoc"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.MenuTabs.ResumeLayout(False)
        Me.Oxidos.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.MainTable.ResumeLayout(False)
        CType(Me.Elements, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimboloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimboloBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SimboloBindingNavigator.ResumeLayout(False)
        Me.SimboloBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuBar As System.Windows.Forms.MenuStrip
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Seleccionar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Calcular As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Elements As Episteme.ElementsDataSet
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents SimboloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SimboloTableAdapter As Episteme.ElementsDataSetTableAdapters.SimboloTableAdapter
    Friend WithEvents TableAdapterManager As Episteme.ElementsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SimboloBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SimboloBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SimboloTextBox As System.Windows.Forms.TextBox
End Class
