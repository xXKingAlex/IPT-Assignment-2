Imports System.IO
Public Class Form1
        Dim arylines As List(Of String) = New List(Of String)
    Dim aryLines2 As List(Of String) = New List(Of String)
    Dim rnd As New Random
    Dim ChosenWord As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFileAndStart()
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
    End Sub

    Private Sub btnCheckWord_Click(sender As Object, e As EventArgs) Handles btnCheckWord.Click
        OpenFileAndStart()
        For i As Integer = 0 To arylines.Count - 1c
            Console.WriteLine(arylines(i))
        Next
    End Sub
    Private Sub OpenFileAndStart()
        ' creating Streamreader to open and read all words.
        Dim reader As StreamReader = New StreamReader("9letter.txt")
        arylines.Clear()
        Do Until reader.EndOfStream
            arylines.Add(reader.ReadLine)
        Loop
        ' closes reader and file
        reader.Close()
        Dim randomNum = 3
        Dim Chosenword = arylines(3)
        reader = New StreamReader("4to8letter.txt")
        aryLines2.Clear()
        Do Until reader.EndOfStream
            aryLines2.Add(reader.ReadLine)
        Loop
        reader.Close()
    End Sub
    Private Sub ChooseWord()
        Dim IoFile As New StreamReader("9letter.txt")
        Dim lines As New List(Of String)
        Dim line As Integer
        While IoFile.Peek <> -1
            lines.Add(IoFile.ReadLine())
        End While
        line = rnd.Next(lines.Count + 1)
        RichTextBox1.AppendText(lines(line).Trim())
        IoFile.Close()
        IoFile.Dispose()
        Console.WriteLine(lines(line).Trim)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChooseWord()

    End Sub
End Class
















































