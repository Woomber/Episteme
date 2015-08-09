Public Class Electro
    'Una GUI para acceder a los programas de electrónica
    Private Sub BtnResist_Click(sender As Object, e As EventArgs) Handles BtnResist.Click
        Resist.Show()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

End Class