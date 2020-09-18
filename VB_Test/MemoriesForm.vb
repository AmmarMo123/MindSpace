Public Class MemoriesForm
    Public Property intPassJournal As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Rating As New RatingForm
        Rating.Show()
        Me.Hide()
    End Sub


    Private Sub MemoriesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myMemory As String = intPassJournal
        ' MessageBox.Show(myMemory)
        If myMemory <> "" Then
            Label1.Text = myMemory
        Else
            Label1.Text = "Memory is currently empty"
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class