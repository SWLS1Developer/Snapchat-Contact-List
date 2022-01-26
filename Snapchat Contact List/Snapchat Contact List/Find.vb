Public Class Find
    Private defSize As New Size(221, 166)
    Private maxSize As New Size(221, 326)

    Private Sub Find_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Me.Size
        Me.MinimumSize = Me.Size
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ListBox1.Items.Clear()

        For Each c As Contact In Form1.contacts
            If TextBox1.Text.Length < 2 Then
                If c.Name.ToLower.StartsWith(TextBox1.Text.ToLower) Then
                    ListBox1.Items.Add(c.Name)
                End If
            Else
                If c.Name.ToLower.Contains(TextBox1.Text.ToLower) Then
                    ListBox1.Items.Add(c.Name)
                End If
            End If
        Next


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'Select From TreeView 
        For i As Integer = 0 To Form1.TreeView1.Nodes.Count - 1
            For Each x As TreeNode In Form1.TreeView1.Nodes(i).Nodes
                If x.Text.ToUpper = ListBox1.SelectedItem.ToString.ToUpper Then
                    Form1.TreeView1.SelectedNode = x
                End If
            Next
        Next
    End Sub
End Class