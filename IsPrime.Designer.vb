<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IsPrime
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Body = New System.Windows.Forms.TableLayoutPanel()
        Me.InputBox = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Input = New System.Windows.Forms.TextBox()
        Me.Btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OutList = New System.Windows.Forms.ListBox()
        Me.Isit = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Body.SuspendLayout()
        Me.InputBox.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(562, 24)
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
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 231)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(562, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Body
        '
        Me.Body.ColumnCount = 2
        Me.Body.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Body.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Body.Controls.Add(Me.InputBox, 0, 0)
        Me.Body.Controls.Add(Me.GroupBox1, 1, 0)
        Me.Body.Controls.Add(Me.Isit, 0, 1)
        Me.Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Body.Location = New System.Drawing.Point(0, 24)
        Me.Body.Name = "Body"
        Me.Body.RowCount = 2
        Me.Body.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.61353!))
        Me.Body.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.38647!))
        Me.Body.Size = New System.Drawing.Size(562, 207)
        Me.Body.TabIndex = 2
        '
        'InputBox
        '
        Me.InputBox.Controls.Add(Me.TableLayoutPanel1)
        Me.InputBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InputBox.Location = New System.Drawing.Point(3, 3)
        Me.InputBox.Name = "InputBox"
        Me.InputBox.Size = New System.Drawing.Size(275, 76)
        Me.InputBox.TabIndex = 0
        Me.InputBox.TabStop = False
        Me.InputBox.Text = "Parámetros"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Input, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(269, 57)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Input
        '
        Me.Input.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Input.Location = New System.Drawing.Point(3, 3)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(263, 20)
        Me.Input.TabIndex = 0
        '
        'Btn
        '
        Me.Btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn.Location = New System.Drawing.Point(3, 28)
        Me.Btn.Name = "Btn"
        Me.Btn.Size = New System.Drawing.Size(263, 26)
        Me.Btn.TabIndex = 1
        Me.Btn.Text = "¿Es Primo?"
        Me.Btn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OutList)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(284, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.Body.SetRowSpan(Me.GroupBox1, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(275, 201)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Factores"
        '
        'OutList
        '
        Me.OutList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OutList.FormattingEnabled = True
        Me.OutList.Location = New System.Drawing.Point(3, 16)
        Me.OutList.Name = "OutList"
        Me.OutList.Size = New System.Drawing.Size(269, 182)
        Me.OutList.TabIndex = 0
        '
        'Isit
        '
        Me.Isit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Isit.AutoSize = True
        Me.Isit.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Isit.Location = New System.Drawing.Point(3, 82)
        Me.Isit.Name = "Isit"
        Me.Isit.Size = New System.Drawing.Size(275, 125)
        Me.Isit.TabIndex = 2
        Me.Isit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IsPrime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 253)
        Me.Controls.Add(Me.Body)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "IsPrime"
        Me.Text = "IsPrime"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Body.ResumeLayout(False)
        Me.Body.PerformLayout()
        Me.InputBox.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Body As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents InputBox As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Input As System.Windows.Forms.TextBox
    Friend WithEvents Btn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OutList As System.Windows.Forms.ListBox
    Friend WithEvents Isit As System.Windows.Forms.Label
End Class
