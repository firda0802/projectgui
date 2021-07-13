Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class BuyOrSale
    Public aksi As String
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextNoProduct.Text = "" Or TextProductName.Text = "" Or TextAmount.Text = "" Or TextPriceUnit.Text = "" Or TextBuy.Text = "" Or TextSell.Text = "" Or TextEmployees.Text = "" Or TextTotal.Text = "" Then
            MessageBox.Show("Isi no product, product name, amount, price, buy, sell, employees, dan total terlebih dahulu!!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Call koneksi()
            str = "insert into tbl_buy_or_sell values (@no_product,@product_name,@amount,@price,@buy,@sell,@employees,@total)"
            cmd = conn.CreateCommand
            With cmd
                .CommandText = str
                .Connection = conn
                .Parameters.Add("no_product", MySqlDbType.String).Value = TextNoProduct.Text
                .Parameters.Add("product_name", MySqlDbType.String).Value = TextProductName.Text
                .Parameters.Add("amount", MySqlDbType.String).Value = TextAmount.Text
                .Parameters.Add("price", MySqlDbType.String).Value = TextPriceUnit.Text
                .Parameters.Add("buy", MySqlDbType.String).Value = TextBuy.Text
                .Parameters.Add("sell", MySqlDbType.String).Value = TextSell.Text
                .Parameters.Add("employees", MySqlDbType.String).Value = TextEmployees.Text
                .Parameters.Add("total", MySqlDbType.String).Value = TextTotal.Text
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Data berhasil disimpan!!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DashboardKedua.Show()
            Call bersih()
            Me.Close()
        End If
    End Sub
    Sub bersih()
        TextNoProduct.Text = ""
        TextProductName.Text = ""
        TextAmount.Text = ""
        TextPriceUnit.Text = ""
        TextBuy.Text = ""
        TextSell.Text = ""
        TextEmployees.Text = ""
        TextTotal.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DashboardKedua.Show()
        Me.Close()
    End Sub

    Private Sub TextSell_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextSell.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
        If TextSell.Text = "" Or Not IsNumeric(TextSell.Text) Then
            Exit Sub
        End If
    End Sub

    Private Sub BuyOrSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextTotal.Enabled = False
        TextNoProduct.Enabled = False
        Call koneksi()
        cmd = New MySqlCommand("select * from tbl_buy_or_sell order by no_product desc", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            TextNoProduct.Text = "PR" + "0001"
        Else
            TextNoProduct.Text = Val(Microsoft.VisualBasic.Mid(rd.Item("no_product").ToString, 4, 3)) + 1
            If Len(TextNoProduct.Text) = 1 Then
                TextNoProduct.Text = "PR000" & TextNoProduct.Text & ""
            ElseIf Len(TextNoProduct.Text) = 2 Then
                TextNoProduct.Text = "PR00" & TextNoProduct.Text & ""
            ElseIf Len(TextNoProduct.Text) = 3 Then
                TextNoProduct.Text = "PR0" & TextNoProduct.Text & ""
            End If
        End If
    End Sub

    Private Sub TextAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextAmount.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
        If TextAmount.Text = "" Or Not IsNumeric(TextAmount.Text) Then
            Exit Sub
        End If
    End Sub

    Private Sub TextPriceUnit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextPriceUnit.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
        If TextPriceUnit.Text = "" Or Not IsNumeric(TextPriceUnit.Text) Then
            Exit Sub
        End If
    End Sub

    Private Sub TextBuy_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBuy.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
        If TextBuy.Text = "" Or Not IsNumeric(TextBuy.Text) Then
            Exit Sub
        End If
        TextTotal.Text = Val(TextPriceUnit.Text) * Val(TextBuy.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PPD.Document = PD
        PPD.ShowDialog()
        'PD.Print()
    End Sub

    Private Sub PD_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 250)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PD.PrintPage
        Call koneksi()
        cmd = New MySqlCommand("select * from tbl_buy_or_sell order by no_product desc limit 1", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f14 As New Font("Times New Roman", 10, FontStyle.Regular)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "---------------------------------------------------------------"

        e.Graphics.DrawString("PT. DAVCO SENDAWAR INDUSTRI", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Kp. Rejo Basuki, Kec. Barong Tongkok", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("BUY OR SELL", f14, Brushes.Black, centermargin, 45, tengah)

        e.Graphics.DrawString("No Product", f10, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f10, Brushes.Black, 65, 60)
        e.Graphics.DrawString(rd.Item(0), f10, Brushes.Black, 70, 60)

        e.Graphics.DrawString("Product Name", f10, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f10, Brushes.Black, 85, 75)
        e.Graphics.DrawString(rd.Item(1), f10, Brushes.Black, 90, 75)

        e.Graphics.DrawString("Employee Who Input", f10, Brushes.Black, 0, 90)
        e.Graphics.DrawString(":", f10, Brushes.Black, 125, 90)
        e.Graphics.DrawString(rd.Item(6), f10, Brushes.Black, 135, 90)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 105)

        e.Graphics.DrawString("Amount", f10, Brushes.Black, 0, 120)
        e.Graphics.DrawString(":", f10, Brushes.Black, 100, 120)
        e.Graphics.DrawString(rd.Item(2), f10, Brushes.Black, 105, 120)

        e.Graphics.DrawString("Price", f10, Brushes.Black, 0, 135)
        e.Graphics.DrawString(":", f10, Brushes.Black, 105, 135)
        e.Graphics.DrawString(rd.Item(3), f10, Brushes.Black, 115, 135)

        e.Graphics.DrawString("Buy", f10, Brushes.Black, 0, 145)
        e.Graphics.DrawString(":", f10, Brushes.Black, 105, 145)
        e.Graphics.DrawString(rd.Item(4), f10, Brushes.Black, 115, 145)

        e.Graphics.DrawString("Sell", f10, Brushes.Black, 0, 155)
        e.Graphics.DrawString(":", f10, Brushes.Black, 105, 155)
        e.Graphics.DrawString(rd.Item(5), f10, Brushes.Black, 115, 155)

        e.Graphics.DrawString("Total Price", f10, Brushes.Black, 0, 165)
        e.Graphics.DrawString(":", f10, Brushes.Black, 105, 165)
        e.Graphics.DrawString(rd.Item(7), f10, Brushes.Black, 115, 165)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 175)
    End Sub
End Class