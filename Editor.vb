Public Class Editor
    Private Sub Editor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            If MsgBox("¿Seguro de que desea salir?" & vbNewLine & "Cualquier cambio sin guardar se perderá.", _
                   MsgBoxStyle.YesNo, "Editor") = Windows.Forms.DialogResult.Yes Then

                Me.Hide()
            Else
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Abrir.Filter = "Todos los archivos|*.*|Archivo de texto|*.txt|Episteme log|*.eplog|HTML|*.htm,*.html"
        Guardar.Filter = Abrir.Filter
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Abrir.ShowDialog()
            Dim FILE_NAME As String = Abrir.FileName
            Dim objReader As New System.IO.StreamReader(FILE_NAME)
            AreaTexto.Text = objReader.ReadToEnd
            objReader.Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error." & vbNewLine & ex.Message)
        End Try


    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            Dim fecha As String
            fecha = Format$(Now, "yyyy-mm-dd hh-mm-ss")
            Guardar.FileName = fecha & ".txt"

            Guardar.ShowDialog()

            Dim FILE_NAME As String = Guardar.FileName
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(AreaTexto.Text)
            objWriter.Close()
            MsgBox("Guardado con éxito." & vbNewLine & "Archivo: " & FILE_NAME & vbNewLine)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error." & vbNewLine & ex.Message)
        End Try
    End Sub
End Class