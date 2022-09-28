Imports System.IO
Imports Microsoft.WindowsAPICodePack.Dialogs
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        txtDLlocation.Text = My.Settings.Output
        cbCookies.Checked = My.Settings.Cookies
        txtOutput.AppendText("youtube-DL GUI v1.1.0" + Environment.NewLine)
        txtOutput.AppendText("Current executable: " + My.Settings.Exe + Environment.NewLine)
        If My.Settings.Exe.Contains("yt-dlp.exe") Then
            txtOutput.AppendText("Checking for yt-dlp updates" + Environment.NewLine)
            StartProcess(My.Settings.Exe, "-U")
        End If
    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        Dim folderBrowser As CommonOpenFileDialog = New CommonOpenFileDialog()
        folderBrowser.IsFolderPicker = True
        If folderBrowser.ShowDialog() = DialogResult.OK Then
            txtDLlocation.Text = folderBrowser.FileName
        End If
    End Sub

    Private Sub DownloadButton_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        My.Settings.Output = txtDLlocation.Text
        txtOutput.AppendText("Loading " + My.Settings.Exe + "..." + Environment.NewLine)
        txtOutput.ScrollToCaret()

        If cbCookies.Checked Then
            StartProcess(My.Settings.Exe, "--cookies " + My.Settings.CookiesFile + " -o """ + txtDLlocation.Text + "\%(title)s.%(ext)s"" " + txtYTurl.Text)
        Else
            StartProcess(My.Settings.Exe, "-o """ + txtDLlocation.Text + "\%(title)s.%(ext)s"" " + txtYTurl.Text)
        End If
        My.Settings.Cookies = cbCookies.Checked
        My.Settings.Save()
    End Sub

    Private CurrentProcessID As Integer = -1

    Private Sub StartProcess(FileName As String, Arguments As String)
        Dim MyStartInfo As New ProcessStartInfo() With {
            .FileName = FileName,
            .Arguments = Arguments,
            .WorkingDirectory = Path.GetDirectoryName(FileName),
            .RedirectStandardError = True,
            .RedirectStandardOutput = True,
            .UseShellExecute = False,
            .CreateNoWindow = True
        }

        Dim YTDLProcess As Process = New Process() With {
            .StartInfo = MyStartInfo,
            .EnableRaisingEvents = True,
            .SynchronizingObject = Me
        }

        YTDLProcess.Start()
        YTDLProcess.BeginErrorReadLine()
        YTDLProcess.BeginOutputReadLine()

        CurrentProcessID = YTDLProcess.Id

        AddHandler YTDLProcess.OutputDataReceived,
            Sub(sender As Object, e As DataReceivedEventArgs)
                If e.Data IsNot Nothing Then
                    BeginInvoke(New MethodInvoker(
                    Sub()
                        txtOutput.AppendText(e.Data + Environment.NewLine)
                        txtOutput.ScrollToCaret()
                    End Sub))
                End If
            End Sub

        AddHandler YTDLProcess.ErrorDataReceived,
            Sub(sender As Object, e As DataReceivedEventArgs)
                If e.Data IsNot Nothing Then
                    BeginInvoke(New MethodInvoker(
                    Sub()
                        txtOutput.AppendText(e.Data + Environment.NewLine)
                        txtOutput.ScrollToCaret()
                    End Sub))
                End If
            End Sub

        AddHandler YTDLProcess.Exited,
            Sub(source As Object, ev As EventArgs)
                YTDLProcess.Close()
                If YTDLProcess IsNot Nothing Then
                    YTDLProcess.Dispose()
                End If
            End Sub
    End Sub

    Private Sub KillButton_Click(sender As Object, e As EventArgs) Handles KillButton.Click
        If My.Settings.Exe.Contains("yt-dlp") Then
            Dim p = Process.GetProcessesByName("yt-dlp")
            For i As Integer = 0 To p.Count - 1
                p(i).Kill()
                txtOutput.AppendText("Download stopped by user" + Environment.NewLine)
                txtOutput.ScrollToCaret()
            Next i
        End If
        If My.Settings.Exe.Contains("youtube-dl") Then
            Dim p = Process.GetProcessesByName("youtube-dl")
            For i As Integer = 0 To p.Count - 1
                p(i).Kill()
                txtOutput.AppendText("Download stopped by user" + Environment.NewLine)
                txtOutput.ScrollToCaret()
            Next i
        End If
    End Sub

    Private Sub GitHubButton_Click(sender As Object, e As EventArgs) Handles GitHubButton.Click
        Process.Start("https://github.com/KDunny/youtube-dl-GUI")
    End Sub

    Private Sub ChangeExeButton_Click(sender As Object, e As EventArgs) Handles ChangeExeButton.Click
        Dim folderBrowser2 As CommonOpenFileDialog = New CommonOpenFileDialog()
        If folderBrowser2.ShowDialog() = DialogResult.OK Then
            My.Settings.Exe = folderBrowser2.FileName
            txtOutput.AppendText("New executable: " + My.Settings.Exe + Environment.NewLine)
            My.Settings.Save()
        End If
    End Sub

    Private Sub cbCookies_Clicked(sender As Object, e As MouseEventArgs) Handles cbCookies.MouseClick
        Dim folderBrowser3 As CommonOpenFileDialog = New CommonOpenFileDialog()
        If folderBrowser3.ShowDialog() = DialogResult.OK Then
            My.Settings.Cookies = cbCookies.Checked
            My.Settings.CookiesFile = folderBrowser3.FileName
            txtOutput.AppendText("Cookies file: " + My.Settings.CookiesFile + Environment.NewLine)
            My.Settings.Save()
        End If
    End Sub
End Class
