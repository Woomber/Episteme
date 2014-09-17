Imports System.IO
Imports System.Text

Module Write

    Public Sub SaveFile()
        Dim path As String = "c:\temp\MyTest.txt"
        ' Create or overwrite the file. 
        Dim fs As FileStream = File.Create(path)
        ' Add text to the file. 
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("This is some text in the file.")
        fs.Write(info, 0, info.Length)
        fs.Close()

        Dim FILE_NAME As String = "C:\textfile.txt"
        Dim i As Integer
        Dim aryText(4) As String
        aryText(0) = "Mary WriteLine"
        aryText(1) = "Had"
        aryText(2) = "Another"
        aryText(3) = "Little"
        aryText(4) = "One"
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME, True)
        For i = 0 To 4
            objWriter.WriteLine(aryText(i))
        Next
        objWriter.Close()
        MsgBox("Text Appended to the File")

        System.IO.File.AppendAllText(FILE_NAME, "Hello World" & vbCrLf)
    End Sub

End Module
