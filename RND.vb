Imports System
Imports System.IO
Imports System.Text
Public Class RNDGen
    Dim min As Integer = 1
    Dim max As Integer = 6
    Dim time As Integer = 10
    Dim random As Double = 0
    Dim array() As Object
    Private Sub RND_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        MinV.Value = min
        MaxV.Value = max
        Times.Value = time

    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Generar_Click(sender As Object, e As EventArgs) Handles Generar.Click
        min = MinV.Value
        max = MaxV.Value
        time = Times.Value

        Resultados.Items.Add("----------------------")

        For i = 1 To time Step 1
            Randomize()
            random = CInt(Math.Floor((max - min + 1) * RND())) + min 'Fórmula
            Resultados.Items.Add(random)
        Next
        Estado.Text = "Preparado | Generado(s) " & time & " elemento(s)"
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Try
            'ListBox1.Items.CopyTo(array, 0) primer intento
            Dim fecha As String
            fecha = Format$(Now, "yyyy-mm-dd hh-mm-ss")
            Guardado.FileName = "RND " & fecha & ".eplog"

            Guardado.ShowDialog()
            Dim FILE_NAME As String = Guardado.FileName
            'MsgBox(FILE_NAME) lo usé para depurar
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            Dim i As Integer
            For i = 0 To Resultados.Items.Count - 1 'Se requiere del -1 porque Items.Count cuenta desde 1 for desde 0
                objWriter.WriteLine(Resultados.Items.Item(i))
                'System.IO.File.AppendAllText(FILE_NAME, CStr(ListBox1.Items.Item(i)) & vbCrLf) también funcionaría (no probado)
            Next
            objWriter.Close()
            MsgBox("Guardado con éxito." & vbNewLine & "Archivo: " & FILE_NAME & vbNewLine)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error.")
        End Try
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        Estado.Text = "Preparado"
        Resultados.Items.Clear()
        Resultados.Items.Add("RND")
        Resultados.Items.Add("Copyright © 2014")
        Resultados.Items.Add("Yael Arturo Chavoya Andalón")
    End Sub

End Class
