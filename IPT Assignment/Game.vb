Imports System.IO
Public Class Game
    Dim arylines As List(Of String) = New List(Of String)
    Dim aryLines2 As List(Of String) = New List(Of String)
    Dim ChosenWord As String
    Dim rnd2 As New Random

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFileAndStart()
        ChooseWord()
        FindAnswersFor9LetterWord()
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        RichTextBox1.Text = ""
        lstAnswers.Items.Clear()
        lbl1.Text = ""
        lbl2.Text = ""
        lbl3.Text = ""
        lbl4.Text = ""
        lbl5.Text = ""
        lbl6.Text = ""
        lbl7.Text = ""
        lbl8.Text = ""
        lbl9.Text = ""


    End Sub

    Private Sub btnCheckWord_Click(sender As Object, e As EventArgs) Handles btnCheckWord.Click

        Console.WriteLine(String.Equals(txtanswer1.Text, ChosenWord))
        If txtanswer1.Text = ChosenWord Then
            lstAnswers.Items.Add(txtanswer1.Text)
        Else
            MsgBox("Wrong Answer")
        End If


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub
    Private Sub txtanswer1_TextChanged(sender As Object, e As EventArgs) Handles txtanswer1.TextChanged


    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ChooseWord()
    End Sub
    Private Sub btnCheat_Click(sender As Object, e As EventArgs) Handles btnCheat.Click
        If sender.Text = "Cheat" Then
            Me.Width += 400
            sender.Text = "Uncheat"
        Else
            Me.Width -= 400
            sender.Text = "Cheat"
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

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
        line = rnd2.Next(lines.Count + 1)
        RichTextBox1.AppendText(lines(line).Trim())
        IoFile.Close()
        IoFile.Dispose()
        ChosenWord = lines(line).Trim
        Console.WriteLine(ChosenWord)
        Dim aryVowels As List(Of String) = New List(Of String)
        For z As Integer = 0 To 8
            If ChosenWord.Chars(z) Like "[a, e, i, o, u]" Then
                aryVowels.Add(ChosenWord.Chars(z))
            End If
        Next
        Dim randomNum As Integer = (CInt(Math.Ceiling(Rnd() * aryVowels.Count) - 1))
        Dim chosenLetter As String = aryVowels(randomNum)
        Console.WriteLine(chosenLetter)

        Dim arrayLetters As List(Of String) = New List(Of String)
        For i As Integer = 0 To 8
            arrayLetters.Add(ChosenWord.Chars(i))
        Next
        arrayLetters.Remove(chosenLetter)


        lbl1.Text = arrayLetters(0)
        lbl2.Text = arrayLetters(1)
        lbl3.Text = arrayLetters(2)
        lbl4.Text = arrayLetters(3)
        lbl5.Text = arrayLetters(4)
        lbl6.Text = arrayLetters(5)
        lbl7.Text = arrayLetters(6)
        lbl8.Text = arrayLetters(7)
        lbl9.Text = chosenLetter



    End Sub
    Private Sub FindAnswersFor9LetterWord()
        Dim reader = New StreamReader("4to8letter.txt")
        Dim wordlist As List(Of String) = New List(Of String)
        Do Until reader.EndOfStream
            wordlist.Add(reader.ReadLine)
        Loop
        reader.Close()
        Dim str As String = "[" & ChosenWord.Chars(0) & "," & ChosenWord.Chars(1) & "," & ChosenWord.Chars(2) & "," & ChosenWord.Chars(3) & "," & ChosenWord.Chars(4) & "," & ChosenWord.Chars(5) & "," & ChosenWord.Chars(6) & "," & ChosenWord.Chars(7) & "," & ChosenWord.Chars(8) & "]"

        For i As Integer = 0 To wordlist.Count - 1
            If wordlist(i) Like str & str & str & str Then
                lstAnswers.Items.Add(wordlist(i))
                RichTextBox2.Text += wordlist(i) & vbCrLf

            End If
        Next



    End Sub

    Private Sub tmrGame_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick

    End Sub

    '[a,e,i,o,u]
    '[chosenWord.Chars(0),chosenWord.Chars(1),chosenWord.Chars(2),chosenWord.Chars(3)....... (cont),]
    'Loop for every word in your answers

    'If answersWOrds(i) Like str & str & str & str
    'Code for valid answer
    'End if

    'End loop

End Class
















































