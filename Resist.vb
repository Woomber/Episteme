Public Class Resist

    Dim ResT As Double = 0
    Dim VolT As Double = 0
    Dim IntT As Double = 0
    Dim IsCalc As Boolean = False
    Dim PotT As Double = 0

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
        VE.Text = "Tensión total: " & VolT & " v"
        ResT = 0
        For i = 0 To (OhmList.Items.Count - 1)
            ResT += CDbl(OhmList.Items.Item(i))
        Next

        If ResT < 1000 And ResT >= 1 Then
            RT.Text = "Resistencia total: " & ResT & " Ω"
        ElseIf ResT >= 1000 And ResT < 1000000 Then
            RT.Text = "Resistencia total: " & (ResT / 1000) & " kΩ"
        ElseIf ResT >= 1000000 Then
            RT.Text = "Resistencia total: " & (ResT / 1000000) & " MΩ"
        ElseIf ResT < 1 Then
            RT.Text = "Resistencia total: " & (ResT * 1000) & " mΩ"
        End If

        IntT = VolT / ResT

        'IT.Text = "Corriente total: " & IntT & " A"

        If IntT < 1000 And IntT >= 1 Then
            IT.Text = "Corriente total: " & IntT & " A"
        ElseIf IntT >= 1000 Then
            IT.Text = "Corriente total: " & (IntT / 1000) & " kA"
        ElseIf IntT < 0.001 And IntT >= 0.000001 Then
            IT.Text = "Corriente total: " & (IntT * 1000000) & " μA"
        ElseIf IntT >= 0.001 And IntT < 1 Then
            IT.Text = "Corriente total: " & (IntT * 1000) & " mA"
        ElseIf IntT < 0.000001 Then
            IT.Text = "Corriente total: " & (IntT * 1000000000) & " nA"
        End If
        VoltList.Items.Clear()
        WattList.Items.Clear()
        Voltaje()
        Potencia()
        IsCalc = True

    End Sub

    Public Sub Voltaje()
        For i = 0 To (OhmList.Items.Count - 1)
            VoltList.Items.Add(VolT * CDbl(OhmList.Items.Item(i) / ResT) & " v")
        Next
    End Sub

    Public Sub Potencia()
        For i = 0 To (OhmList.Items.Count - 1)
            'WattList.Items.Add(VolT * IntT * CDbl(OhmList.Items.Item(i) / ResT) & " W")
            PotT = VolT * IntT * CDbl(OhmList.Items.Item(i) / ResT)

            If PotT < 1000 And PotT >= 1 Then
                WattList.Items.Add(PotT & " W")
            ElseIf PotT >= 1000 Then
                'IT.Text = "Corriente total: " & (IntT / 1000) & " kA"
                WattList.Items.Add(PotT / 1000 & " kW")
            ElseIf PotT < 0.001 And PotT >= 0.000001 Then
                'IT.Text = "Corriente total: " & (IntT * 1000000) & " μA"
                WattList.Items.Add(PotT * 1000000 & " μW")
            ElseIf PotT >= 0.001 And PotT < 1 Then
                'IT.Text = "Corriente total: " & (IntT * 1000) & " mA"
                WattList.Items.Add(PotT * 1000 & " mW")
            ElseIf PotT < 0.000001 Then
                'IT.Text = "Corriente total: " & (IntT * 1000000000) & " nA"
                WattList.Items.Add(PotT * 1000000000 & " nW")
            End If

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

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub WattList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WattList.SelectedIndexChanged
        If IsCalc Then
            OhmList.SelectedIndex = WattList.SelectedIndex
            VoltList.SelectedIndex = WattList.SelectedIndex
        End If
    End Sub
End Class