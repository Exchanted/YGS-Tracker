Public Class Homepage

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        Me.Hide()
        Dim homepage As New Homepage
        homepage.Show()

    End Sub
End Class