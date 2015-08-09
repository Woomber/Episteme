Public Class IsPrime
    Dim number As Integer
    Dim prime As Boolean = True
    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click
        Isit.Text = ""
        OutList.Items.Clear()
        prime = True
        Try
            number = Input.Text
            If number < 2 Then
                MsgBox("Por definición, un número primo tiene que ser mayor que uno.", MsgBoxStyle.OkOnly, "Error")
            Else
                For i = 1 To number Step 1
                    If number Mod i = 0 Then
                        OutList.Items.Add(i)
                        If Not (i = 1 Or i = number) Then
                            prime = False
                        End If
                    End If
                Next
                If prime Then
                    Isit.Text = "Sí es primo"
                Else
                    Isit.Text = "No es primo"
                End If
            End If
        Catch ex As Exception
            MsgBox("No se ha introducido un entero válido.", MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
End Class