Public Class Misc
    'Una GUI para acceder a los programas misceláneos
    Private Sub BtnJoint_Click(sender As Object, e As EventArgs) Handles BtnJoint.Click
        Joint.Show()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

End Class