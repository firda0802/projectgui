<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuyOrSale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuyOrSale))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextTotal = New System.Windows.Forms.TextBox()
        Me.TextEmployees = New System.Windows.Forms.TextBox()
        Me.TextSell = New System.Windows.Forms.TextBox()
        Me.TextBuy = New System.Windows.Forms.TextBox()
        Me.TextPriceUnit = New System.Windows.Forms.TextBox()
        Me.TextAmount = New System.Windows.Forms.TextBox()
        Me.TextProductName = New System.Windows.Forms.TextBox()
        Me.TextNoProduct = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.TextTotal)
        Me.Panel1.Controls.Add(Me.TextEmployees)
        Me.Panel1.Controls.Add(Me.TextSell)
        Me.Panel1.Controls.Add(Me.TextBuy)
        Me.Panel1.Controls.Add(Me.TextPriceUnit)
        Me.Panel1.Controls.Add(Me.TextAmount)
        Me.Panel1.Controls.Add(Me.TextProductName)
        Me.Panel1.Controls.Add(Me.TextNoProduct)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(23, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(677, 330)
        Me.Panel1.TabIndex = 0
        '
        'TextTotal
        '
        Me.TextTotal.Location = New System.Drawing.Point(416, 115)
        Me.TextTotal.Name = "TextTotal"
        Me.TextTotal.Size = New System.Drawing.Size(234, 20)
        Me.TextTotal.TabIndex = 15
        '
        'TextEmployees
        '
        Me.TextEmployees.Location = New System.Drawing.Point(416, 65)
        Me.TextEmployees.Name = "TextEmployees"
        Me.TextEmployees.Size = New System.Drawing.Size(234, 20)
        Me.TextEmployees.TabIndex = 14
        '
        'TextSell
        '
        Me.TextSell.Location = New System.Drawing.Point(36, 293)
        Me.TextSell.Name = "TextSell"
        Me.TextSell.Size = New System.Drawing.Size(344, 20)
        Me.TextSell.TabIndex = 13
        '
        'TextBuy
        '
        Me.TextBuy.Location = New System.Drawing.Point(36, 245)
        Me.TextBuy.Name = "TextBuy"
        Me.TextBuy.Size = New System.Drawing.Size(341, 20)
        Me.TextBuy.TabIndex = 12
        '
        'TextPriceUnit
        '
        Me.TextPriceUnit.Location = New System.Drawing.Point(36, 204)
        Me.TextPriceUnit.Name = "TextPriceUnit"
        Me.TextPriceUnit.Size = New System.Drawing.Size(344, 20)
        Me.TextPriceUnit.TabIndex = 11
        '
        'TextAmount
        '
        Me.TextAmount.Location = New System.Drawing.Point(36, 155)
        Me.TextAmount.Name = "TextAmount"
        Me.TextAmount.Size = New System.Drawing.Size(344, 20)
        Me.TextAmount.TabIndex = 10
        '
        'TextProductName
        '
        Me.TextProductName.Location = New System.Drawing.Point(36, 115)
        Me.TextProductName.Name = "TextProductName"
        Me.TextProductName.Size = New System.Drawing.Size(344, 20)
        Me.TextProductName.TabIndex = 9
        '
        'TextNoProduct
        '
        Me.TextNoProduct.Location = New System.Drawing.Point(36, 65)
        Me.TextNoProduct.Name = "TextNoProduct"
        Me.TextNoProduct.Size = New System.Drawing.Size(341, 20)
        Me.TextNoProduct.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(414, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(415, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Employees Who Input"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sell"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Buy"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Price / Unit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Product"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(308, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 24)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Buy Or Sell"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(511, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(189, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "PT. DAVCO SENDAWAR INDUSTRI"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(23, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 30)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(23, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(337, 373)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(625, 372)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BuyOrSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(733, 407)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "BuyOrSale"
        Me.Text = "Buy Or Sale"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextSell As System.Windows.Forms.TextBox
    Friend WithEvents TextBuy As System.Windows.Forms.TextBox
    Friend WithEvents TextPriceUnit As System.Windows.Forms.TextBox
    Friend WithEvents TextAmount As System.Windows.Forms.TextBox
    Friend WithEvents TextProductName As System.Windows.Forms.TextBox
    Friend WithEvents TextNoProduct As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextTotal As System.Windows.Forms.TextBox
    Friend WithEvents TextEmployees As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
