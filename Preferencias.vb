Public Class Preferencias

    Private Sub Preferencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nombre.Text = My.Settings.Name
        If My.Settings.HombreOMujer Then
            Hombre.Checked = True
        Else
            Mujer.Checked = True
        End If
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        My.Settings.Name = Nombre.Text
        If Hombre.Checked Then
            My.Settings.HombreOMujer = True
        Else
            My.Settings.HombreOMujer = False
        End If
        StartUI.ChangeValues()
        Me.Close()
    End Sub
End Class