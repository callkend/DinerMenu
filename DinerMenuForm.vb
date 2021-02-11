'Kendall Callister
'RCET0265
'Spring 2021
'Diner Menu Program
'https://github.com/callkend/DinerMenu.git

Option Explicit On
Option Strict On

Public Class DinerMenuForm
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DailySpecialLabel.Text = "~Soup of the Day~" + vbCrLf + vbCrLf + "Palm Nut Soup"
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DailySpecialLabel.Text = "~Chef's Special~" + vbCrLf + vbCrLf + "Shredduce"
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DailySpecialLabel.Text = "~Daily Fish~" + vbCrLf + vbCrLf + "Tuna"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


End Class
