<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Electro
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
        Me.ElectroBody = New System.Windows.Forms.TableLayoutPanel()
        Me.ElectroBtnTable = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnResist = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.CloseBtn = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ElectroBody.SuspendLayout()
        Me.ElectroBtnTable.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ElectroBody
        '
        Me.ElectroBody.ColumnCount = 1
        Me.ElectroBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ElectroBody.Controls.Add(Me.ElectroBtnTable, 0, 1)
        Me.ElectroBody.Controls.Add(Me.NameLabel, 0, 0)
        Me.ElectroBody.Controls.Add(Me.StatusStrip1, 0, 2)
        Me.ElectroBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElectroBody.Location = New System.Drawing.Point(0, 0)
        Me.ElectroBody.Name = "ElectroBody"
        Me.ElectroBody.RowCount = 3
        Me.ElectroBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.ElectroBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ElectroBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ElectroBody.Size = New System.Drawing.Size(307, 167)
        Me.ElectroBody.TabIndex = 0
        '
        'ElectroBtnTable
        '
        Me.ElectroBtnTable.ColumnCount = 1
        Me.ElectroBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.ElectroBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.ElectroBtnTable.Controls.Add(Me.BtnResist, 0, 0)
        Me.ElectroBtnTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElectroBtnTable.Location = New System.Drawing.Point(3, 83)
        Me.ElectroBtnTable.Name = "ElectroBtnTable"
        Me.ElectroBtnTable.RowCount = 1
        Me.ElectroBtnTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ElectroBtnTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ElectroBtnTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.ElectroBtnTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.ElectroBtnTable.Size = New System.Drawing.Size(301, 61)
        Me.ElectroBtnTable.TabIndex = 0
        '
        'BtnResist
        '
        Me.BtnResist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnResist.Location = New System.Drawing.Point(3, 3)
        Me.BtnResist.Name = "BtnResist"
        Me.BtnResist.Size = New System.Drawing.Size(295, 55)
        Me.BtnResist.TabIndex = 0
        Me.BtnResist.Text = "Resist" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Resistencias en serie y paralelo"
        Me.BtnResist.UseVisualStyleBackColor = True
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
        Me.NameLabel.Text = "Electrónica"
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
        'Electro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 167)
        Me.Controls.Add(Me.ElectroBody)
        Me.Name = "Electro"
        Me.Text = "Electrónica - Episteme"
        Me.ElectroBody.ResumeLayout(False)
        Me.ElectroBody.PerformLayout()
        Me.ElectroBtnTable.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ElectroBody As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ElectroBtnTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnResist As System.Windows.Forms.Button
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents CloseBtn As System.Windows.Forms.ToolStripDropDownButton
End Class
