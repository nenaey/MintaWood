Public Class FrmCubitization
    Private Sub ItemsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ItemsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ItemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBWoodDataSet)

    End Sub

    Private Sub FrmCubitization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBWoodDataSet.Cubitization' table. You can move, or remove it, as needed.
        Me.CubitizationTableAdapter.Fill(Me.DBWoodDataSet.Cubitization)
        'TODO: This line of code loads data into the 'DBWoodDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.DBWoodDataSet.Items)

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        CubitizationBindingSource.AddNew()
        CubitizationDataGridView.CurrentRow.Cells("TBCItemID").Value = IDTextBox.Text
        CubitizationDataGridView.CurrentRow.Cells("TbcPartsCount").Value = 0
        CubitizationDataGridView.CurrentRow.Cells("TbcLength").Value = 0
        CubitizationDataGridView.CurrentRow.Cells("TbcWidth").Value = 0
        CubitizationDataGridView.CurrentRow.Cells("TbcThickness").Value = 0
        CubitizationDataGridView.CurrentRow.Cells("TbcTotalCube").Value = 0
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        CubitizationBindingSource.RemoveCurrent()

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Me.Validate()
            CubitizationBindingSource.EndEdit()
            CubitizationTableAdapter.Update(DBWoodDataSet.Cubitization)
            ItemsBindingSource.EndEdit()
            ItemsTableAdapter.Update(DBWoodDataSet.Items)
            MsgBox("تم الحفظ بنجاح", vbOKOnly, "استمر")
        Catch ex As Exception
            MsgBox("حدث خطأ ما أثناء عملية الحفظ .. برجاء المحاولة مرة أخرى", vbOKOnly, "تحذير")
        End Try

        FrmItemDetails.ItemsTableAdapter.Fill(FrmItemDetails.DBWoodDataSet.Items)

    End Sub

    Private Sub CubitizationDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CubitizationDataGridView.CellContentClick

    End Sub

    Private Sub CubitizationDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles CubitizationDataGridView.CellEndEdit
        If e.ColumnIndex = 1 Or 2 Or 3 Or 4 Then
            Try
                CubitizationDataGridView.CurrentRow.Cells("TbcTotalCube").Value = CubitizationDataGridView.CurrentRow.Cells("TbcPartsCount").Value * CubitizationDataGridView.CurrentRow.Cells("TbcLength").Value * (CubitizationDataGridView.CurrentRow.Cells("TbcWidth").Value / 10) * (CubitizationDataGridView.CurrentRow.Cells("TbcThickness").Value / 10)
                Dim i As Integer
                CubeTextBox.Text = 0
                For i = 0 To CubitizationDataGridView.Rows.Count() - 1
                    CubeTextBox.Text = Val(CubeTextBox.Text) + CubitizationDataGridView.Rows(i).Cells("TbcTotalCube").Value
                Next i
            Catch ex As Exception
                MsgBox("من فضلك أدخل قيمة رقمية", vbOKOnly, "خطأ في الإدخال")
            End Try
            CubeTextBox.Text = Val(CubeTextBox.Text) / 10000
            CubeTextBox.Text = Format(Val(CubeTextBox.Text), "#0.0000")
        End If


    End Sub

    Private Sub CubitizationDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles CubitizationDataGridView.DataError
        If e.ColumnIndex = 1 Or 2 Or 3 Or 4 Then
            MsgBox("من فضلك أدخل قيمة رقمية", vbOKOnly, "خطأ خطير في الإدخال")
        End If
    End Sub

End Class