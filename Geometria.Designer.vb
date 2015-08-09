<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Geometria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Geometria))
        Me.GeometriaBody = New System.Windows.Forms.TableLayoutPanel()
        Me.GeometriaBtnTable = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnStraight = New System.Windows.Forms.Button()
        Me.BtnPokkar = New System.Windows.Forms.Button()
        Me.BtnVektor = New System.Windows.Forms.Button()
        Me.BtnArpevol = New System.Windows.Forms.Button()
        Me.BtnTrigger = New System.Windows.Forms.Button()
        Me.BtnPithagorean = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.CloseBtn = New System.Windows.Forms.ToolStripDropDownButton()
        Me.GeometriaBody.SuspendLayout()
        Me.GeometriaBtnTable.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GeometriaBody
        '
        Me.GeometriaBody.ColumnCount = 1
        Me.GeometriaBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GeometriaBody.Controls.Add(Me.GeometriaBtnTable, 0, 1)
        Me.GeometriaBody.Controls.Add(Me.NameLabel, 0, 0)
        Me.GeometriaBody.Controls.Add(Me.StatusStrip1, 0, 2)
        Me.GeometriaBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GeometriaBody.Location = New System.Drawing.Point(0, 0)
        Me.GeometriaBody.Name = "GeometriaBody"
        Me.GeometriaBody.RowCount = 3
        Me.GeometriaBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.GeometriaBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GeometriaBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GeometriaBody.Size = New System.Drawing.Size(682, 240)
        Me.GeometriaBody.TabIndex = 0
        '
        'GeometriaBtnTable
        '
        Me.GeometriaBtnTable.ColumnCount = 3
        Me.GeometriaBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.GeometriaBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.GeometriaBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.GeometriaBtnTable.Controls.Add(Me.BtnStraight, 0, 1)
        Me.GeometriaBtnTable.Controls.Add(Me.BtnPokkar, 0, 1)
        Me.GeometriaBtnTable.Controls.Add(Me.BtnVektor, 0, 1)
        Me.GeometriaBtnTable.Controls.Add(Me.BtnArpevol, 2, 0)
        Me.GeometriaBtnTable.Controls.Add(Me.BtnTrigger, 1, 0)
        Me.GeometriaBtnTable.Controls.Add(Me.BtnPithagorean, 0, 0)
        Me.GeometriaBtnTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GeometriaBtnTable.Location = New System.Drawing.Point(3, 83)
        Me.GeometriaBtnTable.Name = "GeometriaBtnTable"
        Me.GeometriaBtnTable.RowCount = 2
        Me.GeometriaBtnTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.GeometriaBtnTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.GeometriaBtnTable.Size = New System.Drawing.Size(676, 134)
        Me.GeometriaBtnTable.TabIndex = 0
        '
        'BtnStraight
        '
        Me.BtnStraight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnStraight.Enabled = False
        Me.BtnStraight.Location = New System.Drawing.Point(3, 70)
        Me.BtnStraight.Name = "BtnStraight"
        Me.BtnStraight.Size = New System.Drawing.Size(219, 61)
        Me.BtnStraight.TabIndex = 6
        Me.BtnStraight.Text = "Straight" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ecuaciones de línea recta"
        Me.BtnStraight.UseVisualStyleBackColor = True
        '
        'BtnPokkar
        '
        Me.BtnPokkar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPokkar.Enabled = False
        Me.BtnPokkar.Location = New System.Drawing.Point(228, 70)
        Me.BtnPokkar.Name = "BtnPokkar"
        Me.BtnPokkar.Size = New System.Drawing.Size(219, 61)
        Me.BtnPokkar.TabIndex = 5
        Me.BtnPokkar.Text = "Pokkar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Conversor polar-cartesiano"
        Me.BtnPokkar.UseVisualStyleBackColor = True
        '
        'BtnVektor
        '
        Me.BtnVektor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnVektor.Location = New System.Drawing.Point(453, 70)
        Me.BtnVektor.Name = "BtnVektor"
        Me.BtnVektor.Size = New System.Drawing.Size(220, 61)
        Me.BtnVektor.TabIndex = 4
        Me.BtnVektor.Text = "Vektor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Suma y resta de vectores"
        Me.BtnVektor.UseVisualStyleBackColor = True
        '
        'BtnArpevol
        '
        Me.BtnArpevol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnArpevol.Enabled = False
        Me.BtnArpevol.Location = New System.Drawing.Point(453, 3)
        Me.BtnArpevol.Name = "BtnArpevol"
        Me.BtnArpevol.Size = New System.Drawing.Size(220, 61)
        Me.BtnArpevol.TabIndex = 3
        Me.BtnArpevol.Text = "Arpevol" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Áreas, perímetros y volúmenes"
        Me.BtnArpevol.UseVisualStyleBackColor = True
        '
        'BtnTrigger
        '
        Me.BtnTrigger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnTrigger.Enabled = False
        Me.BtnTrigger.Location = New System.Drawing.Point(228, 3)
        Me.BtnTrigger.Name = "BtnTrigger"
        Me.BtnTrigger.Size = New System.Drawing.Size(219, 61)
        Me.BtnTrigger.TabIndex = 1
        Me.BtnTrigger.Text = "Trigger" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trigonometría"
        Me.BtnTrigger.UseVisualStyleBackColor = True
        '
        'BtnPithagorean
        '
        Me.BtnPithagorean.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPithagorean.Enabled = False
        Me.BtnPithagorean.Location = New System.Drawing.Point(3, 3)
        Me.BtnPithagorean.Name = "BtnPithagorean"
        Me.BtnPithagorean.Size = New System.Drawing.Size(219, 61)
        Me.BtnPithagorean.TabIndex = 0
        Me.BtnPithagorean.Text = "Pithagorean" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Teorema de Pitágoras"
        Me.BtnPithagorean.UseVisualStyleBackColor = True
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
        Me.NameLabel.Text = "Geometría"
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
        'Geometria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 240)
        Me.Controls.Add(Me.GeometriaBody)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Geometria"
        Me.Text = "Geometría - Episteme"
        Me.GeometriaBody.ResumeLayout(False)
        Me.GeometriaBody.PerformLayout()
        Me.GeometriaBtnTable.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GeometriaBody As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GeometriaBtnTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnPithagorean As System.Windows.Forms.Button
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents BtnArpevol As System.Windows.Forms.Button
    Friend WithEvents BtnTrigger As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents CloseBtn As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents BtnStraight As System.Windows.Forms.Button
    Friend WithEvents BtnPokkar As System.Windows.Forms.Button
    Friend WithEvents BtnVektor As System.Windows.Forms.Button
End Class
