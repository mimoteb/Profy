<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BuyPrice = New System.Windows.Forms.TextBox()
        Me.SellPrice = New System.Windows.Forms.TextBox()
        Me.FeePrice = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblNetIncome = New System.Windows.Forms.Label()
        Me.ProfitPrice = New System.Windows.Forms.TextBox()
        Me.AmountPrice = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.IncomePrice = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.AmountDec = New System.Windows.Forms.TextBox()
        Me.BuyDec = New System.Windows.Forms.TextBox()
        Me.SellDec = New System.Windows.Forms.TextBox()
        Me.FeeDec = New System.Windows.Forms.TextBox()
        Me.ProfitDec = New System.Windows.Forms.TextBox()
        Me.IncomeDec = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DesiredProfitPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DesiredIncomePrice = New System.Windows.Forms.TextBox()
        Me.DesiredIncomeDec = New System.Windows.Forms.TextBox()
        Me.DesiredProfitDec = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SellAtDec = New System.Windows.Forms.TextBox()
        Me.SellAtPrice = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(235, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Buy Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(457, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Sell Price"
        '
        'BuyPrice
        '
        Me.BuyPrice.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BuyPrice.Location = New System.Drawing.Point(235, 35)
        Me.BuyPrice.Name = "BuyPrice"
        Me.BuyPrice.Size = New System.Drawing.Size(170, 35)
        Me.BuyPrice.TabIndex = 2
        Me.BuyPrice.Text = "100"
        '
        'SellPrice
        '
        Me.SellPrice.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SellPrice.Location = New System.Drawing.Point(457, 35)
        Me.SellPrice.Name = "SellPrice"
        Me.SellPrice.Size = New System.Drawing.Size(170, 35)
        Me.SellPrice.TabIndex = 3
        Me.SellPrice.Text = "110"
        '
        'FeePrice
        '
        Me.FeePrice.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FeePrice.Location = New System.Drawing.Point(13, 126)
        Me.FeePrice.Name = "FeePrice"
        Me.FeePrice.Size = New System.Drawing.Size(170, 35)
        Me.FeePrice.TabIndex = 4
        Me.FeePrice.Text = "0.1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(13, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 23)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Fees %"
        '
        'lblNetIncome
        '
        Me.lblNetIncome.AutoSize = True
        Me.lblNetIncome.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNetIncome.Location = New System.Drawing.Point(235, 100)
        Me.lblNetIncome.Name = "lblNetIncome"
        Me.lblNetIncome.Size = New System.Drawing.Size(63, 23)
        Me.lblNetIncome.TabIndex = 15
        Me.lblNetIncome.Text = "Profit"
        '
        'ProfitPrice
        '
        Me.ProfitPrice.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProfitPrice.Location = New System.Drawing.Point(235, 126)
        Me.ProfitPrice.Name = "ProfitPrice"
        Me.ProfitPrice.Size = New System.Drawing.Size(170, 35)
        Me.ProfitPrice.TabIndex = 5
        Me.ProfitPrice.Text = "0"
        '
        'AmountPrice
        '
        Me.AmountPrice.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AmountPrice.Location = New System.Drawing.Point(13, 35)
        Me.AmountPrice.Name = "AmountPrice"
        Me.AmountPrice.Size = New System.Drawing.Size(170, 35)
        Me.AmountPrice.TabIndex = 1
        Me.AmountPrice.Text = "100"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(13, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 23)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Amount"
        '
        'IncomePrice
        '
        Me.IncomePrice.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IncomePrice.Location = New System.Drawing.Point(457, 126)
        Me.IncomePrice.Name = "IncomePrice"
        Me.IncomePrice.Size = New System.Drawing.Size(170, 35)
        Me.IncomePrice.TabIndex = 6
        Me.IncomePrice.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(457, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 23)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Income"
        '
        'AmountDec
        '
        Me.AmountDec.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AmountDec.Location = New System.Drawing.Point(189, 35)
        Me.AmountDec.Name = "AmountDec"
        Me.AmountDec.Size = New System.Drawing.Size(40, 35)
        Me.AmountDec.TabIndex = 7
        Me.AmountDec.Text = "8"
        '
        'BuyDec
        '
        Me.BuyDec.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BuyDec.Location = New System.Drawing.Point(411, 35)
        Me.BuyDec.Name = "BuyDec"
        Me.BuyDec.Size = New System.Drawing.Size(40, 35)
        Me.BuyDec.TabIndex = 8
        Me.BuyDec.Text = "8"
        '
        'SellDec
        '
        Me.SellDec.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SellDec.Location = New System.Drawing.Point(633, 35)
        Me.SellDec.Name = "SellDec"
        Me.SellDec.Size = New System.Drawing.Size(40, 35)
        Me.SellDec.TabIndex = 9
        Me.SellDec.Text = "8"
        '
        'FeeDec
        '
        Me.FeeDec.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FeeDec.Location = New System.Drawing.Point(189, 126)
        Me.FeeDec.Name = "FeeDec"
        Me.FeeDec.Size = New System.Drawing.Size(40, 35)
        Me.FeeDec.TabIndex = 10
        Me.FeeDec.Text = "8"
        '
        'ProfitDec
        '
        Me.ProfitDec.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProfitDec.Location = New System.Drawing.Point(411, 126)
        Me.ProfitDec.Name = "ProfitDec"
        Me.ProfitDec.Size = New System.Drawing.Size(40, 35)
        Me.ProfitDec.TabIndex = 11
        Me.ProfitDec.Text = "8"
        '
        'IncomeDec
        '
        Me.IncomeDec.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IncomeDec.Location = New System.Drawing.Point(633, 126)
        Me.IncomeDec.Name = "IncomeDec"
        Me.IncomeDec.Size = New System.Drawing.Size(40, 35)
        Me.IncomeDec.TabIndex = 12
        Me.IncomeDec.Text = "8"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Desired Profit:"
        '
        'DesiredProfitPrice
        '
        Me.DesiredProfitPrice.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DesiredProfitPrice.Location = New System.Drawing.Point(13, 217)
        Me.DesiredProfitPrice.Name = "DesiredProfitPrice"
        Me.DesiredProfitPrice.Size = New System.Drawing.Size(170, 35)
        Me.DesiredProfitPrice.TabIndex = 5
        Me.DesiredProfitPrice.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(235, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 23)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Desired Income:"
        '
        'DesiredIncomePrice
        '
        Me.DesiredIncomePrice.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DesiredIncomePrice.Location = New System.Drawing.Point(235, 217)
        Me.DesiredIncomePrice.Name = "DesiredIncomePrice"
        Me.DesiredIncomePrice.Size = New System.Drawing.Size(170, 35)
        Me.DesiredIncomePrice.TabIndex = 6
        Me.DesiredIncomePrice.Text = "0"
        '
        'DesiredIncomeDec
        '
        Me.DesiredIncomeDec.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DesiredIncomeDec.Location = New System.Drawing.Point(411, 217)
        Me.DesiredIncomeDec.Name = "DesiredIncomeDec"
        Me.DesiredIncomeDec.Size = New System.Drawing.Size(40, 35)
        Me.DesiredIncomeDec.TabIndex = 12
        Me.DesiredIncomeDec.Text = "8"
        '
        'DesiredProfitDec
        '
        Me.DesiredProfitDec.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DesiredProfitDec.Location = New System.Drawing.Point(189, 217)
        Me.DesiredProfitDec.Name = "DesiredProfitDec"
        Me.DesiredProfitDec.Size = New System.Drawing.Size(40, 35)
        Me.DesiredProfitDec.TabIndex = 11
        Me.DesiredProfitDec.Text = "8"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(457, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 23)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Sell At:"
        '
        'SellAtDec
        '
        Me.SellAtDec.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SellAtDec.Location = New System.Drawing.Point(633, 217)
        Me.SellAtDec.Name = "SellAtDec"
        Me.SellAtDec.Size = New System.Drawing.Size(40, 35)
        Me.SellAtDec.TabIndex = 29
        Me.SellAtDec.Text = "8"
        '
        'SellAtPrice
        '
        Me.SellAtPrice.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SellAtPrice.Location = New System.Drawing.Point(457, 217)
        Me.SellAtPrice.Name = "SellAtPrice"
        Me.SellAtPrice.Size = New System.Drawing.Size(170, 35)
        Me.SellAtPrice.TabIndex = 28
        Me.SellAtPrice.Text = "1400"
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(691, 270)
        Me.Controls.Add(Me.SellAtDec)
        Me.Controls.Add(Me.SellAtPrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SellDec)
        Me.Controls.Add(Me.BuyDec)
        Me.Controls.Add(Me.FeeDec)
        Me.Controls.Add(Me.DesiredProfitDec)
        Me.Controls.Add(Me.ProfitDec)
        Me.Controls.Add(Me.DesiredIncomeDec)
        Me.Controls.Add(Me.IncomeDec)
        Me.Controls.Add(Me.AmountDec)
        Me.Controls.Add(Me.DesiredIncomePrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IncomePrice)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DesiredProfitPrice)
        Me.Controls.Add(Me.AmountPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProfitPrice)
        Me.Controls.Add(Me.lblNetIncome)
        Me.Controls.Add(Me.FeePrice)
        Me.Controls.Add(Me.SellPrice)
        Me.Controls.Add(Me.BuyPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Profy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Buy1 As TextBox
    Friend WithEvents Sell1 As TextBox
    Friend WithEvents FeePrice As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblNetIncome As Label
    Friend WithEvents ProfitPrice As TextBox
    Friend WithEvents AmountPrice As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents IncomePrice As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents BuyPrice As TextBox
    Friend WithEvents SellPrice As TextBox
    Friend WithEvents FeeText As TextBox
    Friend WithEvents nt As TextBox
    Friend WithEvents DesiredProfitPrice As TextBox
    Friend WithEvents DesiredIncomePrice As TextBox
    Friend WithEvents AmountDec As TextBox
    Friend WithEvents BuyDec As TextBox
    Friend WithEvents SellDec As TextBox
    Friend WithEvents FeeDec As TextBox
    Friend WithEvents ProfitDec As TextBox
    Friend WithEvents IncomeDec As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DesiredIncomeDec As TextBox
    Friend WithEvents DesiredProfitDec As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SellAtDec As TextBox
    Friend WithEvents SellAt As TextBox
    Friend WithEvents ll As TextBox
    Friend WithEvents SellAtPrice As TextBox
End Class
