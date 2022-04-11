<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIndex
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
        Me.BtnCashier = New System.Windows.Forms.Button()
        Me.BtnItems = New System.Windows.Forms.Button()
        Me.BtnCustomers = New System.Windows.Forms.Button()
        Me.BtnSuppliers = New System.Windows.Forms.Button()
        Me.BtnMoneyMoving = New System.Windows.Forms.Button()
        Me.BtnSellingScreen = New System.Windows.Forms.Button()
        Me.LblItems = New System.Windows.Forms.Label()
        Me.LblCashier = New System.Windows.Forms.Label()
        Me.LblSuppliers = New System.Windows.Forms.Label()
        Me.LblCustomers = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PurchasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchasesInvoicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesInvoicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShiftsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.حركاتالنقودToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblSellingScreen = New System.Windows.Forms.Label()
        Me.LblMoneyMoving = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCashier
        '
        Me.BtnCashier.BackgroundImage = Global.MintaWood.My.Resources.Resources.LockedCashier
        Me.BtnCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCashier.Location = New System.Drawing.Point(671, 80)
        Me.BtnCashier.Name = "BtnCashier"
        Me.BtnCashier.Size = New System.Drawing.Size(268, 209)
        Me.BtnCashier.TabIndex = 0
        Me.BtnCashier.Tag = ""
        Me.BtnCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCashier.UseVisualStyleBackColor = True
        '
        'BtnItems
        '
        Me.BtnItems.BackgroundImage = Global.MintaWood.My.Resources.Resources.Items
        Me.BtnItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnItems.Location = New System.Drawing.Point(356, 81)
        Me.BtnItems.Name = "BtnItems"
        Me.BtnItems.Size = New System.Drawing.Size(268, 209)
        Me.BtnItems.TabIndex = 1
        Me.BtnItems.UseVisualStyleBackColor = True
        '
        'BtnCustomers
        '
        Me.BtnCustomers.BackgroundImage = Global.MintaWood.My.Resources.Resources.Customers
        Me.BtnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCustomers.Location = New System.Drawing.Point(48, 83)
        Me.BtnCustomers.Name = "BtnCustomers"
        Me.BtnCustomers.Size = New System.Drawing.Size(268, 209)
        Me.BtnCustomers.TabIndex = 2
        Me.BtnCustomers.UseVisualStyleBackColor = True
        '
        'BtnSuppliers
        '
        Me.BtnSuppliers.BackgroundImage = Global.MintaWood.My.Resources.Resources.Suppliers
        Me.BtnSuppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSuppliers.Location = New System.Drawing.Point(671, 317)
        Me.BtnSuppliers.Name = "BtnSuppliers"
        Me.BtnSuppliers.Size = New System.Drawing.Size(268, 209)
        Me.BtnSuppliers.TabIndex = 3
        Me.BtnSuppliers.UseVisualStyleBackColor = True
        '
        'BtnMoneyMoving
        '
        Me.BtnMoneyMoving.BackgroundImage = Global.MintaWood.My.Resources.Resources.Money
        Me.BtnMoneyMoving.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMoneyMoving.Location = New System.Drawing.Point(356, 317)
        Me.BtnMoneyMoving.Name = "BtnMoneyMoving"
        Me.BtnMoneyMoving.Size = New System.Drawing.Size(268, 209)
        Me.BtnMoneyMoving.TabIndex = 4
        Me.BtnMoneyMoving.UseVisualStyleBackColor = True
        '
        'BtnSellingScreen
        '
        Me.BtnSellingScreen.BackColor = System.Drawing.Color.White
        Me.BtnSellingScreen.BackgroundImage = Global.MintaWood.My.Resources.Resources.Screen
        Me.BtnSellingScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSellingScreen.Location = New System.Drawing.Point(48, 317)
        Me.BtnSellingScreen.Name = "BtnSellingScreen"
        Me.BtnSellingScreen.Size = New System.Drawing.Size(268, 209)
        Me.BtnSellingScreen.TabIndex = 5
        Me.BtnSellingScreen.UseVisualStyleBackColor = False
        '
        'LblItems
        '
        Me.LblItems.AutoSize = True
        Me.LblItems.BackColor = System.Drawing.Color.AntiqueWhite
        Me.LblItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblItems.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItems.Location = New System.Drawing.Point(430, 239)
        Me.LblItems.Name = "LblItems"
        Me.LblItems.Size = New System.Drawing.Size(124, 46)
        Me.LblItems.TabIndex = 6
        Me.LblItems.Text = "الأصناف"
        Me.LblItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblItems.Visible = False
        '
        'LblCashier
        '
        Me.LblCashier.AutoSize = True
        Me.LblCashier.BackColor = System.Drawing.Color.AntiqueWhite
        Me.LblCashier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCashier.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCashier.Location = New System.Drawing.Point(758, 239)
        Me.LblCashier.Name = "LblCashier"
        Me.LblCashier.Size = New System.Drawing.Size(109, 46)
        Me.LblCashier.TabIndex = 7
        Me.LblCashier.Text = "الخزينة"
        Me.LblCashier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblCashier.Visible = False
        '
        'LblSuppliers
        '
        Me.LblSuppliers.AutoSize = True
        Me.LblSuppliers.BackColor = System.Drawing.Color.AntiqueWhite
        Me.LblSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSuppliers.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSuppliers.Location = New System.Drawing.Point(731, 475)
        Me.LblSuppliers.Name = "LblSuppliers"
        Me.LblSuppliers.Size = New System.Drawing.Size(130, 46)
        Me.LblSuppliers.TabIndex = 8
        Me.LblSuppliers.Text = "الموردين"
        Me.LblSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblSuppliers.Visible = False
        '
        'LblCustomers
        '
        Me.LblCustomers.AutoSize = True
        Me.LblCustomers.BackColor = System.Drawing.Color.AntiqueWhite
        Me.LblCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCustomers.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomers.Location = New System.Drawing.Point(131, 239)
        Me.LblCustomers.Name = "LblCustomers"
        Me.LblCustomers.Size = New System.Drawing.Size(104, 46)
        Me.LblCustomers.TabIndex = 9
        Me.LblCustomers.Text = "العملاء"
        Me.LblCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblCustomers.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchasesToolStripMenuItem, Me.SalesToolStripMenuItem, Me.CashierToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PurchasesToolStripMenuItem
        '
        Me.PurchasesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchasesInvoicesToolStripMenuItem})
        Me.PurchasesToolStripMenuItem.Name = "PurchasesToolStripMenuItem"
        Me.PurchasesToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.PurchasesToolStripMenuItem.Text = "المشتريات"
        '
        'PurchasesInvoicesToolStripMenuItem
        '
        Me.PurchasesInvoicesToolStripMenuItem.Name = "PurchasesInvoicesToolStripMenuItem"
        Me.PurchasesInvoicesToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.PurchasesInvoicesToolStripMenuItem.Text = "فواتير المشتريات"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesInvoicesToolStripMenuItem, Me.SalesDetailsToolStripMenuItem})
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.SalesToolStripMenuItem.Text = "المبيعات"
        '
        'SalesInvoicesToolStripMenuItem
        '
        Me.SalesInvoicesToolStripMenuItem.Name = "SalesInvoicesToolStripMenuItem"
        Me.SalesInvoicesToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SalesInvoicesToolStripMenuItem.Text = "فواتير المبيعات"
        '
        'SalesDetailsToolStripMenuItem
        '
        Me.SalesDetailsToolStripMenuItem.Name = "SalesDetailsToolStripMenuItem"
        Me.SalesDetailsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SalesDetailsToolStripMenuItem.Text = "تفاصيل المبيعات"
        '
        'CashierToolStripMenuItem
        '
        Me.CashierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShiftsToolStripMenuItem, Me.حركاتالنقودToolStripMenuItem})
        Me.CashierToolStripMenuItem.Name = "CashierToolStripMenuItem"
        Me.CashierToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.CashierToolStripMenuItem.Text = "الخزينة"
        '
        'ShiftsToolStripMenuItem
        '
        Me.ShiftsToolStripMenuItem.Name = "ShiftsToolStripMenuItem"
        Me.ShiftsToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ShiftsToolStripMenuItem.Text = "الورديات"
        '
        'حركاتالنقودToolStripMenuItem
        '
        Me.حركاتالنقودToolStripMenuItem.Name = "حركاتالنقودToolStripMenuItem"
        Me.حركاتالنقودToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.حركاتالنقودToolStripMenuItem.Text = "حركات النقود"
        '
        'LblSellingScreen
        '
        Me.LblSellingScreen.AutoSize = True
        Me.LblSellingScreen.BackColor = System.Drawing.Color.AntiqueWhite
        Me.LblSellingScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSellingScreen.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSellingScreen.Location = New System.Drawing.Point(105, 473)
        Me.LblSellingScreen.Name = "LblSellingScreen"
        Me.LblSellingScreen.Size = New System.Drawing.Size(156, 46)
        Me.LblSellingScreen.TabIndex = 11
        Me.LblSellingScreen.Text = "شاشة البيع"
        Me.LblSellingScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblSellingScreen.Visible = False
        '
        'LblMoneyMoving
        '
        Me.LblMoneyMoving.AutoSize = True
        Me.LblMoneyMoving.BackColor = System.Drawing.Color.AntiqueWhite
        Me.LblMoneyMoving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMoneyMoving.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMoneyMoving.Location = New System.Drawing.Point(400, 473)
        Me.LblMoneyMoving.Name = "LblMoneyMoving"
        Me.LblMoneyMoving.Size = New System.Drawing.Size(182, 46)
        Me.LblMoneyMoving.TabIndex = 12
        Me.LblMoneyMoving.Text = "حركات النقود"
        Me.LblMoneyMoving.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblMoneyMoving.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(315, 564)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 36)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = Global.MintaWood.My.Resources.Resources.WoodBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblMoneyMoving)
        Me.Controls.Add(Me.LblSellingScreen)
        Me.Controls.Add(Me.LblCustomers)
        Me.Controls.Add(Me.LblSuppliers)
        Me.Controls.Add(Me.LblCashier)
        Me.Controls.Add(Me.LblItems)
        Me.Controls.Add(Me.BtnSellingScreen)
        Me.Controls.Add(Me.BtnMoneyMoving)
        Me.Controls.Add(Me.BtnSuppliers)
        Me.Controls.Add(Me.BtnCustomers)
        Me.Controls.Add(Me.BtnItems)
        Me.Controls.Add(Me.BtnCashier)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmIndex"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MintaWood"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCashier As Button
    Friend WithEvents BtnItems As Button
    Friend WithEvents BtnCustomers As Button
    Friend WithEvents BtnSuppliers As Button
    Friend WithEvents BtnMoneyMoving As Button
    Friend WithEvents BtnSellingScreen As Button
    Friend WithEvents LblItems As Label
    Friend WithEvents LblCashier As Label
    Friend WithEvents LblSuppliers As Label
    Friend WithEvents LblCustomers As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PurchasesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchasesInvoicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LblSellingScreen As Label
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesInvoicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LblMoneyMoving As Label
    Friend WithEvents CashierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShiftsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents حركاتالنقودToolStripMenuItem As ToolStripMenuItem
End Class
