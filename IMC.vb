Public Class IMC
    Dim IMC As Double = 0
    Dim altura As Double = 0
    Dim peso As Double = 0
    Dim altsq As Double = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Try
            altura = HeightP.Text
            peso = Weight.Text
            altsq = altura ^ 2
            IMC = peso / altsq
            RESULTA.Text = "Con " & altura & " metros y " & peso & " kg," & vbNewLine & "su IMC es de: " & IMC
            'MsgBox("Su IMC es de: " & IMC & "." & vbNewLine & "Programa creado por Yael Arturo Chavoya Andalón.")
        Catch ex As Exception
            MsgBox("Ha ocurrido un error, por favor coloque cantidades numéricas.")
        End Try

    End Sub
End Class
