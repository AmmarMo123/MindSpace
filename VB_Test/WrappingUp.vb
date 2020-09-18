Public Class WrappingUp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form3 As New Activities1Form
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Final As New FinalForm
        Final.Show()
        Me.Hide()
    End Sub
End Class