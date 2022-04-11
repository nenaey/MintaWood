<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSales
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
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.SalesTableAdapter()
        Me.TableAdapterManager = New MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.SalesQueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesQueryTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.SalesQueryTableAdapter()
        Me.SalesQueryDataGridView = New System.Windows.Forms.DataGridView()
        Me.TbcID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbcStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SalesQueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesQueryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBWoodDataSet
        '
        Me.DBWoodDataSet.DataSetName = "DBWoodDataSet"
        Me.DBWoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CashierTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.SaleDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Me.SalesTableAdapter
        Me.TableAdapterManager.UpdateOrder = MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.BtnOpen)
        Me.Panel1.Location = New System.Drawing.Point(801, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(102, 427)
        Me.Panel1.TabIndex = 2
        '
        'BtnOpen
        '
        Me.BtnOpen.Location = New System.Drawing.Point(14, 56)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(75, 68)
        Me.BtnOpen.TabIndex = 0
        Me.BtnOpen.Text = "فتح"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'SalesQueryBindingSource
        '
        Me.SalesQueryBindingSource.DataMember = "SalesQuery"
        Me.SalesQueryBindingSource.DataSource = Me.DBWoodDataSet
        '
        'SalesQueryTableAdapter
        '
        Me.SalesQueryTableAdapter.ClearBeforeFill = True
        '
        'SalesQueryDataGridView
        '
        Me.SalesQueryDataGridView.AllowUserToAddRows = False
        Me.SalesQueryDataGridView.AllowUserToDeleteRows = False
        Me.SalesQueryDataGridView.AutoGenerateColumns = False
        Me.SalesQueryDataGridView.BackgroundColor = System.Drawing.Color.Olive
        Me.SalesQueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesQueryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TbcID, Me.DataGridViewTextBoxColumn2, Me.TbcStatus, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.SalesQueryDataGridView.DataSource = Me.SalesQueryBindingSource
        Me.SalesQueryDataGridView.Location = New System.Drawing.Point(5, 69)
        Me.SalesQueryDataGridView.Name = "SalesQueryDataGridView"
        Me.SalesQueryDataGridView.ReadOnly = True
        Me.SalesQueryDataGridView.Size = New System.Drawing.Size(745, 220)
        Me.SalesQueryDataGridView.TabIndex = 2
        '
        'TbcID
        '
        Me.TbcID.DataPropertyName = "ID"
        Me.TbcID.HeaderText = "ID"
        Me.TbcID.Name = "TbcID"
        Me.TbcID.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Customer_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'TbcStatus
        '
        Me.TbcStatus.DataPropertyName = "Status"
        Me.TbcStatus.HeaderText = "Status"
        Me.TbcStatus.Name = "TbcStatus"
        Me.TbcStatus.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "User_Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "User_Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Sale_Date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Sale_Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Sale_Time"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Sale_Time"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'FrmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 467)
        Me.Controls.Add(Me.SalesQueryDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmSales"
        Me.Text = "عمليات البيع"
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.SalesQueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesQueryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DBWoodDataSet As DBWoodDataSet
    Friend WithEvents SalesBindingSource As BindingSource
    Friend WithEvents SalesTableAdapter As DBWoodDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents TableAdapterManager As DBWoodDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnOpen As Button
    Friend WithEvents SalesQueryBindingSource As BindingSource
    Friend WithEvents SalesQueryTableAdapter As DBWoodDataSetTableAdapters.SalesQueryTableAdapter
    Friend WithEvents SalesQueryDataGridView As DataGridView
    Friend WithEvents TbcID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TbcStatus As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
