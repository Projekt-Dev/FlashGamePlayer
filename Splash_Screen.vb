Public Class Splash_Screen

    'Variables
    Dim sleep As New Random

    Private Sub Splash_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (bar.Width > 0) Then
            bar.Width = 0
        End If
    End Sub
    Private Sub time_Tick(sender As Object, e As EventArgs) Handles time.Tick

        bar.Width += sleep.Next(0, 3) 'Progress width by minimum of 0 and max of 3

        If (bar.Width >= 700) Then 'If the width of panel is greater or equal to 700 open main form
            time.Stop()
            main.Show()
            Me.Hide()
        End If

    End Sub
End Class
