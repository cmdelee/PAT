Public Class PAT

        Private Sub timetablebtn_Click(sender As Object, e As EventArgs) Handles timetablebtn.Click

        timetablefm.TopLevel = False 'keeps the game within the panel (not opening outside the program)
        Panel1.Controls.Add(timetablefm) 'sets the game to load in the window
        timetablefm.Show() 'hides other games
        Calculator.Hide()
        highlow.Hide()
        Animal_game.Hide()
        helppg.hide()

    End Sub


    Private Sub calcbtn_Click(sender As Object, e As EventArgs) Handles calcbtn.Click

        Calculator.TopLevel = False
        Panel1.Controls.Add(Calculator)
        Calculator.Show()
        timetablefm.Hide()
        highlow.Hide()
        Animal_game.Hide()
        helppg.Hide()



    End Sub

    Private Sub highlowbtn_Click(sender As Object, e As EventArgs) Handles highlowbtn.Click

        highlow.TopLevel = False
        Panel1.Controls.Add(highlow)
        highlow.Show()
        Calculator.Hide()
        timetablefm.Hide()
        Animal_game.Hide()
        helppg.hide()

    End Sub

    Private Sub animalbtn_Click(sender As Object, e As EventArgs) Handles animalbtn.Click

        Animal_game.TopLevel = False
        Panel1.Controls.Add(Animal_game)
        Animal_game.Show()
        highlow.Hide()
        Calculator.Hide()
        timetablefm.Hide()
        helppg.hide()


    End Sub

    Private Sub Helpbtn_Click(sender As Object, e As EventArgs) Handles Helpbtn.Click

        Helppg.TopLevel = False
        Panel1.Controls.Add(helppg)
        helppg.show()
        Animal_game.Hide()
        highlow.Hide()
        Calculator.Hide()
        timetablefm.Hide()

    End Sub

    Private Sub userbtn_Click(sender As Object, e As EventArgs) Handles userbtn.Click

        Splash.Show() 'swaps back to the name  input screen to change names
        Hide()
        My.Forms.Splash.nametbx.Clear() 'clears the name input

    End Sub

    Private Sub endbtn_Click(sender As Object, e As EventArgs) Handles endbtn.Click
        End 'closes the program
    End Sub

End Class
