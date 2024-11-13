Imports System.Reflection.Emit

Public Class Form1
    Dim lives As Integer = 6
    Dim points As Integer = 0
    Dim hints As Integer = 3
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
        lblScore.Text = "Score: " & points
        lblHints.Text = "Hints: " & hints
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
            CheckWinner(word)
        Else
            lives -= 1
            lblLives.Text = "Lives: " & lives
        End If

        If lives <= 0 Then
            Dim result As DialogResult = MessageBox.Show("You've run out of lives!")
            Me.Close()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        btnNext.Enabled = False
        btnHint.Enabled = True
        resetDisplayedWord()
    End Sub

    Private Sub btnHint_Click(sender As Object, e As EventArgs) Handles btnHint.Click
        If hints > 0 Then
            hints -= 1
            lblHints.Text = "Hints: " & hints
            Dim word As String = words(currentWord)
            Dim unrevealedCount = CountItem(displayedAnswer, "_")
            Dim unrevealedIndices(unrevealedCount) As Integer
            Dim idx = 0

            For unrevealedIndex As Integer = 0 To displayedAnswer.Length - 1
                If displayedAnswer(unrevealedIndex) = "_" Then
                    unrevealedIndices(idx) = unrevealedIndex
                    idx += 1
                End If
            Next

            If unrevealedIndices.Count() > 0 Then
                Dim randomIndex As Integer = unrevealedIndices(rndGen.Next(0, unrevealedIndices.Count))
                displayedAnswer(randomIndex) = word(randomIndex)
                lbl_answer.Text = String.Join(" ", displayedAnswer)
                CheckWinner(word)
            End If

            If hints <= 0 Then
                btnHint.Enabled = False
            End If
        End If
    End Sub

    Private Sub CheckWinner(word As String)
        If String.Join("", displayedAnswer) = word Then
            MessageBox.Show("Congratulations! You've guessed the word.")
            points += 5
            lblScore.Text = "Score: " & points
            btnNext.Enabled = True
            btnHint.Enabled = False

            If completed = words.Length Then
                MessageBox.Show("Game completed!")
                Me.Close()
            End If
        End If
    End Sub

    Private Function CountItem(array() As String, item As String) As Integer
        Dim count As Integer = 0

        For i = 0 To array.Length - 1
            If array(i) = item Then
                count += 1
            End If
        Next

        Return count
    End Function
End Class
