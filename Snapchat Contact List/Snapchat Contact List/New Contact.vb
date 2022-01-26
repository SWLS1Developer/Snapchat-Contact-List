Imports System.Text

Public Class New_Contact
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedItems.Count > 0 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not TextBox2.Text = "" And Not TextBox3.Text = "" Then
            ListBox1.Items.Add(TextBox2.Text & "=" & TextBox3.Text)
            TextBox2.Text = ""
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text <> "" Then
            If Not Form1.contacts.ContainsName(TextBox1.Text) Then
                Dim newLine As String
                Dim sb As New StringBuilder
                Dim strfrm As String = "{0}({1})"
                For Each str As String In ListBox1.Items
                    If sb.ToString.Length < 1 Then
                        sb.Append(str)
                    Else
                        sb.Append(":" & str)
                    End If
                Next
                newLine = String.Format(strfrm, TextBox1.Text, sb.ToString)
                Dim combinedString As String = IO.File.ReadAllText(Form1.path) & (vbNewLine & newLine)
                IO.File.WriteAllText(Form1.path, combinedString)
                Form1.LoadOrRefresh(Form1.path)
                MsgBox("Success", vbInformation)
                ListBox1.Items.Clear()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
            Else
                MsgBox("Names conflicting", vbCritical)
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Form1.TreeView1.SelectedNode IsNot Nothing Then
            Dim cont As Contact = Form1.TreeView1.GetSelectedContact(Form1.contacts)
            TextBox1.Text = cont.Name
            For i As Integer = 0 To cont.arguments.Count - 1
                ListBox1.Items.Add(cont.arguments(i).Argument_Name & "=" & cont.arguments(i).Argument_Value)
            Next
        End If
    End Sub



End Class