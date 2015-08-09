<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preferencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Preferencias))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Hombre = New System.Windows.Forms.RadioButton()
        Me.Mujer = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(12, 25)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(105, 20)
        Me.Nombre.TabIndex = 1
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(12, 97)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(105, 23)
        Me.Guardar.TabIndex = 2
        Me.Guardar.Text = "Guardar y cerrar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Hombre
        '
        Me.Hombre.AutoSize = True
        Me.Hombre.Location = New System.Drawing.Point(12, 51)
        Me.Hombre.Name = "Hombre"
        Me.Hombre.Size = New System.Drawing.Size(62, 17)
        Me.Hombre.TabIndex = 3
        Me.Hombre.TabStop = True
        Me.Hombre.Text = "Hombre"
        Me.Hombre.UseVisualStyleBackColor = True
        '
        'Mujer
        '
        Me.Mujer.AutoSize = True
        Me.Mujer.Location = New System.Drawing.Point(12, 74)
        Me.Mujer.Name = "Mujer"
        Me.Mujer.Size = New System.Drawing.Size(51, 17)
        Me.Mujer.TabIndex = 4
        Me.Mujer.TabStop = True
        Me.Mujer.Text = "Mujer"
        Me.Mujer.UseVisualStyleBackColor = True
        '
        'Preferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(129, 132)
        Me.Controls.Add(Me.Mujer)
        Me.Controls.Add(Me.Hombre)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Preferencias"
        Me.Text = "Preferencias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Hombre As System.Windows.Forms.RadioButton
    Friend WithEvents Mujer As System.Windows.Forms.RadioButton
End Class
