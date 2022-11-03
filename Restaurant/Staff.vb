Imports System.Data.SqlClient
Public Class Staff
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marquez\Documents\VS projekti\Restoran\RestDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        Dim pocetna As New Login
        pocetna.Show()
        Me.Hide()
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles pProizv.Click
        Dim Obj As New items
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub
    Private Sub ResetS()
        RIme.Text = ""
        RSpol.SelectedIndex = 0
        RLoz.Text = ""
        RPla.Text = ""
    End Sub
    Private Sub populate()
        Con.Open()
        Dim sql = "select * from StaffTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        StaffDG.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        If RIme.Text = "" Or RSpol.SelectedIndex = -1 Or RLoz.Text = "" Or RPla.Text = "" Then
            MsgBox("Error. Enter the required data!")
        Else
            Con.Open()
            Dim query = "insert into StaffTbl values ('" & RIme.Text & "', '" & RSpol.SelectedItem.ToString() & "', '" & RLoz.Text & "', '" & RPla.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Employee added to database!")
            Con.Close()
            ResetS()
            populate()
        End If
    End Sub
    Dim key = 0
    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        If key = 0 Then
            MsgBox("Error. Choose an employee!")
        Else
            Con.Open()
            Dim query = "delete from StaffTbl where Rb=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Employee deleted from database!")
            Con.Close()
            ResetS()
            populate()
        End If
    End Sub

    Private Sub StaffDG_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles StaffDG.CellMouseClick
        Dim row As DataGridViewRow = StaffDG.Rows(e.RowIndex)
        RIme.Text = row.Cells(1).Value.ToString
        RSpol.SelectedItem = row.Cells(2).Value.ToString
        RLoz.Text = row.Cells(3).Value.ToString
        RPla.Text = row.Cells(4).Value.ToString
        If RIme.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub
    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        ResetS()
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        If RIme.Text = "" Or RSpol.SelectedIndex = -1 Or RLoz.Text = "" Or RPla.Text = "" Or key = 0 Then
            MsgBox("Error. Choose an employee!")
        Else
            Try
                Con.Open()
                Dim query = "update StaffTbl set Employee='" & RIme.Text & "', Gender='" & RSpol.SelectedItem.ToString() & "', Password='" & RLoz.Text & "', Salary='" & RPla.Text & "' where Rb=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Change successful!")
                Con.Close()
                ResetS()
                populate()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class