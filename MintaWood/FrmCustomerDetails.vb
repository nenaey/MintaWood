Public Class FrmCustomerDetails
    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBWoodDataSet)

    End Sub

    Private Sub FrmCustomerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBWoodDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.DBWoodDataSet.Customers)

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Customer_NameTextBox.Text <> "" Then
            Try
                Me.Validate()
                CustomersBindingSource.EndEdit()
                CustomersTableAdapter.Update(DBWoodDataSet.Customers)
                MsgBox("تم حفظ بيانات العميل بنجاح", vbOKOnly, "Success")
                FrmCustomers.CustomersTableAdapter.Update(FrmCustomers.DBWoodDataSet.Customers)
                FrmCustomers.CustomersTableAdapter.Fill(FrmCustomers.DBWoodDataSet.Customers)
                Me.Close()
            Catch ex As Exception
                MsgBox("لم يتم الحفظ", vbOKOnly, "Warning")
            End Try
        Else
            MsgBox("من فضلك أدخل اسم العميل", vbOKOnly, "Warning")
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim Ans
        Try
            Ans = MsgBox("هل ترغب حقاً في إزالة بيانات العميل " + Customer_NameTextBox.Text + " ?", vbYesNo, "تأكيد")
            If Ans = 6 Then
                CustomersBindingSource.RemoveCurrent()
                Me.Validate()
                CustomersBindingSource.EndEdit()
                CustomersTableAdapter.Update(DBWoodDataSet.Customers)
                MsgBox("تم محو بيانات العميل بنجاح", vbOKOnly, "Success")
                FrmCustomers.CustomersTableAdapter.Update(FrmCustomers.DBWoodDataSet.Customers)
                FrmCustomers.CustomersTableAdapter.Fill(FrmCustomers.DBWoodDataSet.Customers)
                Me.Close()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("حدث خطأ ما برجاء المحاولة مرة أخرى", vbOKOnly, "Warning")
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()

    End Sub
End Class