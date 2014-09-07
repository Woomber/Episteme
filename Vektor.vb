Public Class Vektor
    ' Longitud, Dirección, X, Y
    Dim Va() As Double = {0, 0, 0, 0}
    Dim Vb() As Double = {0, 0, 0, 0}
    Dim Vr() As Double = {0, 0, 0, 0}
    'Sin, Cos, ArcTan
    Dim Tdeg As Double = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Va(0) = CDbl(LongA.Text)
            Va(1) = CDbl(DirA.Text)
            Vb(0) = CDbl(LongB.Text)
            Vb(1) = CDbl(DirB.Text)

            Va(2) = Va(0) * Math.Cos((Math.PI / 180) * Va(1))
            Va(3) = Va(0) * Math.Sin((Math.PI / 180) * Va(1))
            Vb(2) = Vb(0) * Math.Cos((Math.PI / 180) * Vb(1))
            Vb(3) = Vb(0) * Math.Sin((Math.PI / 180) * Vb(1))

            Vr(2) = Va(2) + Vb(2)
            Vr(3) = Va(3) + Vb(3)
            Vr(0) = Math.Sqrt((Vr(2) ^ 2) + (Vr(3) ^ 2))

            Tdeg = (180 / Math.PI) * Math.Atan(Vr(3) / Vr(2))
            'MsgBox(Tdeg)

            If Vr(2) >= 0 And Vr(3) >= 0 Then
                Vr(1) = Tdeg
            ElseIf Vr(2) <= 0 And Vr(3) >= 0 Then
                Vr(1) = 180 + Tdeg
            ElseIf Vr(2) <= 0 And Vr(3) <= 0 Then
                Vr(1) = 180 + Tdeg
            ElseIf Vr(2) >= 0 And Vr(3) <= 0 Then
                Vr(1) = 360 + Tdeg
            End If

            La.Text = Va(0) & ", " & Va(1) & "°"
            Lb.Text = Vb(0) & ", " & Vb(1) & "°"
            Lr.Text = Vr(0) & ", " & Vr(1) & "°"
            Lax.Text = Va(2)
            Lay.Text = Va(3)
            Lbx.Text = Vb(2)
            Lby.Text = Vb(3)
            Lrx.Text = Vr(2)
            Lry.Text = Vr(3)

        Catch ex As Exception
            MsgBox("Error: Vectores no válidos." & vbNewLine & "Por favor use sólo números.")
        End Try
    End Sub

    Private Sub PonerRComoVectorAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PonerRComoVectorAToolStripMenuItem.Click
        LongA.Text = Vr(0)
        DirA.Text = Vr(1)
    End Sub

    Private Sub PonerRComoVectorBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PonerRComoVectorBToolStripMenuItem.Click
        LongB.Text = Vr(0)
        DirB.Text = Vr(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class