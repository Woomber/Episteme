<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents MainLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DetailsLayoutPanel As System.Windows.Forms.TableLayoutPanel

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MainLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.DetailsLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Description = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.Company = New System.Windows.Forms.Label()
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.MainLayoutPanel.SuspendLayout()
        Me.DetailsLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainLayoutPanel
        '
        Me.MainLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MainLayoutPanel.BackgroundImage = Global.Episteme.My.Resources.Resources.Brain
        Me.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MainLayoutPanel.ColumnCount = 2
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255.0!))
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.MainLayoutPanel.Controls.Add(Me.DetailsLayoutPanel, 1, 2)
        Me.MainLayoutPanel.Controls.Add(Me.ApplicationTitle, 1, 1)
        Me.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainLayoutPanel.Name = "MainLayoutPanel"
        Me.MainLayoutPanel.RowCount = 1
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.MainLayoutPanel.Size = New System.Drawing.Size(496, 262)
        Me.MainLayoutPanel.TabIndex = 0
        '
        'DetailsLayoutPanel
        '
        Me.DetailsLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.DetailsLayoutPanel.ColumnCount = 1
        Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247.0!))
        Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.DetailsLayoutPanel.Controls.Add(Me.Description, 0, 0)
        Me.DetailsLayoutPanel.Controls.Add(Me.Copyright, 0, 2)
        Me.DetailsLayoutPanel.Controls.Add(Me.Version, 0, 1)
        Me.DetailsLayoutPanel.Controls.Add(Me.Company, 0, 3)
        Me.DetailsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DetailsLayoutPanel.Location = New System.Drawing.Point(258, 175)
        Me.DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        Me.DetailsLayoutPanel.RowCount = 4
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DetailsLayoutPanel.Size = New System.Drawing.Size(235, 79)
        Me.DetailsLayoutPanel.TabIndex = 1
        '
        'Description
        '
        Me.Description.AutoSize = True
        Me.Description.Dock = System.Windows.Forms.DockStyle.Top
        Me.Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Description.Location = New System.Drawing.Point(3, 0)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(241, 15)
        Me.Description.TabIndex = 3
        Me.Description.Text = "Description"
        '
        'Copyright
        '
        Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.Location = New System.Drawing.Point(3, 38)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(241, 20)
        Me.Copyright.TabIndex = 2
        Me.Copyright.Text = "Copyright"
        '
        'Version
        '
        Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(3, 19)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(241, 19)
        Me.Version.TabIndex = 1
        Me.Version.Text = "Versión {0}.{1:00}.{2}.{3:00}"
        '
        'Company
        '
        Me.Company.AutoSize = True
        Me.Company.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Company.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Company.Location = New System.Drawing.Point(3, 58)
        Me.Company.Name = "Company"
        Me.Company.Size = New System.Drawing.Size(241, 21)
        Me.Company.TabIndex = 2
        Me.Company.Text = "Company"
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.ApplicationTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.Location = New System.Drawing.Point(258, 128)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(235, 42)
        Me.ApplicationTitle.TabIndex = 0
        Me.ApplicationTitle.Text = "Episteme"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Splash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MainLayoutPanel.ResumeLayout(False)
        Me.DetailsLayoutPanel.ResumeLayout(False)
        Me.DetailsLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Description As System.Windows.Forms.Label
    Friend WithEvents Company As System.Windows.Forms.Label

End Class
