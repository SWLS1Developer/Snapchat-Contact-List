Public Class New_Chat
    Private lastPos As Point = Point.Empty
    Public ColorDict As New Dictionary(Of String, Color)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pnl As New Panel With {
        .Size = New Size(272, 94),
        .BackColor = Color.White
        }
        Dim lbl1 As New Label With {
        .Location = New Point(7, 7),
        .Text = "Message",
        .Size = New Drawing.Size(50, 13)
        }
        Dim lbl2 As New Label With {
       .Location = New Point(7, 46),
       .Text = "Color",
        .Size = New Drawing.Size(50, 13)
       }
        Dim lbl3 As New Label With {
       .Location = New Point(147, 46),
       .Text = "Date",
        .Size = New Drawing.Size(50, 13)
       }

        Dim tb1 As New TextBox With {
        .Location = New Point(10, 23),
        .Size = New Size(226, 20)
        }

        Dim tb2 As New TextBox With {
        .Location = New Point(150, 62),
        .Size = New Size(115, 20)
        }

        Dim cb1 As New ComboBox With {
     .Location = New Point(26, 62),
     .Size = New Size(118, 21)
     }

        Dim cpnl1 As New Panel With {
   .Location = New Point(10, 62),
   .Size = New Size(10, 21),
   .BackColor = Panel3.BackColor
   }

        Dim btn1 As New Button With {
.Location = New Point(242, 23),
.Size = New Size(23, 20),
.Text = "X"
}

        AddHandler btn1.Click, AddressOf btnClick
        AddHandler cb1.SelectedIndexChanged, AddressOf cbChanged

        For i As Integer = 0 To ColorDict.Count - 1
            cb1.Items.Add(ColorDict.Keys(i))
        Next

        pnl.Tag = (lastPos.Y - 11) / 94

        With pnl.Controls
            .Add(lbl1)
            .Add(lbl2)
            .Add(lbl3)
            .Add(tb1)
            .Add(tb2)
            .Add(cb1)
            .Add(cpnl1)
            .Add(btn1)
        End With

        If lastPos <> Point.Empty Then
            pnl.Location = New Point(lastPos.X, lastPos.Y + 94 + 5)
            lastPos = New Point(lastPos.X, lastPos.Y + 94 + 5)
            Panel3.Controls.Add(pnl)
        Else
            pnl.Location = New Point(11, 12)
            lastPos = New Point(11, 12)
            Panel3.Controls.Add(pnl)
        End If


    End Sub

    Private Sub cbChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim cb As ComboBox = DirectCast(sender, ComboBox)
        Dim clr As Color
        If ColorDict.ContainsKey(cb.SelectedItem) Then
            ColorDict.TryGetValue(cb.SelectedItem, clr)
            For Each cntrl As Control In cb.Parent.Controls
                If TypeOf cntrl Is Panel Then
                    DirectCast(cntrl, Panel).BackColor = clr
                End If
            Next
        End If
    End Sub

    Private Sub btnClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        btn.Parent.Parent.Controls.Remove(btn.Parent)
        lastPos = New Point(lastPos.X, lastPos.Y - (94 + 5))
        For i As Integer = 0 To Panel3.Controls.Count - 1
            Dim mainPanel As Panel = Panel3
            If TypeOf mainPanel.Controls(i) Is Panel Then
                Dim pnl As Panel = mainPanel.Controls(i)
                If pnl.Tag > btn.Parent.Tag Then
                    pnl.Tag -= 1
                    pnl.Location = New Point(pnl.Location.X, pnl.Location.Y - (94 + 5))
                End If
            End If
        Next
    End Sub

    Private Sub New_Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorDict.Add("Red", Color.FromArgb(192, 0, 0))
        ColorDict.Add("Blue", Color.FromArgb(5, 150, 255))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ColorList.Show()
    End Sub
End Class