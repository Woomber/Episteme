Public Class Editor
    Dim FILE_NAME As String = ""
    Dim editado As Boolean = False

    Private Sub Editor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing And editado Then
            If MsgBox("¿Seguro de que desea salir?" & vbNewLine & "Cualquier cambio sin guardar se perderá.", _
                   MsgBoxStyle.YesNo, "Editor") = Windows.Forms.DialogResult.Yes Then

                Me.Close()
            Else
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Abrir.Filter = "Todos los archivos|*.*|Archivo de texto|*.txt|Episteme log|*.eplog|HTML|*.htm,*.html"
        Guardar.Filter = Abrir.Filter
    End Sub

    Private Sub AbrirArchivo_Click(sender As Object, e As EventArgs) Handles AbrirArchivo.Click

        If editado Then
            If MsgBox("¿Seguro de que desea abrir un archivo?" & vbNewLine & "Cualquier cambio sin guardar se perderá.", _
                   MsgBoxStyle.YesNo, "Editor") = Windows.Forms.DialogResult.Yes Then
                CargarArchivo()

            End If
        Else
            CargarArchivo()
        End If

    End Sub
    Private Sub CargarArchivo()
        Try
            Abrir.ShowDialog()
            FILE_NAME = Abrir.FileName
            Dim objReader As New System.IO.StreamReader(FILE_NAME)
            AreaTexto.Text = objReader.ReadToEnd
            objReader.Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error." & vbNewLine & ex.Message)
        End Try

    End Sub

    Private Sub Guardando(Texto As String)
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
        objWriter.Write(Texto)
        objWriter.Close()
        MsgBox("Guardado con éxito." & vbNewLine & "Archivo: " & FILE_NAME & vbNewLine)
        editado = False
    End Sub

    Private Sub GuardarArchivo_Click(sender As Object, e As EventArgs) Handles GuardarArchivo.Click
        Try
            If FILE_NAME = "" Then
                Dim fecha As String
                fecha = Format$(Now, "yyyy-mm-dd hh-mm-ss")
                Guardar.FileName = fecha & ".txt"

                Guardar.ShowDialog()

                If Windows.Forms.DialogResult.OK Then
                    FILE_NAME = Guardar.FileName
                End If
            End If
            If Not FILE_NAME = "" Then
                Guardando(AreaTexto.Text)
            End If

        Catch ex As Exception
            MsgBox("Ha ocurrido un error." & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub GuardarComo_Click(sender As Object, e As EventArgs) Handles GuardarComo.Click
        Try
            Dim fecha As String
            fecha = Format$(Now, "yyyy-mm-dd hh-mm-ss")
            Guardar.FileName = fecha & ".txt"
            Guardar.ShowDialog()


            If Windows.Forms.DialogResult.OK Then
                FILE_NAME = Guardar.FileName
                Guardando(AreaTexto.Text)
            End If


        Catch ex As Exception
            MsgBox("Ha ocurrido un error." & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub CerrarEditor_Click(sender As Object, e As EventArgs) Handles CerrarEditor.Click
        If editado Then
            If MsgBox("¿Seguro de que desea salir?" & vbNewLine & "Cualquier cambio sin guardar se perderá.", _
                   MsgBoxStyle.YesNo, "Editor") = Windows.Forms.DialogResult.Yes Then

                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        If editado Then
            If MsgBox("¿Seguro de que desea crear un nuevo archivo?" & vbNewLine & "Cualquier cambio sin guardar se perderá.", _
                   MsgBoxStyle.YesNo, "Editor") = Windows.Forms.DialogResult.Yes Then
                AreaTexto.Text = ""
                editado = False
                FILE_NAME = ""
            End If
        Else
            AreaTexto.Text = ""
            editado = False
            FILE_NAME = ""
        End If
    End Sub

    Private Sub AreaTexto_TextChanged(sender As Object, e As EventArgs) Handles AreaTexto.TextChanged
        editado = True
    End Sub

    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        Clipboard.SetText(AreaTexto.SelectedText, TextDataFormat.UnicodeText)
        AreaTexto.SelectedText = ""
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        Clipboard.SetText(AreaTexto.SelectedText, TextDataFormat.UnicodeText)
    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        AreaTexto.SelectedText = Clipboard.GetText
    End Sub
End Class