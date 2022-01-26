Public Class Pictures
    Public picList As List(Of Bitmap)
    Private pos As Integer = 0

    Private Sub Pictures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If picList.Count > 0 Then
            PictureBox1.Image = picList(0)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If picList.Count > 0 Then
            PictureBox1.Image = picList(pos)

            If pos + 1 > picList.Count - 1 Then
                pos = 0
            Else
                pos += 1
            End If
        End If
    End Sub
End Class