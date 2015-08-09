<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Numeros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Numeros))
        Me.NumerosBody = New System.Windows.Forms.TableLayoutPanel()
        Me.NumerosBtnTable = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnDoubleM = New System.Windows.Forms.Button()
        Me.BtnRassop = New System.Windows.Forms.Button()
        Me.BtnLog = New System.Windows.Forms.Button()
        Me.BtnIsPrime = New System.Windows.Forms.Button()
        Me.BtnRND = New System.Windows.Forms.Button()
        Me.BtnBrokeN = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.CloseBtn = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NumerosBody.SuspendLayout()
        Me.NumerosBtnTable.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumerosBody
        '
        Me.NumerosBody.ColumnCount = 1
        Me.NumerosBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.NumerosBody.Controls.Add(Me.NumerosBtnTable, 0, 1)
        Me.NumerosBody.Controls.Add(Me.NameLabel, 0, 0)
        Me.NumerosBody.Controls.Add(Me.StatusStrip1, 0, 2)
        Me.NumerosBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumerosBody.Location = New System.Drawing.Point(0, 0)
        Me.NumerosBody.Name = "NumerosBody"
        Me.NumerosBody.RowCount = 3
        Me.NumerosBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.NumerosBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.NumerosBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.NumerosBody.Size = New System.Drawing.Size(682, 240)
        Me.NumerosBody.TabIndex = 0
        '
        'NumerosBtnTable
        '
        Me.NumerosBtnTable.ColumnCount = 3
        Me.NumerosBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.NumerosBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.NumerosBtnTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.NumerosBtnTable.Controls.Add(Me.BtnDoubleM, 0, 1)
        Me.NumerosBtnTable.Controls.Add(Me.BtnRassop, 0, 1)
        Me.NumerosBtnTable.Controls.Add(Me.BtnLog, 0, 1)
        Me.NumerosBtnTable.Controls.Add(Me.BtnIsPrime, 2, 0)
        Me.NumerosBtnTable.Controls.Add(Me.BtnRND, 1, 0)
        Me.NumerosBtnTable.Controls.Add(Me.BtnBrokeN, 0, 0)
        Me.NumerosBtnTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumerosBtnTable.Location = New System.Drawing.Point(3, 83)
        Me.NumerosBtnTable.Name = "NumerosBtnTable"
        Me.NumerosBtnTable.RowCount = 2
        Me.NumerosBtnTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.NumerosBtnTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.NumerosBtnTable.Size = New System.Drawing.Size(676, 134)
        Me.NumerosBtnTable.TabIndex = 0
        '
        'BtnDoubleM
        '
        Me.BtnDoubleM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnDoubleM.Enabled = False
        Me.BtnDoubleM.Location = New System.Drawing.Point(3, 70)
        Me.BtnDoubleM.Name = "BtnDoubleM"
        Me.BtnDoubleM.Size = New System.Drawing.Size(219, 61)
        Me.BtnDoubleM.TabIndex = 6
        Me.BtnDoubleM.Text = "DoubleM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MCM y MCD"
        Me.BtnDoubleM.UseVisualStyleBackColor = True
        '
        'BtnRassop
        '
        Me.BtnRassop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRassop.Enabled = False
        Me.BtnRassop.Location = New System.Drawing.Point(228, 70)
        Me.BtnRassop.Name = "BtnRassop"
        Me.BtnRassop.Size = New System.Drawing.Size(219, 61)
        Me.BtnRassop.TabIndex = 5
        Me.BtnRassop.Text = "Rassop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proporciones (regla de 3)"
        Me.BtnRassop.UseVisualStyleBackColor = True
        '
        'BtnLog
        '
        Me.BtnLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnLog.Enabled = False
        Me.BtnLog.Location = New System.Drawing.Point(453, 70)
        Me.BtnLog.Name = "BtnLog"
        Me.BtnLog.Size = New System.Drawing.Size(220, 61)
        Me.BtnLog.TabIndex = 4
        Me.BtnLog.Text = "Log" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Logaritmos"
        Me.BtnLog.UseVisualStyleBackColor = True
        '
        'BtnIsPrime
        '
        Me.BtnIsPrime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnIsPrime.Location = New System.Drawing.Point(453, 3)
        Me.BtnIsPrime.Name = "BtnIsPrime"
        Me.BtnIsPrime.Size = New System.Drawing.Size(220, 61)
        Me.BtnIsPrime.TabIndex = 3
        Me.BtnIsPrime.Text = "IsPrime" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Números primos"
        Me.BtnIsPrime.UseVisualStyleBackColor = True
        '
        'BtnRND
        '
        Me.BtnRND.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRND.Location = New System.Drawing.Point(228, 3)
        Me.BtnRND.Name = "BtnRND"
        Me.BtnRND.Size = New System.Drawing.Size(219, 61)
        Me.BtnRND.TabIndex = 1
        Me.BtnRND.Text = "RND" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Generador de números aleatorios"
        Me.BtnRND.UseVisualStyleBackColor = True
        '
        'BtnBrokeN
        '
        Me.BtnBrokeN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnBrokeN.Enabled = False
        Me.BtnBrokeN.Location = New System.Drawing.Point(3, 3)
        Me.BtnBrokeN.Name = "BtnBrokeN"
        Me.BtnBrokeN.Size = New System.Drawing.Size(219, 61)
        Me.BtnBrokeN.TabIndex = 0
        Me.BtnBrokeN.Text = "BrokeN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Números fraccionarios"
        Me.BtnBrokeN.UseVisualStyleBackColor = True
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
        Me.NameLabel.Text = "Números"
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
        'Numeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 240)
        Me.Controls.Add(Me.NumerosBody)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Numeros"
        Me.Text = "Números - Episteme"
        Me.NumerosBody.ResumeLayout(False)
        Me.NumerosBody.PerformLayout()
        Me.NumerosBtnTable.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NumerosBody As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NumerosBtnTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnBrokeN As System.Windows.Forms.Button
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents BtnIsPrime As System.Windows.Forms.Button
    Friend WithEvents BtnRND As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents CloseBtn As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents BtnDoubleM As System.Windows.Forms.Button
    Friend WithEvents BtnRassop As System.Windows.Forms.Button
    Friend WithEvents BtnLog As System.Windows.Forms.Button
End Class
