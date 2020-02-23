Public Class Form1

    Private Sub ReturnMessage(state As Int16, Category As Int16)

        If (state = 1) Then

            Select Case Category
                Case "1"
                    InfoBox.Text = "Golden poppy"
                Case "2"
                    InfoBox.Text = "Golden State"
                Case "3"
                    InfoBox.Text = "Eureka"
                Case Else
                    InfoBox.Text = ""
            End Select
        End If

        If (state = 2) Then

            Select Case Category
                Case "1"
                    InfoBox.Text = "Peony"
                Case "2"
                    InfoBox.Text = "Hoosier State"
                Case "3"
                    InfoBox.Text = "Crossroads of America"
                Case Else
                    InfoBox.Text = ""
            End Select
        End If

        If (state = 3) Then

            Select Case Category
                Case "1"
                    InfoBox.Text = "Magnolia"
                Case "2"
                    InfoBox.Text = "Magnolia State"
                Case "3"
                    InfoBox.Text = "By Valor And Arms"
                Case Else
                    InfoBox.Text = ""
            End Select
        End If

        If (state = 4) Then

            Select Case Category
                Case "1"
                    InfoBox.Text = "Rose"
                Case "2"
                    InfoBox.Text = "Empire State"
                Case "3"
                    InfoBox.Text = "Ever Upward"
                Case Else
                    InfoBox.Text = ""
            End Select
        End If


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
