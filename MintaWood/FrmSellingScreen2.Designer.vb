<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSellingScreen2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSellingScreen2))
        Dim IDLabel As System.Windows.Forms.Label
        Dim Sale_DateLabel As System.Windows.Forms.Label
        Dim Sale_TimeLabel As System.Windows.Forms.Label
        Dim Cashier_IDLabel As System.Windows.Forms.Label
        Dim User_IDLabel As System.Windows.Forms.Label
        Dim Customer_IDLabel As System.Windows.Forms.Label
        Dim SubtotalLabel As System.Windows.Forms.Label
        Dim DiscountLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim IDLabel1 As System.Windows.Forms.Label
        Dim Item_NameLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim Public_PriceLabel As System.Windows.Forms.Label
        Dim Supplier_PriceLabel As System.Windows.Forms.Label
        Dim Customer_NameLabel As System.Windows.Forms.Label
        Dim IDLabel2 As System.Windows.Forms.Label
        Me.DBWoodDataSet = New MintaWood.DBWoodDataSet()
        Me.TableAdapterManager = New MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager()
        Me.SaleDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleDetailsTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.SaleDetailsTableAdapter()
        Me.SaleDetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.SaleDetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SaleDetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.TbcItem_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcDiscount_Percentage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcDiscount_Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcTotal_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcSale_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcItem_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcSupplier_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.SalesTableAdapter()
        Me.TxtSale_ID = New System.Windows.Forms.TextBox()
        Me.Sale_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Sale_TimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Cashier_IDTextBox = New System.Windows.Forms.TextBox()
        Me.User_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_IDTextBox = New System.Windows.Forms.TextBox()
        Me.SubtotalTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.ItemsTableAdapter()
        Me.TxtItem_ID = New System.Windows.Forms.TextBox()
        Me.Item_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.Public_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Supplier_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.ItemsSaleDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.CustomersTableAdapter()
        Me.Customer_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.IDTextBox2 = New System.Windows.Forms.TextBox()
        Me.CustomersSalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersSalesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        Sale_DateLabel = New System.Windows.Forms.Label()
        Sale_TimeLabel = New System.Windows.Forms.Label()
        Cashier_IDLabel = New System.Windows.Forms.Label()
        User_IDLabel = New System.Windows.Forms.Label()
        Customer_IDLabel = New System.Windows.Forms.Label()
        SubtotalLabel = New System.Windows.Forms.Label()
        DiscountLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        IDLabel1 = New System.Windows.Forms.Label()
        Item_NameLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        Public_PriceLabel = New System.Windows.Forms.Label()
        Supplier_PriceLabel = New System.Windows.Forms.Label()
        Customer_NameLabel = New System.Windows.Forms.Label()
        IDLabel2 = New System.Windows.Forms.Label()
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaleDetailsBindingNavigator.SuspendLayout()
        CType(Me.SaleDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsSaleDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersSalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersSalesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBWoodDataSet
        '
        Me.DBWoodDataSet.DataSetName = "DBWoodDataSet"
        Me.DBWoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CashierTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing

        Me.TableAdapterManager.SaleDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
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
        'SaleDetailsBindingNavigator
        '
        Me.SaleDetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SaleDetailsBindingNavigator.BindingSource = Me.SaleDetailsBindingSource
        Me.SaleDetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SaleDetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SaleDetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SaleDetailsBindingNavigatorSaveItem})
        Me.SaleDetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SaleDetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SaleDetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SaleDetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SaleDetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SaleDetailsBindingNavigator.Name = "SaleDetailsBindingNavigator"
        Me.SaleDetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SaleDetailsBindingNavigator.Size = New System.Drawing.Size(947, 25)
        Me.SaleDetailsBindingNavigator.TabIndex = 0
        Me.SaleDetailsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'SaleDetailsBindingNavigatorSaveItem
        '
        Me.SaleDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaleDetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("SaleDetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SaleDetailsBindingNavigatorSaveItem.Name = "SaleDetailsBindingNavigatorSaveItem"
        Me.SaleDetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SaleDetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SaleDetailsDataGridView
        '
        Me.SaleDetailsDataGridView.AllowUserToAddRows = False
        Me.SaleDetailsDataGridView.AutoGenerateColumns = False
        Me.SaleDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SaleDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TbcItem_Name, Me.TbcQuantity, Me.TbcPrice, Me.TbcDiscount_Percentage, Me.TbcDiscount_Value, Me.TbcTotal_Price, Me.TbcID, Me.TbcSale_ID, Me.TbcItem_ID, Me.TbcSupplier_Price})
        Me.SaleDetailsDataGridView.DataSource = Me.SaleDetailsBindingSource
        Me.SaleDetailsDataGridView.Location = New System.Drawing.Point(0, 323)
        Me.SaleDetailsDataGridView.Name = "SaleDetailsDataGridView"
        Me.SaleDetailsDataGridView.Size = New System.Drawing.Size(832, 191)
        Me.SaleDetailsDataGridView.TabIndex = 1
        '
        'TbcItem_Name
        '
        Me.TbcItem_Name.DataPropertyName = "Item_Name"
        Me.TbcItem_Name.HeaderText = "Item_Name"
        Me.TbcItem_Name.Name = "TbcItem_Name"
        '
        'TbcQuantity
        '
        Me.TbcQuantity.DataPropertyName = "Quantity"
        Me.TbcQuantity.HeaderText = "Quantity"
        Me.TbcQuantity.Name = "TbcQuantity"
        '
        'TbcPrice
        '
        Me.TbcPrice.DataPropertyName = "Price"
        Me.TbcPrice.HeaderText = "Price"
        Me.TbcPrice.Name = "TbcPrice"
        '
        'TbcDiscount_Percentage
        '
        Me.TbcDiscount_Percentage.DataPropertyName = "Discount_Percentage"
        Me.TbcDiscount_Percentage.HeaderText = "Discount_Percentage"
        Me.TbcDiscount_Percentage.Name = "TbcDiscount_Percentage"
        '
        'TbcDiscount_Value
        '
        Me.TbcDiscount_Value.DataPropertyName = "Discount_Value"
        Me.TbcDiscount_Value.HeaderText = "Discount_Value"
        Me.TbcDiscount_Value.Name = "TbcDiscount_Value"
        '
        'TbcTotal_Price
        '
        Me.TbcTotal_Price.DataPropertyName = "Total_Price"
        Me.TbcTotal_Price.HeaderText = "Total_Price"
        Me.TbcTotal_Price.Name = "TbcTotal_Price"
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
        'TbcSupplier_Price
        '
        Me.TbcSupplier_Price.DataPropertyName = "Supplier_Price"
        Me.TbcSupplier_Price.HeaderText = "Supplier_Price"
        Me.TbcSupplier_Price.Name = "TbcSupplier_Price"
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "Sales"
        Me.SalesBindingSource.DataSource = Me.DBWoodDataSet
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(275, 24)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'TxtSale_ID
        '
        Me.TxtSale_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "ID", True))
        Me.TxtSale_ID.Location = New System.Drawing.Point(349, 21)
        Me.TxtSale_ID.Name = "TxtSale_ID"
        Me.TxtSale_ID.Size = New System.Drawing.Size(200, 20)
        Me.TxtSale_ID.TabIndex = 3
        '
        'Sale_DateLabel
        '
        Sale_DateLabel.AutoSize = True
        Sale_DateLabel.Location = New System.Drawing.Point(275, 51)
        Sale_DateLabel.Name = "Sale_DateLabel"
        Sale_DateLabel.Size = New System.Drawing.Size(57, 13)
        Sale_DateLabel.TabIndex = 4
        Sale_DateLabel.Text = "Sale Date:"
        '
        'Sale_DateDateTimePicker
        '
        Me.Sale_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesBindingSource, "Sale_Date", True))
        Me.Sale_DateDateTimePicker.Location = New System.Drawing.Point(349, 47)
        Me.Sale_DateDateTimePicker.Name = "Sale_DateDateTimePicker"
        Me.Sale_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Sale_DateDateTimePicker.TabIndex = 5
        '
        'Sale_TimeLabel
        '
        Sale_TimeLabel.AutoSize = True
        Sale_TimeLabel.Location = New System.Drawing.Point(275, 77)
        Sale_TimeLabel.Name = "Sale_TimeLabel"
        Sale_TimeLabel.Size = New System.Drawing.Size(57, 13)
        Sale_TimeLabel.TabIndex = 6
        Sale_TimeLabel.Text = "Sale Time:"
        '
        'Sale_TimeDateTimePicker
        '
        Me.Sale_TimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesBindingSource, "Sale_Time", True))
        Me.Sale_TimeDateTimePicker.Location = New System.Drawing.Point(349, 73)
        Me.Sale_TimeDateTimePicker.Name = "Sale_TimeDateTimePicker"
        Me.Sale_TimeDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Sale_TimeDateTimePicker.TabIndex = 7
        '
        'Cashier_IDLabel
        '
        Cashier_IDLabel.AutoSize = True
        Cashier_IDLabel.Location = New System.Drawing.Point(275, 102)
        Cashier_IDLabel.Name = "Cashier_IDLabel"
        Cashier_IDLabel.Size = New System.Drawing.Size(59, 13)
        Cashier_IDLabel.TabIndex = 8
        Cashier_IDLabel.Text = "Cashier ID:"
        '
        'Cashier_IDTextBox
        '
        Me.Cashier_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Cashier_ID", True))
        Me.Cashier_IDTextBox.Location = New System.Drawing.Point(349, 99)
        Me.Cashier_IDTextBox.Name = "Cashier_IDTextBox"
        Me.Cashier_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cashier_IDTextBox.TabIndex = 9
        '
        'User_IDLabel
        '
        User_IDLabel.AutoSize = True
        User_IDLabel.Location = New System.Drawing.Point(275, 128)
        User_IDLabel.Name = "User_IDLabel"
        User_IDLabel.Size = New System.Drawing.Size(46, 13)
        User_IDLabel.TabIndex = 10
        User_IDLabel.Text = "User ID:"
        '
        'User_IDTextBox
        '
        Me.User_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "User_ID", True))
        Me.User_IDTextBox.Location = New System.Drawing.Point(349, 125)
        Me.User_IDTextBox.Name = "User_IDTextBox"
        Me.User_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.User_IDTextBox.TabIndex = 11
        '
        'Customer_IDLabel
        '
        Customer_IDLabel.AutoSize = True
        Customer_IDLabel.Location = New System.Drawing.Point(582, 28)
        Customer_IDLabel.Name = "Customer_IDLabel"
        Customer_IDLabel.Size = New System.Drawing.Size(68, 13)
        Customer_IDLabel.TabIndex = 12
        Customer_IDLabel.Text = "Customer ID:"
        '
        'Customer_IDTextBox
        '
        Me.Customer_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Customer_ID", True))
        Me.Customer_IDTextBox.Location = New System.Drawing.Point(656, 25)
        Me.Customer_IDTextBox.Name = "Customer_IDTextBox"
        Me.Customer_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Customer_IDTextBox.TabIndex = 13
        '
        'SubtotalLabel
        '
        SubtotalLabel.AutoSize = True
        SubtotalLabel.Location = New System.Drawing.Point(582, 54)
        SubtotalLabel.Name = "SubtotalLabel"
        SubtotalLabel.Size = New System.Drawing.Size(49, 13)
        SubtotalLabel.TabIndex = 14
        SubtotalLabel.Text = "Subtotal:"
        '
        'SubtotalTextBox
        '
        Me.SubtotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Subtotal", True))
        Me.SubtotalTextBox.Location = New System.Drawing.Point(656, 51)
        Me.SubtotalTextBox.Name = "SubtotalTextBox"
        Me.SubtotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SubtotalTextBox.TabIndex = 15
        '
        'DiscountLabel
        '
        DiscountLabel.AutoSize = True
        DiscountLabel.Location = New System.Drawing.Point(582, 80)
        DiscountLabel.Name = "DiscountLabel"
        DiscountLabel.Size = New System.Drawing.Size(52, 13)
        DiscountLabel.TabIndex = 16
        DiscountLabel.Text = "Discount:"
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Discount", True))
        Me.DiscountTextBox.Location = New System.Drawing.Point(656, 77)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DiscountTextBox.TabIndex = 17
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(582, 106)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 18
        TotalLabel.Text = "Total:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(656, 103)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TotalTextBox.TabIndex = 19
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(582, 132)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 20
        StatusLabel.Text = "Status:"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(656, 129)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StatusTextBox.TabIndex = 21
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.DBWoodDataSet
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'IDLabel1
        '
        IDLabel1.AutoSize = True
        IDLabel1.Location = New System.Drawing.Point(29, 196)
        IDLabel1.Name = "IDLabel1"
        IDLabel1.Size = New System.Drawing.Size(21, 13)
        IDLabel1.TabIndex = 22
        IDLabel1.Text = "ID:"
        '
        'TxtItem_ID
        '
        Me.TxtItem_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "ID", True))
        Me.TxtItem_ID.Location = New System.Drawing.Point(110, 193)
        Me.TxtItem_ID.Name = "TxtItem_ID"
        Me.TxtItem_ID.Size = New System.Drawing.Size(121, 20)
        Me.TxtItem_ID.TabIndex = 23
        '
        'Item_NameLabel
        '
        Item_NameLabel.AutoSize = True
        Item_NameLabel.Location = New System.Drawing.Point(29, 222)
        Item_NameLabel.Name = "Item_NameLabel"
        Item_NameLabel.Size = New System.Drawing.Size(61, 13)
        Item_NameLabel.TabIndex = 24
        Item_NameLabel.Text = "Item Name:"
        '
        'Item_NameComboBox
        '
        Me.Item_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ItemsBindingSource, "Item_Name", True))
        Me.Item_NameComboBox.DataSource = Me.ItemsBindingSource
        Me.Item_NameComboBox.DisplayMember = "Item_Name"
        Me.Item_NameComboBox.FormattingEnabled = True
        Me.Item_NameComboBox.Location = New System.Drawing.Point(110, 219)
        Me.Item_NameComboBox.Name = "Item_NameComboBox"
        Me.Item_NameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Item_NameComboBox.TabIndex = 25
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(268, 193)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(38, 13)
        StockLabel.TabIndex = 26
        StockLabel.Text = "Stock:"
        '
        'StockTextBox
        '
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Stock", True))
        Me.StockTextBox.Location = New System.Drawing.Point(349, 190)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(121, 20)
        Me.StockTextBox.TabIndex = 27
        '
        'Public_PriceLabel
        '
        Public_PriceLabel.AutoSize = True
        Public_PriceLabel.Location = New System.Drawing.Point(268, 219)
        Public_PriceLabel.Name = "Public_PriceLabel"
        Public_PriceLabel.Size = New System.Drawing.Size(66, 13)
        Public_PriceLabel.TabIndex = 28
        Public_PriceLabel.Text = "Public Price:"
        '
        'Public_PriceTextBox
        '
        Me.Public_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Public_Price", True))
        Me.Public_PriceTextBox.Location = New System.Drawing.Point(349, 216)
        Me.Public_PriceTextBox.Name = "Public_PriceTextBox"
        Me.Public_PriceTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Public_PriceTextBox.TabIndex = 29
        '
        'Supplier_PriceLabel
        '
        Supplier_PriceLabel.AutoSize = True
        Supplier_PriceLabel.Location = New System.Drawing.Point(268, 245)
        Supplier_PriceLabel.Name = "Supplier_PriceLabel"
        Supplier_PriceLabel.Size = New System.Drawing.Size(75, 13)
        Supplier_PriceLabel.TabIndex = 30
        Supplier_PriceLabel.Text = "Supplier Price:"
        '
        'Supplier_PriceTextBox
        '
        Me.Supplier_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Supplier_Price", True))
        Me.Supplier_PriceTextBox.Location = New System.Drawing.Point(349, 242)
        Me.Supplier_PriceTextBox.Name = "Supplier_PriceTextBox"
        Me.Supplier_PriceTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Supplier_PriceTextBox.TabIndex = 31
        '
        'ItemsSaleDetailsBindingSource
        '
        Me.ItemsSaleDetailsBindingSource.DataMember = "ItemsSaleDetails"
        Me.ItemsSaleDetailsBindingSource.DataSource = Me.ItemsBindingSource
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.DBWoodDataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Location = New System.Drawing.Point(603, 191)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.Size = New System.Drawing.Size(85, 13)
        Customer_NameLabel.TabIndex = 32
        Customer_NameLabel.Text = "Customer Name:"
        '
        'Customer_NameComboBox
        '
        Me.Customer_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CustomersBindingSource, "Customer_Name", True))
        Me.Customer_NameComboBox.DataSource = Me.CustomersBindingSource
        Me.Customer_NameComboBox.DisplayMember = "Customer_Name"
        Me.Customer_NameComboBox.FormattingEnabled = True
        Me.Customer_NameComboBox.Location = New System.Drawing.Point(694, 188)
        Me.Customer_NameComboBox.Name = "Customer_NameComboBox"
        Me.Customer_NameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Customer_NameComboBox.TabIndex = 33
        '
        'IDLabel2
        '
        IDLabel2.AutoSize = True
        IDLabel2.Location = New System.Drawing.Point(667, 218)
        IDLabel2.Name = "IDLabel2"
        IDLabel2.Size = New System.Drawing.Size(21, 13)
        IDLabel2.TabIndex = 34
        IDLabel2.Text = "ID:"
        '
        'IDTextBox2
        '
        Me.IDTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "ID", True))
        Me.IDTextBox2.Location = New System.Drawing.Point(694, 215)
        Me.IDTextBox2.Name = "IDTextBox2"
        Me.IDTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox2.TabIndex = 35
        '
        'CustomersSalesBindingSource
        '
        Me.CustomersSalesBindingSource.DataMember = "CustomersSales"
        Me.CustomersSalesBindingSource.DataSource = Me.CustomersBindingSource
        '
        'CustomersSalesBindingSource1
        '
        Me.CustomersSalesBindingSource1.DataMember = "CustomersSales"
        Me.CustomersSalesBindingSource1.DataSource = Me.CustomersBindingSource
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(633, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 60)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(793, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 55)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmSellingScreen2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 596)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IDLabel2)
        Me.Controls.Add(Me.IDTextBox2)
        Me.Controls.Add(Customer_NameLabel)
        Me.Controls.Add(Me.Customer_NameComboBox)
        Me.Controls.Add(IDLabel1)
        Me.Controls.Add(Me.TxtItem_ID)
        Me.Controls.Add(Item_NameLabel)
        Me.Controls.Add(Me.Item_NameComboBox)
        Me.Controls.Add(StockLabel)
        Me.Controls.Add(Me.StockTextBox)
        Me.Controls.Add(Public_PriceLabel)
        Me.Controls.Add(Me.Public_PriceTextBox)
        Me.Controls.Add(Supplier_PriceLabel)
        Me.Controls.Add(Me.Supplier_PriceTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.TxtSale_ID)
        Me.Controls.Add(Sale_DateLabel)
        Me.Controls.Add(Me.Sale_DateDateTimePicker)
        Me.Controls.Add(Sale_TimeLabel)
        Me.Controls.Add(Me.Sale_TimeDateTimePicker)
        Me.Controls.Add(Cashier_IDLabel)
        Me.Controls.Add(Me.Cashier_IDTextBox)
        Me.Controls.Add(User_IDLabel)
        Me.Controls.Add(Me.User_IDTextBox)
        Me.Controls.Add(Customer_IDLabel)
        Me.Controls.Add(Me.Customer_IDTextBox)
        Me.Controls.Add(SubtotalLabel)
        Me.Controls.Add(Me.SubtotalTextBox)
        Me.Controls.Add(DiscountLabel)
        Me.Controls.Add(Me.DiscountTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(Me.SaleDetailsDataGridView)
        Me.Controls.Add(Me.SaleDetailsBindingNavigator)
        Me.Name = "FrmSellingScreen2"
        Me.Text = "FrmSellingScreen2"
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaleDetailsBindingNavigator.ResumeLayout(False)
        Me.SaleDetailsBindingNavigator.PerformLayout()
        CType(Me.SaleDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsSaleDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersSalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersSalesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBWoodDataSet As DBWoodDataSet
    Friend WithEvents TableAdapterManager As DBWoodDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SaleDetailsBindingSource As BindingSource
    Friend WithEvents SaleDetailsTableAdapter As DBWoodDataSetTableAdapters.SaleDetailsTableAdapter
    Friend WithEvents SaleDetailsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents SaleDetailsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SaleDetailsDataGridView As DataGridView
    Friend WithEvents TbcItem_Name As DataGridViewTextBoxColumn
    Friend WithEvents TbcQuantity As DataGridViewTextBoxColumn
    Friend WithEvents TbcPrice As DataGridViewTextBoxColumn
    Friend WithEvents TbcDiscount_Percentage As DataGridViewTextBoxColumn
    Friend WithEvents TbcDiscount_Value As DataGridViewTextBoxColumn
    Friend WithEvents TbcTotal_Price As DataGridViewTextBoxColumn
    Friend WithEvents TbcID As DataGridViewTextBoxColumn
    Friend WithEvents TbcSale_ID As DataGridViewTextBoxColumn
    Friend WithEvents TbcItem_ID As DataGridViewTextBoxColumn
    Friend WithEvents TbcSupplier_Price As DataGridViewTextBoxColumn
    Friend WithEvents SalesBindingSource As BindingSource
    Friend WithEvents SalesTableAdapter As DBWoodDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents TxtSale_ID As TextBox
    Friend WithEvents Sale_DateDateTimePicker As DateTimePicker
    Friend WithEvents Sale_TimeDateTimePicker As DateTimePicker
    Friend WithEvents Cashier_IDTextBox As TextBox
    Friend WithEvents User_IDTextBox As TextBox
    Friend WithEvents Customer_IDTextBox As TextBox
    Friend WithEvents SubtotalTextBox As TextBox
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As DBWoodDataSetTableAdapters.ItemsTableAdapter
    Friend WithEvents TxtItem_ID As TextBox
    Friend WithEvents Item_NameComboBox As ComboBox
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents Public_PriceTextBox As TextBox
    Friend WithEvents Supplier_PriceTextBox As TextBox
    Friend WithEvents ItemsSaleDetailsBindingSource As BindingSource
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As DBWoodDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents Customer_NameComboBox As ComboBox
    Friend WithEvents IDTextBox2 As TextBox
    Friend WithEvents CustomersSalesBindingSource As BindingSource
    Friend WithEvents CustomersSalesBindingSource1 As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
