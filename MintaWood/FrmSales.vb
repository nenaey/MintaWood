Public Class FrmSales
    Private Sub SalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBWoodDataSet)

    End Sub

    Private Sub FrmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBWoodDataSet.SalesQuery' table. You can move, or remove it, as needed.
        Me.SalesQueryTableAdapter.Fill(Me.DBWoodDataSet.SalesQuery)
        'TODO: This line of code loads data into the 'DBWoodDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.DBWoodDataSet.Sales)

    End Sub

    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        If SalesQueryDataGridView.RowCount = 0 Then
            MsgBox("لا يوجد عمليات بيع لكي أفتحها", vbOKOnly, "تعجب !")
            Exit Sub
        End If

        If SalesQueryDataGridView.CurrentRow.Cells("TbcStatus").Value = "معلقة" Then
            FrmSellingScreen1.Show()
            FrmSellingScreen1.SalesBindingSource.Filter = "ID = '" & SalesQueryDataGridView.CurrentRow.Cells("TbcID").Value & "'"
            FrmSellingScreen1.SaleDetailsBindingSource.Filter = "Sale_ID = '" & SalesQueryDataGridView.CurrentRow.Cells("TbcID").Value & "'"

            FrmSellingScreen1.SalesTableAdapter.Fill(FrmSellingScreen1.DBWoodDataSet.Sales)
            FrmSellingScreen1.SaleDetailsTableAdapter.Fill(FrmSellingScreen1.DBWoodDataSet.SaleDetails)
        End If
    End Sub
End Class