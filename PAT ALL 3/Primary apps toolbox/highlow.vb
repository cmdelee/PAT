Public Class highlow

    Dim number As Integer
    Dim tries As Integer
    Dim guess As Integer


    Private Sub Btnzero_Click(sender As Object, e As EventArgs) Handles Btnzero.Click
        numbertxt.Text = numbertxt.Text & Btnzero.Text 'sets the display to recognise what buttons are pressed (on screen)
    End Sub

    Private Sub BtnOne_Click(sender As Object, e As EventArgs) Handles BtnOne.Click
        numbertxt.Text = numbertxt.Text & BtnOne.Text
    End Sub

    Private Sub BtnTwo_Click(sender As Object, e As EventArgs) Handles BtnTwo.Click
        numbertxt.Text = numbertxt.Text & BtnTwo.Text
    End Sub

    Private Sub BtnThree_Click(sender As Object, e As EventArgs) Handles BtnThree.Click
        numbertxt.Text = numbertxt.Text & BtnThree.Text
    End Sub

    Private Sub BtnFour_Click(sender As Object, e As EventArgs) Handles BtnFour.Click
        numbertxt.Text = numbertxt.Text & BtnFour.Text
    End Sub

    Private Sub BtnFive_Click(sender As Object, e As EventArgs) Handles BtnFive.Click
        numbertxt.Text = numbertxt.Text & BtnFive.Text
    End Sub

    Private Sub BtnSix_Click(sender As Object, e As EventArgs) Handles BtnSix.Click
        numbertxt.Text = numbertxt.Text & BtnSix.Text
    End Sub

    Private Sub BtnSeven_Click(sender As Object, e As EventArgs) Handles BtnSeven.Click
        numbertxt.Text = numbertxt.Text & BtnSeven.Text
    End Sub

    Private Sub BtnEight_Click(sender As Object, e As EventArgs) Handles BtnEight.Click
        numbertxt.Text = numbertxt.Text & BtnEight.Text
    End Sub

    Private Sub BtnNine_Click(sender As Object, e As EventArgs) Handles BtnNine.Click
        numbertxt.Text = numbertxt.Text & BtnNine.Text
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Hide()
    End Sub

    Private Sub highlow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lowpic.Visible = False 'sets all images and pictures so nothing shown on load
        highpic.Visible = False
        Correctpic.Visible = False
        highlbl.Visible = False
        lowlbl.Visible = False


    End Sub


    Private Sub fiftybtn_Click(sender As Object, e As EventArgs) Handles fiftybtn.Click

        number = CInt(Int((50 * Rnd()) + 1)) 'picks random number between 0-50
        lowpic.Visible = False 'clears all images and pictures so nothing shown ready for new game
        highpic.Visible = False
        Correctpic.Visible = False
        highlbl.Visible = False
        lowlbl.Visible = False
        historytxt.Clear() 'clears history
        attemptstbx.Clear() 'clears attempt number
        tries = 0 'zeros attempts



    End Sub

    Private Sub hundredbtn_Click(sender As Object, e As EventArgs) Handles hundredbtn.Click

        number = CInt(Int((100 * Rnd()) + 1)) 'picts random number between 0-100
        lowpic.Visible = False
        highpic.Visible = False
        Correctpic.Visible = False
        highlbl.Visible = False
        lowlbl.Visible = False
        historytxt.Clear()
        attemptstbx.Clear()
        tries = 0

    End Sub

    Private Sub fhundredbtn_Click(sender As Object, e As EventArgs) Handles fhundredbtn.Click

        number = CInt(Int((500 * Rnd()) + 1)) 'picks random number between 0-500
        lowpic.Visible = False
        highpic.Visible = False
        Correctpic.Visible = False
        highlbl.Visible = False
        lowlbl.Visible = False
        historytxt.Clear()
        attemptstbx.Clear()
        tries = 0

    End Sub

    Private Sub thousandbtn_Click(sender As Object, e As EventArgs) Handles thousandbtn.Click

        number = CInt(Int((1000 * Rnd()) + 1)) 'picks random number between 0-1000
        lowpic.Visible = False
        highpic.Visible = False
        Correctpic.Visible = False
        highlbl.Visible = False
        lowlbl.Visible = False
        historytxt.Clear()
        attemptstbx.Clear()
        tries = 0

    End Sub


    Private Sub enterbtn_Click(sender As System.Object, ByVal e As EventArgs) Handles enterbtn.Click
        Try
            guess = numbertxt.Text 'checks that number is inputted

        Catch
            MessageBox.Show("Please enter number") 'if number not inputted then brings up box saying use number
            Correctpic.Visible = False
            lowpic.Visible = False
            highpic.Visible = False
            highlbl.Visible = False
            lowlbl.Visible = False
            tries = tries - 1
        End Try

        tries = tries + 1 'adds 1 to the amount of tries
        attemptstbx.Text = tries 'shows the amount of tries in the text box

        historytxt.AppendText(guess & vbCrLf) 'shows recent tries in the text box

        If guess = number Then 'checks if the try is the correct random number
            Correctpic.Visible = True 'changes the image to a tick
            lowpic.Visible = False 'stops displaying other images
            highpic.Visible = False
            highlbl.Visible = False 'stops displaying other lables
            lowlbl.Visible = False
        ElseIf guess > number Then 'checks if the try is higher than the number
            lowpic.Visible = False 'stops displaying the too low image
            highpic.Visible = True 'displays the too high image
            highlbl.Visible = True 'displays the too high label
            lowlbl.Visible = False 'stops displaying the too low lable
        ElseIf guess < number Then 'checks if the try is lower than the number
            highpic.Visible = False 'tops displaying the too high image
            lowpic.Visible = True 'displays the too low image
            highlbl.Visible = False 'stops displaying the high label
            lowlbl.Visible = True 'displays the too low label
        End If

        numbertxt.Clear() 'clears the textbox

    End Sub

    Private Sub numbertxt_TextChanged(sender As Object, e As EventArgs) Handles numbertxt.TextChanged
        AcceptButton = enterbtn 'accepts enter as a command for keyboard use
    End Sub
End Class
