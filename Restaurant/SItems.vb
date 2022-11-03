Imports System.Data.SqlClient
Public Class SItems
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marquez\Documents\VS projekti\Restoran\RestDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        Dim pocetna As New Login
        pocetna.Show()
        Me.Hide()
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        Dim pracuna As New ViewOrders
        pracuna.Show()
        Me.Hide()
    End Sub
    Private Sub FillCategory()
        Con.Open()
        Dim cmd = New SqlCommand("select * from CategoryTbl", Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim Tbl = New DataTable()
        adapter.Fill(Tbl)
        Kate.DataSource = Tbl
        Kate.DisplayMember = "KATi"
        Kate.ValueMember = "KATi"
        Con.Close()
    End Sub
    Private Sub DisplayItem()
        Con.Open()
        Dim query = "select * from ItemsTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub SItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
        FillCategory()
    End Sub
    Private Sub FilterByCategory()
        Con.Open()
        Dim query = "select * from ItemsTbl where Category='" & Kate.SelectedValue.ToString() & "'"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Kate_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Kate.SelectionChangeCommitted
        FilterByCategory()
    End Sub
    Private Sub ResetP()
        Kate.SelectedIndex = 0
        Kol.Text = ""
    End Sub
    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        ResetP()
        DisplayItem()
    End Sub
    Dim ProName As String
    Dim i = 0, GrdTotal = 0, cijena, kolicina
    Private Sub AddBill()
        Con.Open()
        Dim query = "insert into OrderTbl values ('" & DateTime.Today.Date & "', " & GrdTotal & ")"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Bill added!")
        Con.Close()
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        AddBill()
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Restaurant Allegro", New Font("Arial", 22), Brushes.Black, 287, 35)
        e.Graphics.DrawString("*** Your bill ***", New Font("Arial", 14), Brushes.Black, 347, 65)
        Dim bm As New Bitmap(Me.BillDGV.Width, Me.BillDGV.Height)
        BillDGV.DrawToBitmap(bm, New Rectangle(0, 0, Me.BillDGV.Width, Me.BillDGV.Height))
        e.Graphics.DrawImage(bm, 17, 150)
        e.Graphics.DrawString("Total (EUR) " + GrdTotal.ToString(), New Font("Arial", 15), Brushes.Black, 289, 460)
        e.Graphics.DrawString("*** Thank you for your purchase ***", New Font("Arial", 15), Brushes.Black, 260, 485)
    End Sub
    Private Sub UpdateItem()
        Try
            Dim newQty = stock - Convert.ToInt32(Kol.Text)
            Con.Open()
            Dim query = "update ItemsTbl set Quantity=" & newQty & " where ID=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Product status changed!")
            Con.Close()
            DisplayItem()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub AddBillBtn_Click(sender As Object, e As EventArgs) Handles AddBillBtn.Click
        If key = 0 Then
            MsgBox("Error. Choose a product!")
        ElseIf Convert.ToInt32(Kol.Text) > stock Then
            MsgBox("Error. Not enough stock!")
        Else
            Dim rnum As Integer = BillDGV.Rows.Add()
            Dim ukupno = Convert.ToInt32(Kol.Text) * cijena
            i = i + 1
            BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillDGV.Rows.Item(rnum).Cells("Column2").Value = ProName
            BillDGV.Rows.Item(rnum).Cells("Column3").Value = cijena
            BillDGV.Rows.Item(rnum).Cells("Column4").Value = Kol.Text
            BillDGV.Rows.Item(rnum).Cells("Column5").Value = ukupno
            GrdTotal = GrdTotal + ukupno
            UkupnoC.Text = "Total EUR " + Convert.ToString(GrdTotal)
            UpdateItem()
            UkupnoC.Text = ""
            key = 0
        End If
    End Sub

    Dim key = 0, stock
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ProName = row.Cells(1).Value.ToString
        If ProName = "" Then
            key = 0
            stock = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            stock = Convert.ToInt32(row.Cells(4).Value.ToString)
            cijena = Convert.ToInt32(row.Cells(3).Value.ToString)
        End If
    End Sub
End Class