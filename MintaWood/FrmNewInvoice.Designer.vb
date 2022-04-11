<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewInvoice
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
        Dim Purchase_DateLabel As System.Windows.Forms.Label
        Dim Purchase_TimeLabel As System.Windows.Forms.Label
        Dim Supplier_NameLabel As System.Windows.Forms.Label
        Dim Supplier_IDLabel As System.Windows.Forms.Label
        Dim User_IDLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim Sorts_CountLabel As System.Windows.Forms.Label
        Dim Items_CountLabel As System.Windows.Forms.Label
        Dim SubtotalLabel As System.Windows.Forms.Label
        Dim Discount_ValueLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim IDLabel1 As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim Public_PriceLabel As System.Windows.Forms.Label
        Dim Supplier_PriceLabel As System.Windows.Forms.Label
        Dim Item_NameLabel As System.Windows.Forms.Label
        Dim InvoiceNumberLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnFinish = New System.Windows.Forms.Button()
        Me.BtnTempoSave = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnAddNew = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.InvoiceNumberTextBox = New System.Windows.Forms.TextBox()
        Me.PurchasesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBWoodDataSet = New MintaWood.DBWoodDataSet()
        Me.User_IDTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Supplier_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Purchase_TimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Supplier_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Purchase_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.SubtotalTextBox = New System.Windows.Forms.TextBox()
        Me.Discount_ValueTextBox = New System.Windows.Forms.TextBox()
        Me.Items_CountTextBox = New System.Windows.Forms.TextBox()
        Me.Sorts_CountTextBox = New System.Windows.Forms.TextBox()
        Me.PurchasesTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.PurchasesTableAdapter()
        Me.TableAdapterManager = New MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager()
        Me.PurchaseDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseDetailsTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.PurchaseDetailsTableAdapter()
        Me.PurchaseDetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.TbcItem_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcItem_Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcSupplier_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcPublic_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcProfit_Percentage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcTotal_Supplier_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcItem_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcPurchase_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.ItemsTableAdapter()
        Me.TxtItem_ID = New System.Windows.Forms.TextBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.Public_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Supplier_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Item_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.ItemsSaleDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleDetailsTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.SaleDetailsTableAdapter()
        IDLabel = New System.Windows.Forms.Label()
        Purchase_DateLabel = New System.Windows.Forms.Label()
        Purchase_TimeLabel = New System.Windows.Forms.Label()
        Supplier_NameLabel = New System.Windows.Forms.Label()
        Supplier_IDLabel = New System.Windows.Forms.Label()
        User_IDLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Sorts_CountLabel = New System.Windows.Forms.Label()
        Items_CountLabel = New System.Windows.Forms.Label()
        SubtotalLabel = New System.Windows.Forms.Label()
        Discount_ValueLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        IDLabel1 = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        Public_PriceLabel = New System.Windows.Forms.Label()
        Supplier_PriceLabel = New System.Windows.Forms.Label()
        Item_NameLabel = New System.Windows.Forms.Label()
        InvoiceNumberLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PurchasesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PurchaseDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsSaleDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(977, 12)
        IDLabel.Name = "IDLabel"
        IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        IDLabel.Size = New System.Drawing.Size(77, 19)
        IDLabel.TabIndex = 4
        IDLabel.Text = "كود الفاتورة:"
        '
        'Purchase_DateLabel
        '
        Purchase_DateLabel.AutoSize = True
        Purchase_DateLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Purchase_DateLabel.Location = New System.Drawing.Point(977, 45)
        Purchase_DateLabel.Name = "Purchase_DateLabel"
        Purchase_DateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Purchase_DateLabel.Size = New System.Drawing.Size(87, 19)
        Purchase_DateLabel.TabIndex = 6
        Purchase_DateLabel.Text = "تاريخ الفاتورة:"
        '
        'Purchase_TimeLabel
        '
        Purchase_TimeLabel.AutoSize = True
        Purchase_TimeLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Purchase_TimeLabel.Location = New System.Drawing.Point(977, 77)
        Purchase_TimeLabel.Name = "Purchase_TimeLabel"
        Purchase_TimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Purchase_TimeLabel.Size = New System.Drawing.Size(81, 19)
        Purchase_TimeLabel.TabIndex = 8
        Purchase_TimeLabel.Text = "وقت الفاتورة:"
        '
        'Supplier_NameLabel
        '
        Supplier_NameLabel.AutoSize = True
        Supplier_NameLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Supplier_NameLabel.Location = New System.Drawing.Point(571, 15)
        Supplier_NameLabel.Name = "Supplier_NameLabel"
        Supplier_NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Supplier_NameLabel.Size = New System.Drawing.Size(73, 19)
        Supplier_NameLabel.TabIndex = 10
        Supplier_NameLabel.Text = "اسم المورد:"
        '
        'Supplier_IDLabel
        '
        Supplier_IDLabel.AutoSize = True
        Supplier_IDLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Supplier_IDLabel.Location = New System.Drawing.Point(571, 47)
        Supplier_IDLabel.Name = "Supplier_IDLabel"
        Supplier_IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Supplier_IDLabel.Size = New System.Drawing.Size(71, 19)
        Supplier_IDLabel.TabIndex = 12
        Supplier_IDLabel.Text = "كود المورد:"
        '
        'User_IDLabel
        '
        User_IDLabel.AutoSize = True
        User_IDLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_IDLabel.Location = New System.Drawing.Point(240, 15)
        User_IDLabel.Name = "User_IDLabel"
        User_IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        User_IDLabel.Size = New System.Drawing.Size(85, 19)
        User_IDLabel.TabIndex = 14
        User_IDLabel.Text = "كود المستخدم:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusLabel.Location = New System.Drawing.Point(240, 47)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        StatusLabel.Size = New System.Drawing.Size(82, 19)
        StatusLabel.TabIndex = 16
        StatusLabel.Text = "حالة الفاتورة:"
        '
        'Sorts_CountLabel
        '
        Sorts_CountLabel.AutoSize = True
        Sorts_CountLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sorts_CountLabel.Location = New System.Drawing.Point(970, 24)
        Sorts_CountLabel.Name = "Sorts_CountLabel"
        Sorts_CountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Sorts_CountLabel.Size = New System.Drawing.Size(82, 19)
        Sorts_CountLabel.TabIndex = 18
        Sorts_CountLabel.Text = "عدد الأصناف:"
        '
        'Items_CountLabel
        '
        Items_CountLabel.AutoSize = True
        Items_CountLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Items_CountLabel.Location = New System.Drawing.Point(970, 56)
        Items_CountLabel.Name = "Items_CountLabel"
        Items_CountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Items_CountLabel.Size = New System.Drawing.Size(67, 19)
        Items_CountLabel.TabIndex = 20
        Items_CountLabel.Text = "عدد القطع:"
        '
        'SubtotalLabel
        '
        SubtotalLabel.AutoSize = True
        SubtotalLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SubtotalLabel.Location = New System.Drawing.Point(634, 24)
        SubtotalLabel.Name = "SubtotalLabel"
        SubtotalLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        SubtotalLabel.Size = New System.Drawing.Size(95, 19)
        SubtotalLabel.TabIndex = 22
        SubtotalLabel.Text = "الإجمالي الأولي:"
        '
        'Discount_ValueLabel
        '
        Discount_ValueLabel.AutoSize = True
        Discount_ValueLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Discount_ValueLabel.Location = New System.Drawing.Point(634, 56)
        Discount_ValueLabel.Name = "Discount_ValueLabel"
        Discount_ValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Discount_ValueLabel.Size = New System.Drawing.Size(76, 19)
        Discount_ValueLabel.TabIndex = 24
        Discount_ValueLabel.Text = "قيمة الخصم:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalLabel.Location = New System.Drawing.Point(90, 12)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        TotalLabel.Size = New System.Drawing.Size(99, 19)
        TotalLabel.TabIndex = 26
        TotalLabel.Text = "الإجمالي النهائي:"
        '
        'IDLabel1
        '
        IDLabel1.AutoSize = True
        IDLabel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel1.Location = New System.Drawing.Point(245, 141)
        IDLabel1.Name = "IDLabel1"
        IDLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        IDLabel1.Size = New System.Drawing.Size(73, 19)
        IDLabel1.TabIndex = 4
        IDLabel1.Text = "كود الصنف:"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StockLabel.Location = New System.Drawing.Point(1079, 186)
        StockLabel.Name = "StockLabel"
        StockLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        StockLabel.Size = New System.Drawing.Size(89, 19)
        StockLabel.TabIndex = 8
        StockLabel.Text = "كمية المخزون:"
        '
        'Public_PriceLabel
        '
        Public_PriceLabel.AutoSize = True
        Public_PriceLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Public_PriceLabel.Location = New System.Drawing.Point(782, 186)
        Public_PriceLabel.Name = "Public_PriceLabel"
        Public_PriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Public_PriceLabel.Size = New System.Drawing.Size(86, 19)
        Public_PriceLabel.TabIndex = 10
        Public_PriceLabel.Text = "سعر الجمهور:"
        '
        'Supplier_PriceLabel
        '
        Supplier_PriceLabel.AutoSize = True
        Supplier_PriceLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Supplier_PriceLabel.Location = New System.Drawing.Point(487, 186)
        Supplier_PriceLabel.Name = "Supplier_PriceLabel"
        Supplier_PriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Supplier_PriceLabel.Size = New System.Drawing.Size(76, 19)
        Supplier_PriceLabel.TabIndex = 12
        Supplier_PriceLabel.Text = "سعر المورد:"
        '
        'Item_NameLabel
        '
        Item_NameLabel.AutoSize = True
        Item_NameLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Item_NameLabel.Location = New System.Drawing.Point(1080, 141)
        Item_NameLabel.Name = "Item_NameLabel"
        Item_NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Item_NameLabel.Size = New System.Drawing.Size(75, 19)
        Item_NameLabel.TabIndex = 13
        Item_NameLabel.Text = "اسم الصنف:"
        '
        'InvoiceNumberLabel
        '
        InvoiceNumberLabel.AutoSize = True
        InvoiceNumberLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        InvoiceNumberLabel.Location = New System.Drawing.Point(571, 82)
        InvoiceNumberLabel.Name = "InvoiceNumberLabel"
        InvoiceNumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        InvoiceNumberLabel.Size = New System.Drawing.Size(77, 19)
        InvoiceNumberLabel.TabIndex = 17
        InvoiceNumberLabel.Text = "رقم الفاتورة:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BtnFinish)
        Me.Panel1.Controls.Add(Me.BtnTempoSave)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.BtnAddNew)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 659)
        Me.Panel1.TabIndex = 0
        '
        'BtnFinish
        '
        Me.BtnFinish.Location = New System.Drawing.Point(13, 290)
        Me.BtnFinish.Name = "BtnFinish"
        Me.BtnFinish.Size = New System.Drawing.Size(84, 63)
        Me.BtnFinish.TabIndex = 3
        Me.BtnFinish.Text = "حفظ و إنهاء"
        Me.BtnFinish.UseVisualStyleBackColor = True
        '
        'BtnTempoSave
        '
        Me.BtnTempoSave.Location = New System.Drawing.Point(13, 194)
        Me.BtnTempoSave.Name = "BtnTempoSave"
        Me.BtnTempoSave.Size = New System.Drawing.Size(84, 68)
        Me.BtnTempoSave.TabIndex = 2
        Me.BtnTempoSave.Text = "حفظ مؤقت"
        Me.BtnTempoSave.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(13, 102)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(85, 70)
        Me.BtnDelete.TabIndex = 1
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Location = New System.Drawing.Point(13, 14)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(85, 71)
        Me.BtnAddNew.TabIndex = 0
        Me.BtnAddNew.Text = "إضافة"
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(InvoiceNumberLabel)
        Me.Panel2.Controls.Add(Me.InvoiceNumberTextBox)
        Me.Panel2.Controls.Add(User_IDLabel)
        Me.Panel2.Controls.Add(Supplier_NameLabel)
        Me.Panel2.Controls.Add(Me.User_IDTextBox)
        Me.Panel2.Controls.Add(StatusLabel)
        Me.Panel2.Controls.Add(IDLabel)
        Me.Panel2.Controls.Add(Me.StatusTextBox)
        Me.Panel2.Controls.Add(Me.Supplier_NameTextBox)
        Me.Panel2.Controls.Add(Me.Purchase_TimeDateTimePicker)
        Me.Panel2.Controls.Add(Supplier_IDLabel)
        Me.Panel2.Controls.Add(Me.IDTextBox)
        Me.Panel2.Controls.Add(Me.Supplier_IDTextBox)
        Me.Panel2.Controls.Add(Purchase_TimeLabel)
        Me.Panel2.Controls.Add(Purchase_DateLabel)
        Me.Panel2.Controls.Add(Me.Purchase_DateDateTimePicker)
        Me.Panel2.Location = New System.Drawing.Point(113, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1086, 124)
        Me.Panel2.TabIndex = 1
        '
        'InvoiceNumberTextBox
        '
        Me.InvoiceNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchasesBindingSource, "InvoiceNumber", True))
        Me.InvoiceNumberTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvoiceNumberTextBox.Location = New System.Drawing.Point(357, 79)
        Me.InvoiceNumberTextBox.Name = "InvoiceNumberTextBox"
        Me.InvoiceNumberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.InvoiceNumberTextBox.Size = New System.Drawing.Size(199, 26)
        Me.InvoiceNumberTextBox.TabIndex = 18
        '
        'PurchasesBindingSource
        '
        Me.PurchasesBindingSource.DataMember = "Purchases"
        Me.PurchasesBindingSource.DataSource = Me.DBWoodDataSet
        '
        'DBWoodDataSet
        '
        Me.DBWoodDataSet.DataSetName = "DBWoodDataSet"
        Me.DBWoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'User_IDTextBox
        '
        Me.User_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchasesBindingSource, "User_ID", True))
        Me.User_IDTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_IDTextBox.Location = New System.Drawing.Point(25, 15)
        Me.User_IDTextBox.Name = "User_IDTextBox"
        Me.User_IDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.User_IDTextBox.TabIndex = 15
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchasesBindingSource, "Status", True))
        Me.StatusTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusTextBox.Location = New System.Drawing.Point(25, 47)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 26)
        Me.StatusTextBox.TabIndex = 17
        '
        'Supplier_NameTextBox
        '
        Me.Supplier_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchasesBindingSource, "Supplier_Name", True))
        Me.Supplier_NameTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_NameTextBox.Location = New System.Drawing.Point(356, 15)
        Me.Supplier_NameTextBox.Name = "Supplier_NameTextBox"
        Me.Supplier_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Supplier_NameTextBox.TabIndex = 11
        '
        'Purchase_TimeDateTimePicker
        '
        Me.Purchase_TimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PurchasesBindingSource, "Purchase_Time", True))
        Me.Purchase_TimeDateTimePicker.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Purchase_TimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Purchase_TimeDateTimePicker.Location = New System.Drawing.Point(803, 76)
        Me.Purchase_TimeDateTimePicker.Name = "Purchase_TimeDateTimePicker"
        Me.Purchase_TimeDateTimePicker.Size = New System.Drawing.Size(159, 26)
        Me.Purchase_TimeDateTimePicker.TabIndex = 9
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchasesBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(762, 12)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.IDTextBox.TabIndex = 5
        '
        'Supplier_IDTextBox
        '
        Me.Supplier_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchasesBindingSource, "Supplier_ID", True))
        Me.Supplier_IDTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_IDTextBox.Location = New System.Drawing.Point(356, 47)
        Me.Supplier_IDTextBox.Name = "Supplier_IDTextBox"
        Me.Supplier_IDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Supplier_IDTextBox.TabIndex = 13
        '
        'Purchase_DateDateTimePicker
        '
        Me.Purchase_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PurchasesBindingSource, "Purchase_Date", True))
        Me.Purchase_DateDateTimePicker.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Purchase_DateDateTimePicker.Location = New System.Drawing.Point(654, 44)
        Me.Purchase_DateDateTimePicker.Name = "Purchase_DateDateTimePicker"
        Me.Purchase_DateDateTimePicker.Size = New System.Drawing.Size(308, 26)
        Me.Purchase_DateDateTimePicker.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TotalTextBox)
        Me.Panel3.Controls.Add(TotalLabel)
        Me.Panel3.Controls.Add(Me.SubtotalTextBox)
        Me.Panel3.Controls.Add(Me.Discount_ValueTextBox)
        Me.Panel3.Controls.Add(Discount_ValueLabel)
        Me.Panel3.Controls.Add(SubtotalLabel)
        Me.Panel3.Controls.Add(Me.Items_CountTextBox)
        Me.Panel3.Controls.Add(Items_CountLabel)
        Me.Panel3.Controls.Add(Me.Sorts_CountTextBox)
        Me.Panel3.Controls.Add(Sorts_CountLabel)
        Me.Panel3.Location = New System.Drawing.Point(113, 553)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1068, 104)
        Me.Panel3.TabIndex = 2
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchasesBindingSource, "Total", True))
        Me.TotalTextBox.Font = New System.Drawing.Font("Arial", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTextBox.Location = New System.Drawing.Point(26, 34)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(227, 57)
        Me.TotalTextBox.TabIndex = 27
        '
        'SubtotalTextBox
        '
        Me.SubtotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchasesBindingSource, "Subtotal", True))
        Me.SubtotalTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubtotalTextBox.Location = New System.Drawing.Point(419, 20)
        Me.SubtotalTextBox.Name = "SubtotalTextBox"
        Me.SubtotalTextBox.Size = New System.Drawing.Size(200, 26)
        Me.SubtotalTextBox.TabIndex = 23
        '
        'Discount_ValueTextBox
        '
        Me.Discount_ValueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchasesBindingSource, "Discount_Value", True))
        Me.Discount_ValueTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Discount_ValueTextBox.Location = New System.Drawing.Point(419, 56)
        Me.Discount_ValueTextBox.Name = "Discount_ValueTextBox"
        Me.Discount_ValueTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Discount_ValueTextBox.TabIndex = 25
        '
        'Items_CountTextBox
        '
        Me.Items_CountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchasesBindingSource, "Items_Count", True))
        Me.Items_CountTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Items_CountTextBox.Location = New System.Drawing.Point(755, 56)
        Me.Items_CountTextBox.Name = "Items_CountTextBox"
        Me.Items_CountTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Items_CountTextBox.TabIndex = 21
        '
        'Sorts_CountTextBox
        '
        Me.Sorts_CountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchasesBindingSource, "Sorts_Count", True))
        Me.Sorts_CountTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sorts_CountTextBox.Location = New System.Drawing.Point(755, 20)
        Me.Sorts_CountTextBox.Name = "Sorts_CountTextBox"
        Me.Sorts_CountTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Sorts_CountTextBox.TabIndex = 19
        '
        'PurchasesTableAdapter
        '
        Me.PurchasesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CashierTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.PurchaseDetailsTableAdapter = Nothing
        Me.TableAdapterManager.PurchasesTableAdapter = Me.PurchasesTableAdapter
        Me.TableAdapterManager.SaleDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'PurchaseDetailsBindingSource
        '
        Me.PurchaseDetailsBindingSource.DataMember = "PurchaseDetails"
        Me.PurchaseDetailsBindingSource.DataSource = Me.DBWoodDataSet
        '
        'PurchaseDetailsTableAdapter
        '
        Me.PurchaseDetailsTableAdapter.ClearBeforeFill = True
        '
        'PurchaseDetailsDataGridView
        '
        Me.PurchaseDetailsDataGridView.AllowUserToAddRows = False
        Me.PurchaseDetailsDataGridView.AllowUserToDeleteRows = False
        Me.PurchaseDetailsDataGridView.AutoGenerateColumns = False
        Me.PurchaseDetailsDataGridView.BackgroundColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PurchaseDetailsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PurchaseDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurchaseDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TbcItem_Name, Me.TbcItem_Quantity, Me.TbcSupplier_Price, Me.TbcPublic_Price, Me.TbcProfit_Percentage, Me.TbcTotal_Supplier_Price, Me.TbcItem_ID, Me.TbcPurchase_ID})
        Me.PurchaseDetailsDataGridView.DataSource = Me.PurchaseDetailsBindingSource
        Me.PurchaseDetailsDataGridView.Location = New System.Drawing.Point(119, 234)
        Me.PurchaseDetailsDataGridView.Name = "PurchaseDetailsDataGridView"
        Me.PurchaseDetailsDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PurchaseDetailsDataGridView.Size = New System.Drawing.Size(1061, 313)
        Me.PurchaseDetailsDataGridView.TabIndex = 3
        '
        'TbcItem_Name
        '
        Me.TbcItem_Name.DataPropertyName = "Item_Name"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbcItem_Name.DefaultCellStyle = DataGridViewCellStyle2
        Me.TbcItem_Name.HeaderText = "اسم الصنف"
        Me.TbcItem_Name.Name = "TbcItem_Name"
        Me.TbcItem_Name.Width = 450
        '
        'TbcItem_Quantity
        '
        Me.TbcItem_Quantity.DataPropertyName = "Item_Quantity"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbcItem_Quantity.DefaultCellStyle = DataGridViewCellStyle3
        Me.TbcItem_Quantity.HeaderText = "الكمية"
        Me.TbcItem_Quantity.Name = "TbcItem_Quantity"
        '
        'TbcSupplier_Price
        '
        Me.TbcSupplier_Price.DataPropertyName = "Supplier_Price"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbcSupplier_Price.DefaultCellStyle = DataGridViewCellStyle4
        Me.TbcSupplier_Price.HeaderText = "سعر المورد"
        Me.TbcSupplier_Price.Name = "TbcSupplier_Price"
        '
        'TbcPublic_Price
        '
        Me.TbcPublic_Price.DataPropertyName = "Public_Price"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.TbcPublic_Price.DefaultCellStyle = DataGridViewCellStyle5
        Me.TbcPublic_Price.HeaderText = "سعر الجمهور"
        Me.TbcPublic_Price.Name = "TbcPublic_Price"
        Me.TbcPublic_Price.Width = 120
        '
        'TbcProfit_Percentage
        '
        Me.TbcProfit_Percentage.DataPropertyName = "Profit_Percentage"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.TbcProfit_Percentage.DefaultCellStyle = DataGridViewCellStyle6
        Me.TbcProfit_Percentage.HeaderText = "نسبة هامش الربح"
        Me.TbcProfit_Percentage.Name = "TbcProfit_Percentage"
        Me.TbcProfit_Percentage.Width = 150
        '
        'TbcTotal_Supplier_Price
        '
        Me.TbcTotal_Supplier_Price.DataPropertyName = "Total_Supplier_Price"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TbcTotal_Supplier_Price.DefaultCellStyle = DataGridViewCellStyle7
        Me.TbcTotal_Supplier_Price.HeaderText = "إجمالي سعر المورد"
        Me.TbcTotal_Supplier_Price.Name = "TbcTotal_Supplier_Price"
        '
        'TbcItem_ID
        '
        Me.TbcItem_ID.DataPropertyName = "Item_ID"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbcItem_ID.DefaultCellStyle = DataGridViewCellStyle8
        Me.TbcItem_ID.HeaderText = "كود الصنف"
        Me.TbcItem_ID.Name = "TbcItem_ID"
        '
        'TbcPurchase_ID
        '
        Me.TbcPurchase_ID.DataPropertyName = "Purchase_ID"
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbcPurchase_ID.DefaultCellStyle = DataGridViewCellStyle9
        Me.TbcPurchase_ID.HeaderText = "كود الفاتورة"
        Me.TbcPurchase_ID.Name = "TbcPurchase_ID"
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
        'TxtItem_ID
        '
        Me.TxtItem_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "ID", True))
        Me.TxtItem_ID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItem_ID.Location = New System.Drawing.Point(139, 138)
        Me.TxtItem_ID.Name = "TxtItem_ID"
        Me.TxtItem_ID.Size = New System.Drawing.Size(100, 26)
        Me.TxtItem_ID.TabIndex = 5
        Me.TxtItem_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StockTextBox
        '
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Stock", True))
        Me.StockTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockTextBox.Location = New System.Drawing.Point(960, 182)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(100, 26)
        Me.StockTextBox.TabIndex = 9
        Me.StockTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Public_PriceTextBox
        '
        Me.Public_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Public_Price", True))
        Me.Public_PriceTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Public_PriceTextBox.Location = New System.Drawing.Point(676, 182)
        Me.Public_PriceTextBox.Name = "Public_PriceTextBox"
        Me.Public_PriceTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Public_PriceTextBox.TabIndex = 11
        Me.Public_PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Supplier_PriceTextBox
        '
        Me.Supplier_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Supplier_Price", True))
        Me.Supplier_PriceTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_PriceTextBox.Location = New System.Drawing.Point(346, 182)
        Me.Supplier_PriceTextBox.Name = "Supplier_PriceTextBox"
        Me.Supplier_PriceTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Supplier_PriceTextBox.TabIndex = 13
        Me.Supplier_PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Item_NameComboBox
        '
        Me.Item_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ItemsBindingSource, "Item_Name", True))
        Me.Item_NameComboBox.DataSource = Me.ItemsBindingSource
        Me.Item_NameComboBox.DisplayMember = "Item_Name"
        Me.Item_NameComboBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item_NameComboBox.FormattingEnabled = True
        Me.Item_NameComboBox.Location = New System.Drawing.Point(346, 138)
        Me.Item_NameComboBox.Name = "Item_NameComboBox"
        Me.Item_NameComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Item_NameComboBox.Size = New System.Drawing.Size(714, 27)
        Me.Item_NameComboBox.TabIndex = 14
        '
        'ItemsSaleDetailsBindingSource
        '
        Me.ItemsSaleDetailsBindingSource.DataMember = "ItemsSaleDetails"
        Me.ItemsSaleDetailsBindingSource.DataSource = Me.ItemsBindingSource
        '
        'SaleDetailsTableAdapter
        '
        Me.SaleDetailsTableAdapter.ClearBeforeFill = True
        '
        'FrmNewInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1199, 661)
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
        Me.Controls.Add(Me.PurchaseDetailsDataGridView)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmNewInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "فاتورة جديدة"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PurchasesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PurchaseDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsSaleDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DBWoodDataSet As DBWoodDataSet
    Friend WithEvents PurchasesBindingSource As BindingSource
    Friend WithEvents PurchasesTableAdapter As DBWoodDataSetTableAdapters.PurchasesTableAdapter
    Friend WithEvents TableAdapterManager As DBWoodDataSetTableAdapters.TableAdapterManager
    Friend WithEvents User_IDTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents Supplier_NameTextBox As TextBox
    Friend WithEvents Purchase_TimeDateTimePicker As DateTimePicker
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Supplier_IDTextBox As TextBox
    Friend WithEvents Purchase_DateDateTimePicker As DateTimePicker
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents SubtotalTextBox As TextBox
    Friend WithEvents Discount_ValueTextBox As TextBox
    Friend WithEvents Items_CountTextBox As TextBox
    Friend WithEvents Sorts_CountTextBox As TextBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnAddNew As Button
    Friend WithEvents BtnTempoSave As Button
    Friend WithEvents BtnFinish As Button
    Friend WithEvents PurchaseDetailsBindingSource As BindingSource
    Friend WithEvents PurchaseDetailsTableAdapter As DBWoodDataSetTableAdapters.PurchaseDetailsTableAdapter
    Friend WithEvents PurchaseDetailsDataGridView As DataGridView
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As DBWoodDataSetTableAdapters.ItemsTableAdapter
    Friend WithEvents TxtItem_ID As TextBox
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents Public_PriceTextBox As TextBox
    Friend WithEvents Supplier_PriceTextBox As TextBox
    Friend WithEvents Item_NameComboBox As ComboBox
    Friend WithEvents ItemsSaleDetailsBindingSource As BindingSource
    Friend WithEvents SaleDetailsTableAdapter As DBWoodDataSetTableAdapters.SaleDetailsTableAdapter
    Friend WithEvents TbcItem_Name As DataGridViewTextBoxColumn
    Friend WithEvents TbcItem_Quantity As DataGridViewTextBoxColumn
    Friend WithEvents TbcSupplier_Price As DataGridViewTextBoxColumn
    Friend WithEvents TbcPublic_Price As DataGridViewTextBoxColumn
    Friend WithEvents TbcProfit_Percentage As DataGridViewTextBoxColumn
    Friend WithEvents TbcTotal_Supplier_Price As DataGridViewTextBoxColumn
    Friend WithEvents TbcItem_ID As DataGridViewTextBoxColumn
    Friend WithEvents TbcPurchase_ID As DataGridViewTextBoxColumn
    Friend WithEvents InvoiceNumberTextBox As TextBox
End Class
