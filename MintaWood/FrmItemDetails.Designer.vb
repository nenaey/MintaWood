<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemDetails
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
        Dim Item_NameLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim Public_PriceLabel As System.Windows.Forms.Label
        Dim Supplier_PriceLabel As System.Windows.Forms.Label
        Dim CubeLabel As System.Windows.Forms.Label
        Dim Workmanship_CostLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmItemDetails))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCubitization = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.DBWoodDataSet = New MintaWood.DBWoodDataSet()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.ItemsTableAdapter()
        Me.TableAdapterManager = New MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager()
        Me.ItemsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItemsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Item_NameTextBox = New System.Windows.Forms.TextBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.Public_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Supplier_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.CubeTextBox = New System.Windows.Forms.TextBox()
        Me.Workmanship_CostTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        IDLabel = New System.Windows.Forms.Label()
        Item_NameLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        Public_PriceLabel = New System.Windows.Forms.Label()
        Supplier_PriceLabel = New System.Windows.Forms.Label()
        CubeLabel = New System.Windows.Forms.Label()
        Workmanship_CostLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemsBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(136, 96)
        IDLabel.Name = "IDLabel"
        IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        IDLabel.Size = New System.Drawing.Size(87, 22)
        IDLabel.TabIndex = 12
        IDLabel.Text = "كود الصنف:"
        '
        'Item_NameLabel
        '
        Item_NameLabel.AutoSize = True
        Item_NameLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Item_NameLabel.Location = New System.Drawing.Point(719, 50)
        Item_NameLabel.Name = "Item_NameLabel"
        Item_NameLabel.Size = New System.Drawing.Size(80, 22)
        Item_NameLabel.TabIndex = 14
        Item_NameLabel.Text = "اسم الصنف"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StockLabel.Location = New System.Drawing.Point(721, 96)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(53, 22)
        StockLabel.TabIndex = 16
        StockLabel.Text = "الرصيد"
        '
        'Public_PriceLabel
        '
        Public_PriceLabel.AutoSize = True
        Public_PriceLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Public_PriceLabel.Location = New System.Drawing.Point(721, 145)
        Public_PriceLabel.Name = "Public_PriceLabel"
        Public_PriceLabel.Size = New System.Drawing.Size(94, 22)
        Public_PriceLabel.TabIndex = 18
        Public_PriceLabel.Text = "سعر الجمهور"
        '
        'Supplier_PriceLabel
        '
        Supplier_PriceLabel.AutoSize = True
        Supplier_PriceLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Supplier_PriceLabel.Location = New System.Drawing.Point(408, 95)
        Supplier_PriceLabel.Name = "Supplier_PriceLabel"
        Supplier_PriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Supplier_PriceLabel.Size = New System.Drawing.Size(89, 22)
        Supplier_PriceLabel.TabIndex = 20
        Supplier_PriceLabel.Text = "سعر المورد:"
        '
        'CubeLabel
        '
        CubeLabel.AutoSize = True
        CubeLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CubeLabel.Location = New System.Drawing.Point(408, 183)
        CubeLabel.Name = "CubeLabel"
        CubeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        CubeLabel.Size = New System.Drawing.Size(61, 22)
        CubeLabel.TabIndex = 21
        CubeLabel.Text = "التكعيب:"
        '
        'Workmanship_CostLabel
        '
        Workmanship_CostLabel.AutoSize = True
        Workmanship_CostLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Workmanship_CostLabel.Location = New System.Drawing.Point(408, 142)
        Workmanship_CostLabel.Name = "Workmanship_CostLabel"
        Workmanship_CostLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Workmanship_CostLabel.Size = New System.Drawing.Size(73, 22)
        Workmanship_CostLabel.TabIndex = 22
        Workmanship_CostLabel.Text = "المصنعية:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.BtnCubitization)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Location = New System.Drawing.Point(821, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 536)
        Me.Panel1.TabIndex = 11
        '
        'BtnCubitization
        '
        Me.BtnCubitization.Location = New System.Drawing.Point(16, 216)
        Me.BtnCubitization.Name = "BtnCubitization"
        Me.BtnCubitization.Size = New System.Drawing.Size(68, 61)
        Me.BtnCubitization.TabIndex = 3
        Me.BtnCubitization.Text = "تكعيب"
        Me.BtnCubitization.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(16, 115)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(68, 67)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "إزالة"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(16, 20)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(68, 61)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(16, 352)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(76, 58)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "غلق"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'DBWoodDataSet
        '
        Me.DBWoodDataSet.DataSetName = "DBWoodDataSet"
        Me.DBWoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CashierTableAdapter = Nothing
        Me.TableAdapterManager.CubitizationTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Me.ItemsTableAdapter
        Me.TableAdapterManager.MoneyTransactionsTableAdapter = Nothing
        Me.TableAdapterManager.PurchaseDetailsTableAdapter = Nothing
        Me.TableAdapterManager.PurchasesTableAdapter = Nothing
        Me.TableAdapterManager.SaleDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'ItemsBindingNavigator
        '
        Me.ItemsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ItemsBindingNavigator.BindingSource = Me.ItemsBindingSource
        Me.ItemsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ItemsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ItemsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ItemsBindingNavigatorSaveItem})
        Me.ItemsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ItemsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ItemsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ItemsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ItemsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ItemsBindingNavigator.Name = "ItemsBindingNavigator"
        Me.ItemsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ItemsBindingNavigator.Size = New System.Drawing.Size(924, 25)
        Me.ItemsBindingNavigator.TabIndex = 12
        Me.ItemsBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ItemsBindingNavigatorSaveItem
        '
        Me.ItemsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ItemsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ItemsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ItemsBindingNavigatorSaveItem.Name = "ItemsBindingNavigatorSaveItem"
        Me.ItemsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ItemsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(23, 92)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(107, 29)
        Me.IDTextBox.TabIndex = 13
        '
        'Item_NameTextBox
        '
        Me.Item_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Item_Name", True))
        Me.Item_NameTextBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item_NameTextBox.Location = New System.Drawing.Point(23, 47)
        Me.Item_NameTextBox.Name = "Item_NameTextBox"
        Me.Item_NameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Item_NameTextBox.Size = New System.Drawing.Size(678, 29)
        Me.Item_NameTextBox.TabIndex = 15
        Me.Item_NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StockTextBox
        '
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Stock", True))
        Me.StockTextBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockTextBox.Location = New System.Drawing.Point(601, 93)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(100, 29)
        Me.StockTextBox.TabIndex = 17
        Me.StockTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Public_PriceTextBox
        '
        Me.Public_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Public_Price", True))
        Me.Public_PriceTextBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Public_PriceTextBox.Location = New System.Drawing.Point(601, 142)
        Me.Public_PriceTextBox.Name = "Public_PriceTextBox"
        Me.Public_PriceTextBox.Size = New System.Drawing.Size(100, 29)
        Me.Public_PriceTextBox.TabIndex = 19
        Me.Public_PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Supplier_PriceTextBox
        '
        Me.Supplier_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Supplier_Price", True))
        Me.Supplier_PriceTextBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_PriceTextBox.Location = New System.Drawing.Point(302, 91)
        Me.Supplier_PriceTextBox.Name = "Supplier_PriceTextBox"
        Me.Supplier_PriceTextBox.Size = New System.Drawing.Size(100, 29)
        Me.Supplier_PriceTextBox.TabIndex = 21
        Me.Supplier_PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CubeTextBox
        '
        Me.CubeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Cube", True))
        Me.CubeTextBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CubeTextBox.Location = New System.Drawing.Point(302, 180)
        Me.CubeTextBox.Name = "CubeTextBox"
        Me.CubeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CubeTextBox.Size = New System.Drawing.Size(100, 29)
        Me.CubeTextBox.TabIndex = 22
        '
        'Workmanship_CostTextBox
        '
        Me.Workmanship_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Workmanship_Cost", True))
        Me.Workmanship_CostTextBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Workmanship_CostTextBox.Location = New System.Drawing.Point(302, 139)
        Me.Workmanship_CostTextBox.Name = "Workmanship_CostTextBox"
        Me.Workmanship_CostTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Workmanship_CostTextBox.Size = New System.Drawing.Size(100, 29)
        Me.Workmanship_CostTextBox.TabIndex = 23
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(23, 139)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 424)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'FrmItemDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(924, 567)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Workmanship_CostLabel)
        Me.Controls.Add(Me.Workmanship_CostTextBox)
        Me.Controls.Add(CubeLabel)
        Me.Controls.Add(Me.CubeTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Item_NameLabel)
        Me.Controls.Add(Me.Item_NameTextBox)
        Me.Controls.Add(StockLabel)
        Me.Controls.Add(Me.StockTextBox)
        Me.Controls.Add(Public_PriceLabel)
        Me.Controls.Add(Me.Public_PriceTextBox)
        Me.Controls.Add(Supplier_PriceLabel)
        Me.Controls.Add(Me.Supplier_PriceTextBox)
        Me.Controls.Add(Me.ItemsBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmItemDetails"
        Me.Text = "بيانات الصنف"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemsBindingNavigator.ResumeLayout(False)
        Me.ItemsBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents DBWoodDataSet As DBWoodDataSet
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As DBWoodDataSetTableAdapters.ItemsTableAdapter
    Friend WithEvents TableAdapterManager As DBWoodDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemsBindingNavigator As BindingNavigator
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
    Friend WithEvents ItemsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Item_NameTextBox As TextBox
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents Public_PriceTextBox As TextBox
    Friend WithEvents Supplier_PriceTextBox As TextBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnCubitization As Button
    Friend WithEvents CubeTextBox As TextBox
    Friend WithEvents Workmanship_CostTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
