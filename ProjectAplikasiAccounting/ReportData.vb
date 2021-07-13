Imports MySql.Data.MySqlClient
Public Class ReportData

    Private Sub ReportData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilDataEmployee()
        Call TampilDataAttedance()
        Call TampilDataBuyOrSell()
        Call TampilDataProdukData()
        Call TampilDataPaymentSlip()
        Call AturDGV1()
        Call AturDGV2()
        Call AturDGV3()
        Call AturDGV4()
        Call AturDGV5()
    End Sub
    Sub TampilDataEmployee()

        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_new_employee", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_new_employee")
        DataGridView1.DataSource = ds.Tables(0)

    End Sub
    Sub TampilDataAttedance()

        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_attedance_list", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_attedance_list")
        DataGridView2.DataSource = ds.Tables(0)

    End Sub
    Sub TampilDataBuyOrSell()

        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_buy_or_sell", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_buy_or_sell")
        DataGridView3.DataSource = ds.Tables(0)

    End Sub
    Sub TampilDataProdukData()

        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_product", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_product")
        DataGridView4.DataSource = ds.Tables(0)

    End Sub

    Sub TampilDataPaymentSlip()

        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_payment_slip", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_payment_slip")
        DataGridView5.DataSource = ds.Tables(0)

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
            DataGridView2.Columns(0).HeaderText = "No Employee"
            DataGridView2.Columns(1).HeaderText = "Employee Name"
            DataGridView2.Columns(2).HeaderText = "Position"
            DataGridView2.Columns(3).HeaderText = "Attedance (H/A)"
            DataGridView2.Columns(4).HeaderText = "Time To Work (Day)"
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
            DataGridView3.Columns(4).HeaderText = "Buy"
            DataGridView3.Columns(5).HeaderText = "Sell"
            DataGridView3.Columns(6).HeaderText = "Employees Who Input"
            DataGridView3.Columns(7).HeaderText = "Total"
        Catch ex As Exception
        End Try
    End Sub

    Sub AturDGV4()
        Try
            DataGridView4.Columns(0).Width = 70
            DataGridView4.Columns(1).Width = 130
            DataGridView4.Columns(2).Width = 100
            DataGridView4.Columns(3).Width = 150
            DataGridView4.Columns(4).Width = 150
            DataGridView4.Columns(5).Width = 150
            DataGridView4.Columns(6).Width = 150
            DataGridView4.Columns(7).Width = 150
            DataGridView4.Columns(0).HeaderText = "No Product"
            DataGridView4.Columns(1).HeaderText = "Product Name"
            DataGridView4.Columns(2).HeaderText = "Amount"
            DataGridView4.Columns(3).HeaderText = "Price"
            DataGridView4.Columns(4).HeaderText = "Product In"
            DataGridView4.Columns(5).HeaderText = "Product Out"
            DataGridView4.Columns(6).HeaderText = "Employees Input"
            DataGridView4.Columns(7).HeaderText = "Total Product"
        Catch ex As Exception
        End Try
    End Sub

    Sub AturDGV5()
        Try
            DataGridView5.Columns(0).Width = 70
            DataGridView5.Columns(1).Width = 130
            DataGridView5.Columns(2).Width = 100
            DataGridView5.Columns(3).Width = 150
            DataGridView5.Columns(4).Width = 150
            DataGridView5.Columns(5).Width = 150
            DataGridView5.Columns(6).Width = 150
            DataGridView5.Columns(7).Width = 150
            DataGridView5.Columns(8).Width = 150
            DataGridView5.Columns(9).Width = 150
            DataGridView5.Columns(10).Width = 150
            DataGridView5.Columns(11).Width = 150
            DataGridView5.Columns(12).Width = 150
            DataGridView5.Columns(13).Width = 150
            DataGridView5.Columns(14).Width = 150
            DataGridView5.Columns(15).Width = 150
            DataGridView5.Columns(16).Width = 150
            DataGridView5.Columns(0).HeaderText = "No Slip"
            DataGridView5.Columns(1).HeaderText = "No Employee"
            DataGridView5.Columns(2).HeaderText = "Employee Name"
            DataGridView5.Columns(3).HeaderText = "Position"
            DataGridView5.Columns(4).HeaderText = "Date Started Work"
            DataGridView5.Columns(5).HeaderText = "Departement"
            DataGridView5.Columns(6).HeaderText = "Basic Pay"
            DataGridView5.Columns(7).HeaderText = "Overtime"
            DataGridView5.Columns(8).HeaderText = "Positional Allowance"
            DataGridView5.Columns(9).HeaderText = "Intensive Attedance"
            DataGridView5.Columns(10).HeaderText = "Orther Allowance"
            DataGridView5.Columns(11).HeaderText = "Bonus"
            DataGridView5.Columns(12).HeaderText = "Attedance"
            DataGridView5.Columns(13).HeaderText = "Orther Salary"
            DataGridView5.Columns(14).HeaderText = "Jamsostek"
            DataGridView5.Columns(15).HeaderText = "PPH Pasal 22"
            DataGridView5.Columns(16).HeaderText = "Orther Jamsostek"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DataGridView1.RowCount > 0 Then
            'Deklarasi Object
            Dim ApExcel As Object

            'Set sebagai excel  object
            ApExcel = CreateObject("Excel.application")

            'Menyembunyikan proses excel
            ApExcel.Visible = False

            'Membuat/menambah workbook baru
            ApExcel.Workbooks.Add()

            'Lebar Kolom
            ApExcel.Columns(1).ColumnWidth = 15
            ApExcel.Columns(2).ColumnWidth = 20

            'Tulis nama kolom ke excel
            For i As Integer = 1 To DataGridView1.Columns.Count
                ApExcel.Cells(1, i).Value = DataGridView1.Columns(i - 1).Name
            Next

            'Tulis data ke excel
            For r = 0 To DataGridView1.RowCount - 1
                For i As Integer = 1 To DataGridView1.Columns.Count
                    ApExcel.Cells(r + 2, i).Value = DataGridView1.Rows(r).Cells(i - 1).Value
                Next
            Next

            'Membuat Font Bold
            ApExcel.Range("A1:G1").Font.Bold = True

            'Memberi warna backgound
            ApExcel.Range("A1:G1").interior.colorindex = 36

            'Membuat border hitam
            ApExcel.Range("A1:G" & DataGridView1.RowCount + 1).Borders.Color = RGB(0, 0, 0)

            ApExcel.Visible = True

            ApExcel = Nothing
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If DataGridView2.RowCount > 0 Then
            'Deklarasi Object
            Dim ApExcel As Object

            'Set sebagai excel  object
            ApExcel = CreateObject("Excel.application")

            'Menyembunyikan proses excel
            ApExcel.Visible = False

            'Membuat/menambah workbook baru
            ApExcel.Workbooks.Add()

            'Lebar Kolom
            ApExcel.Columns(1).ColumnWidth = 15
            ApExcel.Columns(2).ColumnWidth = 20

            'Tulis nama kolom ke excel
            For i As Integer = 1 To DataGridView2.Columns.Count
                ApExcel.Cells(1, i).Value = DataGridView2.Columns(i - 1).Name
            Next

            'Tulis data ke excel
            For r = 0 To DataGridView2.RowCount - 1
                For i As Integer = 1 To DataGridView2.Columns.Count
                    ApExcel.Cells(r + 2, i).Value = DataGridView2.Rows(r).Cells(i - 1).Value
                Next
            Next

            'Membuat Font Bold
            ApExcel.Range("A1:E1").Font.Bold = True

            'Memberi warna backgound
            ApExcel.Range("A1:E1").interior.colorindex = 36

            'Membuat border hitam
            ApExcel.Range("A1:E" & DataGridView2.RowCount + 1).Borders.Color = RGB(0, 0, 0)

            ApExcel.Visible = True

            ApExcel = Nothing
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If DataGridView3.RowCount > 0 Then
            'Deklarasi Object
            Dim ApExcel As Object

            'Set sebagai excel  object
            ApExcel = CreateObject("Excel.application")

            'Menyembunyikan proses excel
            ApExcel.Visible = False

            'Membuat/menambah workbook baru
            ApExcel.Workbooks.Add()

            'Lebar Kolom
            ApExcel.Columns(1).ColumnWidth = 15
            ApExcel.Columns(2).ColumnWidth = 20

            'Tulis nama kolom ke excel
            For i As Integer = 1 To DataGridView3.Columns.Count
                ApExcel.Cells(1, i).Value = DataGridView3.Columns(i - 1).Name
            Next

            'Tulis data ke excel
            For r = 0 To DataGridView3.RowCount - 1
                For i As Integer = 1 To DataGridView3.Columns.Count
                    ApExcel.Cells(r + 2, i).Value = DataGridView3.Rows(r).Cells(i - 1).Value
                Next
            Next

            'Membuat Font Bold
            ApExcel.Range("A1:H1").Font.Bold = True

            'Memberi warna backgound
            ApExcel.Range("A1:H1").interior.colorindex = 36

            'Membuat border hitam
            ApExcel.Range("A1:H" & DataGridView3.RowCount + 1).Borders.Color = RGB(0, 0, 0)

            ApExcel.Visible = True

            ApExcel = Nothing
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If DataGridView4.RowCount > 0 Then
            'Deklarasi Object
            Dim ApExcel As Object

            'Set sebagai excel  object
            ApExcel = CreateObject("Excel.application")

            'Menyembunyikan proses excel
            ApExcel.Visible = False

            'Membuat/menambah workbook baru
            ApExcel.Workbooks.Add()

            'Lebar Kolom
            ApExcel.Columns(1).ColumnWidth = 15
            ApExcel.Columns(2).ColumnWidth = 20

            'Tulis nama kolom ke excel
            For i As Integer = 1 To DataGridView4.Columns.Count
                ApExcel.Cells(1, i).Value = DataGridView4.Columns(i - 1).Name
            Next

            'Tulis data ke excel
            For r = 0 To DataGridView4.RowCount - 1
                For i As Integer = 1 To DataGridView4.Columns.Count
                    ApExcel.Cells(r + 2, i).Value = DataGridView4.Rows(r).Cells(i - 1).Value
                Next
            Next

            'Membuat Font Bold
            ApExcel.Range("A1:H1").Font.Bold = True

            'Memberi warna backgound
            ApExcel.Range("A1:H1").interior.colorindex = 36

            'Membuat border hitam
            ApExcel.Range("A1:H" & DataGridView4.RowCount + 1).Borders.Color = RGB(0, 0, 0)

            ApExcel.Visible = True

            ApExcel = Nothing
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        DashboardUtama.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If DataGridView5.RowCount > 0 Then
            'Deklarasi Object
            Dim ApExcel As Object

            'Set sebagai excel  object
            ApExcel = CreateObject("Excel.application")

            'Menyembunyikan proses excel
            ApExcel.Visible = False

            'Membuat/menambah workbook baru
            ApExcel.Workbooks.Add()

            'Lebar Kolom
            ApExcel.Columns(1).ColumnWidth = 15
            ApExcel.Columns(2).ColumnWidth = 20

            'Tulis nama kolom ke excel
            For i As Integer = 1 To DataGridView5.Columns.Count
                ApExcel.Cells(1, i).Value = DataGridView5.Columns(i - 1).Name
            Next

            'Tulis data ke excel
            For r = 0 To DataGridView5.RowCount - 1
                For i As Integer = 1 To DataGridView5.Columns.Count
                    ApExcel.Cells(r + 2, i).Value = DataGridView5.Rows(r).Cells(i - 1).Value
                Next
            Next

            'Membuat Font Bold
            ApExcel.Range("A1:Q1").Font.Bold = True

            'Memberi warna backgound
            ApExcel.Range("A1:Q1").interior.colorindex = 36

            'Membuat border hitam
            ApExcel.Range("A1:Q" & DataGridView5.RowCount + 1).Borders.Color = RGB(0, 0, 0)

            ApExcel.Visible = True

            ApExcel = Nothing
        End If
    End Sub
End Class