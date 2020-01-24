Public Class Calculator

    Dim mathOperator As Char = "n"
    Dim total1 As String = ""
    Dim total2 As String = ""
    Dim opt As Boolean = False
    Dim oprnd As Boolean = False

    Private Sub calculator_keypress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case "0"
                Btnzero_Click(sender, e)
            Case "1"
                BtnOne_Click(sender, e)
            Case "2"
                BtnTwo_Click(sender, e)
            Case "3"
                BtnThree_Click(sender, e)
            Case "4"
                BtnFour_Click(sender, e)
            Case "5"
                BtnFive_Click(sender, e)
            Case "6"
                BtnSix_Click(sender, e)
            Case "7"
                BtnSeven_Click(sender, e)
            Case "8"
                BtnEight_Click(sender, e)
            Case "9"
                BtnNine_Click(sender, e)
            Case "."
                Btnpoint_Click(sender, e)
            Case "/"
                btndivide_Click(sender, e)
            Case "*"
                btntimes_Click(sender, e)
            Case "-"
                btnminus_Click(sender, e)
            Case "+"
                BtnPlus_Click(sender, e)
            Case "="
                BtnEquals_Click(sender, e)
            Case ChrW(13)
                BtnEquals_Click(sender, e)
            Case "c"
                BtnClear_Click(sender, e)
            Case Else
                MsgBox("invalid option")
        End Select
    End Sub

    Private Sub Btnzero_Click(sender As Object, e As EventArgs) Handles Btnzero.Click
        If opt = True Then
            TxtDisplay.Text = ""
            opt = False
        End If
        TxtDisplay.Text = TxtDisplay.Text & "0"
        oprnd = True
    End Sub

    Private Sub BtnOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOne.Click
        If opt = True Then
            TxtDisplay.Text = ""
            opt = False
        End If
        TxtDisplay.Text = TxtDisplay.Text & "1"
        oprnd = True
    End Sub

    Private Sub BtnTwo_Click(sender As Object, e As EventArgs) Handles BtnTwo.Click
        If opt = True Then
            TxtDisplay.Text = ""
            opt = False
        End If
        TxtDisplay.Text = TxtDisplay.Text & "2"
        oprnd = True
    End Sub

    Private Sub BtnThree_Click(sender As Object, e As EventArgs) Handles BtnThree.Click
        If opt = True Then
            TxtDisplay.Text = ""
            opt = False
        End If
        TxtDisplay.Text = TxtDisplay.Text & "3"
        oprnd = True
    End Sub

    Private Sub BtnFour_Click(sender As Object, e As EventArgs) Handles BtnFour.Click
        If opt = True Then
            TxtDisplay.Text = ""
            opt = False
        End If
        TxtDisplay.Text = TxtDisplay.Text & "4"
        oprnd = True
    End Sub

    Private Sub BtnFive_Click(sender As Object, e As EventArgs) Handles BtnFive.Click
        If opt = True Then
            TxtDisplay.Text = ""
            opt = False
        End If
        TxtDisplay.Text = TxtDisplay.Text & "5"
        oprnd = True
    End Sub

    Private Sub BtnSix_Click(sender As Object, e As EventArgs) Handles BtnSix.Click
        If opt = True Then
            TxtDisplay.Text = ""
            opt = False
        End If
        TxtDisplay.Text = TxtDisplay.Text & "6"
        oprnd = True
    End Sub

    Private Sub BtnSeven_Click(sender As Object, e As EventArgs) Handles BtnSeven.Click
        If opt = True Then
            TxtDisplay.Text = ""
            opt = False
        End If
        TxtDisplay.Text = TxtDisplay.Text & "7"
        oprnd = True
    End Sub

    Private Sub BtnEight_Click(sender As Object, e As EventArgs) Handles BtnEight.Click
        If opt = True Then
            TxtDisplay.Text = ""
            opt = False
        End If
        TxtDisplay.Text = TxtDisplay.Text & "8"
        oprnd = True
    End Sub

    Private Sub BtnNine_Click(sender As Object, e As EventArgs) Handles BtnNine.Click
        If opt = True Then
            TxtDisplay.Text = ""
            opt = False
        End If
        TxtDisplay.Text = TxtDisplay.Text & "9"
        oprnd = True
    End Sub

    Private Sub Btnpoint_Click(sender As Object, e As EventArgs) Handles Btnpoint.Click
        If opt = True Then
            TxtDisplay.Text = ""
            opt = False
        End If

        TxtDisplay.Text = TxtDisplay.Text & "."
        oprnd = True
    End Sub

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click
        If oprnd = True Then
            BtnEquals_Click(sender, e)
        End If

        mathOperator = "+"

        opt = True
        total1 = TxtDisplay.Text
    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        If oprnd = True Then
            BtnEquals_Click(sender, e)
        End If

        mathOperator = "-"

        opt = True
        total1 = TxtDisplay.Text

    End Sub

    Private Sub btntimes_Click(sender As Object, e As EventArgs) Handles btntimes.Click
        If oprnd = True Then
            BtnEquals_Click(sender, e)
        End If

        mathOperator = "*"

        opt = True
        total1 = TxtDisplay.Text

    End Sub

    Private Sub btndivide_Click(sender As Object, e As EventArgs) Handles btndivide.Click
        If oprnd = True Then
            BtnEquals_Click(sender, e)
        End If

        mathOperator = "/"

        opt = True
        total1 = TxtDisplay.Text

    End Sub

    Private Sub BtnEquals_Click(sender As Object, e As EventArgs) Handles BtnEquals.Click
        operations()
    End Sub

    Public Sub operations()
        Try
            Select Case mathOperator
                Case "+"
                    total2 = TxtDisplay.Text
                    TxtDisplay.Text = (Convert.ToDouble(total1) + Convert.ToDouble(total2)).ToString
                    oprnd = False
                    opt = False
                    mathOperator = "n"

                Case "-"
                    total2 = TxtDisplay.Text
                    TxtDisplay.Text = (Convert.ToDouble(total1) - Convert.ToDouble(total2)).ToString
                    oprnd = False
                    opt = False
                    mathOperator = "n"

                Case "*"
                    total2 = TxtDisplay.Text
                    TxtDisplay.Text = (Convert.ToDouble(total1) * Convert.ToDouble(total2)).ToString
                    oprnd = False
                    opt = False
                    mathOperator = "n"

                Case "/"
                    total2 = TxtDisplay.Text
                    If total2 <> 0 Then
                        TxtDisplay.Text = (Convert.ToDouble(total1) / Convert.ToDouble(total2)).ToString
                        oprnd = False
                        opt = False
                        mathOperator = "n"

                    Else
                        TxtDisplay.Text = "Divide by zero error"
                    End If
            End Select
        Catch
            MessageBox.Show("error Occured")
        End Try
    End Sub

    Private Sub txtdisplay_keyup(sender As Object, e As KeyEventArgs) Handles TxtDisplay.KeyUp
        If e.KeyCode > Keys.D0 And e.KeyCode < Keys.D9 Then
            TxtDisplay.Text = TxtDisplay.Text
        End If
    End Sub

    Private Sub calculator_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Delete Then
            TxtDisplay.Text = ""
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtDisplay.Text = ""
        total1 = 0
        total2 = 0
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close() 'closes the calculatur
    End Sub

End Class
