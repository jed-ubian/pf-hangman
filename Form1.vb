Imports System.Reflection.Emit

Public Class Form1
    Dim lives As Integer = 6
    Dim points As Integer = 0
    Dim currentWord As Integer
    Dim displayedAnswer() As String
    Dim words(2) As String
    Dim descriptions(2) As String
    Dim chosenIndexes() As Integer = {-1, -1, -1}
    Dim completed As Integer = 0
    Dim rndGen As New Random()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        words(0) = "Samgyeopsal"
        descriptions(0) = "A type of gui in Korean cuisine"

        words(1) = "Evaluation"
        descriptions(1) = "The systematic process of analyzing and judging the quality, importance, or value of something"

        words(2) = "Global"
        descriptions(2) = "Refers to something that spans or impacts the entire world"

        resetDisplayedWord()

        lblLives.Text = "Lives: " & lives
    End Sub

    Private Function getWordIndex() As Integer
        Dim index As Integer = rndGen.Next(0, 3)

        While chosenIndexes.Contains(index)
            index = rndGen.Next(0, 3)
        End While

        chosenIndexes(completed) = index
        completed += 1
        Return index
    End Function

    Private Sub resetDisplayedWord()
        currentWord = getWordIndex()
        ReDim displayedAnswer(words(currentWord).Length - 1)

        Dim word As String = ""
        Dim i As Integer

        For i = 0 To words(currentWord).Length - 1
            displayedAnswer(i) = "_"
            word += "_ "
        Next

        lbl_answer.Text = word
        lbl_description.Text = descriptions(currentWord)

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim keyChar As String = e.KeyCode.ToString().ToLower()
        Dim foundMatch As Boolean = False
        Dim word As String = words(currentWord)
        Dim displayWord As String

        For i As Integer = 0 To word.Length - 1
            If word(i).ToString().ToLower() = keyChar Then
                displayedAnswer(i) = word(i)
                foundMatch = True
            End If
        Next

        If foundMatch Then
            displayWord = String.Join(" ", displayedAnswer)
            lbl_answer.Text = displayWord

            If String.Join("", displayedAnswer) = word Then
                MessageBox.Show("Congratulations! You've guessed the word.")
                points += 5
                resetDisplayedWord()
            End If
        Else
            lives -= 1
            lblLives.Text = "Lives: " & lives
        End If

        If lives <= 0 Then
            Dim result As DialogResult = MessageBox.Show("You've run out of lives!")
            Me.Close()
        End If
    End Sub
End Class
