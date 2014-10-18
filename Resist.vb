Public Class Resist

    Dim ResT As Double = 0
    Dim VolT As Double = 0
    Dim IntT As Double = 0
    Dim IsCalc As Boolean = False
    Dim ResTP As Double = 0
    Dim VolTP As Double = 0
    Dim IntTP As Double = 0
    Dim IsCalcP As Boolean = False

    Public Function Escala(n)
        'Convierte la unidad a la escala más cercana y devuelve una string con el prefijo

        Dim Name As String = 0
        If n < 1000000000000 And n >= 1000000000 Then
            Name = n / 10 ^ 9 & " G"
        ElseIf n < 1000000000 And n >= 1000000 Then
            Name = n / 10 ^ 6 & " M"
        ElseIf n < 1000000 And n >= 1000 Then
            Name = n / 10 ^ 3 & " k"
        ElseIf n < 1000 And n >= 1 Then
            Name = n & " "
        ElseIf n < 1 And n >= 0.001 Then
            Name = n * 10 ^ 3 & " m"
        ElseIf n < 0.001 And n >= 0.000001 Then
            Name = n * 10 ^ 6 & " μ"
        ElseIf n < 0.000001 Then
            Name = n * 10 ^ 9 & " n"
        End If

        Return Name

    End Function

    Private Sub AddRes_Click(sender As Object, e As EventArgs) Handles AddRes.Click
        IsCalc = False
        If Ohm.Checked Then
            OhmList.Items.Add(SelectRes.Value)
        ElseIf OhmMili.Checked Then
            OhmList.Items.Add(SelectRes.Value / 1000)
        ElseIf OhmKilo.Checked Then
            OhmList.Items.Add(SelectRes.Value * 1000)
        ElseIf OhmMega.Checked Then
            OhmList.Items.Add(SelectRes.Value * 1000000)
        End If

    End Sub

    Private Sub RemoveRes_Click(sender As Object, e As EventArgs) Handles RemoveRes.Click
        IsCalc = False
        OhmList.Items.Remove(OhmList.SelectedItem)
    End Sub

    Private Sub CalculaRes_Click(sender As Object, e As EventArgs) Handles CalculaRes.Click
        VolT = SelectVolt.Value
        VE.Text = "Tensión total: " & Escala(VolT) & " v"
        ResT = 0
        For i = 0 To (OhmList.Items.Count - 1)
            ResT += CDbl(OhmList.Items.Item(i))
        Next
        RT.Text = "Resistencia total: " & Escala(ResT) & "Ω"

        IntT = VolT / ResT
        IT.Text = "Corriente total: " & Escala(IntT) & "A"
        
        VoltList.Items.Clear()
        WattList.Items.Clear()

        Voltaje(OhmList, VoltList, ResT, VolT)
        Potencia(OhmList, WattList, ResT, VolT, IntT, True)

        IsCalc = True

    End Sub

    Public Sub Voltaje(listaohm, listavolt, resistencia, voltaje)
        For i = 0 To (listaohm.Items.Count - 1)
            listavolt.Items.Add((Escala(voltaje * CDbl(listaohm.Items.Item(i) / resistencia))) & " v")
        Next
    End Sub

    Public Sub Potencia(listaohm, listawatt, resistencia, voltaje, intensidad, SorP)
        If SorP Then
            For i = 0 To (listaohm.Items.Count - 1)
                listawatt.Items.Add(Escala(voltaje * intensidad * CDbl(listaohm.Items.Item(i)) / _
                                        resistencia) & "W")
            Next
        Else
            For i = 0 To (listaohm.Items.Count - 1)
                listawatt.Items.Add(Escala(voltaje ^ 2 / CDbl(listaohm.Items.Item(i))) & "W")
            Next
        End If
        
    End Sub

    Public Sub Intensidad(listaohm, listamper, voltaje)
        For i = 0 To (listaohm.items.count - 1)
            listamper.items.add((Escala(voltaje / listaohm.items.item(i)) & "A"))
        Next
    End Sub


    Private Sub OhmList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OhmList.SelectedIndexChanged
        If IsCalc Then
            VoltList.SelectedIndex = OhmList.SelectedIndex
            WattList.SelectedIndex = OhmList.SelectedIndex
        End If
    End Sub

    Private Sub VoltList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VoltList.SelectedIndexChanged
        If IsCalc Then
            OhmList.SelectedIndex = VoltList.SelectedIndex
            WattList.SelectedIndex = VoltList.SelectedIndex
        End If
    End Sub

    Private Sub WattList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WattList.SelectedIndexChanged
        If IsCalc Then
            OhmList.SelectedIndex = WattList.SelectedIndex
            VoltList.SelectedIndex = WattList.SelectedIndex
        End If
    End Sub

    Private Sub OhmListP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OhmListP.SelectedIndexChanged
        If IsCalc Then
            IntListP.SelectedIndex = OhmListP.SelectedIndex
            WattListP.SelectedIndex = OhmListP.SelectedIndex
        End If
    End Sub

    Private Sub IntListP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IntListP.SelectedIndexChanged
        If IsCalc Then
            OhmListP.SelectedIndex = IntListP.SelectedIndex
            WattListP.SelectedIndex = IntListP.SelectedIndex
        End If
    End Sub

    Private Sub WattListP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WattListP.SelectedIndexChanged
        If IsCalc Then
            OhmListP.SelectedIndex = WattListP.SelectedIndex
            IntListP.SelectedIndex = WattListP.SelectedIndex
        End If
    End Sub


    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddResP_Click(sender As Object, e As EventArgs) Handles AddResP.Click
        IsCalcP = False
        If OhmP.Checked Then
            OhmListP.Items.Add(SelectResP.Value)
        ElseIf OhmMiliP.Checked Then
            OhmListP.Items.Add(SelectResP.Value / 1000)
        ElseIf OhmKiloP.Checked Then
            OhmListP.Items.Add(SelectResP.Value * 1000)
        ElseIf OhmMegaP.Checked Then
            OhmListP.Items.Add(SelectResP.Value * 1000000)
        End If

    End Sub

    Private Sub RemoveResp_Click(sender As Object, e As EventArgs) Handles RemoveResP.Click
        IsCalcP = False
        OhmListP.Items.Remove(OhmListP.SelectedItem)
    End Sub

    Private Sub CalculaResP_Click(sender As Object, e As EventArgs) Handles CalculaResP.Click
        VoltP = SelectVoltP.Value
        VTP.Text = "Tensión total: " & Escala(VoltP) & "v"
        ResTP = 0

        For i = 0 To (OhmListP.Items.Count - 1)
            ResTP += CDbl(OhmListP.Items.Item(i) ^ (-1))
        Next

        ResTP = ResTP ^ -1

        RTP.Text = "Resistencia total: " & Escala(ResTP) & "Ω"

        IntTP = VoltP / ResTP
        ITP.Text = "Corriente total: " & Escala(IntTP) & "A"

        IntListP.Items.Clear()
        WattListP.Items.Clear()

        Intensidad(OhmListP, IntListP, VoltP)
        Potencia(OhmListP, WattListP, ResTP, VoltP, IntTP, False)

        IsCalcP = True

    End Sub


End Class