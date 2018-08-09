Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "abraham" And TextBox2.Text = "gradi" Or
            TextBox1.Text = "pedro" And TextBox2.Text = "619" Then



            Me.Hide()
            Gradi.Show()

        Else
            MsgBox("Usuario y contraseña incorrectos",, "ERROR")

        End If
    End Sub
End Class
