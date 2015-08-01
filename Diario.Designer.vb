<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Diario
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
        Me.DiarioBody = New System.Windows.Forms.TableLayoutPanel()
        Me.DiarioBtnTable = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnIMC = New System.Windows.Forms.Button()
        Me.BtnFusion = New System.Windows.Forms.Button()
        Me.BtnEplog = New System.Windows.Forms.Button()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.CloseBtn = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DiarioBody.SuspendLayout()
        Me.DiarioBtnTable.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DiarioBody
        '
        Me.DiarioBody.ColumnCount = 1
        Me.DiarioBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DiarioBody.Controls.Add(Me.DiarioBtnTable, 0, 1)
        Me.DiarioBody.Controls.Add(Me.NameLabel, 0, 0)
        Me.DiarioBody.Controls.Add(Me.StatusStrip1, 0, 2)
        Me.DiarioBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DiarioBody.Location = New System.Drawing.Point(0, 0)
        Me.DiarioBody.Name = "DiarioBody"
        Me.DiarioBody.RowCount = 3
        Me.DiarioBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.DiarioBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DiarioBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DiarioBody.Size = New System.Drawing.Size(682, 240)
        Me.DiarioBody.TabIndex = 0
        '
        'DiarioBtnTable
        '
        Me.DiarioBtnTable.ColumnCount = 2
        Me.DiarioBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.DiarioBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.DiarioBtnTable.Controls.Add(Me.BtnIMC, 0, 1)
        Me.DiarioBtnTable.Controls.Add(Me.BtnFusion, 0, 1)
        Me.DiarioBtnTable.Controls.Add(Me.BtnEplog, 1, 0)
        Me.DiarioBtnTable.Controls.Add(Me.BtnCalc, 0, 0)
        Me.DiarioBtnTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DiarioBtnTable.Location = New System.Drawing.Point(3, 83)
        Me.DiarioBtnTable.Name = "DiarioBtnTable"
        Me.DiarioBtnTable.RowCount = 2
        Me.DiarioBtnTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.DiarioBtnTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.DiarioBtnTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DiarioBtnTable.Size = New System.Drawing.Size(676, 134)
        Me.DiarioBtnTable.TabIndex = 0
        '
        'BtnIMC
        '
        Me.BtnIMC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnIMC.Location = New System.Drawing.Point(3, 70)
        Me.BtnIMC.Name = "BtnIMC"
        Me.BtnIMC.Size = New System.Drawing.Size(332, 61)
        Me.BtnIMC.TabIndex = 6
        Me.BtnIMC.Text = "IMC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculador de IMC"
        Me.BtnIMC.UseVisualStyleBackColor = True
        '
        'BtnFusion
        '
        Me.BtnFusion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnFusion.Enabled = False
        Me.BtnFusion.Location = New System.Drawing.Point(341, 70)
        Me.BtnFusion.Name = "BtnFusion"
        Me.BtnFusion.Size = New System.Drawing.Size(332, 61)
        Me.BtnFusion.TabIndex = 5
        Me.BtnFusion.Text = "Fusion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Conversor de unidades"
        Me.BtnFusion.UseVisualStyleBackColor = True
        '
        'BtnEplog
        '
        Me.BtnEplog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnEplog.Location = New System.Drawing.Point(341, 3)
        Me.BtnEplog.Name = "BtnEplog"
        Me.BtnEplog.Size = New System.Drawing.Size(332, 61)
        Me.BtnEplog.TabIndex = 1
        Me.BtnEplog.Text = "Eplog" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Editor de texto"
        Me.BtnEplog.UseVisualStyleBackColor = True
        '
        'BtnCalc
        '
        Me.BtnCalc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnCalc.Enabled = False
        Me.BtnCalc.Location = New System.Drawing.Point(3, 3)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(332, 61)
        Me.BtnCalc.TabIndex = 0
        Me.BtnCalc.Text = "Calc" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculadora"
        Me.BtnCalc.UseVisualStyleBackColor = True
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
        Me.NameLabel.Text = "Uso diario"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseBtn})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 220)
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
        'Diario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 240)
        Me.Controls.Add(Me.DiarioBody)
        Me.Name = "Diario"
        Me.Text = "Uso diario - Episteme"
        Me.DiarioBody.ResumeLayout(False)
        Me.DiarioBody.PerformLayout()
        Me.DiarioBtnTable.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DiarioBody As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DiarioBtnTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnCalc As System.Windows.Forms.Button
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents BtnEplog As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents CloseBtn As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents BtnIMC As System.Windows.Forms.Button
    Friend WithEvents BtnFusion As System.Windows.Forms.Button
End Class
