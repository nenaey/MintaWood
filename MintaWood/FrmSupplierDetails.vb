Public Class FrmSupplierDetails
    Private Sub SuppliersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBWoodDataSet)

    End Sub

    Private Sub FrmSupplierDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBWoodDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.DBWoodDataSet.Suppliers)

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Me.Validate()
            SuppliersBindingSource.EndEdit()
            SuppliersTableAdapter.Update(DBWoodDataSet.Suppliers)
            MsgBox("تم حفظ البيانات بنجاح", vbOKOnly, "استمر")
        Catch ex As Exception
            MsgBox("لم يتم حفظ البيانات", vbOKOnly, "خطأ")
        End Try
        If FrmSuppliers.Visible = True Then
            FrmSuppliers.SuppliersTableAdapter.Fill(FrmSuppliers.DBWoodDataSet.Suppliers)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim Ans
        Try
            Ans = MsgBox("هل ترغب حقاً في إزالة بيانات المورد " + Supplier_NameTextBox.Text + " ?", vbYesNo, "تأكيد")
            If Ans = 6 Then
                SuppliersBindingSource.RemoveCurrent()
                Me.Validate()
                SuppliersBindingSource.EndEdit()
                SuppliersTableAdapter.Update(DBWoodDataSet.Suppliers)
                MsgBox("تم محو بيانات المورد بنجاح", vbOKOnly, "Success")
                FrmSuppliers.SuppliersTableAdapter.Update(FrmSuppliers.DBWoodDataSet.Suppliers)
                FrmSuppliers.SuppliersTableAdapter.Fill(FrmSuppliers.DBWoodDataSet.Suppliers)
                Me.Close()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("حدث خطأ ما برجاء المحاولة مرة أخرى", vbOKOnly, "Warning")
        End Try
    End Sub
End Class