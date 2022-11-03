Public Class AdminLogin
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub

    Private Sub ALBtn_Click(sender As Object, e As EventArgs) Handles ALBtn.Click
        If LozinkaA.Text = "admin" Then
            Dim addstaff As New Staff
            addstaff.Show()
            Me.Hide()
        Else
            MsgBox("Wrong password, try again!")
        End If
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If Guna2CheckBox1.CheckState = CheckState.Checked Then
            LozinkaA.PasswordChar = ""
        Else
            LozinkaA.PasswordChar = "*"
        End If
    End Sub
End Class