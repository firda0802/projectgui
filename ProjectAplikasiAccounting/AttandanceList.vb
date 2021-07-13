Imports MySql.Data.MySqlClient
Public Class AttandanceList

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextNoEmployee.Text = "" Or TextEmployeeName.Text = "" Then
            MessageBox.Show("Isi no employee, employee name!!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Call koneksi()
            str = "insert into tbl_attedance_list values (@no_employee,@name_employee,@position,@attedance,@timetowork)"
            cmd = conn.CreateCommand
            With cmd
                .CommandText = str
                .Connection = conn
                .Parameters.Add("no_employee", MySqlDbType.String).Value = TextNoEmployee.Text
                .Parameters.Add("name_employee", MySqlDbType.String).Value = TextEmployeeName.Text
                .Parameters.Add("position", MySqlDbType.String).Value = ComboBoxPosition.Text
                .Parameters.Add("attedance", MySqlDbType.String).Value = ComboBoxAttedance.Text
                .Parameters.Add("timetowork", MySqlDbType.String).Value = Format(DateTimePickerTimeToWork.Value, "yyyy-MM-dd")
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Data berhasil disimpan!!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DashboardUtama.Show()
            Call bersih()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DashboardUtama.Show()
        Me.Close()
    End Sub
    Sub bersih()
        TextNoEmployee.Text = ""
        TextEmployeeName.Text = ""
        ComboBoxPosition.Text = ""
        ComboBoxAttedance.Text = ""
        DateTimePickerTimeToWork.Text = ""
    End Sub

    Private Sub AttandanceList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextNoEmployee.MaxLength = 16
    End Sub
End Class