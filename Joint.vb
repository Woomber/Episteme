Public Class Joint

    Dim j() As Integer = {0, 0}
    Dim AA As String
    Dim AB As String
    Dim AU As String
    Dim CA() As String
    Dim CB() As String
    Dim CU() As String

    Private Sub AgregarA_Click(sender As Object, e As EventArgs) Handles AgregarA.Click
        If AddA.Text <> "" Then
            AA = AddA.Text
            'A.Items.Add(AA)
            j(0) = 0
            j(1) = 0
            For i = 0 To (A.Items.Count - 1)
                If CStr(A.Items.Item(i)) = CStr(AA) Then
                    j(0) -= 1
                Else
                    j(0) += 1
                End If
            Next
            If j(0) - A.Items.Count = 0 Then
                A.Items.Add(AA)
            End If
            For i = 0 To (U.Items.Count - 1)
                If CStr(U.Items.Item(i)) = CStr(AA) Then
                    j(1) -= 1
                Else
                    j(1) += 1
                End If
            Next
            If j(1) - U.Items.Count = 0 Then
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
            'B.Items.Add(AB)
            j(0) = 0
            j(1) = 0
            For i = 0 To (B.Items.Count - 1)
                If CStr(B.Items.Item(i)) = CStr(AB) Then
                    j(0) -= 1
                Else
                    j(0) += 1
                End If
            Next
            If j(0) - B.Items.Count = 0 Then
                B.Items.Add(AB)
            End If
            For i = 0 To (U.Items.Count - 1)
                If CStr(U.Items.Item(i)) = CStr(AB) Then
                    j(1) -= 1
                Else
                    j(1) += 1
                End If
            Next
            If j(1) - U.Items.Count = 0 Then
                U.Items.Add(AB)
            End If
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

    Private Sub AgregarU_Click(sender As Object, e As EventArgs) Handles AgregarU.Click
        If AddU.Text <> "" Then
            AU = AddU.Text
            'U.Items.Add(AU)
            j(0) = 0
            j(1) = 0
            For i = 0 To (U.Items.Count - 1)
                If CStr(U.Items.Item(i)) = CStr(AU) Then
                    j(1) -= 1
                Else
                    j(1) += 1
                End If
            Next
            If j(1) - U.Items.Count = 0 Then
                U.Items.Add(AU)
            End If
        Else
            MsgBox("Por favor ponga un elemento a agregar.")
        End If
    End Sub
End Class