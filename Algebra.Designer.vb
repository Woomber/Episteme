<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Algebra
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
        Me.AlgebraBody = New System.Windows.Forms.TableLayoutPanel()
        Me.AlgebraBtnTable = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnKross = New System.Windows.Forms.Button()
        Me.BtnMBSolve = New System.Windows.Forms.Button()
        Me.BtnComplex = New System.Windows.Forms.Button()
        Me.BtnEqala = New System.Windows.Forms.Button()
        Me.BtnQadratic = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.CloseBtn = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AlgebraBody.SuspendLayout()
        Me.AlgebraBtnTable.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AlgebraBody
        '
        Me.AlgebraBody.ColumnCount = 1
        Me.AlgebraBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AlgebraBody.Controls.Add(Me.AlgebraBtnTable, 0, 1)
        Me.AlgebraBody.Controls.Add(Me.NameLabel, 0, 0)
        Me.AlgebraBody.Controls.Add(Me.StatusStrip1, 0, 2)
        Me.AlgebraBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlgebraBody.Location = New System.Drawing.Point(0, 0)
        Me.AlgebraBody.Name = "AlgebraBody"
        Me.AlgebraBody.RowCount = 3
        Me.AlgebraBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.AlgebraBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AlgebraBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.AlgebraBody.Size = New System.Drawing.Size(682, 183)
        Me.AlgebraBody.TabIndex = 0
        '
        'AlgebraBtnTable
        '
        Me.AlgebraBtnTable.ColumnCount = 5
        Me.AlgebraBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.AlgebraBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.AlgebraBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.AlgebraBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.AlgebraBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.AlgebraBtnTable.Controls.Add(Me.BtnKross, 4, 0)
        Me.AlgebraBtnTable.Controls.Add(Me.BtnMBSolve, 2, 0)
        Me.AlgebraBtnTable.Controls.Add(Me.BtnComplex, 3, 0)
        Me.AlgebraBtnTable.Controls.Add(Me.BtnEqala, 1, 0)
        Me.AlgebraBtnTable.Controls.Add(Me.BtnQadratic, 0, 0)
        Me.AlgebraBtnTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlgebraBtnTable.Location = New System.Drawing.Point(3, 83)
        Me.AlgebraBtnTable.Name = "AlgebraBtnTable"
        Me.AlgebraBtnTable.RowCount = 1
        Me.AlgebraBtnTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AlgebraBtnTable.Size = New System.Drawing.Size(676, 77)
        Me.AlgebraBtnTable.TabIndex = 0
        '
        'BtnKross
        '
        Me.BtnKross.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnKross.Enabled = False
        Me.BtnKross.Location = New System.Drawing.Point(543, 3)
        Me.BtnKross.Name = "BtnKross"
        Me.BtnKross.Size = New System.Drawing.Size(130, 71)
        Me.BtnKross.TabIndex = 4
        Me.BtnKross.Text = "Kross" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ecuaciones simultáneas"
        Me.BtnKross.UseVisualStyleBackColor = True
        '
        'BtnMBSolve
        '
        Me.BtnMBSolve.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnMBSolve.Enabled = False
        Me.BtnMBSolve.Location = New System.Drawing.Point(273, 3)
        Me.BtnMBSolve.Name = "BtnMBSolve"
        Me.BtnMBSolve.Size = New System.Drawing.Size(129, 71)
        Me.BtnMBSolve.TabIndex = 3
        Me.BtnMBSolve.Text = "MBSolve" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ecuaciones cuadráticas"
        Me.BtnMBSolve.UseVisualStyleBackColor = True
        '
        'BtnComplex
        '
        Me.BtnComplex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnComplex.Enabled = False
        Me.BtnComplex.Location = New System.Drawing.Point(408, 3)
        Me.BtnComplex.Name = "BtnComplex"
        Me.BtnComplex.Size = New System.Drawing.Size(129, 71)
        Me.BtnComplex.TabIndex = 2
        Me.BtnComplex.Text = "Complex" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Números complejos"
        Me.BtnComplex.UseVisualStyleBackColor = True
        '
        'BtnEqala
        '
        Me.BtnEqala.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnEqala.Enabled = False
        Me.BtnEqala.Location = New System.Drawing.Point(138, 3)
        Me.BtnEqala.Name = "BtnEqala"
        Me.BtnEqala.Size = New System.Drawing.Size(129, 71)
        Me.BtnEqala.TabIndex = 1
        Me.BtnEqala.Text = "Eqala" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ecuaciones lineales"
        Me.BtnEqala.UseVisualStyleBackColor = True
        '
        'BtnQadratic
        '
        Me.BtnQadratic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnQadratic.Location = New System.Drawing.Point(3, 3)
        Me.BtnQadratic.Name = "BtnQadratic"
        Me.BtnQadratic.Size = New System.Drawing.Size(129, 71)
        Me.BtnQadratic.TabIndex = 0
        Me.BtnQadratic.Text = "Qadratic" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sucesiones cuadráticas"
        Me.BtnQadratic.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameLabel.AutoSize = True
        Me.NameLabel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(3, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(676, 80)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Álgebra"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseBtn})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 163)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(682, 20)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'CloseBtn
        '
        Me.CloseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CloseBtn.Image = Global.Episteme.My.Resources.Resources.Delete
        Me.CloseBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(29, 18)
        Me.CloseBtn.Text = "ToolStripDropDownButton1"
        '
        'Algebra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 183)
        Me.Controls.Add(Me.AlgebraBody)
        Me.Name = "Algebra"
        Me.Text = "Álgebra - Episteme"
        Me.AlgebraBody.ResumeLayout(False)
        Me.AlgebraBody.PerformLayout()
        Me.AlgebraBtnTable.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AlgebraBody As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AlgebraBtnTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnQadratic As System.Windows.Forms.Button
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents BtnKross As System.Windows.Forms.Button
    Friend WithEvents BtnMBSolve As System.Windows.Forms.Button
    Friend WithEvents BtnComplex As System.Windows.Forms.Button
    Friend WithEvents BtnEqala As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents CloseBtn As System.Windows.Forms.ToolStripDropDownButton
End Class
