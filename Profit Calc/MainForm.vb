Imports System.ComponentModel
Imports System.IO
Imports Profy.Profy

Public Class MainForm
    'ex=amount/buy
    'income =ex*sell
    'sell=income /ex
    'Variables
    Dim amount As Double
    Dim Buy As Double
    Dim Sell As Double
    Dim Fee As Double
    Dim Profit As Double
    Dim Income As Double
    Dim NetIncome As Double
    Dim DesiredProfit As Double
    Dim DesiredIncome As Double
    Dim DesiredSellAt As Double
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With ProfySettings.Default
                AmountPrice.Text = .AmountPrice
                AmountDec.Text = .AmountDec
                BuyPrice.Text = .BuyPrice
                BuyDec.Text = .BuyDec
                SellPrice.Text = .SellPrice
                SellDec.Text = .SellDec
                FeePrice.Text = .FeePrice
                FeeDec.Text = .FeeDec
                ProfitPrice.Text = .ProfitPrice
                ProfitDec.Text = .ProfitDec
                IncomePrice.Text = .IncomePrice
                IncomeDec.Text = .IncomeDec
                DesiredProfitPrice.Text = .DesiredIncomePrice
                DesiredProfitDec.Text = .DesiredProfitDec
                DesiredIncomePrice.Text = .DesiredIncomePrice
                DesiredIncomeDec.Text = .DesiredIncomeDec
                SellAtPrice.Text = .SellAtPrice
                SellAtDec.Text = .SellAtDec
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            With ProfySettings.Default
                .AmountPrice = AmountPrice.Text
                .AmountDec = AmountDec.Text
                .BuyPrice = BuyPrice.Text
                .BuyDec = BuyDec.Text
                .SellPrice = SellPrice.Text
                .SellDec = SellDec.Text
                .FeePrice = FeePrice.Text
                .FeeDec = FeeDec.Text
                .ProfitPrice = ProfitPrice.Text
                .ProfitDec = ProfitDec.Text
                .IncomePrice = IncomePrice.Text
                .IncomeDec = IncomeDec.Text
                .DesiredIncomePrice = DesiredProfitPrice.Text
                .DesiredProfitDec = DesiredProfitDec.Text
                .DesiredIncomePrice = DesiredIncomePrice.Text
                .DesiredIncomeDec = DesiredIncomeDec.Text
                .SellAtPrice = SellAtPrice.Text
                .SellAtDec = SellAtDec.Text
            End With
            ProfySettings.Default.Save()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub textboxes_KeyPress(sender As TextBox, e As KeyPressEventArgs) Handles AmountPrice.KeyPress, BuyPrice.KeyPress, SellPrice.KeyPress, FeeText.KeyPress, ProfitPrice.KeyPress, IncomePrice.KeyPress, DesiredProfitPrice.KeyPress, DesiredIncomePrice.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub calculate(sender As Object, e As EventArgs) Handles AmountPrice.TextChanged, BuyPrice.TextChanged, SellPrice.TextChanged, FeePrice.TextChanged
        On Error Resume Next

        'Assign Values
        amount = Math.Round(CDbl(AmountPrice.Text), CInt(AmountDec.Text))
        Buy = Math.Round(CDbl(BuyPrice.Text), CInt(BuyDec.Text))
        Sell = Math.Round(CDbl(SellPrice.Text), CInt(SellDec.Text))
        Fee = 2 * Math.Round(CDbl(FeePrice.Text), CInt(FeeDec.Text)) / 100
        '  Profit = Math.Round(CDbl(ProfitPrice.Text), CInt(ProfitDec.Text))
        ' Income = Math.Round(CDbl(IncomePrice.Text), CInt(IncomeDec.Text))

        Dim Exchange As Double = amount / Buy ' 0.01980620
        Income = Exchange * Sell
        NetIncome = Income - Fee
        Profit = NetIncome - amount

        'show values
        ProfitPrice.Text = Math.Round(Profit, CInt(ProfitDec.Text))
        IncomePrice.Text = Math.Round(NetIncome, CInt(IncomeDec.Text))
        Dim profitPercentage As Decimal = Math.Round((Sell - Buy), 2)
        lblNetIncome.Text = "Profit " & profitPercentage & "%"
    End Sub

    Private Sub ReverseCalcProfit(sender As TextBox, e As EventArgs) Handles DesiredProfitPrice.TextChanged, DesiredIncomePrice.TextChanged
        On Error Resume Next

        'Assign Values
        amount = Math.Round(CDbl(AmountPrice.Text), CInt(AmountDec.Text))
        Buy = Math.Round(CDbl(BuyPrice.Text), CInt(BuyDec.Text))
        Fee = Math.Round(CDbl(FeePrice.Text), CInt(FeeDec.Text))
        DesiredProfit = Math.Round(CDbl(DesiredProfitPrice.Text), CInt(DesiredProfitDec.Text))
        DesiredIncome = Math.Round(CDbl(DesiredIncomePrice.Text), CInt(DesiredIncomeDec.Text))
        Dim Exchange As Double = amount / Buy ' 0.01980620
        'income =ex*sell
        'sell=income /ex
        If sender Is DesiredProfitPrice Then
            Income = amount + Math.Round(DesiredProfit, CInt(DesiredProfitDec.Text))
            Sell = Income / Exchange
            DesiredIncomePrice.Text = Math.Round(Income, CInt(DesiredIncomeDec.Text))
            SellAtPrice.Text = Math.Round(Sell, CInt(SellAtDec.Text))
        Else
            DesiredProfit = DesiredIncome - amount
            DesiredProfitPrice.Text = Math.Round(DesiredProfit, CInt(DesiredProfitDec.Text))
            Sell = DesiredIncome / Exchange
            SellAtPrice.Text = Math.Round(Sell, CInt(SellAtDec.Text))
        End If

    End Sub

End Class
