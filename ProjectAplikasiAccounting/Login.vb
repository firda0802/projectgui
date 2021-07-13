Imports MySql.Data.MySqlClient
Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MessageBox.Show("Isi username dan password terlebih dahulu!!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                koneksi()
                cmd = New MySqlCommand("select * from tbl_user where username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    If rd("status").ToString = "HRD" Then
                        Me.Hide()
                        MenuKedua.Show()
                        BuyOrSale.Enabled = False
                        ProductData.Enabled = False
                    ElseIf rd("status").ToString = "PRODUKSI" Then
                        Me.Hide()
                        MenuKedua.Show()
                        PaymentSlip.Enabled = False
                        BuyOrSale.Enabled = False
                        NewEmployeeInput.Enabled = False
                    ElseIf rd("status").ToString = "FINANCE" Then
                        Me.Hide()
                        MenuKedua.Show()
                        PaymentSlip.Enabled = False
                        ProductData.Enabled = False
                        NewEmployeeInput.Enabled = False
                    Else
                        Me.Hide()
                        MenuKedua.Show()
                    End If
                    MessageBox.Show("Berhasil Login!!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MessageBox.Show(rd.Item(0), "Selamat Datang Anda Login Sebagai!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call bersih()
                    Me.Close()
                Else
                    MessageBox.Show("Anda Belum Terdaftar Silahkan Registrasi Akun Terlebih Dahulu!!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Call bersih()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Register.Show()
        Me.Close()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"
    End Sub
    Sub bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class