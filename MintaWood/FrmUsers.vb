Public Class FrmUsers
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBWoodDataSet)

    End Sub

    Private Sub FrmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBWoodDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DBWoodDataSet.Users)
        DateTimePicker1.Text = Today
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()

    End Sub

    Private Sub BtnNewUser_Click(sender As Object, e As EventArgs) Handles BtnNewUser.Click
        FrmUserDetails.Show()
        FrmUserDetails.UsersBindingSource.AddNew()

    End Sub

    Private Sub BtnOpenCashier_Click(sender As Object, e As EventArgs) Handles BtnOpenCashier.Click
        If Me.Text = "فتح الخزينة" Then

            UsersBindingSource.Filter = "User_Name = '" & User_NameComboBox.Text & "' And Password = '" & TxtPassword.Text & "'"
            If UsersBindingSource.Count = 1 Then
                FrmCashier.Show()
                FrmCashier.CashierBindingSource.Filter = "Status = 'مفتوحة'"
                If FrmCashier.CashierBindingSource.Count = 1 Then
                    If FrmCashier.User_IDTextBox.Text = IDTextBox.Text Then
                        Me.Close()
                    Else
                        MsgBox("يوجد وردية مفتوحة .. يجب إكمالها أو إغلاقها أولاً", vbOKOnly, "تحذير")
                        FrmCashier.Text = "يجب تغيير الوردية"
                        FrmCashier.Panel1.BackColor = Color.DarkRed
                        FrmCashier.Panel2.BackColor = Color.DarkRed
                        FrmCashierShifts.Show()
                        FrmCashierShifts.CashierBindingSource.Filter = "Status = 'مفتوحة'"
                    End If
                Else
                    FrmCashier.CashierBindingSource.AddNew()
                    FrmCashier.User_IDTextBox.Text = IDTextBox.Text
                    FrmCashier.Start_DateDateTimePicker.Text = DateTimePicker1.Value
                    FrmCashier.StatusTextBox.Text = "مفتوحة"
                    Try
                        FrmCashier.Validate()
                        FrmCashier.CashierBindingSource.EndEdit()
                        FrmCashier.CashierTableAdapter.Update(FrmCashier.DBWoodDataSet.Cashier)
                    Catch ex As Exception
                        MsgBox("خطأ في حفظ الوردية" + Err.Description, vbOKOnly, "خطأ")
                    End Try
                    Me.Close()
                End If
            Else
                MsgBox("كلمة السر التي أدخلتها غير صحيحة", vbOKOnly, "Warning")
                UsersBindingSource.RemoveFilter()
            End If
            Exit Sub
        End If

        If Me.Text = "تغيير الوردية" Then
            UsersBindingSource.Filter = "User_Name = '" & User_NameComboBox.Text & "' And Password = '" & TxtPassword.Text & "'"
            If UsersBindingSource.Count = 1 Then
                If FrmCashier.TxtFound.Text = "" Then
                    MsgBox("من فضلك أدخل الرقم الذي وجدته بعد أن قمت بالعد", vbOKOnly, "للتأكيد")
                    FrmCashier.TxtFound.Focus()
                Else
                    Try
                        FrmCashier.StatusTextBox.Text = "مغلقة"
                        FrmCashier.Validate()
                        FrmCashier.CashierBindingSource.EndEdit()
                        FrmCashier.CashierTableAdapter.Update(FrmCashier.DBWoodDataSet.Cashier)
                    Catch ex As Exception
                        MsgBox("خطأ في حفظ الوردية" + Err.Description, vbOKOnly, "خطأ")
                    End Try

                    Dim CashierStartingPoint As Double
                    CashierStartingPoint = Val(FrmCashier.TxtFound.Text)

                    FrmCashier.CashierBindingSource.AddNew()
                    FrmCashier.User_IDTextBox.Text = IDTextBox.Text
                    FrmCashier.Start_DateDateTimePicker.Text = DateTimePicker1.Value
                    FrmCashier.StatusTextBox.Text = "مفتوحة"
                    FrmCashier.Cash_StartTextBox.Text = CashierStartingPoint

                    Try
                        FrmCashier.Validate()
                        FrmCashier.CashierBindingSource.EndEdit()
                        FrmCashier.CashierTableAdapter.Update(FrmCashier.DBWoodDataSet.Cashier)
                    Catch ex As Exception
                        MsgBox("خطأ في حفظ الوردية" + Err.Description, vbOKOnly, "خطأ")
                    End Try

                    Me.Close()

                End If

            Else
                MsgBox("كلمة السر التي أدخلتها غير صحيحة", vbOKOnly, "Warning")
                UsersBindingSource.RemoveFilter()
            End If

        End If


    End Sub
End Class