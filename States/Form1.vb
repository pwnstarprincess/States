Public Class Form1

    Private Sub ReturnMessage()

        ''If Cali Button Checked get applicable Message
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

        ''If Indiana Button Checked get applicable Message
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

        ''If Mississippi Button Checked get applicable Message
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

        ''If New York Button Checked get applicable Message
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
        ''Run return message subroutine to get applicable Message
        ReturnMessage()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        ''On Form load set buttons to false
        CaliButton.Checked = False
        IndianaButton.Checked = False
        MississippiButton.Checked = False
        NewYorkButton.Checked = False
        FlowerButton.Checked = False
        NicknameButton.Checked = False
        MottoButton.Checked = False

    End Sub
End Class
