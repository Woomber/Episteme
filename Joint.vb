Public Class Joint

    Dim j As Integer = 0
    Dim AA As String
    Dim AB As String
    Dim AU As String
    Dim CA() As String
    Dim CB() As String
    Dim CU() As String

    Private Sub AgregarA_Click(sender As Object, e As EventArgs) Handles AgregarA.Click
        If AddA.Text <> "" Then
            AA = AddA.Text
            A.Items.Add(AA)
            For i = 0 To (U.Items.Count - 1)
                If CStr(U.Items.Item(i)) = CStr(AA) Then
                    j -= 1
                Else
                    j += 1
                End If
            Next
            If j - U.Items.Count = 0 Then
                U.Items.Add(AA)
            End If
        Else
            MsgBox("Por favor ponga un elemento a agregar.")
        End If
    End Sub

    Private Sub EliminarA_Click(sender As Object, e As EventArgs) Handles EliminarA.Click
        Try
            A.Items.Remove(A.SelectedItem)
        Catch ex As Exception
            MsgBox("Por favor seleccione un elemnto a eliminar.")
        End Try
    End Sub

    Private Sub EditarA_Click(sender As Object, e As EventArgs) Handles EditarA.Click
        'If AddA.Text <> "" Then
        'A.Items.Item(A.SelectedIndex) = AddB.Text
        'Else
        ' MsgBox("Por favor ponga el elemento por el que se reemplazará.")
        ' End If
    End Sub

    Private Sub AgregarB_Click(sender As Object, e As EventArgs) Handles AgregarB.Click
        If AddB.Text <> "" Then
            AB = AddB.Text
            B.Items.Add(AB)
            U.Items.Add(AB)
        Else
            MsgBox("Por favor ponga un elemento a agregar.")
        End If
    End Sub

    Private Sub EliminarB_Click(sender As Object, e As EventArgs) Handles EliminarB.Click
        Try
            B.Items.Remove(B.SelectedItem)
        Catch ex As Exception
            MsgBox("Por favor seleccione un elemento a eliminar.")
        End Try
    End Sub

    Private Sub EditarB_Click(sender As Object, e As EventArgs) Handles EditarB.Click
        'If AddB.Text <> "" Then
        'B.Items.Item(B.SelectedItem) = AddB.Text
        ' Else
        ' MsgBox("Por favor ponga el elemento por el que se reemplazará.")
        ' End If
    End Sub

End Class