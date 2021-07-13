<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewEmployeeInput
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewEmployeeInput))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBoxPositional = New System.Windows.Forms.ComboBox()
        Me.TextBasicPay = New System.Windows.Forms.TextBox()
        Me.ComboBoxDepartement = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerStartedWork = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxPosition = New System.Windows.Forms.ComboBox()
        Me.TextEmployeeName = New System.Windows.Forms.TextBox()
        Me.TextNoEmployee = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.ComboBoxPositional)
        Me.Panel1.Controls.Add(Me.TextBasicPay)
        Me.Panel1.Controls.Add(Me.ComboBoxDepartement)
        Me.Panel1.Controls.Add(Me.DateTimePickerStartedWork)
        Me.Panel1.Controls.Add(Me.ComboBoxPosition)
        Me.Panel1.Controls.Add(Me.TextEmployeeName)
        Me.Panel1.Controls.Add(Me.TextNoEmployee)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 320)
        Me.Panel1.TabIndex = 0
        '
        'ComboBoxPositional
        '
        Me.ComboBoxPositional.FormattingEnabled = True
        Me.ComboBoxPositional.Items.AddRange(New Object() {"BPJS", "KENDARAAN RODA DUA", "KENDARAAN RODA EMPAT", "LAPTOP"})
        Me.ComboBoxPositional.Location = New System.Drawing.Point(22, 281)
        Me.ComboBoxPositional.Name = "ComboBoxPositional"
        Me.ComboBoxPositional.Size = New System.Drawing.Size(497, 21)
        Me.ComboBoxPositional.TabIndex = 13
        '
        'TextBasicPay
        '
        Me.TextBasicPay.Location = New System.Drawing.Point(22, 242)
        Me.TextBasicPay.Name = "TextBasicPay"
        Me.TextBasicPay.Size = New System.Drawing.Size(497, 20)
        Me.TextBasicPay.TabIndex = 12
        '
        'ComboBoxDepartement
        '
        Me.ComboBoxDepartement.FormattingEnabled = True
        Me.ComboBoxDepartement.Items.AddRange(New Object() {"HUMAN RESOURCE DEVELOPMENT", "FINANCE", "ASSEMBELING"})
        Me.ComboBoxDepartement.Location = New System.Drawing.Point(22, 200)
        Me.ComboBoxDepartement.Name = "ComboBoxDepartement"
        Me.ComboBoxDepartement.Size = New System.Drawing.Size(497, 21)
        Me.ComboBoxDepartement.TabIndex = 11
        '
        'DateTimePickerStartedWork
        '
        Me.DateTimePickerStartedWork.Location = New System.Drawing.Point(22, 162)
        Me.DateTimePickerStartedWork.Name = "DateTimePickerStartedWork"
        Me.DateTimePickerStartedWork.Size = New System.Drawing.Size(497, 20)
        Me.DateTimePickerStartedWork.TabIndex = 10
        '
        'ComboBoxPosition
        '
        Me.ComboBoxPosition.FormattingEnabled = True
        Me.ComboBoxPosition.Items.AddRange(New Object() {"ADMINISTRASI", "ACCOUNTING", "KEPALA BAGIAN", "OPERATOR"})
        Me.ComboBoxPosition.Location = New System.Drawing.Point(22, 118)
        Me.ComboBoxPosition.Name = "ComboBoxPosition"
        Me.ComboBoxPosition.Size = New System.Drawing.Size(497, 21)
        Me.ComboBoxPosition.TabIndex = 9
        '
        'TextEmployeeName
        '
        Me.TextEmployeeName.Location = New System.Drawing.Point(22, 80)
        Me.TextEmployeeName.Name = "TextEmployeeName"
        Me.TextEmployeeName.Size = New System.Drawing.Size(497, 20)
        Me.TextEmployeeName.TabIndex = 8
        '
        'TextNoEmployee
        '
        Me.TextNoEmployee.Location = New System.Drawing.Point(22, 38)
        Me.TextNoEmployee.Name = "TextNoEmployee"
        Me.TextNoEmployee.Size = New System.Drawing.Size(497, 20)
        Me.TextNoEmployee.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Positional Allowance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Basic Pay"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Departement"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date Started Work"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Position"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Employee"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 36)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(180, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(204, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "New Employee Input"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(29, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(498, 375)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(399, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(189, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "PT. DAVCO SENDAWAR INDUSTRI"
        '
        'NewEmployeeInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(612, 410)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "NewEmployeeInput"
        Me.Text = "NewEmployeeInput"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBasicPay As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxDepartement As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePickerStartedWork As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBoxPosition As System.Windows.Forms.ComboBox
    Friend WithEvents TextEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents TextNoEmployee As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxPositional As System.Windows.Forms.ComboBox
End Class
