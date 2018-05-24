Imports System.IO
Public Class Form1
        Dim arylines As List(Of String) = New List(Of String)
    Dim aryLines2 As List(Of String) = New List(Of String)
    Dim rnd As New Random
    Dim rnd2 As New Random
    Dim ChosenWord As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFileAndStart()
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
    End Sub

    Private Sub btnCheckWord_Click(sender As Object, e As EventArgs) Handles btnCheckWord.Click
        '    OpenFileAndStart()
        '   For i As Integer = 0 To arylines.Count - 1
        ' Console.WriteLine(arylines(i))
        '   Next

        ChooseWord()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
    Private Sub btnCheat_Click(sender As Object, e As EventArgs) Handles btnCheat.Click
        Me.Width += 400
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
        ' This sub is to choose the word. I'm opening the file with a streamreader then giving each line a number. Then i choose a random number, and find what word is on the line of the random number, and i display that word. 

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
        ChosenWord = lines(line).Trim
        Console.WriteLine(ChosenWord)

        Dim arrayLetters As List(Of String) = New List(Of String)
        For i As Integer = 0 To 8
            arrayLetters.Add(ChosenWord.Chars(i))
        Next
        lbl1.Text = arrayLetters(0)
        lbl2.Text = arrayLetters(1)
        lbl3.Text = arrayLetters(2)
        lbl4.Text = arrayLetters(3)
        lbl5.Text = arrayLetters(4)
        lbl6.Text = arrayLetters(5)
        lbl7.Text = arrayLetters(6)
        lbl8.Text = arrayLetters(7)
        lbl9.Text = arrayLetters(8)

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
















































