Imports System.Runtime.CompilerServices

Public Module Extentions
    <Extension>
    Public Function ContainsKey(list As List(Of ContactArgument), key As String) As List(Of ContactArgument)
        Dim i As New List(Of ContactArgument)
        For x As Integer = 0 To list.Count - 1

            If list(x).Argument_Name.ToUpper = key.ToUpper Then
                i.Add(list(x))
            End If
        Next
        Return i
    End Function

    <Extension>
    Public Function GetSelectedContact(treeview As TreeView, Contacts As List(Of Contact)) As Contact
        Dim i As Contact = Nothing
        For x As Integer = 0 To Contacts.Count - 1
            If treeview.SelectedNode.Text = Contacts(x).Name Then
                i = Contacts(x)
            End If
        Next
        Return i
    End Function

    <Extension>
    Public Function ContainsName(cont As List(Of Contact), name As String) As Boolean
        Dim i As Contact = Nothing
        For x As Integer = 0 To cont.Count - 1
            If name.ToUpper = cont(x).Name.ToUpper Then
                Return True
                Exit Function
            End If
        Next
Return False
    End Function
End Module
