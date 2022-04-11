<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMoneyMoving
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
        Dim Transaction_DateLabel As System.Windows.Forms.Label
        Dim Cashier_IDLabel As System.Windows.Forms.Label
        Dim User_IDLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim MoneyLabel As System.Windows.Forms.Label
        Dim InOutLabel As System.Windows.Forms.Label
        Dim TypeLabel1 As System.Windows.Forms.Label
        Dim MoneyLabel1 As System.Windows.Forms.Label
        Dim DescriptionLabel1 As System.Windows.Forms.Label
        Dim User_NameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim MoneyLabel2 As System.Windows.Forms.Label
        Dim Customer_NameLabel As System.Windows.Forms.Label
        Dim DescriptionLabel2 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.User_IDTextBox = New System.Windows.Forms.TextBox()
        Me.MoneyTransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBWoodDataSet = New MintaWood.DBWoodDataSet()
        Me.Cashier_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Transaction_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnFinish = New System.Windows.Forms.Button()
        Me.InOutTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MoneyTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox1 = New System.Windows.Forms.TextBox()
        Me.MoneyTextBox1 = New System.Windows.Forms.TextBox()
        Me.TypeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DescriptionTextBox2 = New System.Windows.Forms.TextBox()
        Me.Customer_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoneyTextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TypeComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MoneyTransactionsTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.MoneyTransactionsTableAdapter()
        Me.TableAdapterManager = New MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager()
        Me.UsersTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.UsersTableAdapter()
        Me.CustomersTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.CustomersTableAdapter()
        Me.CustomersSalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.SalesTableAdapter()
        Transaction_DateLabel = New System.Windows.Forms.Label()
        Cashier_IDLabel = New System.Windows.Forms.Label()
        User_IDLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        MoneyLabel = New System.Windows.Forms.Label()
        InOutLabel = New System.Windows.Forms.Label()
        TypeLabel1 = New System.Windows.Forms.Label()
        MoneyLabel1 = New System.Windows.Forms.Label()
        DescriptionLabel1 = New System.Windows.Forms.Label()
        User_NameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        MoneyLabel2 = New System.Windows.Forms.Label()
        Customer_NameLabel = New System.Windows.Forms.Label()
        DescriptionLabel2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.MoneyTransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersSalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Transaction_DateLabel
        '
        Transaction_DateLabel.AutoSize = True
        Transaction_DateLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Transaction_DateLabel.ForeColor = System.Drawing.Color.White
        Transaction_DateLabel.Location = New System.Drawing.Point(724, 20)
        Transaction_DateLabel.Name = "Transaction_DateLabel"
        Transaction_DateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Transaction_DateLabel.Size = New System.Drawing.Size(51, 19)
        Transaction_DateLabel.TabIndex = 0
        Transaction_DateLabel.Text = "التاريخ:"
        '
        'Cashier_IDLabel
        '
        Cashier_IDLabel.AutoSize = True
        Cashier_IDLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cashier_IDLabel.ForeColor = System.Drawing.Color.White
        Cashier_IDLabel.Location = New System.Drawing.Point(189, 20)
        Cashier_IDLabel.Name = "Cashier_IDLabel"
        Cashier_IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Cashier_IDLabel.Size = New System.Drawing.Size(75, 19)
        Cashier_IDLabel.TabIndex = 2
        Cashier_IDLabel.Text = "رقم الوردية:"
        '
        'User_IDLabel
        '
        User_IDLabel.AutoSize = True
        User_IDLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_IDLabel.ForeColor = System.Drawing.Color.White
        User_IDLabel.Location = New System.Drawing.Point(189, 60)
        User_IDLabel.Name = "User_IDLabel"
        User_IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        User_IDLabel.Size = New System.Drawing.Size(85, 19)
        User_IDLabel.TabIndex = 4
        User_IDLabel.Text = "رقم المستخدم:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(681, 22)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(99, 19)
        TypeLabel.TabIndex = 0
        TypeLabel.Text = "نوع المصروفات:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(681, 96)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(54, 19)
        DescriptionLabel.TabIndex = 2
        DescriptionLabel.Text = "الوصف:"
        '
        'MoneyLabel
        '
        MoneyLabel.AutoSize = True
        MoneyLabel.Location = New System.Drawing.Point(56, 61)
        MoneyLabel.Name = "MoneyLabel"
        MoneyLabel.Size = New System.Drawing.Size(77, 19)
        MoneyLabel.TabIndex = 4
        MoneyLabel.Text = "القيمة النقدية"
        '
        'InOutLabel
        '
        InOutLabel.AutoSize = True
        InOutLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        InOutLabel.ForeColor = System.Drawing.Color.White
        InOutLabel.Location = New System.Drawing.Point(434, 41)
        InOutLabel.Name = "InOutLabel"
        InOutLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        InOutLabel.Size = New System.Drawing.Size(78, 19)
        InOutLabel.TabIndex = 0
        InOutLabel.Text = "وارد / صادر:"
        '
        'TypeLabel1
        '
        TypeLabel1.AutoSize = True
        TypeLabel1.Location = New System.Drawing.Point(677, 19)
        TypeLabel1.Name = "TypeLabel1"
        TypeLabel1.Size = New System.Drawing.Size(75, 19)
        TypeLabel1.TabIndex = 0
        TypeLabel1.Text = "نوع الحركة:"
        '
        'MoneyLabel1
        '
        MoneyLabel1.AutoSize = True
        MoneyLabel1.Location = New System.Drawing.Point(36, 67)
        MoneyLabel1.Name = "MoneyLabel1"
        MoneyLabel1.Size = New System.Drawing.Size(82, 19)
        MoneyLabel1.TabIndex = 2
        MoneyLabel1.Text = "المبلغ النقدي:"
        '
        'DescriptionLabel1
        '
        DescriptionLabel1.AutoSize = True
        DescriptionLabel1.Location = New System.Drawing.Point(680, 153)
        DescriptionLabel1.Name = "DescriptionLabel1"
        DescriptionLabel1.Size = New System.Drawing.Size(54, 19)
        DescriptionLabel1.TabIndex = 4
        DescriptionLabel1.Text = "الوصف:"
        '
        'User_NameLabel
        '
        User_NameLabel.AutoSize = True
        User_NameLabel.Location = New System.Drawing.Point(677, 57)
        User_NameLabel.Name = "User_NameLabel"
        User_NameLabel.Size = New System.Drawing.Size(87, 19)
        User_NameLabel.TabIndex = 6
        User_NameLabel.Text = "اسم المستخدم:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(431, 58)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(68, 19)
        PasswordLabel.TabIndex = 9
        PasswordLabel.Text = "كلمة السر:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(677, 93)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(101, 19)
        PositionLabel.TabIndex = 10
        PositionLabel.Text = "المنصب الوظيفي:"
        '
        'MoneyLabel2
        '
        MoneyLabel2.AutoSize = True
        MoneyLabel2.Location = New System.Drawing.Point(58, 96)
        MoneyLabel2.Name = "MoneyLabel2"
        MoneyLabel2.Size = New System.Drawing.Size(77, 19)
        MoneyLabel2.TabIndex = 2
        MoneyLabel2.Text = "القيمة النقدية"
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Location = New System.Drawing.Point(671, 57)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.Size = New System.Drawing.Size(71, 19)
        Customer_NameLabel.TabIndex = 4
        Customer_NameLabel.Text = "اسم العميل:"
        '
        'DescriptionLabel2
        '
        DescriptionLabel2.AutoSize = True
        DescriptionLabel2.Location = New System.Drawing.Point(671, 118)
        DescriptionLabel2.Name = "DescriptionLabel2"
        DescriptionLabel2.Size = New System.Drawing.Size(54, 19)
        DescriptionLabel2.TabIndex = 6
        DescriptionLabel2.Text = "الوصف:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(User_IDLabel)
        Me.Panel1.Controls.Add(Me.User_IDTextBox)
        Me.Panel1.Controls.Add(Cashier_IDLabel)
        Me.Panel1.Controls.Add(Me.Cashier_IDTextBox)
        Me.Panel1.Controls.Add(Transaction_DateLabel)
        Me.Panel1.Controls.Add(Me.Transaction_DateDateTimePicker)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 109)
        Me.Panel1.TabIndex = 0
        '
        'User_IDTextBox
        '
        Me.User_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoneyTransactionsBindingSource, "User_ID", True))
        Me.User_IDTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_IDTextBox.Location = New System.Drawing.Point(50, 57)
        Me.User_IDTextBox.Name = "User_IDTextBox"
        Me.User_IDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.User_IDTextBox.Size = New System.Drawing.Size(131, 26)
        Me.User_IDTextBox.TabIndex = 5
        '
        'MoneyTransactionsBindingSource
        '
        Me.MoneyTransactionsBindingSource.DataMember = "MoneyTransactions"
        Me.MoneyTransactionsBindingSource.DataSource = Me.DBWoodDataSet
        '
        'DBWoodDataSet
        '
        Me.DBWoodDataSet.DataSetName = "DBWoodDataSet"
        Me.DBWoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cashier_IDTextBox
        '
        Me.Cashier_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoneyTransactionsBindingSource, "Cashier_ID", True))
        Me.Cashier_IDTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cashier_IDTextBox.Location = New System.Drawing.Point(50, 17)
        Me.Cashier_IDTextBox.Name = "Cashier_IDTextBox"
        Me.Cashier_IDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Cashier_IDTextBox.Size = New System.Drawing.Size(131, 26)
        Me.Cashier_IDTextBox.TabIndex = 3
        '
        'Transaction_DateDateTimePicker
        '
        Me.Transaction_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MoneyTransactionsBindingSource, "Transaction_Date", True))
        Me.Transaction_DateDateTimePicker.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Transaction_DateDateTimePicker.Location = New System.Drawing.Point(328, 14)
        Me.Transaction_DateDateTimePicker.Name = "Transaction_DateDateTimePicker"
        Me.Transaction_DateDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Transaction_DateDateTimePicker.Size = New System.Drawing.Size(369, 26)
        Me.Transaction_DateDateTimePicker.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.BtnFinish)
        Me.Panel2.Controls.Add(InOutLabel)
        Me.Panel2.Controls.Add(Me.InOutTextBox)
        Me.Panel2.Location = New System.Drawing.Point(2, 352)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(797, 95)
        Me.Panel2.TabIndex = 1
        '
        'BtnFinish
        '
        Me.BtnFinish.Location = New System.Drawing.Point(10, 3)
        Me.BtnFinish.Name = "BtnFinish"
        Me.BtnFinish.Size = New System.Drawing.Size(108, 89)
        Me.BtnFinish.TabIndex = 2
        Me.BtnFinish.Text = "حفظ و إنهاء"
        Me.BtnFinish.UseVisualStyleBackColor = True
        '
        'InOutTextBox
        '
        Me.InOutTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoneyTransactionsBindingSource, "InOut", True))
        Me.InOutTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InOutTextBox.Location = New System.Drawing.Point(294, 38)
        Me.InOutTextBox.Name = "InOutTextBox"
        Me.InOutTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.InOutTextBox.Size = New System.Drawing.Size(134, 26)
        Me.InOutTextBox.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 106)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(794, 240)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.Orange
        Me.TabPage1.Controls.Add(MoneyLabel)
        Me.TabPage1.Controls.Add(Me.MoneyTextBox)
        Me.TabPage1.Controls.Add(DescriptionLabel)
        Me.TabPage1.Controls.Add(Me.DescriptionTextBox)
        Me.TabPage1.Controls.Add(TypeLabel)
        Me.TabPage1.Controls.Add(Me.TypeComboBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabPage1.Size = New System.Drawing.Size(786, 208)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "المصروفات"
        '
        'MoneyTextBox
        '
        Me.MoneyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoneyTransactionsBindingSource, "Money", True))
        Me.MoneyTextBox.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoneyTextBox.Location = New System.Drawing.Point(6, 83)
        Me.MoneyTextBox.Name = "MoneyTextBox"
        Me.MoneyTextBox.Size = New System.Drawing.Size(171, 63)
        Me.MoneyTextBox.TabIndex = 5
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoneyTransactionsBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(185, 61)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(490, 124)
        Me.DescriptionTextBox.TabIndex = 3
        '
        'TypeComboBox
        '
        Me.TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoneyTransactionsBindingSource, "Type", True))
        Me.TypeComboBox.FormattingEnabled = True
        Me.TypeComboBox.Items.AddRange(New Object() {"مصروفات ثابتة", "محاسبة موردين", "شراء من محلات أخرى"})
        Me.TypeComboBox.Location = New System.Drawing.Point(185, 19)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(490, 27)
        Me.TypeComboBox.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.RoyalBlue
        Me.TabPage2.Controls.Add(PositionLabel)
        Me.TabPage2.Controls.Add(Me.PositionTextBox)
        Me.TabPage2.Controls.Add(PasswordLabel)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(User_NameLabel)
        Me.TabPage2.Controls.Add(DescriptionLabel1)
        Me.TabPage2.Controls.Add(Me.DescriptionTextBox1)
        Me.TabPage2.Controls.Add(MoneyLabel1)
        Me.TabPage2.Controls.Add(Me.MoneyTextBox1)
        Me.TabPage2.Controls.Add(TypeLabel1)
        Me.TabPage2.Controls.Add(Me.TypeComboBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(786, 208)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "سحب و إيداع النقود"
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "Position", True))
        Me.PositionTextBox.Location = New System.Drawing.Point(513, 89)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(158, 26)
        Me.PositionTextBox.TabIndex = 11
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.DBWoodDataSet
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(283, 55)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(143, 26)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(513, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 26)
        Me.TextBox1.TabIndex = 7
        '
        'DescriptionTextBox1
        '
        Me.DescriptionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoneyTransactionsBindingSource, "Description", True))
        Me.DescriptionTextBox1.Location = New System.Drawing.Point(283, 124)
        Me.DescriptionTextBox1.Multiline = True
        Me.DescriptionTextBox1.Name = "DescriptionTextBox1"
        Me.DescriptionTextBox1.Size = New System.Drawing.Size(391, 78)
        Me.DescriptionTextBox1.TabIndex = 5
        '
        'MoneyTextBox1
        '
        Me.MoneyTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoneyTransactionsBindingSource, "Money", True))
        Me.MoneyTextBox1.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoneyTextBox1.Location = New System.Drawing.Point(6, 98)
        Me.MoneyTextBox1.Name = "MoneyTextBox1"
        Me.MoneyTextBox1.Size = New System.Drawing.Size(154, 63)
        Me.MoneyTextBox1.TabIndex = 3
        '
        'TypeComboBox1
        '
        Me.TypeComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoneyTransactionsBindingSource, "Type", True))
        Me.TypeComboBox1.FormattingEnabled = True
        Me.TypeComboBox1.Items.AddRange(New Object() {"سحب نقود", "إيداع نقود"})
        Me.TypeComboBox1.Location = New System.Drawing.Point(390, 16)
        Me.TypeComboBox1.Name = "TypeComboBox1"
        Me.TypeComboBox1.Size = New System.Drawing.Size(281, 27)
        Me.TypeComboBox1.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.NavajoWhite
        Me.TabPage3.Controls.Add(DescriptionLabel2)
        Me.TabPage3.Controls.Add(Me.DescriptionTextBox2)
        Me.TabPage3.Controls.Add(Customer_NameLabel)
        Me.TabPage3.Controls.Add(Me.Customer_NameComboBox)
        Me.TabPage3.Controls.Add(MoneyLabel2)
        Me.TabPage3.Controls.Add(Me.MoneyTextBox2)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.TypeComboBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(786, 208)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "القروض"
        '
        'DescriptionTextBox2
        '
        Me.DescriptionTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoneyTransactionsBindingSource, "Description", True))
        Me.DescriptionTextBox2.Location = New System.Drawing.Point(266, 118)
        Me.DescriptionTextBox2.Multiline = True
        Me.DescriptionTextBox2.Name = "DescriptionTextBox2"
        Me.DescriptionTextBox2.Size = New System.Drawing.Size(399, 73)
        Me.DescriptionTextBox2.TabIndex = 7
        '
        'Customer_NameComboBox
        '
        Me.Customer_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CustomersBindingSource, "Customer_Name", True))
        Me.Customer_NameComboBox.DataSource = Me.CustomersBindingSource
        Me.Customer_NameComboBox.DisplayMember = "Customer_Name"
        Me.Customer_NameComboBox.FormattingEnabled = True
        Me.Customer_NameComboBox.Location = New System.Drawing.Point(312, 54)
        Me.Customer_NameComboBox.Name = "Customer_NameComboBox"
        Me.Customer_NameComboBox.Size = New System.Drawing.Size(353, 27)
        Me.Customer_NameComboBox.TabIndex = 5
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.DBWoodDataSet
        '
        'MoneyTextBox2
        '
        Me.MoneyTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoneyTransactionsBindingSource, "Money", True))
        Me.MoneyTextBox2.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold)
        Me.MoneyTextBox2.Location = New System.Drawing.Point(33, 118)
        Me.MoneyTextBox2.Name = "MoneyTextBox2"
        Me.MoneyTextBox2.Size = New System.Drawing.Size(129, 63)
        Me.MoneyTextBox2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(671, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "نوع حركة القرض:"
        '
        'TypeComboBox2
        '
        Me.TypeComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoneyTransactionsBindingSource, "Type", True))
        Me.TypeComboBox2.FormattingEnabled = True
        Me.TypeComboBox2.Items.AddRange(New Object() {"أخذ قرض", "سداد قرض"})
        Me.TypeComboBox2.Location = New System.Drawing.Point(387, 11)
        Me.TypeComboBox2.Name = "TypeComboBox2"
        Me.TypeComboBox2.Size = New System.Drawing.Size(278, 27)
        Me.TypeComboBox2.TabIndex = 0
        '
        'MoneyTransactionsTableAdapter
        '
        Me.MoneyTransactionsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CashierTableAdapter = Nothing
        Me.TableAdapterManager.CubitizationTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.MoneyTransactionsTableAdapter = Me.MoneyTransactionsTableAdapter
        Me.TableAdapterManager.PurchaseDetailsTableAdapter = Nothing
        Me.TableAdapterManager.PurchasesTableAdapter = Nothing
        Me.TableAdapterManager.SaleDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'CustomersSalesBindingSource
        '
        Me.CustomersSalesBindingSource.DataMember = "CustomersSales"
        Me.CustomersSalesBindingSource.DataSource = Me.CustomersBindingSource
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'FrmMoneyMoving
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmMoneyMoving"
        Me.Text = "حركات النقود"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MoneyTransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersSalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DBWoodDataSet As DBWoodDataSet
    Friend WithEvents MoneyTransactionsBindingSource As BindingSource
    Friend WithEvents MoneyTransactionsTableAdapter As DBWoodDataSetTableAdapters.MoneyTransactionsTableAdapter
    Friend WithEvents TableAdapterManager As DBWoodDataSetTableAdapters.TableAdapterManager
    Friend WithEvents User_IDTextBox As TextBox
    Friend WithEvents Cashier_IDTextBox As TextBox
    Friend WithEvents Transaction_DateDateTimePicker As DateTimePicker
    Friend WithEvents InOutTextBox As TextBox
    Friend WithEvents MoneyTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents TypeComboBox As ComboBox
    Friend WithEvents BtnFinish As Button
    Friend WithEvents DescriptionTextBox1 As TextBox
    Friend WithEvents MoneyTextBox1 As TextBox
    Friend WithEvents TypeComboBox1 As ComboBox
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As DBWoodDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MoneyTextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TypeComboBox2 As ComboBox
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As DBWoodDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents Customer_NameComboBox As ComboBox
    Friend WithEvents CustomersSalesBindingSource As BindingSource
    Friend WithEvents SalesTableAdapter As DBWoodDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents DescriptionTextBox2 As TextBox
End Class
