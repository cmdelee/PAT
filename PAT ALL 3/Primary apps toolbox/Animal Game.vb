Imports PAT.My.Resources

Public Class Animal_game

    Dim animalsound(9) As Object
    Dim animalpic(9) As Object
    Dim imagechoice(4) As PictureBox
    Dim score As Integer

    Dim rannum, rannum1, rannum2, rannum3, rannum4 As Integer
    Dim ranpic As Integer

    Dim images(4) As Boolean
    Dim picavailable(9) As Boolean
    Dim correctanswer As Boolean

    Dim boxran As New Random
    Dim newrandom As New Random

    Dim player As New System.Media.SoundPlayer

    Private Sub Amimal_game_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        animalsound(0) = Cat 'brings up the sounds in resources
        animalsound(1) = cow
        animalsound(2) = dog
        animalsound(3) = duck
        animalsound(4) = elephant
        animalsound(5) = horse
        animalsound(6) = monkey
        animalsound(7) = pig
        animalsound(8) = sheep
        animalsound(9) = Tiger

        animalpic(0) = cat1 'brings up the images in resources
        animalpic(1) = Cow1
        animalpic(2) = Dog1
        animalpic(3) = Duck1
        animalpic(4) = Elephant1
        animalpic(5) = Horse1
        animalpic(6) = Monkey1
        animalpic(7) = Pig1
        animalpic(8) = sheep1
        animalpic(9) = tiger1

        imagechoice(0) = pbanswer1 'Assigns the pictureboxes
        imagechoice(1) = pbanswer2
        imagechoice(2) = pbanswer3
        imagechoice(3) = pbanswer4

    End Sub

    Private Sub btnplay_Click(sender As Object, e As EventArgs) Handles btnplay.Click

        images(0) = False 'makes the pictureboxes available (not in use)
        images(1) = False
        images(2) = False
        images(3) = False

        picavailable(0) = True 'makes the images availability boolean
        picavailable(1) = True
        picavailable(2) = True
        picavailable(3) = True
        picavailable(4) = True
        picavailable(5) = True
        picavailable(6) = True
        picavailable(7) = True
        picavailable(8) = True
        picavailable(9) = True

        correctanswer = True

        rannum = newrandom.Next(0, 10) 'sets random number
        player.Stream = animalsound(rannum) 'sets up the player with the random number corresponding with the resource sound and image
        player.Stream.Position = 0 'starts the player stream from the start
        player.Play() 'plays the audio file
        picavailable(rannum) = False 'makes the pic available linked with the random number false

        ranpic = boxran.Next(0, 4) 'selects a random picture box
        imagechoice(ranpic).Image = animalpic(rannum) 'puts the correct image in the random box
        images(ranpic) = True 'sets the picturebox as in use

        If images(0) = False Then 'checks if picturebox is in use (top left)
            Do
                rannum1 = newrandom.Next(0, 10) 'selects a random picture 
            Loop Until picavailable(rannum1) = True 'loops until the random picture isnt already being used
            picavailable(rannum1) = False 'sets the picture as being used
            imagechoice(0).Image = animalpic(rannum1) 'shows the picture in the picturebox
        End If

        If images(1) = False Then 'check if picturebox is in use (top right)
            Do
                rannum2 = newrandom.Next(0, 10)
            Loop Until picavailable(rannum2) = True
            picavailable(rannum2) = False
            imagechoice(1).Image = animalpic(rannum2)
        End If

        If images(2) = False Then 'checks if picturebox is in use (bottom left)
            Do
                rannum3 = newrandom.Next(0, 10)
            Loop Until picavailable(rannum3) = True
            picavailable(rannum3) = False
            imagechoice(2).Image = animalpic(rannum3)
        End If

        If images(3) = False Then 'checks if picturebox is in use (bottom right)
            Do
                rannum4 = newrandom.Next(0, 10)
            Loop Until picavailable(rannum4) = True
            picavailable(rannum4) = False
            imagechoice(3).Image = animalpic(rannum4)
        End If

    End Sub

    Private Sub pbanswer1_Click(sender As Object, e As EventArgs) Handles pbanswer1.Click

        If imagechoice(0) Is imagechoice(ranpic) And correctanswer = True Then 'cehcks if the box is the correct picture for the animal sound
            score = score + 1 'increases score by 1
            imagechoice(0).Image = correct 'shows a tick to show correct image is selected
        Else imagechoice(0).Image = incorrect 'shows a x to show wrong image selected
        End If
        correctanswer = False 'changes all pictureboxes to incorrect answers so you cant get a point after picking wrong one
        tbxscore.Text = score 'changes the textbox to show new score


    End Sub

    Private Sub pbanswer2_Click(sender As Object, e As EventArgs) Handles pbanswer2.Click

        If imagechoice(1) Is imagechoice(ranpic) And correctanswer = True Then
            score = score + 1
            imagechoice(1).Image = correct
        Else imagechoice(1).Image = incorrect
        End If
        correctanswer = False
        tbxscore.Text = score


    End Sub

    Private Sub pbanswer3_Click(sender As Object, e As EventArgs) Handles pbanswer3.Click

        If imagechoice(2) Is imagechoice(ranpic) And correctanswer = True Then
            score = score + 1
            imagechoice(2).Image = correct
        Else imagechoice(2).Image = incorrect
        End If
        correctanswer = False
        tbxscore.Text = score


    End Sub

    Private Sub pbanswer4_Click(sender As Object, e As EventArgs) Handles pbanswer4.Click

        If imagechoice(3) Is imagechoice(ranpic) And correctanswer = True Then
            score = score + 1
            imagechoice(3).Image = correct
        Else imagechoice(3).Image = incorrect
        End If
        correctanswer = False
        tbxscore.Text = score

    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click

        score = 0
        Close()

    End Sub

End Class
