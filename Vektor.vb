Public Class Vektor
    ' Longitud, Dirección, X, Y
    Dim Va() As Double = {0, 0, 0, 0}
    Dim Vb() As Double = {0, 0, 0, 0}
    Dim Vr() As Double = {0, 0, 0, 0}
    'Longitud, Dirección
    Dim M1() As Double = {0, 0}
    Dim M2() As Double = {0, 0}
    Dim M3() As Double = {0, 0}
    Dim M4() As Double = {0, 0}
    Dim isResta As Boolean = False
    'Sin, Cos, ArcTan
    Dim Tdeg As Double = 0

    Private Sub Vektor_Load(sender As Object, e As EventArgs) Handles Me.Load

        M1(0) = My.Settings.M1_L
        M1(1) = My.Settings.M1_D
        M2(0) = My.Settings.M2_L
        M2(1) = My.Settings.M2_D
        M3(0) = My.Settings.M3_L
        M3(1) = My.Settings.M3_D
        M4(0) = My.Settings.M4_L
        M4(1) = My.Settings.M4_D

        If M1(0) <> 0 And M1(1) <> 0 Then
            M1ToolStripMenuItem.Text = "M1: " & M1(0) & ", " & M1(1) & "°"
        ElseIf M2(0) <> 0 And M2(1) <> 0 Then
            M2ToolStripMenuItem.Text = "M2: " & M2(0) & ", " & M2(1) & "°"
        ElseIf M3(0) <> 0 And M3(1) <> 0 Then
            M3ToolStripMenuItem.Text = "M3: " & M3(0) & ", " & M3(1) & "°"
        ElseIf M4(0) <> 0 And M4(1) <> 0 Then
            M4ToolStripMenuItem.Text = "M4: " & M4(0) & ", " & M4(1) & "°"
        End If

    End Sub


    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Try
            '0 longitud, 1 dirección, 2 x, 3 y
            Va(0) = CInt(CantVecA.Value) * CDbl(LongA.Text)
            Va(1) = CDbl(DirA.Text)
            Vb(0) = CInt(CantVecB.Value) * CDbl(LongB.Text)
            Vb(1) = CDbl(DirB.Text)
           
            Va(2) = Va(0) * Math.Cos((Math.PI / 180) * Va(1))
            Va(3) = Va(0) * Math.Sin((Math.PI / 180) * Va(1))
            Vb(2) = Vb(0) * Math.Cos((Math.PI / 180) * Vb(1))
            Vb(3) = Vb(0) * Math.Sin((Math.PI / 180) * Vb(1))

            For i = 2 to 3
                If (Va(i) < 0.000000001 And Va(i) >= 0) Or (Va(i) <= 0 And Va(i) > -0.000000001) Then
                    Va(i) = 0
                End If
            Next

            For i = 2 to 3
                If (Vb(i) < 0.000000001 And Vb(i) >= 0) Or (Vb(i) <= 0 And Vb(i) > -0.000000001) Then
                    Vb(i) = 0
                End If
            Next


            If isResta = 0 Then
                Vr(2) = Va(2) + Vb(2)
                Vr(3) = Va(3) + Vb(3)
            Else
                Vr(2) = Va(2) - Vb(2)
                Vr(3) = Va(3) - Vb(3)
            End If
            Vr(0) = Math.Sqrt((Vr(2) ^ 2) + (Vr(3) ^ 2))
            If Vr(2) = 0 Then
                Tdeg = 90
            Else
                Tdeg = (180 / Math.PI) * Math.Atan(Vr(3) / Vr(2))
            End If

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

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GuardarAMemoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarAMemoriaToolStripMenuItem.Click
        ' Test MsgBox("Memorias llenas. Borre alguna de las memorias para almacenar los datos nuevos." & vbNewLine & "M1: " & M1(0) & ", " & M1(1) & vbNewLine & "M2: " & M2(0) & ", " & M2(1) & vbNewLine & "M3: " & M3(0) & ", " & M3(1) & vbNewLine & "M4: " & M4(0) & ", " & M4(1))
        If Vr(0) <> 0 Then
            If M1(0) = 0 And M1(1) = 0 Then
                M1(0) = Vr(0)
                M1(1) = Vr(1)
                M1ToolStripMenuItem.Text = "M1: " & M1(0) & ", " & M1(1) & "°"
                My.Settings.M1_L = M1(0)
                My.Settings.M1_D = M1(1)
            ElseIf M2(0) = 0 And M2(1) = 0 Then
                M2(0) = Vr(0)
                M2(1) = Vr(1)
                M2ToolStripMenuItem.Text = "M2: " & M2(0) & ", " & M2(1) & "°"
                My.Settings.M2_L = M2(0)
                My.Settings.M2_D = M2(1)
            ElseIf M3(0) = 0 And M3(1) = 0 Then
                M3(0) = Vr(0)
                M3(1) = Vr(1)
                M3ToolStripMenuItem.Text = "M3: " & M3(0) & ", " & M3(1) & "°"
                My.Settings.M3_L = M3(0)
                My.Settings.M3_D = M3(1)
            ElseIf M4(0) = 0 And M4(1) = 0 Then
                M4(0) = Vr(0)
                M4(1) = Vr(1)
                M4ToolStripMenuItem.Text = "M4: " & M4(0) & ", " & M4(1) & "°"
                My.Settings.M4_L = M4(0)
                My.Settings.M4_D = M4(1)
            Else
                MsgBox("Memorias llenas. Borre alguna de las memorias para almacenar los datos nuevos." & vbNewLine & "M1: " & M1(0) & ", " & M1(1) & "°" & vbNewLine & "M2: " & M2(0) & ", " & M2(1) & "°" & vbNewLine & "M3: " & M3(0) & ", " & M3(1) & "°" & vbNewLine & "M4: " & M4(0) & ", " & M4(1) & "°")
            End If
        Else
            MsgBox("Error: El vector resultante a guardar tiene un valor nulo." & vbNewLine & "Vr = " & Vr(0) & ", " & Vr(1) & "°")
        End If

    End Sub

    Private Sub BorrarMemoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarMemoriaToolStripMenuItem.Click

        M1(0) = 0
        M1(1) = 0
        M1ToolStripMenuItem.Text = "M1"
        My.Settings.M1_L = 0
        My.Settings.M1_D = 0

    End Sub

    Private Sub BorrarMemoriaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BorrarMemoriaToolStripMenuItem1.Click

        M2(0) = 0
        M2(1) = 0
        M2ToolStripMenuItem.Text = "M2"
        My.Settings.M2_L = 0
        My.Settings.M2_D = 0

    End Sub

    Private Sub BorrarMemoriaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles BorrarMemoriaToolStripMenuItem2.Click

        M3(0) = 0
        M3(1) = 0
        M3ToolStripMenuItem.Text = "M3"
        My.Settings.M3_L = 0
        My.Settings.M3_D = 0

    End Sub

    Private Sub BorrarMemoriaToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles BorrarMemoriaToolStripMenuItem3.Click

        M4(0) = 0
        M4(1) = 0
        M4ToolStripMenuItem.Text = "M4"
        My.Settings.M4_L = 0
        My.Settings.M4_D = 0

    End Sub

    Private Sub RestaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaToolStripMenuItem.Click

        RestaToolStripMenuItem.Checked = True
        SumaToolStripMenuItem.Checked = False
        isResta = True
        OpcionesToolStripMenuItem.Text = "Modo Resta"

    End Sub

    Private Sub SumaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumaToolStripMenuItem.Click

        SumaToolStripMenuItem.Checked = True
        RestaToolStripMenuItem.Checked = False
        isResta = False
        OpcionesToolStripMenuItem.Text = "Modo Suma"

    End Sub

    Private Sub ColocarEnVectorAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColocarEnVectorAToolStripMenuItem.Click

        LongA.Text = M1(0)
        DirA.Text = M1(1)

    End Sub

    Private Sub ColocarEnVectorAToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ColocarEnVectorAToolStripMenuItem1.Click

        LongA.Text = M2(0)
        DirA.Text = M2(1)

    End Sub

    Private Sub ColocarEnVectorAToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ColocarEnVectorAToolStripMenuItem2.Click

        LongA.Text = M3(0)
        DirA.Text = M3(1)

    End Sub

    Private Sub ColocarEnVectorAToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ColocarEnVectorAToolStripMenuItem3.Click

        LongA.Text = M4(0)
        DirA.Text = M4(1)

    End Sub

    Private Sub ColocarEnVectorBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColocarEnVectorBToolStripMenuItem.Click

        LongB.Text = M1(0)
        DirB.Text = M1(1)

    End Sub

    Private Sub ColocarEnVectorBToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ColocarEnVectorBToolStripMenuItem1.Click

        LongB.Text = M2(0)
        DirB.Text = M2(1)

    End Sub

    Private Sub ColocarEnVectorBToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ColocarEnVectorBToolStripMenuItem2.Click

        LongB.Text = M3(0)
        DirB.Text = M3(1)

    End Sub

    Private Sub ColocarEnVectorBToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ColocarEnVectorBToolStripMenuItem3.Click

        LongB.Text = M4(0)
        DirB.Text = M4(1)

    End Sub
End Class