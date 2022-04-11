Public Class FrmCustomers
    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBWoodDataSet)

    End Sub

    Private Sub FrmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBWoodDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.DBWoodDataSet.Customers)

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()

    End Sub

    Private Sub BtnNewCustomer_Click(sender As Object, e As EventArgs) Handles BtnNewCustomer.Click
        FrmCustomerDetails.Show()

        FrmCustomerDetails.CustomersBindingSource.AddNew()

    End Sub

    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        FrmCustomerDetails.Show()
        FrmCustomerDetails.CustomersBindingSource.Filter = "Customer_Name = '" & Customer_NameComboBox.Text & "'"
        Me.Close()
    End Sub

    Private Sub Customer_NameLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class