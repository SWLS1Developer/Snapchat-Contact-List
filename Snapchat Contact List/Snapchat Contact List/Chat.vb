Imports System.IO
Imports System.Text.RegularExpressions
Public Class Chat
    Private msgs As New List(Of ChatMessage)
    Private Sub Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cont As Contact = Form1.TreeView1.GetSelectedContact(Form1.contacts)
        If File.Exists(Path.Combine(Path.GetDirectoryName(Form1.path), cont.Name & ".snapchat")) Then
            Dim lines As String() = File.ReadAllText(Path.Combine(Path.GetDirectoryName(Form1.path), cont.Name & ".snapchat")).Split(vbCrLf)
            For Each line As String In lines
                Dim parts As String() = Regex.Split(line, "\#\#\?")
                If parts.Length >= 3 Then
                    Dim msg As New ChatMessage(
                parts(0).Trim,
                parts(1),
                Color.FromArgb(parts(2).Split(",")(0), parts(2).Split(",")(1), parts(2).Split(",")(2)))

                    If parts.Length = 4 Then
                        msg.MessageTime = parts(3)
                    End If
                    msgs.Add(msg)
                End If
            Next
            Dim snap As New SnapChat
            snap.CreateChat(Panel1, msgs)
        End If
    End Sub
End Class