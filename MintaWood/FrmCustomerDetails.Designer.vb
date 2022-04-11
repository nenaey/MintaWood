<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomerDetails
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
        Dim Mobile1Label As System.Windows.Forms.Label
        Dim Mobile2Label As System.Windows.Forms.Label
        Dim Mobile3Label As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Customer_NameLabel As System.Windows.Forms.Label
        Me.DBWoodDataSet = New MintaWood.DBWoodDataSet()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New MintaWood.DBWoodDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Mobile1TextBox = New System.Windows.Forms.TextBox()
        Me.Mobile2TextBox = New System.Windows.Forms.TextBox()
        Me.Mobile3TextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnClose = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        Mobile1Label = New System.Windows.Forms.Label()
        Mobile2Label = New System.Windows.Forms.Label()
        Mobile3Label = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Customer_NameLabel = New System.Windows.Forms.Label()
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.Color.White
        IDLabel.Location = New System.Drawing.Point(104, 39)
        IDLabel.Name = "IDLabel"
        IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        IDLabel.Size = New System.Drawing.Size(69, 19)
        IDLabel.TabIndex = 1
        IDLabel.Text = "كود العميل:"
        '
        'Mobile1Label
        '
        Mobile1Label.AutoSize = True
        Mobile1Label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile1Label.Location = New System.Drawing.Point(685, 125)
        Mobile1Label.Name = "Mobile1Label"
        Mobile1Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Mobile1Label.Size = New System.Drawing.Size(94, 19)
        Mobile1Label.TabIndex = 5
        Mobile1Label.Text = "رقم المحمول 1:"
        '
        'Mobile2Label
        '
        Mobile2Label.AutoSize = True
        Mobile2Label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile2Label.Location = New System.Drawing.Point(685, 162)
        Mobile2Label.Name = "Mobile2Label"
        Mobile2Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Mobile2Label.Size = New System.Drawing.Size(94, 19)
        Mobile2Label.TabIndex = 7
        Mobile2Label.Text = "رقم المحمول 2:"
        '
        'Mobile3Label
        '
        Mobile3Label.AutoSize = True
        Mobile3Label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile3Label.Location = New System.Drawing.Point(685, 202)
        Mobile3Label.Name = "Mobile3Label"
        Mobile3Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Mobile3Label.Size = New System.Drawing.Size(94, 19)
        Mobile3Label.TabIndex = 9
        Mobile3Label.Text = "رقم المحمول 3:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelephoneLabel.Location = New System.Drawing.Point(327, 126)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        TelephoneLabel.Size = New System.Drawing.Size(48, 19)
        TelephoneLabel.TabIndex = 11
        TelephoneLabel.Text = "تليفون:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(327, 158)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        EmailLabel.Size = New System.Drawing.Size(104, 19)
        EmailLabel.TabIndex = 13
        EmailLabel.Text = "البريد الإليكتروني:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(689, 279)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        AddressLabel.Size = New System.Drawing.Size(53, 19)
        AddressLabel.TabIndex = 15
        AddressLabel.Text = "العنوان:"
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Customer_NameLabel.ForeColor = System.Drawing.Color.White
        Customer_NameLabel.Location = New System.Drawing.Point(696, 36)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Customer_NameLabel.Size = New System.Drawing.Size(94, 26)
        Customer_NameLabel.TabIndex = 16
        Customer_NameLabel.Text = "اسم العميل:"
        '
        'DBWoodDataSet
        '
        Me.DBWoodDataSet.DataSetName = "DBWoodDataSet"
        Me.DBWoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CashierTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.PurchaseDetailsTableAdapter = Nothing
        Me.TableAdapterManager.PurchasesTableAdapter = Nothing
        Me.TableAdapterManager.SaleDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MintaWood.DBWoodDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(3, 36)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(98, 26)
        Me.IDTextBox.TabIndex = 2
        '
        'Mobile1TextBox
        '
        Me.Mobile1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Mobile1", True))
        Me.Mobile1TextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile1TextBox.Location = New System.Drawing.Point(491, 122)
        Me.Mobile1TextBox.Name = "Mobile1TextBox"
        Me.Mobile1TextBox.Size = New System.Drawing.Size(192, 26)
        Me.Mobile1TextBox.TabIndex = 6
        '
        'Mobile2TextBox
        '
        Me.Mobile2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Mobile2", True))
        Me.Mobile2TextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile2TextBox.Location = New System.Drawing.Point(491, 159)
        Me.Mobile2TextBox.Name = "Mobile2TextBox"
        Me.Mobile2TextBox.Size = New System.Drawing.Size(192, 26)
        Me.Mobile2TextBox.TabIndex = 8
        '
        'Mobile3TextBox
        '
        Me.Mobile3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Mobile3", True))
        Me.Mobile3TextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile3TextBox.Location = New System.Drawing.Point(491, 199)
        Me.Mobile3TextBox.Name = "Mobile3TextBox"
        Me.Mobile3TextBox.Size = New System.Drawing.Size(192, 26)
        Me.Mobile3TextBox.TabIndex = 10
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Telephone", True))
        Me.TelephoneTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelephoneTextBox.Location = New System.Drawing.Point(128, 123)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(199, 26)
        Me.TelephoneTextBox.TabIndex = 12
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(12, 155)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(315, 26)
        Me.EmailTextBox.TabIndex = 14
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(32, 245)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AddressTextBox.Size = New System.Drawing.Size(651, 91)
        Me.AddressTextBox.TabIndex = 16
        '
        'Customer_NameTextBox
        '
        Me.Customer_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Customer_Name", True))
        Me.Customer_NameTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_NameTextBox.Location = New System.Drawing.Point(180, 33)
        Me.Customer_NameTextBox.Name = "Customer_NameTextBox"
        Me.Customer_NameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Customer_NameTextBox.Size = New System.Drawing.Size(508, 32)
        Me.Customer_NameTextBox.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Location = New System.Drawing.Point(0, 360)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 89)
        Me.Panel1.TabIndex = 18
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(210, 13)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 65)
        Me.BtnDelete.TabIndex = 1
        Me.BtnDelete.Text = "إزالة"
        Me.ToolTip1.SetToolTip(Me.BtnDelete, "إزالة")
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(703, 13)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 65)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "حفظ"
        Me.ToolTip1.SetToolTip(Me.BtnSave, "حفظ")
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Customer_NameLabel)
        Me.Panel2.Controls.Add(Me.Customer_NameTextBox)
        Me.Panel2.Controls.Add(IDLabel)
        Me.Panel2.Controls.Add(Me.IDTextBox)
        Me.Panel2.Location = New System.Drawing.Point(0, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(799, 100)
        Me.Panel2.TabIndex = 19
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Black
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(12, 13)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 65)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "غلق"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'FrmCustomerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Mobile1Label)
        Me.Controls.Add(Me.Mobile1TextBox)
        Me.Controls.Add(Mobile2Label)
        Me.Controls.Add(Me.Mobile2TextBox)
        Me.Controls.Add(Mobile3Label)
        Me.Controls.Add(Me.Mobile3TextBox)
        Me.Controls.Add(TelephoneLabel)
        Me.Controls.Add(Me.TelephoneTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Name = "FrmCustomerDetails"
        Me.Text = "بيانات العملاء"
        CType(Me.DBWoodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBWoodDataSet As DBWoodDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As DBWoodDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As DBWoodDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Mobile1TextBox As TextBox
    Friend WithEvents Mobile2TextBox As TextBox
    Friend WithEvents Mobile3TextBox As TextBox
    Friend WithEvents TelephoneTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Customer_NameTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSave As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnClose As Button
End Class
