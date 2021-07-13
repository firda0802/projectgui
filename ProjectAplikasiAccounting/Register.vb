Imports MySql.Data.MySqlClient
Public Class Register

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Isi username, password dan posisi terlebih dahulu!!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Call koneksi()
            str = "insert into tbl_user values (@username,@password,@status)"
            cmd = conn.CreateCommand
            With cmd
                .CommandText = str
                .Connection = conn
                .Parameters.Add("username", MySqlDbType.String).Value = TextBox1.Text
                .Parameters.Add("password", MySqlDbType.String).Value = TextBox2.Text
                .Parameters.Add("status", MySqlDbType.String).Value = ComboBox1.Text
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Data berhasil disimpan!!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Login.Show()
            Call bersih()
            Me.Close()
        End If
    End Sub

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"
    End Sub
    Sub bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
    End Sub
End Class