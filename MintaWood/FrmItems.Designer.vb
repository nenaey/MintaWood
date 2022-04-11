<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmItems))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.DBWoodDataSet = New MintaWood.DBWoodDataSet()
        Me.TableAdapterManager = New MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager()
        Me.ItemsQueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsQueryTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.ItemsQueryTableAdapter()
        Me.ItemsQueryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ItemsQueryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ItemsQueryDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCapital = New System.Windows.Forms.TextBox()
        Me.TbcID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcItem_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcPublic_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcSupplier_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcTotal_Supplier_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsQueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsQueryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemsQueryBindingNavigator.SuspendLayout()
        CType(Me.ItemsQueryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.BtnCalculate)
        Me.Panel1.Controls.Add(Me.BtnRefresh)
        Me.Panel1.Controls.Add(Me.BtnNew)
        Me.Panel1.Controls.Add(Me.BtnOpen)
        Me.Panel1.Location = New System.Drawing.Point(794, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(104, 447)
        Me.Panel1.TabIndex = 2
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(15, 209)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(76, 72)
        Me.BtnCalculate.TabIndex = 3
        Me.BtnCalculate.Text = "احسب"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(15, 367)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(77, 70)
        Me.BtnRefresh.TabIndex = 2
        Me.BtnRefresh.Text = "تنشيط"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(12, 115)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(81, 73)
        Me.BtnNew.TabIndex = 1
        Me.BtnNew.Text = "صنف جديد"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnOpen
        '
        Me.BtnOpen.Location = New System.Drawing.Point(12, 25)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(82, 71)
        Me.BtnOpen.TabIndex = 0
        Me.BtnOpen.Text = "فتح"
        Me.BtnOpen.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.PurchaseDetailsTableAdapter = Nothing
        Me.TableAdapterManager.PurchasesTableAdapter = Nothing
        Me.TableAdapterManager.SaleDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'ItemsQueryBindingSource
        '
        Me.ItemsQueryBindingSource.DataMember = "ItemsQuery"
        Me.ItemsQueryBindingSource.DataSource = Me.DBWoodDataSet
        '
        'ItemsQueryTableAdapter
        '
        Me.ItemsQueryTableAdapter.ClearBeforeFill = True
        '
        'ItemsQueryBindingNavigator
        '
        Me.ItemsQueryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ItemsQueryBindingNavigator.BindingSource = Me.ItemsQueryBindingSource
        Me.ItemsQueryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ItemsQueryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ItemsQueryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ItemsQueryBindingNavigatorSaveItem})
        Me.ItemsQueryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ItemsQueryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ItemsQueryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ItemsQueryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ItemsQueryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ItemsQueryBindingNavigator.Name = "ItemsQueryBindingNavigator"
        Me.ItemsQueryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ItemsQueryBindingNavigator.Size = New System.Drawing.Size(900, 25)
        Me.ItemsQueryBindingNavigator.TabIndex = 3
        Me.ItemsQueryBindingNavigator.Text = "BindingNavigator1"
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
        'ItemsQueryBindingNavigatorSaveItem
        '
        Me.ItemsQueryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ItemsQueryBindingNavigatorSaveItem.Enabled = False
        Me.ItemsQueryBindingNavigatorSaveItem.Image = CType(resources.GetObject("ItemsQueryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ItemsQueryBindingNavigatorSaveItem.Name = "ItemsQueryBindingNavigatorSaveItem"
        Me.ItemsQueryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ItemsQueryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ItemsQueryDataGridView
        '
        Me.ItemsQueryDataGridView.AllowUserToAddRows = False
        Me.ItemsQueryDataGridView.AllowUserToDeleteRows = False
        Me.ItemsQueryDataGridView.AutoGenerateColumns = False
        Me.ItemsQueryDataGridView.BackgroundColor = System.Drawing.Color.Crimson
        Me.ItemsQueryDataGridView.ColumnHeadersHeight = 35
        Me.ItemsQueryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TbcID, Me.TbcItem_Name, Me.TbcStock, Me.TbcPublic_Price, Me.TbcSupplier_Price, Me.TbcTotal_Supplier_Price})
        Me.ItemsQueryDataGridView.DataSource = Me.ItemsQueryBindingSource
        Me.ItemsQueryDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.ItemsQueryDataGridView.Name = "ItemsQueryDataGridView"
        Me.ItemsQueryDataGridView.ReadOnly = True
        Me.ItemsQueryDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ItemsQueryDataGridView.RowHeadersWidth = 40
        Me.ItemsQueryDataGridView.Size = New System.Drawing.Size(788, 338)
        Me.ItemsQueryDataGridView.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TxtCapital)
        Me.Panel2.Location = New System.Drawing.Point(0, 372)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(788, 95)
        Me.Panel2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(652, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "إجمالي رأس المال"
        '
        'TxtCapital
        '
        Me.TxtCapital.Location = New System.Drawing.Point(629, 41)
        Me.TxtCapital.Name = "TxtCapital"
        Me.TxtCapital.Size = New System.Drawing.Size(142, 20)
        Me.TxtCapital.TabIndex = 0
        '
        'TbcID
        '
        Me.TbcID.DataPropertyName = "ID"
        Me.TbcID.HeaderText = "كود الصنف"
        Me.TbcID.Name = "TbcID"
        Me.TbcID.ReadOnly = True
        '
        'TbcItem_Name
        '
        Me.TbcItem_Name.DataPropertyName = "Item_Name"
        Me.TbcItem_Name.HeaderText = "اسم الصنف"
        Me.TbcItem_Name.Name = "TbcItem_Name"
        Me.TbcItem_Name.ReadOnly = True
        Me.TbcItem_Name.Width = 300
        '
        'TbcStock
        '
        Me.TbcStock.DataPropertyName = "Stock"
        Me.TbcStock.HeaderText = "المخزون"
        Me.TbcStock.Name = "TbcStock"
        Me.TbcStock.ReadOnly = True
        '
        'TbcPublic_Price
        '
        Me.TbcPublic_Price.DataPropertyName = "Public_Price"
        Me.TbcPublic_Price.HeaderText = "سعر الجمهور"
        Me.TbcPublic_Price.Name = "TbcPublic_Price"
        Me.TbcPublic_Price.ReadOnly = True
        '
        'TbcSupplier_Price
        '
        Me.TbcSupplier_Price.DataPropertyName = "Supplier_Price"
        Me.TbcSupplier_Price.HeaderText = "سعر المورد"
        Me.TbcSupplier_Price.Name = "TbcSupplier_Price"
        Me.TbcSupplier_Price.ReadOnly = True
        '
        'TbcTotal_Supplier_Price
        '
        Me.TbcTotal_Supplier_Price.DataPropertyName = "Total_Supplier_Price"
        Me.TbcTotal_Supplier_Price.HeaderText = "إجمالي سعر المورد"
        Me.TbcTotal_Supplier_Price.Name = "TbcTotal_Supplier_Price"
        Me.TbcTotal_Supplier_Price.ReadOnly = True
        Me.TbcTotal_Supplier_Price.Width = 150
        '
        'FrmItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 469)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ItemsQueryDataGridView)
        Me.Controls.Add(Me.ItemsQueryBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmItems"
        Me.Text = "الأصناف"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsQueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsQueryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemsQueryBindingNavigator.ResumeLayout(False)
        Me.ItemsQueryBindingNavigator.PerformLayout()
        CType(Me.ItemsQueryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBWoodDataSet As DBWoodDataSet
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnOpen As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents TableAdapterManager As DBWoodDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents ItemsQueryBindingSource As BindingSource
    Friend WithEvents ItemsQueryTableAdapter As DBWoodDataSetTableAdapters.ItemsQueryTableAdapter
    Friend WithEvents ItemsQueryBindingNavigator As BindingNavigator
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
    Friend WithEvents ItemsQueryBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ItemsQueryDataGridView As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtCapital As TextBox
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TbcID As DataGridViewTextBoxColumn
    Friend WithEvents TbcItem_Name As DataGridViewTextBoxColumn
    Friend WithEvents TbcStock As DataGridViewTextBoxColumn
    Friend WithEvents TbcPublic_Price As DataGridViewTextBoxColumn
    Friend WithEvents TbcSupplier_Price As DataGridViewTextBoxColumn
    Friend WithEvents TbcTotal_Supplier_Price As DataGridViewTextBoxColumn
End Class
