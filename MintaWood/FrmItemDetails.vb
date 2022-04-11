Imports System.ComponentModel

Public Class FrmItemDetails
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Me.Validate()
            ItemsBindingSource.EndEdit()
            ItemsTableAdapter.Update(DBWoodDataSet.Items)
            MsgBox("Saving Successful", vbOKOnly, "Good")
        Catch ex As Exception
            MsgBox(Err.Description, vbOKOnly, "Warning")
        End Try
    End Sub

    Private Sub ItemsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ItemsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ItemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBWoodDataSet)

    End Sub

    Private Sub FrmItemDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBWoodDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.DBWoodDataSet.Items)

    End Sub

    Private Sub FrmItemDetails_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmItems.ItemsQueryTableAdapter.Fill(FrmItems.DBWoodDataSet.ItemsQuery)
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        Dim Response As String
        Response = MsgBox("هل ترغب في إزالة الصنف " + Item_NameTextBox.Text + " ؟", MessageBoxButtons.YesNo, "Warning")
        If Response = vbYes Then
            ItemsBindingSource.RemoveCurrent()
        Else
            Exit Sub
        End If


    End Sub

    Private Sub BtnCubitization_Click(sender As Object, e As EventArgs) Handles BtnCubitization.Click
        FrmCubitization.Show()
        FrmCubitization.ItemsBindingSource.Filter = "ID = '" & Val(IDTextBox.Text) & "'"
        FrmCubitization.CubitizationBindingSource.Filter = "Item_ID = '" & Val(IDTextBox.Text) & "'"
    End Sub
End Class