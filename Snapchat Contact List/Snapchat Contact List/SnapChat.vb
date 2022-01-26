
Imports System.Drawing.Drawing2D
Imports System.Drawing
Public Class SnapChat
    Public pnl As Panel
    Public Sub CreateChat(ByRef panel As Panel, msgs As List(Of ChatMessage), Optional ByVal startingPoint As Point = Nothing, Optional ByVal NameFont_ As Font = Nothing, Optional ByVal TextFont_ As Font = Nothing)
        pnl = panel
        If NameFont_ Is Nothing Then
            NameFont = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        End If
        If TextFont_ Is Nothing Then
            TextFont = New Font("Ebrima", 9.75F)
        End If
        If IsNothing(startingPoint) Then
            startingPoint = New Point(10, 10)
        End If

        Dim lastPanel As Panel = Nothing

        For Each msg As ChatMessage In msgs
            Dim msgText As String = msg.Message
            If msgText.Contains("\n") Then
                msgText = msgText.Replace("\n", vbNewLine)
            End If
            If lastPanel Is Nothing Then
                lastPanel = CreateTextControl(msg.Sender, msgText, msg.Color, startingPoint, msg.MessageTime)
                panel.Controls.Add(lastPanel)
            Else
                lastPanel = CreateTextControl(msg.Sender, msgText, msg.Color, New Point(lastPanel.Location.X, lastPanel.Location.Y + lastPanel.Height), msg.MessageTime)
                panel.Controls.Add(lastPanel)
            End If
        Next
    End Sub

    Private NameFont As Font
    Private TextFont As Font

    Private Function CreateTextControl(ByVal name As String, ByVal text As String, ByVal User_Color_ As Color, ByVal loc As Point, Optional ByVal msgTime As String = Nothing) As Panel
        Dim newPnl_ As New Panel With {
        .BackColor = Color.Transparent,
        .Location = loc
        }

        Dim newPnl As Panel
        Dim User_Color As Color
        Dim nameVal, textVal As String

        newPnl = newPnl_
        User_Color = User_Color_
        textVal = text
        nameVal = name

        Dim w, h As Integer
        Using g_ As Graphics = newPnl.CreateGraphics()
            h = g_.MeasureString(text, TextFont).Height + g_.MeasureString(name, NameFont).Height + 15
            w = 250 'IIf(g_.MeasureString(text, TextFont).Width > g_.MeasureString(name, NameFont).Width, g_.MeasureString(text, TextFont).Width + 15, g_.MeasureString(name, NameFont).Width + 15)
            newPnl.Size = New Size(w, h)
        End Using
        Dim bmp As New Bitmap(w, h, Imaging.PixelFormat.Format32bppPArgb)
        Using g As Graphics = Graphics.FromImage(bmp)
            Dim sp As New Point(10, 5)
            g.SmoothingMode = SmoothingMode.HighQuality
            g.PixelOffsetMode = PixelOffsetMode.HighQuality
            g.InterpolationMode = InterpolationMode.HighQualityBicubic
            g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
            g.DrawString(nameVal.ToUpper, NameFont, New SolidBrush(User_Color), New PointF(sp.X + 1, sp.Y))
            Dim rect As New Rectangle(New Point(sp.X, sp.Y + 17), New Size(1, g.MeasureString(textVal, TextFont).Height + 6))
            g.DrawLine(New Pen(User_Color, 2.0F), rect.Location, New Point(rect.X, rect.Y + rect.Height))
            g.DrawString(textVal, TextFont, New SolidBrush(Color.Black), New PointF(sp.X + 5, sp.Y + 3 + 17))
            'g.DrawRectangle(New Pen(Color.Black, 1.5F), loc.X, loc.Y, loc.X + newPnl.Width, loc.Y + newPnl.Height)
            If msgTime IsNot Nothing Or Not msgTime = "" Then
                Dim timeLoc As Point = New Point(250 - (g.MeasureString(msgTime, New Font(NameFont, FontStyle.Bold)).Width + 3), sp.Y)
                g.DrawString(msgTime, New Font(NameFont, FontStyle.Bold), New SolidBrush(Color.Gray), timeLoc)
            End If


        End Using
        newPnl.Controls.Add(New PictureBox With {
        .Size = newPnl.Size,
        .Location = New Point(0, 0),
        .Image = bmp
        })
        Return newPnl
    End Function

End Class

Public Class ChatMessage
    Public Message As String
    Public Sender As String
    Public Color As Color
    Public MessageTime As String
    Public Sub New(msg As String, Sndr As String, clr As Color, Optional ByVal msgTime As String = Nothing)
        Message = msg
        Sender = Sndr
        Color = clr
        If msgTime IsNot Nothing Then
            MessageTime = msgTime
        End If
    End Sub
End Class
