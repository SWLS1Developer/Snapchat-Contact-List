<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenInNotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPicturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddChatToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.findToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LATToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LONGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowPicturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'listView1
        '
        Me.listView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listView1.HideSelection = False
        Me.listView1.Location = New System.Drawing.Point(170, 42)
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(618, 396)
        Me.listView1.TabIndex = 4
        Me.listView1.UseCompatibleStateImageBehavior = False
        Me.listView1.View = System.Windows.Forms.View.Details
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripDropDownButton2, Me.ToolStripDropDownButton3, Me.toolStripDropDownButton1})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.toolStrip1.TabIndex = 3
        Me.toolStrip1.Text = "toolStrip1"
        '
        'toolStripDropDownButton2
        '
        Me.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem1, Me.OpenInNotepadToolStripMenuItem, Me.NewToolStripMenuItem})
        Me.toolStripDropDownButton2.Image = CType(resources.GetObject("toolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripDropDownButton2.Name = "toolStripDropDownButton2"
        Me.toolStripDropDownButton2.Size = New System.Drawing.Size(38, 22)
        Me.toolStripDropDownButton2.Text = "File"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.toolStripMenuItem1.Text = "Open"
        '
        'OpenInNotepadToolStripMenuItem
        '
        Me.OpenInNotepadToolStripMenuItem.Name = "OpenInNotepadToolStripMenuItem"
        Me.OpenInNotepadToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.OpenInNotepadToolStripMenuItem.Text = "Open In Notepad"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.AddPicturesToolStripMenuItem, Me.AddChatToolStripMenuItem, Me.ToolStripMenuItem5, Me.DeleteSelectedToolStripMenuItem})
        Me.ToolStripDropDownButton3.Image = CType(resources.GetObject("ToolStripDropDownButton3.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripDropDownButton3.Text = "Actions"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem4.Text = "Add New "
        '
        'AddPicturesToolStripMenuItem
        '
        Me.AddPicturesToolStripMenuItem.Name = "AddPicturesToolStripMenuItem"
        Me.AddPicturesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddPicturesToolStripMenuItem.Text = "Add Picture(s)"
        '
        'AddChatToolStripMenuItem
        '
        Me.AddChatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddChatToolStripMenuItem1})
        Me.AddChatToolStripMenuItem.Name = "AddChatToolStripMenuItem"
        Me.AddChatToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddChatToolStripMenuItem.Text = "Chats"
        '
        'AddChatToolStripMenuItem1
        '
        Me.AddChatToolStripMenuItem1.Name = "AddChatToolStripMenuItem1"
        Me.AddChatToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AddChatToolStripMenuItem1.Text = "Add Chat"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem5.Text = "Find"
        '
        'DeleteSelectedToolStripMenuItem
        '
        Me.DeleteSelectedToolStripMenuItem.Name = "DeleteSelectedToolStripMenuItem"
        Me.DeleteSelectedToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteSelectedToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteSelectedToolStripMenuItem.Text = "Delete Selected"
        '
        'toolStripDropDownButton1
        '
        Me.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.findToolStripMenuItem, Me.ShowLocationToolStripMenuItem, Me.ShowPicturesToolStripMenuItem, Me.ShowChatToolStripMenuItem})
        Me.toolStripDropDownButton1.Image = CType(resources.GetObject("toolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripDropDownButton1.Name = "toolStripDropDownButton1"
        Me.toolStripDropDownButton1.Size = New System.Drawing.Size(62, 22)
        Me.toolStripDropDownButton1.Text = "Contact"
        '
        'findToolStripMenuItem
        '
        Me.findToolStripMenuItem.Name = "findToolStripMenuItem"
        Me.findToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.findToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.findToolStripMenuItem.Text = "Show Location On Google Maps"
        '
        'ShowLocationToolStripMenuItem
        '
        Me.ShowLocationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LATToolStripMenuItem, Me.LONGToolStripMenuItem})
        Me.ShowLocationToolStripMenuItem.Name = "ShowLocationToolStripMenuItem"
        Me.ShowLocationToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.ShowLocationToolStripMenuItem.Text = "Show Location"
        '
        'LATToolStripMenuItem
        '
        Me.LATToolStripMenuItem.Name = "LATToolStripMenuItem"
        Me.LATToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.LATToolStripMenuItem.Text = "LAT: "
        '
        'LONGToolStripMenuItem
        '
        Me.LONGToolStripMenuItem.Name = "LONGToolStripMenuItem"
        Me.LONGToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.LONGToolStripMenuItem.Text = "LONG:"
        '
        'ShowPicturesToolStripMenuItem
        '
        Me.ShowPicturesToolStripMenuItem.Name = "ShowPicturesToolStripMenuItem"
        Me.ShowPicturesToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.ShowPicturesToolStripMenuItem.Text = "Show Pictures"
        '
        'ShowChatToolStripMenuItem
        '
        Me.ShowChatToolStripMenuItem.Name = "ShowChatToolStripMenuItem"
        Me.ShowChatToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.ShowChatToolStripMenuItem.Text = "Show Chat"
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Location = New System.Drawing.Point(12, 42)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(152, 396)
        Me.TreeView1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.listView1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents listView1 As ListView
    Private WithEvents toolStrip1 As ToolStrip
    Private WithEvents toolStripDropDownButton2 As ToolStripDropDownButton
    Private WithEvents toolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents toolStripDropDownButton1 As ToolStripDropDownButton
    Private WithEvents findToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TreeView1 As TreeView
    Private WithEvents ToolStripDropDownButton3 As ToolStripDropDownButton
    Private WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ShowLocationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LATToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LONGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenInNotepadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowPicturesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddPicturesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowChatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddChatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddChatToolStripMenuItem1 As ToolStripMenuItem
End Class
