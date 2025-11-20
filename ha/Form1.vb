Public Class Form1
    Dim a As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "hammam"
        TextBox2.Text = " sabri"
        TextBox3.Text = " hussin"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox2.Text
        Dim i As String
        i = a.Substring(0, 6)
        TextBox4.Text = i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = "hammam sabri hussin"

        Dim z As String
        z = a.Remove(13, 6)
        TextBox4.Text = z
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a = "hammam sabri hussin"
        Dim r As String
        r = a.Insert(0, "mohammad ")
        TextBox4.Text = r
    End Sub
End Class
