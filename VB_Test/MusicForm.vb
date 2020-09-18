
Public Class MusicForm
    Public Property intPass As Integer

    Private Sub MusicForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userMood As Integer = intPass
        ' MessageBox.Show(userMood)
        If userMood = 1 Then
            My.Computer.Audio.Play("C:\Users\User\Music\Hype up music\AJR - Bummerland.wav",
        AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play("C:\Users\User\Music\Hype up music\BTS (방탄소년단) 'Dynamite'.wav",
        AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play("C:\Users\User\Music\Hype up music\Imagine Dragons - Believer.wav",
        AudioPlayMode.WaitToComplete)
        ElseIf userMood = 2 Then
            My.Computer.Audio.Play("C:\Users\User\Music\Sad music\A Great Big World, Christina Aguilera - Say Something.wav",
        AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play("C:\Users\User\Music\Sad music\Coldplay - Fix You.wav",
        AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play("C:\Users\User\Music\Hype up music\AJR - Bummerland.wav",
        AudioPlayMode.WaitToComplete)
        ElseIf userMood = 3 Then
            My.Computer.Audio.Play("C:\Users\User\Music\angry music\Green Day - American Idiot.wav",
        AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play("C:\Users\User\Music\angry music\Nirvana - Smells Like Teen Spirit.wav",
        AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play("C:\Users\User\Music\Hype up music\Imagine Dragons - Believer.wav",
        AudioPlayMode.WaitToComplete)
        Else
            My.Computer.Audio.Play("C:\Users\User\Music\Sad music\Adele - Someone Like You.wav",
        AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play("C:\Users\User\Music\Hype up music\BTS (방탄소년단) 'Dynamite'.wav",
        AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play("C:\Users\User\Music\Hype up music\AJR - Bummerland.wav",
        AudioPlayMode.WaitToComplete)
        End If

        ' MusicForm.intPass
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Rating As New RatingForm
        My.Computer.Audio.Stop()
        Rating.Show()
        Me.Hide()
    End Sub
End Class