<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMoneyTransactions
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
        Me.DBWoodDataSet = New MintaWood.DBWoodDataSet()
        Me.MoneyTransactionsQueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoneyTransactionsQueryTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.MoneyTransactionsQueryTableAdapter()
        Me.TableAdapterManager = New MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager()
        Me.MoneyTransactionsQueryDataGridView = New System.Windows.Forms.DataGridView()
        Me.TbcUser_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcTransaction_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcMoney = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcInOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBoxTransaction_Type = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyTransactionsQueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyTransactionsQueryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DBWoodDataSet
        '
        Me.DBWoodDataSet.DataSetName = "DBWoodDataSet"
        Me.DBWoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MoneyTransactionsQueryBindingSource
        '
        Me.MoneyTransactionsQueryBindingSource.DataMember = "MoneyTransactionsQuery"
        Me.MoneyTransactionsQueryBindingSource.DataSource = Me.DBWoodDataSet
        '
        'MoneyTransactionsQueryTableAdapter
        '
        Me.MoneyTransactionsQueryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CashierTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CubitizationTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.MoneyTransactionsTableAdapter = Nothing
        Me.TableAdapterManager.PurchaseDetailsTableAdapter = Nothing
        Me.TableAdapterManager.PurchasesTableAdapter = Nothing
        Me.TableAdapterManager.SaleDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'MoneyTransactionsQueryDataGridView
        '
        Me.MoneyTransactionsQueryDataGridView.AllowUserToAddRows = False
        Me.MoneyTransactionsQueryDataGridView.AutoGenerateColumns = False
        Me.MoneyTransactionsQueryDataGridView.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.MoneyTransactionsQueryDataGridView.ColumnHeadersHeight = 35
        Me.MoneyTransactionsQueryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TbcUser_Name, Me.TbcTransaction_Date, Me.TbcDescription, Me.TbcMoney, Me.TbcInOut, Me.TbcType, Me.TbcID})
        Me.MoneyTransactionsQueryDataGridView.DataSource = Me.MoneyTransactionsQueryBindingSource
        Me.MoneyTransactionsQueryDataGridView.Location = New System.Drawing.Point(3, 125)
        Me.MoneyTransactionsQueryDataGridView.Name = "MoneyTransactionsQueryDataGridView"
        Me.MoneyTransactionsQueryDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MoneyTransactionsQueryDataGridView.Size = New System.Drawing.Size(877, 319)
        Me.MoneyTransactionsQueryDataGridView.TabIndex = 1
        '
        'TbcUser_Name
        '
        Me.TbcUser_Name.DataPropertyName = "User_Name"
        Me.TbcUser_Name.HeaderText = "اسم المستخدم"
        Me.TbcUser_Name.Name = "TbcUser_Name"
        '
        'TbcTransaction_Date
        '
        Me.TbcTransaction_Date.DataPropertyName = "Transaction_Date"
        Me.TbcTransaction_Date.HeaderText = "التاريخ"
        Me.TbcTransaction_Date.Name = "TbcTransaction_Date"
        '
        'TbcDescription
        '
        Me.TbcDescription.DataPropertyName = "Description"
        Me.TbcDescription.HeaderText = "الوصف"
        Me.TbcDescription.Name = "TbcDescription"
        Me.TbcDescription.Width = 350
        '
        'TbcMoney
        '
        Me.TbcMoney.DataPropertyName = "Money"
        Me.TbcMoney.HeaderText = "القيمة النقدية"
        Me.TbcMoney.Name = "TbcMoney"
        '
        'TbcInOut
        '
        Me.TbcInOut.DataPropertyName = "InOut"
        Me.TbcInOut.HeaderText = "صادر / وارد"
        Me.TbcInOut.Name = "TbcInOut"
        '
        'TbcType
        '
        Me.TbcType.DataPropertyName = "Type"
        Me.TbcType.HeaderText = "النوع"
        Me.TbcType.Name = "TbcType"
        '
        'TbcID
        '
        Me.TbcID.DataPropertyName = "ID"
        Me.TbcID.HeaderText = "ID"
        Me.TbcID.Name = "TbcID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.ComboBoxTransaction_Type)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(877, 117)
        Me.Panel1.TabIndex = 2
        '
        'ComboBoxTransaction_Type
        '
        Me.ComboBoxTransaction_Type.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTransaction_Type.FormattingEnabled = True
        Me.ComboBoxTransaction_Type.Items.AddRange(New Object() {"مصروفات ثابتة", "محاسبة موردين", "شراء من محلات أخرى", "سحب قيمة نقدية", "إضافة قيمة نقدية", "أخذ قرض", "سداد قرض"})
        Me.ComboBoxTransaction_Type.Location = New System.Drawing.Point(277, 42)
        Me.ComboBoxTransaction_Type.Name = "ComboBoxTransaction_Type"
        Me.ComboBoxTransaction_Type.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBoxTransaction_Type.Size = New System.Drawing.Size(353, 27)
        Me.ComboBoxTransaction_Type.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Location = New System.Drawing.Point(3, 446)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(880, 123)
        Me.Panel2.TabIndex = 3
        '
        'FrmMoneyTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 566)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MoneyTransactionsQueryDataGridView)
        Me.Name = "FrmMoneyTransactions"
        Me.Text = "FrmMoneyTransactions"
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyTransactionsQueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyTransactionsQueryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DBWoodDataSet As DBWoodDataSet
    Friend WithEvents MoneyTransactionsQueryBindingSource As BindingSource
    Friend WithEvents MoneyTransactionsQueryTableAdapter As DBWoodDataSetTableAdapters.MoneyTransactionsQueryTableAdapter
    Friend WithEvents TableAdapterManager As DBWoodDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MoneyTransactionsQueryDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TbcUser_Name As DataGridViewTextBoxColumn
    Friend WithEvents TbcTransaction_Date As DataGridViewTextBoxColumn
    Friend WithEvents TbcDescription As DataGridViewTextBoxColumn
    Friend WithEvents TbcMoney As DataGridViewTextBoxColumn
    Friend WithEvents TbcInOut As DataGridViewTextBoxColumn
    Friend WithEvents TbcType As DataGridViewTextBoxColumn
    Friend WithEvents TbcID As DataGridViewTextBoxColumn
    Friend WithEvents ComboBoxTransaction_Type As ComboBox
End Class
