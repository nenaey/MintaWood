Public Class FrmCashier
    Private Sub CashierBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CashierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBWoodDataSet)

    End Sub

    Private Sub FrmCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBWoodDataSet.Cashier' table. You can move, or remove it, as needed.
        Me.CashierTableAdapter.Fill(Me.DBWoodDataSet.Cashier)

    End Sub

    Private Sub ShiftTextBox_TextChanged(sender As Object, e As EventArgs) Handles ShiftTextBox.TextChanged
        Cash_FinalTextBox.Text = Val(Cash_StartTextBox.Text) + Val(ShiftTextBox.Text)

    End Sub

    Private Sub TxtFound_TextChanged(sender As Object, e As EventArgs) Handles TxtFound.TextChanged
        ErrorTextBox.Text = Val(TxtFound.Text) - Val(Cash_FinalTextBox.Text)
    End Sub

    Private Sub BtnChangeShift_Click(sender As Object, e As EventArgs) Handles BtnChangeShift.Click
        FrmUsers.Show()
        FrmUsers.Text = "تغيير الوردية"
        TxtFound.Text = ""
    End Sub

    Private Sub Cash_StartTextBox_TextChanged(sender As Object, e As EventArgs) Handles Cash_StartTextBox.TextChanged
        Cash_FinalTextBox.Text = Val(Cash_StartTextBox.Text) + Val(ShiftTextBox.Text)
    End Sub
End Class