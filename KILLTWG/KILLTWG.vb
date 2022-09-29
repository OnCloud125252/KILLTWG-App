Imports System.IO
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class KILLTWG_form
    Private Sub Setup() Handles Me.Activated
        KILLTWGver_linklabel.Text = AppVersion()
        StatusValue()
        SetTheme_Light()
    End Sub

    Function AppVersion()
        Try
            Dim request As HttpWebRequest = WebRequest.Create("https://api.github.com/repos/Anonymous-AAAA/KILLTWG-App/releases/latest")
            request.Method = "GET"
            request.UserAgent = "request"
            Dim response As WebResponse = request.GetResponse()
            Dim dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            reader.Close()
            dataStream.Close()
            response.Close()
            Return Mid(responseFromServer, InStr(responseFromServer, """tag_name""") + 12, InStr(responseFromServer, """target_commitish""") - InStr(responseFromServer, """tag_name""") - 14)
        Catch ex As Exception
            Return "Can't get latest version"
            Exit Try
        End Try
    End Function

    Public Sub StatusValue()
        If Process.GetProcessesByName("REDAgent").Count > 0 Then
            StatusValue_label.Text = "ON"
            StatusValue_label.ForeColor = Color.Green
        Else
            StatusValue_label.Text = "OFF"
            StatusValue_label.ForeColor = Color.Red
        End If
    End Sub

    Private Sub KILL_Click(sender As Object, e As EventArgs) Handles KILL_button.Click
        Try
            Dim dir = My.Computer.FileSystem.GetDirectories("C:\Program Files (x86)\TWG")(0)
            My.Computer.FileSystem.RenameDirectory(dir, "Classroom")
        Catch ex As Exception
            Exit Try
        End Try
        Try
            If Process.GetProcessesByName("REDAgent").Count > 0 Then
                For Each proc As Process In Process.GetProcessesByName("REDAgent")
                    proc.Kill()
                Next
                Threading.Thread.Sleep(100)
                StatusValue()
            Else
                StatusValue_label.Text = "OFF"
                StatusValue_label.ForeColor = Color.Red
            End If
        Catch ex As Exception
            Exit Try
        End Try
    End Sub

    Private Sub RESUME_button_Click(sender As Object, e As EventArgs) Handles RESUME_button.Click
        Try
            Dim dir = My.Computer.FileSystem.GetDirectories("C:\Program Files (x86)\TWG")(0)
            My.Computer.FileSystem.RenameDirectory(dir, "eClassroom")
        Catch ex As Exception
            Exit Try
        End Try
        Threading.Thread.Sleep(200)
        Try
            If Process.GetProcessesByName("REDAgent").Count = 0 Then
                Dim redagent As New ProcessStartInfo With {
                    .FileName = "C:\Program Files (x86)\TWG\eClassroom\REDAgent.exe"
                }
                Dim redagentStats = Process.Start(redagent)
                Threading.Thread.Sleep(100)
                StatusValue()
            Else
                StatusValue_label.Text = "ON"
                StatusValue_label.ForeColor = Color.Green
            End If
        Catch ex As Exception
            Exit Try
        End Try
    End Sub

    Private Sub KILLTWGver_linklabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles KILLTWGver_linklabel.LinkClicked
        If AppVersion() <> "Can't get latest version" Then
            Process.Start("https://github.com/Anonymous-AAAA/KILLTWG-App/releases/tag/" + AppVersion())
        Else
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ")
        End If
    End Sub
    Private Sub WrittenBy_linklabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles WrittenBy_linklabel.LinkClicked
        Process.Start("https://github.com/Anonymous-AAAA")
    End Sub

    Private Sub GithubRepo_linklabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GithubRepo_linklabel.LinkClicked
        Process.Start("https://github.com/Anonymous-AAAA/KILLTWG-App")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/MRHACO")
    End Sub

    Private Sub Theme_Light(sender As Object, e As EventArgs) Handles LightToolStripMenuItem.Click
        SetTheme_Light()
    End Sub

    Private Sub Theme_Dark(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click
        SetTheme_Dark()
    End Sub

    Private Sub Theme_Hacker(sender As Object, e As EventArgs) Handles HackerToolStripMenuItem1.Click
        SetTheme_Hacker()
    End Sub

    Private Sub SetTheme_Light()
        BackColor = ColorTranslator.FromHtml("#ffffff")
        Control_groupbox.ForeColor = ColorTranslator.FromHtml("#000000")
        GroupBox1.ForeColor = ColorTranslator.FromHtml("#000000")
        Information_groupbox.ForeColor = ColorTranslator.FromHtml("#000000")
        KILLTWG_label.ForeColor = ColorTranslator.FromHtml("#000000")
        RESUME_button.BackColor = ColorTranslator.FromHtml("#ffffff")
        RESUME_button.ForeColor = ColorTranslator.FromHtml("#000000")
        RESUME_button.FlatStyle = FlatStyle.Standard
        KILL_button.BackColor = ColorTranslator.FromHtml("#ffffff")
        KILL_button.ForeColor = ColorTranslator.FromHtml("#00000")
        KILL_button.FlatStyle = FlatStyle.Standard
        KILLTWGver_linklabel.LinkColor = ColorTranslator.FromHtml("#0000FF")
        KILLTWGver_linklabel.ActiveLinkColor = ColorTranslator.FromHtml("#FF0000")
        WrittenBy_linklabel.LinkColor = ColorTranslator.FromHtml("#0000FF")
        WrittenBy_linklabel.ActiveLinkColor = ColorTranslator.FromHtml("#FF0000")
        LinkLabel1.LinkColor = ColorTranslator.FromHtml("#0000FF")
        LinkLabel1.ActiveLinkColor = ColorTranslator.FromHtml("#FF0000")
        GithubRepo_linklabel.LinkColor = ColorTranslator.FromHtml("#0000FF")
        GithubRepo_linklabel.ActiveLinkColor = ColorTranslator.FromHtml("#FF0000")
    End Sub

    Private Sub SetTheme_Dark()
        BackColor = ColorTranslator.FromHtml("#36393e")
        Control_groupbox.ForeColor = ColorTranslator.FromHtml("#ffffff")
        GroupBox1.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Information_groupbox.ForeColor = ColorTranslator.FromHtml("#ffffff")
        KILLTWG_label.ForeColor = ColorTranslator.FromHtml("#DCDDDE")
        RESUME_button.BackColor = ColorTranslator.FromHtml("#5865F2")
        RESUME_button.ForeColor = ColorTranslator.FromHtml("#ffffff")
        RESUME_button.FlatStyle = FlatStyle.Flat
        RESUME_button.FlatAppearance.BorderSize = 0
        KILL_button.BackColor = ColorTranslator.FromHtml("#5865F2")
        KILL_button.ForeColor = ColorTranslator.FromHtml("#ffffff")
        KILL_button.FlatStyle = FlatStyle.Flat
        KILL_button.FlatAppearance.BorderSize = 0
        KILLTWGver_linklabel.LinkColor = ColorTranslator.FromHtml("#5c68f6")
        KILLTWGver_linklabel.ActiveLinkColor = ColorTranslator.FromHtml("#5c68f6")
        WrittenBy_linklabel.LinkColor = ColorTranslator.FromHtml("#5c68f6")
        WrittenBy_linklabel.ActiveLinkColor = ColorTranslator.FromHtml("#5c68f6")
        LinkLabel1.LinkColor = ColorTranslator.FromHtml("#5c68f6")
        LinkLabel1.ActiveLinkColor = ColorTranslator.FromHtml("#5c68f6")
        GithubRepo_linklabel.LinkColor = ColorTranslator.FromHtml("#5c68f6")
        GithubRepo_linklabel.ActiveLinkColor = ColorTranslator.FromHtml("#5c68f6")
    End Sub

    Private Sub SetTheme_Hacker()
        BackColor = Color.FromName("Black")
        Control_groupbox.ForeColor = ColorTranslator.FromHtml("#ffffff")
        GroupBox1.ForeColor = ColorTranslator.FromHtml("#ffffff")
        Information_groupbox.ForeColor = ColorTranslator.FromHtml("#ffffff")
        KILLTWG_label.ForeColor = Color.FromName("Lime")
        RESUME_button.BackColor = Color.FromName("Black")
        RESUME_button.ForeColor = Color.FromName("Lime")
        RESUME_button.FlatStyle = FlatStyle.Standard
        KILL_button.BackColor = Color.FromName("Black")
        KILL_button.ForeColor = Color.FromName("Lime")
        KILL_button.FlatStyle = FlatStyle.Standard
        KILLTWGver_linklabel.LinkColor = Color.FromName("Lime")
        KILLTWGver_linklabel.ActiveLinkColor = Color.FromName("Lime")
        WrittenBy_linklabel.LinkColor = Color.FromName("Lime")
        WrittenBy_linklabel.ActiveLinkColor = Color.FromName("Lime")
        LinkLabel1.LinkColor = Color.FromName("Lime")
        LinkLabel1.ActiveLinkColor = Color.FromName("Lime")
        GithubRepo_linklabel.LinkColor = Color.FromName("Lime")
        GithubRepo_linklabel.ActiveLinkColor = Color.FromName("Lime")
    End Sub
End Class