Public Class StartUI

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Quadratic.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Vektor.Show()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
