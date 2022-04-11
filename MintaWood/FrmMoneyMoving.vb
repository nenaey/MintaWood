Public Class FrmMoneyMoving
    Private Sub MoneyTransactionsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MoneyTransactionsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBWoodDataSet)

    End Sub

    Private Sub FrmMoneyMoving_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBWoodDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.DBWoodDataSet.Sales)
        'TODO: This line of code loads data into the 'DBWoodDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.DBWoodDataSet.Customers)
        'TODO: This line of code loads data into the 'DBWoodDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DBWoodDataSet.Users)
        'TODO: This line of code loads data into the 'DBWoodDataSet.MoneyTransactions' table. You can move, or remove it, as needed.
        Me.MoneyTransactionsTableAdapter.Fill(Me.DBWoodDataSet.MoneyTransactions)

    End Sub

    Private Sub BtnFinish_Click(sender As Object, e As EventArgs) Handles BtnFinish.Click
        'Fees'
        If TabControl1.SelectedIndex = 0 And InOutTextBox.Text = "صادر" Then
            FrmCashier.Cash_OutTextBox.Text = Val(FrmCashier.Cash_OutTextBox.Text) + Val(MoneyTextBox.Text)
        End If

        'Money Movement'
        If TabControl1.SelectedIndex = 1 Then
            If TypeComboBox1.Text = "سحب نقود" Then
                FrmCashier.Cash_OutTextBox.Text = Val(FrmCashier.Cash_OutTextBox.Text) + Val(MoneyTextBox1.Text)
            ElseIf TypeComboBox1.Text = "إيداع نقود" Then
                FrmCashier.Cash_InTextBox.Text = Val(FrmCashier.Cash_InTextBox.Text) + Val(MoneyTextBox1.Text)
            End If
        End If

        'Loans'
        If TabControl1.SelectedIndex = 2 Then
            If TypeComboBox2.Text = "سداد قرض" Then
                FrmCashier.Cash_InTextBox.Text = Val(FrmCashier.Cash_InTextBox.Text) + Val(MoneyTextBox2.Text)
            ElseIf TypeComboBox2.Text = "أخذ قرض" Then
                FrmCashier.Cash_OutTextBox.Text = Val(FrmCashier.Cash_OutTextBox.Text) + Val(MoneyTextBox2.Text)
            End If
        End If


        Try
            Me.Validate()
            MoneyTransactionsBindingSource.EndEdit()
            MoneyTransactionsTableAdapter.Update(DBWoodDataSet.MoneyTransactions)

            FrmCashier.Validate()
            FrmCashier.CashierBindingSource.EndEdit()
            FrmCashier.CashierTableAdapter.Update(FrmCashier.DBWoodDataSet.Cashier)

            MsgBox("تم الحفظ بنجاح", vbOKOnly, "استمر")

            Me.Close()
        Catch ex As Exception
            MsgBox("حدث خطأ أثناء الحفظ .. رجاء المحاولة مرة أخرى", vbOKOnly, "تحذير")
        End Try

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyUp
        If e.KeyCode = Keys.Enter Then
            UsersBindingSource.Filter = "User_Name='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "'"
            UsersTableAdapter.Fill(DBWoodDataSet.Users)
            If UsersBindingSource.Count = 1 Then
                If PositionTextBox.Text = "1" Then
                    MoneyTextBox1.Enabled = True
                    DescriptionTextBox1.Text = TypeComboBox1.Text & " - " & TextBox1.Text
                    MoneyTextBox1.Focus()

                ElseIf PositionTextBox.Text <> "1" Then
                    MsgBox("للأسف لا يمكنك القيام بعملية تحويل النقود بسبب منصبك الوظيفي", vbOKOnly, "ممنوع")
                    Close()
                End If
            ElseIf UsersBindingSource.Count = 0 Then
                MsgBox("هناك خطأ في اسم المستخدم أو كلمة السر .. حاول مرة أخرى", vbOKOnly, "خطأ")

                TextBox1.Focus()
                TextBox1.Text = ""
                TextBox2.Text = ""
            End If
        End If
    End Sub

    Private Sub TypeComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeComboBox1.SelectedIndexChanged
        If TypeComboBox1.Text = "إيداع نقود" Then
            InOutTextBox.Text = "وارد"
        Else
            InOutTextBox.Text = "صادر"
        End If
    End Sub

    Private Sub TypeComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeComboBox2.SelectedIndexChanged
        DescriptionTextBox2.Text = TypeComboBox2.Text & " - " & Customer_NameComboBox.Text
        If TypeComboBox2.Text = "سداد قرض" Then
            InOutTextBox.Text = "وارد"
        Else
            InOutTextBox.Text = "صادر"
        End If
    End Sub

    Private Sub Customer_NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Customer_NameComboBox.SelectedIndexChanged
        DescriptionTextBox2.Text = TypeComboBox2.Text & " - " & Customer_NameComboBox.Text
    End Sub

    Private Sub Customer_NameComboBox_KeyUp(sender As Object, e As KeyEventArgs) Handles Customer_NameComboBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            CustomersBindingSource.Filter = "Customer_Name like '*" & Customer_NameComboBox.Text & "*'"
            Customer_NameComboBox.DroppedDown = True
        End If

        If e.KeyCode = Keys.Back And Customer_NameComboBox.Text = "" Then
            CustomersBindingSource.RemoveFilter()
            Customer_NameComboBox.DroppedDown = False
        End If
    End Sub

    Private Sub Customer_NameComboBox_LostFocus(sender As Object, e As EventArgs) Handles Customer_NameComboBox.LostFocus
        DescriptionTextBox2.Text = TypeComboBox2.Text & " - " & Customer_NameComboBox.Text
    End Sub
End Class