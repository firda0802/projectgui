Imports MySql.Data.MySqlClient
Public Class ViewDatabase

    Private Sub ViewDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilDataEmployee()
        Call TampilDataBuyOrSell()
        Call TampilDataProdukData()
        Call AturDGV1()
        Call AturDGV2()
        Call AturDGV3()
    End Sub
    Sub TampilDataEmployee()

        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_new_employee", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_new_employee")
        DataGridView1.DataSource = ds.Tables(0)

    End Sub
    Sub TampilDataBuyOrSell()

        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_buy_or_sell", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_buy_or_sell")
        DataGridView2.DataSource = ds.Tables(0)

    End Sub
    Sub TampilDataProdukData()

        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_product", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_product")
        DataGridView3.DataSource = ds.Tables(0)

    End Sub

    Sub AturDGV1()
        Try
            DataGridView1.Columns(0).Width = 70
            DataGridView1.Columns(1).Width = 130
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 150
            DataGridView1.Columns(4).Width = 150
            DataGridView1.Columns(5).Width = 150
            DataGridView1.Columns(6).Width = 150
            DataGridView1.Columns(0).HeaderText = "No Employee"
            DataGridView1.Columns(1).HeaderText = "Employee Name"
            DataGridView1.Columns(2).HeaderText = "Position"
            DataGridView1.Columns(3).HeaderText = "Date Started Work"
            DataGridView1.Columns(4).HeaderText = "Departement"
            DataGridView1.Columns(5).HeaderText = "Basic Pay"
            DataGridView1.Columns(6).HeaderText = "Positional Allowance"
        Catch ex As Exception
        End Try
    End Sub

    Sub AturDGV2()
        Try
            DataGridView2.Columns(0).Width = 70
            DataGridView2.Columns(1).Width = 130
            DataGridView2.Columns(2).Width = 100
            DataGridView2.Columns(3).Width = 150
            DataGridView2.Columns(4).Width = 150
            DataGridView2.Columns(5).Width = 150
            DataGridView2.Columns(6).Width = 150
            DataGridView2.Columns(7).Width = 150
            DataGridView2.Columns(0).HeaderText = "No Product"
            DataGridView2.Columns(1).HeaderText = "Product Name"
            DataGridView2.Columns(2).HeaderText = "Amount"
            DataGridView2.Columns(3).HeaderText = "Price"
            DataGridView2.Columns(4).HeaderText = "Buy"
            DataGridView2.Columns(5).HeaderText = "Sell"
            DataGridView2.Columns(6).HeaderText = "Employees Who Input"
            DataGridView2.Columns(7).HeaderText = "Total"
        Catch ex As Exception
        End Try
    End Sub

    Sub AturDGV3()
        Try
            DataGridView3.Columns(0).Width = 70
            DataGridView3.Columns(1).Width = 130
            DataGridView3.Columns(2).Width = 100
            DataGridView3.Columns(3).Width = 150
            DataGridView3.Columns(4).Width = 150
            DataGridView3.Columns(5).Width = 150
            DataGridView3.Columns(6).Width = 150
            DataGridView3.Columns(7).Width = 150
            DataGridView3.Columns(0).HeaderText = "No Product"
            DataGridView3.Columns(1).HeaderText = "Product Name"
            DataGridView3.Columns(2).HeaderText = "Amount"
            DataGridView3.Columns(3).HeaderText = "Price"
            DataGridView3.Columns(4).HeaderText = "Product In"
            DataGridView3.Columns(5).HeaderText = "Product Out"
            DataGridView3.Columns(6).HeaderText = "Employees Input"
            DataGridView3.Columns(7).HeaderText = "Total Product"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        NewEmployeeInput.TextNoEmployee.Text = DataGridView1.Item(0, i).Value
        NewEmployeeInput.TextEmployeeName.Text = DataGridView1.Item(1, i).Value
        NewEmployeeInput.ComboBoxPosition.Text = DataGridView1.Item(2, i).Value
        NewEmployeeInput.DateTimePickerStartedWork.Value = DataGridView1.Item(3, i).Value
        NewEmployeeInput.ComboBoxDepartement.Text = DataGridView1.Item(4, i).Value
        NewEmployeeInput.TextBasicPay.Text = DataGridView1.Item(5, i).Value
        NewEmployeeInput.ComboBoxPositional.Text = DataGridView1.Item(6, i).Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        NewEmployeeInput.Show()
        NewEmployeeInput.aksi = "edit"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim tanya
        tanya = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = vbYes Then
            Call koneksi()
            cmd = New MySqlCommand
            cmd.Connection = conn
            str = "delete from tbl_new_employee where no_employee='" & NewEmployeeInput.TextNoEmployee.Text & "'"
            cmd.CommandText = str
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus!!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TampilDataEmployee()
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BuyOrSale.Show()
        BuyOrSale.aksi = "edit"
    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim i As Integer
        i = DataGridView2.CurrentRow.Index
        BuyOrSale.TextNoProduct.Text = DataGridView2.Item(0, i).Value
        BuyOrSale.TextProductName.Text = DataGridView2.Item(1, i).Value
        BuyOrSale.TextAmount.Text = DataGridView2.Item(2, i).Value
        BuyOrSale.TextPriceUnit.Text = DataGridView2.Item(3, i).Value
        BuyOrSale.TextBuy.Text = DataGridView2.Item(4, i).Value
        BuyOrSale.TextSell.Text = DataGridView2.Item(5, i).Value
        BuyOrSale.TextEmployees.Text = DataGridView2.Item(6, i).Value
        BuyOrSale.TextTotal.Text = DataGridView2.Item(7, i).Value
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim tanya
        tanya = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = vbYes Then
            Call koneksi()
            cmd = New MySqlCommand
            cmd.Connection = conn
            str = "delete from tbl_buy_or_sell where no_product='" & BuyOrSale.TextNoProduct.Text & "'"
            cmd.CommandText = str
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus!!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TampilDataBuyOrSell()
        End If
    End Sub

    Private Sub DataGridView3_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        ProductData.TextNoProduct.Text = DataGridView3.Item(0, i).Value
        ProductData.TextProductName.Text = DataGridView3.Item(1, i).Value
        ProductData.TextAmount.Text = DataGridView3.Item(2, i).Value
        ProductData.TextPrice.Text = DataGridView3.Item(3, i).Value
        ProductData.TextProductIn.Text = DataGridView3.Item(4, i).Value
        ProductData.TextProductOut.Text = DataGridView3.Item(5, i).Value
        ProductData.TextEmployees.Text = DataGridView3.Item(6, i).Value
        ProductData.TextTotal.Text = DataGridView3.Item(7, i).Value
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ProductData.Show()
        ProductData.aksi = "edit"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim tanya
        tanya = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = vbYes Then
            Call koneksi()
            cmd = New MySqlCommand
            cmd.Connection = conn
            str = "delete from tbl_product where no_product='" & ProductData.TextNoProduct.Text & "'"
            cmd.CommandText = str
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus!!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TampilDataProdukData()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        DashboardKedua.Show()
        Me.Close()
    End Sub
End Class