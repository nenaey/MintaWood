Public Class FrmMoneyTransactions
    Private Sub FrmMoneyTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBWoodDataSet.MoneyTransactionsQuery' table. You can move, or remove it, as needed.
        Me.MoneyTransactionsQueryTableAdapter.Fill(Me.DBWoodDataSet.MoneyTransactionsQuery)

    End Sub

    Private Sub ComboBoxTransaction_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTransaction_Type.SelectedIndexChanged
        MoneyTransactionsQueryBindingSource.Filter = "type = '" & ComboBoxTransaction_Type.Text & "'"
    End Sub
End Class