Public Class FrmSuppliers
    Private Sub SuppliersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBWoodDataSet)

    End Sub

    Private Sub FrmSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBWoodDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.DBWoodDataSet.Suppliers)

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        FrmSupplierDetails.Show()
        FrmSupplierDetails.SuppliersBindingSource.AddNew()

    End Sub

    Private Sub BtnDetails_Click(sender As Object, e As EventArgs) Handles BtnDetails.Click
        FrmSupplierDetails.Show()
        FrmSupplierDetails.SuppliersBindingSource.Filter = "Supplier_Name = '" & Supplier_NameComboBox.Text & "'"
    End Sub

    Private Sub BtnNewInvoice_Click(sender As Object, e As EventArgs) Handles BtnNewInvoice.Click
        If FrmNewInvoice.CanFocus = False Then
            If FrmCashier.CanFocus = True Then
                FrmNewInvoice.Show()
                FrmNewInvoice.PurchasesBindingSource.AddNew()
                FrmNewInvoice.User_IDTextBox.Text = FrmCashier.User_IDTextBox.Text
                FrmNewInvoice.StatusTextBox.Text = "معلقة"
                FrmNewInvoice.Purchase_DateDateTimePicker.Value = FrmCashier.Start_DateDateTimePicker.Text
                FrmNewInvoice.Purchase_TimeDateTimePicker.Value = Now
                FrmNewInvoice.Supplier_NameTextBox.Text = Supplier_NameComboBox.Text
                FrmNewInvoice.Supplier_IDTextBox.Text = IDTextBox.Text
            Else
                MsgBox("من فضلك افتح الخزينة أولاً", vbOKOnly)
                FrmUsers.Show()
            End If
        Else
            FrmNewInvoice.WindowState = FormWindowState.Normal
            FrmNewInvoice.BringToFront()
        End If


    End Sub
End Class