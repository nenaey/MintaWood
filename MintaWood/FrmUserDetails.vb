Public Class FrmUserDetails
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBWoodDataSet)

    End Sub

    Private Sub FrmUserDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBWoodDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DBWoodDataSet.Users)

    End Sub

    Private Sub CboPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPosition.SelectedIndexChanged
        PositionTextBox.Text = CboPosition.SelectedIndex
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If PasswordTextBox.Text = TxtRepeatPassword.Text Then
            Try
                Me.Validate()
                UsersBindingSource.EndEdit()
                UsersTableAdapter.Update(DBWoodDataSet.Users)
                MsgBox("Saving Successful", vbOKOnly, "Success")
                FrmUsers.UsersTableAdapter.Fill(FrmUsers.DBWoodDataSet.Users)
                Close()
            Catch ex As Exception
                MsgBox("Saving Failed", vbOKOnly, "Warning")
            End Try
        Else
            MsgBox("كلمة السر التي أدخلتها غير متطابقة", vbOKOnly, "Warning")
        End If


    End Sub
End Class