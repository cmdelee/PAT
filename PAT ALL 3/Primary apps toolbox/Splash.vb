Public Class Splash

    Private Sub continuebtn_Click(sender As Object, e As EventArgs) Handles continuebtn.Click

        Dim name As String

        name = nametbx.Text

        If Len(name) > 2 Then 'checks the name is at least 2 characters long
            PAT.Show() 'opens the main application
            Hide() 'hides the spalsh/name entry form
            My.Forms.PAT.hellolbl.Text = name 'changes the name on the main application to the name inputted here
            My.Computer.Audio.Play(My.Resources.vista, AudioPlayMode.Background) 'plays the windows welcome sound
        End If

    End Sub

    Private Sub nametbx_TextChanged(sender As Object, e As EventArgs) Handles nametbx.TextChanged

        AcceptButton = continuebtn 'sets the enter button to work for keyboard use

    End Sub

End Class
