Public Class ColorList
    Private Sub ColorList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadList()
    End Sub

    Private Sub LoadList()
        ListBox1.Items.Clear()

        For i As Integer = 0 To New_Chat.ColorDict.Count - 1
            ListBox1.Items.Add(New_Chat.ColorDict.Keys(i))
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If New_Chat.ColorDict.ContainsKey(ListBox1.SelectedItem) Then
            Dim clr As Color
            New_Chat.ColorDict.TryGetValue(ListBox1.SelectedItem, clr)
            Panel1.BackColor = clr
            TextBox1.Text = ListBox1.SelectedItem
            TextBox2.Text = clr.R & "," & clr.G & "," & clr.B
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        New_Chat.ColorDict.Add(TextBox1.Text, Color.FromArgb(TextBox2.Text.Split(",")(0), TextBox2.Text.Split(",")(1), TextBox2.Text.Split(",")(2)))
        For Each cnt As Control In New_Chat.Panel3.Controls
            For Each cnt1 As Control In cnt.Controls
                If TypeOf cnt1 Is ComboBox Then
                    Dim cb1 As ComboBox = DirectCast(cnt1, ComboBox)
                    cb1.Items.Add(TextBox1.Text)
                End If
            Next
        Next
        LoadList()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedItems.Count > 0 Then
            If New_Chat.ColorDict.ContainsKey(ListBox1.SelectedItem) Then
                New_Chat.ColorDict.Remove(ListBox1.SelectedItem)
            End If

            For Each cnt As Control In New_Chat.Panel3.Controls
                For Each cnt1 As Control In cnt.Controls
                    If TypeOf cnt1 Is ComboBox Then
                        Dim cb1 As ComboBox = DirectCast(cnt1, ComboBox)
                        If cb1.Items.Contains(ListBox1.SelectedItem) Then
                            cb1.Items.Remove(ListBox1.SelectedItem)
                        End If
                    End If
                Next
            Next
            LoadList()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Try
            Panel1.BackColor = Color.FromArgb(TextBox2.Text.Split(",")(0), TextBox2.Text.Split(",")(1), TextBox2.Text.Split(",")(2))
        Catch ex As Exception

        End Try
    End Sub
End Class