Public Class FrmNewInvoice
    Private Sub FrmNewInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBWoodDataSet.SaleDetails' table. You can move, or remove it, as needed.
        Me.SaleDetailsTableAdapter.Fill(Me.DBWoodDataSet.SaleDetails)
        'TODO: This line of code loads data into the 'DBWoodDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.DBWoodDataSet.Items)

        'TODO: This line of code loads data into the 'DBWoodDataSet.Purchases' table. You can move, or remove it, as needed.
        Me.PurchasesTableAdapter.Fill(Me.DBWoodDataSet.Purchases)

    End Sub

    Private Sub PurchasesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PurchasesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBWoodDataSet)

    End Sub

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
        PurchaseDetailsBindingSource.AddNew()
        PurchaseDetailsDataGridView.CurrentRow.Cells("TbcPurchase_ID").Value = IDTextBox.Text
        PurchaseDetailsDataGridView.CurrentRow.Cells("TbcItem_Name").Value = Item_NameComboBox.Text
        PurchaseDetailsDataGridView.CurrentRow.Cells("TbcItem_ID").Value = TxtItem_ID.Text
        PurchaseDetailsDataGridView.CurrentRow.Cells("TbcSupplier_Price").Value = Supplier_PriceTextBox.Text
        PurchaseDetailsDataGridView.CurrentRow.Cells("TbcPublic_Price").Value = Public_PriceTextBox.Text
        PurchaseDetailsDataGridView.CurrentRow.Cells("TbcProfit_Percentage").Value = 100 * (1 - (PurchaseDetailsDataGridView.CurrentRow.Cells("TbcSupplier_Price").Value / PurchaseDetailsDataGridView.CurrentRow.Cells("TbcPublic_Price").Value))


        PurchaseDetailsDataGridView.CurrentCell = PurchaseDetailsDataGridView.CurrentRow.Cells("TbcItem_Quantity")
        PurchaseDetailsDataGridView.BeginEdit(True)

    End Sub

    Private Sub PurchaseDetailsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PurchaseDetailsDataGridView.CellContentClick

    End Sub

    Private Sub PurchaseDetailsDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles PurchaseDetailsDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            Item_NameComboBox.Focus()
        End If
    End Sub

    Private Sub PurchaseDetailsDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles PurchaseDetailsDataGridView.CellEndEdit

        'Quantity Change
        If e.ColumnIndex = 1 Then
            PurchaseDetailsDataGridView.CurrentRow.Cells("TbcTotal_Supplier_Price").Value = PurchaseDetailsDataGridView.CurrentRow.Cells("TbcItem_Quantity").Value * PurchaseDetailsDataGridView.CurrentRow.Cells("TbcSupplier_Price").Value

            'Calculating invoice totals
            SubtotalTextBox.Text = 0
            Items_CountTextBox.Text = 0
            Dim i As Integer
            For i = 0 To PurchaseDetailsDataGridView.RowCount - 1
                SubtotalTextBox.Text += PurchaseDetailsDataGridView.Rows(i).Cells("TbcTotal_Supplier_Price").Value
                Items_CountTextBox.Text += PurchaseDetailsDataGridView.Rows(i).Cells("TbcItem_Quantity").Value
            Next i
            TotalTextBox.Text = Val(SubtotalTextBox.Text) - Val(Discount_ValueTextBox.Text)
            Sorts_CountTextBox.Text = PurchaseDetailsDataGridView.RowCount
        End If

        'Supplier_Price Change
        If e.ColumnIndex = 2 Then
            PurchaseDetailsDataGridView.CurrentRow.Cells("TbcTotal_Supplier_Price").Value = PurchaseDetailsDataGridView.CurrentRow.Cells("TbcItem_Quantity").Value * PurchaseDetailsDataGridView.CurrentRow.Cells("TbcSupplier_Price").Value
            PurchaseDetailsDataGridView.CurrentRow.Cells("TbcProfit_Percentage").Value = 100 * (1 - (PurchaseDetailsDataGridView.CurrentRow.Cells("TbcSupplier_Price").Value / PurchaseDetailsDataGridView.CurrentRow.Cells("TbcPublic_Price").Value))

            'Calculating invoice totals
            SubtotalTextBox.Text = 0
            Items_CountTextBox.Text = 0
            Dim i As Integer
            For i = 0 To PurchaseDetailsDataGridView.RowCount - 1
                SubtotalTextBox.Text += PurchaseDetailsDataGridView.Rows(i).Cells("TbcTotal_Supplier_Price").Value
                Items_CountTextBox.Text += PurchaseDetailsDataGridView.Rows(i).Cells("TbcItem_Quantity").Value
            Next i
            TotalTextBox.Text = Val(SubtotalTextBox.Text) - Val(Discount_ValueTextBox.Text)
            Sorts_CountTextBox.Text = PurchaseDetailsDataGridView.RowCount
        End If

        'Public_Price Change
        If e.ColumnIndex = 3 Then
            PurchaseDetailsDataGridView.CurrentRow.Cells("TbcProfit_Percentage").Value = 100 * (1 - (PurchaseDetailsDataGridView.CurrentRow.Cells("TbcSupplier_Price").Value / PurchaseDetailsDataGridView.CurrentRow.Cells("TbcPublic_Price").Value))
        End If

        'Profit_Percentage Change
        If e.ColumnIndex = 4 Then
            PurchaseDetailsDataGridView.CurrentRow.Cells("TbcPublic_Price").Value = PurchaseDetailsDataGridView.CurrentRow.Cells("TbcSupplier_Price").Value * 100 / (100 - PurchaseDetailsDataGridView.CurrentRow.Cells("TbcProfit_Percentage").Value)
        End If


    End Sub

    Private Sub BtnTempoSave_Click(sender As Object, e As EventArgs) Handles BtnTempoSave.Click
        Try
            Me.Validate()
            PurchasesBindingSource.EndEdit()
            PurchasesTableAdapter.Update(DBWoodDataSet.Purchases)

            PurchaseDetailsBindingSource.EndEdit()
            PurchaseDetailsTableAdapter.Update(DBWoodDataSet.PurchaseDetails)

            MsgBox("تم الحفظ بنجاح", vbOKOnly, "نجاح")
        Catch ex As Exception
            MsgBox("للأسف لم يتم الحفظ" + Err.Description, vbOKOnly, "تحذير")
        End Try

        Me.Close()

    End Sub

    Private Sub Discount_ValueTextBox_TextChanged(sender As Object, e As EventArgs) Handles Discount_ValueTextBox.TextChanged
        TotalTextBox.Text = Val(SubtotalTextBox.Text) - Val(Discount_ValueTextBox.Text)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        PurchaseDetailsBindingSource.RemoveCurrent()

        'Calculating invoice totals
        SubtotalTextBox.Text = 0
        Items_CountTextBox.Text = 0
        Dim i As Integer
        For i = 0 To PurchaseDetailsDataGridView.RowCount - 1
            SubtotalTextBox.Text += PurchaseDetailsDataGridView.Rows(i).Cells("TbcTotal_Supplier_Price").Value
            Items_CountTextBox.Text += PurchaseDetailsDataGridView.Rows(i).Cells("TbcItem_Quantity").Value
        Next i
        TotalTextBox.Text = Val(SubtotalTextBox.Text) - Val(Discount_ValueTextBox.Text)
        Sorts_CountTextBox.Text = PurchaseDetailsDataGridView.RowCount
    End Sub

    Private Sub BtnFinish_Click(sender As Object, e As EventArgs) Handles BtnFinish.Click

        'Items Stocks Editing'
        Dim i As Integer
        ItemsBindingSource.RemoveFilter()
        ItemsTableAdapter.Fill(DBWoodDataSet.Items)


        For i = 0 To PurchaseDetailsDataGridView.RowCount - 1
            ItemsBindingSource.Position = ItemsBindingSource.Find("Item_Name", PurchaseDetailsDataGridView.Rows(i).Cells("TbcItem_Name").Value.ToString)
            StockTextBox.Text = Val(StockTextBox.Text) + Val(PurchaseDetailsDataGridView.Rows(i).Cells("TbcItem_Quantity").Value.ToString)
            Public_PriceTextBox.Text = PurchaseDetailsDataGridView.Rows(i).Cells("TbcPublic_Price").Value
            Supplier_PriceTextBox.Text = PurchaseDetailsDataGridView.Rows(i).Cells("TbcSupplier_Price").Value
        Next i

        StatusTextBox.Text = "تمت"

        Try
            Me.Validate()
            PurchasesBindingSource.EndEdit()
            PurchasesTableAdapter.Update(DBWoodDataSet.Purchases)

            PurchaseDetailsBindingSource.EndEdit()
            PurchaseDetailsTableAdapter.Update(DBWoodDataSet.PurchaseDetails)
            Try
                ItemsBindingSource.EndEdit()
                ItemsTableAdapter.Update(DBWoodDataSet.Items)
            Catch ex As Exception
                MsgBox("للأسف لم يتم إضافة كميات الفاتورة إلى المخزون" + Err.Description, vbOKOnly, "تحذير خطير")
            End Try

            MsgBox("تم الحفظ بنجاح", vbOKOnly, "نجاح")
        Catch ex As Exception
            MsgBox("للأسف لم يتم الحفظ" + Err.Description, vbOKOnly, "تحذير")
        End Try

        Me.Close()

    End Sub
End Class