Public Class timetablefm
    Dim mult As Integer
    Dim rows As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btngo_Click(sender As Object, e As EventArgs) Handles btngo.Click
        Try
            mult = tbxmult.Text 'check numbers are inputted
            rows = tbxrows.Text 'checks numbers are inputted
        Catch
            MessageBox.Show("Please enter number") 'if numbers arent inputted show a message
        End Try

        For n = 1 To rows
            tbxresults.AppendText(n & "x" & mult & "=" & n * mult & vbCrLf) 'displays a list of the times table requested

        Next
    End Sub

    Private Sub Btnzero_Click(sender As Object, e As EventArgs) Handles Btnzero.Click
        tbxmult.Text = tbxmult.Text & Btnzero.Text 'sets the display to recognise what buttons are pressed (on screen) for the first input box
    End Sub

    Private Sub BtnOne_Click(sender As Object, e As EventArgs) Handles BtnOne.Click
        tbxmult.Text = tbxmult.Text & BtnOne.Text
    End Sub

    Private Sub BtnTwo_Click(sender As Object, e As EventArgs) Handles BtnTwo.Click
        tbxmult.Text = tbxmult.Text & BtnTwo.Text
    End Sub

    Private Sub BtnThree_Click(sender As Object, e As EventArgs) Handles BtnThree.Click
        tbxmult.Text = tbxmult.Text & BtnThree.Text
    End Sub

    Private Sub BtnFour_Click(sender As Object, e As EventArgs) Handles BtnFour.Click
        tbxmult.Text = tbxmult.Text & BtnFour.Text
    End Sub

    Private Sub BtnFive_Click(sender As Object, e As EventArgs) Handles BtnFive.Click
        tbxmult.Text = tbxmult.Text & BtnFive.Text
    End Sub

    Private Sub BtnSix_Click(sender As Object, e As EventArgs) Handles BtnSix.Click
        tbxmult.Text = tbxmult.Text & BtnSix.Text
    End Sub

    Private Sub BtnSeven_Click(sender As Object, e As EventArgs) Handles BtnSeven.Click
        tbxmult.Text = tbxmult.Text & BtnSeven.Text
    End Sub

    Private Sub BtnEight_Click(sender As Object, e As EventArgs) Handles BtnEight.Click
        tbxmult.Text = tbxmult.Text & BtnEight.Text
    End Sub

    Private Sub BtnNine_Click(sender As Object, e As EventArgs) Handles BtnNine.Click
        tbxmult.Text = tbxmult.Text & BtnNine.Text
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        tbxrows.Text = tbxrows.Text & btn0.Text 'sets the display to recognise what buttons are pressed (on screen) for the second input box
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        tbxrows.Text = tbxrows.Text & Btn1.Text
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        tbxrows.Text = tbxrows.Text & Btn2.Text
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        tbxrows.Text = tbxrows.Text & btn3.Text
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        tbxrows.Text = tbxrows.Text & btn4.Text
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        tbxrows.Text = tbxrows.Text & btn5.Text
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        tbxrows.Text = tbxrows.Text & btn6.Text
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        tbxrows.Text = tbxrows.Text & btn7.Text
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        tbxrows.Text = tbxrows.Text & btn8.Text
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        tbxrows.Text = tbxrows.Text & btn9.Text
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Hide() 'closes the game
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tbxmult.Clear() 'clears all boxes
        tbxrows.Clear()
        tbxresults.Clear()
    End Sub

End Class
