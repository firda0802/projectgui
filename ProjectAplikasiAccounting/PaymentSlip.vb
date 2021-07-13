Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class PaymentSlip
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextNoSlip.Text = "" Or TextNoEmployee.Text = "" Or TextEmployeeName.Text = "" Or TextBasicPay.Text = "" Or TextOvertime.Text = "" Or TextIntensive.Text = "" Or TextOrtherAllowance.Text = "" Or TextBonus.Text = "" Or TextAttedance.Text = "" Or TextOrtherSalary.Text = "" Or TextJamsostek.Text = "" Or TextPPH.Text = "" Or TextOrtherJamsostek.Text = "" Then
            MessageBox.Show("Isi no slip, no employee, employee name, basic pay, overtime, positional allowance, intensive attedance, orther allowance, bonus, attendance, orther_salary, jamsostek, pph, dan orther jamsostek terlebih dahulu!!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Call koneksi()
            str = "insert into tbl_payment_slip values (@no_slip ,@no_employee,@employee_name,@position,@date_started,@departement,@basic_pay,@overtime,@positional_allowance,@intensive_attedance,@orther_allowance,@bonus,@attendance,@orther_salary,@jamsostek,@pph,@orther_jamsostek)"
            cmd = conn.CreateCommand
            With cmd
                .CommandText = str
                .Connection = conn
                .Parameters.Add("no_slip", MySqlDbType.String).Value = TextNoSlip.Text
                .Parameters.Add("no_employee", MySqlDbType.String).Value = TextNoEmployee.Text
                .Parameters.Add("employee_name", MySqlDbType.String).Value = TextEmployeeName.Text
                .Parameters.Add("position", MySqlDbType.String).Value = ComboBoxPosition.Text
                .Parameters.Add("date_started", MySqlDbType.String).Value = Format(DateTimePickerStartedWork.Value, "yyyy-MM-dd")
                .Parameters.Add("departement", MySqlDbType.String).Value = ComboBoxDepartement.Text
                .Parameters.Add("basic_pay", MySqlDbType.String).Value = TextBasicPay.Text
                .Parameters.Add("overtime", MySqlDbType.String).Value = TextOvertime.Text
                .Parameters.Add("positional_allowance", MySqlDbType.String).Value = ComboBoxPositional.Text
                .Parameters.Add("intensive_attedance", MySqlDbType.String).Value = TextIntensive.Text
                .Parameters.Add("orther_allowance", MySqlDbType.String).Value = TextOrtherAllowance.Text
                .Parameters.Add("bonus", MySqlDbType.String).Value = TextBonus.Text
                .Parameters.Add("attendance", MySqlDbType.String).Value = TextAttedance.Text
                .Parameters.Add("orther_salary", MySqlDbType.String).Value = TextOrtherSalary.Text
                .Parameters.Add("jamsostek", MySqlDbType.String).Value = TextJamsostek.Text
                .Parameters.Add("pph", MySqlDbType.String).Value = TextPPH.Text
                .Parameters.Add("orther_jamsostek", MySqlDbType.String).Value = TextOrtherJamsostek.Text
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Data berhasil disimpan!!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DashboardUtama.Show()
            Call bersih()
            Me.Close()
        End If
    End Sub
    Sub bersih()
        TextNoSlip.Text = ""
        TextNoEmployee.Text = ""
        TextEmployeeName.Text = ""
        ComboBoxPosition.Text = ""
        DateTimePickerStartedWork.Text = ""
        ComboBoxDepartement.Text = ""
        TextBasicPay.Text = ""
        TextOvertime.Text = ""
        ComboBoxPositional.Text = ""
        TextIntensive.Text = ""
        TextOrtherAllowance.Text = ""
        TextBonus.Text = ""
        TextAttedance.Text = ""
        TextOrtherSalary.Text = ""
        TextJamsostek.Text = ""
        TextPPH.Text = ""
        TextOrtherJamsostek.Text = ""

    End Sub
    Private Sub TextJamsostek_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextJamsostek.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
        TextPPH.Text = 1.5 / 100 * Val(TextBasicPay.Text) + Val(TextOvertime.Text) + Val(TextIntensive.Text) + Val(TextOrtherAllowance.Text) + Val(TextBonus.Text) + Val(TextAttedance.Text) + Val(TextOrtherSalary.Text) + Val(TextJamsostek.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DashboardUtama.Show()
        Me.Close()
    End Sub

    Private Sub PaymentSlip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextNoEmployee.MaxLength = 16
        TextPPH.Enabled = False
        TextNoSlip.Enabled = False
        Call koneksi()
        cmd = New MySqlCommand("select * from tbl_payment_slip order by no_slip desc", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            TextNoSlip.Text = "SL" + "0001"
        Else
            TextNoSlip.Text = Val(Microsoft.VisualBasic.Mid(rd.Item("no_slip").ToString, 4, 3)) + 1
            If Len(TextNoSlip.Text) = 1 Then
                TextNoSlip.Text = "SL000" & TextNoSlip.Text & ""
            ElseIf Len(TextNoSlip.Text) = 2 Then
                TextNoSlip.Text = "SL00" & TextNoSlip.Text & ""
            ElseIf Len(TextNoSlip.Text) = 3 Then
                TextNoSlip.Text = "SL0" & TextNoSlip.Text & ""
            End If
        End If
    End Sub

    Private Sub TextBasicPay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBasicPay.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub TextOvertime_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextOvertime.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub TextIntensive_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextIntensive.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub TextOrtherAllowance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextOrtherAllowance.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub TextBonus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBonus.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub TextAttedance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextAttedance.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub TextOrtherSalary_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextOrtherSalary.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub TextOrtherJamsostek_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextOrtherJamsostek.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PPD.Document = PD
        PPD.ShowDialog()
        'PD.Print()
    End Sub

    Private Sub PD_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 280)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PD.PrintPage
        Call koneksi()
        cmd = New MySqlCommand("select * from tbl_payment_slip order by no_slip desc limit 1", conn)
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
        e.Graphics.DrawString("PAYMENT SLIP", f14, Brushes.Black, centermargin, 45, tengah)

        e.Graphics.DrawString("No Slip", f10, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f10, Brushes.Black, 65, 60)
        e.Graphics.DrawString(rd.Item(0), f10, Brushes.Black, 70, 60)

        e.Graphics.DrawString("No Employee", f10, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f10, Brushes.Black, 85, 75)
        e.Graphics.DrawString(rd.Item(1), f10, Brushes.Black, 90, 75)

        e.Graphics.DrawString("Employee Name", f10, Brushes.Black, 0, 90)
        e.Graphics.DrawString(":", f10, Brushes.Black, 98, 90)
        e.Graphics.DrawString(rd.Item(2), f10, Brushes.Black, 105, 90)

        e.Graphics.DrawString("Position", f10, Brushes.Black, 0, 105)
        e.Graphics.DrawString(":", f10, Brushes.Black, 100, 105)
        e.Graphics.DrawString(rd.Item(3), f10, Brushes.Black, 105, 105)

        e.Graphics.DrawString("Date Started Work", f10, Brushes.Black, 0, 120)
        e.Graphics.DrawString(":", f10, Brushes.Black, 105, 120)
        e.Graphics.DrawString(rd.Item(4), f10, Brushes.Black, 115, 120)

        e.Graphics.DrawString("Departement", f10, Brushes.Black, 0, 135)
        e.Graphics.DrawString(":", f10, Brushes.Black, 105, 135)
        e.Graphics.DrawString(rd.Item(5), f10, Brushes.Black, 115, 135)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 145)

        e.Graphics.DrawString("Basic Pay", f10, Brushes.Black, 0, 155)
        e.Graphics.DrawString(":", f10, Brushes.Black, 105, 155)
        e.Graphics.DrawString(rd.Item(6), f10, Brushes.Black, 115, 155)

        e.Graphics.DrawString("Overtime", f10, Brushes.Black, 0, 165)
        e.Graphics.DrawString(":", f10, Brushes.Black, 105, 165)
        e.Graphics.DrawString(rd.Item(7), f10, Brushes.Black, 115, 165)

        e.Graphics.DrawString("Positional", f10, Brushes.Black, 0, 175)
        e.Graphics.DrawString(":", f10, Brushes.Black, 105, 175)
        e.Graphics.DrawString(rd.Item(8), f10, Brushes.Black, 115, 175)

        e.Graphics.DrawString("Intensive", f10, Brushes.Black, 0, 185)
        e.Graphics.DrawString(":", f10, Brushes.Black, 105, 185)
        e.Graphics.DrawString(rd.Item(9), f10, Brushes.Black, 115, 185)

        e.Graphics.DrawString("Other Allowance", f10, Brushes.Black, 0, 195)
        e.Graphics.DrawString(":", f10, Brushes.Black, 105, 195)
        e.Graphics.DrawString(rd.Item(10), f10, Brushes.Black, 115, 195)

        e.Graphics.DrawString("Bonus", f10, Brushes.Black, 0, 205)
        e.Graphics.DrawString(":", f10, Brushes.Black, 105, 205)
        e.Graphics.DrawString(rd.Item(11), f10, Brushes.Black, 115, 205)

        e.Graphics.DrawString("Attedance", f10, Brushes.Black, 0, 215)
        e.Graphics.DrawString(":", f10, Brushes.Black, 105, 215)
        e.Graphics.DrawString(rd.Item(12), f10, Brushes.Black, 115, 215)

        e.Graphics.DrawString("Orther Salary", f10, Brushes.Black, 0, 225)
        e.Graphics.DrawString(":", f10, Brushes.Black, 105, 225)
        e.Graphics.DrawString(rd.Item(13), f10, Brushes.Black, 115, 225)

        e.Graphics.DrawString("Jamsostek", f10, Brushes.Black, 0, 235)
        e.Graphics.DrawString(":", f10, Brushes.Black, 105, 235)
        e.Graphics.DrawString(rd.Item(14), f10, Brushes.Black, 115, 235)

        e.Graphics.DrawString("PPH", f10, Brushes.Black, 0, 245)
        e.Graphics.DrawString(":", f10, Brushes.Black, 105, 245)
        e.Graphics.DrawString(rd.Item(15), f10, Brushes.Black, 115, 245)

        e.Graphics.DrawString("Other Jamsostek", f10, Brushes.Black, 0, 255)
        e.Graphics.DrawString(":", f10, Brushes.Black, 105, 255)
        e.Graphics.DrawString(rd.Item(16), f10, Brushes.Black, 115, 255)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 265)
    End Sub
End Class