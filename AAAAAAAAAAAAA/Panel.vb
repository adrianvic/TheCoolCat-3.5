Public Class Panel

    Private Sub Reset(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MainForm.progress = 0
    End Sub

    Private Sub ClosePanel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Kill(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MainForm.Close()
    End Sub

    Private Sub Boost(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MainForm.progress += 300
    End Sub

    Private Sub PanelLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MainForm.PayloadTimer.Enabled = True Then
            Button7.Enabled = False
            Button6.Enabled = True
        Else
            Button7.Enabled = True
            Button6.Enabled = False
        End If
    End Sub

    Private Sub Pause(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button7.Enabled = True
        Button6.Enabled = False
        MainForm.PayloadTimer.Enabled = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Button7.Enabled = False
        Button6.Enabled = True
        MainForm.PayloadTimer.Enabled = True
    End Sub
End Class