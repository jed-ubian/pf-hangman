Public Class Form1
    Dim lives As Integer = 6
    Dim points As Integer = 0
    Dim currentWord As Integer
    Dim displayedAnswer() As String
    Dim words(3) As String
    Dim descriptions(3) As String
    Dim chosenIndexes(3) As Integer
    Dim completed As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        words(0) = "Samgyeopsal"

        resetDisplayedWord()
    End Sub

    Private Function getWordIndex() As Integer
        Dim index As Integer = (Rnd() * 3) + 1

        While Not chosenIndexes.Contains(index)
            index = (Rnd() * 3) + 1
        End While

        Return index
    End Function

    Private Function resetDisplayedWord()
        currentWord = getWordIndex()
        chosenIndexes(completed) = currentWord

        For wordIndex As Integer = 0 To words(currentWord).Length
            displayedAnswer.Append("_")
        Next
    End Function
End Class
