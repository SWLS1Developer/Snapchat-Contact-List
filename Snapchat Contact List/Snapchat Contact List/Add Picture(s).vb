Imports System.IO

Public Class Add_Picture_s_
    Private picList As New List(Of Image)
    Private Sub Add_Picture_s__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .MinimumSize = .Size
            .MaximumSize = .Size
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            For Each path As String In OpenFileDialog1.FileNames
                If IO.File.Exists(path) Then
                    TextBox1.Text = IO.Path.GetDirectoryName(OpenFileDialog1.FileName)
                    picList.Add(Image.FromFile(path))
                End If
            Next
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If picList.Count > 0 Then
            Dim x As Integer = 0
            For Each i As Image In picList
                Dim data As String
                Dim ms As MemoryStream = New MemoryStream
                i.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                data = Convert.ToBase64String(ms.ToArray())
                If File.Exists(Path.Combine(Path.GetDirectoryName(Form1.path), Form1.TreeView1.GetSelectedContact(Form1.contacts).Name & "-" & x)) Then
                    While File.Exists(Path.Combine(Path.GetDirectoryName(Form1.path), Form1.TreeView1.GetSelectedContact(Form1.contacts).Name & "-" & x))
                        x += 1
                    End While
                End If
                If Not File.Exists(Path.Combine(Path.GetDirectoryName(Form1.path), Form1.TreeView1.GetSelectedContact(Form1.contacts).Name & "-" & x)) Then
                    With File.CreateText(Path.Combine(Path.GetDirectoryName(Form1.path), Form1.TreeView1.GetSelectedContact(Form1.contacts).Name & "-" & x))
                        .Write(data)
                        .Close()
                    End With
                End If

                x += 1
            Next
            MsgBox("Success", vbInformation)
            Me.Close()
        End If
    End Sub
End Class