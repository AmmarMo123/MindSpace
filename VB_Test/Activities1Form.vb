Public Class Activities1Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Journaling As New JournalForm
        Journaling.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Memories As New MemoriesForm
        Memories.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '  Dim Music As New 'MusicForm
        MusicForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Meditation As New MeditationForm
        Meditation.Show()
        Me.Hide()
    End Sub
End Class