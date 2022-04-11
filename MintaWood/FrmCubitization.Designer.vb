<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCubitization
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
        Dim Item_NameLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim CubeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCubitization))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DBWoodDataSet = New MintaWood.DBWoodDataSet()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.ItemsTableAdapter()
        Me.TableAdapterManager = New MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager()
        Me.CubitizationTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.CubitizationTableAdapter()
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
        Me.Item_NameTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.CubitizationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CubitizationDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.CubeTextBox = New System.Windows.Forms.TextBox()
        Me.TbcPart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcPartsCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcLength = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcWidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcThickness = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcTotalCube = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBCItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Item_NameLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        CubeLabel = New System.Windows.Forms.Label()
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemsBindingNavigator.SuspendLayout()
        CType(Me.CubitizationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CubitizationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Item_NameLabel
        '
        Item_NameLabel.AutoSize = True
        Item_NameLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Item_NameLabel.Location = New System.Drawing.Point(794, 49)
        Item_NameLabel.Name = "Item_NameLabel"
        Item_NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Item_NameLabel.Size = New System.Drawing.Size(75, 19)
        Item_NameLabel.TabIndex = 1
        Item_NameLabel.Text = "اسم الصنف:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(118, 50)
        IDLabel.Name = "IDLabel"
        IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        IDLabel.Size = New System.Drawing.Size(73, 19)
        IDLabel.TabIndex = 3
        IDLabel.Text = "كود الصنف:"
        '
        'CubeLabel
        '
        CubeLabel.AutoSize = True
        CubeLabel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CubeLabel.Location = New System.Drawing.Point(216, 441)
        CubeLabel.Name = "CubeLabel"
        CubeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        CubeLabel.Size = New System.Drawing.Size(88, 20)
        CubeLabel.TabIndex = 7
        CubeLabel.Text = "إجمالي التكعيب:"
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
        Me.TableAdapterManager.CubitizationTableAdapter = Me.CubitizationTableAdapter
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Me.ItemsTableAdapter
        Me.TableAdapterManager.PurchaseDetailsTableAdapter = Nothing
        Me.TableAdapterManager.PurchasesTableAdapter = Nothing
        Me.TableAdapterManager.SaleDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'CubitizationTableAdapter
        '
        Me.CubitizationTableAdapter.ClearBeforeFill = True
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
        Me.ItemsBindingNavigator.Size = New System.Drawing.Size(901, 25)
        Me.ItemsBindingNavigator.TabIndex = 0
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
        'Item_NameTextBox
        '
        Me.Item_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Item_Name", True))
        Me.Item_NameTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item_NameTextBox.Location = New System.Drawing.Point(197, 46)
        Me.Item_NameTextBox.Name = "Item_NameTextBox"
        Me.Item_NameTextBox.Size = New System.Drawing.Size(582, 26)
        Me.Item_NameTextBox.TabIndex = 2
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(14, 46)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IDTextBox.TabIndex = 4
        '
        'CubitizationBindingSource
        '
        Me.CubitizationBindingSource.DataMember = "Cubitization"
        Me.CubitizationBindingSource.DataSource = Me.DBWoodDataSet
        '
        'CubitizationDataGridView
        '
        Me.CubitizationDataGridView.AllowUserToAddRows = False
        Me.CubitizationDataGridView.AutoGenerateColumns = False
        Me.CubitizationDataGridView.BackgroundColor = System.Drawing.Color.LawnGreen
        Me.CubitizationDataGridView.ColumnHeadersHeight = 35
        Me.CubitizationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TbcPart, Me.TbcPartsCount, Me.TbcLength, Me.TbcWidth, Me.TbcThickness, Me.TbcTotalCube, Me.TBCItemID, Me.DataGridViewTextBoxColumn1})
        Me.CubitizationDataGridView.DataSource = Me.CubitizationBindingSource
        Me.CubitizationDataGridView.Location = New System.Drawing.Point(12, 90)
        Me.CubitizationDataGridView.Name = "CubitizationDataGridView"
        Me.CubitizationDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CubitizationDataGridView.Size = New System.Drawing.Size(767, 320)
        Me.CubitizationDataGridView.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.BtnAdd)
        Me.Panel1.Location = New System.Drawing.Point(785, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 394)
        Me.Panel1.TabIndex = 6
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(16, 220)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(88, 69)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(10, 120)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(94, 72)
        Me.BtnDelete.TabIndex = 1
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(10, 25)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(94, 69)
        Me.BtnAdd.TabIndex = 0
        Me.BtnAdd.Text = "إضافة"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'CubeTextBox
        '
        Me.CubeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Cube", True))
        Me.CubeTextBox.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CubeTextBox.Location = New System.Drawing.Point(99, 438)
        Me.CubeTextBox.Name = "CubeTextBox"
        Me.CubeTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CubeTextBox.TabIndex = 8
        '
        'TbcPart
        '
        Me.TbcPart.DataPropertyName = "Part"
        Me.TbcPart.HeaderText = "اسم الجزء"
        Me.TbcPart.Name = "TbcPart"
        '
        'TbcPartsCount
        '
        Me.TbcPartsCount.DataPropertyName = "Count"
        Me.TbcPartsCount.HeaderText = "عدد الأجزاء"
        Me.TbcPartsCount.Name = "TbcPartsCount"
        '
        'TbcLength
        '
        Me.TbcLength.DataPropertyName = "Length"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.TbcLength.DefaultCellStyle = DataGridViewCellStyle3
        Me.TbcLength.HeaderText = "الطول (سم)"
        Me.TbcLength.Name = "TbcLength"
        '
        'TbcWidth
        '
        Me.TbcWidth.DataPropertyName = "Width"
        Me.TbcWidth.HeaderText = "العرض (مم)"
        Me.TbcWidth.Name = "TbcWidth"
        '
        'TbcThickness
        '
        Me.TbcThickness.DataPropertyName = "Thickness"
        Me.TbcThickness.HeaderText = "السمك (مم)"
        Me.TbcThickness.Name = "TbcThickness"
        '
        'TbcTotalCube
        '
        Me.TbcTotalCube.DataPropertyName = "Total_Cube"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.TbcTotalCube.DefaultCellStyle = DataGridViewCellStyle4
        Me.TbcTotalCube.HeaderText = "الإجمالي"
        Me.TbcTotalCube.Name = "TbcTotalCube"
        '
        'TBCItemID
        '
        Me.TBCItemID.DataPropertyName = "Item_ID"
        Me.TBCItemID.HeaderText = "كود الصنف"
        Me.TBCItemID.Name = "TBCItemID"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'FrmCubitization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 486)
        Me.Controls.Add(CubeLabel)
        Me.Controls.Add(Me.CubeTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CubitizationDataGridView)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Item_NameLabel)
        Me.Controls.Add(Me.Item_NameTextBox)
        Me.Controls.Add(Me.ItemsBindingNavigator)
        Me.Name = "FrmCubitization"
        Me.Text = "التكعيب"
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemsBindingNavigator.ResumeLayout(False)
        Me.ItemsBindingNavigator.PerformLayout()
        CType(Me.CubitizationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CubitizationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents Item_NameTextBox As TextBox
    Friend WithEvents CubitizationTableAdapter As DBWoodDataSetTableAdapters.CubitizationTableAdapter
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents CubitizationBindingSource As BindingSource
    Friend WithEvents CubitizationDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents CubeTextBox As TextBox
    Friend WithEvents TbcPart As DataGridViewTextBoxColumn
    Friend WithEvents TbcPartsCount As DataGridViewTextBoxColumn
    Friend WithEvents TbcLength As DataGridViewTextBoxColumn
    Friend WithEvents TbcWidth As DataGridViewTextBoxColumn
    Friend WithEvents TbcThickness As DataGridViewTextBoxColumn
    Friend WithEvents TbcTotalCube As DataGridViewTextBoxColumn
    Friend WithEvents TBCItemID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
