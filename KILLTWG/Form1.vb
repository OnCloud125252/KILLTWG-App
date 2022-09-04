Public Class KILLTWG_form
    Sub StatusValue()
        If Process.GetProcessesByName("Insomnia").Count > 0 Then
            StatusValue_label.Text = "ON"
            StatusValue_label.ForeColor = Color.Green
        Else
            StatusValue_label.Text = "OFF"
            StatusValue_label.ForeColor = Color.Red
        End If
    End Sub
    Private Sub Setup() Handles Me.Activated
        StatusValue()
    End Sub
    Private Sub KILL_Click(sender As Object, e As EventArgs) Handles KILL_button.Click
        Try
            Dim dir = My.Computer.FileSystem.GetDirectories("C:\Program Files (x86)\TWG")(0)
            My.Computer.FileSystem.RenameDirectory(dir, "Classroom")
        Catch ex As Exception
            Exit Try
        End Try
        If Process.GetProcessesByName("Insomnia").Count > 0 Then
            For Each proc As Process In Process.GetProcessesByName("Insomnia")  ' For Each proc As Process In Process.GetProcessesByName("REDAgent")
                proc.Kill()
            Next
            Threading.Thread.Sleep(100)
            StatusValue()
        Else
            StatusValue_label.Text = "OFF"
            StatusValue_label.ForeColor = Color.Red
        End If
    End Sub

    Private Sub RESUME_button_Click(sender As Object, e As EventArgs) Handles RESUME_button.Click
        Try
            Dim dir = My.Computer.FileSystem.GetDirectories("C:\Program Files (x86)\TWG")(0)
            My.Computer.FileSystem.RenameDirectory(dir, "eClassroom")
        Catch ex As Exception
            Exit Try
        End Try
        If Process.GetProcessesByName("Insomnia").Count = 0 Then
            Dim redagent As New ProcessStartInfo With {
                .FileName = "C:\Users\Alex\AppData\Local\insomnia\Insomnia.exe"  ' .FileName = "C:\Program Files\TWG\eClassroom\REDAgent.exe"
            }
            Dim redagentStats = Process.Start(redagent)
            Threading.Thread.Sleep(100)
            StatusValue()
        Else
            StatusValue_label.Text = "ON"
            StatusValue_label.ForeColor = Color.Green
        End If
    End Sub

    Private Sub KILLTWGver_linklabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles KILLTWGver_linklabel.LinkClicked
        Process.Start("https://github.com/Anonymous-AAAA")
    End Sub
End Class