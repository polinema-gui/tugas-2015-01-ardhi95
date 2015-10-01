Public Class Form1
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.BackColor = Color.Maroon Then
            Me.BackColor = Color.Aqua
        Else
            Me.BackColor = Color.Maroon
        End If
    End Sub
End Class
