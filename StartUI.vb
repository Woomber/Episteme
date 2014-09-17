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
End Class
