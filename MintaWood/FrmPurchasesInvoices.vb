Public Class FrmPurchasesInvoices

    Private Sub FrmPurchasesInvoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBWoodDataSet.QueryPurchases' table. You can move, or remove it, as needed.
        Me.QueryPurchasesTableAdapter.Fill(Me.DBWoodDataSet.QueryPurchases)
        'TODO: This line of code loads data into the 'DBWoodDataSet.QueryPurchases' table. You can move, or remove it, as needed.
        Me.QueryPurchasesTableAdapter.Fill(Me.DBWoodDataSet.QueryPurchases)


    End Sub

    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        FrmNewInvoice.Show()
        FrmNewInvoice.PurchasesBindingSource.Filter = "ID = '" & QueryPurchasesDataGridView.CurrentRow.Cells("TbcID").Value & "'"

        FrmNewInvoice.PurchaseDetailsBindingSource.Filter = "Purchase_ID = '" & QueryPurchasesDataGridView.CurrentRow.Cells("TbcID").Value & "'"
        FrmNewInvoice.PurchaseDetailsTableAdapter.Fill(FrmNewInvoice.DBWoodDataSet.PurchaseDetails)
    End Sub
End Class