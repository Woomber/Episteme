Public Class Juegos
    'Una GUI para acceder a los programas de juegos
    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnPredixis.Click

    End Sub

    Private Sub BtnEplog_Click(sender As Object, e As EventArgs) Handles BtnBetcha.Click
        Editor.Show()
    End Sub
    Private Sub BtnFusion_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnIMC_Click(sender As Object, e As EventArgs)
        IMC.Show()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

End Class