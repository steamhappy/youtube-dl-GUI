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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtYTurl = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DownloadButton = New System.Windows.Forms.Button()
        Me.txtDLlocation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.cbCookies = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.RichTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GitHubButton = New System.Windows.Forms.Button()
        Me.KillButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtYTurl
        '
        Me.txtYTurl.Location = New System.Drawing.Point(131, 15)
        Me.txtYTurl.Name = "txtYTurl"
        Me.txtYTurl.Size = New System.Drawing.Size(242, 20)
        Me.txtYTurl.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Video URL:"
        Me.ToolTip1.SetToolTip(Me.Label1, "Any site supported by youtube-dl works here." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For more information, visit the r" &
        "eadme on the GitHub repo." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'DownloadButton
        '
        Me.DownloadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DownloadButton.Location = New System.Drawing.Point(179, 88)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(97, 31)
        Me.DownloadButton.TabIndex = 2
        Me.DownloadButton.Text = "Download"
        Me.DownloadButton.UseVisualStyleBackColor = True
        '
        'txtDLlocation
        '
        Me.txtDLlocation.Location = New System.Drawing.Point(131, 41)
        Me.txtDLlocation.Name = "txtDLlocation"
        Me.txtDLlocation.Size = New System.Drawing.Size(242, 20)
        Me.txtDLlocation.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Download To:"
        '
        'BrowseButton
        '
        Me.BrowseButton.Location = New System.Drawing.Point(379, 41)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(63, 20)
        Me.BrowseButton.TabIndex = 5
        Me.BrowseButton.Text = "Browse..."
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'cbCookies
        '
        Me.cbCookies.AutoSize = True
        Me.cbCookies.Location = New System.Drawing.Point(131, 70)
        Me.cbCookies.Name = "cbCookies"
        Me.cbCookies.Size = New System.Drawing.Size(15, 14)
        Me.cbCookies.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.cbCookies, resources.GetString("cbCookies.ToolTip"))
        Me.cbCookies.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Enable cookies?"
        Me.ToolTip1.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip"))
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(12, 125)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(430, 198)
        Me.txtOutput.TabIndex = 8
        Me.txtOutput.Text = ""
        '
        'GitHubButton
        '
        Me.GitHubButton.Location = New System.Drawing.Point(12, 96)
        Me.GitHubButton.Name = "GitHubButton"
        Me.GitHubButton.Size = New System.Drawing.Size(51, 23)
        Me.GitHubButton.TabIndex = 9
        Me.GitHubButton.Text = "GitHub"
        Me.ToolTip1.SetToolTip(Me.GitHubButton, "Opens the GitHub repo in your default web browser.")
        Me.GitHubButton.UseVisualStyleBackColor = True
        '
        'KillButton
        '
        Me.KillButton.Location = New System.Drawing.Point(336, 96)
        Me.KillButton.Name = "KillButton"
        Me.KillButton.Size = New System.Drawing.Size(106, 23)
        Me.KillButton.TabIndex = 10
        Me.KillButton.Text = "Cancel Download"
        Me.KillButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 332)
        Me.Controls.Add(Me.KillButton)
        Me.Controls.Add(Me.GitHubButton)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbCookies)
        Me.Controls.Add(Me.BrowseButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDLlocation)
        Me.Controls.Add(Me.DownloadButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtYTurl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "youtube-dl GUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtYTurl As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DownloadButton As Button
    Friend WithEvents txtDLlocation As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BrowseButton As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents cbCookies As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOutput As RichTextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GitHubButton As Button
    Friend WithEvents KillButton As Button
End Class
