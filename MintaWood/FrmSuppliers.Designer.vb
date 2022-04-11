<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSuppliers
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
        Dim Supplier_NameLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Me.DBWoodDataSet = New MintaWood.DBWoodDataSet()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppliersTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.SuppliersTableAdapter()
        Me.TableAdapterManager = New MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager()
        Me.Supplier_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnNewInvoice = New System.Windows.Forms.Button()
        Me.BtnDetails = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Supplier_NameLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Supplier_NameLabel
        '
        Supplier_NameLabel.AutoSize = True
        Supplier_NameLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Supplier_NameLabel.Location = New System.Drawing.Point(528, 51)
        Supplier_NameLabel.Name = "Supplier_NameLabel"
        Supplier_NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Supplier_NameLabel.Size = New System.Drawing.Size(73, 19)
        Supplier_NameLabel.TabIndex = 1
        Supplier_NameLabel.Text = "اسم المورد:"
        '
        'DBWoodDataSet
        '
        Me.DBWoodDataSet.DataSetName = "DBWoodDataSet"
        Me.DBWoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me.DBWoodDataSet
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CashierTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.PurchaseDetailsTableAdapter = Nothing
        Me.TableAdapterManager.PurchasesTableAdapter = Nothing
        Me.TableAdapterManager.SaleDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Me.SuppliersTableAdapter
        Me.TableAdapterManager.UpdateOrder = MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'Supplier_NameComboBox
        '
        Me.Supplier_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.SuppliersBindingSource, "Supplier_Name", True))
        Me.Supplier_NameComboBox.DataSource = Me.SuppliersBindingSource
        Me.Supplier_NameComboBox.DisplayMember = "Supplier_Name"
        Me.Supplier_NameComboBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_NameComboBox.FormattingEnabled = True
        Me.Supplier_NameComboBox.Location = New System.Drawing.Point(46, 48)
        Me.Supplier_NameComboBox.Name = "Supplier_NameComboBox"
        Me.Supplier_NameComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Supplier_NameComboBox.Size = New System.Drawing.Size(476, 27)
        Me.Supplier_NameComboBox.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.BtnNewInvoice)
        Me.Panel1.Controls.Add(Me.BtnDetails)
        Me.Panel1.Controls.Add(Me.BtnAdd)
        Me.Panel1.Location = New System.Drawing.Point(0, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(630, 91)
        Me.Panel1.TabIndex = 3
        '
        'BtnNewInvoice
        '
        Me.BtnNewInvoice.Location = New System.Drawing.Point(545, 13)
        Me.BtnNewInvoice.Name = "BtnNewInvoice"
        Me.BtnNewInvoice.Size = New System.Drawing.Size(75, 63)
        Me.BtnNewInvoice.TabIndex = 2
        Me.BtnNewInvoice.Text = "فاتورة جديدة"
        Me.BtnNewInvoice.UseVisualStyleBackColor = True
        '
        'BtnDetails
        '
        Me.BtnDetails.Location = New System.Drawing.Point(112, 15)
        Me.BtnDetails.Name = "BtnDetails"
        Me.BtnDetails.Size = New System.Drawing.Size(79, 63)
        Me.BtnDetails.TabIndex = 1
        Me.BtnDetails.Text = "بيانات المورد"
        Me.BtnDetails.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(12, 13)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 67)
        Me.BtnAdd.TabIndex = 0
        Me.BtnAdd.Text = "مورد جديد"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(241, 162)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 3
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(268, 159)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 4
        '
        'FrmSuppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 210)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Supplier_NameLabel)
        Me.Controls.Add(Me.Supplier_NameComboBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Name = "FrmSuppliers"
        Me.Text = "الموردين"
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBWoodDataSet As DBWoodDataSet
    Friend WithEvents SuppliersBindingSource As BindingSource
    Friend WithEvents SuppliersTableAdapter As DBWoodDataSetTableAdapters.SuppliersTableAdapter
    Friend WithEvents TableAdapterManager As DBWoodDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Supplier_NameComboBox As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnDetails As Button
    Friend WithEvents BtnNewInvoice As Button
    Friend WithEvents IDTextBox As TextBox
End Class
