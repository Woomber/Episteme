Public Class Numeros
    'Una GUI para acceder a los programas de números
    Private Sub BtnBrokeN_Click(sender As Object, e As EventArgs) Handles BtnBrokeN.Click

    End Sub

    Private Sub BtnRND_Click(sender As Object, e As EventArgs) Handles BtnRND.Click
        RNDGen.Show()
    End Sub

    Private Sub BtnIsPrime_Click(sender As Object, e As EventArgs) Handles BtnIsPrime.Click
        IsPrime.Show()
    End Sub

    Private Sub BtnLog_Click(sender As Object, e As EventArgs) Handles BtnLog.Click

    End Sub

    Private Sub BtnRassop_Click(sender As Object, e As EventArgs) Handles BtnRassop.Click

    End Sub

    Private Sub BtnDoubleM_Click(sender As Object, e As EventArgs) Handles BtnDoubleM.Click

    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

End Class