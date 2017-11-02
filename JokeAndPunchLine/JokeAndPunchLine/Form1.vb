Public Class Form1

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        lblJoke.Text = "How many programmers does" & ControlChars.NewLine &
            "it take to change a light bulb?"
    End Sub

    Private Sub btnPunchLine_Click(sender As Object, e As EventArgs) Handles btnPunchLine.Click
        lblJoke.Text = "None." & ControlChars.NewLine &
            "That's a hardware problem."
    End Sub
End Class
