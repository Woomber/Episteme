Imports System.Deployment.Application

Public Class StartUI

    Private Sub Algebra_Launch_Click(sender As Object, e As EventArgs) Handles Algebra_Launch.Click
        Algebra.Show()
    End Sub

    Private Sub Geometria_Launch_Click(sender As Object, e As EventArgs) Handles Geometria_Launch.Click
        Geometria.Show()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Misc_Launch_Click(sender As Object, e As EventArgs) Handles Misc_Launch.Click
        Misc.Show()
    End Sub

    Private Sub StartUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VersiónToolStripMenuItem.Text = "Versión: " & CStr(ProductVersion)
        ChangeValues()
    End Sub

    Public Sub ChangeValues()
        If My.Settings.HombreOMujer Then
            If My.Settings.Name = "" Or My.Settings.Name = " " Then
                Bienvenido.Text = "Bienvenido"
            Else
                Bienvenido.Text = "Bienvenido, " & My.Settings.Name
            End If
        Else
            If My.Settings.Name = "" Or My.Settings.Name = " " Then
                Bienvenido.Text = "Bienvenida"
            Else
                Bienvenido.Text = "Bienvenida, " & My.Settings.Name
            End If
        End If
    End Sub

    Private Sub InstallUpdateSyncWithInfo()
        Dim info As UpdateCheckInfo = Nothing

        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

            Try
                info = AD.CheckForDetailedUpdate()
            Catch dde As DeploymentDownloadException
                MessageBox.Show("La actualización no se puede descargar por el momento. " + _
                                ControlChars.Lf & ControlChars.Lf & "Por favor revise su conexión a internet," & _
                                " o inténtelo más tarde. Error: " + dde.Message)
                Return
            Catch ioe As InvalidOperationException
                MessageBox.Show("Esta aplicación no puede ser actualizada. Posiblemente no sea una aplicación ClickOnce." _
                                & " Error: " & ioe.Message)
                Return
            End Try

            If (info.UpdateAvailable) Then
                Dim doUpdate As Boolean = True

                If (Not info.IsUpdateRequired) Then
                    Dim dr As DialogResult = MessageBox.Show("Hay una actualización disponible." & _
                                                             " ¿Le gustaría actualizar la aplicación ahora?", _
                                                             "Actualización encontrada", MessageBoxButtons.OKCancel)
                    If (Not System.Windows.Forms.DialogResult.OK = dr) Then
                        doUpdate = False
                    End If
                Else
                    ' Display a message that the app MUST reboot. Display the minimum required version.
                    MessageBox.Show("Se ha detectado una apliación obligatoria " & _
                        "a la versión " & info.MinimumRequiredVersion.ToString() & _
                        ". Se instalará la actualización y se reiniciará la aplicación.", _
                        "Actualización obligatoria encontrada", MessageBoxButtons.OK, _
                        MessageBoxIcon.Information)
                End If

                If (doUpdate) Then
                    Try
                        AD.Update()
                        MessageBox.Show("La aplicación se ha actualizado, ahora se reiniciará.")
                        Application.Restart()
                    Catch dde As DeploymentDownloadException
                        MessageBox.Show("No se pudo instalar la última versión. " & ControlChars.Lf & ControlChars.Lf & _
                                        "Por favor revise su conexión a internet, o inténtelo más tarde.")
                        Return
                    End Try
                End If
            Else
                MessageBox.Show("No hay actualizaciones disponibles. Estás al día.", "Actualización", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub BuscarActualizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarActualizacionesToolStripMenuItem.Click
        InstallUpdateSyncWithInfo()
    End Sub

    Private Sub Juegos_Launch_Click(sender As Object, e As EventArgs) Handles Juegos_Launch.Click
        Juegos.Show()
    End Sub

    Private Sub Diario_Launch_Click(sender As Object, e As EventArgs) Handles Diario_Launch.Click
        Diario.Show()
    End Sub

    Private Sub Electro_Launch_Click(sender As Object, e As EventArgs) Handles Electro_Launch.Click
        Electro.Show()
    End Sub

    Private Sub AbrirArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirArchivoToolStripMenuItem.Click
        Editor.Show()
    End Sub

    Private Sub AcercaDeEpistemeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeEpistemeToolStripMenuItem.Click
        AcercaDe.Show()
    End Sub

    Private Sub PreferenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreferenciasToolStripMenuItem.Click
        Preferencias.Show()
    End Sub

    Private Sub SitioWebToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SitioWebToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://woomber.github.io/Episteme")
    End Sub

    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/Woomber/Episteme/releases")
    End Sub

    Private Sub ChemDoc_Launch_Click(sender As Object, e As EventArgs) Handles ChemDoc_Launch.Click
        Quimica.Show()
    End Sub

    Private Sub Numeros_Launch_Click(sender As Object, e As EventArgs) Handles Numeros_Launch.Click
        Numeros.Show()
    End Sub

    Private Sub ReportarErrorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportarErrorToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/Woomber/Episteme/issues")
    End Sub
End Class
