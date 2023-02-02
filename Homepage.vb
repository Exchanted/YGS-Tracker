Public Class Homepage

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        Me.Hide()
        Dim homepage As New Homepage
        homepage.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button1_MouseMove(sender As Object, e As EventArgs) Handles Button1.MouseMove
        Me.Button1.BackColor = Color.FromArgb(122, 122, 122)
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Me.Button1.BackColor = Color.FromArgb(138, 138, 138)
    End Sub

End Class