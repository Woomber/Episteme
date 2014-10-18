Imports System.Deployment.Application

Public Class StartUI

    Private Sub Qadratic_Launch_Click(sender As Object, e As EventArgs) Handles Qadratic_Launch.Click
        Quadratic.Show()
    End Sub

    Private Sub Vektor_Launch_Click(sender As Object, e As EventArgs) Handles Vektor_Launch.Click
        Vektor.Show()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Joint_Launch_Click(sender As Object, e As EventArgs) Handles Joint_Launch.Click
        Joint.Show()
    End Sub

    Private Sub StartUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VersiónToolStripMenuItem.Text = "Versión: " & CStr(ProductVersion)
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

    Private Sub RND_Launch_Click(sender As Object, e As EventArgs) Handles RND_Launch.Click
        RNDGen.Show()
    End Sub

    Private Sub IMC_Launch_Click(sender As Object, e As EventArgs) Handles IMC_Launch.Click
        IMC.Show()
    End Sub

    Private Sub Resist_Launch_Click(sender As Object, e As EventArgs) Handles Resist_Launch.Click
        Resist.Show()
    End Sub
End Class
