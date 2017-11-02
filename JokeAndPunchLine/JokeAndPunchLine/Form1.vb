Public Class Form1

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        lblJoke.Text = "How many programmers does" & ControlChars.NewLine &
            "it take to change a light bulb?"
    End Sub

    Private Sub btnPunchLine_Click(sender As Object, e As EventArgs) Handles btnPunchLine.Click
        lblJoke.Text = "None." & ControlChars.NewLine &
            "That's a hardware problem."
    End Sub

    Private Sub btnNextJoke_Click(sender As Object, e As EventArgs) Handles btnNextJoke.Click
        btnSteup2.Show()
        btnPunchLine2.Show()
        btnExit.Show()
        lblJoke.Text = "Click setup for new joke."
    End Sub

    Private Sub btnSteup2_Click(sender As Object, e As EventArgs) Handles btnSteup2.Click
        lblJoke.Text = "Why do Java Programmers" & ControlChars.NewLine &
            "have to wear glasses?"
    End Sub

    Private Sub btnPunchLine2_Click(sender As Object, e As EventArgs) Handles btnPunchLine2.Click
        lblJoke.Text = "Because the don't C#"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
