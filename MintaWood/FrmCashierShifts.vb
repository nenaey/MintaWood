Public Class FrmCashierShifts
    Private Sub CashierBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CashierBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CashierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBWoodDataSet)

    End Sub

    Private Sub FrmCashierShifts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBWoodDataSet.Cashier' table. You can move, or remove it, as needed.
        Me.CashierTableAdapter.Fill(Me.DBWoodDataSet.Cashier)

    End Sub
End Class