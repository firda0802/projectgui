Imports MySql.Data.MySqlClient
Public Class ProductData
    Public aksi As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextNoProduct.Text = "" Or TextProductName.Text = "" Or TextAmount.Text = "" Or TextPrice.Text = "" Or TextProductIn.Text = "" Or TextProductOut.Text = "" Or TextEmployees.Text = "" Or TextTotal.Text = "" Then
            MessageBox.Show("Isi no employee, employee name, basic pay dan positional allowance terlebih dahulu!!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Call koneksi()
            str = "insert into tbl_product values (@no_product,@product_name,@amount,@price,@product_in,@product_out,@employees_input,@total_product)"
            cmd = conn.CreateCommand
            With cmd
                .CommandText = str
                .Connection = conn
                .Parameters.Add("no_product", MySqlDbType.String).Value = TextNoProduct.Text
                .Parameters.Add("product_name", MySqlDbType.String).Value = TextProductName.Text
                .Parameters.Add("amount", MySqlDbType.String).Value = TextAmount.Text
                .Parameters.Add("price", MySqlDbType.String).Value = TextPrice.Text
                .Parameters.Add("product_in", MySqlDbType.String).Value = TextProductIn.Text
                .Parameters.Add("product_out", MySqlDbType.String).Value = TextProductOut.Text
                .Parameters.Add("employees_input", MySqlDbType.String).Value = TextEmployees.Text
                .Parameters.Add("total_product", MySqlDbType.String).Value = TextTotal.Text
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
        TextPrice.Text = ""
        TextProductIn.Text = ""
        TextProductOut.Text = ""
        TextEmployees.Text = ""
        TextTotal.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DashboardKedua.Show()
        Me.Close()
    End Sub

    Private Sub TextProductOut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextProductOut.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
        If TextProductOut.Text = "" Or Not IsNumeric(TextProductOut.Text) Then
            Exit Sub
        End If
        TextTotal.Text = Val(TextAmount.Text) + Val(TextProductIn.Text) - Val(TextProductOut.Text)
    End Sub

    Private Sub ProductData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextTotal.Enabled = False
        TextNoProduct.Enabled = False
        Call koneksi()
        cmd = New MySqlCommand("select * from tbl_product order by no_product desc", conn)
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

    Private Sub TextPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextPrice.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
        If TextPrice.Text = "" Or Not IsNumeric(TextPrice.Text) Then
            Exit Sub
        End If
    End Sub

    Private Sub TextProductIn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextProductIn.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
        If TextProductIn.Text = "" Or Not IsNumeric(TextProductIn.Text) Then
            Exit Sub
        End If
    End Sub
End Class