Public Class Quimica
    'Una GUI para acceder a los programas de química
    Private Sub BtnChemDoc_Click(sender As Object, e As EventArgs) Handles BtnChemDoc.Click
        Auth.Show()
        'ChemDoc.Show()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

End Class