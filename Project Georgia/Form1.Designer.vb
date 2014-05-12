<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.encryptBtn = New System.Windows.Forms.Button()
        Me.decryptBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.keyTxt = New System.Windows.Forms.TextBox()
        Me.dataTxt = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CleanAPPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'encryptBtn
        '
        Me.encryptBtn.Location = New System.Drawing.Point(218, 421)
        Me.encryptBtn.Name = "encryptBtn"
        Me.encryptBtn.Size = New System.Drawing.Size(65, 32)
        Me.encryptBtn.TabIndex = 0
        Me.encryptBtn.Text = "Encrypt"
        Me.encryptBtn.UseVisualStyleBackColor = True
        '
        'decryptBtn
        '
        Me.decryptBtn.Location = New System.Drawing.Point(289, 421)
        Me.decryptBtn.Name = "decryptBtn"
        Me.decryptBtn.Size = New System.Drawing.Size(65, 32)
        Me.decryptBtn.TabIndex = 1
        Me.decryptBtn.Text = "Decrypt"
        Me.decryptBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 428)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "S.A.F.E Key"
        '
        'keyTxt
        '
        Me.keyTxt.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyTxt.Location = New System.Drawing.Point(102, 421)
        Me.keyTxt.Name = "keyTxt"
        Me.keyTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.keyTxt.Size = New System.Drawing.Size(111, 32)
        Me.keyTxt.TabIndex = 4
        '
        'dataTxt
        '
        Me.dataTxt.BackColor = System.Drawing.SystemColors.MenuText
        Me.dataTxt.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataTxt.ForeColor = System.Drawing.SystemColors.Menu
        Me.dataTxt.Location = New System.Drawing.Point(12, 32)
        Me.dataTxt.Multiline = True
        Me.dataTxt.Name = "dataTxt"
        Me.dataTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.dataTxt.Size = New System.Drawing.Size(426, 383)
        Me.dataTxt.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CleanAPPToolStripMenuItem, Me.ExportToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CleanAPPToolStripMenuItem
        '
        Me.CleanAPPToolStripMenuItem.Name = "CleanAPPToolStripMenuItem"
        Me.CleanAPPToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CleanAPPToolStripMenuItem.Text = "Clean APP"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(360, 421)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Load"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(444, 32)
        Me.Label2.MaximumSize = New System.Drawing.Size(330, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(330, 391)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(784, 457)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dataTxt)
        Me.Controls.Add(Me.keyTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.decryptBtn)
        Me.Controls.Add(Me.encryptBtn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Project Georgia (S.A.F.E) by Vitor Pêgas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents encryptBtn As System.Windows.Forms.Button
    Friend WithEvents decryptBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents keyTxt As System.Windows.Forms.TextBox
    Friend WithEvents dataTxt As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CleanAPPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
