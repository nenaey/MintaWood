Public Class FrmSellingScreen2
    Private Sub FrmSellingScreen2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBWoodDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.DBWoodDataSet.Customers)
        'TODO: This line of code loads data into the 'DBWoodDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.DBWoodDataSet.Items)
        'TODO: This line of code loads data into the 'DBWoodDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.DBWoodDataSet.Sales)


    End Sub

    Private Sub SaleDetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SaleDetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SaleDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBWoodDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StatusTextBox.Text = "معلقة"
        Try
            Me.Validate()
            SaleDetailsBindingSource.EndEdit()
            SaleDetailsTableAdapter.Update(DBWoodDataSet.SaleDetails)

            SalesBindingSource.EndEdit()
            SalesTableAdapter.Update(DBWoodDataSet.Sales)
            MsgBox("تم الحفظ بنجاح", vbOKOnly, "Good")
            Close()

        Catch ex As Exception
            MsgBox("Saving Failed Due To " + Err.Description, vbOKOnly, "Warning")
        End Try
    End Sub
End Class