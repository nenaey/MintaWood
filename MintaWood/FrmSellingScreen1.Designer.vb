<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSellingScreen1
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
        Dim Sale_DateLabel As System.Windows.Forms.Label
        Dim Sale_TimeLabel As System.Windows.Forms.Label
        Dim Cashier_IDLabel As System.Windows.Forms.Label
        Dim User_IDLabel As System.Windows.Forms.Label
        Dim Customer_IDLabel As System.Windows.Forms.Label
        Dim IDLabel1 As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim Public_PriceLabel As System.Windows.Forms.Label
        Dim Supplier_PriceLabel As System.Windows.Forms.Label
        Dim Customer_NameLabel As System.Windows.Forms.Label
        Dim IDLabel2 As System.Windows.Forms.Label
        Dim Item_NameLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DBWoodDataSet = New MintaWood.DBWoodDataSet()
        Me.CustomersTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.CustomersTableAdapter()
        Me.ItemsTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.ItemsTableAdapter()
        Me.SalesTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.SalesTableAdapter()
        Me.TxtSale_ID = New System.Windows.Forms.TextBox()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sale_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Sale_TimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Cashier_IDTextBox = New System.Windows.Forms.TextBox()
        Me.User_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_IDTextBox = New System.Windows.Forms.TextBox()
        Me.TxtItem_ID = New System.Windows.Forms.TextBox()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.Public_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Supplier_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtCustomer_ID = New System.Windows.Forms.TextBox()
        Me.Item_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDiscount = New System.Windows.Forms.TextBox()
        Me.TxtSubtotal = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.BtnFinish = New System.Windows.Forms.Button()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.SaleDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleDetailsTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.SaleDetailsTableAdapter()
        Me.SaleDetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.TbcItem_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcDiscount_Percentage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcDiscount_Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcTotal_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcSupplier_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcSale_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcItem_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        IDLabel = New System.Windows.Forms.Label()
        Sale_DateLabel = New System.Windows.Forms.Label()
        Sale_TimeLabel = New System.Windows.Forms.Label()
        Cashier_IDLabel = New System.Windows.Forms.Label()
        User_IDLabel = New System.Windows.Forms.Label()
        Customer_IDLabel = New System.Windows.Forms.Label()
        IDLabel1 = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        Public_PriceLabel = New System.Windows.Forms.Label()
        Supplier_PriceLabel = New System.Windows.Forms.Label()
        Customer_NameLabel = New System.Windows.Forms.Label()
        IDLabel2 = New System.Windows.Forms.Label()
        Item_NameLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SaleDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(892, 7)
        IDLabel.Name = "IDLabel"
        IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        IDLabel.Size = New System.Drawing.Size(96, 19)
        IDLabel.TabIndex = 2
        IDLabel.Text = "كود عملية البيع:"
        '
        'Sale_DateLabel
        '
        Sale_DateLabel.AutoSize = True
        Sale_DateLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sale_DateLabel.Location = New System.Drawing.Point(892, 38)
        Sale_DateLabel.Name = "Sale_DateLabel"
        Sale_DateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Sale_DateLabel.Size = New System.Drawing.Size(71, 19)
        Sale_DateLabel.TabIndex = 4
        Sale_DateLabel.Text = "تاريخ البيع:"
        '
        'Sale_TimeLabel
        '
        Sale_TimeLabel.AutoSize = True
        Sale_TimeLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sale_TimeLabel.Location = New System.Drawing.Point(892, 68)
        Sale_TimeLabel.Name = "Sale_TimeLabel"
        Sale_TimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Sale_TimeLabel.Size = New System.Drawing.Size(65, 19)
        Sale_TimeLabel.TabIndex = 6
        Sale_TimeLabel.Text = "وقت البيع:"
        '
        'Cashier_IDLabel
        '
        Cashier_IDLabel.AutoSize = True
        Cashier_IDLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cashier_IDLabel.Location = New System.Drawing.Point(490, 9)
        Cashier_IDLabel.Name = "Cashier_IDLabel"
        Cashier_IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Cashier_IDLabel.Size = New System.Drawing.Size(75, 19)
        Cashier_IDLabel.TabIndex = 8
        Cashier_IDLabel.Text = "كود الخزينة:"
        '
        'User_IDLabel
        '
        User_IDLabel.AutoSize = True
        User_IDLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_IDLabel.Location = New System.Drawing.Point(490, 39)
        User_IDLabel.Name = "User_IDLabel"
        User_IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        User_IDLabel.Size = New System.Drawing.Size(85, 19)
        User_IDLabel.TabIndex = 10
        User_IDLabel.Text = "كود المستخدم:"
        '
        'Customer_IDLabel
        '
        Customer_IDLabel.AutoSize = True
        Customer_IDLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Customer_IDLabel.Location = New System.Drawing.Point(490, 69)
        Customer_IDLabel.Name = "Customer_IDLabel"
        Customer_IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Customer_IDLabel.Size = New System.Drawing.Size(69, 19)
        Customer_IDLabel.TabIndex = 12
        Customer_IDLabel.Text = "كود العميل:"
        '
        'IDLabel1
        '
        IDLabel1.AutoSize = True
        IDLabel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel1.Location = New System.Drawing.Point(238, 116)
        IDLabel1.Name = "IDLabel1"
        IDLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        IDLabel1.Size = New System.Drawing.Size(73, 19)
        IDLabel1.TabIndex = 14
        IDLabel1.Text = "كود الصنف:"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StockLabel.Location = New System.Drawing.Point(1012, 156)
        StockLabel.Name = "StockLabel"
        StockLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        StockLabel.Size = New System.Drawing.Size(89, 19)
        StockLabel.TabIndex = 18
        StockLabel.Text = "كمية المخزون:"
        '
        'Public_PriceLabel
        '
        Public_PriceLabel.AutoSize = True
        Public_PriceLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Public_PriceLabel.Location = New System.Drawing.Point(454, 157)
        Public_PriceLabel.Name = "Public_PriceLabel"
        Public_PriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Public_PriceLabel.Size = New System.Drawing.Size(86, 19)
        Public_PriceLabel.TabIndex = 20
        Public_PriceLabel.Text = "سعر الجمهور:"
        '
        'Supplier_PriceLabel
        '
        Supplier_PriceLabel.AutoSize = True
        Supplier_PriceLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Supplier_PriceLabel.Location = New System.Drawing.Point(454, 190)
        Supplier_PriceLabel.Name = "Supplier_PriceLabel"
        Supplier_PriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Supplier_PriceLabel.Size = New System.Drawing.Size(76, 19)
        Supplier_PriceLabel.TabIndex = 22
        Supplier_PriceLabel.Text = "سعر المورد:"
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Customer_NameLabel.Location = New System.Drawing.Point(274, 34)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Customer_NameLabel.Size = New System.Drawing.Size(71, 19)
        Customer_NameLabel.TabIndex = 24
        Customer_NameLabel.Text = "اسم العميل:"
        '
        'IDLabel2
        '
        IDLabel2.AutoSize = True
        IDLabel2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel2.Location = New System.Drawing.Point(276, 68)
        IDLabel2.Name = "IDLabel2"
        IDLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        IDLabel2.Size = New System.Drawing.Size(69, 19)
        IDLabel2.TabIndex = 26
        IDLabel2.Text = "كود العميل:"
        '
        'Item_NameLabel
        '
        Item_NameLabel.AutoSize = True
        Item_NameLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Item_NameLabel.Location = New System.Drawing.Point(1012, 116)
        Item_NameLabel.Name = "Item_NameLabel"
        Item_NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Item_NameLabel.Size = New System.Drawing.Size(75, 19)
        Item_NameLabel.TabIndex = 27
        Item_NameLabel.Text = "اسم الصنف:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusLabel.Location = New System.Drawing.Point(274, 4)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        StatusLabel.Size = New System.Drawing.Size(101, 19)
        StatusLabel.TabIndex = 33
        StatusLabel.Text = "حالة عملية البيع:"
        '
        'DBWoodDataSet
        '
        Me.DBWoodDataSet.DataSetName = "DBWoodDataSet"
        Me.DBWoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'TxtSale_ID
        '
        Me.TxtSale_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "ID", True))
        Me.TxtSale_ID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSale_ID.Location = New System.Drawing.Point(745, 4)
        Me.TxtSale_ID.Name = "TxtSale_ID"
        Me.TxtSale_ID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSale_ID.Size = New System.Drawing.Size(140, 26)
        Me.TxtSale_ID.TabIndex = 3
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "Sales"
        Me.SalesBindingSource.DataSource = Me.DBWoodDataSet
        '
        'Sale_DateDateTimePicker
        '
        Me.Sale_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesBindingSource, "Sale_Date", True))
        Me.Sale_DateDateTimePicker.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sale_DateDateTimePicker.Location = New System.Drawing.Point(580, 34)
        Me.Sale_DateDateTimePicker.Name = "Sale_DateDateTimePicker"
        Me.Sale_DateDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Sale_DateDateTimePicker.Size = New System.Drawing.Size(305, 26)
        Me.Sale_DateDateTimePicker.TabIndex = 5
        '
        'Sale_TimeDateTimePicker
        '
        Me.Sale_TimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesBindingSource, "Sale_Time", True))
        Me.Sale_TimeDateTimePicker.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sale_TimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Sale_TimeDateTimePicker.Location = New System.Drawing.Point(721, 64)
        Me.Sale_TimeDateTimePicker.Name = "Sale_TimeDateTimePicker"
        Me.Sale_TimeDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Sale_TimeDateTimePicker.Size = New System.Drawing.Size(164, 26)
        Me.Sale_TimeDateTimePicker.TabIndex = 7
        '
        'Cashier_IDTextBox
        '
        Me.Cashier_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Cashier_ID", True))
        Me.Cashier_IDTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cashier_IDTextBox.Location = New System.Drawing.Point(391, 5)
        Me.Cashier_IDTextBox.Name = "Cashier_IDTextBox"
        Me.Cashier_IDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Cashier_IDTextBox.Size = New System.Drawing.Size(94, 26)
        Me.Cashier_IDTextBox.TabIndex = 9
        '
        'User_IDTextBox
        '
        Me.User_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "User_ID", True))
        Me.User_IDTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_IDTextBox.Location = New System.Drawing.Point(391, 35)
        Me.User_IDTextBox.Name = "User_IDTextBox"
        Me.User_IDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.User_IDTextBox.Size = New System.Drawing.Size(94, 26)
        Me.User_IDTextBox.TabIndex = 11
        '
        'Customer_IDTextBox
        '
        Me.Customer_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Customer_ID", True))
        Me.Customer_IDTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_IDTextBox.Location = New System.Drawing.Point(391, 66)
        Me.Customer_IDTextBox.Name = "Customer_IDTextBox"
        Me.Customer_IDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Customer_IDTextBox.Size = New System.Drawing.Size(94, 26)
        Me.Customer_IDTextBox.TabIndex = 13
        '
        'TxtItem_ID
        '
        Me.TxtItem_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "ID", True))
        Me.TxtItem_ID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItem_ID.Location = New System.Drawing.Point(132, 113)
        Me.TxtItem_ID.Name = "TxtItem_ID"
        Me.TxtItem_ID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtItem_ID.Size = New System.Drawing.Size(100, 26)
        Me.TxtItem_ID.TabIndex = 15
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.DBWoodDataSet
        '
        'StockTextBox
        '
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Stock", True))
        Me.StockTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockTextBox.Location = New System.Drawing.Point(905, 153)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StockTextBox.Size = New System.Drawing.Size(100, 26)
        Me.StockTextBox.TabIndex = 19
        '
        'Public_PriceTextBox
        '
        Me.Public_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Public_Price", True))
        Me.Public_PriceTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Public_PriceTextBox.Location = New System.Drawing.Point(348, 154)
        Me.Public_PriceTextBox.Name = "Public_PriceTextBox"
        Me.Public_PriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Public_PriceTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Public_PriceTextBox.TabIndex = 21
        '
        'Supplier_PriceTextBox
        '
        Me.Supplier_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Supplier_Price", True))
        Me.Supplier_PriceTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_PriceTextBox.Location = New System.Drawing.Point(348, 187)
        Me.Supplier_PriceTextBox.Name = "Supplier_PriceTextBox"
        Me.Supplier_PriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Supplier_PriceTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Supplier_PriceTextBox.TabIndex = 23
        '
        'Customer_NameComboBox
        '
        Me.Customer_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CustomersBindingSource, "Customer_Name", True))
        Me.Customer_NameComboBox.DataSource = Me.CustomersBindingSource
        Me.Customer_NameComboBox.DisplayMember = "Customer_Name"
        Me.Customer_NameComboBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_NameComboBox.FormattingEnabled = True
        Me.Customer_NameComboBox.Location = New System.Drawing.Point(3, 31)
        Me.Customer_NameComboBox.Name = "Customer_NameComboBox"
        Me.Customer_NameComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Customer_NameComboBox.Size = New System.Drawing.Size(267, 27)
        Me.Customer_NameComboBox.TabIndex = 25
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.DBWoodDataSet
        '
        'TxtCustomer_ID
        '
        Me.TxtCustomer_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "ID", True))
        Me.TxtCustomer_ID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomer_ID.Location = New System.Drawing.Point(170, 63)
        Me.TxtCustomer_ID.Name = "TxtCustomer_ID"
        Me.TxtCustomer_ID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCustomer_ID.Size = New System.Drawing.Size(100, 26)
        Me.TxtCustomer_ID.TabIndex = 27
        '
        'Item_NameComboBox
        '
        Me.Item_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ItemsBindingSource, "Item_Name", True))
        Me.Item_NameComboBox.DataSource = Me.ItemsBindingSource
        Me.Item_NameComboBox.DisplayMember = "Item_Name"
        Me.Item_NameComboBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item_NameComboBox.FormattingEnabled = True
        Me.Item_NameComboBox.Location = New System.Drawing.Point(348, 116)
        Me.Item_NameComboBox.Name = "Item_NameComboBox"
        Me.Item_NameComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Item_NameComboBox.Size = New System.Drawing.Size(657, 27)
        Me.Item_NameComboBox.TabIndex = 28
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(13, 19)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(81, 69)
        Me.BtnAdd.TabIndex = 29
        Me.BtnAdd.Text = "إضافة"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(13, 110)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(81, 70)
        Me.BtnSave.TabIndex = 30
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CashierTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.BtnAdd)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Location = New System.Drawing.Point(1, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(113, 481)
        Me.Panel1.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TxtDiscount)
        Me.Panel2.Controls.Add(Me.TxtSubtotal)
        Me.Panel2.Controls.Add(Me.TxtTotal)
        Me.Panel2.Location = New System.Drawing.Point(120, 488)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(994, 111)
        Me.Panel2.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(99, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "الإجمالي النهائي"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(470, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "إجمالي الخصم"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(714, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "الإجمالي الأولي"
        '
        'TxtDiscount
        '
        Me.TxtDiscount.BackColor = System.Drawing.Color.LightYellow
        Me.TxtDiscount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Discount", True))
        Me.TxtDiscount.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiscount.Location = New System.Drawing.Point(429, 53)
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(167, 43)
        Me.TxtDiscount.TabIndex = 2
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.BackColor = System.Drawing.Color.LightYellow
        Me.TxtSubtotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Subtotal", True))
        Me.TxtSubtotal.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubtotal.Location = New System.Drawing.Point(662, 52)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.Size = New System.Drawing.Size(193, 43)
        Me.TxtSubtotal.TabIndex = 1
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.Yellow
        Me.TxtTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Total", True))
        Me.TxtTotal.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(56, 44)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(199, 52)
        Me.TxtTotal.TabIndex = 0
        '
        'BtnFinish
        '
        Me.BtnFinish.BackColor = System.Drawing.Color.OldLace
        Me.BtnFinish.Location = New System.Drawing.Point(1, 488)
        Me.BtnFinish.Name = "BtnFinish"
        Me.BtnFinish.Size = New System.Drawing.Size(113, 113)
        Me.BtnFinish.TabIndex = 33
        Me.BtnFinish.Text = "إتمام عملية البيع"
        Me.BtnFinish.UseVisualStyleBackColor = False
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Status", True))
        Me.StatusTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusTextBox.Location = New System.Drawing.Point(170, 1)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusTextBox.Size = New System.Drawing.Size(100, 26)
        Me.StatusTextBox.TabIndex = 34
        '
        'SaleDetailsBindingSource
        '
        Me.SaleDetailsBindingSource.DataMember = "SaleDetails"
        Me.SaleDetailsBindingSource.DataSource = Me.DBWoodDataSet
        '
        'SaleDetailsTableAdapter
        '
        Me.SaleDetailsTableAdapter.ClearBeforeFill = True
        '
        'SaleDetailsDataGridView
        '
        Me.SaleDetailsDataGridView.AllowUserToAddRows = False
        Me.SaleDetailsDataGridView.AutoGenerateColumns = False
        Me.SaleDetailsDataGridView.BackgroundColor = System.Drawing.Color.Yellow
        Me.SaleDetailsDataGridView.ColumnHeadersHeight = 40
        Me.SaleDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TbcItem_Name, Me.TbcQuantity, Me.TbcPrice, Me.TbcDiscount_Percentage, Me.TbcDiscount_Value, Me.TbcTotal_Price, Me.TbcSupplier_Price, Me.TbcID, Me.TbcSale_ID, Me.TbcItem_ID})
        Me.SaleDetailsDataGridView.DataSource = Me.SaleDetailsBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SaleDetailsDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.SaleDetailsDataGridView.Location = New System.Drawing.Point(120, 219)
        Me.SaleDetailsDataGridView.Name = "SaleDetailsDataGridView"
        Me.SaleDetailsDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SaleDetailsDataGridView.RowHeadersWidth = 40
        Me.SaleDetailsDataGridView.Size = New System.Drawing.Size(994, 263)
        Me.SaleDetailsDataGridView.TabIndex = 34
        '
        'TbcItem_Name
        '
        Me.TbcItem_Name.DataPropertyName = "Item_Name"
        Me.TbcItem_Name.HeaderText = "اسم الصنف"
        Me.TbcItem_Name.Name = "TbcItem_Name"
        '
        'TbcQuantity
        '
        Me.TbcQuantity.DataPropertyName = "Quantity"
        Me.TbcQuantity.HeaderText = "الكمية"
        Me.TbcQuantity.Name = "TbcQuantity"
        '
        'TbcPrice
        '
        Me.TbcPrice.DataPropertyName = "Price"
        Me.TbcPrice.HeaderText = "السعر"
        Me.TbcPrice.Name = "TbcPrice"
        '
        'TbcDiscount_Percentage
        '
        Me.TbcDiscount_Percentage.DataPropertyName = "Discount_Percentage"
        Me.TbcDiscount_Percentage.HeaderText = "نسبة الخصم"
        Me.TbcDiscount_Percentage.Name = "TbcDiscount_Percentage"
        '
        'TbcDiscount_Value
        '
        Me.TbcDiscount_Value.DataPropertyName = "Discount_Value"
        Me.TbcDiscount_Value.HeaderText = "قيمة الخصم"
        Me.TbcDiscount_Value.Name = "TbcDiscount_Value"
        '
        'TbcTotal_Price
        '
        Me.TbcTotal_Price.DataPropertyName = "Total_Price"
        Me.TbcTotal_Price.HeaderText = "إجمالي السعر"
        Me.TbcTotal_Price.Name = "TbcTotal_Price"
        '
        'TbcSupplier_Price
        '
        Me.TbcSupplier_Price.DataPropertyName = "Supplier_Price"
        Me.TbcSupplier_Price.HeaderText = "سعر المورد"
        Me.TbcSupplier_Price.Name = "TbcSupplier_Price"
        '
        'TbcID
        '
        Me.TbcID.DataPropertyName = "ID"
        Me.TbcID.HeaderText = "ID"
        Me.TbcID.Name = "TbcID"
        '
        'TbcSale_ID
        '
        Me.TbcSale_ID.DataPropertyName = "Sale_ID"
        Me.TbcSale_ID.HeaderText = "Sale_ID"
        Me.TbcSale_ID.Name = "TbcSale_ID"
        '
        'TbcItem_ID
        '
        Me.TbcItem_ID.DataPropertyName = "Item_ID"
        Me.TbcItem_ID.HeaderText = "Item_ID"
        Me.TbcItem_ID.Name = "TbcItem_ID"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel3.Controls.Add(StatusLabel)
        Me.Panel3.Controls.Add(Me.StatusTextBox)
        Me.Panel3.Controls.Add(IDLabel2)
        Me.Panel3.Controls.Add(Me.TxtCustomer_ID)
        Me.Panel3.Controls.Add(Customer_NameLabel)
        Me.Panel3.Controls.Add(Me.Customer_NameComboBox)
        Me.Panel3.Controls.Add(IDLabel)
        Me.Panel3.Controls.Add(Me.TxtSale_ID)
        Me.Panel3.Controls.Add(Sale_DateLabel)
        Me.Panel3.Controls.Add(Me.Sale_DateDateTimePicker)
        Me.Panel3.Controls.Add(Sale_TimeLabel)
        Me.Panel3.Controls.Add(Me.Sale_TimeDateTimePicker)
        Me.Panel3.Controls.Add(Cashier_IDLabel)
        Me.Panel3.Controls.Add(Me.Cashier_IDTextBox)
        Me.Panel3.Controls.Add(User_IDLabel)
        Me.Panel3.Controls.Add(Me.User_IDTextBox)
        Me.Panel3.Controls.Add(Customer_IDLabel)
        Me.Panel3.Controls.Add(Me.Customer_IDTextBox)
        Me.Panel3.Location = New System.Drawing.Point(120, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(991, 99)
        Me.Panel3.TabIndex = 35
        '
        'FrmSellingScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 601)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.SaleDetailsDataGridView)
        Me.Controls.Add(Me.BtnFinish)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Item_NameLabel)
        Me.Controls.Add(Me.Item_NameComboBox)
        Me.Controls.Add(IDLabel1)
        Me.Controls.Add(Me.TxtItem_ID)
        Me.Controls.Add(StockLabel)
        Me.Controls.Add(Me.StockTextBox)
        Me.Controls.Add(Public_PriceLabel)
        Me.Controls.Add(Me.Public_PriceTextBox)
        Me.Controls.Add(Supplier_PriceLabel)
        Me.Controls.Add(Me.Supplier_PriceTextBox)
        Me.Name = "FrmSellingScreen1"
        Me.Text = "شاشة البيع الأولى"
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.SaleDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBWoodDataSet As DBWoodDataSet
    Friend WithEvents TableAdapterManager As DBWoodDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalesTableAdapter As DBWoodDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents SalesBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As DBWoodDataSetTableAdapters.ItemsTableAdapter
    Friend WithEvents TxtSale_ID As TextBox
    Friend WithEvents Sale_DateDateTimePicker As DateTimePicker
    Friend WithEvents Sale_TimeDateTimePicker As DateTimePicker
    Friend WithEvents Cashier_IDTextBox As TextBox
    Friend WithEvents User_IDTextBox As TextBox
    Friend WithEvents Customer_IDTextBox As TextBox
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As DBWoodDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TxtItem_ID As TextBox
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents Public_PriceTextBox As TextBox
    Friend WithEvents Supplier_PriceTextBox As TextBox
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents Customer_NameComboBox As ComboBox
    Friend WithEvents TxtCustomer_ID As TextBox
    Friend WithEvents Item_NameComboBox As ComboBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnFinish As Button
    Friend WithEvents TxtDiscount As TextBox
    Friend WithEvents TxtSubtotal As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents SaleDetailsBindingSource As BindingSource
    Friend WithEvents SaleDetailsTableAdapter As DBWoodDataSetTableAdapters.SaleDetailsTableAdapter
    Friend WithEvents SaleDetailsDataGridView As DataGridView
    Friend WithEvents TbcItem_Name As DataGridViewTextBoxColumn
    Friend WithEvents TbcQuantity As DataGridViewTextBoxColumn
    Friend WithEvents TbcPrice As DataGridViewTextBoxColumn
    Friend WithEvents TbcDiscount_Percentage As DataGridViewTextBoxColumn
    Friend WithEvents TbcDiscount_Value As DataGridViewTextBoxColumn
    Friend WithEvents TbcTotal_Price As DataGridViewTextBoxColumn
    Friend WithEvents TbcSupplier_Price As DataGridViewTextBoxColumn
    Friend WithEvents TbcID As DataGridViewTextBoxColumn
    Friend WithEvents TbcSale_ID As DataGridViewTextBoxColumn
    Friend WithEvents TbcItem_ID As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
End Class
