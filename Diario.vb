Public Class Diario
    'Una GUI para acceder a los programas de uso diario
    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click

    End Sub

    Private Sub BtnEplog_Click(sender As Object, e As EventArgs) Handles BtnEplog.Click
        Editor.Show()
    End Sub
    Private Sub BtnFusion_Click(sender As Object, e As EventArgs) Handles BtnFusion.Click

    End Sub

    Private Sub BtnIMC_Click(sender As Object, e As EventArgs) Handles BtnIMC.Click
        IMC.Show()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

End Class