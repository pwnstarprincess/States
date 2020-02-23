Public Class Form1

    Private Sub ReturnMessage()

        If (CaliButton.Checked) Then

            Select Case True
                Case FlowerButton.Checked
                    InfoBox.Text = "Golden poppy"
                Case NicknameButton.Checked
                    InfoBox.Text = "Golden State"
                Case MottoButton.Checked
                    InfoBox.Text = "Eureka"
                Case Else
                    InfoBox.Text = ""
            End Select
        End If

        If (IndianaButton.Checked) Then

            Select Case True
                Case FlowerButton.Checked
                    InfoBox.Text = "Peony"
                Case NicknameButton.Checked
                    InfoBox.Text = "Hoosier State"
                Case MottoButton.Checked
                    InfoBox.Text = "Crossroads of America"
                Case Else
                    InfoBox.Text = ""
            End Select
        End If

        If (MississippiButton.Checked) Then

            Select Case True
                Case FlowerButton.Checked
                    InfoBox.Text = "Magnolia"
                Case NicknameButton.Checked
                    InfoBox.Text = "Magnolia State"
                Case MottoButton.Checked
                    InfoBox.Text = "By Valor And Arms"
                Case Else
                    InfoBox.Text = ""
            End Select
        End If

        If (NewYorkButton.Checked) Then

            Select Case True
                Case FlowerButton.Checked
                    InfoBox.Text = "Rose"
                Case NicknameButton.Checked
                    InfoBox.Text = "Empire State"
                Case MottoButton.Checked
                    InfoBox.Text = "Ever Upward"
                Case Else
                    InfoBox.Text = ""
            End Select
        End If


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReturnMessage()
    End Sub
End Class
