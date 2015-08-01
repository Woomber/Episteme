<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quimica
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
        Me.QuimicaBody = New System.Windows.Forms.TableLayoutPanel()
        Me.QuimicaBtnTable = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnChemDoc = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.CloseBtn = New System.Windows.Forms.ToolStripDropDownButton()
        Me.QuimicaBody.SuspendLayout()
        Me.QuimicaBtnTable.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'QuimicaBody
        '
        Me.QuimicaBody.ColumnCount = 1
        Me.QuimicaBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.QuimicaBody.Controls.Add(Me.QuimicaBtnTable, 0, 1)
        Me.QuimicaBody.Controls.Add(Me.NameLabel, 0, 0)
        Me.QuimicaBody.Controls.Add(Me.StatusStrip1, 0, 2)
        Me.QuimicaBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QuimicaBody.Location = New System.Drawing.Point(0, 0)
        Me.QuimicaBody.Name = "QuimicaBody"
        Me.QuimicaBody.RowCount = 3
        Me.QuimicaBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.QuimicaBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.QuimicaBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.QuimicaBody.Size = New System.Drawing.Size(307, 167)
        Me.QuimicaBody.TabIndex = 0
        '
        'QuimicaBtnTable
        '
        Me.QuimicaBtnTable.ColumnCount = 1
        Me.QuimicaBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.QuimicaBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.QuimicaBtnTable.Controls.Add(Me.BtnChemDoc, 0, 0)
        Me.QuimicaBtnTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QuimicaBtnTable.Location = New System.Drawing.Point(3, 83)
        Me.QuimicaBtnTable.Name = "QuimicaBtnTable"
        Me.QuimicaBtnTable.RowCount = 1
        Me.QuimicaBtnTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.QuimicaBtnTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.QuimicaBtnTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.QuimicaBtnTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.QuimicaBtnTable.Size = New System.Drawing.Size(301, 61)
        Me.QuimicaBtnTable.TabIndex = 0
        '
        'BtnChemDoc
        '
        Me.BtnChemDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnChemDoc.Enabled = False
        Me.BtnChemDoc.Location = New System.Drawing.Point(3, 3)
        Me.BtnChemDoc.Name = "BtnChemDoc"
        Me.BtnChemDoc.Size = New System.Drawing.Size(295, 55)
        Me.BtnChemDoc.TabIndex = 0
        Me.BtnChemDoc.Text = "ChemDoc" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnChemDoc.UseVisualStyleBackColor = True
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
        Me.NameLabel.Size = New System.Drawing.Size(301, 80)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Química"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseBtn})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 147)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(307, 20)
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
        'Quimica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 167)
        Me.Controls.Add(Me.QuimicaBody)
        Me.Name = "Quimica"
        Me.Text = "Química - Episteme"
        Me.QuimicaBody.ResumeLayout(False)
        Me.QuimicaBody.PerformLayout()
        Me.QuimicaBtnTable.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QuimicaBody As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents QuimicaBtnTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnChemDoc As System.Windows.Forms.Button
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents CloseBtn As System.Windows.Forms.ToolStripDropDownButton
End Class
