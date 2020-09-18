Public Class MeditationForm
    Private Sub MeditationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play("C:\Users\User\Music\Meditation.wav")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Stop()
        Dim Rating As New RatingForm
        Rating.Show()
        Me.Hide()
    End Sub
End Class