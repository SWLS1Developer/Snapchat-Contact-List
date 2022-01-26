Imports System.IO, System.Text, System.Text.RegularExpressions
Imports System.Text.Encoding
Imports System

Public Class Form1

    Public lineRegex As New Regex("^([\w\s]{1,})\((.{1,})\)$")
    Public fileRegex As New Regex("([\w ]{1,})\-(\d)")

    Public contacts As List(Of Contact)
    Public Const FileExt As String = "babake"
    Public path As String
    Private currentLoc As String

    Private Sub Open()
        Dim ofd As New OpenFileDialog With {
        .Filter = "Contact List Files|*." & FileExt,
        .Title = ""
        }

        If ofd.ShowDialog() = DialogResult.OK Then
            If File.Exists(ofd.FileName) Then
                LoadOrRefresh(ofd.FileName)
                path = ofd.FileName
                My.Settings.lastPath = ofd.FileName
                My.Settings.Save()
            End If
        End If
    End Sub

    Public Function LoadFileToContactList(path As String) As List(Of Contact)
        Try
            If File.Exists(path) Then
                Dim lines() As String = File.ReadAllLines(path)
                Dim list As New List(Of Contact)
                For Each ln As String In lines
                    If lineRegex.IsMatch(ln) Then
                        Dim name As String = lineRegex.Match(ln).Groups(1).Value
                        Dim args() As String = lineRegex.Match(ln).Groups(2).Value.Split(":")
                        Dim cArg As New List(Of ContactArgument)
                        For Each l As String In args
                            Dim text As String
                            Dim value As String
                            text = l.Split("=")(0)
                            value = l.Split("=")(1)
                            cArg.Add(New ContactArgument(text, value))
                        Next
                        list.Add(New Contact(name, cArg))
                    End If
                Next
                Return list
            End If
        Catch ex As Exception
            MsgBox("Configuration Error" & vbNewLine & ex.Message, vbCritical)
        End Try
    End Function

    Public Sub LoadOrRefresh(ByVal File As String)
        contacts = LoadFileToContactList(File)
        TreeView1.Nodes.Clear()
        listView1.Items.Clear()
        Dim firstNodes As TreeNode() = {TreeView1.Nodes.Add("Uygun"), TreeView1.Nodes.Add("Uygun Değil"), TreeView1.Nodes.Add("Belirsiz")}
        With firstNodes(0)
            .ForeColor = Color.SeaGreen
        End With
        With firstNodes(1)
            .ForeColor = Color.FromArgb(192, 0, 0)
        End With
        With firstNodes(2)
            .ForeColor = Color.Gold
        End With
        For Each c As Contact In contacts
            Dim keys As List(Of ContactArgument) = c.arguments.ContainsKey("Uygunluk")
            If keys.Count > 0 And keys.Count < 2 Then
                If keys(0).Argument_Value = True Then
                    firstNodes(0).Nodes.Add(c.Name)
                Else
                    firstNodes(1).Nodes.Add(c.Name)
                End If
            Else
                firstNodes(2).Nodes.Add(c.Name)
            End If

            firstNodes(0).ExpandAll()
            firstNodes(1).ExpandAll()
            firstNodes(2).ExpandAll()
        Next
    End Sub


    Private Sub toolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem1.Click
        Open()
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        listView1.Columns.Clear()
        listView1.Items.Clear()
        For Each c As Contact In contacts
            If c.Name = TreeView1.SelectedNode.Text Then
                For Each arg As ContactArgument In c.arguments
                    listView1.Columns.Add(arg.Argument_Name)
                Next
                Dim lvi As New ListViewItem
                For Each arg As ContactArgument In c.arguments
                    If lvi.Text = "" Then
                        lvi.Text = arg.Argument_Value
                    Else
                        lvi.SubItems.Add(arg.Argument_Value)
                    End If

                    If arg.Argument_Name = "DirectLoc" Then
                        If arg.Argument_Value.Split(",").Count > 1 Then
                            LATToolStripMenuItem.Text = "LAT: " & arg.Argument_Value.Split(",")(0)
                            LONGToolStripMenuItem.Text = "LONG: " & arg.Argument_Value.Split(",")(1)
                            currentLoc = arg.Argument_Value
                        End If
                    End If
                Next
                listView1.Items.Add(lvi)
                Dim g As Graphics = listView1.CreateGraphics
                For i As Integer = 0 To listView1.Columns.Count - 1
                    listView1.Columns(i).Text = listView1.Columns(i).Text.Substring(0, 1).ToUpper & listView1.Columns(i).Text.Substring(1, listView1.Columns(i).Text.Length - 1)
                    listView1.Columns(i).Width = g.MeasureString(listView1.Columns(i).Text, listView1.Font).Width + 8
                    listView1.Columns(i).TextAlign = HorizontalAlignment.Center
                Next
            End If
        Next
    End Sub

    Private Sub OpenInNotepadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenInNotepadToolStripMenuItem.Click
        System.Diagnostics.Process.Start(path)
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        If path <> "" Then
            Find.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        If path <> "" Then
            New_Contact.Show()
        End If
    End Sub

    Private Sub findToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles findToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.google.com/maps/search/" & currentLoc)
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        If TreeView1.SelectedNode IsNot Nothing Then
            Dim cont As Contact = TreeView1.GetSelectedContact(contacts)
            If MessageBox.Show("Do you want to delete this contact from list? Name: " & cont.Name, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Dim list As New StringBuilder
                For Each str As String In File.ReadAllLines(path)
                    If lineRegex.IsMatch(str) Then
                        If lineRegex.Match(str).Groups(1).Value <> cont.Name Then
                            list.AppendLine(str)
                        End If
                    End If
                Next
                File.WriteAllText(path, list.ToString)

                Dim di As New IO.DirectoryInfo(IO.Path.GetDirectoryName(path))
                Dim aryFi As IO.FileInfo() = di.GetFiles("*.*")
                Dim imgList As New List(Of String)
                For Each fi As IO.FileInfo In aryFi
                    'MsgBox(fi.Name)
                    If fileRegex.IsMatch(fi.Name) Then
                        MsgBox(fileRegex.Match(fi.Name).Groups(1).Value.ToString.ToUpper)
                        If fileRegex.Match(fi.Name).Groups(1).Value.ToString.ToUpper = cont.Name.ToUpper Then
                            imgList.Add(fi.FullName)
                        End If
                    End If
                Next

                If imgList.Count > 0 Then
                    If MessageBox.Show("Do you want to delete pictures belong to this contact?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                        For Each path As String In imgList
                            File.Delete(path)
                        Next
                    End If
                End If

                LoadOrRefresh(path)
            End If
        End If

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        New_File.Show()
    End Sub

    Private Sub ShowPicturesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowPicturesToolStripMenuItem.Click
        Dim di As New IO.DirectoryInfo(IO.Path.GetDirectoryName(path))
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.*")
        Dim imList As New List(Of Bitmap)
        If TreeView1.SelectedNode IsNot Nothing Then
            For Each fi As IO.FileInfo In aryFi
                If fileRegex.IsMatch(fi.Name) Then
                    If fileRegex.Match(fi.Name).Groups(1).Value.ToString.ToUpper = TreeView1.SelectedNode.Text.ToUpper Then
                        Dim ms As New MemoryStream(System.Convert.FromBase64String(File.ReadAllText(fi.FullName)))
                        Dim bmp As Bitmap
                        bmp = Bitmap.FromStream(ms)
                        imList.Add(bmp)
                    End If
                End If
            Next
            With Pictures
                .picList = imList
                .Show()
            End With
        End If
    End Sub

    Private Sub AddPicturesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPicturesToolStripMenuItem.Click
        Add_Picture_s_.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.lastPath <> "" Then
            If File.Exists(My.Settings.lastPath) Then
                If MessageBox.Show("Last used file found do you want to open it?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    LoadOrRefresh(My.Settings.lastPath)
                    path = My.Settings.lastPath
                    My.Settings.lastPath = My.Settings.lastPath
                    My.Settings.Save()
                Else
                    My.Settings.lastPath = ""
                    My.Settings.Save()
                End If
            End If
        End If
    End Sub

    Private Sub ShowChatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowChatToolStripMenuItem.Click
        If TreeView1.SelectedNode IsNot Nothing Then
            Chat.Show()
        End If
    End Sub

    Private Sub AddChatToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddChatToolStripMenuItem1.Click
        If TreeView1.SelectedNode IsNot Nothing Then
            New_Chat.Show()
        End If
    End Sub
End Class
