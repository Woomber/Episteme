Public Class Calc
    Dim resultado As Decimal = 0
    Dim cache1 As Decimal = 0
    Dim cache2 As Decimal = 0
    Dim input As String = ""
    Dim currentOp As Integer = 0

    Dim UseRad As Boolean = False 'Radianes (v) o grados (f)
    Dim isDot As Boolean = False 'Verifica si ya se ha insertado un punto decimal
    Dim hasOP As Boolean = False 'Verifica si ya se ha realizado una operación anteriormente

    Private Sub clear(isAll As Boolean)
        If isAll = False Then
            DisplayBox.Text = resultado
        Else
            resultado = 0
            DisplayBox.Text = 0
        End If
        input = ""
        cache1 = 0
        currentOp = 0
        hasOP = False
        isDot = False
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GradosToolStripMenuItem.Click
        GradosToolStripMenuItem.Checked = True
        RadianesToolStripMenuItem.Checked = False
        UseRad = False
    End Sub

    Private Sub RadianesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RadianesToolStripMenuItem.Click
        RadianesToolStripMenuItem.Checked = True
        GradosToolStripMenuItem.Checked = False
        UseRad = True
    End Sub
    'Botones de números
    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        input += "0"
        displaybox.text = input
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        input += "1"
        displaybox.text = input
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        input += "2"
        displaybox.text = input
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        input += "3"
        displaybox.text = input
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        input += "4"
        displaybox.text = input
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        input += "5"
        displaybox.text = input
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        input += "6"
        displaybox.text = input
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        input += "7"
        displaybox.text = input
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        input += "8"
        displaybox.text = input
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        input += "9"
        displaybox.text = input
    End Sub

    Private Sub BtnDec_Click(sender As Object, e As EventArgs) Handles BtnDec.Click
        If isDot = False Then
            input += "."
            displaybox.text = input
            isDot = True
        End If
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        clear(True)
    End Sub

    Private Sub BtnCE_Click(sender As Object, e As EventArgs) Handles BtnCE.Click
        clear(False)
    End Sub

    'Botones de operaciones
    Private Sub BtnEquals_Click(sender As Object, e As EventArgs) Handles BtnEquals.Click
        If input IsNot "" Then
            cache1 = CDec(input)
            'input = ""
        End If

        Select Case currentOp
            Case 0
                If input = "" Then

                Else
                    resultado = cache1
                End If
            Case 1
                resultado += cache1
            Case 2
                resultado = resultado - cache1
            Case 3
                resultado = cache1 * resultado
            Case 4
                If Not (cache1 = 0) Then
                    resultado = resultado / cache1
                End If
        End Select
        If currentOp = 4 And cache1 = 0 Then
            DisplayBox.Text = "∞"
        Else
            DisplayBox.Text = resultado
        End If
        clear(False)
    End Sub


    Private Sub BtnSuma_Click(sender As Object, e As EventArgs) Handles BtnSuma.Click
        If input IsNot "" Then

            cache1 = CDec(input)
            If hasOP Then
                resultado = resultado + cache1
            Else
                resultado = cache1
            End If
            input = ""
        End If
        DisplayBox.Text = resultado & " +"
        currentOp = 1
        hasOP = True
        isDot = False
    End Sub

    Private Sub BtnRes_Click(sender As Object, e As EventArgs) Handles BtnRes.Click
        If input IsNot "" Then
            cache1 = CDec(input)
            If hasOP Then
                resultado = resultado - cache1
            Else
                resultado = cache1
            End If
            input = ""

        End If
        DisplayBox.Text = resultado & " -"
        hasOP = True
        currentOp = 2
        isDot = False
    End Sub

    Private Sub BtnDiv_Click(sender As Object, e As EventArgs) Handles BtnDiv.Click
        If input IsNot "" Then

            cache1 = CDec(input)
            If Not (cache1 = 0) Then
                If hasOP Then
                    resultado = resultado / cache1
                Else
                    resultado = cache1
                End If
            End If
            
            input = ""

        End If
        ' If cache1 = 0 Then
        ' DisplayBox.Text = "∞"
        'Else

        DisplayBox.Text = resultado & " ÷"
        ' End If
        hasOP = True
        currentOp = 4
        isDot = False
    End Sub

    Private Sub BtnMult_Click(sender As Object, e As EventArgs) Handles BtnMult.Click
        If input IsNot "" Then

            cache1 = CDec(input)
            If hasOP Then
                resultado = resultado * cache1
            Else
                resultado = cache1
            End If
            input = ""

        End If
        hasOP = True
        DisplayBox.Text = resultado & " ×"
        currentOp = 3
        isDot = False
    End Sub

End Class