<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplierDetails
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
        Dim CityLabel As System.Windows.Forms.Label
        Dim SpecialityLabel As System.Windows.Forms.Label
        Dim Telephone1Label As System.Windows.Forms.Label
        Dim Telephone2Label As System.Windows.Forms.Label
        Dim Telephone3Label As System.Windows.Forms.Label
        Dim Mobile1Label As System.Windows.Forms.Label
        Dim Mobile2Label As System.Windows.Forms.Label
        Dim Mobile3Label As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim Supplier_NameLabel As System.Windows.Forms.Label
        Me.DBWoodDataSet = New MintaWood.DBWoodDataSet()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppliersTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.SuppliersTableAdapter()
        Me.TableAdapterManager = New MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.SpecialityTextBox = New System.Windows.Forms.TextBox()
        Me.Telephone1TextBox = New System.Windows.Forms.TextBox()
        Me.Telephone2TextBox = New System.Windows.Forms.TextBox()
        Me.Telephone3TextBox = New System.Windows.Forms.TextBox()
        Me.Mobile1TextBox = New System.Windows.Forms.TextBox()
        Me.Mobile2TextBox = New System.Windows.Forms.TextBox()
        Me.Mobile3TextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.Supplier_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        SpecialityLabel = New System.Windows.Forms.Label()
        Telephone1Label = New System.Windows.Forms.Label()
        Telephone2Label = New System.Windows.Forms.Label()
        Telephone3Label = New System.Windows.Forms.Label()
        Mobile1Label = New System.Windows.Forms.Label()
        Mobile2Label = New System.Windows.Forms.Label()
        Mobile3Label = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        Supplier_NameLabel = New System.Windows.Forms.Label()
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(1, 75)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.Location = New System.Drawing.Point(555, 84)
        CityLabel.Name = "CityLabel"
        CityLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        CityLabel.Size = New System.Drawing.Size(50, 19)
        CityLabel.TabIndex = 5
        CityLabel.Text = "المدينة:"
        '
        'SpecialityLabel
        '
        SpecialityLabel.AutoSize = True
        SpecialityLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SpecialityLabel.Location = New System.Drawing.Point(243, 88)
        SpecialityLabel.Name = "SpecialityLabel"
        SpecialityLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        SpecialityLabel.Size = New System.Drawing.Size(64, 19)
        SpecialityLabel.TabIndex = 7
        SpecialityLabel.Text = "التخصص:"
        '
        'Telephone1Label
        '
        Telephone1Label.AutoSize = True
        Telephone1Label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telephone1Label.Location = New System.Drawing.Point(555, 145)
        Telephone1Label.Name = "Telephone1Label"
        Telephone1Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Telephone1Label.Size = New System.Drawing.Size(61, 19)
        Telephone1Label.TabIndex = 9
        Telephone1Label.Text = "تليفون 1:"
        '
        'Telephone2Label
        '
        Telephone2Label.AutoSize = True
        Telephone2Label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telephone2Label.Location = New System.Drawing.Point(555, 177)
        Telephone2Label.Name = "Telephone2Label"
        Telephone2Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Telephone2Label.Size = New System.Drawing.Size(61, 19)
        Telephone2Label.TabIndex = 11
        Telephone2Label.Text = "تليفون 2:"
        '
        'Telephone3Label
        '
        Telephone3Label.AutoSize = True
        Telephone3Label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telephone3Label.Location = New System.Drawing.Point(555, 209)
        Telephone3Label.Name = "Telephone3Label"
        Telephone3Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Telephone3Label.Size = New System.Drawing.Size(61, 19)
        Telephone3Label.TabIndex = 13
        Telephone3Label.Text = "تليفون 3:"
        '
        'Mobile1Label
        '
        Mobile1Label.AutoSize = True
        Mobile1Label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile1Label.Location = New System.Drawing.Point(243, 145)
        Mobile1Label.Name = "Mobile1Label"
        Mobile1Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Mobile1Label.Size = New System.Drawing.Size(61, 19)
        Mobile1Label.TabIndex = 15
        Mobile1Label.Text = "موبايل 1:"
        '
        'Mobile2Label
        '
        Mobile2Label.AutoSize = True
        Mobile2Label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile2Label.Location = New System.Drawing.Point(243, 177)
        Mobile2Label.Name = "Mobile2Label"
        Mobile2Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Mobile2Label.Size = New System.Drawing.Size(61, 19)
        Mobile2Label.TabIndex = 17
        Mobile2Label.Text = "موبايل 2:"
        '
        'Mobile3Label
        '
        Mobile3Label.AutoSize = True
        Mobile3Label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile3Label.Location = New System.Drawing.Point(243, 209)
        Mobile3Label.Name = "Mobile3Label"
        Mobile3Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Mobile3Label.Size = New System.Drawing.Size(61, 19)
        Mobile3Label.TabIndex = 19
        Mobile3Label.Text = "موبايل 3:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(601, 263)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        AddressLabel.Size = New System.Drawing.Size(53, 19)
        AddressLabel.TabIndex = 21
        AddressLabel.Text = "العنوان:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NotesLabel.Location = New System.Drawing.Point(601, 329)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        NotesLabel.Size = New System.Drawing.Size(61, 19)
        NotesLabel.TabIndex = 23
        NotesLabel.Text = "ملاحظات:"
        '
        'Supplier_NameLabel
        '
        Supplier_NameLabel.AutoSize = True
        Supplier_NameLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Supplier_NameLabel.ForeColor = System.Drawing.Color.LawnGreen
        Supplier_NameLabel.Location = New System.Drawing.Point(590, 18)
        Supplier_NameLabel.Name = "Supplier_NameLabel"
        Supplier_NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Supplier_NameLabel.Size = New System.Drawing.Size(85, 22)
        Supplier_NameLabel.TabIndex = 24
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
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(28, 72)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(57, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "City", True))
        Me.CityTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.Location = New System.Drawing.Point(428, 81)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CityTextBox.Size = New System.Drawing.Size(121, 26)
        Me.CityTextBox.TabIndex = 6
        '
        'SpecialityTextBox
        '
        Me.SpecialityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Speciality", True))
        Me.SpecialityTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialityTextBox.Location = New System.Drawing.Point(116, 85)
        Me.SpecialityTextBox.Name = "SpecialityTextBox"
        Me.SpecialityTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SpecialityTextBox.Size = New System.Drawing.Size(121, 26)
        Me.SpecialityTextBox.TabIndex = 8
        '
        'Telephone1TextBox
        '
        Me.Telephone1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Telephone1", True))
        Me.Telephone1TextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telephone1TextBox.Location = New System.Drawing.Point(370, 142)
        Me.Telephone1TextBox.Name = "Telephone1TextBox"
        Me.Telephone1TextBox.Size = New System.Drawing.Size(179, 26)
        Me.Telephone1TextBox.TabIndex = 10
        '
        'Telephone2TextBox
        '
        Me.Telephone2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Telephone2", True))
        Me.Telephone2TextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telephone2TextBox.Location = New System.Drawing.Point(370, 174)
        Me.Telephone2TextBox.Name = "Telephone2TextBox"
        Me.Telephone2TextBox.Size = New System.Drawing.Size(179, 26)
        Me.Telephone2TextBox.TabIndex = 12
        '
        'Telephone3TextBox
        '
        Me.Telephone3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Telephone3", True))
        Me.Telephone3TextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telephone3TextBox.Location = New System.Drawing.Point(370, 206)
        Me.Telephone3TextBox.Name = "Telephone3TextBox"
        Me.Telephone3TextBox.Size = New System.Drawing.Size(179, 26)
        Me.Telephone3TextBox.TabIndex = 14
        '
        'Mobile1TextBox
        '
        Me.Mobile1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Mobile1", True))
        Me.Mobile1TextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile1TextBox.Location = New System.Drawing.Point(50, 142)
        Me.Mobile1TextBox.Name = "Mobile1TextBox"
        Me.Mobile1TextBox.Size = New System.Drawing.Size(187, 26)
        Me.Mobile1TextBox.TabIndex = 16
        '
        'Mobile2TextBox
        '
        Me.Mobile2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Mobile2", True))
        Me.Mobile2TextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile2TextBox.Location = New System.Drawing.Point(50, 174)
        Me.Mobile2TextBox.Name = "Mobile2TextBox"
        Me.Mobile2TextBox.Size = New System.Drawing.Size(187, 26)
        Me.Mobile2TextBox.TabIndex = 18
        '
        'Mobile3TextBox
        '
        Me.Mobile3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Mobile3", True))
        Me.Mobile3TextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile3TextBox.Location = New System.Drawing.Point(50, 206)
        Me.Mobile3TextBox.Name = "Mobile3TextBox"
        Me.Mobile3TextBox.Size = New System.Drawing.Size(187, 26)
        Me.Mobile3TextBox.TabIndex = 20
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(41, 241)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AddressTextBox.Size = New System.Drawing.Size(554, 54)
        Me.AddressTextBox.TabIndex = 22
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Notes", True))
        Me.NotesTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotesTextBox.Location = New System.Drawing.Point(41, 301)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NotesTextBox.Size = New System.Drawing.Size(554, 74)
        Me.NotesTextBox.TabIndex = 24
        '
        'Supplier_NameTextBox
        '
        Me.Supplier_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Supplier_Name", True))
        Me.Supplier_NameTextBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_NameTextBox.Location = New System.Drawing.Point(18, 15)
        Me.Supplier_NameTextBox.Name = "Supplier_NameTextBox"
        Me.Supplier_NameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Supplier_NameTextBox.Size = New System.Drawing.Size(547, 29)
        Me.Supplier_NameTextBox.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.Supplier_NameTextBox)
        Me.Panel1.Controls.Add(Supplier_NameLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(708, 65)
        Me.Panel1.TabIndex = 26
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Indigo
        Me.Panel2.Controls.Add(Me.BtnDelete)
        Me.Panel2.Controls.Add(Me.BtnClose)
        Me.Panel2.Controls.Add(Me.BtnSave)
        Me.Panel2.Location = New System.Drawing.Point(0, 381)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(706, 81)
        Me.Panel2.TabIndex = 27
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(611, 8)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 65)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(18, 8)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 65)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "غلق"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(306, 8)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 65)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "إزالة"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'FrmSupplierDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 466)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(SpecialityLabel)
        Me.Controls.Add(Me.SpecialityTextBox)
        Me.Controls.Add(Telephone1Label)
        Me.Controls.Add(Me.Telephone1TextBox)
        Me.Controls.Add(Telephone2Label)
        Me.Controls.Add(Me.Telephone2TextBox)
        Me.Controls.Add(Telephone3Label)
        Me.Controls.Add(Me.Telephone3TextBox)
        Me.Controls.Add(Mobile1Label)
        Me.Controls.Add(Me.Mobile1TextBox)
        Me.Controls.Add(Mobile2Label)
        Me.Controls.Add(Me.Mobile2TextBox)
        Me.Controls.Add(Mobile3Label)
        Me.Controls.Add(Me.Mobile3TextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(NotesLabel)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Name = "FrmSupplierDetails"
        Me.Text = "FrmSupplierDetails"
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBWoodDataSet As DBWoodDataSet
    Friend WithEvents SuppliersBindingSource As BindingSource
    Friend WithEvents SuppliersTableAdapter As DBWoodDataSetTableAdapters.SuppliersTableAdapter
    Friend WithEvents TableAdapterManager As DBWoodDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents SpecialityTextBox As TextBox
    Friend WithEvents Telephone1TextBox As TextBox
    Friend WithEvents Telephone2TextBox As TextBox
    Friend WithEvents Telephone3TextBox As TextBox
    Friend WithEvents Mobile1TextBox As TextBox
    Friend WithEvents Mobile2TextBox As TextBox
    Friend WithEvents Mobile3TextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents NotesTextBox As TextBox
    Friend WithEvents Supplier_NameTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnDelete As Button
End Class
