Imports System.IO

Public Class New_File
    Private Sub New_File_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Me.Size
        Me.MinimumSize = Me.Size

        TextBox2.Text = "." & Form1.FileExt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TextBox3.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not File.Exists(Path.Combine(TextBox3.Text, TextBox1.Text & TextBox2.Text)) Then
            File.CreateText(Path.Combine(TextBox3.Text, TextBox1.Text & TextBox2.Text))
            MsgBox("File Created", vbInformation)
            Me.Close()
        Else
            MsgBox("File exists", vbCritical)
        End If
    End Sub
End Class