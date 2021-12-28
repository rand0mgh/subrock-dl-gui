Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TextBox2.Text = ("https://www.subrock.tk/dynamic/videos/")
        TextBox1.Text = ("")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox2.Text = ("https://www.subrock.tk/dynamic/videos/" & TextBox1.Text & ".mp4")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.URL = TextBox2.Text
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
