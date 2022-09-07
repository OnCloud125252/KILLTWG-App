Imports System.IO
Imports System.Net

Public Class KILLTWG_form
    Private Sub Setup() Handles Me.Activated
        KILLTWGver_linklabel.Text = AppVersion()
        StatusValue()
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
End Class