Public Class ChemDoc
    'Dim con As New OleDb.OleDbConnection
    'Dim ds As New DataTable 'A5E8K
    'Dim da As OleDb.OleDbDataAdapter
    'Dim sql As String

    Private Sub ChemDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;" & _
        '   "Data Source = C:\Users\Yael\Documents\GitHub\Episteme\Elements.accdb"
        'con.Open()
        'sql = "SELECT * FROM Simbolo"
        'da = New OleDb.OleDbDataAdapter(sql, con)

        'MsgBox("Abierto " & da.ToString)
        'con.Close()

    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class