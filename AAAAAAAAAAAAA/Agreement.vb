Public Class Agreement

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If My.Settings.Immune = True Then
            Me.Close()
        End If

        If CheckBox1.Checked = True Then
            MainForm.Show()
        Else
            MessageBox.Show("You are an idiot? you can't use the app without accepting", "", MessageBoxButtons.OK)
        End If
    End Sub
End Class