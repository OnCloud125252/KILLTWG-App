<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KILLTWG_form
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.KILLTWG_label = New System.Windows.Forms.Label()
        Me.Control_groupbox = New System.Windows.Forms.GroupBox()
        Me.KILL_button = New System.Windows.Forms.Button()
        Me.StatusValue_label = New System.Windows.Forms.Label()
        Me.RESUME_button = New System.Windows.Forms.Button()
        Me.Status_label = New System.Windows.Forms.Label()
        Me.Information_groupbox = New System.Windows.Forms.GroupBox()
        Me.GithubRepo_linklabel = New System.Windows.Forms.LinkLabel()
        Me.WrittenBy_linklabel = New System.Windows.Forms.LinkLabel()
        Me.KILLTWGver_linklabel = New System.Windows.Forms.LinkLabel()
        Me.GithubRepo_label = New System.Windows.Forms.Label()
        Me.WrittenBy_label = New System.Windows.Forms.Label()
        Me.KILLTWGver_label = New System.Windows.Forms.Label()
        Me.Control_groupbox.SuspendLayout()
        Me.Information_groupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'KILLTWG_label
        '
        Me.KILLTWG_label.AutoSize = True
        Me.KILLTWG_label.Font = New System.Drawing.Font("Algerian", 30.0!, System.Drawing.FontStyle.Bold)
        Me.KILLTWG_label.Location = New System.Drawing.Point(40, 9)
        Me.KILLTWG_label.Name = "KILLTWG_label"
        Me.KILLTWG_label.Size = New System.Drawing.Size(192, 45)
        Me.KILLTWG_label.TabIndex = 4
        Me.KILLTWG_label.Text = "KILLTWG"
        '
        'Control_groupbox
        '
        Me.Control_groupbox.Controls.Add(Me.KILL_button)
        Me.Control_groupbox.Controls.Add(Me.StatusValue_label)
        Me.Control_groupbox.Controls.Add(Me.RESUME_button)
        Me.Control_groupbox.Controls.Add(Me.Status_label)
        Me.Control_groupbox.Location = New System.Drawing.Point(12, 57)
        Me.Control_groupbox.Name = "Control_groupbox"
        Me.Control_groupbox.Size = New System.Drawing.Size(272, 94)
        Me.Control_groupbox.TabIndex = 1
        Me.Control_groupbox.TabStop = False
        Me.Control_groupbox.Text = "Control"
        '
        'KILL_button
        '
        Me.KILL_button.Location = New System.Drawing.Point(31, 53)
        Me.KILL_button.Name = "KILL_button"
        Me.KILL_button.Size = New System.Drawing.Size(75, 23)
        Me.KILL_button.TabIndex = 2
        Me.KILL_button.Text = "KILL"
        Me.KILL_button.UseVisualStyleBackColor = True
        '
        'StatusValue_label
        '
        Me.StatusValue_label.AutoSize = True
        Me.StatusValue_label.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.StatusValue_label.Location = New System.Drawing.Point(156, 18)
        Me.StatusValue_label.Name = "StatusValue_label"
        Me.StatusValue_label.Size = New System.Drawing.Size(0, 24)
        Me.StatusValue_label.TabIndex = 6
        '
        'RESUME_button
        '
        Me.RESUME_button.Location = New System.Drawing.Point(166, 53)
        Me.RESUME_button.Name = "RESUME_button"
        Me.RESUME_button.Size = New System.Drawing.Size(75, 23)
        Me.RESUME_button.TabIndex = 3
        Me.RESUME_button.Text = "RESUME"
        Me.RESUME_button.UseVisualStyleBackColor = True
        '
        'Status_label
        '
        Me.Status_label.AutoSize = True
        Me.Status_label.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Status_label.Location = New System.Drawing.Point(77, 18)
        Me.Status_label.Name = "Status_label"
        Me.Status_label.Size = New System.Drawing.Size(73, 24)
        Me.Status_label.TabIndex = 5
        Me.Status_label.Text = "Status :"
        '
        'Information_groupbox
        '
        Me.Information_groupbox.Controls.Add(Me.GithubRepo_linklabel)
        Me.Information_groupbox.Controls.Add(Me.WrittenBy_linklabel)
        Me.Information_groupbox.Controls.Add(Me.KILLTWGver_linklabel)
        Me.Information_groupbox.Controls.Add(Me.GithubRepo_label)
        Me.Information_groupbox.Controls.Add(Me.WrittenBy_label)
        Me.Information_groupbox.Controls.Add(Me.KILLTWGver_label)
        Me.Information_groupbox.Location = New System.Drawing.Point(12, 157)
        Me.Information_groupbox.Name = "Information_groupbox"
        Me.Information_groupbox.Size = New System.Drawing.Size(272, 95)
        Me.Information_groupbox.TabIndex = 5
        Me.Information_groupbox.TabStop = False
        Me.Information_groupbox.Text = "Information"
        '
        'GithubRepo_linklabel
        '
        Me.GithubRepo_linklabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GithubRepo_linklabel.AutoSize = True
        Me.GithubRepo_linklabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GithubRepo_linklabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.GithubRepo_linklabel.Location = New System.Drawing.Point(173, 65)
        Me.GithubRepo_linklabel.Name = "GithubRepo_linklabel"
        Me.GithubRepo_linklabel.Size = New System.Drawing.Size(87, 17)
        Me.GithubRepo_linklabel.TabIndex = 5
        Me.GithubRepo_linklabel.TabStop = True
        Me.GithubRepo_linklabel.Text = "KILLTWG App"
        Me.GithubRepo_linklabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WrittenBy_linklabel
        '
        Me.WrittenBy_linklabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WrittenBy_linklabel.AutoSize = True
        Me.WrittenBy_linklabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.WrittenBy_linklabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.WrittenBy_linklabel.Location = New System.Drawing.Point(220, 43)
        Me.WrittenBy_linklabel.Name = "WrittenBy_linklabel"
        Me.WrittenBy_linklabel.Size = New System.Drawing.Size(40, 17)
        Me.WrittenBy_linklabel.TabIndex = 4
        Me.WrittenBy_linklabel.TabStop = True
        Me.WrittenBy_linklabel.Text = "AAAA"
        Me.WrittenBy_linklabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'KILLTWGver_linklabel
        '
        Me.KILLTWGver_linklabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KILLTWGver_linklabel.AutoSize = True
        Me.KILLTWGver_linklabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.KILLTWGver_linklabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.KILLTWGver_linklabel.Location = New System.Drawing.Point(216, 21)
        Me.KILLTWGver_linklabel.Name = "KILLTWGver_linklabel"
        Me.KILLTWGver_linklabel.Size = New System.Drawing.Size(0, 17)
        Me.KILLTWGver_linklabel.TabIndex = 3
        Me.KILLTWGver_linklabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GithubRepo_label
        '
        Me.GithubRepo_label.AutoSize = True
        Me.GithubRepo_label.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GithubRepo_label.Location = New System.Drawing.Point(16, 65)
        Me.GithubRepo_label.Name = "GithubRepo_label"
        Me.GithubRepo_label.Size = New System.Drawing.Size(90, 17)
        Me.GithubRepo_label.TabIndex = 2
        Me.GithubRepo_label.Text = "Github Repo :"
        '
        'WrittenBy_label
        '
        Me.WrittenBy_label.AutoSize = True
        Me.WrittenBy_label.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.WrittenBy_label.Location = New System.Drawing.Point(16, 43)
        Me.WrittenBy_label.Name = "WrittenBy_label"
        Me.WrittenBy_label.Size = New System.Drawing.Size(102, 17)
        Me.WrittenBy_label.TabIndex = 1
        Me.WrittenBy_label.Text = "App written by :"
        '
        'KILLTWGver_label
        '
        Me.KILLTWGver_label.AutoSize = True
        Me.KILLTWGver_label.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.KILLTWGver_label.Location = New System.Drawing.Point(16, 21)
        Me.KILLTWGver_label.Name = "KILLTWGver_label"
        Me.KILLTWGver_label.Size = New System.Drawing.Size(91, 17)
        Me.KILLTWGver_label.TabIndex = 0
        Me.KILLTWGver_label.Text = "KILLTWG.exe :"
        '
        'KILLTWG_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(296, 261)
        Me.Controls.Add(Me.Information_groupbox)
        Me.Controls.Add(Me.Control_groupbox)
        Me.Controls.Add(Me.KILLTWG_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "KILLTWG_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KILLTWG"
        Me.Control_groupbox.ResumeLayout(False)
        Me.Control_groupbox.PerformLayout()
        Me.Information_groupbox.ResumeLayout(False)
        Me.Information_groupbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KILLTWG_label As Label
    Friend WithEvents Control_groupbox As GroupBox
    Friend WithEvents Status_label As Label
    Friend WithEvents StatusValue_label As Label
    Friend WithEvents KILL_button As Button
    Friend WithEvents RESUME_button As Button
    Friend WithEvents Information_groupbox As GroupBox
    Friend WithEvents KILLTWGver_label As Label
    Friend WithEvents KILLTWGver_linklabel As LinkLabel
    Friend WithEvents WrittenBy_label As Label
    Friend WithEvents WrittenBy_linklabel As LinkLabel
    Friend WithEvents GithubRepo_label As Label
    Friend WithEvents GithubRepo_linklabel As LinkLabel
End Class
