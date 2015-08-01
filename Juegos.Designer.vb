<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Juegos
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
        Me.JuegosBody = New System.Windows.Forms.TableLayoutPanel()
        Me.JuegosBtnTable = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnBetcha = New System.Windows.Forms.Button()
        Me.BtnPredixis = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.CloseBtn = New System.Windows.Forms.ToolStripDropDownButton()
        Me.JuegosBody.SuspendLayout()
        Me.JuegosBtnTable.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'JuegosBody
        '
        Me.JuegosBody.ColumnCount = 1
        Me.JuegosBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.JuegosBody.Controls.Add(Me.JuegosBtnTable, 0, 1)
        Me.JuegosBody.Controls.Add(Me.NameLabel, 0, 0)
        Me.JuegosBody.Controls.Add(Me.StatusStrip1, 0, 2)
        Me.JuegosBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JuegosBody.Location = New System.Drawing.Point(0, 0)
        Me.JuegosBody.Name = "JuegosBody"
        Me.JuegosBody.RowCount = 3
        Me.JuegosBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.JuegosBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.JuegosBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.JuegosBody.Size = New System.Drawing.Size(682, 176)
        Me.JuegosBody.TabIndex = 0
        '
        'JuegosBtnTable
        '
        Me.JuegosBtnTable.ColumnCount = 2
        Me.JuegosBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.JuegosBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.JuegosBtnTable.Controls.Add(Me.BtnBetcha, 1, 0)
        Me.JuegosBtnTable.Controls.Add(Me.BtnPredixis, 0, 0)
        Me.JuegosBtnTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JuegosBtnTable.Location = New System.Drawing.Point(3, 83)
        Me.JuegosBtnTable.Name = "JuegosBtnTable"
        Me.JuegosBtnTable.RowCount = 1
        Me.JuegosBtnTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.JuegosBtnTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.JuegosBtnTable.Size = New System.Drawing.Size(676, 70)
        Me.JuegosBtnTable.TabIndex = 0
        '
        'BtnBetcha
        '
        Me.BtnBetcha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnBetcha.Enabled = False
        Me.BtnBetcha.Location = New System.Drawing.Point(341, 3)
        Me.BtnBetcha.Name = "BtnBetcha"
        Me.BtnBetcha.Size = New System.Drawing.Size(332, 64)
        Me.BtnBetcha.TabIndex = 1
        Me.BtnBetcha.Text = "Betcha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Probabilidad"
        Me.BtnBetcha.UseVisualStyleBackColor = True
        '
        'BtnPredixis
        '
        Me.BtnPredixis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPredixis.Enabled = False
        Me.BtnPredixis.Location = New System.Drawing.Point(3, 3)
        Me.BtnPredixis.Name = "BtnPredixis"
        Me.BtnPredixis.Size = New System.Drawing.Size(332, 64)
        Me.BtnPredixis.TabIndex = 0
        Me.BtnPredixis.Text = "Predixis" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Adivina el número"
        Me.BtnPredixis.UseVisualStyleBackColor = True
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
        Me.NameLabel.Text = "Juegos"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseBtn})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 156)
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
        'Juegos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 176)
        Me.Controls.Add(Me.JuegosBody)
        Me.Name = "Juegos"
        Me.Text = "Juegos - Episteme"
        Me.JuegosBody.ResumeLayout(False)
        Me.JuegosBody.PerformLayout()
        Me.JuegosBtnTable.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents JuegosBody As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents JuegosBtnTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnPredixis As System.Windows.Forms.Button
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents BtnBetcha As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents CloseBtn As System.Windows.Forms.ToolStripDropDownButton
End Class
