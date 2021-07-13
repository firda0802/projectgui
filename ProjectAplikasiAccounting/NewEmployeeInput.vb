Imports MySql.Data.MySqlClient
Public Class NewEmployeeInput
    Public aksi As String
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextNoEmployee.Text = "" Or TextEmployeeName.Text = "" Or TextBasicPay.Text = "" Then
            MessageBox.Show("Isi no employee, employee name,dan basic pay terlebih dahulu!!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Call koneksi()
            str = "insert into tbl_new_employee values (@no_employee,@employee_name,@position,@date_started,@departement,@basic_pay,@positional_allowance)"
            cmd = conn.CreateCommand
            With cmd
                .CommandText = str
                .Connection = conn
                .Parameters.Add("no_employee", MySqlDbType.String).Value = TextNoEmployee.Text
                .Parameters.Add("employee_name", MySqlDbType.String).Value = TextEmployeeName.Text
                .Parameters.Add("position", MySqlDbType.String).Value = ComboBoxPosition.Text
                .Parameters.Add("date_started", MySqlDbType.String).Value = Format(DateTimePickerStartedWork.Value, "yyyy-MM-dd")
                .Parameters.Add("departement", MySqlDbType.String).Value = ComboBoxDepartement.Text
                .Parameters.Add("basic_pay", MySqlDbType.String).Value = TextBasicPay.Text
                .Parameters.Add("positional_allowance", MySqlDbType.String).Value = ComboBoxPositional.Text
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Data berhasil disimpan!!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DashboardKedua.Show()
            Call bersih()
            Me.Close()
        End If
    End Sub
    Sub bersih()
        TextNoEmployee.Text = ""
        TextEmployeeName.Text = ""
        ComboBoxPosition.Text = ""
        DateTimePickerStartedWork.Text = ""
        ComboBoxDepartement.Text = ""
        TextBasicPay.Text = ""
        ComboBoxPositional.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DashboardUtama.Show()
        Me.Close()
    End Sub

    Private Sub NewEmployeeInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextNoEmployee.MaxLength = 16
    End Sub
End Class