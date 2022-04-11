Public Class FrmIndex
    Private Sub BtnItems_Click(sender As Object, e As EventArgs) Handles BtnItems.Click
        FrmItems.Show()

    End Sub

    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        FrmCustomers.Show()

    End Sub

    Private Sub BtnCashier_Click(sender As Object, e As EventArgs) Handles BtnCashier.Click
        If FrmCashier.CanFocus = True Then
            FrmCashier.WindowState = FormWindowState.Normal
            FrmCashier.BringToFront()
        Else
            FrmUsers.Show()
        End If


    End Sub

    Private Sub BtnSellingScreen_Click(sender As Object, e As EventArgs) Handles BtnSellingScreen.Click
        If FrmSellingScreen1.CanFocus = False Then
            If FrmCashier.CanFocus = True And FrmCashier.Text = "الخزينة" Then
                FrmSellingScreen1.Show()
                FrmSellingScreen1.SalesTableAdapter.Fill(FrmSellingScreen1.DBWoodDataSet.Sales)
                FrmSellingScreen1.SalesBindingSource.AddNew()
                FrmSellingScreen1.Sale_DateDateTimePicker.Value = Today.ToShortDateString
                FrmSellingScreen1.Sale_TimeDateTimePicker.Value = Now
                FrmSellingScreen1.Cashier_IDTextBox.Text = FrmCashier.IDTextBox.Text
                FrmSellingScreen1.Customer_IDTextBox.Text = FrmSellingScreen1.TxtCustomer_ID.Text

            ElseIf FrmCashier.CanFocus = True And FrmCashier.Text = "يجب تغيير الوردية" Then
                MsgBox("من فضلك يجب تغيير الوردية أولاً", vbOKOnly)
                FrmCashier.Show()
                FrmCashier.WindowState = FormWindowState.Normal
                FrmCashier.BringToFront()
            Else
                MsgBox("من فضلك افتح الخزينة أولاً", vbOKOnly)
                FrmUsers.Show()
            End If
        Else
            FrmSellingScreen1.WindowState = FormWindowState.Normal
            FrmSellingScreen1.BringToFront()

        End If

    End Sub

    Private Sub BtnMoneyMoving_Click(sender As Object, e As EventArgs) Handles BtnMoneyMoving.Click

        If FrmMoneyMoving.CanFocus = False Then
            If FrmCashier.CanFocus = True And FrmCashier.Text = "الخزينة" Then
                FrmMoneyMoving.Show()
                FrmMoneyMoving.MoneyTransactionsBindingSource.AddNew()
                FrmMoneyMoving.InOutTextBox.Text = "صادر"
                FrmMoneyMoving.Cashier_IDTextBox.Text = FrmCashier.IDTextBox.Text
                FrmMoneyMoving.User_IDTextBox.Text = FrmCashier.User_IDTextBox.Text
                FrmMoneyMoving.Transaction_DateDateTimePicker.Value = FrmCashier.Start_DateDateTimePicker.Value

            ElseIf FrmCashier.CanFocus = True And FrmCashier.Text = "يجب تغيير الوردية" Then
                MsgBox("من فضلك يجب تغيير الوردية أولاً", vbOKOnly)
                FrmCashier.Show()
                FrmCashier.WindowState = FormWindowState.Normal
                FrmCashier.BringToFront()
            Else
                MsgBox("من فضلك افتح الخزينة أولاً", vbOKOnly)
                FrmUsers.Show()
            End If
        Else
            FrmMoneyMoving.WindowState = FormWindowState.Normal
            FrmMoneyMoving.BringToFront()

        End If

    End Sub

    Private Sub BtnSuppliers_Click(sender As Object, e As EventArgs) Handles BtnSuppliers.Click
        FrmSuppliers.Show()

    End Sub

    Private Sub BtnItems_MouseLeave(sender As Object, e As EventArgs) Handles BtnItems.MouseLeave
        LblItems.Visible = False
    End Sub


    Private Sub BtnCashier_MouseLeave(sender As Object, e As EventArgs) Handles BtnCashier.MouseLeave
        LblCashier.Visible = False
    End Sub

    Private Sub BtnCashier_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnCashier.MouseMove
        LblCashier.Visible = True
    End Sub

    Private Sub BtnItems_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnItems.MouseMove
        LblItems.Visible = True
    End Sub

    Private Sub BtnSuppliers_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnSuppliers.MouseMove
        LblSuppliers.Visible = True

    End Sub

    Private Sub BtnSuppliers_MouseLeave(sender As Object, e As EventArgs) Handles BtnSuppliers.MouseLeave
        LblSuppliers.Visible = False

    End Sub

    Private Sub BtnCustomers_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnCustomers.MouseMove
        LblCustomers.Visible = True
    End Sub

    Private Sub BtnCustomers_MouseLeave(sender As Object, e As EventArgs) Handles BtnCustomers.MouseLeave
        LblCustomers.Visible = False
    End Sub

    Private Sub PurchasesInvoicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchasesInvoicesToolStripMenuItem.Click
        FrmPurchasesInvoices.Show()

    End Sub

    Private Sub BtnSellingScreen_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnSellingScreen.MouseMove
        LblSellingScreen.Visible = True
    End Sub

    Private Sub BtnSellingScreen_MouseLeave(sender As Object, e As EventArgs) Handles BtnSellingScreen.MouseLeave
        LblSellingScreen.Visible = False

    End Sub

    Private Sub SalesInvoicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesInvoicesToolStripMenuItem.Click
        FrmSales.Show()
    End Sub

    Private Sub BtnMoneyMoving_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnMoneyMoving.MouseMove
        LblMoneyMoving.Visible = True

    End Sub

    Private Sub BtnMoneyMoving_MouseLeave(sender As Object, e As EventArgs) Handles BtnMoneyMoving.MouseLeave
        LblMoneyMoving.Visible = False

    End Sub

    Private Sub ShiftsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShiftsToolStripMenuItem.Click
        FrmCashierShifts.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmReportSaleInvoice.Show()


    End Sub

    Private Sub حركاتالنقودToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حركاتالنقودToolStripMenuItem.Click
        FrmMoneyTransactions.Show()

    End Sub

    Private Sub LblMoneyMoving_Click(sender As Object, e As EventArgs) Handles LblMoneyMoving.Click

    End Sub
End Class
