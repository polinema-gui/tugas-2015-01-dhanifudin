Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.BackColor = Color.Blue Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.Blue
        End If
    End Sub
End Class
