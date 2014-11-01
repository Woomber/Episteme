Public Class Quadratic
    Dim u As Double = 0
    Dim p() As Double = {0, 0}
    Dim ra As Double = 0
    Dim rb As Double = 0
    Dim rc As Double = 0
    Dim f() As Double = {0, 0, 0}
    Dim gen As Integer = 0
    Dim rn1 As Integer = 0
    Dim rn2 As Integer = 9

    Private Sub Quadratic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Rango1.Value = My.Settings.QadraticMin
        rn1 = My.Settings.QadraticMin
        Rango2.Value = My.Settings.QadraticMax
        rn2 = My.Settings.QadraticMax

    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

   
    Private Sub Calc_Click(sender As Object, e As EventArgs) Handles Calc.Click
        '(0.5u)x^2+(p-1.5u)x+(m-p+u)
        'u=diferencia segunda
        'p=diferencia primera (en n = 1)
        'm=número 'r' de la sucesión (en n = 1)
        Try
            ra = R1.Text
            rb = R2.Text
            rc = R3.Text
            p(0) = rb - ra
            p(1) = rc - rb
            u = p(1) - p(0)
            f(0) = u / 2
            f(1) = p(0) - (1.5 * u)
            f(2) = ra - p(0) + u
            'MsgBox(f(0) & vbNewLine & f(1) & vbNewLine & f(2))  'Para pruebas
            PrintFormula()
        Catch ex As Exception
            MsgBox("Error 0x01 en '" & R1.Text & ", " & R2.Text & ", " & R3.Text & "'." & vbNewLine & "Se esperaban cantidades numéricas.")

        End Try
    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Print.Click
        ListBox1.Items.Add("----------------------")
        ListBox1.Items.Add("Función: " & Formula.Text)
        Try
            For i = rn1 To rn2
                ListBox1.Items.Add("x = " & i & "   | y= " & f(0) * (i ^ 2) + f(1) * i + f(2))
            Next
        Catch ex As Exception
            MsgBox("Error 0x04 imprevisto." & vbNewLine & "No se esperaba este error. Por favor inténtelo de nuevo." & vbNewLine & "Si el problema persiste contacte al autor.")
        End Try
        gen += (rn2 - rn1) + 1
        StatusLabel.Text = "Preparado | Generado(s) " & gen & " elemento(s)"
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        gen = 0
        StatusLabel.Text = "Preparado"
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Qadratic")
        ListBox1.Items.Add("Copyright © 2014")
        ListBox1.Items.Add("Yael Arturo Chavoya Andalón")
    End Sub

    Private Sub CalcF_Click(sender As Object, e As EventArgs) Handles CalcF.Click
        Try
            If ax.Text = "" Then
                f(0) = 0
            Else
                f(0) = ax.Text
            End If
            If bx.Text = "" Then
                f(1) = 0
            Else
                f(1) = bx.Text
            End If
            If cx.Text = "" Then
                f(2) = 0
            Else
                f(2) = cx.Text
            End If
            ra = (f(0) * (1 ^ 2) + f(1) * 1 + f(2))
            rb = (f(0) * (2 ^ 2) + f(1) * 2 + f(2))
            rc = (f(0) * (3 ^ 2) + f(1) * 3 + f(2))
            p(0) = rb - ra
            p(1) = rc - rb
            u = p(1) - p(0)
            PrintFormula()
        Catch ex As Exception
            MsgBox("Error 0x03 en '" & ax.Text & ", " & bx.Text & ", " & cx.Text & "'." & vbNewLine & "Se esperaban cantidades numéricas.")
        End Try
        
    End Sub
	
    Public Sub PrintFormula()
        Formula.Text = ""
        If f(0) = 0 Then

        ElseIf f(0) = 1 Then
            Formula.Text = "x^2"

        ElseIf f(0) = -1 Then
            Formula.Text = "-x^2"
        Else
            Formula.Text = f(0) & "x^2"
        End If
        If f(1) = 0 Then

        ElseIf f(1) = 1 Then
            If f(0) = 0 Then
                Formula.Text += "x"
            Else
                Formula.Text += " + x"
            End If
        ElseIf f(1) = -1 Then
            Formula.Text += " - x"
        Else
            If f(1) < 0 Then
                Dim fpa As Double = f(1) * -1
                Formula.Text += " - " & fpa & "x"
            Else
                If f(0) = 0 Then
                    Formula.Text += f(1) & "x"
                Else
                    Formula.Text += " + " & f(1) & "x"
                End If
            End If
        End If
        If f(2) = 0 Then
            If f(1) = 0 And f(0) = 0 Then
                Formula.Text += "0"
            End If
        Else
            If f(2) < 0 Then
                Dim fpb As Double = f(2) * -1
                Formula.Text += " - " & fpb
            Else
                If f(0) = 0 And f(1) = 0 Then
                    Formula.Text = f(2)
                Else
                    Formula.Text += " + " & f(2)
                End If
            End If
        End If
        Formula.Visible = True
        Dif1.Visible = True
        Dif2.Visible = True
        If p(0) = p(1) Then
            Dif1.Text = p(0)
        Else
            Dif1.Text = p(0) & ", " & p(1) & ", " & p(1) + u & "..."
        End If
        Dif2.Text = u
        Print.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If Rango1.Value <= Rango2.Value Then
                rn1 = Rango1.Value
                My.Settings.QadraticMin = rn1
                rn2 = Rango2.Value
                My.Settings.QadraticMax = rn2
                Label15.Text = "Guardado " & Format$(Now, "hh:mm:ss") & "."
                Label15.Visible = True
            Else
                MsgBox("Error 0x06 en '" & Rango1.Text & ", " & Rango2.Text & "'." & vbNewLine & Rango1.Text & " es mayor que " & Rango2.Text & ".")
            End If
        Catch ex As Exception
            MsgBox("Error 0x05 en '" & rn1 & ", " & rn2 & "'." & vbNewLine & "Se esperaba un rango de enteros válido.")
        End Try
    End Sub

    Private Sub Rango2_ValueChanged(sender As Object, e As EventArgs) Handles Rango2.ValueChanged
        Label15.Visible = False
    End Sub

    Private Sub Rango1_ValueChanged(sender As Object, e As EventArgs) Handles Rango1.ValueChanged
        Label15.Visible = False
    End Sub

    Private Sub GuardarArchivoDeImpresiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarArchivoDeImpresiónToolStripMenuItem.Click
        Try

            Dim fecha As String
            fecha = Format$(Now, "yyyy-mm-dd hh-mm-ss")
            Guardado.FileName = "Qadratic " & fecha & ".eplog"
            Guardado.ShowDialog()
            Dim FILE_NAME As String = Guardado.FileName

            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            Dim i As Integer
            For i = 0 To ListBox1.Items.Count - 1
                objWriter.WriteLine(ListBox1.Items.Item(i))
            Next
            objWriter.Close()
            MsgBox("Guardado con éxito." & vbNewLine & "Archivo: " & FILE_NAME & vbNewLine)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error." & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub Custom1_Click(sender As Object, e As EventArgs) Handles Custom1.Click
        TabPage1.BackColor = Color.Transparent
        TabPage2.BackColor = Color.Transparent
        TabPage1.ForeColor = Color.Black
        TabPage2.ForeColor = Color.Black
        Calc.BackColor = Color.Transparent
        Print.BackColor = Color.Transparent
        CalcF.BackColor = Color.Transparent
        Custom1.Enabled = False
        Custom2.Enabled = True
    End Sub

    Private Sub Custom2_Click(sender As Object, e As EventArgs) Handles Custom2.Click
        TabPage1.BackColor = Color.Black
        TabPage2.BackColor = Color.Black
        TabPage1.ForeColor = Color.White
        TabPage2.ForeColor = Color.White
        Calc.BackColor = Color.DarkSlateGray
        Print.BackColor = Color.DarkSlateGray
        CalcF.BackColor = Color.DarkSlateGray
        Custom2.Enabled = False
        Custom1.Enabled = True
    End Sub


End Class
