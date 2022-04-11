<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCashier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim User_IDLabel As System.Windows.Forms.Label
        Dim Start_DateLabel As System.Windows.Forms.Label
        Dim Cash_StartLabel As System.Windows.Forms.Label
        Dim Cash_FinalLabel As System.Windows.Forms.Label
        Dim Cash_InLabel As System.Windows.Forms.Label
        Dim Cash_OutLabel As System.Windows.Forms.Label
        Dim CreditLabel As System.Windows.Forms.Label
        Dim ShiftLabel As System.Windows.Forms.Label
        Dim ErrorLabel As System.Windows.Forms.Label
        Dim Transactions_CountLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.CashierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBWoodDataSet = New MintaWood.DBWoodDataSet()
        Me.User_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Start_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Cash_StartTextBox = New System.Windows.Forms.TextBox()
        Me.Cash_FinalTextBox = New System.Windows.Forms.TextBox()
        Me.Cash_InTextBox = New System.Windows.Forms.TextBox()
        Me.Cash_OutTextBox = New System.Windows.Forms.TextBox()
        Me.CreditTextBox = New System.Windows.Forms.TextBox()
        Me.ShiftTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFound = New System.Windows.Forms.TextBox()
        Me.BtnChangeShift = New System.Windows.Forms.Button()
        Me.ErrorTextBox = New System.Windows.Forms.TextBox()
        Me.Transactions_CountTextBox = New System.Windows.Forms.TextBox()
        Me.CashierTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.CashierTableAdapter()
        Me.TableAdapterManager = New MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        User_IDLabel = New System.Windows.Forms.Label()
        Start_DateLabel = New System.Windows.Forms.Label()
        Cash_StartLabel = New System.Windows.Forms.Label()
        Cash_FinalLabel = New System.Windows.Forms.Label()
        Cash_InLabel = New System.Windows.Forms.Label()
        Cash_OutLabel = New System.Windows.Forms.Label()
        CreditLabel = New System.Windows.Forms.Label()
        ShiftLabel = New System.Windows.Forms.Label()
        ErrorLabel = New System.Windows.Forms.Label()
        Transactions_CountLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CType(Me.CashierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(609, 17)
        IDLabel.Name = "IDLabel"
        IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        IDLabel.Size = New System.Drawing.Size(64, 16)
        IDLabel.TabIndex = 1
        IDLabel.Text = "رقم الوردية:"
        '
        'User_IDLabel
        '
        User_IDLabel.AutoSize = True
        User_IDLabel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_IDLabel.Location = New System.Drawing.Point(609, 56)
        User_IDLabel.Name = "User_IDLabel"
        User_IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        User_IDLabel.Size = New System.Drawing.Size(73, 16)
        User_IDLabel.TabIndex = 3
        User_IDLabel.Text = "رقم المستخدم:"
        '
        'Start_DateLabel
        '
        Start_DateLabel.AutoSize = True
        Start_DateLabel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Start_DateLabel.Location = New System.Drawing.Point(254, 19)
        Start_DateLabel.Name = "Start_DateLabel"
        Start_DateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Start_DateLabel.Size = New System.Drawing.Size(74, 16)
        Start_DateLabel.TabIndex = 5
        Start_DateLabel.Text = "تاريخ الوردية:"
        '
        'Cash_StartLabel
        '
        Cash_StartLabel.AutoSize = True
        Cash_StartLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cash_StartLabel.Location = New System.Drawing.Point(561, 169)
        Cash_StartLabel.Name = "Cash_StartLabel"
        Cash_StartLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Cash_StartLabel.Size = New System.Drawing.Size(103, 19)
        Cash_StartLabel.TabIndex = 7
        Cash_StartLabel.Text = "رقم بداية الوردية:"
        '
        'Cash_FinalLabel
        '
        Cash_FinalLabel.AutoSize = True
        Cash_FinalLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cash_FinalLabel.Location = New System.Drawing.Point(418, 17)
        Cash_FinalLabel.Name = "Cash_FinalLabel"
        Cash_FinalLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Cash_FinalLabel.Size = New System.Drawing.Size(93, 19)
        Cash_FinalLabel.TabIndex = 9
        Cash_FinalLabel.Text = "إجمالي الخزينة:"
        '
        'Cash_InLabel
        '
        Cash_InLabel.AutoSize = True
        Cash_InLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cash_InLabel.Location = New System.Drawing.Point(561, 215)
        Cash_InLabel.Name = "Cash_InLabel"
        Cash_InLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Cash_InLabel.Size = New System.Drawing.Size(109, 19)
        Cash_InLabel.TabIndex = 11
        Cash_InLabel.Text = "الوارد إلى الخزينة:"
        '
        'Cash_OutLabel
        '
        Cash_OutLabel.AutoSize = True
        Cash_OutLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cash_OutLabel.Location = New System.Drawing.Point(147, 211)
        Cash_OutLabel.Name = "Cash_OutLabel"
        Cash_OutLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Cash_OutLabel.Size = New System.Drawing.Size(113, 19)
        Cash_OutLabel.TabIndex = 13
        Cash_OutLabel.Text = "الخارج من الخزينة:"
        '
        'CreditLabel
        '
        CreditLabel.AutoSize = True
        CreditLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CreditLabel.Location = New System.Drawing.Point(147, 162)
        CreditLabel.Name = "CreditLabel"
        CreditLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        CreditLabel.Size = New System.Drawing.Size(147, 19)
        CreditLabel.TabIndex = 15
        CreditLabel.Text = "إجمالي ما لم يتم دفعه نقدا:"
        '
        'ShiftLabel
        '
        ShiftLabel.AutoSize = True
        ShiftLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ShiftLabel.Location = New System.Drawing.Point(384, 114)
        ShiftLabel.Name = "ShiftLabel"
        ShiftLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        ShiftLabel.Size = New System.Drawing.Size(81, 19)
        ShiftLabel.TabIndex = 17
        ShiftLabel.Text = "إيراد الوردية:"
        '
        'ErrorLabel
        '
        ErrorLabel.AutoSize = True
        ErrorLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ErrorLabel.Location = New System.Drawing.Point(147, 266)
        ErrorLabel.Name = "ErrorLabel"
        ErrorLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        ErrorLabel.Size = New System.Drawing.Size(43, 19)
        ErrorLabel.TabIndex = 20
        ErrorLabel.Text = "الخطأ:"
        '
        'Transactions_CountLabel
        '
        Transactions_CountLabel.AutoSize = True
        Transactions_CountLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Transactions_CountLabel.Location = New System.Drawing.Point(561, 269)
        Transactions_CountLabel.Name = "Transactions_CountLabel"
        Transactions_CountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Transactions_CountLabel.Size = New System.Drawing.Size(76, 19)
        Transactions_CountLabel.TabIndex = 21
        Transactions_CountLabel.Text = "عدد العملاء:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusLabel.Location = New System.Drawing.Point(253, 58)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        StatusLabel.Size = New System.Drawing.Size(65, 16)
        StatusLabel.TabIndex = 6
        StatusLabel.Text = "حالة الوردية:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CashierBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(479, 14)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(124, 23)
        Me.IDTextBox.TabIndex = 2
        '
        'CashierBindingSource
        '
        Me.CashierBindingSource.DataMember = "Cashier"
        Me.CashierBindingSource.DataSource = Me.DBWoodDataSet
        '
        'DBWoodDataSet
        '
        Me.DBWoodDataSet.DataSetName = "DBWoodDataSet"
        Me.DBWoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'User_IDTextBox
        '
        Me.User_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CashierBindingSource, "User_ID", True))
        Me.User_IDTextBox.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_IDTextBox.Location = New System.Drawing.Point(479, 52)
        Me.User_IDTextBox.Name = "User_IDTextBox"
        Me.User_IDTextBox.Size = New System.Drawing.Size(124, 23)
        Me.User_IDTextBox.TabIndex = 4
        '
        'Start_DateDateTimePicker
        '
        Me.Start_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CashierBindingSource, "Start_Date", True))
        Me.Start_DateDateTimePicker.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_DateDateTimePicker.Location = New System.Drawing.Point(9, 15)
        Me.Start_DateDateTimePicker.Name = "Start_DateDateTimePicker"
        Me.Start_DateDateTimePicker.Size = New System.Drawing.Size(239, 23)
        Me.Start_DateDateTimePicker.TabIndex = 6
        '
        'Cash_StartTextBox
        '
        Me.Cash_StartTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CashierBindingSource, "Cash_Start", True))
        Me.Cash_StartTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cash_StartTextBox.Location = New System.Drawing.Point(426, 162)
        Me.Cash_StartTextBox.Name = "Cash_StartTextBox"
        Me.Cash_StartTextBox.Size = New System.Drawing.Size(129, 26)
        Me.Cash_StartTextBox.TabIndex = 8
        Me.Cash_StartTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cash_FinalTextBox
        '
        Me.Cash_FinalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CashierBindingSource, "Cash_Final", True))
        Me.Cash_FinalTextBox.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cash_FinalTextBox.Location = New System.Drawing.Point(231, 8)
        Me.Cash_FinalTextBox.Name = "Cash_FinalTextBox"
        Me.Cash_FinalTextBox.Size = New System.Drawing.Size(182, 38)
        Me.Cash_FinalTextBox.TabIndex = 10
        Me.Cash_FinalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cash_InTextBox
        '
        Me.Cash_InTextBox.BackColor = System.Drawing.Color.YellowGreen
        Me.Cash_InTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CashierBindingSource, "Cash_In", True))
        Me.Cash_InTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cash_InTextBox.ForeColor = System.Drawing.Color.White
        Me.Cash_InTextBox.Location = New System.Drawing.Point(425, 212)
        Me.Cash_InTextBox.Name = "Cash_InTextBox"
        Me.Cash_InTextBox.Size = New System.Drawing.Size(129, 26)
        Me.Cash_InTextBox.TabIndex = 12
        Me.Cash_InTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cash_OutTextBox
        '
        Me.Cash_OutTextBox.BackColor = System.Drawing.Color.Red
        Me.Cash_OutTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CashierBindingSource, "Cash_Out", True))
        Me.Cash_OutTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cash_OutTextBox.ForeColor = System.Drawing.Color.White
        Me.Cash_OutTextBox.Location = New System.Drawing.Point(12, 208)
        Me.Cash_OutTextBox.Name = "Cash_OutTextBox"
        Me.Cash_OutTextBox.Size = New System.Drawing.Size(129, 26)
        Me.Cash_OutTextBox.TabIndex = 14
        Me.Cash_OutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CreditTextBox
        '
        Me.CreditTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CashierBindingSource, "Credit", True))
        Me.CreditTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditTextBox.Location = New System.Drawing.Point(12, 159)
        Me.CreditTextBox.Name = "CreditTextBox"
        Me.CreditTextBox.Size = New System.Drawing.Size(129, 26)
        Me.CreditTextBox.TabIndex = 16
        Me.CreditTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ShiftTextBox
        '
        Me.ShiftTextBox.BackColor = System.Drawing.Color.Indigo
        Me.ShiftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CashierBindingSource, "Shift", True))
        Me.ShiftTextBox.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShiftTextBox.ForeColor = System.Drawing.Color.White
        Me.ShiftTextBox.Location = New System.Drawing.Point(231, 104)
        Me.ShiftTextBox.Name = "ShiftTextBox"
        Me.ShiftTextBox.Size = New System.Drawing.Size(146, 38)
        Me.ShiftTextBox.TabIndex = 18
        Me.ShiftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(StatusLabel)
        Me.Panel1.Controls.Add(Me.StatusTextBox)
        Me.Panel1.Controls.Add(Me.User_IDTextBox)
        Me.Panel1.Controls.Add(User_IDLabel)
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Controls.Add(Start_DateLabel)
        Me.Panel1.Controls.Add(IDLabel)
        Me.Panel1.Controls.Add(Me.Start_DateDateTimePicker)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(702, 97)
        Me.Panel1.TabIndex = 19
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CashierBindingSource, "Status", True))
        Me.StatusTextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusTextBox.Location = New System.Drawing.Point(147, 55)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusTextBox.Size = New System.Drawing.Size(100, 22)
        Me.StatusTextBox.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TxtFound)
        Me.Panel2.Controls.Add(Me.BtnChangeShift)
        Me.Panel2.Controls.Add(Me.Cash_FinalTextBox)
        Me.Panel2.Controls.Add(Cash_FinalLabel)
        Me.Panel2.Location = New System.Drawing.Point(0, 328)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(702, 108)
        Me.Panel2.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(419, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(87, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "وجدت بعد العد:"
        '
        'TxtFound
        '
        Me.TxtFound.BackColor = System.Drawing.Color.Black
        Me.TxtFound.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFound.ForeColor = System.Drawing.Color.White
        Me.TxtFound.Location = New System.Drawing.Point(231, 59)
        Me.TxtFound.Name = "TxtFound"
        Me.TxtFound.Size = New System.Drawing.Size(182, 26)
        Me.TxtFound.TabIndex = 12
        Me.TxtFound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnChangeShift
        '
        Me.BtnChangeShift.Location = New System.Drawing.Point(9, 8)
        Me.BtnChangeShift.Name = "BtnChangeShift"
        Me.BtnChangeShift.Size = New System.Drawing.Size(85, 74)
        Me.BtnChangeShift.TabIndex = 11
        Me.BtnChangeShift.Text = "تغيير الوردية"
        Me.BtnChangeShift.UseVisualStyleBackColor = True
        '
        'ErrorTextBox
        '
        Me.ErrorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CashierBindingSource, "Error", True))
        Me.ErrorTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorTextBox.Location = New System.Drawing.Point(12, 260)
        Me.ErrorTextBox.Name = "ErrorTextBox"
        Me.ErrorTextBox.Size = New System.Drawing.Size(129, 26)
        Me.ErrorTextBox.TabIndex = 21
        Me.ErrorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Transactions_CountTextBox
        '
        Me.Transactions_CountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CashierBindingSource, "Transactions_Count", True))
        Me.Transactions_CountTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Transactions_CountTextBox.Location = New System.Drawing.Point(426, 266)
        Me.Transactions_CountTextBox.Name = "Transactions_CountTextBox"
        Me.Transactions_CountTextBox.Size = New System.Drawing.Size(128, 26)
        Me.Transactions_CountTextBox.TabIndex = 22
        Me.Transactions_CountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CashierTableAdapter
        '
        Me.CashierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CashierTableAdapter = Me.CashierTableAdapter
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.PurchaseDetailsTableAdapter = Nothing
        Me.TableAdapterManager.PurchasesTableAdapter = Nothing
        Me.TableAdapterManager.SaleDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'FrmCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 436)
        Me.Controls.Add(Transactions_CountLabel)
        Me.Controls.Add(Me.Transactions_CountTextBox)
        Me.Controls.Add(ErrorLabel)
        Me.Controls.Add(Me.ErrorTextBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(ShiftLabel)
        Me.Controls.Add(Me.ShiftTextBox)
        Me.Controls.Add(Cash_StartLabel)
        Me.Controls.Add(Me.Cash_StartTextBox)
        Me.Controls.Add(Cash_InLabel)
        Me.Controls.Add(Me.Cash_InTextBox)
        Me.Controls.Add(Cash_OutLabel)
        Me.Controls.Add(Me.Cash_OutTextBox)
        Me.Controls.Add(CreditLabel)
        Me.Controls.Add(Me.CreditTextBox)
        Me.Name = "FrmCashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الخزينة"
        CType(Me.CashierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBWoodDataSet As DBWoodDataSet
    Friend WithEvents CashierBindingSource As BindingSource
    Friend WithEvents CashierTableAdapter As DBWoodDataSetTableAdapters.CashierTableAdapter
    Friend WithEvents TableAdapterManager As DBWoodDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents User_IDTextBox As TextBox
    Friend WithEvents Start_DateDateTimePicker As DateTimePicker
    Friend WithEvents Cash_StartTextBox As TextBox
    Friend WithEvents Cash_FinalTextBox As TextBox
    Friend WithEvents Cash_InTextBox As TextBox
    Friend WithEvents Cash_OutTextBox As TextBox
    Friend WithEvents CreditTextBox As TextBox
    Friend WithEvents ShiftTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnChangeShift As Button
    Friend WithEvents ErrorTextBox As TextBox
    Friend WithEvents Transactions_CountTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtFound As TextBox
    Friend WithEvents StatusTextBox As TextBox
End Class
