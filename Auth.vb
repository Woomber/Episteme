Public Class Auth

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.LogAuth + "B" And NumericUpDown1.Value = 66 Then
            ChemDoc.Show()
            Me.Hide()
        Else
            MsgBox("Error en las credenciales." & vbNewLine & "Acceso denegado", MsgBoxStyle.OkOnly, "Acceso denegado")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class