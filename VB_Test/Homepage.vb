
Public Class Homepage
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.Play("C:\Users\User\Music\TestMusic.wav",
       AudioPlayMode.WaitToComplete)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim form2 As New SeverityForm
        form2.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MusicForm.intPass = 1
        Dim HappyForm As New HappySelected
        HappyForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        MusicForm.intPass = 2
        Dim form2 As New SeverityForm
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MusicForm.intPass = 3
        Dim form2 As New SeverityForm
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MusicForm.intPass = 4
        Dim form2 As New SeverityForm
        form2.Show()
        Me.Hide()
    End Sub
End Class
