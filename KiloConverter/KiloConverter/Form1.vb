﻿Public Class Form1

    Private Sub btnFeet_Click(sender As Object, e As EventArgs) Handles btnFeet.Click
        lblMessage.Text = "1 Kilo = 3,281 feet"
    End Sub

    Private Sub btnInches_Click(sender As Object, e As EventArgs) Handles btnInches.Click
        lblMessage.Text = "1 Kilo = 39,370 inches"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnYards_Click(sender As Object, e As EventArgs) Handles btnYards.Click
        lblMessage.Text = "1 Kilo = 1,093 yards"
    End Sub

    Private Sub btnMiles_Click(sender As Object, e As EventArgs) Handles btnMiles.Click
        lblMessage.Text = "1 Kilo = .06214 miles"
    End Sub
End Class
