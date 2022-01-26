Public Class Contact
    Public arguments As List(Of ContactArgument)
    Public Name As String
    Public Sub New(ByVal name_ As String, ByVal arguments_ As List(Of ContactArgument))
        arguments = arguments_
        Name = name_
    End Sub
End Class
