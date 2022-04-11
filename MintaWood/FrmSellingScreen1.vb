Public Class FrmSellingScreen1

    Private Sub FrmSellingScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DBWoodDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.DBWoodDataSet.Customers)
        'TODO: This line of code loads data into the 'DBWoodDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.DBWoodDataSet.Items)


    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        SaleDetailsBindingSource.AddNew()

        SaleDetailsDataGridView.CurrentRow.Cells("TbcID").Value = Val(TxtSale_ID.Text) * 1000 + SaleDetailsDataGridView.RowCount

        SaleDetailsDataGridView.CurrentRow.Cells("TbcItem_ID").Value = TxtItem_ID.Text
        SaleDetailsDataGridView.CurrentRow.Cells("TbcSale_ID").Value = TxtSale_ID.Text
        SaleDetailsDataGridView.CurrentRow.Cells("TbcItem_Name").Value = Item_NameComboBox.Text
        SaleDetailsDataGridView.CurrentRow.Cells("TbcPrice").Value = Public_PriceTextBox.Text
        SaleDetailsDataGridView.CurrentRow.Cells("TbcQuantity").Value = 1
        SaleDetailsDataGridView.CurrentRow.Cells("TbcDiscount_Percentage").Value = 0
        SaleDetailsDataGridView.CurrentRow.Cells("TbcDiscount_Value").Value = 0
        SaleDetailsDataGridView.CurrentRow.Cells("TbcTotal_Price").Value = SaleDetailsDataGridView.CurrentRow.Cells("TbcQuantity").Value * SaleDetailsDataGridView.CurrentRow.Cells("TbcPrice").Value * (100 - SaleDetailsDataGridView.CurrentRow.Cells("TbcDiscount_Percentage").Value) / 100
        SaleDetailsDataGridView.CurrentRow.Cells("TbcSupplier_Price").Value = Supplier_PriceTextBox.Text

        SaleDetailsDataGridView.CurrentCell = SaleDetailsDataGridView.CurrentRow.Cells("TbcQuantity")
        SaleDetailsDataGridView.BeginEdit(True)

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        StatusTextBox.Text = "معلقة"
        Try
            Me.Validate()
            SaleDetailsBindingSource.EndEdit()
            SaleDetailsTableAdapter.Update(DBWoodDataSet.SaleDetails)
        Catch ex As Exception
            MsgBox("SaleDetails Saving Failed Due To " + Err.Description, vbOKOnly, "Warning")
        End Try

        Try
            Me.Validate()
            SalesBindingSource.EndEdit()
            SalesTableAdapter.Update(DBWoodDataSet.Sales)
            MsgBox("تم الحفظ بنجاح", vbOKOnly, "Good")
            Close()
        Catch ex As Exception
            MsgBox("Sales Saving Failed Due To " + Err.Description, vbOKOnly, "Warning")
        End Try
    End Sub

    Private Sub SaleDetailsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SaleDetailsDataGridView.CellContentClick

    End Sub

    Private Sub SaleDetailsDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles SaleDetailsDataGridView.CellEndEdit
        'Quantity Changing'
        If e.ColumnIndex = 1 Then
            SaleDetailsDataGridView.CurrentRow.Cells("TbcDiscount_Value").Value = SaleDetailsDataGridView.CurrentRow.Cells("TbcQuantity").Value * SaleDetailsDataGridView.CurrentRow.Cells("TbcPrice").Value * SaleDetailsDataGridView.CurrentRow.Cells("TbcDiscount_Percentage").Value / 100
            SaleDetailsDataGridView.CurrentRow.Cells("TbcDiscount_Percentage").Value = SaleDetailsDataGridView.CurrentRow.Cells("TbcDiscount_Value").Value / (SaleDetailsDataGridView.CurrentRow.Cells("TbcQuantity").Value * SaleDetailsDataGridView.CurrentRow.Cells("TbcPrice").Value) * 100
            SaleDetailsDataGridView.CurrentRow.Cells("TbcTotal_Price").Value = SaleDetailsDataGridView.CurrentRow.Cells("TbcQuantity").Value * SaleDetailsDataGridView.CurrentRow.Cells("TbcPrice").Value - SaleDetailsDataGridView.CurrentRow.Cells("TbcDiscount_Value").Value

            'Calculating Totals'
            Dim i As Integer
            TxtSubtotal.Text = 0
            TxtDiscount.Text = 0
            TxtTotal.Text = 0
            For i = 0 To SaleDetailsDataGridView.Rows.Count() - 1
                TxtTotal.Text = Val(TxtTotal.Text) + SaleDetailsDataGridView.Rows(i).Cells("TbcTotal_Price").Value
                TxtDiscount.Text = Val(TxtDiscount.Text) + SaleDetailsDataGridView.Rows(i).Cells("TbcDiscount_Value").Value
            Next i
            TxtSubtotal.Text = Val(TxtTotal.Text) + Val(TxtDiscount.Text)
        End If


        'Discount Percentage Changing'
        If e.ColumnIndex = 3 Then
            SaleDetailsDataGridView.CurrentRow.Cells("TbcDiscount_Value").Value = SaleDetailsDataGridView.CurrentRow.Cells("TbcQuantity").Value * SaleDetailsDataGridView.CurrentRow.Cells("TbcPrice").Value * SaleDetailsDataGridView.CurrentRow.Cells("TbcDiscount_Percentage").Value / 100
            SaleDetailsDataGridView.CurrentRow.Cells("TbcTotal_Price").Value = SaleDetailsDataGridView.CurrentRow.Cells("TbcQuantity").Value * SaleDetailsDataGridView.CurrentRow.Cells("TbcPrice").Value - SaleDetailsDataGridView.CurrentRow.Cells("TbcDiscount_Value").Value

            'Calculating Totals'
            Dim i As Integer
            TxtSubtotal.Text = 0
            TxtDiscount.Text = 0
            TxtTotal.Text = 0
            For i = 0 To SaleDetailsDataGridView.Rows.Count() - 1
                TxtTotal.Text = Val(TxtTotal.Text) + SaleDetailsDataGridView.Rows(i).Cells("TbcTotal_Price").Value
                TxtDiscount.Text = Val(TxtDiscount.Text) + SaleDetailsDataGridView.Rows(i).Cells("TbcDiscount_Value").Value
            Next i
            TxtSubtotal.Text = Val(TxtTotal.Text) + Val(TxtDiscount.Text)
        End If


        'Discount Value Changing'
        If e.ColumnIndex = 4 Then
            SaleDetailsDataGridView.CurrentRow.Cells("TbcDiscount_Percentage").Value = SaleDetailsDataGridView.CurrentRow.Cells("TbcDiscount_Value").Value / (SaleDetailsDataGridView.CurrentRow.Cells("TbcQuantity").Value * SaleDetailsDataGridView.CurrentRow.Cells("TbcPrice").Value) * 100
            SaleDetailsDataGridView.CurrentRow.Cells("TbcTotal_Price").Value = SaleDetailsDataGridView.CurrentRow.Cells("TbcQuantity").Value * SaleDetailsDataGridView.CurrentRow.Cells("TbcPrice").Value - SaleDetailsDataGridView.CurrentRow.Cells("TbcDiscount_Value").Value

            'Calculating Totals'
            Dim i As Integer
            TxtSubtotal.Text = 0
            TxtDiscount.Text = 0
            TxtTotal.Text = 0
            For i = 0 To SaleDetailsDataGridView.Rows.Count() - 1
                TxtTotal.Text = Val(TxtTotal.Text) + SaleDetailsDataGridView.Rows(i).Cells("TbcTotal_Price").Value
                TxtDiscount.Text = Val(TxtDiscount.Text) + SaleDetailsDataGridView.Rows(i).Cells("TbcDiscount_Value").Value
            Next i
            TxtSubtotal.Text = Val(TxtTotal.Text) + Val(TxtDiscount.Text)

        End If
    End Sub

    Private Sub BtnFinish_Click(sender As Object, e As EventArgs) Handles BtnFinish.Click
        If FrmCashier.Visible = False Then
            MsgBox("من فضلك افتح الخزينة أولاً", vbOKOnly)
            FrmUsers.Show()
            Exit Sub
        Else

            'Cashier Editing'
            FrmCashier.ShiftTextBox.Text = Val(FrmCashier.ShiftTextBox.Text) + Val(TxtTotal.Text)

            'Items Stocks Editing'
            Dim i As Integer
            ItemsBindingSource.RemoveFilter()
            ItemsTableAdapter.Fill(DBWoodDataSet.Items)


            For i = 0 To SaleDetailsDataGridView.RowCount - 1
                ItemsBindingSource.Position = ItemsBindingSource.Find("Item_Name", SaleDetailsDataGridView.Rows(i).Cells("TbcItem_Name").Value.ToString)
                StockTextBox.Text = Val(StockTextBox.Text) - Val(SaleDetailsDataGridView.Rows(i).Cells("TbcQuantity").Value.ToString)
            Next i

            'Sales Editing'
            StatusTextBox.Text = "تمت"
            User_IDTextBox.Text = FrmCashier.User_IDTextBox.Text
            Cashier_IDTextBox.Text = FrmCashier.IDTextBox.Text

            'Saving Items'
            Try
                Me.Validate()
                ItemsBindingSource.EndEdit()
                ItemsTableAdapter.Update(DBWoodDataSet.Items)
            Catch ex As Exception
                MsgBox("Items Saving Failed Due To " + Err.Description, vbOKOnly, "Warning")
            End Try

            'Saving SaleDetails'
            Try
                Me.Validate()
                SaleDetailsBindingSource.EndEdit()
                SaleDetailsTableAdapter.Update(DBWoodDataSet.SaleDetails)
            Catch ex As Exception
                MsgBox("SaleDetails Saving Failed Due To " + Err.Description, vbOKOnly, "Warning")
            End Try

            'Saving Sales'
            Try
                Me.Validate()
                SalesBindingSource.EndEdit()
                SalesTableAdapter.Update(DBWoodDataSet.Sales)
                MsgBox("تم الحفظ بنجاح", vbOKOnly, "Good")
                Close()
            Catch ex As Exception
                MsgBox("Sales Saving Failed Due To " + Err.Description, vbOKOnly, "Warning")
            End Try

            'Saving Cashier'
            Try
                FrmCashier.Validate()
                FrmCashier.CashierBindingSource.EndEdit()
                FrmCashier.CashierTableAdapter.Update(FrmCashier.DBWoodDataSet.Cashier)
            Catch ex As Exception
                MsgBox("خطأ في حفظ الوردية" + Err.Description, vbOKOnly, "خطأ")
            End Try

        End If
    End Sub

    Private Sub Customer_NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Customer_NameComboBox.SelectedIndexChanged
        Customer_IDTextBox.Text = TxtCustomer_ID.Text
    End Sub
End Class