Imports System.Data.SqlClient
Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim Adm As New AdminLogin
        Adm.Show()
        Me.Hide()
    End Sub
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub

    Private Sub CheckBoxx_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxx.CheckedChanged
        If CheckBoxx.CheckState = CheckState.Checked Then
            LozinkaU.PasswordChar = ""
        Else
            LozinkaU.PasswordChar = "*"
        End If
    End Sub
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marquez\Documents\VS projekti\Restoran\RestDb.mdf;Integrated Security=True;Connect Timeout=2")
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        If UName.Text = "" Or LozinkaU.Text = "" Then
            MsgBox("Error. Enter all data!")
        Else
            Con.Open()
            Dim query = "select * from StaffTbl where Employee ='" & UName.Text & "' And Password ='" & LozinkaU.Text & "'"
            Dim cmd = New SqlCommand(query, Con)
            Dim da = New SqlDataAdapter(cmd)
            Dim ds = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Wrong username or password, try again!")
            Else
                Dim proit = New SItems
                proit.Show()
                Me.Hide()
            End If
            Con.Close()
        End If
    End Sub
End Class